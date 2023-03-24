Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles

Public Class Voir_reunion

    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter

    Private Sub Voir_reunion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom

        'Récupération des dates de toutes les réunions
        Dim query As String = "SELECT DISTINCT R_DATE
                                FROM reunion
                                WHERE r_id IN
                                    (
                                    SELECT reunion_dv.r_id
                                    FROM reunion_dv
                                    WHERE id ='" & id_utilisateur & "'
                                    )
                                ORDER BY to_date(R_DATE) DESC"

        Dim dt_Date_reu As New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, Form1.myConnection)
        myAdapter.Fill(dt_Date_reu)

        Me.ComboBoxDate.DataSource = dt_Date_reu
        Me.ComboBoxDate.DisplayMember = "R_DATE"
    End Sub

    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
        If type_Utilisateur = "Responsable" Then
            Delegue_Organiser_réunions_mensuelles.Show()
            Me.Close()
        ElseIf type_Utilisateur = "Delegue" Then
            Delegue_Organiser_réunions_mensuelles.Show()
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


    Private Sub ComboBoxDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDate.SelectedIndexChanged
        'Récupération des dates de toutes les réunions
        Dim selectedDataRowView As DataRowView = ComboBoxDate.SelectedItem
        Dim selectedDate As Date = selectedDataRowView("R_DATE")
        Dim query As String = "SELECT R_ID,R_LIEU
                        FROM reunion
                        WHERE R_ID IN
                            (
                            SELECT reunion_dv.R_ID
                            FROM reunion_dv
                            WHERE id ='" & id_utilisateur & "'
                            )
                        AND R_DATE = TO_DATE('" & selectedDate.ToString("dd/MM/yyyy") & "', 'DD/MM/YYYY')"

        Me.ListBox1.Items.Add(selectedDate)

        Dim dt_Lieu_Reu = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, Form1.myConnection)
        myAdapter.Fill(dt_Lieu_Reu)

        Me.ComboBoxLieu.DataSource = dt_Lieu_Reu
        Me.ComboBoxLieu.DisplayMember = "R_LIEU"
        Me.ComboBoxLieu.ValueMember = "R_ID"
    End Sub

    Private Sub ComboBoxLieu_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxLieu.SelectedIndexChanged
        'Clear la listbox au cas ou des Membres y serais déja ajouté
        Me.ListBox1.Items.Clear()

        'SELECT les Membres et leurs quantité associé a la selectionné
        Dim query As String = "SELECT ID FROM REUNION_DV WHERE r_id ='" & ComboBoxLieu.SelectedValue.ToString & "'"
        Dim nom_liste As New List(Of String)
        Dim prenom_liste As New List(Of String)
        Dim id_liste As New List(Of String)
        myCommand.Connection = Form1.myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            id_liste.Add(myReader.GetString(0))
        End While
        myReader.Close()

        'Boucle parcourant tous les Membres associé a la Réunion selectionné
        Dim item As Integer = id_liste.Count - 1
        For index As Integer = 0 To item
            Dim query2 = "SELECT NOM, PRENOM FROM DELEGUE_VISITEUR WHERE ID ='" & id_liste(index) & "'"
            myCommand.Connection = Form1.myConnection
            myCommand.CommandText = query2
            myReader = myCommand.ExecuteReader
            While myReader.Read
                nom_liste.Add(myReader.GetString(0))
                prenom_liste.Add(myReader.GetString(1))
            End While
            myReader.Close()
            Me.ListBox1.Items.Add(nom_liste(index) & " " & prenom_liste(index))
        Next
    End Sub
End Class