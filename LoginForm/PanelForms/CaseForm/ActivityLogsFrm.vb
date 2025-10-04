Public Class ActivityLogsFrm

    Private Sub ActivityLogsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Only Admins should be able to see the activity log.
        If SESSION Is Nothing OrElse SESSION("Role").ToString() <> "Admin" Then
            MsgBox("You do not have permission to view this page.", MsgBoxStyle.Critical, "Access Denied")
            Me.Close()
            Return
        End If
        InitializeFilters()
        LoadActivityLogs()
    End Sub

    Private Sub InitializeFilters()
        ' Set dates to a default range (e.g., the last 30 days)
        dtpStartDate.Value = Date.Now.AddDays(-30)
        dtpEndDate.Value = Date.Now

        ' Populate the user filter dropdown
        cboUserFilter.Items.Clear()
        cboUserFilter.Items.Add("All Users")
        Dim usersTable As DataTable = GetAllUsernames() ' Assumes you have this function
        For Each row As DataRow In usersTable.Rows
            cboUserFilter.Items.Add(row("Username").ToString())
        Next
        cboUserFilter.SelectedIndex = 0
    End Sub

    Private Sub LoadActivityLogs()
        ' --- START OF THE FIX ---
        ' First, check if the ComboBox has a valid selection.
        ' If the form is still loading or the control is not ready, SelectedItem might be Nothing.
        If cboUserFilter.SelectedItem Is Nothing Then
            Return ' Exit the subroutine immediately to prevent the error.
        End If
        ' --- END OF THE FIX ---

        ' Get values from the filter controls
        Dim searchTerm As String = txtLogSearch.Text.Trim()
        Dim selectedUser As String = cboUserFilter.SelectedItem.ToString()
        Dim startDate As Date = dtpStartDate.Value
        Dim endDate As Date = dtpEndDate.Value

        ' Call the filtered function from the Utilities module
        dgvActivityLogs.DataSource = GetFilteredActivityLogs(searchTerm, selectedUser, startDate, endDate)
        StyleLogsGrid()
    End Sub



    Private Sub StyleLogsGrid()
        ' --- Apply the base design from ManageForm ---
        dgvActivityLogs.BorderStyle = BorderStyle.Fixed3D
        dgvActivityLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvActivityLogs.RowHeadersVisible = False
        dgvActivityLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvActivityLogs.ReadOnly = True
        dgvActivityLogs.AllowUserToAddRows = False
        dgvActivityLogs.AllowUserToResizeRows = False
        dgvActivityLogs.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        ' --- Column Header Styling (from ManageForm) ---
        dgvActivityLogs.EnableHeadersVisualStyles = False
        dgvActivityLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.BackColor = Color.FromArgb(148, 41, 34) ' The maroon header color
        headerStyle.ForeColor = Color.White
        headerStyle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvActivityLogs.ColumnHeadersDefaultCellStyle = headerStyle
        dgvActivityLogs.ColumnHeadersHeight = 40

        ' --- Row Styling (from ManageForm) ---
        Dim defaultRowStyle As New DataGridViewCellStyle()
        defaultRowStyle.BackColor = Color.White
        defaultRowStyle.ForeColor = Color.FromArgb(40, 40, 40)
        ' Use the light red selection highlight
        defaultRowStyle.SelectionBackColor = Color.FromArgb(255, 224, 220)
        defaultRowStyle.SelectionForeColor = Color.FromArgb(148, 41, 34)
        defaultRowStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        defaultRowStyle.Padding = New Padding(5, 0, 5, 0)
        dgvActivityLogs.DefaultCellStyle = defaultRowStyle
        dgvActivityLogs.RowTemplate.Height = 35

        ' --- Alternating Row Styling (from ManageForm) ---
        dgvActivityLogs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

        ' --- Set Column Sizes and Headers for THIS specific grid ---
        ' This part is unique to the Activity Logs form.
        If dgvActivityLogs.Columns.Count > 0 Then
            dgvActivityLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvActivityLogs.Columns("LogTimestamp").HeaderText = "Date & Time"
            dgvActivityLogs.Columns("LogTimestamp").FillWeight = 25

            dgvActivityLogs.Columns("Username").HeaderText = "User"
            dgvActivityLogs.Columns("Username").FillWeight = 15

            dgvActivityLogs.Columns("ActionType").HeaderText = "Action"
            dgvActivityLogs.Columns("ActionType").FillWeight = 20

            dgvActivityLogs.Columns("Details").HeaderText = "Details"
            dgvActivityLogs.Columns("Details").FillWeight = 40
        End If
    End Sub

    ' --- ADD EVENT HANDLERS for your new filter controls ---
    Private Sub FilterControls_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles txtLogSearch.TextChanged, cboUserFilter.SelectedIndexChanged, dtpStartDate.ValueChanged, dtpEndDate.ValueChanged
        LoadActivityLogs()
    End Sub

    Private Sub GunaLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel6.Click
        Me.Hide()
    End Sub

    Private Sub dgvActivityLogs_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvActivityLogs.CellContentClick

    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub cboUserFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUserFilter.SelectedIndexChanged

    End Sub

    
    Private Sub btnClearFilters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilters.Click
        txtLogSearch.Clear()
        InitializeFilters() ' This will reset the dates and combobox
        LoadActivityLogs()
    End Sub


    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If dgvActivityLogs.Rows.Count = 0 Then
            MsgBox("There is no data to export.", MsgBoxStyle.Information)
            Return
        End If

        ' Let the user choose where to save the file
        Dim saveDlg As New SaveFileDialog()
        saveDlg.Filter = "CSV File (*.csv)|*.csv"
        saveDlg.Title = "Save Activity Log"
        saveDlg.FileName = "ActivityLog_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"

        If saveDlg.ShowDialog() = DialogResult.OK Then
            Try
                ' Use a StringBuilder for better performance
                Dim sb As New System.Text.StringBuilder()

                ' Add the header row
                Dim headers = dgvActivityLogs.Columns.Cast(Of DataGridViewColumn)()
                sb.AppendLine(String.Join(",", headers.Select(Function(column) """" & column.HeaderText & """").ToArray()))

                ' Add the data rows
                For Each row As DataGridViewRow In dgvActivityLogs.Rows
                    Dim cells = row.Cells.Cast(Of DataGridViewCell)()
                    sb.AppendLine(String.Join(",", cells.Select(Function(cell) """" & cell.Value.ToString().Replace("""", """""") & """").ToArray()))
                Next

                ' Write the file
                My.Computer.FileSystem.WriteAllText(saveDlg.FileName, sb.ToString(), False)
                MsgBox("Log exported successfully!", MsgBoxStyle.Information, "Export Complete")

            Catch ex As Exception
                MsgBox("An error occurred while exporting the data: " & ex.Message, MsgBoxStyle.Critical, "Export Error")
            End Try
        End If
    End Sub
End Class