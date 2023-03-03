Imports System.Data.Common

Public Class Accueil_responsable
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub Accueil_responsable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Nom = "") Then
            connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"

            myConnection.ConnectionString = connString
            Try
                myConnection.Open()
            Catch ex As Odbc.OdbcException
                MessageBox.Show(ex.Message)
            End Try

            Dim commande As String = "SELECT NOM,ID
                                    FROM RESPONSABLE_SECTEUR
                                    WHERE PRENOM='" & Connect.TextBox_username.Text & "'
                                    AND MDP='" & Connect.TextBox_MDP.Text & "'"
            myCommand.Connection = myConnection
            myCommand.CommandText = commande
            myReader = myCommand.ExecuteReader

            While myReader.Read
                Nom = myReader.GetString(0)
                id_utilisateur = myReader.GetString(1)
            End While
            Prenom = Connect.TextBox_username.Text
        End If


        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom

    End Sub

    Private Sub Button_Gerer_med_Click(sender As Object, e As EventArgs) Handles Button_Gerer_med.Click
        Responsable_Gerer_approvisionnement_echantillon.Show()
    End Sub

    Private Sub Button_Gerer_vis_Click(sender As Object, e As EventArgs) Handles Button_Gerer_vis.Click
        Responsable_Gerer_nouveaux_visiteurs.Show()
    End Sub

    Private Sub Button_Organiser_Click(sender As Object, e As EventArgs) Handles Button_Organiser.Click
        Responsable_Organiser_soiree_information.Show()
    End Sub

    Private Sub Button_Effectuer_Click(sender As Object, e As EventArgs) Handles Button_Effectuer.Click
        Responsable_Effectuer_analyse.Show()
    End Sub

    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
        Nom = ""
        Prenom = ""
        Connect.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Delegue_Organiser_réunions_mensuelles.Show()
    End Sub

    Private Sub Button_acceder_Click(sender As Object, e As EventArgs) Handles Button_acceder.Click
        Delegue_Acceder_rapport_collegues.Show()
    End Sub

    Private Sub Button_Enregistrer_Click(sender As Object, e As EventArgs) Handles Button_Enregistrer.Click
        Delegue_Enregistrer_donnees_attribution.Show()
    End Sub

    Private Sub Button_rediger_Click(sender As Object, e As EventArgs) Handles Button_rediger.Click
        Visiteur_Rediger_compte_rendu.Show()
    End Sub

    Private Sub Button_consulter_Click(sender As Object, e As EventArgs) Handles Button_consulter.Click
        Visiteur_Consulter_compte_rendu.Show()
    End Sub
End Class