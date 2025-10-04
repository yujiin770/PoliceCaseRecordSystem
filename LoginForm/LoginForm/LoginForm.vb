Imports System.Drawing.Drawing2D
Public Class LoginForm
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
       Dim result = utilities.Login(UsernameTxtBox.Text, PasswordTextBox.Text)

        If result Then
            ' --- THIS IS THE CORRECT IMPLEMENTATION ---
            ' 1. Create a NEW, clean instance of the AdminForm.
            Dim NewAdminForm As New AdminForm()



            ' 2. Show the NEW instance. This forces its Form_Load event to run.
            NewAdminForm.Show()

            ' 3. Clean up the login form and hide it.
            UsernameTxtBox.Text = ""
            PasswordTextBox.Text = ""
            Me.Hide()

        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        ExitPanel.Visible = True
        BtnLogin.Enabled = False
        BtnExit.Enabled = False
        FrgtPassword.Enabled = False
        UsernameTxtBox.Enabled = False
        PasswordTextBox.Enabled = False

    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim radius As Integer = 50
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New GraphicsPath()
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)
        gunatransitionentrance()
        UsernameTxtBox.Focus()

    End Sub

    Sub gunatransitionentrancedashboard()
        GunaTransition1.Show(Dashboard.Guna2Panel1)
        GunaTransition2.Show(Dashboard.Guna2Panel2)
        GunaTransition3.Show(Dashboard.Guna2Panel3)
        GunaTransition4.Show(Dashboard.Guna2Panel4)
        GunaTransition5.Show(Dashboard.GunaButton1)
        GunaTransition6.Show(Dashboard.Label2)
        GunaTransition6.Show(AdminForm.Guna2Panel1)
    End Sub

    Sub gunatransitionentrance()
        GunaTransition1.Show(Panel1)
        GunaTransition2.Show(GunaLabel1)
        GunaTransition3.Show(GunaLabel2)
        GunaTransition4.Show(GunaLabel3)
        GunaTransition5.Show(GunaLabel4)
        GunaTransition6.Show(GunaPictureBox1)
    End Sub

    Sub gunatransitionexit()
        GunaTransition1.HideSync(Panel1)
        GunaTransition2.HideSync(GunaLabel1)
        GunaTransition3.HideSync(GunaLabel2)
        GunaTransition4.HideSync(GunaLabel3)
        GunaTransition5.HideSync(GunaLabel4)
        GunaTransition6.HideSync(GunaPictureBox1)
    End Sub
    Private Sub BtnYes_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYes.Click
        End
    End Sub

    Private Sub BtnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNo.Click
        ExitPanel.Visible = False
        BtnLogin.Enabled = True
        BtnExit.Enabled = True
        FrgtPassword.Enabled = True
        UsernameTxtBox.Enabled = True
        PasswordTextBox.Enabled = True
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnLogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BtnLogin.KeyPress

    End Sub

    Private Sub UsernameTxtBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTxtBox.KeyPress
        ' Check if the Enter key is pressed
        If e.KeyChar = Chr(13) Then
            ' Prevent the beep sound on Enter
            e.Handled = True

            ' Call your login button click event
            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub UsernameTxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTxtBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Chr(13) Then

            e.Handled = True


            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim radius As Integer = 50
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
    End Sub

    Private Sub GunaLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel3.Click

    End Sub

    Private Sub GunaLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel2.Click

    End Sub

    Private Sub FrgtPassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FrgtPassword.LinkClicked
        ' This simply informs the user what to do.
        ' A more advanced system might send an email, but this is a secure, manual approach.
        MsgBox("To reset your password, please contact an Administrator.",
               MsgBoxStyle.Information, "Password Reset")
    End Sub

    Private Sub Guna2ControlBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class