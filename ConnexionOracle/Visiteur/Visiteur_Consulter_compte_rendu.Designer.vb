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
        Me.LabelConsulterUnCompteRendu = New System.Windows.Forms.Label()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxCompteRendu = New System.Windows.Forms.ComboBox()
        Me.LabelCompteRendu = New System.Windows.Forms.Label()
        Me.LabelMotif = New System.Windows.Forms.Label()
        Me.LabelDateCR = New System.Windows.Forms.Label()
        Me.LabelPraticien = New System.Windows.Forms.Label()
        Me.LabelMedicaments = New System.Windows.Forms.Label()
        Me.ListBoxMedicaments = New System.Windows.Forms.ListBox()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.ComboBoxDate = New System.Windows.Forms.ComboBox()
        Me.TextBoxMotifCR = New System.Windows.Forms.TextBox()
        Me.TextBoxPraticien = New System.Windows.Forms.TextBox()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.ButtonSupprimerCR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelConsulterUnCompteRendu
        '
        Me.LabelConsulterUnCompteRendu.AutoSize = True
        Me.LabelConsulterUnCompteRendu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsulterUnCompteRendu.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsulterUnCompteRendu.Location = New System.Drawing.Point(254, 146)
        Me.LabelConsulterUnCompteRendu.Name = "LabelConsulterUnCompteRendu"
        Me.LabelConsulterUnCompteRendu.Size = New System.Drawing.Size(370, 35)
        Me.LabelConsulterUnCompteRendu.TabIndex = 9
        Me.LabelConsulterUnCompteRendu.Text = "Consulter un compte-rendu"
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
        'ComboBoxCompteRendu
        '
        Me.ComboBoxCompteRendu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxCompteRendu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCompteRendu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCompteRendu.FormattingEnabled = True
        Me.ComboBoxCompteRendu.Location = New System.Drawing.Point(307, 197)
        Me.ComboBoxCompteRendu.Name = "ComboBoxCompteRendu"
        Me.ComboBoxCompteRendu.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxCompteRendu.TabIndex = 43
        '
        'LabelCompteRendu
        '
        Me.LabelCompteRendu.AutoSize = True
        Me.LabelCompteRendu.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompteRendu.Location = New System.Drawing.Point(191, 197)
        Me.LabelCompteRendu.Name = "LabelCompteRendu"
        Me.LabelCompteRendu.Size = New System.Drawing.Size(110, 17)
        Me.LabelCompteRendu.TabIndex = 44
        Me.LabelCompteRendu.Text = "Compte-rendu :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelMotif
        '
        Me.LabelMotif.AutoSize = True
        Me.LabelMotif.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMotif.Location = New System.Drawing.Point(106, 240)
        Me.LabelMotif.Name = "LabelMotif"
        Me.LabelMotif.Size = New System.Drawing.Size(152, 17)
        Me.LabelMotif.TabIndex = 47
        Me.LabelMotif.Text = "Motif du compte rendu"
        '
        'LabelDateCR
        '
        Me.LabelDateCR.AutoSize = True
        Me.LabelDateCR.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDateCR.Location = New System.Drawing.Point(106, 307)
        Me.LabelDateCR.Name = "LabelDateCR"
        Me.LabelDateCR.Size = New System.Drawing.Size(232, 17)
        Me.LabelDateCR.TabIndex = 48
        Me.LabelDateCR.Text = "Date du compte-rendu sélectionné"
        '
        'LabelPraticien
        '
        Me.LabelPraticien.AutoSize = True
        Me.LabelPraticien.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPraticien.Location = New System.Drawing.Point(106, 368)
        Me.LabelPraticien.Name = "LabelPraticien"
        Me.LabelPraticien.Size = New System.Drawing.Size(124, 17)
        Me.LabelPraticien.TabIndex = 49
        Me.LabelPraticien.Text = "Praticien consulté"
        '
        'LabelMedicaments
        '
        Me.LabelMedicaments.AutoSize = True
        Me.LabelMedicaments.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMedicaments.Location = New System.Drawing.Point(506, 240)
        Me.LabelMedicaments.Name = "LabelMedicaments"
        Me.LabelMedicaments.Size = New System.Drawing.Size(95, 17)
        Me.LabelMedicaments.TabIndex = 42
        Me.LabelMedicaments.Text = "Médicaments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ListBoxMedicaments
        '
        Me.ListBoxMedicaments.FormattingEnabled = True
        Me.ListBoxMedicaments.Location = New System.Drawing.Point(509, 260)
        Me.ListBoxMedicaments.Name = "ListBoxMedicaments"
        Me.ListBoxMedicaments.Size = New System.Drawing.Size(305, 147)
        Me.ListBoxMedicaments.TabIndex = 53
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackgroundImage = Global.ConnexionOracle.My.Resources.Resources.retour
        Me.ButtonRetour.Location = New System.Drawing.Point(12, 140)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(55, 50)
        Me.ButtonRetour.TabIndex = 54
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(482, 197)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(51, 17)
        Me.LabelDate.TabIndex = 56
        Me.LabelDate.Text = "Date : "
        '
        'ComboBoxDate
        '
        Me.ComboBoxDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDate.FormattingEnabled = True
        Me.ComboBoxDate.Location = New System.Drawing.Point(539, 197)
        Me.ComboBoxDate.Name = "ComboBoxDate"
        Me.ComboBoxDate.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxDate.TabIndex = 55

        '
        'TextBoxMotifCR
        '
        Me.TextBoxMotifCR.Location = New System.Drawing.Point(109, 260)
        Me.TextBoxMotifCR.Name = "TextBoxMotifCR"
        Me.TextBoxMotifCR.ReadOnly = True
        Me.TextBoxMotifCR.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxMotifCR.TabIndex = 57
        '
        'TextBoxPraticien
        '
        Me.TextBoxPraticien.Location = New System.Drawing.Point(109, 388)
        Me.TextBoxPraticien.Name = "TextBoxPraticien"
        Me.TextBoxPraticien.ReadOnly = True
        Me.TextBoxPraticien.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxPraticien.TabIndex = 58
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(109, 327)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.ReadOnly = True
        Me.TextBoxDate.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxDate.TabIndex = 59
        '
        'ButtonSupprimerCR
        '
        Me.ButtonSupprimerCR.BackColor = System.Drawing.Color.IndianRed
        Me.ButtonSupprimerCR.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonSupprimerCR.Location = New System.Drawing.Point(307, 453)
        Me.ButtonSupprimerCR.Name = "ButtonSupprimerCR"
        Me.ButtonSupprimerCR.Size = New System.Drawing.Size(238, 40)
        Me.ButtonSupprimerCR.TabIndex = 60
        Me.ButtonSupprimerCR.Text = "SUPPRIMER COMPTE-RENDU"
        Me.ButtonSupprimerCR.UseVisualStyleBackColor = False
        '
        'Visiteur_Consulter_compte_rendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.ButtonSupprimerCR)
        Me.Controls.Add(Me.TextBoxDate)
        Me.Controls.Add(Me.TextBoxPraticien)
        Me.Controls.Add(Me.TextBoxMotifCR)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.ComboBoxDate)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ListBoxMedicaments)
        Me.Controls.Add(Me.LabelPraticien)
        Me.Controls.Add(Me.LabelDateCR)
        Me.Controls.Add(Me.LabelMotif)
        Me.Controls.Add(Me.LabelCompteRendu)
        Me.Controls.Add(Me.ComboBoxCompteRendu)
        Me.Controls.Add(Me.LabelMedicaments)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelConsulterUnCompteRendu)
        Me.Name = "Visiteur_Consulter_compte_rendu"
        Me.Text = "Consulter_compte_rendu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelConsulterUnCompteRendu As Label
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Nom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxCompteRendu As ComboBox
    Friend WithEvents LabelCompteRendu As Label
    Friend WithEvents LabelMotif As Label
    Friend WithEvents LabelDateCR As Label
    Friend WithEvents LabelPraticien As Label
    Friend WithEvents LabelMedicaments As Label
    Friend WithEvents ListBoxMedicaments As ListBox
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents LabelDate As Label
    Friend WithEvents ComboBoxDate As ComboBox
    Friend WithEvents TextBoxMotifCR As TextBox
    Friend WithEvents TextBoxPraticien As TextBox
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents ButtonSupprimerCR As Button
End Class

