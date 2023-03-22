<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Voir_reunion
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Button_retour = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelLieu = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBoxLieu = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDate = New System.Windows.Forms.ComboBox()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Voir mes réunions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(602, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 26)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Participants"
        '
        'LabelLieu
        '
        Me.LabelLieu.AutoSize = True
        Me.LabelLieu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelLieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLieu.Location = New System.Drawing.Point(78, 326)
        Me.LabelLieu.Name = "LabelLieu"
        Me.LabelLieu.Size = New System.Drawing.Size(48, 26)
        Me.LabelLieu.TabIndex = 56
        Me.LabelLieu.Text = "Lieu"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(78, 247)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(50, 26)
        Me.LabelDate.TabIndex = 57
        Me.LabelDate.Text = "Date"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(508, 222)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(302, 264)
        Me.ListBox1.TabIndex = 59
        '
        'ComboBoxLieu
        '
        Me.ComboBoxLieu.FormattingEnabled = True
        Me.ComboBoxLieu.Location = New System.Drawing.Point(78, 355)
        Me.ComboBoxLieu.Name = "ComboBoxLieu"
        Me.ComboBoxLieu.Size = New System.Drawing.Size(291, 21)
        Me.ComboBoxLieu.TabIndex = 60
        '
        'ComboBoxDate
        '
        Me.ComboBoxDate.FormattingEnabled = True
        Me.ComboBoxDate.Location = New System.Drawing.Point(78, 276)
        Me.ComboBoxDate.Name = "ComboBoxDate"
        Me.ComboBoxDate.Size = New System.Drawing.Size(291, 21)
        Me.ComboBoxDate.TabIndex = 61
        '
        'Voir_reunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.ComboBoxDate)
        Me.Controls.Add(Me.ComboBoxLieu)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelLieu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button_retour)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Voir_reunion"
        Me.Text = "Voir_reunion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Nom As Label
    Friend WithEvents Button_retour As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelLieu As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBoxLieu As ComboBox
    Friend WithEvents ComboBoxDate As ComboBox
End Class



