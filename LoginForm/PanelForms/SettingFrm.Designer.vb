<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingFrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BtnExit = New Guna.UI.WinForms.GunaLabel()
        Me.btnCreateUser = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtNewPasswordConfirm = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNewPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNewUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtUpdateUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.cboUpdateUsername = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.btnUpdatePassword = New Guna.UI.WinForms.GunaButton()
        Me.txtUpdatePasswordConfirm = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtUpdatePassword = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.dgvUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.BtnActivityLogs = New Guna.UI.WinForms.GunaButton()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 37)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "USER ACCOUNTS"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox2.BorderRadius = 7
        Me.Guna2GroupBox2.BorderThickness = 2
        Me.Guna2GroupBox2.Controls.Add(Me.BtnExit)
        Me.Guna2GroupBox2.Controls.Add(Me.btnCreateUser)
        Me.Guna2GroupBox2.Controls.Add(Me.GunaPictureBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.txtNewPasswordConfirm)
        Me.Guna2GroupBox2.Controls.Add(Me.GunaLabel3)
        Me.Guna2GroupBox2.Controls.Add(Me.txtNewPassword)
        Me.Guna2GroupBox2.Controls.Add(Me.GunaLabel2)
        Me.Guna2GroupBox2.Controls.Add(Me.txtNewUsername)
        Me.Guna2GroupBox2.Controls.Add(Me.GunaLabel8)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(75, 97)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(854, 574)
        Me.Guna2GroupBox2.TabIndex = 41
        Me.Guna2GroupBox2.Text = "Create New Officer Account"
        Me.Guna2GroupBox2.Visible = False
        '
        'BtnExit
        '
        Me.BtnExit.AutoSize = True
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(818, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(33, 32)
        Me.BtnExit.TabIndex = 53
        Me.BtnExit.Text = "X"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Animated = True
        Me.btnCreateUser.AnimationHoverSpeed = 0.07!
        Me.btnCreateUser.AnimationSpeed = 0.03!
        Me.btnCreateUser.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateUser.BaseColor = System.Drawing.Color.Transparent
        Me.btnCreateUser.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnCreateUser.BorderSize = 3
        Me.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateUser.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCreateUser.FocusedColor = System.Drawing.Color.Empty
        Me.btnCreateUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnCreateUser.Image = CType(resources.GetObject("btnCreateUser.Image"), System.Drawing.Image)
        Me.btnCreateUser.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnCreateUser.Location = New System.Drawing.Point(321, 495)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnCreateUser.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnCreateUser.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnCreateUser.OnHoverImage = Nothing
        Me.btnCreateUser.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnCreateUser.Radius = 7
        Me.btnCreateUser.Size = New System.Drawing.Size(184, 38)
        Me.btnCreateUser.TabIndex = 52
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(253, 53)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(306, 162)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 51
        Me.GunaPictureBox1.TabStop = False
        '
        'txtNewPasswordConfirm
        '
        Me.txtNewPasswordConfirm.BackColor = System.Drawing.Color.Transparent
        Me.txtNewPasswordConfirm.BaseColor = System.Drawing.Color.White
        Me.txtNewPasswordConfirm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtNewPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPasswordConfirm.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNewPasswordConfirm.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtNewPasswordConfirm.FocusedForeColor = System.Drawing.Color.Black
        Me.txtNewPasswordConfirm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPasswordConfirm.ForeColor = System.Drawing.Color.Black
        Me.txtNewPasswordConfirm.Location = New System.Drawing.Point(195, 438)
        Me.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm"
        Me.txtNewPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPasswordConfirm.Radius = 10
        Me.txtNewPasswordConfirm.SelectedText = ""
        Me.txtNewPasswordConfirm.Size = New System.Drawing.Size(442, 33)
        Me.txtNewPasswordConfirm.TabIndex = 48
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.White
        Me.GunaLabel3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(200, 412)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(167, 23)
        Me.GunaLabel3.TabIndex = 47
        Me.GunaLabel3.Text = "Re-enter Password"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtNewPassword.BaseColor = System.Drawing.Color.White
        Me.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNewPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtNewPassword.FocusedForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.Location = New System.Drawing.Point(195, 366)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPassword.Radius = 10
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.Size = New System.Drawing.Size(442, 33)
        Me.txtNewPassword.TabIndex = 46
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.White
        Me.GunaLabel2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(200, 340)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(148, 23)
        Me.GunaLabel2.TabIndex = 45
        Me.GunaLabel2.Text = "Create Password"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNewUsername
        '
        Me.txtNewUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtNewUsername.BaseColor = System.Drawing.Color.White
        Me.txtNewUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtNewUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNewUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtNewUsername.FocusedForeColor = System.Drawing.Color.Black
        Me.txtNewUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.ForeColor = System.Drawing.Color.Black
        Me.txtNewUsername.Location = New System.Drawing.Point(195, 304)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewUsername.Radius = 10
        Me.txtNewUsername.SelectedText = ""
        Me.txtNewUsername.Size = New System.Drawing.Size(442, 33)
        Me.txtNewUsername.TabIndex = 44
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.White
        Me.GunaLabel8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(200, 278)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(154, 23)
        Me.GunaLabel8.TabIndex = 43
        Me.GunaLabel8.Text = "Create Username"
        Me.GunaLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 7
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.txtUpdateUsername)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel7)
        Me.Guna2GroupBox1.Controls.Add(Me.cboUpdateUsername)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.btnUpdatePassword)
        Me.Guna2GroupBox1.Controls.Add(Me.txtUpdatePasswordConfirm)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel5)
        Me.Guna2GroupBox1.Controls.Add(Me.txtUpdatePassword)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel4)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaPictureBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(75, 97)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(854, 574)
        Me.Guna2GroupBox1.TabIndex = 42
        Me.Guna2GroupBox1.Text = "Change a User Password"
        Me.Guna2GroupBox1.Visible = False
        '
        'txtUpdateUsername
        '
        Me.txtUpdateUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUpdateUsername.BaseColor = System.Drawing.Color.White
        Me.txtUpdateUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtUpdateUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUpdateUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUpdateUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtUpdateUsername.FocusedForeColor = System.Drawing.Color.Black
        Me.txtUpdateUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUpdateUsername.Location = New System.Drawing.Point(208, 317)
        Me.txtUpdateUsername.Name = "txtUpdateUsername"
        Me.txtUpdateUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUpdateUsername.Radius = 10
        Me.txtUpdateUsername.SelectedText = ""
        Me.txtUpdateUsername.Size = New System.Drawing.Size(442, 33)
        Me.txtUpdateUsername.TabIndex = 59
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.White
        Me.GunaLabel7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(204, 291)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(137, 23)
        Me.GunaLabel7.TabIndex = 58
        Me.GunaLabel7.Text = "New Username"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboUpdateUsername
        '
        Me.cboUpdateUsername.BackColor = System.Drawing.Color.Transparent
        Me.cboUpdateUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cboUpdateUsername.BorderRadius = 7
        Me.cboUpdateUsername.BorderThickness = 2
        Me.cboUpdateUsername.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUpdateUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUpdateUsername.FocusedColor = System.Drawing.Color.Empty
        Me.cboUpdateUsername.FocusedState.Parent = Me.cboUpdateUsername
        Me.cboUpdateUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboUpdateUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboUpdateUsername.FormattingEnabled = True
        Me.cboUpdateUsername.HoverState.Parent = Me.cboUpdateUsername
        Me.cboUpdateUsername.ItemHeight = 30
        Me.cboUpdateUsername.ItemsAppearance.Parent = Me.cboUpdateUsername
        Me.cboUpdateUsername.Location = New System.Drawing.Point(208, 252)
        Me.cboUpdateUsername.Name = "cboUpdateUsername"
        Me.cboUpdateUsername.ShadowDecoration.Parent = Me.cboUpdateUsername
        Me.cboUpdateUsername.Size = New System.Drawing.Size(442, 36)
        Me.cboUpdateUsername.TabIndex = 57
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaLabel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaLabel6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(817, 5)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(33, 32)
        Me.GunaLabel6.TabIndex = 56
        Me.GunaLabel6.Text = "X"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.Animated = True
        Me.btnUpdatePassword.AnimationHoverSpeed = 0.07!
        Me.btnUpdatePassword.AnimationSpeed = 0.03!
        Me.btnUpdatePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.BaseColor = System.Drawing.Color.Transparent
        Me.btnUpdatePassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdatePassword.BorderSize = 3
        Me.btnUpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdatePassword.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdatePassword.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdatePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdatePassword.Image = CType(resources.GetObject("btnUpdatePassword.Image"), System.Drawing.Image)
        Me.btnUpdatePassword.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnUpdatePassword.Location = New System.Drawing.Point(334, 502)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdatePassword.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdatePassword.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUpdatePassword.OnHoverImage = Nothing
        Me.btnUpdatePassword.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdatePassword.Radius = 7
        Me.btnUpdatePassword.Size = New System.Drawing.Size(184, 38)
        Me.btnUpdatePassword.TabIndex = 55
        Me.btnUpdatePassword.Text = "Update"
        Me.btnUpdatePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUpdatePasswordConfirm
        '
        Me.txtUpdatePasswordConfirm.BackColor = System.Drawing.Color.Transparent
        Me.txtUpdatePasswordConfirm.BaseColor = System.Drawing.Color.White
        Me.txtUpdatePasswordConfirm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtUpdatePasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUpdatePasswordConfirm.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUpdatePasswordConfirm.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtUpdatePasswordConfirm.FocusedForeColor = System.Drawing.Color.Black
        Me.txtUpdatePasswordConfirm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePasswordConfirm.ForeColor = System.Drawing.Color.Black
        Me.txtUpdatePasswordConfirm.Location = New System.Drawing.Point(208, 456)
        Me.txtUpdatePasswordConfirm.Name = "txtUpdatePasswordConfirm"
        Me.txtUpdatePasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUpdatePasswordConfirm.Radius = 10
        Me.txtUpdatePasswordConfirm.SelectedText = ""
        Me.txtUpdatePasswordConfirm.Size = New System.Drawing.Size(442, 33)
        Me.txtUpdatePasswordConfirm.TabIndex = 54
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.White
        Me.GunaLabel5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel5.Location = New System.Drawing.Point(204, 428)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(210, 23)
        Me.GunaLabel5.TabIndex = 53
        Me.GunaLabel5.Text = "Re-enter New Password"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtUpdatePassword
        '
        Me.txtUpdatePassword.BackColor = System.Drawing.Color.Transparent
        Me.txtUpdatePassword.BaseColor = System.Drawing.Color.White
        Me.txtUpdatePassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtUpdatePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUpdatePassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUpdatePassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtUpdatePassword.FocusedForeColor = System.Drawing.Color.Black
        Me.txtUpdatePassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePassword.ForeColor = System.Drawing.Color.Black
        Me.txtUpdatePassword.Location = New System.Drawing.Point(208, 386)
        Me.txtUpdatePassword.Name = "txtUpdatePassword"
        Me.txtUpdatePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUpdatePassword.Radius = 10
        Me.txtUpdatePassword.SelectedText = ""
        Me.txtUpdatePassword.Size = New System.Drawing.Size(442, 33)
        Me.txtUpdatePassword.TabIndex = 52
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.White
        Me.GunaLabel4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel4.Location = New System.Drawing.Point(204, 360)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(131, 23)
        Me.GunaLabel4.TabIndex = 51
        Me.GunaLabel4.Text = "New Password"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(268, 57)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(306, 158)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 50
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(204, 226)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(55, 23)
        Me.GunaLabel1.TabIndex = 43
        Me.GunaLabel1.Text = "Users"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvUsers
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsers.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUsers.EnableHeadersVisualStyles = False
        Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.Location = New System.Drawing.Point(19, 172)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(955, 496)
        Me.dgvUsers.TabIndex = 57
        Me.dgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUsers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvUsers.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvUsers.ThemeStyle.ReadOnly = False
        Me.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.RowsStyle.Height = 22
        Me.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaButton1.BorderSize = 3
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(0, 0)
        Me.GunaButton1.Location = New System.Drawing.Point(366, 690)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GunaButton1.Radius = 7
        Me.GunaButton1.Size = New System.Drawing.Size(184, 38)
        Me.GunaButton1.TabIndex = 53
        Me.GunaButton1.Text = "Create User"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.BorderSize = 3
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(0, 0)
        Me.GunaButton2.Location = New System.Drawing.Point(556, 690)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.Radius = 7
        Me.GunaButton2.Size = New System.Drawing.Size(184, 38)
        Me.GunaButton2.TabIndex = 55
        Me.GunaButton2.Text = "Change User Password"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnActivityLogs
        '
        Me.BtnActivityLogs.Animated = True
        Me.BtnActivityLogs.AnimationHoverSpeed = 0.07!
        Me.BtnActivityLogs.AnimationSpeed = 0.03!
        Me.BtnActivityLogs.BackColor = System.Drawing.Color.Transparent
        Me.BtnActivityLogs.BaseColor = System.Drawing.Color.Transparent
        Me.BtnActivityLogs.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnActivityLogs.BorderSize = 3
        Me.BtnActivityLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActivityLogs.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnActivityLogs.FocusedColor = System.Drawing.Color.Empty
        Me.BtnActivityLogs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivityLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnActivityLogs.Image = CType(resources.GetObject("BtnActivityLogs.Image"), System.Drawing.Image)
        Me.BtnActivityLogs.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnActivityLogs.Location = New System.Drawing.Point(746, 690)
        Me.BtnActivityLogs.Name = "BtnActivityLogs"
        Me.BtnActivityLogs.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnActivityLogs.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnActivityLogs.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnActivityLogs.OnHoverImage = Nothing
        Me.BtnActivityLogs.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnActivityLogs.Radius = 7
        Me.BtnActivityLogs.Size = New System.Drawing.Size(184, 38)
        Me.BtnActivityLogs.TabIndex = 56
        Me.BtnActivityLogs.Text = "Activity logs"
        Me.BtnActivityLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SettingFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 768)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.BtnActivityLogs)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingFrm"
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtNewPasswordConfirm As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtNewPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtNewUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtUpdatePasswordConfirm As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtUpdatePassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnCreateUser As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUpdatePassword As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnExit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cboUpdateUsername As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnActivityLogs As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvUsers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtUpdateUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
End Class
