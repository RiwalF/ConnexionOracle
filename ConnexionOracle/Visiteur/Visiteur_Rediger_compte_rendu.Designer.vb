<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visiteur_Rediger_compte_rendu
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
        Me.LabelRedigerUnCompteRendu = New System.Windows.Forms.Label()
        Me.Label_Prenom = New System.Windows.Forms.Label()
        Me.Label_Nom = New System.Windows.Forms.Label()
        Me.ComboBoxMedicaments = New System.Windows.Forms.ComboBox()
        Me.TextBoxQuantite = New System.Windows.Forms.TextBox()
        Me.ComboBoxPraticien = New System.Windows.Forms.ComboBox()
        Me.ButtonCreerCompteRendu = New System.Windows.Forms.Button()
        Me.LabelPraticien = New System.Windows.Forms.Label()
        Me.LabelMedicaments = New System.Windows.Forms.Label()
        Me.LabelQuantite = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxMotif = New System.Windows.Forms.TextBox()
        Me.LabelMotif = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.ButtonVoirMedicaments = New System.Windows.Forms.Button()
        Me.PictureBoxHeader = New System.Windows.Forms.PictureBox()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ButtonAjouterMedicaments = New System.Windows.Forms.Button()
        Me.LabelMedicamentsSelectionne = New System.Windows.Forms.Label()
        Me.DataGridViewMedicaments = New System.Windows.Forms.DataGridView()
        Me.quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medicament = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSupprimerLigneSelectionne = New System.Windows.Forms.Button()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewMedicaments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelRedigerUnCompteRendu
        '
        Me.LabelRedigerUnCompteRendu.AutoSize = True
        Me.LabelRedigerUnCompteRendu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelRedigerUnCompteRendu.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRedigerUnCompteRendu.Location = New System.Drawing.Point(249, 147)
        Me.LabelRedigerUnCompteRendu.Name = "LabelRedigerUnCompteRendu"
        Me.LabelRedigerUnCompteRendu.Size = New System.Drawing.Size(347, 35)
        Me.LabelRedigerUnCompteRendu.TabIndex = 9
        Me.LabelRedigerUnCompteRendu.Text = "Rédiger un compte-rendu"
        '
        'Label_Prenom
        '
        Me.Label_Prenom.AutoSize = True
        Me.Label_Prenom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Prenom.Location = New System.Drawing.Point(789, 90)
        Me.Label_Prenom.Name = "Label_Prenom"
        Me.Label_Prenom.Size = New System.Drawing.Size(0, 13)
        Me.Label_Prenom.TabIndex = 16
        '
        'Label_Nom
        '
        Me.Label_Nom.AutoSize = True
        Me.Label_Nom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label_Nom.Location = New System.Drawing.Point(789, 52)
        Me.Label_Nom.Name = "Label_Nom"
        Me.Label_Nom.Size = New System.Drawing.Size(0, 13)
        Me.Label_Nom.TabIndex = 15
        '
        'ComboBoxMedicaments
        '
        Me.ComboBoxMedicaments.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxMedicaments.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxMedicaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMedicaments.FormattingEnabled = True
        Me.ComboBoxMedicaments.Location = New System.Drawing.Point(117, 238)
        Me.ComboBoxMedicaments.Name = "ComboBoxMedicaments"
        Me.ComboBoxMedicaments.Size = New System.Drawing.Size(222, 21)
        Me.ComboBoxMedicaments.TabIndex = 17
        Me.ComboBoxMedicaments.DropDownStyle = ComboBoxStyle.DropDownList
        '
        'TextBoxQuantite
        '
        Me.TextBoxQuantite.Location = New System.Drawing.Point(117, 278)
        Me.TextBoxQuantite.MaxLength = 9
        Me.TextBoxQuantite.Name = "TextBoxQuantite"
        Me.TextBoxQuantite.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxQuantite.TabIndex = 18
        '
        'ComboBoxPraticien
        '
        Me.ComboBoxPraticien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxPraticien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxPraticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPraticien.FormattingEnabled = True
        Me.ComboBoxPraticien.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBoxPraticien.Location = New System.Drawing.Point(117, 317)
        Me.ComboBoxPraticien.Name = "ComboBoxPraticien"
        Me.ComboBoxPraticien.Size = New System.Drawing.Size(390, 21)
        Me.ComboBoxPraticien.TabIndex = 20
        Me.ComboBoxPraticien.DropDownStyle = ComboBoxStyle.DropDownList
        '
        'ButtonCreerCompteRendu
        '
        Me.ButtonCreerCompteRendu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCreerCompteRendu.Location = New System.Drawing.Point(117, 427)
        Me.ButtonCreerCompteRendu.Name = "ButtonCreerCompteRendu"
        Me.ButtonCreerCompteRendu.Size = New System.Drawing.Size(390, 23)
        Me.ButtonCreerCompteRendu.TabIndex = 22
        Me.ButtonCreerCompteRendu.Text = "Créer Compte-Rendu"
        Me.ButtonCreerCompteRendu.UseVisualStyleBackColor = False
        '
        'LabelPraticien
        '
        Me.LabelPraticien.AutoSize = True
        Me.LabelPraticien.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPraticien.Location = New System.Drawing.Point(29, 317)
        Me.LabelPraticien.Name = "LabelPraticien"
        Me.LabelPraticien.Size = New System.Drawing.Size(81, 17)
        Me.LabelPraticien.TabIndex = 24
        Me.LabelPraticien.Text = "Praticiens :"
        '
        'LabelMedicaments
        '
        Me.LabelMedicaments.AutoSize = True
        Me.LabelMedicaments.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMedicaments.Location = New System.Drawing.Point(7, 242)
        Me.LabelMedicaments.Name = "LabelMedicaments"
        Me.LabelMedicaments.Size = New System.Drawing.Size(103, 17)
        Me.LabelMedicaments.TabIndex = 26
        Me.LabelMedicaments.Text = "Médicaments :"
        '
        'LabelQuantite
        '
        Me.LabelQuantite.AutoSize = True
        Me.LabelQuantite.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuantite.Location = New System.Drawing.Point(39, 278)
        Me.LabelQuantite.Name = "LabelQuantite"
        Me.LabelQuantite.Size = New System.Drawing.Size(71, 17)
        Me.LabelQuantite.TabIndex = 27
        Me.LabelQuantite.Text = "Quantité :"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(117, 353)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(390, 20)
        Me.DateTimePicker.TabIndex = 28
        '
        'TextBoxMotif
        '
        Me.TextBoxMotif.Location = New System.Drawing.Point(117, 388)
        Me.TextBoxMotif.MaxLength = 32
        Me.TextBoxMotif.Name = "TextBoxMotif"
        Me.TextBoxMotif.Size = New System.Drawing.Size(390, 20)
        Me.TextBoxMotif.TabIndex = 29
        '
        'LabelMotif
        '
        Me.LabelMotif.AutoSize = True
        Me.LabelMotif.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMotif.Location = New System.Drawing.Point(64, 391)
        Me.LabelMotif.Name = "LabelMotif"
        Me.LabelMotif.Size = New System.Drawing.Size(46, 17)
        Me.LabelMotif.TabIndex = 30
        Me.LabelMotif.Text = "Motif :"
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(7, 353)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(104, 17)
        Me.LabelDate.TabIndex = 31
        Me.LabelDate.Text = "Date de visite :"
        '
        'ButtonVoirMedicaments
        '
        Me.ButtonVoirMedicaments.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonVoirMedicaments.Location = New System.Drawing.Point(429, 238)
        Me.ButtonVoirMedicaments.Name = "ButtonVoirMedicaments"
        Me.ButtonVoirMedicaments.Size = New System.Drawing.Size(78, 60)
        Me.ButtonVoirMedicaments.TabIndex = 32
        Me.ButtonVoirMedicaments.Text = "Voir médicaments"
        Me.ButtonVoirMedicaments.UseVisualStyleBackColor = False
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxHeader.ErrorImage = Nothing
        Me.PictureBoxHeader.Image = Global.ConnexionOracle.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBoxHeader.InitialImage = Nothing
        Me.PictureBoxHeader.Location = New System.Drawing.Point(-1, 26)
        Me.PictureBoxHeader.Name = "PictureBoxHeader"
        Me.PictureBoxHeader.Size = New System.Drawing.Size(1176, 108)
        Me.PictureBoxHeader.TabIndex = 14
        Me.PictureBoxHeader.TabStop = False
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackgroundImage = Global.ConnexionOracle.My.Resources.Resources.retour
        Me.ButtonRetour.Location = New System.Drawing.Point(12, 140)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(55, 50)
        Me.ButtonRetour.TabIndex = 33
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'ButtonAjouterMedicaments
        '
        Me.ButtonAjouterMedicaments.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAjouterMedicaments.Location = New System.Drawing.Point(345, 238)
        Me.ButtonAjouterMedicaments.Name = "ButtonAjouterMedicaments"
        Me.ButtonAjouterMedicaments.Size = New System.Drawing.Size(78, 60)
        Me.ButtonAjouterMedicaments.TabIndex = 19
        Me.ButtonAjouterMedicaments.Text = "Ajouter médicaments"
        Me.ButtonAjouterMedicaments.UseVisualStyleBackColor = False
        '
        'LabelMedicamentsSelectionne
        '
        Me.LabelMedicamentsSelectionne.AutoSize = True
        Me.LabelMedicamentsSelectionne.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMedicamentsSelectionne.Location = New System.Drawing.Point(605, 202)
        Me.LabelMedicamentsSelectionne.Name = "LabelMedicamentsSelectionne"
        Me.LabelMedicamentsSelectionne.Size = New System.Drawing.Size(173, 17)
        Me.LabelMedicamentsSelectionne.TabIndex = 41
        Me.LabelMedicamentsSelectionne.Text = "Médicaments sélectionné"
        '
        'DataGridViewMedicaments
        '
        Me.DataGridViewMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMedicaments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.quantite, Me.medicament, Me.id})
        Me.DataGridViewMedicaments.Location = New System.Drawing.Point(540, 238)
        Me.DataGridViewMedicaments.Name = "DataGridViewMedicaments"
        Me.DataGridViewMedicaments.Size = New System.Drawing.Size(305, 212)
        Me.DataGridViewMedicaments.TabIndex = 42
        '
        'quantite
        '
        Me.quantite.Frozen = True
        Me.quantite.HeaderText = "Quantité"
        Me.quantite.MaxInputLength = 9
        Me.quantite.Name = "quantite"
        Me.quantite.ReadOnly = True
        Me.quantite.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.quantite.Width = 50
        '
        'medicament
        '
        Me.medicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.medicament.Frozen = True
        Me.medicament.HeaderText = "Médicament"
        Me.medicament.Name = "medicament"
        Me.medicament.ReadOnly = True
        Me.medicament.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.medicament.Width = 212
        '
        'id
        '
        Me.id.Frozen = True
        Me.id.HeaderText = "Identifiant"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'ButtonSupprimerLigneSelectionne
        '
        Me.ButtonSupprimerLigneSelectionne.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonSupprimerLigneSelectionne.Location = New System.Drawing.Point(540, 456)
        Me.ButtonSupprimerLigneSelectionne.Name = "ButtonSupprimerLigneSelectionne"
        Me.ButtonSupprimerLigneSelectionne.Size = New System.Drawing.Size(305, 31)
        Me.ButtonSupprimerLigneSelectionne.TabIndex = 43
        Me.ButtonSupprimerLigneSelectionne.Text = "Supprimer ligne seléctionné"
        Me.ButtonSupprimerLigneSelectionne.UseVisualStyleBackColor = False
        '
        'Visiteur_Rediger_compte_rendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.ButtonSupprimerLigneSelectionne)
        Me.Controls.Add(Me.DataGridViewMedicaments)
        Me.Controls.Add(Me.LabelMedicamentsSelectionne)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ButtonVoirMedicaments)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelMotif)
        Me.Controls.Add(Me.TextBoxMotif)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.LabelQuantite)
        Me.Controls.Add(Me.LabelMedicaments)
        Me.Controls.Add(Me.LabelPraticien)
        Me.Controls.Add(Me.ButtonCreerCompteRendu)
        Me.Controls.Add(Me.ComboBoxPraticien)
        Me.Controls.Add(Me.ButtonAjouterMedicaments)
        Me.Controls.Add(Me.TextBoxQuantite)
        Me.Controls.Add(Me.ComboBoxMedicaments)
        Me.Controls.Add(Me.Label_Prenom)
        Me.Controls.Add(Me.Label_Nom)
        Me.Controls.Add(Me.LabelRedigerUnCompteRendu)
        Me.Controls.Add(Me.PictureBoxHeader)
        Me.Name = "Visiteur_Rediger_compte_rendu"
        Me.Text = "Rediger_compte_rendu"
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewMedicaments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub




    Friend WithEvents LabelRedigerUnCompteRendu As Label
    Friend WithEvents Label_Prenom As Label
    Friend WithEvents Label_Nom As Label
    Friend WithEvents PictureBoxHeader As PictureBox
    Friend WithEvents ComboBoxMedicaments As ComboBox
    Friend WithEvents TextBoxQuantite As TextBox
    Friend WithEvents ComboBoxPraticien As ComboBox
    Friend WithEvents ButtonCreerCompteRendu As Button
    Friend WithEvents LabelPraticien As Label
    Friend WithEvents LabelMedicaments As Label
    Friend WithEvents LabelQuantite As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents TextBoxMotif As TextBox
    Friend WithEvents LabelMotif As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents ButtonVoirMedicaments As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents ButtonAjouterMedicaments As Button
    Friend WithEvents LabelMedicamentsSelectionne As Label
    Friend WithEvents DataGridViewMedicaments As DataGridView
    Friend WithEvents ButtonSupprimerLigneSelectionne As Button
    Friend WithEvents quantite As DataGridViewTextBoxColumn
    Friend WithEvents medicament As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
End Class