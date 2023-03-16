Imports System.Data.Common

Public Class Accueil_Visiteur

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String

    Private Sub Accueil_Visiteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNom.Text = Nom
        LabelPrenom.Text = Prenom
    End Sub

    Private Sub Button_rediger_Click(sender As Object, e As EventArgs) Handles ButtonRediger.Click
        Visiteur_Rediger_compte_rendu.Show()
        Me.Close()
    End Sub

    Private Sub Button_consulter_Click(sender As Object, e As EventArgs) Handles ButtonConsulter.Click
        Visiteur_Consulter_compte_rendu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Nom = ""
        Prenom = ""
        type_Utilisateur = ""
        Form1.Show()
        Me.Close()
    End Sub

End Class