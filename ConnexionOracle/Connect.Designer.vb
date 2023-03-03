<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Connect))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.TextBox_MDP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1176, 108)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(155, 288)
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(132, 20)
        Me.TextBox_username.TabIndex = 1
        '
        'Label_username
        '
        Me.Label_username.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_username.Location = New System.Drawing.Point(66, 288)
        Me.Label_username.MaximumSize = New System.Drawing.Size(500, 500)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(83, 20)
        Me.Label_username.TabIndex = 2
        Me.Label_username.Text = "Username :"
        '
        'TextBox_MDP
        '
        Me.TextBox_MDP.Location = New System.Drawing.Point(613, 285)
        Me.TextBox_MDP.MaximumSize = New System.Drawing.Size(500, 500)
        Me.TextBox_MDP.MinimumSize = New System.Drawing.Size(4, 4)
        Me.TextBox_MDP.Name = "TextBox_MDP"
        Me.TextBox_MDP.Size = New System.Drawing.Size(150, 20)
        Me.TextBox_MDP.TabIndex = 3
        Me.TextBox_MDP.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password :"
        '
        'Button_Login
        '
        Me.Button_Login.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.Location = New System.Drawing.Point(381, 412)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(91, 40)
        Me.Button_Login.TabIndex = 5
        Me.Button_Login.Text = "Login"
        Me.Button_Login.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 35)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Connexion"
        '
        'Connect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_MDP)
        Me.Controls.Add(Me.Label_username)
        Me.Controls.Add(Me.TextBox_username)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Connect"
        Me.Text = "Connect"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents Label_username As Label
    Friend WithEvents TextBox_MDP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Label2 As Label
End Class