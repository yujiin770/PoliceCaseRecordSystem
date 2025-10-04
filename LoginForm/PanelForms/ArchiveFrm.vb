Public Class ArchiveFrm

    Sub LoadArchivedData()
        ' Get the values from your new filter controls
        Dim searchTerm As String = txtArchiveSearch.Text.Trim()
        Dim startDate As Date = dtpStartDate.Value
        Dim endDate As Date = dtpEndDate.Value

        ' Call the new filtered function
        dgvArchivedCases.DataSource = GetFilteredArchivedCases(searchTerm, startDate, endDate)
        StyleArchivedGrid() ' Apply styling
    End Sub


    Private Sub StyleArchivedGrid()
        ' --- Ensure Header is Visible ---
        dgvArchivedCases.ColumnHeadersVisible = True
        dgvArchivedCases.EnableHeadersVisualStyles = False

        If dgvArchivedCases.Columns.Contains("colView") Then
            dgvArchivedCases.Columns.Remove("colView")
        End If

        ' --- Main Grid Appearance ---
        dgvArchivedCases.BorderStyle = BorderStyle.None
        dgvArchivedCases.BackgroundColor = Color.WhiteSmoke
        dgvArchivedCases.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvArchivedCases.RowHeadersVisible = False
        dgvArchivedCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvArchivedCases.ReadOnly = True
        dgvArchivedCases.AllowUserToAddRows = False
        dgvArchivedCases.AllowUserToResizeRows = False

        ' --- Column Header Styling ---
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.BackColor = Color.FromArgb(148, 41, 34)
        headerStyle.ForeColor = Color.White
        headerStyle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvArchivedCases.ColumnHeadersDefaultCellStyle = headerStyle
        dgvArchivedCases.ColumnHeadersHeight = 40
        dgvArchivedCases.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        ' --- Row Styling ---
        Dim defaultRowStyle As New DataGridViewCellStyle()
        defaultRowStyle.BackColor = Color.White
        defaultRowStyle.ForeColor = Color.FromArgb(40, 40, 40)
        defaultRowStyle.SelectionBackColor = Color.FromArgb(255, 224, 220)
        defaultRowStyle.SelectionForeColor = Color.Black
        defaultRowStyle.Font = New Font("Segoe UI", 9.5F)
        defaultRowStyle.Padding = New Padding(5, 0, 5, 0)
        dgvArchivedCases.DefaultCellStyle = defaultRowStyle
        dgvArchivedCases.RowTemplate.Height = 35

        ' --- Alternating Row Styling ---
        dgvArchivedCases.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

        ' --- Hide the IncidentID column ---
        If dgvArchivedCases.Columns.Contains("IncidentID") Then
            dgvArchivedCases.Columns("IncidentID").Visible = False
        End If

        ' --- Column Sizing ---
        dgvArchivedCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvArchivedCases.Columns.Count > 5 Then
            dgvArchivedCases.Columns("CaseNumber").FillWeight = 25
            dgvArchivedCases.Columns("IncidentDate").FillWeight = 30
            dgvArchivedCases.Columns("Status").FillWeight = 40
            dgvArchivedCases.Columns("Priority").FillWeight = 25
            dgvArchivedCases.Columns("LastModifiedTimestamp").HeaderText = "Date Closed"
            dgvArchivedCases.Columns("LastModifiedTimestamp").FillWeight = 40
        End If

        ' --- ADD VIEW BUTTON COLUMN ---
        Dim viewButtonCol As New DataGridViewButtonColumn()
        viewButtonCol.Name = "colView"
        viewButtonCol.HeaderText = "Action"
        viewButtonCol.Text = "View"
        viewButtonCol.UseColumnTextForButtonValue = True
        viewButtonCol.FlatStyle = FlatStyle.Flat
        viewButtonCol.DefaultCellStyle.BackColor = Color.FromArgb(60, 141, 188) ' Blue
        viewButtonCol.DefaultCellStyle.ForeColor = Color.White
        viewButtonCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        viewButtonCol.Width = 80
        dgvArchivedCases.Columns.Add(viewButtonCol)
    End Sub

    ' --- ADD THIS NEW SUBROUTINE ---
    Private Sub InitializeFilters()
        ' Set a default date range, for example, the last year.
        dtpStartDate.Value = Date.Now.AddYears(-1)
        dtpEndDate.Value = Date.Now
    End Sub

    ' --- ADD THIS NEW EVENT HANDLER for all filter controls ---
    Private Sub Filters_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles txtArchiveSearch.TextChanged, dtpStartDate.ValueChanged, dtpEndDate.ValueChanged
        LoadArchivedData()
    End Sub

    ' --- ADD THIS NEW EVENT HANDLER for the clear button ---
    Private Sub btnClearFilters_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearFilters.Click
        txtArchiveSearch.Clear()
        InitializeFilters() ' This resets the date pickers
        LoadArchivedData()
    End Sub


    Private Sub ArchiveFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeFilters() ' Set up the filters first
        LoadArchivedData()  ' Then load the data

        ' Security for the Re-open button (remains the same)
        If SESSION IsNot Nothing AndAlso SESSION("Role").ToString() <> "Admin" Then
            btnReopenCase.Enabled = False
            btnReopenCase.Visible = False
            btnDeleteRecord.Enabled = False
            btnDeleteRecord.Visible = False
            btnClearFilters.Location = New Point(784, 546)
        Else
            btnReopenCase.Visible = True
            btnReopenCase.Enabled = True
            btnDeleteRecord.Enabled = True
            btnDeleteRecord.Visible = True
        End If
    End Sub

    Private Sub btnReopenCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReopenCase.Click
        If dgvArchivedCases.SelectedRows.Count = 0 Then
            MsgBox("Please select a case from the grid to re-open.", MsgBoxStyle.Information, "No Case Selected")
            Return
        End If

        ' Get the ID and Case Number from the selected row.
        Dim selectedID As Integer = CInt(dgvArchivedCases.SelectedRows(0).Cells("IncidentID").Value)
        Dim caseNumber As String = dgvArchivedCases.SelectedRows(0).Cells("CaseNumber").Value.ToString()

        ' Ask for confirmation
        Dim result = MsgBox("Are you sure you want to re-open Case #" & caseNumber & "? " &
                              "Its status will be set to 'Under Investigation' and it will be moved back to the active records list.",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                              "Confirm Re-Open")

        ' If the user clicks "Yes"
        If result = MsgBoxResult.Yes Then
            ' Call new utility function to update the database.
            If ReopenCase(selectedID) Then
                MsgBox("Case #" & caseNumber & " has been successfully re-opened.", MsgBoxStyle.Information, "Success")
                Dashboard.LoadDashboardStats()
                Dashboard.LoadCaseTypeChart()
                Dashboard.LoadRecentCases()
                LoadArchivedData()
            Else
                MsgBox("Failed to re-open the case.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub dgvArchivedCases_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArchivedCases.CellContentClick
        If e.RowIndex < 0 Then Return

        ' --- HANDLE VIEW BUTTON CLICK ---
        If dgvArchivedCases.Columns(e.ColumnIndex).Name = "colView" Then
            ' Get the IncidentID from the hidden column of the clicked row
            Dim selectedID As Integer = CInt(dgvArchivedCases.Rows(e.RowIndex).Cells("IncidentID").Value)

            ' Create an instance of your ViewCase form
            Dim viewForm As New ViewCase()
            viewForm.SelectedIncidentID = selectedID
            viewForm.ShowDialog()
            viewForm.Label2.Text = "Closed Case"
        End If
    End Sub

    Private Sub dgvArchivedCases_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvArchivedCases.CellFormatting
        If e.RowIndex < 0 OrElse e.RowIndex = dgvArchivedCases.NewRowIndex Then Return

        ' --- Force consistent button color ---
        If dgvArchivedCases.Columns(e.ColumnIndex).Name = "colView" Then
            e.CellStyle.BackColor = Color.FromArgb(60, 141, 188)
            e.CellStyle.ForeColor = Color.White
            e.CellStyle.SelectionBackColor = Color.FromArgb(60, 141, 188)
            e.CellStyle.SelectionForeColor = Color.White
        End If

        ' --- Priority Column Formatting ---
        If dgvArchivedCases.Columns(e.ColumnIndex).Name = "Priority" Then
            ' (This is the same logic as your ManageForm)
        End If

        ' --- Status Column Formatting ---
        If dgvArchivedCases.Columns(e.ColumnIndex).Name = "Status" Then
            If e.Value IsNot Nothing Then
                Dim statusValue As String = e.Value.ToString()
                e.CellStyle.Font = New Font(dgvArchivedCases.Font, FontStyle.Regular)
                e.CellStyle.ForeColor = Color.Gray
            End If
        End If
    End Sub

    Private Sub Guna2GroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub btnDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteRecord.Click
        ' Security Check: Only Admins can use this feature.
        If SESSION Is Nothing OrElse SESSION("Role").ToString() <> "Admin" Then
            MsgBox("You do not have permission to perform this action.", MsgBoxStyle.Critical, "Access Denied")
            Return
        End If

        If dgvArchivedCases.SelectedRows.Count = 0 Then
            MsgBox("Please select a case from the grid to delete.", MsgBoxStyle.Information, "No Case Selected")
            Return
        End If

        Dim selectedID As Integer = CInt(dgvArchivedCases.SelectedRows(0).Cells("IncidentID").Value)
        Dim caseNumber As String = dgvArchivedCases.SelectedRows(0).Cells("CaseNumber").Value.ToString()

        ' --- CRITICAL: Use a very strong confirmation message ---
        Dim warningMsg As String = "WARNING: This action is permanent and cannot be undone." & vbCrLf & vbCrLf &
                                   "This will delete Case #" & caseNumber & " AND all of its associated attachments forever." & vbCrLf & vbCrLf &
                                   "Are you absolutely sure you want to proceed?"

        If MsgBox(warningMsg, MsgBoxStyle.YesNo Or MsgBoxStyle.Critical Or MsgBoxStyle.DefaultButton2, "Confirm Permanent Deletion") = MsgBoxResult.Yes Then
            ' If the user confirms, call the new utility function.
            If PermanentlyDeleteIncident(selectedID) Then
                MsgBox("Record permanently deleted.", MsgBoxStyle.Information, "Success")
                LoadArchivedData() ' Refresh the grid
            Else
                MsgBox("Failed to delete the record.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub
End Class