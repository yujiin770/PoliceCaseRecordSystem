<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.LogoutBtn = New Guna.UI.WinForms.GunaButton()
        Me.BtnSettings = New Guna.UI.WinForms.GunaButton()
        Me.BtnArchive = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnReports = New Guna.UI.WinForms.GunaButton()
        Me.BtnView = New Guna.UI.WinForms.GunaButton()
        Me.BtnManage = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdd = New Guna.UI.WinForms.GunaButton()
        Me.BtnDashboard = New Guna.UI.WinForms.GunaButton()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 54
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.LogoutBtn)
        Me.Guna2Panel1.Controls.Add(Me.BtnSettings)
        Me.Guna2Panel1.Controls.Add(Me.BtnArchive)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.BtnReports)
        Me.Guna2Panel1.Controls.Add(Me.BtnView)
        Me.Guna2Panel1.Controls.Add(Me.BtnManage)
        Me.Guna2Panel1.Controls.Add(Me.BtnAdd)
        Me.Guna2Panel1.Controls.Add(Me.BtnDashboard)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-43, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(363, 778)
        Me.Guna2Panel1.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 542)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 21)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Report"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(51, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Records"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(74, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "MARULAS POLICE STATION"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MainPanel.Location = New System.Drawing.Point(327, -1)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.ShadowDecoration.Parent = Me.MainPanel
        Me.MainPanel.Size = New System.Drawing.Size(1007, 773)
        Me.MainPanel.TabIndex = 16
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Animated = True
        Me.LogoutBtn.AnimationHoverSpeed = 0.07!
        Me.LogoutBtn.AnimationSpeed = 0.03!
        Me.LogoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LogoutBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LogoutBtn.BorderSize = 2
        Me.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LogoutBtn.FocusedColor = System.Drawing.Color.Empty
        Me.LogoutBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LogoutBtn.Image = Global.LoginForm.My.Resources.Resources.logout2
        Me.LogoutBtn.ImageOffsetX = 10
        Me.LogoutBtn.ImageSize = New System.Drawing.Size(32, 32)
        Me.LogoutBtn.Location = New System.Drawing.Point(41, 673)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LogoutBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LogoutBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LogoutBtn.OnHoverImage = Global.LoginForm.My.Resources.Resources.Logout1
        Me.LogoutBtn.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LogoutBtn.Radius = 5
        Me.LogoutBtn.Size = New System.Drawing.Size(333, 51)
        Me.LogoutBtn.TabIndex = 38
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.TextOffsetX = 18
        '
        'BtnSettings
        '
        Me.BtnSettings.Animated = True
        Me.BtnSettings.AnimationHoverSpeed = 0.07!
        Me.BtnSettings.AnimationSpeed = 0.03!
        Me.BtnSettings.BackColor = System.Drawing.Color.Transparent
        Me.BtnSettings.BaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSettings.BorderSize = 2
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnSettings.FocusedColor = System.Drawing.Color.Empty
        Me.BtnSettings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnSettings.Image = Global.LoginForm.My.Resources.Resources.setting
        Me.BtnSettings.ImageOffsetX = 10
        Me.BtnSettings.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnSettings.Location = New System.Drawing.Point(41, 620)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnSettings.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSettings.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSettings.OnHoverImage = Global.LoginForm.My.Resources.Resources.settingRed
        Me.BtnSettings.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSettings.Radius = 5
        Me.BtnSettings.Size = New System.Drawing.Size(333, 51)
        Me.BtnSettings.TabIndex = 38
        Me.BtnSettings.Text = "Account Settings"
        Me.BtnSettings.TextOffsetX = 18
        '
        'BtnArchive
        '
        Me.BtnArchive.Animated = True
        Me.BtnArchive.AnimationHoverSpeed = 0.07!
        Me.BtnArchive.AnimationSpeed = 0.03!
        Me.BtnArchive.BackColor = System.Drawing.Color.Transparent
        Me.BtnArchive.BaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnArchive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnArchive.BorderSize = 2
        Me.BtnArchive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnArchive.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnArchive.FocusedColor = System.Drawing.Color.Empty
        Me.BtnArchive.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArchive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnArchive.Image = Global.LoginForm.My.Resources.Resources.backup
        Me.BtnArchive.ImageOffsetX = 8
        Me.BtnArchive.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnArchive.Location = New System.Drawing.Point(39, 408)
        Me.BtnArchive.Name = "BtnArchive"
        Me.BtnArchive.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnArchive.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnArchive.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnArchive.OnHoverImage = Global.LoginForm.My.Resources.Resources.backupRed
        Me.BtnArchive.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnArchive.Radius = 5
        Me.BtnArchive.Size = New System.Drawing.Size(333, 51)
        Me.BtnArchive.TabIndex = 37
        Me.BtnArchive.Text = "Archive Records"
        Me.BtnArchive.TextOffsetX = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, -35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 226)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'BtnReports
        '
        Me.BtnReports.Animated = True
        Me.BtnReports.AnimationHoverSpeed = 0.07!
        Me.BtnReports.AnimationSpeed = 0.03!
        Me.BtnReports.BackColor = System.Drawing.Color.Transparent
        Me.BtnReports.BaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnReports.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnReports.BorderSize = 2
        Me.BtnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReports.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnReports.FocusedColor = System.Drawing.Color.Empty
        Me.BtnReports.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnReports.Image = Global.LoginForm.My.Resources.Resources.report
        Me.BtnReports.ImageOffsetX = 8
        Me.BtnReports.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnReports.Location = New System.Drawing.Point(39, 488)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnReports.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnReports.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnReports.OnHoverImage = Global.LoginForm.My.Resources.Resources.reportRed
        Me.BtnReports.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnReports.Radius = 5
        Me.BtnReports.Size = New System.Drawing.Size(333, 51)
        Me.BtnReports.TabIndex = 34
        Me.BtnReports.Text = "Reports"
        Me.BtnReports.TextOffsetX = 19
        '
        'BtnView
        '
        Me.BtnView.Animated = True
        Me.BtnView.AnimationHoverSpeed = 0.07!
        Me.BtnView.AnimationSpeed = 0.03!
        Me.BtnView.BackColor = System.Drawing.Color.Transparent
        Me.BtnView.BaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnView.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnView.BorderSize = 2
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnView.FocusedColor = System.Drawing.Color.Empty
        Me.BtnView.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnView.Image = Global.LoginForm.My.Resources.Resources.ViewRecords
        Me.BtnView.ImageOffsetX = 10
        Me.BtnView.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnView.Location = New System.Drawing.Point(41, 569)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnView.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnView.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnView.OnHoverImage = Global.LoginForm.My.Resources.Resources.ViewRecordsRed
        Me.BtnView.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnView.Radius = 5
        Me.BtnView.Size = New System.Drawing.Size(333, 51)
        Me.BtnView.TabIndex = 33
        Me.BtnView.Text = "Backup & Restore"
        Me.BtnView.TextOffsetX = 18
        '
        'BtnManage
        '
        Me.BtnManage.Animated = True
        Me.BtnManage.AnimationHoverSpeed = 0.07!
        Me.BtnManage.AnimationSpeed = 0.03!
        Me.BtnManage.BackColor = System.Drawing.Color.Transparent
        Me.BtnManage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnManage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnManage.BorderSize = 2
        Me.BtnManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnManage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnManage.FocusedColor = System.Drawing.Color.Empty
        Me.BtnManage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnManage.Image = Global.LoginForm.My.Resources.Resources.record_keeping
        Me.BtnManage.ImageOffsetX = 10
        Me.BtnManage.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnManage.Location = New System.Drawing.Point(41, 358)
        Me.BtnManage.Name = "BtnManage"
        Me.BtnManage.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnManage.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnManage.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnManage.OnHoverImage = Global.LoginForm.My.Resources.Resources.record_keepingRed
        Me.BtnManage.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnManage.Radius = 5
        Me.BtnManage.Size = New System.Drawing.Size(333, 51)
        Me.BtnManage.TabIndex = 32
        Me.BtnManage.Text = "Manage Records"
        Me.BtnManage.TextOffsetX = 17
        '
        'BtnAdd
        '
        Me.BtnAdd.Animated = True
        Me.BtnAdd.AnimationHoverSpeed = 0.07!
        Me.BtnAdd.AnimationSpeed = 0.03!
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAdd.BorderSize = 2
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnAdd.Image = Global.LoginForm.My.Resources.Resources.add
        Me.BtnAdd.ImageOffsetX = 10
        Me.BtnAdd.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnAdd.Location = New System.Drawing.Point(41, 306)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnAdd.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAdd.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAdd.OnHoverImage = Global.LoginForm.My.Resources.Resources.addRed
        Me.BtnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAdd.Radius = 5
        Me.BtnAdd.Size = New System.Drawing.Size(333, 51)
        Me.BtnAdd.TabIndex = 31
        Me.BtnAdd.Text = "Add Records"
        Me.BtnAdd.TextOffsetX = 17
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Animated = True
        Me.BtnDashboard.AnimationHoverSpeed = 0.07!
        Me.BtnDashboard.AnimationSpeed = 0.03!
        Me.BtnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.BtnDashboard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnDashboard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnDashboard.BorderSize = 2
        Me.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnDashboard.FocusedColor = System.Drawing.Color.Empty
        Me.BtnDashboard.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnDashboard.Image = Global.LoginForm.My.Resources.Resources.DashboardIconRed
        Me.BtnDashboard.ImageOffsetX = 10
        Me.BtnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.BtnDashboard.Location = New System.Drawing.Point(41, 228)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.OnHoverBaseColor = System.Drawing.Color.White
        Me.BtnDashboard.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnDashboard.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnDashboard.OnHoverImage = Global.LoginForm.My.Resources.Resources.DashboardIconRed
        Me.BtnDashboard.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnDashboard.Radius = 5
        Me.BtnDashboard.Size = New System.Drawing.Size(333, 51)
        Me.BtnDashboard.TabIndex = 30
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.TextOffsetX = 25
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1334, 772)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnReports As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnView As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnManage As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnDashboard As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnArchive As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnSettings As Guna.UI.WinForms.GunaButton
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LogoutBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
