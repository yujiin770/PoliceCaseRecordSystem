Imports System.Drawing.Drawing2D
Public Class AdminForm


   
    Private Sub BtnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDashboard.Click
        ' --- NEW METHOD ---
        ' 1. Create a NEW instance of the Dashboard form.
        Dim dash As New Dashboard()
        ' 2. Clear the panel.
        MainPanel.Controls.Clear()
        ' 3. Configure and add the NEW instance.
        dash.TopLevel = False
        MainPanel.Controls.Add(dash)
        dash.Show()
        ' 4. Apply button colors.
        DashboardBtn()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        ' --- NEW METHOD ---
        Dim addFrm As New AddRecordFrm()
        MainPanel.Controls.Clear()
        addFrm.TopLevel = False
        MainPanel.Controls.Add(addFrm)
        addFrm.Show()
        AddBtn()
    End Sub

    Private Sub BtnManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnManage.Click
        ' --- NEW METHOD ---
        Dim manageFrm As New ManageForm()
        MainPanel.Controls.Clear()
        manageFrm.TopLevel = False
        MainPanel.Controls.Add(manageFrm)
        manageFrm.Show()
        ManageBtn()
    End Sub

    Private Sub BtnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReports.Click
        ' --- NEW METHOD ---
        Dim Reportsfrm As New ReportsFrm()
        MainPanel.Controls.Clear()
        Reportsfrm.TopLevel = False
        MainPanel.Controls.Add(Reportsfrm)
        Reportsfrm.Show()
        ReportBtn()
    End Sub

    Private Sub BtnArchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArchive.Click
        ' --- NEW METHOD ---
        Dim archiveFrm As New ArchiveFrm()
        MainPanel.Controls.Clear()
        archiveFrm.TopLevel = False
        MainPanel.Controls.Add(archiveFrm)
        archiveFrm.Show()
        ArchiveBtn()
    End Sub


    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        ' --- NEW METHOD ---
        Dim BackupandRestore As New BackupandRestoreFrm()
        MainPanel.Controls.Clear()
        BackupandRestore.TopLevel = False
        MainPanel.Controls.Add(BackupandRestore)
        BackupandRestore.Show()
        ViewBtn()
    End Sub

    Sub DashboardExit()
        
    End Sub


    'Color Sub

    Private Sub DashboardBtn()
        BtnDashboard.BaseColor = Color.FromArgb(250, 250, 250)
        BtnAdd.BaseColor = Color.Transparent
        BtnArchive.BaseColor = Color.Transparent
        BtnManage.BaseColor = Color.Transparent
        BtnReports.BaseColor = Color.Transparent
        BtnSettings.BaseColor = Color.Transparent
        BtnView.BaseColor = Color.Transparent

        BtnDashboard.ForeColor = Color.FromArgb(148, 41, 34)
        BtnAdd.ForeColor = Color.FromArgb(250, 250, 250)
        BtnArchive.ForeColor = Color.FromArgb(250, 250, 250)
        BtnManage.ForeColor = Color.FromArgb(250, 250, 250)
        BtnReports.ForeColor = Color.FromArgb(250, 250, 250)
        BtnSettings.ForeColor = Color.FromArgb(250, 250, 250)
        BtnView.ForeColor = Color.FromArgb(250, 250, 250)

        BtnDashboard.Image = My.Resources.DashboardIconRed
        BtnAdd.Image = My.Resources.add
        BtnArchive.Image = My.Resources.backup
        BtnManage.Image = My.Resources.record_keeping
        BtnReports.Image = My.Resources.report
        BtnSettings.Image = My.Resources.setting
        BtnView.Image = My.Resources.ViewRecords

    End Sub

    Sub AddBtn()
        BtnAdd.BaseColor = Color.FromArgb(250, 250, 250)
        BtnDashboard.BaseColor = Color.Transparent
        BtnArchive.BaseColor = Color.Transparent
        BtnManage.BaseColor = Color.Transparent
        BtnReports.BaseColor = Color.Transparent
        BtnSettings.BaseColor = Color.Transparent
        BtnView.BaseColor = Color.Transparent

        BtnAdd.ForeColor = Color.FromArgb(148, 41, 34)
        BtnDashboard.ForeColor = Color.FromArgb(250, 250, 250)
        BtnArchive.ForeColor = Color.FromArgb(250, 250, 250)
        BtnManage.ForeColor = Color.FromArgb(250, 250, 250)
        BtnReports.ForeColor = Color.FromArgb(250, 250, 250)
        BtnSettings.ForeColor = Color.FromArgb(250, 250, 250)
        BtnView.ForeColor = Color.FromArgb(250, 250, 250)

        BtnAdd.Image = My.Resources.addRed
        BtnDashboard.Image = My.Resources.DashboardIcon
        BtnArchive.Image = My.Resources.backup
        BtnManage.Image = My.Resources.record_keeping
        BtnReports.Image = My.Resources.report
        BtnSettings.Image = My.Resources.setting
        BtnView.Image = My.Resources.ViewRecords
    End Sub

    Private Sub ManageBtn()
        BtnManage.BaseColor = Color.FromArgb(250, 250, 250)
        BtnAdd.BaseColor = Color.Transparent
        BtnDashboard.BaseColor = Color.Transparent
        BtnArchive.BaseColor = Color.Transparent
        BtnReports.BaseColor = Color.Transparent
        BtnSettings.BaseColor = Color.Transparent
        BtnView.BaseColor = Color.Transparent

        BtnAdd.ForeColor = Color.FromArgb(250, 250, 250)
        BtnDashboard.ForeColor = Color.FromArgb(250, 250, 250)
        BtnArchive.ForeColor = Color.FromArgb(250, 250, 250)
        BtnManage.ForeColor = Color.FromArgb(148, 41, 34)
        BtnReports.ForeColor = Color.FromArgb(250, 250, 250)
        BtnSettings.ForeColor = Color.FromArgb(250, 250, 250)
        BtnView.ForeColor = Color.FromArgb(250, 250, 250)

        BtnAdd.Image = My.Resources.add
        BtnDashboard.Image = My.Resources.DashboardIcon
        BtnArchive.Image = My.Resources.backup
        BtnManage.Image = My.Resources.record_keepingRed
        BtnReports.Image = My.Resources.report
        BtnSettings.Image = My.Resources.setting
        BtnView.Image = My.Resources.ViewRecords

    End Sub

    Private Sub ViewBtn()
        BtnManage.BaseColor = Color.Transparent
        BtnAdd.BaseColor = Color.Transparent
        BtnDashboard.BaseColor = Color.Transparent
        BtnArchive.BaseColor = Color.Transparent
        BtnReports.BaseColor = Color.Transparent
        BtnSettings.BaseColor = Color.Transparent
        BtnView.BaseColor = Color.White

        BtnAdd.ForeColor = Color.White
        BtnDashboard.ForeColor = Color.White
        BtnArchive.ForeColor = Color.White
        BtnManage.ForeColor = Color.White
        BtnReports.ForeColor = Color.White
        BtnSettings.ForeColor = Color.White
        BtnView.ForeColor = Color.FromArgb(148, 41, 34)

        BtnAdd.Image = My.Resources.add
        BtnDashboard.Image = My.Resources.DashboardIcon
        BtnArchive.Image = My.Resources.backup
        BtnManage.Image = My.Resources.record_keeping
        BtnReports.Image = My.Resources.report
        BtnSettings.Image = My.Resources.setting
        BtnView.Image = My.Resources.ViewRecordsRed
    End Sub

    Private Sub ReportBtn()
        BtnManage.BaseColor = Color.Transparent
        BtnAdd.BaseColor = Color.Transparent
        BtnDashboard.BaseColor = Color.Transparent
        BtnArchive.BaseColor = Color.Transparent
        BtnReports.BaseColor = Color.FromArgb(250, 250, 250)
        BtnSettings.BaseColor = Color.Transparent
        BtnView.BaseColor = Color.Transparent

        BtnAdd.ForeColor = Color.FromArgb(250, 250, 250)
        BtnDashboard.ForeColor = Color.FromArgb(250, 250, 250)
        BtnArchive.ForeColor = Color.FromArgb(250, 250, 250)
        BtnManage.ForeColor = Color.FromArgb(250, 250, 250)
        BtnReports.ForeColor = Color.FromArgb(148, 41, 34)
        BtnSettings.ForeColor = Color.FromArgb(250, 250, 250)
        BtnView.ForeColor = Color.FromArgb(250, 250, 250)

        BtnAdd.Image = My.Resources.add
        BtnDashboard.Image = My.Resources.DashboardIcon
        BtnArchive.Image = My.Resources.backup
        BtnManage.Image = My.Resources.record_keeping
        BtnReports.Image = My.Resources.reportRed
        BtnSettings.Image = My.Resources.setting
        BtnView.Image = My.Resources.ViewRecords
    End Sub

    Private Sub ArchiveBtn()
        BtnManage.BaseColor = Color.Transparent
        BtnAdd.BaseColor = Color.Transparent
        BtnDashboard.BaseColor = Color.Transparent
        BtnArchive.BaseColor = Color.FromArgb(250, 250, 250)
        BtnReports.BaseColor = Color.Transparent
        BtnSettings.BaseColor = Color.Transparent
        BtnView.BaseColor = Color.Transparent

        BtnAdd.ForeColor = Color.FromArgb(250, 250, 250)
        BtnDashboard.ForeColor = Color.FromArgb(250, 250, 250)
        BtnArchive.ForeColor = Color.FromArgb(148, 41, 34)
        BtnManage.ForeColor = Color.FromArgb(250, 250, 250)
        BtnReports.ForeColor = Color.FromArgb(250, 250, 250)
        BtnSettings.ForeColor = Color.FromArgb(250, 250, 250)
        BtnView.ForeColor = Color.FromArgb(250, 250, 250)

        BtnAdd.Image = My.Resources.add
        BtnDashboard.Image = My.Resources.DashboardIcon
        BtnArchive.Image = My.Resources.backupRed
        BtnManage.Image = My.Resources.record_keeping
        BtnReports.Image = My.Resources.report
        BtnSettings.Image = My.Resources.setting
        BtnView.Image = My.Resources.ViewRecords
    End Sub

    Private Sub SettingBtn()
        BtnManage.BaseColor = Color.Transparent
        BtnAdd.BaseColor = Color.Transparent
        BtnDashboard.BaseColor = Color.Transparent
        BtnArchive.BaseColor = Color.Transparent
        BtnReports.BaseColor = Color.Transparent
        BtnSettings.BaseColor = Color.FromArgb(250, 250, 250)
        BtnView.BaseColor = Color.Transparent

        BtnAdd.ForeColor = Color.FromArgb(250, 250, 250)
        BtnDashboard.ForeColor = Color.FromArgb(250, 250, 250)
        BtnArchive.ForeColor = Color.FromArgb(250, 250, 250)
        BtnManage.ForeColor = Color.FromArgb(250, 250, 250)
        BtnReports.ForeColor = Color.FromArgb(250, 250, 250)
        BtnSettings.ForeColor = Color.FromArgb(148, 41, 34)
        BtnView.ForeColor = Color.FromArgb(250, 250, 250)

        BtnAdd.Image = My.Resources.add
        BtnDashboard.Image = My.Resources.DashboardIcon
        BtnArchive.Image = My.Resources.backup
        BtnManage.Image = My.Resources.record_keeping
        BtnReports.Image = My.Resources.report
        BtnSettings.Image = My.Resources.settingRed
        BtnView.Image = My.Resources.ViewRecords
    End Sub

    Private Sub AdminForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ApplyRolePermissions()
    End Sub

    Private Sub AdminForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'To make form application has edge curves
        Dim radius As Integer = 50 ' Adjust for more or less curve
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New GraphicsPath()
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)


        ApplyRolePermissions()

        ' --- NEW METHOD for default panel ---
        Dim dash As New Dashboard()
        MainPanel.Controls.Clear()
        dash.TopLevel = False
        MainPanel.Controls.Add(dash)
        dash.Show()
        DashboardBtn()

    End Sub

    Private Sub AdminForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim radius As Integer = 50
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

  

    Private Sub BtnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSettings.Click
        Dim Settingfrm As New SettingFrm()
        MainPanel.Controls.Clear()
        Settingfrm.TopLevel = False
        MainPanel.Controls.Add(Settingfrm)
        Settingfrm.Show()
        SettingBtn()
    End Sub

    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Clear the session variable for security
            SESSION = Nothing

            ' Show the login form
            LoginForm.Show()
            LoginForm.UsernameTxtBox.Focus()
            LoginForm.gunatransitionentrance()

            ' --- THIS IS THE FIX ---
            ' Completely close this instance of the AdminForm instead of just hiding it.
            Me.Close()
        End If
    End Sub

    Private Sub ApplyRolePermissions()
        If SESSION IsNot Nothing AndAlso SESSION("Role").ToString() <> "Admin" Then
            ' --- This is the setup for an "Officer" user ---

            ' Change button text for clarity.
            BtnManage.Text = "View Active Records"
            BtnArchive.Text = "View Archives"

            ' Hide buttons that Officers cannot use.
            BtnReports.Visible = False
            BtnSettings.Visible = False
            ' Assuming BtnView is another admin-only button, hiding it is correct.
            BtnView.Visible = True
            ViewCase.btnViewAttachment.Visible = False
            Label4.Visible = False


            ' --- Move the Logout button to a new position ---
            ' You'll need to use the Point object for location.
            BtnView.Location = New Point(39, 488) ' Sets the X and Y coordinates
            Label5.Location = New Point(51, 460)
            LogoutBtn.Location = New Point(41, 545)

        ElseIf SESSION IsNot Nothing AndAlso SESSION("Role").ToString() = "Admin" Then
            ' --- This is the setup for an "Admin" user ---

            ' Ensure button text is correct for Admins.
            BtnManage.Text = "Manage Records"
            BtnArchive.Text = "Archive Records"

            ' Make sure all Admin buttons are visible.
            BtnReports.Visible = True
            BtnSettings.Visible = True
            BtnView.Visible = True

            ' --- IMPORTANT: Reset the Logout button to its original location ---
            ' Find the original X and Y coordinates from the form designer's properties.
            ' For example, if the original location was (39, 650):
            LogoutBtn.Location = New Point(41, 673)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MainPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainPanel.Paint

    End Sub
End Class