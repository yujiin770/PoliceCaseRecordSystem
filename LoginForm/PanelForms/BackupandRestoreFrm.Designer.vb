<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupandRestoreFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackupandRestoreFrm))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnStartBackup = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowseBackup = New Guna.UI.WinForms.GunaButton()
        Me.txtBackupPath = New Guna.UI.WinForms.GunaTextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnStartRestore = New Guna.UI.WinForms.GunaButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBrowseRestore = New Guna.UI.WinForms.GunaButton()
        Me.txtRestorePath = New Guna.UI.WinForms.GunaTextBox()
        Me.lblAccessDenied = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 7
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.Label11)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.btnStartBackup)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.btnBrowseBackup)
        Me.Guna2GroupBox1.Controls.Add(Me.txtBackupPath)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(17, 187)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(464, 472)
        Me.Guna2GroupBox1.TabIndex = 50
        Me.Guna2GroupBox1.Text = "Backup"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(13, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 20)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "message."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(13, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(402, 20)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "3. Click the ""Start Backup"" button and wait for the success"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(13, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 20)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "drive or a network folder."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(13, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(394, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "recommend saving to an external device like a USB flash"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(397, 20)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "2. Choose a location to save the backup file. We strongly "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(13, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "1. Click the ""Browse..."" button."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(406, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Creates a safe copy of the entire police records database."
        '
        'btnStartBackup
        '
        Me.btnStartBackup.Animated = True
        Me.btnStartBackup.AnimationHoverSpeed = 0.07!
        Me.btnStartBackup.AnimationSpeed = 0.03!
        Me.btnStartBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnStartBackup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnStartBackup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStartBackup.BorderSize = 3
        Me.btnStartBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartBackup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStartBackup.FocusedColor = System.Drawing.Color.Empty
        Me.btnStartBackup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStartBackup.Image = CType(resources.GetObject("btnStartBackup.Image"), System.Drawing.Image)
        Me.btnStartBackup.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnStartBackup.Location = New System.Drawing.Point(236, 157)
        Me.btnStartBackup.Name = "btnStartBackup"
        Me.btnStartBackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStartBackup.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStartBackup.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnStartBackup.OnHoverImage = Nothing
        Me.btnStartBackup.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStartBackup.Radius = 7
        Me.btnStartBackup.Size = New System.Drawing.Size(184, 38)
        Me.btnStartBackup.TabIndex = 52
        Me.btnStartBackup.Text = "Start Backup"
        Me.btnStartBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Backup Path"
        '
        'btnBrowseBackup
        '
        Me.btnBrowseBackup.Animated = True
        Me.btnBrowseBackup.AnimationHoverSpeed = 0.07!
        Me.btnBrowseBackup.AnimationSpeed = 0.03!
        Me.btnBrowseBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowseBackup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnBrowseBackup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseBackup.BorderSize = 3
        Me.btnBrowseBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowseBackup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBrowseBackup.FocusedColor = System.Drawing.Color.Empty
        Me.btnBrowseBackup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseBackup.Image = CType(resources.GetObject("btnBrowseBackup.Image"), System.Drawing.Image)
        Me.btnBrowseBackup.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnBrowseBackup.Location = New System.Drawing.Point(29, 157)
        Me.btnBrowseBackup.Name = "btnBrowseBackup"
        Me.btnBrowseBackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseBackup.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseBackup.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnBrowseBackup.OnHoverImage = Nothing
        Me.btnBrowseBackup.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnBrowseBackup.Radius = 7
        Me.btnBrowseBackup.Size = New System.Drawing.Size(184, 38)
        Me.btnBrowseBackup.TabIndex = 50
        Me.btnBrowseBackup.Text = "Browse"
        Me.btnBrowseBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBackupPath
        '
        Me.txtBackupPath.BackColor = System.Drawing.Color.Transparent
        Me.txtBackupPath.BaseColor = System.Drawing.Color.White
        Me.txtBackupPath.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtBackupPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBackupPath.FocusedBaseColor = System.Drawing.Color.White
        Me.txtBackupPath.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtBackupPath.FocusedForeColor = System.Drawing.Color.Black
        Me.txtBackupPath.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupPath.ForeColor = System.Drawing.Color.Black
        Me.txtBackupPath.Location = New System.Drawing.Point(17, 108)
        Me.txtBackupPath.Name = "txtBackupPath"
        Me.txtBackupPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBackupPath.Radius = 10
        Me.txtBackupPath.ReadOnly = True
        Me.txtBackupPath.SelectedText = ""
        Me.txtBackupPath.Size = New System.Drawing.Size(420, 33)
        Me.txtBackupPath.TabIndex = 27
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox2.BorderRadius = 7
        Me.Guna2GroupBox2.BorderThickness = 2
        Me.Guna2GroupBox2.Controls.Add(Me.Label19)
        Me.Guna2GroupBox2.Controls.Add(Me.Label18)
        Me.Guna2GroupBox2.Controls.Add(Me.Label17)
        Me.Guna2GroupBox2.Controls.Add(Me.Label16)
        Me.Guna2GroupBox2.Controls.Add(Me.Label15)
        Me.Guna2GroupBox2.Controls.Add(Me.Label14)
        Me.Guna2GroupBox2.Controls.Add(Me.Label13)
        Me.Guna2GroupBox2.Controls.Add(Me.Label12)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.btnStartRestore)
        Me.Guna2GroupBox2.Controls.Add(Me.Label4)
        Me.Guna2GroupBox2.Controls.Add(Me.btnBrowseRestore)
        Me.Guna2GroupBox2.Controls.Add(Me.txtRestorePath)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(512, 187)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(464, 472)
        Me.Guna2GroupBox2.TabIndex = 51
        Me.Guna2GroupBox2.Text = "Restore"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(15, 438)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(308, 20)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "automatically after the restore is complete. ."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(15, 418)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(419, 20)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "2. Click the ""Start Restore"" button. The application will close "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(15, 387)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 20)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = ".bak file."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(15, 367)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(416, 20)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "1. Click the ""Browse..."" button and select a previously saved "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(15, 335)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(203, 20)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "will be PERMANENTLY LOST."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(15, 315)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(419, 20)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Any records or changes made since that backup was created"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(12, 283)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(330, 20)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = " it with the data from your selected backup file."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(15, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(440, 20)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Restoring will DELETE all current data in the system and replace"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(465, 20)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "WARNING: THIS IS A DANGEROUS AND IRREVERSIBLE ACTION. "
        '
        'btnStartRestore
        '
        Me.btnStartRestore.Animated = True
        Me.btnStartRestore.AnimationHoverSpeed = 0.07!
        Me.btnStartRestore.AnimationSpeed = 0.03!
        Me.btnStartRestore.BackColor = System.Drawing.Color.Transparent
        Me.btnStartRestore.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnStartRestore.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStartRestore.BorderSize = 3
        Me.btnStartRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartRestore.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStartRestore.FocusedColor = System.Drawing.Color.Empty
        Me.btnStartRestore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartRestore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStartRestore.Image = CType(resources.GetObject("btnStartRestore.Image"), System.Drawing.Image)
        Me.btnStartRestore.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnStartRestore.Location = New System.Drawing.Point(238, 157)
        Me.btnStartRestore.Name = "btnStartRestore"
        Me.btnStartRestore.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStartRestore.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStartRestore.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnStartRestore.OnHoverImage = Nothing
        Me.btnStartRestore.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnStartRestore.Radius = 7
        Me.btnStartRestore.Size = New System.Drawing.Size(184, 38)
        Me.btnStartRestore.TabIndex = 56
        Me.btnStartRestore.Text = "Start Restore"
        Me.btnStartRestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Restore Path"
        '
        'btnBrowseRestore
        '
        Me.btnBrowseRestore.Animated = True
        Me.btnBrowseRestore.AnimationHoverSpeed = 0.07!
        Me.btnBrowseRestore.AnimationSpeed = 0.03!
        Me.btnBrowseRestore.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowseRestore.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnBrowseRestore.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseRestore.BorderSize = 3
        Me.btnBrowseRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowseRestore.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBrowseRestore.FocusedColor = System.Drawing.Color.Empty
        Me.btnBrowseRestore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseRestore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseRestore.Image = CType(resources.GetObject("btnBrowseRestore.Image"), System.Drawing.Image)
        Me.btnBrowseRestore.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnBrowseRestore.Location = New System.Drawing.Point(31, 157)
        Me.btnBrowseRestore.Name = "btnBrowseRestore"
        Me.btnBrowseRestore.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseRestore.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseRestore.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnBrowseRestore.OnHoverImage = Nothing
        Me.btnBrowseRestore.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnBrowseRestore.Radius = 7
        Me.btnBrowseRestore.Size = New System.Drawing.Size(184, 38)
        Me.btnBrowseRestore.TabIndex = 54
        Me.btnBrowseRestore.Text = "Browse"
        Me.btnBrowseRestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRestorePath
        '
        Me.txtRestorePath.BackColor = System.Drawing.Color.Transparent
        Me.txtRestorePath.BaseColor = System.Drawing.Color.White
        Me.txtRestorePath.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtRestorePath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRestorePath.FocusedBaseColor = System.Drawing.Color.White
        Me.txtRestorePath.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtRestorePath.FocusedForeColor = System.Drawing.Color.Black
        Me.txtRestorePath.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestorePath.ForeColor = System.Drawing.Color.Black
        Me.txtRestorePath.Location = New System.Drawing.Point(19, 108)
        Me.txtRestorePath.Name = "txtRestorePath"
        Me.txtRestorePath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRestorePath.Radius = 10
        Me.txtRestorePath.ReadOnly = True
        Me.txtRestorePath.SelectedText = ""
        Me.txtRestorePath.Size = New System.Drawing.Size(420, 33)
        Me.txtRestorePath.TabIndex = 53
        '
        'lblAccessDenied
        '
        Me.lblAccessDenied.AutoSize = True
        Me.lblAccessDenied.BackColor = System.Drawing.Color.Transparent
        Me.lblAccessDenied.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessDenied.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblAccessDenied.Location = New System.Drawing.Point(276, 352)
        Me.lblAccessDenied.Name = "lblAccessDenied"
        Me.lblAccessDenied.Size = New System.Drawing.Size(452, 65)
        Me.lblAccessDenied.TabIndex = 52
        Me.lblAccessDenied.Text = "ACCESS DENIED!!!!"
        Me.lblAccessDenied.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(10, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(313, 37)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "BACKUP AND RESTORE"
        '
        'BackupandRestoreFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 768)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.lblAccessDenied)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BackupandRestoreFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackupandRestoreFrm"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtBackupPath As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnStartBackup As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseBackup As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnStartRestore As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseRestore As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtRestorePath As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblAccessDenied As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
