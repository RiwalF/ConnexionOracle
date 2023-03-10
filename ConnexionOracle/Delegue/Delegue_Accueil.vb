Imports System.Data.Common
Imports System.Windows.Input

Public Class Accueil_Delegue

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub Accueil_Delegue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
        Nom = ""
        Prenom = ""
        type_Utilisateur = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button_acceder_Click(sender As Object, e As EventArgs) Handles Button_acceder.Click
        Delegue_Acceder_rapport_collegues.Show()
        Me.Close()
    End Sub

    Private Sub Button_Organiser_Click(sender As Object, e As EventArgs) Handles Button_Organiser.Click
        Delegue_Organiser_réunions_mensuelles.Show()
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