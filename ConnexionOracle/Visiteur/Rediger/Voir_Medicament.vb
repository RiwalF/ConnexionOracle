Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Voir_Medicament
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Private Sub Voir_Medicament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"
        myConnection.ConnectionString = connString
        myConnection.Open()


        Dim Commande_id_m As String = "SELECT M_id FROM Medicaments WHERE M_NOM ='" & nom_medicaments & "'"

        myCommand.Connection = myConnection
        myCommand.CommandText = Commande_id_m
        myReader = myCommand.ExecuteReader
        Dim text As String = ""
        While myReader.Read
            text = myReader.GetString(0)
        End While
        myReader.Close()


        Dim selectNomMedic As String = "SELECT * FROM medicaments WHERE M_id = '" & text & "'"
        myCommand.Connection = myConnection
        myCommand.CommandText = selectNomMedic
        myReader = myCommand.ExecuteReader
        While myReader.Read
            Label4.Text = myReader.GetString(1)
            Label5.Text = myReader.GetString(2)
            Label6.Text = myReader.GetString(3)
        End While
        myReader.Close()





    End Sub


End Class