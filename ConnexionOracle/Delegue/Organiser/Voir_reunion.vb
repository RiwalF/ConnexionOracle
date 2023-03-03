Imports System.Data.Common

Public Class Voir_reunion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myCommand2 As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Private Sub Voir_reunion_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"

        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom

        Dim query As String = "SELECT *
                                FROM reunion
                                WHERE r_id IN
                                    (
                                    SELECT reunion_dv.r_id
                                    FROM reunion_dv
                                    WHERE id ='" & id_utilisateur & "'
                                    )"
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridView_Tables.DataSource = donnee

        query = "SELECT r_id
                 FROM reunion
                 WHERE r_id IN
                 (
                 SELECT reunion_dv.r_id
                 FROM reunion_dv
                 WHERE id ='" & id_utilisateur & "'
                 )"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            Me.ComboBox1.Items.Add(myReader.GetString(0))
        End While

    End Sub
    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
        Delegue_Organiser_réunions_mensuelles.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()
        Dim id_selec As String = ComboBox1.SelectedItem
        Dim query2 As String = "SELECT NOM,PRENOM
                                FROM delegue_visiteur
                                WHERE id IN
                                    (
                                    SELECT reunion_dv.id
                                    FROM reunion_dv
                                    WHERE r_id ='" & id_selec & "'
                                    )"
        myCommand2.Connection = myConnection
        myCommand2.CommandText = query2
        myReader = myCommand2.ExecuteReader
        Dim text As String
        While myReader.Read
            text = myReader.GetString(0) & " " & myReader.GetString(1)
            Me.ListBox1.Items.Add(text)
        End While
        myReader.Close()
    End Sub

End Class