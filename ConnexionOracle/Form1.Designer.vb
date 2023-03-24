<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBoxHeader = New System.Windows.Forms.PictureBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.LabelConnexion = New System.Windows.Forms.Label()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxHeader.ErrorImage = CType(resources.GetObject("PictureBoxHeader.ErrorImage"), System.Drawing.Image)
        Me.PictureBoxHeader.Image = Global.ConnexionOracle.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBoxHeader.InitialImage = Nothing
        Me.PictureBoxHeader.Location = New System.Drawing.Point(-2, 26)
        Me.PictureBoxHeader.Name = "PictureBoxHeader"
        Me.PictureBoxHeader.Size = New System.Drawing.Size(1176, 108)
        Me.PictureBoxHeader.TabIndex = 0
        Me.PictureBoxHeader.TabStop = False
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(155, 288)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(132, 20)
        Me.TextBoxUsername.TabIndex = 1
        '
        'LabelUsername
        '
        Me.LabelUsername.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(66, 288)
        Me.LabelUsername.MaximumSize = New System.Drawing.Size(500, 500)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(83, 20)
        Me.LabelUsername.TabIndex = 2
        Me.LabelUsername.Text = "Identifiant :"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(613, 285)
        Me.TextBoxPassword.MaximumSize = New System.Drawing.Size(500, 500)
        Me.TextBoxPassword.MinimumSize = New System.Drawing.Size(4, 4)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxPassword.TabIndex = 3
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(504, 285)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(103, 17)
        Me.LabelPassword.TabIndex = 4
        Me.LabelPassword.Text = "Mot de passe :"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.Location = New System.Drawing.Point(381, 412)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(91, 40)
        Me.ButtonLogin.TabIndex = 5
        Me.ButtonLogin.Text = "Connexion"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'LabelConnexion
        '
        Me.LabelConnexion.AutoSize = True
        Me.LabelConnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConnexion.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConnexion.Location = New System.Drawing.Point(345, 190)
        Me.LabelConnexion.Name = "LabelConnexion"
        Me.LabelConnexion.Size = New System.Drawing.Size(154, 35)
        Me.LabelConnexion.TabIndex = 6
        Me.LabelConnexion.Text = "Connexion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.LabelConnexion)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.PictureBoxHeader)
        Me.Name = "Form1"
        Me.Text = "Connect"
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents PictureBoxHeader As PictureBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents LabelConnexion As Label
End Class