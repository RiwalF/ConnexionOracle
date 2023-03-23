Imports System.Data.Common

Public Class Creer_reunion
    Private Sub Creer_reunion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Prenom.Text = Prenom
        Label_Nom.Text = Nom

        'Liste des users
        Dim selectUser As String = "SELECT ID,NOM|| ' ' ||PRENOM As P_AFFICHE FROM delegue_visiteur order by NOM"
        Dim dt_Delegue_Visiteur As New DataTable
        Form1.myAdapter = New Odbc.OdbcDataAdapter(selectUser, Form1.myConnection)
        Form1.myAdapter.Fill(dt_Delegue_Visiteur)

        Me.ComboBox2.DataSource = dt_Delegue_Visiteur
        Me.ComboBox2.DisplayMember = "P_AFFICHE"
        Me.ComboBox2.ValueMember = "ID"

    End Sub
    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
        Delegue_Organiser_réunions_mensuelles.Show()
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Création de la réunion
        If TextBox1.Text = "" Then
            MsgBox("Vous n'avez pas donnez de lieu à votre réunion")
        Else
            Dim query3 As String = "INSERT INTO reunion(r_date,r_lieu) VALUES(to_date('" & DateTimePicker1.Value.Date & "', 'DD/MM/YYYY'),'" & TextBox1.Text & " ')"
            Form1.myCommand.Connection = Form1.myConnection
            Form1.myCommand.CommandText = query3
            Try
                Form1.myCommand.ExecuteNonQuery()
            Catch ex As Odbc.OdbcException
                MessageBox.Show(ex.Message)
            End Try


            'recuperation de l'id de la derniere reunion
            Dim plus_grand_id As String = "SELECT r_id FROM reunion ORDER BY CAST(r_id AS DECIMAL(5,2))"
            Form1.myCommand.Connection = Form1.myConnection
            Form1.myCommand.CommandText = plus_grand_id
            Try
                Form1.myReader = Form1.myCommand.ExecuteReader
            Catch ex As Odbc.OdbcException
                MessageBox.Show(ex.Message)
            End Try


            Dim id_reu As String = ""
            While Form1.myReader.Read
                id_reu = Form1.myReader.GetString(0)
            End While
            Form1.myReader.Close()

            'Association les membres de la réunion
            Dim item As Integer = Me.DataGridView1.RowCount - 2
            Dim id_membre As Integer

            'Boucle ajoutant chaque medicament et leur quantite
            For index As Integer = 0 To item
                id_membre = Me.DataGridView1.Rows.Item(index).Cells.Item(2).Value

                Dim insertMembreReunion As String = "INSERT INTO REUNION_DV(ID, R_ID) values ('" & id_membre & "','" & id_reu & "')"
                Form1.myCommand.Connection = Form1.myConnection
                Form1.myCommand.CommandText = insertMembreReunion
                Form1.myCommand.ExecuteNonQuery()
            Next

            MessageBox.Show("Réunion réalisé")

            'Sortie de la page 
            Delegue_Organiser_réunions_mensuelles.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim UserNom As String = ""
        Dim UserPrenom As String = ""

        Dim displayNomPrenom As String = "SELECT NOM, PRENOM FROM delegue_visiteur WHERE ID =" & ComboBox2.SelectedValue & ""

        Form1.myCommand.Connection = Form1.myConnection
        Form1.myCommand.CommandText = displayNomPrenom
        Form1.myReader = Form1.myCommand.ExecuteReader

        'Dim laCommande As String
        While Form1.myReader.Read
            UserNom = Form1.myReader.GetString(0)
            UserPrenom = Form1.myReader.GetString(1)
        End While
        Form1.myReader.Close()

        Dim NB_ligne_Datagrid As Integer = Me.DataGridView1.Rows.Count
        Dim nb_personne As Integer = -1
        Dim existe_pas As Boolean = True
        'Boucle comparant les médicaments déjà ajouté pour ne pas ajouter plusieurs fois le même médicament
        For i As Integer = 0 To NB_ligne_Datagrid - 1
            nb_personne += 1
            If ComboBox2.SelectedValue = Me.DataGridView1.Rows.Item(i).Cells.Item(2).Value Then
                existe_pas = False
            End If
        Next

        If existe_pas Then
            Me.DataGridView1.Rows.Add()
            Me.DataGridView1.Rows.Item(nb_personne).Cells.Item(0).Value = UserNom
            Me.DataGridView1.Rows.Item(nb_personne).Cells.Item(1).Value = UserPrenom
            Me.DataGridView1.Rows.Item(nb_personne).Cells.Item(2).Value = ComboBox2.SelectedValue
        Else
            MsgBox("Utilisateur déjà ajouté !", vbExclamation, "Erreur de saisie")
        End If
    End Sub

    'Permet de supprimer la ligne du médicaments sélectionné
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Vérifie que l'utilisateur ne supprime pas toutes les cases de la liste
        Dim x As Integer = Me.DataGridView1.CurrentRow.Index()
        Try
            Me.DataGridView1.Rows.RemoveAt(x)
        Catch ex As Exception
            MsgBox("Vous ne pouvez pas supprimer la dernière ligne", vbExclamation, "Erreur")
        End Try
    End Sub
End Class