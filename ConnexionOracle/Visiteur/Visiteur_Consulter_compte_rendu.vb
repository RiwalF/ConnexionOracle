Imports System.Data.Common
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Visiteur_Consulter_compte_rendu

    'Retire les espaces d'une chaine de caractère
    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function


    Private Sub Visiteur_Consulter_compte_rendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciation des Label en haut à droite
        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom

        'Récupération des dates de tous les Compte-Rendu
        ComboBoxDate.Items.Clear()
        Dim query As String = "SELECT DISTINCT CR_DATE
                                 FROM COMPTE_RENDU
                                 WHERE id ='" & id_utilisateur & "'
                                 ORDER BY to_date(CR_DATE) DESC"

        Dim dt_Date As New DataTable
        Form1.myAdapter = New Odbc.OdbcDataAdapter(query, Form1.myConnection)
        Form1.myAdapter.Fill(dt_Date)

        Me.ComboBoxDate.DataSource = dt_Date
        Me.ComboBoxDate.DisplayMember = "CR_DATE"

    End Sub

    'Rempli le ComboBoxCompteRendu en fonction de la date demandé
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDate.SelectedIndexChanged
        'SELECT les compte rendu en fonction de la date
        Dim query As String = "SELECT cr_id,CR_DATE,CR_MODIF
                                 FROM COMPTE_RENDU
                                 WHERE id ='" & id_utilisateur & "'
                                 AND CR_DATE LIKE '%" & ComboBoxDate.Text & "%'"

        Dim dt_CompteRendu As New DataTable
        Form1.myAdapter = New Odbc.OdbcDataAdapter(query, Form1.myConnection)
        Form1.myAdapter.Fill(dt_CompteRendu)

        Me.ComboBoxCompteRendu.DataSource = dt_CompteRendu
        Me.ComboBoxCompteRendu.DisplayMember = "CR_MODIF"
        Me.ComboBoxCompteRendu.ValueMember = "cr_id"
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
        Form1.myCommand.Connection = Form1.myConnection
        Form1.myCommand.CommandText = query
        Form1.myReader = Form1.myCommand.ExecuteReader

        While Form1.myReader.Read
            id_liste.Add(Form1.myReader.GetString(0))
            Quantite_liste.Add(RemoveWhitespace(Form1.myReader.GetString(1)))
        End While
        Form1.myReader.Close()



        'Boucle parcourant tous les médicaments associé au compte-rendu selectionné
        Dim item As Integer = id_liste.Count - 1
        For index As Integer = 0 To item
            Dim query2 = "SELECT M_NOM FROM Medicaments WHERE m_id ='" & id_liste(index) & "'"
            Form1.myCommand.Connection = Form1.myConnection
            Form1.myCommand.CommandText = query2
            Form1.myReader = Form1.myCommand.ExecuteReader
            While Form1.myReader.Read
                nom_liste.Add(Form1.myReader.GetString(0))
            End While
            Form1.myReader.Close()
            Me.ListBoxMedicaments.Items.Add(Quantite_liste(index) & " ==> " & nom_liste(index))
        Next


        'Récupère toutes les informations du compte rendu
        Dim selectnomCR As String = "SELECT CR_DATE,CR_MODIF,P_ID FROM Compte_Rendu WHERE cr_id = '" & ComboBoxCompteRendu.SelectedValue.ToString & "'"
        Form1.myCommand.Connection = Form1.myConnection
        Form1.myCommand.CommandText = selectnomCR
        Form1.myReader = Form1.myCommand.ExecuteReader
        Dim P_ID As String = ""
        While Form1.myReader.Read
            Try
                TextBoxDate.Text = Form1.myReader.GetString(0)
            Catch ex As Exception
                'bug
            End Try
            Try
                TextBoxMotifCR.Text = Form1.myReader.GetString(1)
            Catch ex As Exception
                'bug
            End Try
            Try
                P_ID = Form1.myReader.GetString(2)
            Catch ex As Exception
                'bug
            End Try
        End While
        Form1.myReader.Close()

        'Récupère le Nom et le Prénom du Praticien
        Dim SelectPraticien As String = "SELECT P_NOM,P_PRENOM FROM PRATICIEN WHERE P_ID = '" & P_ID & "'"
        Form1.myCommand.Connection = Form1.myConnection
        Form1.myCommand.CommandText = SelectPraticien
        Form1.myReader = Form1.myCommand.ExecuteReader
        While Form1.myReader.Read
            TextBoxPraticien.Text = RemoveWhitespace(Form1.myReader.GetString(0)) & " " & RemoveWhitespace(Form1.myReader.GetString(1))
        End While
        Form1.myReader.Close()

    End Sub


    'Véérifie que l'utilisateur souhaite réelement supprimer le compte-rendu et le supprime si oui
    Private Sub ButtonSupprimerCR_Click_1(sender As Object, e As EventArgs) Handles ButtonSupprimerCR.Click

        If MsgBox("Continuer ?", 36, "Confirmation") = vbYes Then
            Dim cmd As String = "DELETE FROM QUANTITE WHERE CR_ID = '" & ComboBoxCompteRendu.SelectedValue.ToString() & "';"
            Dim cmd2 As String = "DELETE FROM COMPTE_RENDU WHERE CR_ID = '" & ComboBoxCompteRendu.SelectedValue.ToString() & "';"

            Form1.myCommand.Connection = Form1.myConnection
            Form1.myCommand.CommandText = cmd
            Form1.myReader = Form1.myCommand.ExecuteReader
            Form1.myReader.Close()

            Form1.myCommand.Connection = Form1.myConnection
            Form1.myCommand.CommandText = cmd2
            Form1.myReader = Form1.myCommand.ExecuteReader
            Form1.myReader.Close()

            ComboBoxCompteRendu.Text = ""
            ComboBoxDate.Text = ""
            TextBoxDate.Text = ""
            TextBoxMotifCR.Text = ""
            TextBoxPraticien.Text = ""
            ListBoxMedicaments.ClearSelected()

            MessageBox.Show("Compte rendu supprimé")
        Else
            MessageBox.Show("Annulation de la suppression")
        End If
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