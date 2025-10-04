<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLogsFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivityLogsFrm))
        Me.dgvActivityLogs = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExport = New Guna.UI.WinForms.GunaButton()
        Me.btnClearFilters = New Guna.UI.WinForms.GunaButton()
        Me.lblCaseNumber = New System.Windows.Forms.Label()
        Me.cboUserFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtLogSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvActivityLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvActivityLogs
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvActivityLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvActivityLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActivityLogs.BackgroundColor = System.Drawing.Color.White
        Me.dgvActivityLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvActivityLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvActivityLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivityLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvActivityLogs.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActivityLogs.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvActivityLogs.EnableHeadersVisualStyles = False
        Me.dgvActivityLogs.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivityLogs.Location = New System.Drawing.Point(20, 163)
        Me.dgvActivityLogs.Name = "dgvActivityLogs"
        Me.dgvActivityLogs.RowHeadersVisible = False
        Me.dgvActivityLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivityLogs.Size = New System.Drawing.Size(924, 483)
        Me.dgvActivityLogs.TabIndex = 51
        Me.dgvActivityLogs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvActivityLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvActivityLogs.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvActivityLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvActivityLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvActivityLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvActivityLogs.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvActivityLogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivityLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivityLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvActivityLogs.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvActivityLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvActivityLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvActivityLogs.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvActivityLogs.ThemeStyle.ReadOnly = False
        Me.dgvActivityLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvActivityLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvActivityLogs.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvActivityLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvActivityLogs.ThemeStyle.RowsStyle.Height = 22
        Me.dgvActivityLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivityLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaLabel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaLabel6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(925, 11)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(33, 32)
        Me.GunaLabel6.TabIndex = 57
        Me.GunaLabel6.Text = "X"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.dgvActivityLogs)
        Me.Guna2Panel1.Controls.Add(Me.btnExport)
        Me.Guna2Panel1.Controls.Add(Me.btnClearFilters)
        Me.Guna2Panel1.Controls.Add(Me.lblCaseNumber)
        Me.Guna2Panel1.Controls.Add(Me.cboUserFilter)
        Me.Guna2Panel1.Controls.Add(Me.dtpEndDate)
        Me.Guna2Panel1.Controls.Add(Me.dtpStartDate)
        Me.Guna2Panel1.Controls.Add(Me.txtLogSearch)
        Me.Guna2Panel1.Controls.Add(Me.GunaLabel6)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(971, 711)
        Me.Guna2Panel1.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(546, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Date Range"
        '
        'btnExport
        '
        Me.btnExport.Animated = True
        Me.btnExport.AnimationHoverSpeed = 0.07!
        Me.btnExport.AnimationSpeed = 0.03!
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnExport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnExport.BorderSize = 3
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExport.FocusedColor = System.Drawing.Color.Empty
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnExport.Location = New System.Drawing.Point(773, 661)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnExport.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnExport.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnExport.OnHoverImage = Nothing
        Me.btnExport.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnExport.Radius = 7
        Me.btnExport.Size = New System.Drawing.Size(184, 38)
        Me.btnExport.TabIndex = 62
        Me.btnExport.Text = "Export"
        Me.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Animated = True
        Me.btnClearFilters.AnimationHoverSpeed = 0.07!
        Me.btnClearFilters.AnimationSpeed = 0.03!
        Me.btnClearFilters.BackColor = System.Drawing.Color.Transparent
        Me.btnClearFilters.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnClearFilters.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFilters.BorderSize = 3
        Me.btnClearFilters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearFilters.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClearFilters.FocusedColor = System.Drawing.Color.Empty
        Me.btnClearFilters.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFilters.Image = CType(resources.GetObject("btnClearFilters.Image"), System.Drawing.Image)
        Me.btnClearFilters.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnClearFilters.Location = New System.Drawing.Point(583, 661)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFilters.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFilters.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnClearFilters.OnHoverImage = Nothing
        Me.btnClearFilters.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClearFilters.Radius = 7
        Me.btnClearFilters.Size = New System.Drawing.Size(184, 38)
        Me.btnClearFilters.TabIndex = 63
        Me.btnClearFilters.Text = "Clear"
        Me.btnClearFilters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCaseNumber
        '
        Me.lblCaseNumber.AutoSize = True
        Me.lblCaseNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblCaseNumber.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblCaseNumber.Location = New System.Drawing.Point(12, 11)
        Me.lblCaseNumber.Name = "lblCaseNumber"
        Me.lblCaseNumber.Size = New System.Drawing.Size(213, 45)
        Me.lblCaseNumber.TabIndex = 52
        Me.lblCaseNumber.Text = "Activity Logs"
        '
        'cboUserFilter
        '
        Me.cboUserFilter.BackColor = System.Drawing.Color.Transparent
        Me.cboUserFilter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cboUserFilter.BorderRadius = 7
        Me.cboUserFilter.BorderThickness = 3
        Me.cboUserFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboUserFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cboUserFilter.FocusedState.Parent = Me.cboUserFilter
        Me.cboUserFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboUserFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboUserFilter.FormattingEnabled = True
        Me.cboUserFilter.HoverState.Parent = Me.cboUserFilter
        Me.cboUserFilter.ItemHeight = 30
        Me.cboUserFilter.ItemsAppearance.Parent = Me.cboUserFilter
        Me.cboUserFilter.Location = New System.Drawing.Point(364, 107)
        Me.cboUserFilter.Name = "cboUserFilter"
        Me.cboUserFilter.ShadowDecoration.Parent = Me.cboUserFilter
        Me.cboUserFilter.Size = New System.Drawing.Size(171, 36)
        Me.cboUserFilter.TabIndex = 61
        '
        'dtpEndDate
        '
        Me.dtpEndDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dtpEndDate.BorderRadius = 7
        Me.dtpEndDate.BorderThickness = 2
        Me.dtpEndDate.CheckedState.Parent = Me.dtpEndDate
        Me.dtpEndDate.FillColor = System.Drawing.Color.White
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.ForeColor = System.Drawing.Color.Black
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpEndDate.HoverState.Parent = Me.dtpEndDate
        Me.dtpEndDate.Location = New System.Drawing.Point(748, 107)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShadowDecoration.Parent = Me.dtpEndDate
        Me.dtpEndDate.Size = New System.Drawing.Size(201, 36)
        Me.dtpEndDate.TabIndex = 60
        Me.dtpEndDate.Value = New Date(2025, 8, 26, 21, 32, 20, 638)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dtpStartDate.BorderRadius = 7
        Me.dtpStartDate.BorderThickness = 2
        Me.dtpStartDate.CheckedState.Parent = Me.dtpStartDate
        Me.dtpStartDate.FillColor = System.Drawing.Color.White
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.ForeColor = System.Drawing.Color.Black
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpStartDate.HoverState.Parent = Me.dtpStartDate
        Me.dtpStartDate.Location = New System.Drawing.Point(541, 107)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShadowDecoration.Parent = Me.dtpStartDate
        Me.dtpStartDate.Size = New System.Drawing.Size(201, 36)
        Me.dtpStartDate.TabIndex = 59
        Me.dtpStartDate.Value = New Date(2025, 8, 26, 21, 32, 20, 638)
        '
        'txtLogSearch
        '
        Me.txtLogSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtLogSearch.BorderRadius = 7
        Me.txtLogSearch.BorderThickness = 3
        Me.txtLogSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLogSearch.DefaultText = ""
        Me.txtLogSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLogSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLogSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLogSearch.DisabledState.Parent = Me.txtLogSearch
        Me.txtLogSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLogSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogSearch.FocusedState.Parent = Me.txtLogSearch
        Me.txtLogSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogSearch.HoverState.Parent = Me.txtLogSearch
        Me.txtLogSearch.IconLeft = Global.LoginForm.My.Resources.Resources.search
        Me.txtLogSearch.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtLogSearch.Location = New System.Drawing.Point(20, 107)
        Me.txtLogSearch.Name = "txtLogSearch"
        Me.txtLogSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLogSearch.PlaceholderText = "Filter by Casenumber"
        Me.txtLogSearch.SelectedText = ""
        Me.txtLogSearch.ShadowDecoration.Parent = Me.txtLogSearch
        Me.txtLogSearch.Size = New System.Drawing.Size(338, 36)
        Me.txtLogSearch.TabIndex = 58
        Me.txtLogSearch.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(364, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "User Filter"
        '
        'ActivityLogsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 709)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActivityLogsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActivityLogsFrm"
        CType(Me.dgvActivityLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvActivityLogs As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCaseNumber As System.Windows.Forms.Label
    Friend WithEvents txtLogSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cboUserFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnExport As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClearFilters As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
