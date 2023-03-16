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
        Me.LabelVisiteur = New System.Windows.Forms.Label()
        Me.ButtonRediger = New System.Windows.Forms.Button()
        Me.ButtonConsulter = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.PictureBoxHeader = New System.Windows.Forms.PictureBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVisiteur
        '
        Me.LabelVisiteur.AutoSize = True
        Me.LabelVisiteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelVisiteur.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVisiteur.Location = New System.Drawing.Point(371, 170)
        Me.LabelVisiteur.Name = "LabelVisiteur"
        Me.LabelVisiteur.Size = New System.Drawing.Size(114, 35)
        Me.LabelVisiteur.TabIndex = 8
        Me.LabelVisiteur.Text = "Visiteur"
        '
        'ButtonRediger
        '
        Me.ButtonRediger.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRediger.Location = New System.Drawing.Point(200, 288)
        Me.ButtonRediger.Name = "ButtonRediger"
        Me.ButtonRediger.Size = New System.Drawing.Size(165, 51)
        Me.ButtonRediger.TabIndex = 9
        Me.ButtonRediger.Text = "Rédiger un compte-rendu"
        Me.ButtonRediger.UseVisualStyleBackColor = False
        '
        'ButtonConsulter
        '
        Me.ButtonConsulter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonConsulter.Location = New System.Drawing.Point(491, 288)
        Me.ButtonConsulter.Name = "ButtonConsulter"
        Me.ButtonConsulter.Size = New System.Drawing.Size(165, 51)
        Me.ButtonConsulter.TabIndex = 10
        Me.ButtonConsulter.Text = "Consulter mes comptes-rendu"
        Me.ButtonConsulter.UseVisualStyleBackColor = False
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackgroundImage = Global.ConnexionOracle.My.Resources.Resources.retour
        Me.ButtonRetour.Location = New System.Drawing.Point(12, 140)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(55, 50)
        Me.ButtonRetour.TabIndex = 11
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'PictureBoxHeader
        '
        Me.PictureBoxHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBoxHeader.ErrorImage = Nothing
        Me.PictureBoxHeader.Image = Global.ConnexionOracle.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBoxHeader.InitialImage = Nothing
        Me.PictureBoxHeader.Location = New System.Drawing.Point(-2, 26)
        Me.PictureBoxHeader.Name = "PictureBoxHeader"
        Me.PictureBoxHeader.Size = New System.Drawing.Size(1176, 108)
        Me.PictureBoxHeader.TabIndex = 0
        Me.PictureBoxHeader.TabStop = False
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelNom.Location = New System.Drawing.Point(775, 52)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(29, 13)
        Me.LabelNom.TabIndex = 12
        Me.LabelNom.Text = "Nom"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelPrenom.Location = New System.Drawing.Point(775, 90)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(43, 13)
        Me.LabelPrenom.TabIndex = 13
        Me.LabelPrenom.Text = "Prenom"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        '
        'Accueil_Visiteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ButtonConsulter)
        Me.Controls.Add(Me.ButtonRediger)
        Me.Controls.Add(Me.LabelVisiteur)
        Me.Controls.Add(Me.PictureBoxHeader)
        Me.Name = "Accueil_Visiteur"
        Me.Text = "Accueil_Visiteur"
        CType(Me.PictureBoxHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelVisiteur As Label
    Friend WithEvents ButtonRediger As Button
    Friend WithEvents ButtonConsulter As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents PictureBoxHeader As PictureBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents Label1 As Label
End Class
