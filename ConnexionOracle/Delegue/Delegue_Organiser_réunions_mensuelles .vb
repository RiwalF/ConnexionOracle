Public Class Delegue_Organiser_réunions_mensuelles
    Private Sub Delegue_Organiser_réunions_mensuelles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom
    End Sub

    Private Sub Button_consulter_Click(sender As Object, e As EventArgs) Handles Button_consulter.Click
        Me.Hide()
        Voir_reunion.Show()
    End Sub

    Private Sub Button_rediger_Click(sender As Object, e As EventArgs) Handles Button_rediger.Click
        Me.Hide()
        Creer_reunion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If type_Utilisateur = "Responsable" Then
            Accueil_responsable.Show()
            Me.Close()
        ElseIf type_Utilisateur = "Delegue" Then
            Accueil_Delegue.Show()
            Me.Close()
        ElseIf type_Utilisateur = "Visiteur" Then
            Accueil_Visiteur.Show()
            Me.Close()
        Else
            type_Utilisateur = ""
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class