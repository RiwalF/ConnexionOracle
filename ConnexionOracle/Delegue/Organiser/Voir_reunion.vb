Imports System.Data.Common
Imports System.Windows.Forms.VisualStyles

Public Class Voir_reunion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myCommand2 As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myAdapter2 As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim myBuilder2 As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function
    Private Sub Voir_reunion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connString = "DSN=RN_SLAM1;Uid=slam1;Pwd=SLAMRN2022;"

        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        Label_Nom.Text = Nom
        Label_Prenom.Text = Prenom

        'Récupération des dates de toutes les réunions
        ComboBoxDate.Items.Clear()
        Dim query As String = "SELECT DISTINCT R_DATE
                                FROM reunion
                                WHERE r_id IN
                                    (
                                    SELECT reunion_dv.r_id
                                    FROM reunion_dv
                                    WHERE id ='" & id_utilisateur & "'
                                    )"

        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)

        Dim dt As New DataTable
        dt.Columns.Add("R_DATE")

        For Each unItem In donnee.Rows
            dt.Rows.Add(RemoveWhitespace(unItem("R_DATE")))
        Next

        Me.ComboBoxDate.DataSource = dt
        Me.ComboBoxDate.DisplayMember = "R_DATE"
        donnee.Clear()

    End Sub
    Private Sub Button_retour_Click(sender As Object, e As EventArgs) Handles Button_retour.Click
        Delegue_Organiser_réunions_mensuelles.Show()
        Me.Close()
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

        donnee = New DataTable
        myAdapter2 = New Odbc.OdbcDataAdapter(query, myConnection)
        myBuilder2 = New Odbc.OdbcCommandBuilder(myAdapter2)
        myAdapter2.Fill(donnee)

        Dim dt As New DataTable
        dt.Columns.Add("R_ID")
        dt.Columns.Add("R_LIEU")

        For Each unItem In donnee.Rows
            dt.Rows.Add(unItem("R_ID"), unItem("R_LIEU"))
        Next

        Me.ComboBoxLieu.DataSource = dt
        Me.ComboBoxLieu.DisplayMember = "R_LIEU"
        Me.ComboBoxLieu.ValueMember = "R_ID"
        donnee.Clear()
    End Sub

    Private Sub ComboBoxLieu_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxLieu.SelectedIndexChanged
        'Clear la listbox au cas ou des Membres y serais déja ajouté
        Me.ListBox1.Items.Clear()

        'SELECT les Membres et leurs quantité associé a la selectionné
        Dim query As String = "SELECT ID FROM REUNION_DV WHERE r_id ='" & ComboBoxLieu.SelectedValue.ToString & "'"
        Dim nom_liste As New List(Of String)
        Dim prenom_liste As New List(Of String)
        Dim id_liste As New List(Of String)
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            id_liste.Add(RemoveWhitespace(myReader.GetString(0)))
        End While
        myReader.Close()

        'Boucle parcourant tous les Membres associé a la Réunion selectionné
        Dim item As Integer = id_liste.Count - 1
        For index As Integer = 0 To item
            Dim query2 = "SELECT NOM, PRENOM FROM DELEGUE_VISITEUR WHERE ID ='" & id_liste(index) & "'"
            myCommand.Connection = myConnection
            myCommand.CommandText = query2
            myReader = myCommand.ExecuteReader
            While myReader.Read
                nom_liste.Add(myReader.GetString(0))
                prenom_liste.Add(myReader.GetString(1))
            End While
            myReader.Close()
            Me.ListBox1.Items.Add(RemoveWhitespace(nom_liste(index)) & " " & RemoveWhitespace(prenom_liste(index)))
        Next
    End Sub
End Class