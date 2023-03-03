<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delegue_Organiser_réunions_mensuelles
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
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Button_consulter = New System.Windows.Forms.Button()
        Me.Button_rediger = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(548, 35)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Organiser des réunions bilan mensuelles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label_Prenom
        '
        Me.Label_Prenom.AutoSize = True
        Me.Label_Prenom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Prenom.Location = New System.Drawing.Point(778, 90)
        Me.Label_Prenom.Name = "Label_Prenom"
        Me.Label_Prenom.Size = New System.Drawing.Size(0, 13)
        Me.Label_Prenom.TabIndex = 16
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Nom.Location = New System.Drawing.Point(778, 52)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(0, 13)
        Me.Label_Nom.TabIndex = 15
        '
        'Button_consulter
        '
        Me.Button_consulter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_consulter.Location = New System.Drawing.Point(547, 290)
        Me.Button_consulter.Name = "Button_consulter"
        Me.Button_consulter.Size = New System.Drawing.Size(165, 51)
        Me.Button_consulter.TabIndex = 24
        Me.Button_consulter.Text = "Voir mes réunions"
        Me.Button_consulter.UseVisualStyleBackColor = False
        '
        'Button_rediger
        '
        Me.Button_rediger.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_rediger.Location = New System.Drawing.Point(164, 290)
        Me.Button_rediger.Name = "Button_rediger"
        Me.Button_rediger.Size = New System.Drawing.Size(165, 51)
        Me.Button_rediger.TabIndex = 23
        Me.Button_rediger.Text = "Créer une réunion"
        Me.Button_rediger.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1176, 108)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ConnexionOracle.My.Resources.Resources.retour
        Me.Button1.Location = New System.Drawing.Point(12, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 50)
        Me.Button1.TabIndex = 55
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Delegue_Organiser_réunions_mensuelles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_consulter)
        Me.Controls.Add(Me.Button_rediger)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Delegue_Organiser_réunions_mensuelles"
        Me.Text = "Delegue_Organiser_réunions_mensuelles"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Nom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_consulter As Button
    Friend WithEvents Button_rediger As Button
    Friend WithEvents Button1 As Button
End Class

