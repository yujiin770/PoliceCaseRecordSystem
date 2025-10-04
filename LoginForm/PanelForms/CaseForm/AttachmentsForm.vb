Imports System.IO ' Required for file operations

Public Class AttachmentsForm
    ' These public properties will be set by the form that opens this one.
    Public SelectedIncidentID As Integer
    Public SelectedCaseNumber As String
    Public FormMode As String = "Edit"

    Private Sub AttachmentsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvAttachments.DataSource = GetAttachmentsForCase(SelectedIncidentID)
        StyleAttachmentsGrid()
        Evidence.Text = "Attachments for Case #" & SelectedCaseNumber

        ' This logic now correctly handles the mode set by the ViewCase form.
        If FormMode = "ViewOnly" Then
            ' If in ViewOnly mode, hide editing controls regardless of user role.
            btnAddFile.Visible = False
            btnRemoveFile.Visible = False
            btnSaveFile.Text = "Download File"
            ' Adjust the location to center the single button. You may need to change this coordinate.
            btnSaveFile.Location = New Point(815, 698) ' Example coordinate
        Else
            ' This is the default "Edit" mode for Admins.
            btnAddFile.Visible = True
            btnRemoveFile.Visible = True
            btnSaveFile.Text = "Download File"
            ' Adjust the location for the 3-button layout. You may need to change this.
            btnSaveFile.Location = New Point(648, 698) ' Your original coordinate
        End If
    End Sub

    Private Sub StyleAttachmentsGrid()
        ' --- Main Grid Appearance ---
        dgvAttachments.BorderStyle = BorderStyle.None
        dgvAttachments.BackgroundColor = Color.WhiteSmoke
        dgvAttachments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvAttachments.RowHeadersVisible = False
        dgvAttachments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAttachments.ReadOnly = True
        dgvAttachments.AllowUserToAddRows = False
        dgvAttachments.AllowUserToResizeRows = False

        ' --- Column Header Styling ---
        dgvAttachments.ColumnHeadersVisible = True
        dgvAttachments.EnableHeadersVisualStyles = False
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.BackColor = Color.FromArgb(70, 70, 73) ' A neutral dark gray
        headerStyle.ForeColor = Color.White
        headerStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvAttachments.ColumnHeadersDefaultCellStyle = headerStyle
        dgvAttachments.ColumnHeadersHeight = 35
        dgvAttachments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        ' --- Row Styling ---
        Dim defaultRowStyle As New DataGridViewCellStyle()
        defaultRowStyle.BackColor = Color.White
        defaultRowStyle.ForeColor = Color.FromArgb(40, 40, 40)
        defaultRowStyle.SelectionBackColor = Color.FromArgb(225, 225, 225) ' Light gray selection
        defaultRowStyle.SelectionForeColor = Color.Black
        defaultRowStyle.Font = New Font("Segoe UI", 9)
        defaultRowStyle.Padding = New Padding(5, 0, 5, 0)
        dgvAttachments.DefaultCellStyle = defaultRowStyle
        dgvAttachments.RowTemplate.Height = 30

        ' --- Alternating Row Styling ---
        dgvAttachments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

        ' --- Safety Check and Column Styling ---
        ' Only try to style columns if the grid has been populated with data.
        If dgvAttachments.Rows.Count > 0 Then
            ' Hide the ID column
            dgvAttachments.Columns("AttachmentID").Visible = False

            ' Set proportional widths for the visible columns
            dgvAttachments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvAttachments.Columns("FileName").HeaderText = "File Name"
            dgvAttachments.Columns("FileName").FillWeight = 60 ' Give more space to the filename
            dgvAttachments.Columns("FileType").HeaderText = "File Type"
            dgvAttachments.Columns("FileType").FillWeight = 20
            dgvAttachments.Columns("DateAdded").HeaderText = "Date Added"
            dgvAttachments.Columns("DateAdded").FillWeight = 20
        End If
    End Sub

    Private Sub LoadAttachmentsGrid()
        ' Get the data from the database. This might be an empty table.
        dgvAttachments.DataSource = GetAttachmentsForCase(SelectedIncidentID)

        ' --- THIS IS THE FIX ---
        ' Only try to style the columns if the grid actually has data in it.
        If dgvAttachments.Rows.Count > 0 Then
            ' If we have at least one row, we know the columns have been created.
            dgvAttachments.Columns("AttachmentID").Visible = False ' Hide the ID
            dgvAttachments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' You can also add other styling here that depends on columns existing
            dgvAttachments.Columns("FileName").HeaderText = "File Name"
            dgvAttachments.Columns("DateAdded").HeaderText = "Date Added"
        Else
            ' Optional: If the grid is empty, you could set a message.
            ' For example, if you have a Label control named lblStatus:
            ' lblStatus.Text = "No attachments found for this case."
        End If
    End Sub

    Private Sub btnAddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFile.Click
        ' Use an OpenFileDialog to let the user choose a file.
        Dim openDlg As New OpenFileDialog()
        openDlg.Title = "Select a File to Attach"
        openDlg.Filter = "All Files (*.*)|*.*" ' Allow any file type

        ' If the user selects a file and clicks OK...
        If openDlg.ShowDialog() = DialogResult.OK Then
            Try
                ' Get the file's information.
                Dim fileName As String = Path.GetFileName(openDlg.FileName)
                Dim fileData As Byte() = File.ReadAllBytes(openDlg.FileName)
                ' We'll store a generic file type for now.
                Dim fileType As String = "application/octet-stream"

                ' Call the utility function to add it to the database.
                If AddAttachment(SelectedIncidentID, fileName, fileData, fileType) Then
                    MsgBox("File attached successfully.", MsgBoxStyle.Information, "Success")
                    ' Refresh the grid to show the new file.
                    LoadAttachmentsGrid()

                Else
                    MsgBox("Failed to attach the file.", MsgBoxStyle.Critical, "Database Error")
                End If
            Catch ex As Exception
                MsgBox("An error occurred while reading the file: " & ex.Message, MsgBoxStyle.Critical, "File Error")
            End Try
        End If
    End Sub

    Private Sub btnSaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveFile.Click
        ' Check if a file is selected in the grid.
        If dgvAttachments.SelectedRows.Count = 0 Then
            MsgBox("Please select a file from the list to save.", MsgBoxStyle.Information, "No File Selected")
            Return
        End If

        ' Get the ID of the selected attachment.
        Dim selectedAttachmentID As Integer = CInt(dgvAttachments.SelectedRows(0).Cells("AttachmentID").Value)

        ' Get the full file data from the database.
        Dim fileRow As DataRow = GetSingleAttachment(selectedAttachmentID)
        If fileRow Is Nothing Then
            MsgBox("Could not retrieve the file data.", MsgBoxStyle.Critical, "Error")
            Return
        End If

        ' Use a SaveFileDialog to let the user choose where to save the file.
        Dim saveDlg As New SaveFileDialog()
        saveDlg.Title = "Save Attachment As..."
        saveDlg.FileName = fileRow("FileName").ToString() ' Suggest the original filename
        saveDlg.Filter = "All Files (*.*)|*.*"

        If saveDlg.ShowDialog() = DialogResult.OK Then
            Try
                ' Get the binary data and write it to the chosen file path.
                Dim fileData As Byte() = CType(fileRow("FileData"), Byte())
                File.WriteAllBytes(saveDlg.FileName, fileData)
                MsgBox("File saved successfully.", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox("An error occurred while saving the file: " & ex.Message, MsgBoxStyle.Critical, "File Error")
            End Try
        End If
    End Sub

    Private Sub btnRemoveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFile.Click
        ' Check if a file is selected in the grid.
        If dgvAttachments.SelectedRows.Count = 0 Then
            MsgBox("Please select a file from the list to remove.", MsgBoxStyle.Information, "No File Selected")
            Return
        End If

        Dim selectedAttachmentID As Integer = CInt(dgvAttachments.SelectedRows(0).Cells("AttachmentID").Value)
        Dim fileName As String = dgvAttachments.SelectedRows(0).Cells("FileName").Value.ToString()

        ' Confirm the deletion.
        Dim result = MsgBox("Are you sure you want to remove the attachment '" & fileName & "'?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Removal")

        If result = MsgBoxResult.Yes Then
            If RemoveAttachment(selectedAttachmentID) Then
                MsgBox("Attachment removed successfully.", MsgBoxStyle.Information, "Success")
                LoadAttachmentsGrid() ' Refresh the grid
            Else
                MsgBox("Failed to remove the attachment.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        Me.Hide()

    End Sub


    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class