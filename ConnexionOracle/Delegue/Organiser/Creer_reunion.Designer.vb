<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creer_reunion
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
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.Button_retour = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataPrenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identifiant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Location = New System.Drawing.Point(297, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Créer une réunion"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 280)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(259, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 342)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 20)
        Me.TextBox1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(122, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Lieu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(277, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Sélectionnez les membres de la réunion"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(551, 51)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "CRÉER RÉUNION"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataNom, Me.DataPrenom, Me.identifiant})
        Me.DataGridView1.Location = New System.Drawing.Point(566, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(283, 227)
        Me.DataGridView1.TabIndex = 40
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(280, 279)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(280, 21)
        Me.ComboBox2.TabIndex = 41
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SpringGreen
        Me.Button3.Location = New System.Drawing.Point(277, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(283, 36)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Ajouter Utilisateur"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataNom
        '
        Me.DataNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataNom.HeaderText = "Nom"
        Me.DataNom.Name = "DataNom"
        Me.DataNom.ReadOnly = True
        '
        'DataPrenom
        '
        Me.DataPrenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataPrenom.HeaderText = "Prenom"
        Me.DataPrenom.Name = "DataPrenom"
        Me.DataPrenom.ReadOnly = True
        '
        'identifiant
        '
        Me.identifiant.HeaderText = "identifiant"
        Me.identifiant.Name = "identifiant"
        Me.identifiant.ReadOnly = True
        Me.identifiant.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(628, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Membre sélectionné"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.Location = New System.Drawing.Point(277, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 36)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Supprimer Utilisateur"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Creer_reunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button_retour)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Creer_reunion"
        Me.Text = "Creer_reunion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Nom As Label
    Friend WithEvents Button_retour As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button3 As Button
    Friend WithEvents DataNom As DataGridViewTextBoxColumn
    Friend WithEvents DataPrenom As DataGridViewTextBoxColumn
    Friend WithEvents identifiant As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class

