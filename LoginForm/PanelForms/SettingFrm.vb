Public Class SettingFrm

    Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click
        Dim username As String = txtNewUsername.Text.Trim()
        Dim password As String = txtNewPassword.Text
        Dim passwordConfirm As String = txtNewPasswordConfirm.Text

        ' --- Validation ---
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MsgBox("Username and password cannot be empty.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        ' --- NEW: Password Confirmation Check ---
        If password <> passwordConfirm Then
            MsgBox("The passwords do not match. Please re-enter them.", MsgBoxStyle.Exclamation, "Password Mismatch")
            ' Clear the password fields and set focus to the first one.
            txtNewPassword.Clear()
            txtNewPasswordConfirm.Clear()
            txtNewPassword.Focus()

            Return
        End If

        ' Check if the username is already taken.
        If UsernameExists(username) Then
            MsgBox("This username is already taken. Please choose another one.", MsgBoxStyle.Exclamation, "Username Exists")
            Return
        End If

        ' --- Create the User ---
        If CreateNewOfficer(username, password) Then
            MsgBox("New Officer account created successfully for user: " & username, MsgBoxStyle.Information, "Success")
            ' Clear all the fields for the next entry.
            txtNewUsername.Clear()
            LoadUsersGrid()
            txtNewPassword.Clear()
            txtNewPasswordConfirm.Clear()
            Guna2GroupBox2.Visible = False
        Else
            MsgBox("Failed to create the new account.", MsgBoxStyle.Critical, "Database Error")
        End If
    End Sub

    Private Sub btnUpdatePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdatePassword.Click
        ' --- Validation Step 1: Check if a user is selected ---
        If cboUpdateUsername.SelectedIndex = -1 OrElse cboUpdateUsername.SelectedValue Is Nothing Then
            MsgBox("Please select a user from the dropdown list to update.", MsgBoxStyle.Exclamation, "Validation Error")
            Return
        End If

        ' --- Get the data ---
        Dim userID As Integer = CInt(cboUpdateUsername.SelectedValue)
        Dim originalUsername As String = cboUpdateUsername.Text ' Get the original username for comparison
        Dim newUsername As String = txtUpdateUsername.Text.Trim()
        Dim newPassword As String = txtUpdatePassword.Text
        Dim confirmPassword As String = txtUpdatePasswordConfirm.Text

        ' --- Validation Step 2: Username cannot be empty ---
        If String.IsNullOrWhiteSpace(newUsername) Then
            MsgBox("Username cannot be empty.", MsgBoxStyle.Exclamation, "Validation Error")
            txtUpdateUsername.Focus()
            Return
        End If

        ' --- START: DETAILED PASSWORD VALIDATION ---
        If Not String.IsNullOrWhiteSpace(newPassword) OrElse Not String.IsNullOrWhiteSpace(confirmPassword) Then
            If String.IsNullOrWhiteSpace(newPassword) Then
                MsgBox("Please enter the new password.", MsgBoxStyle.Exclamation, "Validation Error")
                txtUpdatePassword.Focus()
                Return
            End If
            If String.IsNullOrWhiteSpace(confirmPassword) Then
                MsgBox("Please re-enter the new password to confirm.", MsgBoxStyle.Exclamation, "Validation Error")
                txtUpdatePasswordConfirm.Focus()
                Return
            End If
            If newPassword <> confirmPassword Then
                MsgBox("The new passwords do not match. Please try again.", MsgBoxStyle.Exclamation, "Password Mismatch")
                txtUpdatePassword.Clear()
                txtUpdatePasswordConfirm.Clear()
                txtUpdatePassword.Focus()
                Return
            End If
        End If
        ' --- END: PASSWORD VALIDATION ---

        ' --- START: NEW CRUCIAL VALIDATION ---
        ' Check if any data has actually been changed before proceeding.
        If newUsername.ToLower() = originalUsername.ToLower() AndAlso String.IsNullOrWhiteSpace(newPassword) Then
            MsgBox("No changes were made.", MsgBoxStyle.Information, "Update Information")
            Return ' Exit because there's nothing to update.
        End If
        ' --- END: NEW CRUCIAL VALIDATION ---


        ' --- Validation Step 4: Check if the new username is already taken by ANOTHER user ---
        ' This check only runs if the username was actually changed.
        If newUsername.ToLower() <> originalUsername.ToLower() AndAlso UsernameExists(newUsername) Then
            MsgBox("This username is already taken by another user. Please choose a different one.", MsgBoxStyle.Exclamation, "Username Exists")
            Return
        End If

        ' --- Execute the Update ---
        ' Note: We pass the potentially empty newPassword string. The UpdateUser function is designed to handle this.
        If UpdateUser(userID, newUsername, newPassword) Then
            MsgBox("User details updated successfully!", MsgBoxStyle.Information, "Success")

            ' Clear fields and hide the panel
            Guna2GroupBox1.Visible = False
            txtUpdatePassword.Clear()
            txtUpdatePasswordConfirm.Clear()

            ' Refresh ALL data to show the changes everywhere
            LoadUsersGrid()
            PopulateUserComboBox()
        Else
            MsgBox("Failed to update user details.", MsgBoxStyle.Critical, "Database Error")
        End If
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        Guna2GroupBox2.Visible = True
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        ' 1. Make the panel visible
        Guna2GroupBox1.Visible = True

        ' 2. Force the entire group box and the specific textbox to be enabled.
        '    This is the robust fix that overrides any other settings.
        Guna2GroupBox1.Enabled = True
        txtUpdateUsername.Enabled = True
        txtUpdateUsername.ReadOnly = False

        ' 3. Populate the user list
        PopulateUserComboBox()

        ' 4. Set focus to the dropdown so the user can select an account.
        cboUpdateUsername.Focus()
    End Sub

    Private Sub SettingFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateUserComboBox()
        LoadUsersGrid()
    End Sub
    Private Sub LoadUsersGrid()
        dgvUsers.DataSource = GetAllUsers()
        StyleUsersGrid() ' Apply styling after loading data.
    End Sub


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Guna2GroupBox2.Visible = False
    End Sub

    Private Sub GunaLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel6.Click
        Guna2GroupBox1.Visible = False

    End Sub
 
        ' --- REVISED AND COMPLETE STYLING SUBROUTINE ---
    Private Sub StyleUsersGrid()
        ' Base design
        dgvUsers.BorderStyle = BorderStyle.Fixed3D
        dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvUsers.RowHeadersVisible = False
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.ReadOnly = True
        dgvUsers.AllowUserToAddRows = False

        ' Column Header Styling
        dgvUsers.EnableHeadersVisualStyles = False
        dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.BackColor = Color.FromArgb(148, 41, 34)
        headerStyle.ForeColor = Color.White
        headerStyle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        dgvUsers.ColumnHeadersDefaultCellStyle = headerStyle
        dgvUsers.ColumnHeadersHeight = 40

        ' --- THIS IS THE FIX for Invisible Text ---
        ' Define the complete style for all rows, including colors.
        Dim defaultRowStyle As New DataGridViewCellStyle()
        defaultRowStyle.BackColor = Color.White ' Default background is white
        defaultRowStyle.ForeColor = Color.FromArgb(40, 40, 40) ' Default text is dark gray
        defaultRowStyle.SelectionBackColor = Color.FromArgb(255, 224, 220) ' Selection is light red
        defaultRowStyle.SelectionForeColor = Color.Black ' Selected text is black for readability
        defaultRowStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        defaultRowStyle.Padding = New Padding(5, 0, 5, 0)
        dgvUsers.DefaultCellStyle = defaultRowStyle
        dgvUsers.RowTemplate.Height = 35
        ' --- END OF FIX ---

        ' Alternating Row Styling
        dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)

        ' Hide the id column AFTER data is loaded.
        If dgvUsers.Columns.Contains("id") Then
            dgvUsers.Columns("id").Visible = False
        End If

        ' Set Column Sizes
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvUsers.Columns.Count > 1 Then
            dgvUsers.Columns("Username").FillWeight = 50
            dgvUsers.Columns("Role").FillWeight = 50
        End If

        ' Clear and add the Remove button column
        If dgvUsers.Columns.Contains("colRemove") Then
            dgvUsers.Columns.Remove("colRemove")
        End If

        Dim removeButtonCol As New DataGridViewButtonColumn()
        removeButtonCol.Name = "colRemove"
        removeButtonCol.HeaderText = "Action"
        removeButtonCol.Text = "Remove"
        removeButtonCol.UseColumnTextForButtonValue = True
        removeButtonCol.FlatStyle = FlatStyle.Flat
        ' Set the default style; CellFormatting will enforce it.
        removeButtonCol.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        removeButtonCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        removeButtonCol.Width = 100
        dgvUsers.Columns.Add(removeButtonCol)
    End Sub
    ' --- NEW SUBROUTINE to load usernames into the ComboBox ---
    Private Sub PopulateUserComboBox()
        ' Get the list of usernames from the database.
        Dim usersTable As DataTable = GetAllUsers()

        ' Check if any users were returned.
        If usersTable.Rows.Count > 0 Then
            ' --- THIS IS THE FIX ---
            ' Make absolutely sure the group box is enabled if we have users.
            Guna2GroupBox1.Enabled = True

            ' Bind the DataTable to the ComboBox.
            cboUpdateUsername.DataSource = usersTable
            cboUpdateUsername.DisplayMember = "Username"
            cboUpdateUsername.ValueMember = "id"
            cboUpdateUsername.SelectedIndex = -1
            txtUpdateUsername.Clear()
        Else
            ' If no users are found, disable the password update section.
            Guna2GroupBox1.Enabled = False
            cboUpdateUsername.DataSource = Nothing ' Clear the data source
            cboUpdateUsername.Items.Clear()
            cboUpdateUsername.Items.Add("No Users Found")
            cboUpdateUsername.SelectedIndex = 0
        End If
    End Sub

    Private Sub Guna2GroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub BtnActivityLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActivityLogs.Click
        Dim Activitylogs As New ActivityLogsFrm()

        Activitylogs.ShowDialog()
    End Sub

    Private Sub dgvUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        ' First, make sure the click is on an actual row and on our button column.
        If e.RowIndex < 0 OrElse dgvUsers.Columns(e.ColumnIndex).Name <> "colRemove" Then
            Return
        End If

        ' Get the UserID from the clicked row.
        Dim selectedUserID As Integer = CInt(dgvUsers.Rows(e.RowIndex).Cells("id").Value)

        ' --- THIS IS THE CRUCIAL SECURITY CHECK ---
        ' If the ID of the user to be deleted is the same as the currently logged-in user,
        ' STOP IMMEDIATELY. Do not proceed.
        If selectedUserID = CInt(SESSION("id")) Then
            Return ' Exit the subroutine. Nothing else will happen.
        End If
        ' --- END OF SECURITY CHECK ---

        ' If the code reaches this point, it is safe to proceed because it's not the admin's own account.
        Dim selectedUsername As String = dgvUsers.Rows(e.RowIndex).Cells("Username").Value.ToString()

        ' Ask for confirmation.
        Dim result = MsgBox("Are you sure you want to permanently remove the user '" & selectedUsername & "'?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2,
                              "Confirm Deletion")

        If result = MsgBoxResult.Yes Then
            ' Call the utility function to remove the user.
            ' Note: The RemoveUser function ALSO has a safety check, providing double protection.
            If RemoveUser(selectedUserID, selectedUsername) Then
                MsgBox("User removed successfully.", MsgBoxStyle.Information, "Success")
                ' Refresh all data.
                LoadUsersGrid()
                PopulateUserComboBox()
            End If
        End If
    End Sub



    Private Sub dgvUsers_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvUsers.CellPainting
        ' We only want to custom-paint cells in the "Remove" button column, and not the header row.
        If e.RowIndex < 0 OrElse dgvUsers.Columns(e.ColumnIndex).Name <> "colRemove" Then
            Return
        End If

        ' Get the user ID from the current row being painted.
        Dim rowUserID As Integer = CInt(dgvUsers.Rows(e.RowIndex).Cells("id").Value)

        ' Check if the user ID for this row matches the ID of the currently logged-in user.
        If rowUserID = CInt(SESSION("id")) Then
            ' --- This is the admin's own row. We will paint over the button. ---

            ' 1. Paint the cell's background to match the row's background color.
            '    This effectively erases the button's default appearance.
            Using br As New SolidBrush(e.CellStyle.BackColor)
                e.Graphics.FillRectangle(br, e.CellBounds)
            End Using

            ' 2. Paint the grid lines so the cell doesn't look out of place.
            e.Paint(e.CellBounds, DataGridViewPaintParts.Border)

            ' 3. Mark the event as "handled". This is crucial.
            '    It tells the DataGridView, "I have finished painting this cell, do not do anything else."
            '    This prevents the button from being drawn on top of our custom background.
            e.Handled = True
        Else
            ' --- This is NOT the admin's row. Let the DataGridView draw the button as usual. ---
            ' By not setting e.Handled = True here, we allow the default button painting to proceed.
            ' We still need to ensure the button has the correct style.
            e.CellStyle.BackColor = Color.FromArgb(217, 83, 79)
            e.CellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtUpdateUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUpdateUsername.TextChanged
        
    End Sub

    Private Sub cboUpdateUsername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUpdateUsername.SelectedIndexChanged
        ' When a user is selected from the dropdown, update the textbox.
        If cboUpdateUsername.SelectedIndex > -1 AndAlso cboUpdateUsername.SelectedItem IsNot Nothing Then
            txtUpdateUsername.Text = cboUpdateUsername.Text
        End If
    End Sub
End Class