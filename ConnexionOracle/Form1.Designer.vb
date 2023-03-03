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
        Me.Label_Tables = New System.Windows.Forms.Label()
        Me.ComboBox_Tables = New System.Windows.Forms.ComboBox()
        Me.DataGridView_Tables = New System.Windows.Forms.DataGridView()
        Me.Button_Valider_les_modifications = New System.Windows.Forms.Button()
        Me.GroupBox_Données = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Connexion = New System.Windows.Forms.GroupBox()
        Me.Button_Connexion = New System.Windows.Forms.Button()
        Me.TextBox_MDP = New System.Windows.Forms.TextBox()
        Me.Label_MDP = New System.Windows.Forms.Label()
        Me.Label_Login = New System.Windows.Forms.Label()
        Me.Label_DSN = New System.Windows.Forms.Label()
        Me.TextBox_Login = New System.Windows.Forms.TextBox()
        Me.TextBox_DSN = New System.Windows.Forms.TextBox()
        Me.Button_to_CONNEXION = New System.Windows.Forms.Button()
        CType(Me.DataGridView_Tables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Données.SuspendLayout()
        Me.GroupBox_Connexion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Tables
        '
        Me.Label_Tables.AutoSize = True
        Me.Label_Tables.Location = New System.Drawing.Point(211, 22)
        Me.Label_Tables.Name = "Label_Tables"
        Me.Label_Tables.Size = New System.Drawing.Size(45, 13)
        Me.Label_Tables.TabIndex = 2
        Me.Label_Tables.Text = "Tables :"
        '
        'ComboBox_Tables
        '
        Me.ComboBox_Tables.FormattingEnabled = True
        Me.ComboBox_Tables.Location = New System.Drawing.Point(255, 19)
        Me.ComboBox_Tables.Name = "ComboBox_Tables"
        Me.ComboBox_Tables.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox_Tables.TabIndex = 3
        '
        'DataGridView_Tables
        '
        Me.DataGridView_Tables.AllowUserToOrderColumns = True
        Me.DataGridView_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Tables.Location = New System.Drawing.Point(5, 52)
        Me.DataGridView_Tables.Name = "DataGridView_Tables"
        Me.DataGridView_Tables.RowTemplate.Height = 25
        Me.DataGridView_Tables.Size = New System.Drawing.Size(589, 283)
        Me.DataGridView_Tables.TabIndex = 4
        '
        'Button_Valider_les_modifications
        '
        Me.Button_Valider_les_modifications.Location = New System.Drawing.Point(232, 350)
        Me.Button_Valider_les_modifications.Name = "Button_Valider_les_modifications"
        Me.Button_Valider_les_modifications.Size = New System.Drawing.Size(127, 20)
        Me.Button_Valider_les_modifications.TabIndex = 5
        Me.Button_Valider_les_modifications.Text = "Valider les modifications"
        Me.Button_Valider_les_modifications.UseVisualStyleBackColor = True
        '
        'GroupBox_Données
        '
        Me.GroupBox_Données.Controls.Add(Me.Button_Valider_les_modifications)
        Me.GroupBox_Données.Controls.Add(Me.ComboBox_Tables)
        Me.GroupBox_Données.Controls.Add(Me.Label_Tables)
        Me.GroupBox_Données.Controls.Add(Me.DataGridView_Tables)
        Me.GroupBox_Données.Location = New System.Drawing.Point(10, 111)
        Me.GroupBox_Données.Name = "GroupBox_Données"
        Me.GroupBox_Données.Size = New System.Drawing.Size(599, 383)
        Me.GroupBox_Données.TabIndex = 6
        Me.GroupBox_Données.TabStop = False
        Me.GroupBox_Données.Text = "Données :"
        '
        'GroupBox_Connexion
        '
        Me.GroupBox_Connexion.Controls.Add(Me.Button_Connexion)
        Me.GroupBox_Connexion.Controls.Add(Me.TextBox_MDP)
        Me.GroupBox_Connexion.Controls.Add(Me.Label_MDP)
        Me.GroupBox_Connexion.Controls.Add(Me.Label_Login)
        Me.GroupBox_Connexion.Controls.Add(Me.Label_DSN)
        Me.GroupBox_Connexion.Controls.Add(Me.TextBox_Login)
        Me.GroupBox_Connexion.Controls.Add(Me.TextBox_DSN)
        Me.GroupBox_Connexion.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox_Connexion.Name = "GroupBox_Connexion"
        Me.GroupBox_Connexion.Size = New System.Drawing.Size(599, 95)
        Me.GroupBox_Connexion.TabIndex = 7
        Me.GroupBox_Connexion.TabStop = False
        Me.GroupBox_Connexion.Text = "Connexion :"
        '
        'Button_Connexion
        '
        Me.Button_Connexion.Location = New System.Drawing.Point(473, 34)
        Me.Button_Connexion.Name = "Button_Connexion"
        Me.Button_Connexion.Size = New System.Drawing.Size(75, 31)
        Me.Button_Connexion.TabIndex = 6
        Me.Button_Connexion.Text = "Connexion"
        Me.Button_Connexion.UseVisualStyleBackColor = True
        '
        'TextBox_MDP
        '
        Me.TextBox_MDP.Location = New System.Drawing.Point(267, 59)
        Me.TextBox_MDP.Name = "TextBox_MDP"
        Me.TextBox_MDP.Size = New System.Drawing.Size(115, 20)
        Me.TextBox_MDP.TabIndex = 5
        '
        'Label_MDP
        '
        Me.Label_MDP.AutoSize = True
        Me.Label_MDP.Location = New System.Drawing.Point(191, 62)
        Me.Label_MDP.Name = "Label_MDP"
        Me.Label_MDP.Size = New System.Drawing.Size(77, 13)
        Me.Label_MDP.TabIndex = 4
        Me.Label_MDP.Text = "Mot de passe :"
        '
        'Label_Login
        '
        Me.Label_Login.AutoSize = True
        Me.Label_Login.Location = New System.Drawing.Point(19, 62)
        Me.Label_Login.Name = "Label_Login"
        Me.Label_Login.Size = New System.Drawing.Size(39, 13)
        Me.Label_Login.TabIndex = 3
        Me.Label_Login.Text = "Login :"
        '
        'Label_DSN
        '
        Me.Label_DSN.AutoSize = True
        Me.Label_DSN.Location = New System.Drawing.Point(19, 37)
        Me.Label_DSN.Name = "Label_DSN"
        Me.Label_DSN.Size = New System.Drawing.Size(39, 13)
        Me.Label_DSN.TabIndex = 2
        Me.Label_DSN.Text = "DSN : "
        '
        'TextBox_Login
        '
        Me.TextBox_Login.Location = New System.Drawing.Point(61, 59)
        Me.TextBox_Login.Name = "TextBox_Login"
        Me.TextBox_Login.Size = New System.Drawing.Size(115, 20)
        Me.TextBox_Login.TabIndex = 1
        '
        'TextBox_DSN
        '
        Me.TextBox_DSN.Location = New System.Drawing.Point(61, 34)
        Me.TextBox_DSN.Name = "TextBox_DSN"
        Me.TextBox_DSN.Size = New System.Drawing.Size(115, 20)
        Me.TextBox_DSN.TabIndex = 0
        '
        'Button_to_CONNEXION
        '
        Me.Button_to_CONNEXION.Location = New System.Drawing.Point(150, 518)
        Me.Button_to_CONNEXION.Name = "Button_to_CONNEXION"
        Me.Button_to_CONNEXION.Size = New System.Drawing.Size(312, 51)
        Me.Button_to_CONNEXION.TabIndex = 8
        Me.Button_to_CONNEXION.Text = "CONNEXION"
        Me.Button_to_CONNEXION.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 604)
        Me.Controls.Add(Me.Button_to_CONNEXION)
        Me.Controls.Add(Me.GroupBox_Connexion)
        Me.Controls.Add(Me.GroupBox_Données)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView_Tables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Données.ResumeLayout(False)
        Me.GroupBox_Données.PerformLayout()
        Me.GroupBox_Connexion.ResumeLayout(False)
        Me.GroupBox_Connexion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_Tables As Label
    Friend WithEvents ComboBox_Tables As ComboBox
    Friend WithEvents DataGridView_Tables As DataGridView
    Friend WithEvents Button_Valider_les_modifications As Button
    Friend WithEvents GroupBox_Données As GroupBox
    Friend WithEvents GroupBox_Connexion As GroupBox
    Friend WithEvents Label_Login As Label
    Friend WithEvents Label_DSN As Label
    Friend WithEvents TextBox_Login As TextBox
    Friend WithEvents TextBox_DSN As TextBox
    Friend WithEvents Button_Connexion As Button
    Friend WithEvents TextBox_MDP As TextBox
    Friend WithEvents Label_MDP As Label
    Friend WithEvents Button_to_CONNEXION As Button
End Class
