<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Voir_Medicament
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelEffet = New System.Windows.Forms.Label()
        Me.LabelFamille = New System.Windows.Forms.Label()
        Me.LabelNomAffiche = New System.Windows.Forms.Label()
        Me.LabelEffetAffiche = New System.Windows.Forms.Label()
        Me.LabelFamilleAffiche = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = Global.ConnexionOracle.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(315, 108)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(39, 158)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(54, 24)
        Me.LabelNom.TabIndex = 16
        Me.LabelNom.Text = "Nom"
        '
        'LabelEffet
        '
        Me.LabelEffet.AutoSize = True
        Me.LabelEffet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEffet.Location = New System.Drawing.Point(39, 251)
        Me.LabelEffet.Name = "LabelEffet"
        Me.LabelEffet.Size = New System.Drawing.Size(51, 24)
        Me.LabelEffet.TabIndex = 17
        Me.LabelEffet.Text = "Effet"
        '
        'LabelFamille
        '
        Me.LabelFamille.AutoSize = True
        Me.LabelFamille.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFamille.Location = New System.Drawing.Point(39, 337)
        Me.LabelFamille.Name = "LabelFamille"
        Me.LabelFamille.Size = New System.Drawing.Size(78, 24)
        Me.LabelFamille.TabIndex = 18
        Me.LabelFamille.Text = "Famille"
        '
        'LabelNomAffiche
        '
        Me.LabelNomAffiche.AutoSize = True
        Me.LabelNomAffiche.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelNomAffiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomAffiche.Location = New System.Drawing.Point(39, 206)
        Me.LabelNomAffiche.Name = "LabelNomAffiche"
        Me.LabelNomAffiche.Size = New System.Drawing.Size(154, 24)
        Me.LabelNomAffiche.TabIndex = 19
        Me.LabelNomAffiche.Text = "LabelNomAffiche"
        '
        'LabelEffetAffiche
        '
        Me.LabelEffetAffiche.AutoSize = True
        Me.LabelEffetAffiche.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelEffetAffiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEffetAffiche.Location = New System.Drawing.Point(39, 295)
        Me.LabelEffetAffiche.Name = "LabelEffetAffiche"
        Me.LabelEffetAffiche.Size = New System.Drawing.Size(149, 24)
        Me.LabelEffetAffiche.TabIndex = 20
        Me.LabelEffetAffiche.Text = "LabelEffetAffiche"
        '
        'LabelFamilleAffiche
        '
        Me.LabelFamilleAffiche.AutoSize = True
        Me.LabelFamilleAffiche.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelFamilleAffiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFamilleAffiche.Location = New System.Drawing.Point(39, 382)
        Me.LabelFamilleAffiche.Name = "LabelFamilleAffiche"
        Me.LabelFamilleAffiche.Size = New System.Drawing.Size(174, 24)
        Me.LabelFamilleAffiche.TabIndex = 21
        Me.LabelFamilleAffiche.Text = "LabelFamilleAffiche"
        '
        'Voir_Medicament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(304, 450)
        Me.Controls.Add(Me.LabelFamilleAffiche)
        Me.Controls.Add(Me.LabelEffetAffiche)
        Me.Controls.Add(Me.LabelNomAffiche)
        Me.Controls.Add(Me.LabelFamille)
        Me.Controls.Add(Me.LabelEffet)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Voir_Medicament"
        Me.Text = "Voir"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelEffet As Label
    Friend WithEvents LabelFamille As Label
    Friend WithEvents LabelNomAffiche As Label
    Friend WithEvents LabelEffetAffiche As Label
    Friend WithEvents LabelFamilleAffiche As Label
End Class
