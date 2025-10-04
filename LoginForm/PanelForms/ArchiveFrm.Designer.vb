<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArchiveFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArchiveFrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnDeleteRecord = New Guna.UI.WinForms.GunaButton()
        Me.btnClearFilters = New Guna.UI.WinForms.GunaButton()
        Me.dgvArchivedCases = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnReopenCase = New Guna.UI.WinForms.GunaButton()
        Me.txtArchiveSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgvArchivedCases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 7
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.btnDeleteRecord)
        Me.Guna2GroupBox1.Controls.Add(Me.btnClearFilters)
        Me.Guna2GroupBox1.Controls.Add(Me.dgvArchivedCases)
        Me.Guna2GroupBox1.Controls.Add(Me.btnReopenCase)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 163)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(974, 593)
        Me.Guna2GroupBox1.TabIndex = 50
        Me.Guna2GroupBox1.Text = "Case Details"
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Animated = True
        Me.btnDeleteRecord.AnimationHoverSpeed = 0.07!
        Me.btnDeleteRecord.AnimationSpeed = 0.03!
        Me.btnDeleteRecord.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteRecord.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDeleteRecord.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteRecord.BorderSize = 3
        Me.btnDeleteRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteRecord.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteRecord.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteRecord.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteRecord.Image = CType(resources.GetObject("btnDeleteRecord.Image"), System.Drawing.Image)
        Me.btnDeleteRecord.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnDeleteRecord.Location = New System.Drawing.Point(594, 546)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteRecord.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteRecord.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDeleteRecord.OnHoverImage = Nothing
        Me.btnDeleteRecord.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeleteRecord.Radius = 7
        Me.btnDeleteRecord.Size = New System.Drawing.Size(184, 38)
        Me.btnDeleteRecord.TabIndex = 65
        Me.btnDeleteRecord.Text = "Remove"
        Me.btnDeleteRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnClearFilters.Location = New System.Drawing.Point(404, 546)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFilters.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClearFilters.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnClearFilters.OnHoverImage = Nothing
        Me.btnClearFilters.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClearFilters.Radius = 7
        Me.btnClearFilters.Size = New System.Drawing.Size(184, 38)
        Me.btnClearFilters.TabIndex = 64
        Me.btnClearFilters.Text = "Clear"
        Me.btnClearFilters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvArchivedCases
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvArchivedCases.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArchivedCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArchivedCases.BackgroundColor = System.Drawing.Color.White
        Me.dgvArchivedCases.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvArchivedCases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvArchivedCases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArchivedCases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvArchivedCases.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArchivedCases.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvArchivedCases.EnableHeadersVisualStyles = False
        Me.dgvArchivedCases.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvArchivedCases.Location = New System.Drawing.Point(3, 44)
        Me.dgvArchivedCases.Name = "dgvArchivedCases"
        Me.dgvArchivedCases.RowHeadersVisible = False
        Me.dgvArchivedCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArchivedCases.Size = New System.Drawing.Size(968, 496)
        Me.dgvArchivedCases.TabIndex = 50
        Me.dgvArchivedCases.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvArchivedCases.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvArchivedCases.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvArchivedCases.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvArchivedCases.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvArchivedCases.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvArchivedCases.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvArchivedCases.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvArchivedCases.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvArchivedCases.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvArchivedCases.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvArchivedCases.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvArchivedCases.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvArchivedCases.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvArchivedCases.ThemeStyle.ReadOnly = False
        Me.dgvArchivedCases.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvArchivedCases.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvArchivedCases.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvArchivedCases.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvArchivedCases.ThemeStyle.RowsStyle.Height = 22
        Me.dgvArchivedCases.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvArchivedCases.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnReopenCase
        '
        Me.btnReopenCase.Animated = True
        Me.btnReopenCase.AnimationHoverSpeed = 0.07!
        Me.btnReopenCase.AnimationSpeed = 0.03!
        Me.btnReopenCase.BackColor = System.Drawing.Color.Transparent
        Me.btnReopenCase.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnReopenCase.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnReopenCase.BorderSize = 3
        Me.btnReopenCase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReopenCase.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReopenCase.FocusedColor = System.Drawing.Color.Empty
        Me.btnReopenCase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReopenCase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnReopenCase.Image = CType(resources.GetObject("btnReopenCase.Image"), System.Drawing.Image)
        Me.btnReopenCase.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnReopenCase.Location = New System.Drawing.Point(784, 546)
        Me.btnReopenCase.Name = "btnReopenCase"
        Me.btnReopenCase.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnReopenCase.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnReopenCase.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnReopenCase.OnHoverImage = Nothing
        Me.btnReopenCase.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnReopenCase.Radius = 7
        Me.btnReopenCase.Size = New System.Drawing.Size(162, 38)
        Me.btnReopenCase.TabIndex = 49
        Me.btnReopenCase.Text = "Re-Open Case"
        Me.btnReopenCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtArchiveSearch
        '
        Me.txtArchiveSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtArchiveSearch.BorderRadius = 7
        Me.txtArchiveSearch.BorderThickness = 3
        Me.txtArchiveSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtArchiveSearch.DefaultText = ""
        Me.txtArchiveSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtArchiveSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtArchiveSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtArchiveSearch.DisabledState.Parent = Me.txtArchiveSearch
        Me.txtArchiveSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtArchiveSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArchiveSearch.FocusedState.Parent = Me.txtArchiveSearch
        Me.txtArchiveSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArchiveSearch.HoverState.Parent = Me.txtArchiveSearch
        Me.txtArchiveSearch.IconLeft = Global.LoginForm.My.Resources.Resources.search
        Me.txtArchiveSearch.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtArchiveSearch.Location = New System.Drawing.Point(12, 93)
        Me.txtArchiveSearch.Name = "txtArchiveSearch"
        Me.txtArchiveSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtArchiveSearch.PlaceholderText = "Filter by Casenumber"
        Me.txtArchiveSearch.SelectedText = ""
        Me.txtArchiveSearch.ShadowDecoration.Parent = Me.txtArchiveSearch
        Me.txtArchiveSearch.Size = New System.Drawing.Size(557, 40)
        Me.txtArchiveSearch.TabIndex = 51
        Me.txtArchiveSearch.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(580, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Date Range"
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
        Me.dtpEndDate.Location = New System.Drawing.Point(782, 93)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShadowDecoration.Parent = Me.dtpEndDate
        Me.dtpEndDate.Size = New System.Drawing.Size(201, 40)
        Me.dtpEndDate.TabIndex = 66
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
        Me.dtpStartDate.Location = New System.Drawing.Point(575, 93)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShadowDecoration.Parent = Me.dtpStartDate
        Me.dtpStartDate.Size = New System.Drawing.Size(201, 40)
        Me.dtpStartDate.TabIndex = 65
        Me.dtpStartDate.Value = New Date(2025, 8, 26, 21, 32, 20, 638)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 37)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ARCHIVE RECORDS"
        '
        'ArchiveFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 768)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.txtArchiveSearch)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ArchiveFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArchiveFrm"
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.dgvArchivedCases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvArchivedCases As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnReopenCase As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtArchiveSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnClearFilters As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDeleteRecord As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
