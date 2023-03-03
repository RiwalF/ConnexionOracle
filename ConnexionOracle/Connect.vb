Imports System.Security.Cryptography.X509Certificates

Public Class Connect

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String


    Private Sub Connect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FERME DE SERVEUR
        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub Connexio_Click(sender As Object, e As EventArgs) Handles Button_Login.Click

        Dim Responsable As String = "SELECT COUNT(*)
                                    FROM RESPONSABLE_SECTEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & TextBox_MDP.Text & "'"
        Dim Visiteur As String = "SELECT COUNT(*)
                                    FROM DELEGUE_VISITEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & TextBox_MDP.Text & "'
                                    AND DV_DELEGUE=0"
        Dim Delegue As String = "SELECT COUNT(*)
                                    FROM DELEGUE_VISITEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & TextBox_MDP.Text & "'
                                    AND DV_DELEGUE=1"

        myCommand.Connection = myConnection
        myCommand.CommandText = Responsable
        myReader = myCommand.ExecuteReader

        While myReader.Read
            If (myReader.GetString(0)) = 1 Then
                Accueil_responsable.Show()
                Me.Close()
            End If
        End While
        myReader.Close()

        myCommand.Connection = myConnection
        myCommand.CommandText = Visiteur
        myReader = myCommand.ExecuteReader

        While myReader.Read
            If (myReader.GetString(0)) = 1 Then
                Accueil_Visiteur.Show()
                Me.Close()
            End If
        End While
        myReader.Close()

        myCommand.Connection = myConnection
        myCommand.CommandText = Delegue
        myReader = myCommand.ExecuteReader


        While myReader.Read
            If (myReader.GetString(0)) = 1 Then
                Accueil_Delegue.Show()
                Me.Close()
            End If
        End While
        myReader.Close()

    End Sub

End Class