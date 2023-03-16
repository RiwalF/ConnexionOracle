Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Visiteur_Consulter_compte_rendu
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myCommand2 As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    'Retire les espaces d'une chaine de caractère
    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function


    Private Sub Visiteur_Consulter_compte_rendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciation des Label en haut à droite
        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom

        'Connexion à la BDD
        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"
        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        'Récupération des dates de tous les Compte-Rendu
        ComboBoxDate.Items.Clear()
        Dim query As String = "SELECT DISTINCT CR_DATE
                                 FROM COMPTE_RENDU
                                 WHERE id ='" & id_utilisateur & "'
                                 ORDER BY to_date(CR_DATE) DESC"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Dim dt As New DataTable
        dt.Columns.Add("CR_DATE")

        For Each unItem In donnee.Rows
            dt.Rows.Add(RemoveWhitespace(unItem("CR_DATE")))
        Next

        Me.ComboBoxDate.DataSource = dt
        Me.ComboBoxDate.DisplayMember = "CR_DATE"
        donnee.Clear()

    End Sub

    'Rempli le ComboBoxCompteRendu en fonction de la date demandé
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDate.SelectedIndexChanged
        'SELECT les compte rendu en fonction de la date
        Dim query As String = "SELECT cr_id,CR_DATE,CR_MODIF
                                 FROM COMPTE_RENDU
                                 WHERE id ='" & id_utilisateur & "'
                                 AND CR_DATE LIKE '%" & ComboBoxDate.Text & "%'"


        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Dim dt As New DataTable
        dt.Columns.Add("cr_id")
        dt.Columns.Add("CR_MODIF")

        For Each unItem In donnee.Rows
            dt.Rows.Add(unItem("cr_id"), RemoveWhitespace(unItem("CR_MODIF")))
        Next

        Me.ComboBoxCompteRendu.DataSource = dt
        Me.ComboBoxCompteRendu.DisplayMember = "CR_MODIF"
        Me.ComboBoxCompteRendu.ValueMember = "cr_id"
        donnee.Clear()
    End Sub

    'Selectionne le compte-rendu cliqué
    Private Sub ComboBoxCompteRendu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCompteRendu.SelectedIndexChanged

        'Clear la listbox au cas ou des médicaments y serais déja ajouté
        Me.ListBoxMedicaments.Items.Clear()

        'SELECT les médicaments et leurs quantité associé au Compte-Rendu
        Dim query As String = "SELECT m_id,QUANTITE FROM QUANTITE WHERE cr_id ='" & ComboBoxCompteRendu.SelectedValue.ToString & "'"
        Dim id_liste As New List(Of String)
        Dim Quantite_liste As New List(Of String)
        Dim nom_liste As New List(Of String)
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            id_liste.Add(myReader.GetString(0))
            Quantite_liste.Add(RemoveWhitespace(myReader.GetString(1)))
        End While
        myReader.Close()



        'Boucle parcourant tous les médicaments associé au compte-rendu selectionné
        Dim item As Integer = id_liste.Count - 1
        For index As Integer = 0 To item
            Dim query2 = "SELECT M_NOM FROM Medicaments WHERE m_id ='" & id_liste(index) & "'"
            myCommand.Connection = myConnection
            myCommand.CommandText = query2
            myReader = myCommand.ExecuteReader
            While myReader.Read
                nom_liste.Add(myReader.GetString(0))
            End While
            myReader.Close()
            Me.ListBoxMedicaments.Items.Add(Quantite_liste(index) & " ==> " & nom_liste(index))
        Next


        'Récupère toutes les informations du compte rendu
        Dim selectnomCR As String = "SELECT CR_DATE,CR_MODIF,P_ID FROM Compte_Rendu WHERE cr_id = '" & ComboBoxCompteRendu.SelectedValue.ToString & "'"
        myCommand.Connection = myConnection
        myCommand.CommandText = selectnomCR
        myReader = myCommand.ExecuteReader
        Dim P_ID As String = ""
        While myReader.Read
            Try
                LabelDateAffiche.Text = myReader.GetString(0)
            Catch ex As Exception
                'bug
            End Try
            Try
                LabelMotifAffiche.Text = myReader.GetString(1)
            Catch ex As Exception
                'bug
            End Try
            Try
                P_ID = myReader.GetString(2)
            Catch ex As Exception
                'bug
            End Try
        End While
        myReader.Close()

        'Récupère le Nom et le Prénom du Praticien
        Dim SelectPraticien As String = "SELECT P_NOM,P_PRENOM FROM PRATICIEN WHERE P_ID = '" & P_ID & "'"
        myCommand.Connection = myConnection
        myCommand.CommandText = SelectPraticien
        myReader = myCommand.ExecuteReader
        While myReader.Read
            LabelPraticienAffiche.Text = myReader.GetString(0) & " " & myReader.GetString(1)
        End While
        myReader.Close()

    End Sub

    'Button permettant de revenir en arrière 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        If type_Utilisateur = "Responsable" Then
            Accueil_responsable.Show()
            Me.Close()
        ElseIf type_Utilisateur = "Delegue" Then
            Accueil_Delegue.Show()
            Me.Close()
        ElseIf type_Utilisateur = "Visiteur" Then
            Accueil_Visiteur.Show()
            Me.Close()
        Else
            type_Utilisateur = ""
            Form1.Show()
            Me.Close()
        End If
    End Sub

End Class