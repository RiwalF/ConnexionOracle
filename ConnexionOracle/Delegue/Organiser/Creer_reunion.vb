Imports System.Data.Common

Public Class Creer_reunion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myCommand2 As New Odbc.OdbcCommand
    Dim myCommand3 As New Odbc.OdbcCommand
    Dim myCommand4 As New Odbc.OdbcCommand
    Dim myCommand5 As New Odbc.OdbcCommand
    Dim myCommand6 As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Dim id As New List(Of Integer)
    Dim test As New Integer
    Private Sub Creer_reunion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Prenom.Text = Prenom
        Label_Nom.Text = Nom
        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim selectDelegueVisiteur As String = "SELECT ID,NOM,PRENOM FROM delegue_visiteur"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(selectDelegueVisiteur, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Dim dt As New DataTable
        dt.Columns.Add("ID")
        dt.Columns.Add("NOM")

        For Each unItem In donnee.Rows
            dt.Rows.Add(unItem("ID"), unItem("NOM"))
        Next

        Me.ComboBox1.DataSource = dt
        Me.ComboBox1.DisplayMember = "NOM"
        Me.ComboBox1.ValueMember = "ID"
        donnee.Clear()








        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"

        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Dim query As String = "SELECT ID,NOM,PRENOM FROM delegue_visiteur"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridView1.DataSource = donnee

        query = "SELECT ID FROM delegue_visiteur"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            Me.ComboBox1.Items.Add(myReader(0))
        End While
    End Sub
    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
        Delegue_Organiser_réunions_mensuelles.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query2 As String = "SELECT NOM,PRENOM FROM delegue_visiteur WHERE id ='" & ComboBox1.SelectedItem & "'"

        test = 0
        For Each item As Integer In id
            If ComboBox1.SelectedItem = item Then
                test += 1
            End If
        Next

        If test = 0 Then
            id.Add(ComboBox1.SelectedItem)
            myCommand2.Connection = myConnection
            myCommand2.CommandText = query2
            myReader = myCommand2.ExecuteReader
            Dim text As String
            While myReader.Read
                text = myReader.GetString(0) & " " & myReader.GetString(1)
                Me.ListBox1.Items.Add(text)
            End While
        Else
            MessageBox.Show("ATTENTION 'Utilisateur déjà ajouté !'")
        End If

        myReader.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Création de la réunion
        Dim query3 As String = "INSERT INTO reunion(r_date,r_lieu) VALUES(to_date('" & DateTimePicker1.Value.Date & "', 'DD/MM/YYYY'),'" & TextBox1.Text & " ')"
        Dim Error_commande As Integer
        myCommand3.Connection = myConnection
        myCommand3.CommandText = query3
        Try
            myCommand3.ExecuteNonQuery()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
            Error_commande += 1
        End Try


        'recuperation de l'id de la derniere reunion
        Dim plus_grand_id As String = "SELECT r_id FROM reunion ORDER BY CAST(r_id AS DECIMAL(5,2))"
        myCommand4.Connection = myConnection
        myCommand4.CommandText = plus_grand_id
        Try
            myReader = myCommand4.ExecuteReader
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
            Error_commande += 1
        End Try


        Dim id_reu As String = ""
        While myReader.Read
            id_reu = myReader.GetString(0)
        End While
        myReader.Close()

        'Association des personnes liés à la réunion 
        Dim query4 As String = ""
        For Each item As Integer In id
            query4 = "Insert into reunion_dv(id,r_id) Values('" & item & "','" & id_reu & "')"
            myCommand5.Connection = myConnection
            myCommand5.CommandText = query4
            Try
                myCommand5.ExecuteNonQuery()
            Catch ex As Odbc.OdbcException
                MessageBox.Show(ex.Message)
                Error_commande += 1
            End Try
        Next


        If Error_commande = 0 Then
            Delegue_Organiser_réunions_mensuelles.Show()
            Me.Close()
            MessageBox.Show("Réunion réalisé")
        Else
            MessageBox.Show("Erreur de réalisation")
        End If

    End Sub

End Class