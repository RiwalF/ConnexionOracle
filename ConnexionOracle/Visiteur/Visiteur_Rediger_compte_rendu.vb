Imports System.EventArgs
Public Class Visiteur_Rediger_compte_rendu

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Dim id_M As New List(Of String)
    Dim id_M_Quantite As New List(Of Integer)

    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function

    Private Sub Rediger_compte_rendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Prenom.Text = Prenom
        Label_Nom.Text = Nom

        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"
        myConnection.ConnectionString = connString
        myConnection.Open()




        Dim selectNomMedic As String = "SELECT M_ID,M_NOM FROM medicaments"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(selectNomMedic, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Dim dt As New DataTable
        dt.Columns.Add("M_ID")
        dt.Columns.Add("M_NOM")

        For Each unItem In donnee.Rows
            dt.Rows.Add(unItem("M_ID"), unItem("M_NOM"))
        Next

        Me.ComboBox1.DataSource = dt
        Me.ComboBox1.DisplayMember = "M_NOM"
        Me.ComboBox1.ValueMember = "M_ID"
        donnee.Clear()


        Dim selectCoorPracticien As String = "SELECT P_ID,P_NOM,P_PRENOM,P_TYPE,P_CP,P_VILLE
                                              FROM PRATICIEN;"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(selectCoorPracticien, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Dim dt2 As New DataTable
        dt2.Columns.Add("P_ID")
        dt2.Columns.Add("P_NOM")

        For Each unItem In donnee.Rows
            dt2.Rows.Add(unItem("P_ID"), unItem("P_NOM"))
        Next

        Me.ComboBox2.DataSource = dt2
        Me.ComboBox2.DisplayMember = "P_NOM"
        Me.ComboBox2.ValueMember = "P_ID"
        donnee.Clear()

    End Sub




    'Obligé TextBox1 à accepter que des chiffres
    Private Sub TextBox1_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Commande_id_m As String = "SELECT M_id FROM Medicaments WHERE M_NOM ='" & ComboBox1.SelectedValue & "'"
        Dim test As Integer = 0


        For Each item As String In id_M
            If ComboBox1.SelectedValue = item Then
                test += 1
            End If
        Next
        If test = 0 Then
            id_M.Add(ComboBox1.SelectedValue)
            id_M_Quantite.Add(TextBox1.Text)
            Text = TextBox1.Text & " ==> " & ComboBox1.Text
            Me.ListBox1.Items.Add(Text)
        Else
            MessageBox.Show("ATTENTION 'Médicament déjà ajouté !'")
        End If


    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Date_CR As String = "VALUES(to_date('" & DateTimePicker1.Value.Date & "', 'DD/MM/YYYY'), 'column plutot')"

        'insertion du compte-rendu
        Dim insertCompteRendu As String = "INSERT INTO compte_rendu(cr_date, cr_modif,P_ID,ID) values (to_date('" & DateTimePicker1.Value.Date & "', 'DD/MM/YYYY'), '" & TextBox2.Text & "', '" & ComboBox2.SelectedValue & "', '" & id_utilisateur & "')"
        myCommand.Connection = myConnection
        myCommand.CommandText = insertCompteRendu
        myCommand.ExecuteNonQuery()


        'recuperation de l'id du dernier compte-rendu
        Dim plus_grand_id_CR As String = "SELECT cr_id FROM COMPTE_RENDU ORDER BY CAST(cr_id AS DECIMAL(5,2))"
        myCommand.Connection = myConnection
        myCommand.CommandText = plus_grand_id_CR
        myReader = myCommand.ExecuteReader
        Dim id_cr As String = ""
        While myReader.Read
            id_cr = myReader.GetString(0)
        End While
        myReader.Close()

        id_cr = RemoveWhitespace(id_cr)

        'Association des medicaments liés au compte-rendu
        Dim insertQuantiteCompteRendu As String = ""
        Dim item As Integer = id_M.Count - 1

        For index As Integer = 0 To item
            insertQuantiteCompteRendu = "INSERT INTO quantite(CR_ID, M_ID, QUANTITE) values ('" & id_cr & "','" & id_M(index) & "','" & id_M_Quantite(index) & "')"
            myCommand.Connection = myConnection
            myCommand.CommandText = insertQuantiteCompteRendu
            myCommand.ExecuteNonQuery()
        Next

        MessageBox.Show("Compte Rendu Réalisé")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nom_medicaments = ComboBox1.Text
        Voir_Medicament.Show()
    End Sub

    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
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