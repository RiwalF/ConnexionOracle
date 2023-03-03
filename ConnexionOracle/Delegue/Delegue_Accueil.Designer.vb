<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil_Delegue
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Enregistrer = New System.Windows.Forms.Button()
        Me.Button_Organiser = New System.Windows.Forms.Button()
        Me.Button_acceder = New System.Windows.Forms.Button()
        Me.Button_retour = New System.Windows.Forms.Button()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button_consulter = New System.Windows.Forms.Button()
        Me.Button_rediger = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 35)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Délégué"
        '
        'Button_Enregistrer
        '
        Me.Button_Enregistrer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Enregistrer.Location = New System.Drawing.Point(544, 237)
        Me.Button_Enregistrer.Name = "Button_Enregistrer"
        Me.Button_Enregistrer.Size = New System.Drawing.Size(165, 51)
        Me.Button_Enregistrer.TabIndex = 12
        Me.Button_Enregistrer.Text = "Enregistrer les données d'atribution"
        Me.Button_Enregistrer.UseVisualStyleBackColor = False
        '
        'Button_Organiser
        '
        Me.Button_Organiser.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Organiser.Location = New System.Drawing.Point(161, 237)
        Me.Button_Organiser.Name = "Button_Organiser"
        Me.Button_Organiser.Size = New System.Drawing.Size(165, 51)
        Me.Button_Organiser.TabIndex = 11
        Me.Button_Organiser.Text = "Organiser des réunions bilan mensuelles "
        Me.Button_Organiser.UseVisualStyleBackColor = False
        '
        'Button_acceder
        '
        Me.Button_acceder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_acceder.Location = New System.Drawing.Point(353, 237)
        Me.Button_acceder.Name = "Button_acceder"
        Me.Button_acceder.Size = New System.Drawing.Size(165, 51)
        Me.Button_acceder.TabIndex = 13
        Me.Button_acceder.Text = "Accéder aux rapports des collègues"
        Me.Button_acceder.UseVisualStyleBackColor = False
        '
        'Button_retour
        '
        Me.Button_retour.BackgroundImage = Global.ConnexionOracle.My.Resources.Resources.retour
        Me.Button_retour.Location = New System.Drawing.Point(12, 140)
        Me.Button_retour.Name = "Button_retour"
        Me.Button_retour.Size = New System.Drawing.Size(55, 50)
        Me.Button_retour.TabIndex = 14
        Me.Button_retour.UseVisualStyleBackColor = True
        '
        'Label_Prenom
        '
        Me.Label_Prenom.AutoSize = True
        Me.Label_Prenom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Prenom.Location = New System.Drawing.Point(776, 90)
        Me.Label_Prenom.Name = "Label_Prenom"
        Me.Label_Prenom.Size = New System.Drawing.Size(43, 13)
        Me.Label_Prenom.TabIndex = 17
        Me.Label_Prenom.Text = "Prenom"
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Nom.Location = New System.Drawing.Point(776, 52)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(29, 13)
        Me.Label_Nom.TabIndex = 16
        Me.Label_Nom.Text = "Nom"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.ConnexionOracle.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1176, 108)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Button_consulter
        '
        Me.Button_consulter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_consulter.Location = New System.Drawing.Point(448, 381)
        Me.Button_consulter.Name = "Button_consulter"
        Me.Button_consulter.Size = New System.Drawing.Size(165, 51)
        Me.Button_consulter.TabIndex = 24
        Me.Button_consulter.Text = "Consulter mes comptes-rendu"
        Me.Button_consulter.UseVisualStyleBackColor = False
        '
        'Button_rediger
        '
        Me.Button_rediger.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_rediger.Location = New System.Drawing.Point(257, 381)
        Me.Button_rediger.Name = "Button_rediger"
        Me.Button_rediger.Size = New System.Drawing.Size(165, 51)
        Me.Button_rediger.TabIndex = 23
        Me.Button_rediger.Text = "Rédiger un compte-rendu"
        Me.Button_rediger.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 35)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Visiteur"
        '
        'Accueil_Delegue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_consulter)
        Me.Controls.Add(Me.Button_rediger)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button_retour)
        Me.Controls.Add(Me.Button_acceder)
        Me.Controls.Add(Me.Button_Enregistrer)
        Me.Controls.Add(Me.Button_Organiser)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Accueil_Delegue"
        Me.Text = "Accueil_Delegue"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Enregistrer As Button
    Friend WithEvents Button_Organiser As Button
    Friend WithEvents Button_acceder As Button
    Friend WithEvents Button_retour As Button
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Nom As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button_consulter As Button
    Friend WithEvents Button_rediger As Button
    Friend WithEvents Label1 As Label
End Class
