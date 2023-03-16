Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Voir_Medicament
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim connString As String
    Private Sub Voir_Medicament_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connexion à la base
        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"
        myConnection.ConnectionString = connString
        myConnection.Open()

        'Récupération du médicaments
        Dim Commande_id_m As String = "SELECT * FROM Medicaments WHERE M_NOM ='" & nom_medicaments & "'"
        myCommand.Connection = myConnection
        myCommand.CommandText = Commande_id_m
        myReader = myCommand.ExecuteReader
        While myReader.Read
            LabelNomAffiche.Text = myReader.GetString(1)
            LabelEffetAffiche.Text = myReader.GetString(2)
            LabelFamilleAffiche.Text = myReader.GetString(3)
        End While
        myReader.Close()
    End Sub


End Class