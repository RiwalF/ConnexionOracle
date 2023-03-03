
Imports System.Data.SqlTypes
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient

Public Class FormADMIN

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Connexion_Click(sender As Object, e As EventArgs) Handles Button_Connexion.Click

        'FERME DE SERVEUR
        'connString = "DSN=" & TextBox_DSN.Text & ";Uid=" & TextBox_Login.Text & ";Pwd=" & TextBox_MDP.Text & ";"
        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
            MessageBox.Show("Connexion Oracle Réussie")
            Dim query As String = "SELECT table_name FROM user_tables"
            myCommand.Connection = myConnection
            myCommand.CommandText = query
            myReader = myCommand.ExecuteReader
            While myReader.Read
                ComboBox_Tables.Items.Add(myReader.GetString(0))
            End While
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ComboBox_Tables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Tables.SelectedIndexChanged

        Dim table_name As String = ComboBox_Tables.SelectedItem.ToString()
        Dim query As String = "SELECT * FROM " & table_name
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridView_Tables.DataSource = donnee
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Valider_les_modifications.Click
        Dim changes As DataTable = donnee.GetChanges()
        Try
            myAdapter.Update(changes)
            donnee.AcceptChanges()
            MessageBox.Show("Modification réussie...")
        Catch ex As Odbc.OdbcException
            MessageBox.Show("Erreur de modification")
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button_to_CONNEXION.Click
        myConnection.Close()
        Form1.Show()
    End Sub


End Class
