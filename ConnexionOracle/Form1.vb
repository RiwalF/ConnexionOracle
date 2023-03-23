Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Public Class Form1

    Public myConnection As New Odbc.OdbcConnection
    Public myCommand As New Odbc.OdbcCommand
    Public myReader As Odbc.OdbcDataReader
    Public myAdapter As Odbc.OdbcDataAdapter
    Dim my2Command As New Odbc.OdbcCommand
    Dim my2Reader As Odbc.OdbcDataReader


    Private Sub Connect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connexion au serveur SQL
        Dim connString As String = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"
        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        'CREATION DES MOT DE PASSE QUE L'ON AJOUTE AU INSERT LORSQUE L'ON SOUHAITE AJOUTER UN UTILISATEUR QUELCONQUE
        'Dim password As String = "Elegall"
        'Dim sha256 As HashAlgorithm = sha256.Create()
        'Dim passwordBytes() As Byte = Encoding.ASCII.GetBytes(password)
        'Dim passwordHash() As Byte = SHA256.ComputeHash(passwordBytes)
        'Dim passwordHashString As String = BitConverter.ToString(passwordHash).Replace("-", "")
        'Console.WriteLine(passwordHashString)

    End Sub


    Private Sub Connexion_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Dim erreur_connexion As Integer = 0

        'HASHAGE DU MOT DE PASSE
        Dim password As String = TextBoxPassword.Text
        Dim sha256 As HashAlgorithm = sha256.Create()
        Dim passwordBytes() As Byte = Encoding.ASCII.GetBytes(password)
        Dim passwordHash() As Byte = sha256.ComputeHash(passwordBytes)
        Dim passwordHashString As String = BitConverter.ToString(passwordHash).Replace("-", "")

        Dim Responsable As String = "SELECT COUNT(*)
                                    FROM RESPONSABLE_SECTEUR
                                    WHERE PRENOM='" & TextBoxUsername.Text & "'
                                    AND MDP='" & passwordHashString & "'"
        Dim Visiteur As String = "SELECT COUNT(*)
                                    FROM DELEGUE_VISITEUR
                                    WHERE PRENOM='" & TextBoxUsername.Text & "'
                                    AND MDP='" & passwordHashString & "'
                                    AND DV_DELEGUE=0"
        Dim Delegue As String = "SELECT COUNT(*)
                                    FROM DELEGUE_VISITEUR
                                    WHERE PRENOM='" & TextBoxUsername.Text & "'
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
                                    WHERE PRENOM='" & TextBoxUsername.Text & "'
                                    AND MDP='" & passwordHashString & "'"
                my2Command.Connection = myConnection
                my2Command.CommandText = commande
                my2Reader = my2Command.ExecuteReader

                While my2Reader.Read
                    Nom = my2Reader.GetString(0)
                    id_utilisateur = my2Reader.GetString(1)
                End While
                my2Reader.Close()
                Prenom = TextBoxUsername.Text
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
                                    WHERE PRENOM='" & TextBoxUsername.Text & "'
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
                Prenom = TextBoxUsername.Text
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
                                    WHERE PRENOM='" & TextBoxUsername.Text & "'
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
                Prenom = TextBoxUsername.Text
                Accueil_Delegue.Show()
                Me.Hide()
            Else
                erreur_connexion += 1
            End If
        End While
        myReader.Close()

        If (erreur_connexion = 3) Then
            MessageBox.Show("Erreur : Identifiant ou Mot de Passe incorrect")
            TextBoxPassword.Clear()
            TextBoxUsername.Clear()
        End If

    End Sub


End Class