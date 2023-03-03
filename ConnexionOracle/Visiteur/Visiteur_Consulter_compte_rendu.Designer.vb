<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visiteur_Consulter_compte_rendu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(254, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 35)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Consulter un compte-rendu"
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(423, 196)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox2.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Compte-rendu :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 17)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Motif du compte rendu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(115, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 17)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Date du compte-rendu sélectionné"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 415)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Praticien consulté"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 24)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "motif"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(114, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 24)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(114, 451)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 24)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Praticien"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(604, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Médicaments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(507, 260)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(305, 251)
        Me.ListBox1.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ConnexionOracle.My.Resources.Resources.retour
        Me.Button1.Location = New System.Drawing.Point(12, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 50)
        Me.Button1.TabIndex = 54
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Visiteur_Consulter_compte_rendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Visiteur_Consulter_compte_rendu"
        Me.Text = "Consulter_compte_rendu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Nom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
End Class

