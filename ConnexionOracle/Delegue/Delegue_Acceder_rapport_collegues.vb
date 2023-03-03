Public Class Delegue_Acceder_rapport_collegues

    Private Sub Delegue_Acceder_rapport_collegues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Prenom.Text = Prenom
        Label_Nom.Text = Nom
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