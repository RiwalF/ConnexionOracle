Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Public Class Form1

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim my2Connection As New Odbc.OdbcConnection
    Dim my2Command As New Odbc.OdbcCommand
    Dim my2Reader As Odbc.OdbcDataReader
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

        'CREATION DES MOT DE PASSE QUE L'ON AJOUTE AU INSERT LORSQUE L'ON SOUHAITE AJOUTER UN UTILISATEUR QUELCONQUE
        'Dim password As String = "Melon"
        'Dim sha256 As HashAlgorithm = sha256.Create()
        'Dim passwordBytes() As Byte = Encoding.ASCII.GetBytes(password)
        'Dim passwordHash() As Byte = sha256.ComputeHash(passwordBytes)
        'Dim passwordHashString As String = BitConverter.ToString(passwordHash).Replace("-", "")
        'Console.WriteLine(passwordHashString)

    End Sub


    Private Sub Connexio_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        'ATTENTION NE PAS OUBLIER DE SUPPRIMER
        If TextBox_username.Text = "ADMIN" Then
            If TextBox_MDP.Text = "RNSLAM2022" Then
                FormADMIN.Show()
                Me.Hide()
            End If
        End If

        Dim erreur_connexion As Integer = 0

        'HASHAGE DU MOT DE PASSE
        Dim password As String = TextBox_MDP.Text
        Dim sha256 As HashAlgorithm = sha256.Create()
        Dim passwordBytes() As Byte = Encoding.ASCII.GetBytes(password)
        Dim passwordHash() As Byte = sha256.ComputeHash(passwordBytes)
        Dim passwordHashString As String = BitConverter.ToString(passwordHash).Replace("-", "")

        Dim Responsable As String = "SELECT COUNT(*)
                                    FROM RESPONSABLE_SECTEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & passwordHashString & "'"
        Dim Visiteur As String = "SELECT COUNT(*)
                                    FROM DELEGUE_VISITEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & passwordHashString & "'
                                    AND DV_DELEGUE=0"
        Dim Delegue As String = "SELECT COUNT(*)
                                    FROM DELEGUE_VISITEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & passwordHashString & "'
                                    AND DV_DELEGUE=1"

        myCommand.Connection = myConnection
        myCommand.CommandText = Responsable
        myReader = myCommand.ExecuteReader


        While myReader.Read
            If (myReader.GetString(0)) = 1 Then
                type_Utilisateur = "Responsable"
                Dim commande As String = "SELECT NOM,ID
                                    FROM RESPONSABLE_SECTEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & passwordHashString & "'"
                my2Command.Connection = myConnection
                my2Command.CommandText = commande
                my2Reader = my2Command.ExecuteReader

                While my2Reader.Read
                    Nom = my2Reader.GetString(0)
                    id_utilisateur = my2Reader.GetString(1)
                End While
                my2Reader.Close()
                Prenom = TextBox_username.Text
                Accueil_responsable.Show()
                Me.Hide()
            Else
                erreur_connexion += 1
            End If
        End While
        myReader.Close()

        myCommand.Connection = myConnection
        myCommand.CommandText = Visiteur
        myReader = myCommand.ExecuteReader

        While myReader.Read
            If (myReader.GetString(0)) = 1 Then
                type_Utilisateur = "Visiteur"
                Dim commande As String = "SELECT NOM,ID
                                    FROM DELEGUE_VISITEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & passwordHashString & "'
                                    AND DV_DELEGUE=0"
                my2Command.Connection = myConnection
                my2Command.CommandText = commande
                my2Reader = my2Command.ExecuteReader

                While my2Reader.Read
                    Nom = my2Reader.GetString(0)
                    id_utilisateur = my2Reader.GetString(1)
                End While
                my2Reader.Close()
                Prenom = TextBox_username.Text
                Accueil_Visiteur.Show()
                Me.Hide()
            Else
                erreur_connexion += 1
            End If
        End While
        myReader.Close()

        myCommand.Connection = myConnection
        myCommand.CommandText = Delegue
        myReader = myCommand.ExecuteReader


        While myReader.Read
            If (myReader.GetString(0)) = 1 Then
                type_Utilisateur = "Delegue"
                Dim commande As String = "SELECT NOM,ID
                                    FROM DELEGUE_VISITEUR
                                    WHERE PRENOM='" & TextBox_username.Text & "'
                                    AND MDP='" & passwordHashString & "'
                                    AND DV_DELEGUE=1"
                my2Command.Connection = myConnection
                my2Command.CommandText = commande
                my2Reader = my2Command.ExecuteReader

                While my2Reader.Read
                    Nom = my2Reader.GetString(0)
                    id_utilisateur = my2Reader.GetString(1)
                End While
                my2Reader.Close()
                Prenom = TextBox_username.Text
                Accueil_Delegue.Show()
                Me.Hide()
            Else
                erreur_connexion += 1
            End If
        End While
        myReader.Close()

        If (erreur_connexion = 3) Then
            MessageBox.Show("Erreur : Identifiant ou Mot de Passe incorrect")
        End If


    End Sub

End Class