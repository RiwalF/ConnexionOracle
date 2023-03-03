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
End Class