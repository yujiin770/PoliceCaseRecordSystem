Public Class BackupandRestoreFrm

    Private Sub BackupandRestoreFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Security Check: Only Admins can access this feature.
        If SESSION Is Nothing OrElse SESSION("Role").ToString() <> "Admin" Then
            MsgBox("You do not have permission to view this page.", MsgBoxStyle.Critical, "Access Denied")
            ' Hide the controls and show a message instead of closing the panel
            Guna2GroupBox1.Visible = False
            Guna2GroupBox2.Visible = False
            lblAccessDenied.Visible = True
            ' You could add a label here saying "Access Denied"
            Return
        End If
    End Sub

    Private Sub btnBrowseBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseBackup.Click
        ' Use a SaveFileDialog to let the user choose a location and filename for the backup.
        Dim saveDlg As New SaveFileDialog()
        saveDlg.Filter = "SQL Backup File (*.bak)|*.bak"
        saveDlg.Title = "Save Database Backup"
        ' Suggest a default filename with the database name and current date.
        saveDlg.FileName = "DBPoliceRecord_Backup_" & DateTime.Now.ToString("yyyy-MM-dd") & ".bak"

        If saveDlg.ShowDialog() = DialogResult.OK Then
            ' If the user selects a path, put it in the textbox.
            txtBackupPath.Text = saveDlg.FileName
        End If
    End Sub

    Private Sub btnStartBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartBackup.Click
        ' Validate that a path has been chosen.
        If String.IsNullOrWhiteSpace(txtBackupPath.Text) Then
            MsgBox("Please select a destination path for the backup file first.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        Me.Cursor = Cursors.WaitCursor ' Show a waiting cursor during the operation.

        ' Call the utility function to perform the backup.
        If BackupDatabase(txtBackupPath.Text) Then
            MsgBox("Database backup created successfully!", MsgBoxStyle.Information, "Backup Complete")
            ' Clear the path for the next operation.
            txtBackupPath.Clear()
        End If

        Me.Cursor = Cursors.Default ' Return the cursor to normal.
    End Sub

    Private Sub btnBrowseRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseRestore.Click
        ' Use an OpenFileDialog to let the user select an existing backup file.
        Dim openDlg As New OpenFileDialog()
        openDlg.Filter = "SQL Backup File (*.bak)|*.bak"
        openDlg.Title = "Select Database Backup to Restore"

        If openDlg.ShowDialog() = DialogResult.OK Then
            ' Put the selected file path into the textbox.
            txtRestorePath.Text = openDlg.FileName
        End If
    End Sub

    Private Sub btnStartRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartRestore.Click
        ' Validate that a file has been chosen.
        If String.IsNullOrWhiteSpace(txtRestorePath.Text) Then
            MsgBox("Please select a backup file to restore from.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        ' --- CRITICAL WARNING ---
        ' Display a very strong confirmation message because this action is destructive.
        Dim warningMsg As String = "WARNING: THIS ACTION IS IRREVERSIBLE." & vbCrLf & vbCrLf &
                               "Restoring the database will completely overwrite all current data with the data from the selected backup file. Any changes made since the backup was created will be permanently lost." & vbCrLf & vbCrLf &
                               "Are you absolutely sure you want to proceed?"

        If MsgBox(warningMsg, MsgBoxStyle.YesNo Or MsgBoxStyle.Critical Or MsgBoxStyle.DefaultButton2, "Confirm Database Restore") = MsgBoxResult.Yes Then
            ' If the user confirms, proceed.

            Me.Cursor = Cursors.WaitCursor

            ' Call the utility function to perform the restore.
            If RestoreDatabase(txtRestorePath.Text) Then
                MsgBox("Database restored successfully!" & vbCrLf & vbCrLf & "The application will now close. Please restart it to use the restored database.", MsgBoxStyle.Information, "Restore Complete")
                ' After a successful restore, it's best practice to close the application.
                Application.Exit()
            End If

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAccessDenied.Click

    End Sub
End Class