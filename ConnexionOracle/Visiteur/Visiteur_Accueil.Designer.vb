<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil_Visiteur
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
        Me.Button_rediger = New System.Windows.Forms.Button()
        Me.Button_consulter = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Visiteur"
        '
        'Button_rediger
        '
        Me.Button_rediger.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_rediger.Location = New System.Drawing.Point(200, 288)
        Me.Button_rediger.Name = "Button_rediger"
        Me.Button_rediger.Size = New System.Drawing.Size(165, 51)
        Me.Button_rediger.TabIndex = 9
        Me.Button_rediger.Text = "Rédiger un compte-rendu"
        Me.Button_rediger.UseVisualStyleBackColor = False
        '
        'Button_consulter
        '
        Me.Button_consulter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_consulter.Location = New System.Drawing.Point(491, 288)
        Me.Button_consulter.Name = "Button_consulter"
        Me.Button_consulter.Size = New System.Drawing.Size(165, 51)
        Me.Button_consulter.TabIndex = 10
        Me.Button_consulter.Text = "Consulter mes comptes-rendu"
        Me.Button_consulter.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ConnexionOracle.My.Resources.Resources.retour
        Me.Button1.Location = New System.Drawing.Point(12, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
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
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Nom.Location = New System.Drawing.Point(775, 52)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(29, 13)
        Me.Label_Nom.TabIndex = 12
        Me.Label_Nom.Text = "Nom"
        '
        'Label_Prenom
        '
        Me.Label_Prenom.AutoSize = True
        Me.Label_Prenom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Prenom.Location = New System.Drawing.Point(775, 90)
        Me.Label_Prenom.Name = "Label_Prenom"
        Me.Label_Prenom.Size = New System.Drawing.Size(43, 13)
        Me.Label_Prenom.TabIndex = 13
        Me.Label_Prenom.Text = "Prenom"
        '
        'Accueil_Visiteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_consulter)
        Me.Controls.Add(Me.Button_rediger)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Accueil_Visiteur"
        Me.Text = "Accueil_Visiteur"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button_rediger As Button
    Friend WithEvents Button_consulter As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_Nom As Label
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label1 As Label
End Class
