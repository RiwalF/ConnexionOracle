Imports System.Data.Common

Public Class Accueil_responsable
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub Accueil_responsable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom
    End Sub

    Private Sub Button_Gerer_med_Click(sender As Object, e As EventArgs) Handles Button_Gerer_med.Click
        Responsable_Gerer_approvisionnement_echantillon.Show()
        Me.Close()
    End Sub

    Private Sub Button_Gerer_vis_Click(sender As Object, e As EventArgs) Handles Button_Gerer_vis.Click
        Responsable_Gerer_nouveaux_visiteurs.Show()
        Me.Close()
    End Sub

    Private Sub Button_Organiser_Click(sender As Object, e As EventArgs) Handles Button_Organiser.Click
        Responsable_Organiser_soiree_information.Show()
        Me.Close()
    End Sub

    Private Sub Button_Effectuer_Click(sender As Object, e As EventArgs) Handles Button_Effectuer.Click
        Responsable_Effectuer_analyse.Show()
        Me.Close()
    End Sub

    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
        Nom = ""
        Prenom = ""
        type_Utilisateur = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Delegue_Organiser_réunions_mensuelles.Show()
        Me.Close()
    End Sub

    Private Sub Button_acceder_Click(sender As Object, e As EventArgs) Handles Button_acceder.Click
        Delegue_Acceder_rapport_collegues.Show()
        Me.Close()
    End Sub

    Private Sub Button_Enregistrer_Click(sender As Object, e As EventArgs) Handles Button_Enregistrer.Click
        Delegue_Enregistrer_donnees_attribution.Show()
        Me.Close()
    End Sub

    Private Sub Button_rediger_Click(sender As Object, e As EventArgs) Handles Button_rediger.Click
        Visiteur_Rediger_compte_rendu.Show()
        Me.Close()
    End Sub

    Private Sub Button_consulter_Click(sender As Object, e As EventArgs) Handles Button_consulter.Click
        Visiteur_Consulter_compte_rendu.Show()
        Me.Close()
    End Sub
End Class