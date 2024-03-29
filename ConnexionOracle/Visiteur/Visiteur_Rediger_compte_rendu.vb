﻿Imports System.EventArgs
Imports System.Text.RegularExpressions

Public Class Visiteur_Rediger_compte_rendu

    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter

    'Initialisation de tous les ComboBox et les Label de la page
    Private Sub Rediger_compte_rendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initiation des 2 label Nom et Prenom de l'utilisateur
        Label_Prenom.Text = Prenom
        Label_Nom.Text = Nom

        'Récupération des médicaments pour remplir ComboBoxMedicaments
        Dim selectNomMedic As String = "SELECT M_NOM,M_ID FROM medicaments order by M_NOM"
        Dim dt_medicaments As New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(selectNomMedic, Form1.myConnection)
        myAdapter.Fill(dt_medicaments)

        Me.ComboBoxMedicaments.DataSource = dt_medicaments
        Me.ComboBoxMedicaments.DisplayMember = "M_NOM"
        Me.ComboBoxMedicaments.ValueMember = "M_ID"

        'Récupération des Praticien pour remplir ComboBoxPraticien
        Dim selectCoorPraticien As String = "SELECT P_ID,P_NOM|| ' ' ||P_PRENOM As P_AFFICHE
                                               FROM PRATICIEN order by P_NOM;"
        Dim dt_praticien As New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(selectCoorPraticien, Form1.myConnection)
        myAdapter.Fill(dt_praticien)

        Me.ComboBoxPraticien.DataSource = dt_praticien
        Me.ComboBoxPraticien.DisplayMember = "P_AFFICHE"
        Me.ComboBoxPraticien.ValueMember = "P_ID"

    End Sub

    'Obliger TextBox1 à accepter que des chiffres
    Private Sub TextBoxQuantite_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxQuantite.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Ajoute un médicament à DataGridViewMedicaments (la liste de médicaments) avec sa quantite et son id
    Private Sub ButtonAjouterMedicaments_Click(sender As Object, e As EventArgs) Handles ButtonAjouterMedicaments.Click

        'Instanciation de variable
        Dim existe_pas As Boolean = True
        Dim NB_Colonne_Datagrid As Integer = Me.DataGridViewMedicaments.Rows.Count

        'Boucle comparant les médicaments déjà ajouté pour ne pas ajouter plusieurs fois le même médicament
        For i As Integer = 0 To NB_Colonne_Datagrid - 1
            If ComboBoxMedicaments.SelectedValue = Me.DataGridViewMedicaments.Rows.Item(i).Cells.Item(2).Value Then
                existe_pas = False
            End If
        Next

        'Si le medicaments n'a pas été ajouté alors on l'ajoute
        If existe_pas Then
            'On vérifie que l'utilisateur a bien rentré une valeur numérique
            If Not IsNumeric(TextBoxQuantite.Text) Then
                MsgBox("Saisissez une valeur numérique !", vbExclamation, "Erreur de saisie")
                Exit Sub
            Else
                'Ajout de la ligne a la liste
                Me.DataGridViewMedicaments.Rows.Add()
                Me.DataGridViewMedicaments.Rows.Item(NB_Colonne_Datagrid - 1).Cells.Item(0).Value = CInt(TextBoxQuantite.Text)
                Me.DataGridViewMedicaments.Rows.Item(NB_Colonne_Datagrid - 1).Cells.Item(1).Value = ComboBoxMedicaments.Text
                Me.DataGridViewMedicaments.Rows.Item(NB_Colonne_Datagrid - 1).Cells.Item(2).Value = ComboBoxMedicaments.SelectedValue
            End If
        Else
            'Sinon on avertit l'utilisateur
            MsgBox("Médicament déjà ajouté !", vbExclamation, "Erreur de saisie")
        End If

    End Sub

    'Permet de voir les détails du médicaments sélectionné
    Private Sub ButtonVoirMedicaments_Click(sender As Object, e As EventArgs) Handles ButtonVoirMedicaments.Click
        nom_medicaments = ComboBoxMedicaments.Text
        Voir_Medicament.Show()
    End Sub

    'Permet de supprimer la ligne du médicaments sélectionné
    Private Sub ButtonSupprimerLigneSelectionne_Click(sender As Object, e As EventArgs) Handles ButtonSupprimerLigneSelectionne.Click
        'Vérifie que l'utilisateur ne supprime pas toutes les cases de la liste
        Dim x As Integer = Me.DataGridViewMedicaments.CurrentRow.Index()
        Try
            Me.DataGridViewMedicaments.Rows.RemoveAt(x)
        Catch ex As Exception
            MsgBox("Vous ne pouvez pas supprimer la dernière ligne", vbExclamation, "Erreur")
        End Try

    End Sub


    'Insère le compte rendu dans la BDD
    Private Sub ButtonCreerCompteRendu_Click(sender As Object, e As EventArgs) Handles ButtonCreerCompteRendu.Click
        'Vérifie que l'utilisateur à bien ajouté un titre
        If TextBoxMotif.Text = "" Then
            MessageBox.Show("Vous n'avez pas donné de nom à votre compte-rendu")
        Else
            'insertion du compte-rendu
            Dim insertCompteRendu As String = "INSERT INTO compte_rendu(cr_date, cr_modif,P_ID,ID) values (to_date('" & DateTimePicker.Value.Date.ToString("dd-MM-yyyy") & "', 'DD/MM/YYYY'), '" & Regex.Replace(TextBoxMotif.Text, "[^a-zA-Z0-9\s(),.]", "") & "', '" & ComboBoxPraticien.SelectedValue & "', '" & id_utilisateur & "')"
            myCommand.Connection = Form1.myConnection
            myCommand.CommandText = insertCompteRendu
            myCommand.ExecuteNonQuery()

            'recuperation de l'id du dernier compte-rendu
            Dim plus_grand_id_CR As String = "SELECT cr_id FROM COMPTE_RENDU ORDER BY CAST(cr_id AS DECIMAL(5,2))"
            myCommand.Connection = Form1.myConnection
            myCommand.CommandText = plus_grand_id_CR
            myReader = myCommand.ExecuteReader
            Dim id_cr As String = ""
            While myReader.Read
                id_cr = myReader.GetString(0)
            End While
            myReader.Close()

            id_cr = (id_cr)

            'Association des medicaments liés au compte-rendu
            Dim insertQuantiteCompteRendu As String
            Dim item As Integer = Me.DataGridViewMedicaments.RowCount - 2
            Dim quantite As Integer = 0
            Dim id_medicament As Integer
            Dim Est_Numerique As Boolean = True

            'Boucle ajoutant chaque medicament et leur quantite
            For index As Integer = 0 To item
                Try
                    quantite = Me.DataGridViewMedicaments.Rows.Item(index).Cells.Item(0).Value
                    id_medicament = Me.DataGridViewMedicaments.Rows.Item(index).Cells.Item(2).Value
                Catch ex As Exception
                    Est_Numerique = False
                End Try

                If Me.DataGridViewMedicaments.Rows.Item(index).Cells.Item(1).Value = "" Then
                    MessageBox.Show("Le numero ==> '" + quantite + "' n'a pas de medicaments associé !")
                ElseIf Est_Numerique Then
                    insertQuantiteCompteRendu = "INSERT INTO quantite(CR_ID, M_ID, quantite) values ('" & id_cr & "','" & id_medicament & "','" & quantite & "')"
                    myCommand.Connection = Form1.myConnection
                    myCommand.CommandText = insertQuantiteCompteRendu
                    myCommand.ExecuteNonQuery()
                Else
                    Dim chaine As String = "L'élément numéro " & DataGridViewMedicaments.Rows.Item(index).Cells.Item(0).Value & "' n'est pas un nombre"
                    MessageBox.Show(chaine)
                End If
            Next

            MessageBox.Show("Compte Rendu Réalisé")

            'Sortie de la page 
            If type_Utilisateur = "Responsable" Then
                Accueil_responsable.Show()
                Me.Close()
            ElseIf type_Utilisateur = "Delegue" Then
                Accueil_Delegue.Show()
                Me.Close()
            ElseIf type_Utilisateur = "Visiteur" Then
                Accueil_Visiteur.Show()
                Me.Close()
            Else
                type_Utilisateur = ""
                Show()
                Me.Close()
            End If

        End If
    End Sub

    'Button servant à revenir en arrière (grâce à la variable type_utilisateur)
    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        If type_Utilisateur = "Responsable" Then
            Accueil_responsable.Show()
            Me.Close()
        ElseIf type_Utilisateur = "Delegue" Then
            Accueil_Delegue.Show()
            Me.Close()
        ElseIf type_Utilisateur = "Visiteur" Then
            Accueil_Visiteur.Show()
            Me.Close()
        Else
            type_Utilisateur = ""
            Show()
            Me.Close()
        End If
    End Sub

End Class