<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil_responsable
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Gerer_vis = New System.Windows.Forms.Button()
        Me.Button_Organiser = New System.Windows.Forms.Button()
        Me.Button_Gerer_med = New System.Windows.Forms.Button()
        Me.Button_Effectuer = New System.Windows.Forms.Button()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Button_retour = New System.Windows.Forms.Button()
        Me.Button_consulter = New System.Windows.Forms.Button()
        Me.Button_rediger = New System.Windows.Forms.Button()
        Me.Button_acceder = New System.Windows.Forms.Button()
        Me.Button_Enregistrer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1176, 108)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Responsable Secteur"
        '
        'Button_Gerer_vis
        '
        Me.Button_Gerer_vis.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Gerer_vis.Location = New System.Drawing.Point(263, 237)
        Me.Button_Gerer_vis.Name = "Button_Gerer_vis"
        Me.Button_Gerer_vis.Size = New System.Drawing.Size(165, 51)
        Me.Button_Gerer_vis.TabIndex = 16
        Me.Button_Gerer_vis.Text = "Gérer les nouveaux visiteurs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button_Gerer_vis.UseVisualStyleBackColor = False
        '
        'Button_Organiser
        '
        Me.Button_Organiser.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Organiser.Location = New System.Drawing.Point(454, 237)
        Me.Button_Organiser.Name = "Button_Organiser"
        Me.Button_Organiser.Size = New System.Drawing.Size(165, 51)
        Me.Button_Organiser.TabIndex = 15
        Me.Button_Organiser.Text = "Organiser une soirée d'information"
        Me.Button_Organiser.UseVisualStyleBackColor = False
        '
        'Button_Gerer_med
        '
        Me.Button_Gerer_med.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Gerer_med.Location = New System.Drawing.Point(71, 237)
        Me.Button_Gerer_med.Name = "Button_Gerer_med"
        Me.Button_Gerer_med.Size = New System.Drawing.Size(165, 51)
        Me.Button_Gerer_med.TabIndex = 14
        Me.Button_Gerer_med.Text = "Gérer l'approvisionnement des médicaments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button_Gerer_med.UseVisualStyleBackColor = False
        '
        'Button_Effectuer
        '
        Me.Button_Effectuer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Effectuer.Location = New System.Drawing.Point(645, 237)
        Me.Button_Effectuer.Name = "Button_Effectuer"
        Me.Button_Effectuer.Size = New System.Drawing.Size(165, 51)
        Me.Button_Effectuer.TabIndex = 17
        Me.Button_Effectuer.Text = "Effectuer une analyse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button_Effectuer.UseVisualStyleBackColor = False
        '
        'Label_Prenom
        '
        Me.Label_Prenom.AutoSize = True
        Me.Label_Prenom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Prenom.Location = New System.Drawing.Point(781, 88)
        Me.Label_Prenom.Name = "Label_Prenom"
        Me.Label_Prenom.Size = New System.Drawing.Size(43, 13)
        Me.Label_Prenom.TabIndex = 19
        Me.Label_Prenom.Text = "Prenom"
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Nom.Location = New System.Drawing.Point(781, 50)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(29, 13)
        Me.Label_Nom.TabIndex = 18
        Me.Label_Nom.Text = "Nom"
        '
        'Button_retour
        '
        Me.Button_retour.BackgroundImage = Global.ConnexionOracle.My.Resources.Resources.retour
        Me.Button_retour.Location = New System.Drawing.Point(12, 140)
        Me.Button_retour.Name = "Button_retour"
        Me.Button_retour.Size = New System.Drawing.Size(55, 50)
        Me.Button_retour.TabIndex = 20
        Me.Button_retour.UseVisualStyleBackColor = True
        '
        'Button_consulter
        '
        Me.Button_consulter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_consulter.Location = New System.Drawing.Point(463, 460)
        Me.Button_consulter.Name = "Button_consulter"
        Me.Button_consulter.Size = New System.Drawing.Size(165, 51)
        Me.Button_consulter.TabIndex = 22
        Me.Button_consulter.Text = "Consulter mes comptes-rendu"
        Me.Button_consulter.UseVisualStyleBackColor = False
        '
        'Button_rediger
        '
        Me.Button_rediger.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_rediger.Location = New System.Drawing.Point(272, 460)
        Me.Button_rediger.Name = "Button_rediger"
        Me.Button_rediger.Size = New System.Drawing.Size(165, 51)
        Me.Button_rediger.TabIndex = 21
        Me.Button_rediger.Text = "Rédiger un compte-rendu"
        Me.Button_rediger.UseVisualStyleBackColor = False
        '
        'Button_acceder
        '
        Me.Button_acceder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_acceder.Location = New System.Drawing.Point(361, 347)
        Me.Button_acceder.Name = "Button_acceder"
        Me.Button_acceder.Size = New System.Drawing.Size(165, 51)
        Me.Button_acceder.TabIndex = 25
        Me.Button_acceder.Text = "Accéder aux rapports des collègues"
        Me.Button_acceder.UseVisualStyleBackColor = False
        '
        'Button_Enregistrer
        '
        Me.Button_Enregistrer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Enregistrer.Location = New System.Drawing.Point(552, 347)
        Me.Button_Enregistrer.Name = "Button_Enregistrer"
        Me.Button_Enregistrer.Size = New System.Drawing.Size(165, 51)
        Me.Button_Enregistrer.TabIndex = 24
        Me.Button_Enregistrer.Text = "Enregistrer les données d'atribution"
        Me.Button_Enregistrer.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(169, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 51)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Organiser des réunions bilan mensuelles "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 35)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Visiteur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 35)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Délégué"
        '
        'Accueil_responsable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_acceder)
        Me.Controls.Add(Me.Button_Enregistrer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_consulter)
        Me.Controls.Add(Me.Button_rediger)
        Me.Controls.Add(Me.Button_retour)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.Button_Effectuer)
        Me.Controls.Add(Me.Button_Gerer_vis)
        Me.Controls.Add(Me.Button_Organiser)
        Me.Controls.Add(Me.Button_Gerer_med)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Accueil_responsable"
        Me.Text = "Accueil_Responsable"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Gerer_vis As Button
    Friend WithEvents Button_Organiser As Button
    Friend WithEvents Button_Gerer_med As Button
    Friend WithEvents Button_Effectuer As Button
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Nom As Label
    Friend WithEvents Button_retour As Button
    Friend WithEvents Button_consulter As Button
    Friend WithEvents Button_rediger As Button
    Friend WithEvents Button_acceder As Button
    Friend WithEvents Button_Enregistrer As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
