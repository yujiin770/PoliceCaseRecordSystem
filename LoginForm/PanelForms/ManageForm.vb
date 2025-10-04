Public Class ManageForm


    Private Sub InitializeFilterComboBoxes()
        ' --- Populate the Status Filter ---
        cboStatus.Items.Clear()
        cboStatus.Items.Add("All Statuses") ' The "All" option
        cboStatus.Items.Add("New")
        cboStatus.Items.Add("Open")
        cboStatus.Items.Add("Under Investigation")
        cboStatus.Items.Add("Pending")
        cboStatus.Items.Add("Closed - Unfounded")
        cboStatus.Items.Add("Closed - Arrest Made")
        cboStatus.Items.Add("Closed - Resolved")
        cboStatus.SelectedIndex = 0 ' Set "All Statuses" as the default

        ' --- Populate the Priority Filter ---
        cboPriority.Items.Clear()
        cboPriority.Items.Add("All Priorities") ' The "All" option
        cboPriority.Items.Add("Low")
        cboPriority.Items.Add("Medium")
        cboPriority.Items.Add("High")
        cboPriority.Items.Add("Urgent")
        cboPriority.SelectedIndex = 0 ' Set "All Priorities" as the default
    End Sub
    ' REPLACE your entire old StyleDataGridView sub with this complete and corrected version.
    Private Sub StyleDataGridView()
        ' --- Apply the new base design ---
        dgvinfo.BorderStyle = BorderStyle.Fixed3D ' From your example
        dgvinfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249) ' From your example
        dgvinfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal ' From your example
        dgvinfo.RowHeadersVisible = False ' Your setting
        dgvinfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Your setting
        dgvinfo.ReadOnly = True ' Your setting
        dgvinfo.AllowUserToAddRows = False ' Your setting
        dgvinfo.AllowUserToResizeRows = False ' Your setting
        dgvinfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing ' From your example

        ' --- Column Header Styling ---
        dgvinfo.EnableHeadersVisualStyles = False ' From your example
        dgvinfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None ' From your example
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.BackColor = Color.FromArgb(148, 41, 34) ' Your example's header color
        headerStyle.ForeColor = Color.White
        headerStyle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold) ' Keeping your slightly larger font
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvinfo.ColumnHeadersDefaultCellStyle = headerStyle
        dgvinfo.ColumnHeadersHeight = 40 ' Keeping your height

        ' --- Row Styling ---
        Dim defaultRowStyle As New DataGridViewCellStyle()
        defaultRowStyle.BackColor = Color.White ' Keeping your color
        defaultRowStyle.ForeColor = Color.FromArgb(40, 40, 40) ' Keeping your color
        ' Using the new selection color from your example
        defaultRowStyle.SelectionBackColor = Color.FromArgb(255, 224, 220)
        defaultRowStyle.SelectionForeColor = Color.FromArgb(148, 41, 34)
        defaultRowStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular) ' Using your example's font
        defaultRowStyle.Padding = New Padding(5, 0, 5, 0)
        dgvinfo.DefaultCellStyle = defaultRowStyle
        dgvinfo.RowTemplate.Height = 35 ' Keeping your height

        ' --- Clear any old button columns before adding new ones ---
        For i As Integer = dgvinfo.Columns.Count - 1 To 0 Step -1
            If dgvinfo.Columns(i).Name = "colView" OrElse dgvinfo.Columns(i).Name = "colRemove" Then
                dgvinfo.Columns.RemoveAt(i)
            End If
        Next

        ' --- Hide the IncidentID column ---
        If dgvinfo.Columns.Contains("IncidentID") Then
            dgvinfo.Columns("IncidentID").Visible = False
        End If


        ' --- Alternating Row Styling ---
        dgvinfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

        ' --- Hide the IncidentID column ---
        If dgvinfo.Columns.Contains("IncidentID") Then
            dgvinfo.Columns("IncidentID").Visible = False
        End If

       ' VIEW BUTTON
        Dim viewButtonCol As New DataGridViewButtonColumn()
        viewButtonCol.Name = "colView"
        viewButtonCol.HeaderText = "Action"
        viewButtonCol.Text = "View"
        viewButtonCol.UseColumnTextForButtonValue = True
        viewButtonCol.FlatStyle = FlatStyle.Flat
        ' Keeping your distinct blue color for this button for better UX
        viewButtonCol.DefaultCellStyle.BackColor = Color.FromArgb(60, 141, 188)
        viewButtonCol.DefaultCellStyle.ForeColor = Color.White
        viewButtonCol.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        viewButtonCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvinfo.Columns.Add(viewButtonCol)

        ' REMOVE BUTTON
        Dim removeButtonCol As New DataGridViewButtonColumn()
        removeButtonCol.Name = "colRemove"
        removeButtonCol.HeaderText = ""
        removeButtonCol.Text = "Archive"
        removeButtonCol.UseColumnTextForButtonValue = True
        removeButtonCol.FlatStyle = FlatStyle.Flat
        ' Keeping your distinct red color for this button for better UX
        removeButtonCol.DefaultCellStyle.BackColor = Color.FromArgb(217, 83, 79)
        removeButtonCol.DefaultCellStyle.ForeColor = Color.White
        removeButtonCol.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        removeButtonCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvinfo.Columns.Add(removeButtonCol)

        ' --- Set Button Display Order ---
        ' This ensures the buttons are always the last columns on the right.
        If dgvinfo.Columns.Count > 2 Then
            dgvinfo.Columns("colView").DisplayIndex = dgvinfo.Columns.Count - 2
            dgvinfo.Columns("colRemove").DisplayIndex = dgvinfo.Columns.Count - 1
        End If

        ' --- Final security check for the "Remove" button ---
        If SESSION IsNot Nothing AndAlso SESSION("Role").ToString() <> "Admin" Then
            dgvinfo.Columns("colRemove").Visible = False
        End If

    End Sub
    Sub LoadData()
      connection.Parameters.Clear()
        Dim baseQuery As String = "SELECT IncidentID, CaseNumber, IncidentDate, CaseType, Location, Status, Priority FROM IncidentRecords"
        Dim conditions As New List(Of String)

        ' --- NEW: This is the PERMANENT filter for this form ---
        conditions.Add("Status NOT LIKE 'Closed%'") ' Only show cases that are NOT closed.

        ' --- Condition 1: Check the Search Textbox ---
        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            Dim searchTerm As String = "%" & txtSearch.Text & "%"
            conditions.Add("(CaseNumber LIKE @search OR Location LIKE @search OR CaseType LIKE @search)")
            connection.AddParam("@search", searchTerm)
        End If

        ' --- Condition 2: Check the Status Filter ---
        If cboStatus.SelectedIndex > 0 Then
            conditions.Add("Status = @status")
            connection.AddParam("@status", cboStatus.Text)
        End If

        ' --- Condition 3: Check the Priority Filter ---
        If cboPriority.SelectedIndex > 0 Then
            conditions.Add("Priority = @priority")
            connection.AddParam("@priority", cboPriority.Text)
        End If

        ' --- Build the final query ---
        Dim finalQuery As String = baseQuery
        finalQuery &= " WHERE " & String.Join(" AND ", conditions)
        finalQuery &= " ORDER BY IncidentID ASC"

        ' --- Execute the query ---
        connection.Query(finalQuery)

        ' --- START: NEW VALIDATION LOGIC ---
        ' Check if the query returned any rows.
        If connection.Datacount = 0 Then
            ' If there are no results, check if the user was actively searching/filtering.
            ' We don't want this message to appear when the form first loads with an empty table.
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Or cboStatus.SelectedIndex > 0 Or cboPriority.SelectedIndex > 0 Then

                ' 1. Show the "No Record Found" message.
                MsgBox("No records found matching your criteria.", MsgBoxStyle.Information, "Search Result")

                ' 2. Reset the filter controls back to their "All" state.
                txtSearch.Clear()
                cboStatus.SelectedIndex = 0
                cboPriority.SelectedIndex = 0

                ' 3. The function will then run AGAIN from the event handlers to show all records.
                ' No need to call LoadData() here, as the control's changed event will trigger it.
            Else
                ' This is the case where the table is just empty, so we clear the grid.
                dgvinfo.DataSource = Nothing
            End If
        Else
            ' If we found records, bind them to the grid.
            dgvinfo.DataSource = connection.Data.Tables(0)
        End If
        ' --- END: NEW VALIDATION LOGIC ---

        ' Apply all styling after the data source has been set.
        StyleDataGridView()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        LoadData()
    End Sub

    Private Sub dgvinfo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub


    Private Sub ManageForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' --- CORRECT ORDER ---
        ' 1. Initialize controls first.
        InitializeFilterComboBoxes()
        ' 2. Then load the data that might use those controls.
        LoadData()

        ' 3. Apply form-level security last.
     If SESSION IsNot Nothing AndAlso SESSION("Role").ToString() <> "Admin" Then
            ' This code will now run EVERY time an Officer opens the form.
            BtnUpdateRecords.Visible = False
        End If
    End Sub

    Private Sub dgvinfo_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvinfo.CellContentClick
        ' First, make sure the click is on an actual row, not the header.
        If e.RowIndex < 0 Then Return

        ' --- HANDLE VIEW BUTTON CLICK ---
        If dgvinfo.Columns(e.ColumnIndex).Name = "colView" Then
            Dim selectedID As Integer = CInt(dgvinfo.Rows(e.RowIndex).Cells("IncidentID").Value)
            Dim viewForm As New ViewCase()
            viewForm.SelectedIncidentID = selectedID
            viewForm.ShowDialog()
        End If

        ' --- HANDLE "ARCHIVE" (formerly Remove) BUTTON CLICK ---
        If dgvinfo.Columns(e.ColumnIndex).Name = "colRemove" Then
            Dim selectedID As Integer = CInt(dgvinfo.Rows(e.RowIndex).Cells("IncidentID").Value)
            Dim caseNumber As String = dgvinfo.Rows(e.RowIndex).Cells("CaseNumber").Value.ToString()

            ' Ask the user to confirm the ARCHIVE action.
            Dim result = MsgBox("Are you sure you want to archive Case #" & caseNumber & "? " &
                                  "It will be moved to the Archive Records list.",
                                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                                  "Confirm Archive")

            If result = MsgBoxResult.Yes Then
                ' --- CALL THE NEW, SAFER FUNCTION ---
                If ArchiveIncident(selectedID) Then
                    MsgBox("Record archived successfully.", MsgBoxStyle.Information, "Success")
                    ' Refresh the grid to show that the record is now gone from the active list.
                    LoadData()
                    ' Refresh the dashboard stats since an active case was resolved.
                    Dashboard.LoadDashboardStats()
                    Dashboard.LoadCaseTypeChart()
                    Dashboard.LoadRecentCases()
                Else
                    MsgBox("Failed to archive the record.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub dgvinfo_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvinfo.CellFormatting
        ' We only want to format cells that have data, not the headers or new rows
        If e.RowIndex < 0 OrElse e.RowIndex = dgvinfo.NewRowIndex Then
            Return
        End If

        ' --- START: NEW FIX FOR BUTTONS ---
        ' This code will force the button colors to be consistent on every row.

        ' Handle the "View" button column
        If dgvinfo.Columns(e.ColumnIndex).Name = "colView" Then
            e.CellStyle.BackColor = Color.FromArgb(60, 141, 188) ' Blue
            e.CellStyle.ForeColor = Color.White
            ' This next line ensures the button stays blue even when the row is selected
            e.CellStyle.SelectionBackColor = Color.FromArgb(60, 141, 188) ' Blue
            e.CellStyle.SelectionForeColor = Color.White
        End If

        ' Handle the "Remove" button column
        If dgvinfo.Columns(e.ColumnIndex).Name = "colRemove" Then
            e.CellStyle.BackColor = Color.FromArgb(217, 83, 79) ' Red
            e.CellStyle.ForeColor = Color.White
            ' This next line ensures the button stays red even when the row is selected
            e.CellStyle.SelectionBackColor = Color.FromArgb(217, 83, 79) ' Red
            e.CellStyle.SelectionForeColor = Color.White
        End If

        ' --- END: NEW FIX FOR BUTTONS ---


        ' --- (Your existing Priority and Status formatting code remains the same) ---

        ' --- Priority Column Formatting ---
        If dgvinfo.Columns(e.ColumnIndex).Name = "Priority" Then
            If e.Value IsNot Nothing Then
                Dim priorityValue As String = e.Value.ToString().ToLower()
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.Font = New Font(dgvinfo.Font, FontStyle.Bold)
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Select Case priorityValue
                    Case "low"
                        e.CellStyle.BackColor = Color.FromArgb(34, 139, 34) ' Forest Green
                        e.CellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                    Case "medium"
                        e.CellStyle.BackColor = Color.FromArgb(255, 165, 0) ' Orange
                        e.CellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                    Case "high"
                        e.CellStyle.BackColor = Color.FromArgb(217, 83, 79) ' Dark Red
                        e.CellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                    Case "urgent"
                        e.CellStyle.BackColor = Color.FromArgb(148, 41, 34)
                        e.CellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                    Case Else
                        e.CellStyle.BackColor = dgvinfo.DefaultCellStyle.BackColor
                        e.CellStyle.ForeColor = dgvinfo.DefaultCellStyle.ForeColor
                End Select
            End If
        End If

        ' --- Status Column Formatting ---
        If dgvinfo.Columns(e.ColumnIndex).Name = "Status" Then
            If e.Value IsNot Nothing Then
                Dim statusValue As String = e.Value.ToString()
                e.CellStyle.Font = New Font(dgvinfo.Font, FontStyle.Regular)

                Select Case True
                    Case statusValue.StartsWith("Closed")
                        e.CellStyle.ForeColor = Color.Gray
                        e.CellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                    Case statusValue = "New"
                        e.CellStyle.ForeColor = Color.Blue
                        e.CellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                    Case statusValue = "Under Investigation"
                        e.CellStyle.ForeColor = Color.FromArgb(255, 140, 0) ' Dark Orange
                        e.CellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                    Case Else
                        e.CellStyle.ForeColor = Color.Black
                        e.CellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                End Select
            End If
        End If
    End Sub


    Private Sub BtnUpdateRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateRecords.Click
        ' First, check if a row is actually selected in the grid
        If dgvinfo.SelectedRows.Count = 0 Then
            MsgBox("Please select a record from the grid to update.", MsgBoxStyle.Information, "No Record Selected")
            Return ' Stop the code if nothing is selected
        End If

        ' Get the ID from the selected row (the first selected row, in case of multi-select)
        Dim selectedID As Integer = CInt(dgvinfo.SelectedRows(0).Cells("IncidentID").Value)

        ' Create an instance of our reusable form
        Dim updateForm As New AddRecordFrm()

        ' --- CONFIGURE THE FORM FOR UPDATE MODE ---
        updateForm.FormMode = "Update" ' Tell the form to be in "Update" mode
        updateForm.SelectedIncidentID = selectedID ' Pass the ID of the record to be edited

        ' Show the form. The code in ManageForm will pause here until the update form is closed.
        updateForm.ShowDialog()
        updateForm.GunaButton2.Visible = True


        ' After the update form is closed, refresh the grid to show the changes
        LoadData()
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub cboPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPriority.SelectedIndexChanged
        LoadData()
    End Sub

    Private Sub Guna2GroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GroupBox1.Click

    End Sub


    Private Sub btnViewAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class