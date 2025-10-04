<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageForm))
        Me.cboStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboPriority = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvinfo = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnUpdateRecords = New Guna.UI.WinForms.GunaButton()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.Color.Transparent
        Me.cboStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cboStatus.BorderRadius = 7
        Me.cboStatus.BorderThickness = 2
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FocusedColor = System.Drawing.Color.Empty
        Me.cboStatus.FocusedState.Parent = Me.cboStatus
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.HoverState.Parent = Me.cboStatus
        Me.cboStatus.ItemHeight = 30
        Me.cboStatus.ItemsAppearance.Parent = Me.cboStatus
        Me.cboStatus.Location = New System.Drawing.Point(649, 94)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.ShadowDecoration.Depth = 0
        Me.cboStatus.ShadowDecoration.Enabled = True
        Me.cboStatus.ShadowDecoration.Parent = Me.cboStatus
        Me.cboStatus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(30, 30, 30, 3)
        Me.cboStatus.Size = New System.Drawing.Size(156, 36)
        Me.cboStatus.TabIndex = 46
        '
        'cboPriority
        '
        Me.cboPriority.BackColor = System.Drawing.Color.Transparent
        Me.cboPriority.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cboPriority.BorderRadius = 7
        Me.cboPriority.BorderThickness = 2
        Me.cboPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriority.FocusedColor = System.Drawing.Color.Empty
        Me.cboPriority.FocusedState.Parent = Me.cboPriority
        Me.cboPriority.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPriority.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPriority.FormattingEnabled = True
        Me.cboPriority.HoverState.Parent = Me.cboPriority
        Me.cboPriority.ItemHeight = 30
        Me.cboPriority.ItemsAppearance.Parent = Me.cboPriority
        Me.cboPriority.Location = New System.Drawing.Point(821, 94)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.ShadowDecoration.Parent = Me.cboPriority
        Me.cboPriority.Size = New System.Drawing.Size(156, 36)
        Me.cboPriority.TabIndex = 47
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 7
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.dgvinfo)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnUpdateRecords)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(20, 146)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(961, 601)
        Me.Guna2GroupBox1.TabIndex = 49
        Me.Guna2GroupBox1.Text = "Case Details"
        '
        'dgvinfo
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvinfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvinfo.BackgroundColor = System.Drawing.Color.White
        Me.dgvinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvinfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvinfo.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvinfo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvinfo.EnableHeadersVisualStyles = False
        Me.dgvinfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvinfo.Location = New System.Drawing.Point(3, 40)
        Me.dgvinfo.Name = "dgvinfo"
        Me.dgvinfo.RowHeadersVisible = False
        Me.dgvinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvinfo.Size = New System.Drawing.Size(955, 496)
        Me.dgvinfo.TabIndex = 50
        Me.dgvinfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvinfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvinfo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvinfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvinfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvinfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvinfo.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvinfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvinfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvinfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvinfo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvinfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvinfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvinfo.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvinfo.ThemeStyle.ReadOnly = False
        Me.dgvinfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvinfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvinfo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvinfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvinfo.ThemeStyle.RowsStyle.Height = 22
        Me.dgvinfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvinfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BtnUpdateRecords
        '
        Me.BtnUpdateRecords.Animated = True
        Me.BtnUpdateRecords.AnimationHoverSpeed = 0.07!
        Me.BtnUpdateRecords.AnimationSpeed = 0.03!
        Me.BtnUpdateRecords.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpdateRecords.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnUpdateRecords.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdateRecords.BorderSize = 3
        Me.BtnUpdateRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateRecords.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnUpdateRecords.FocusedColor = System.Drawing.Color.Empty
        Me.BtnUpdateRecords.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdateRecords.Image = CType(resources.GetObject("BtnUpdateRecords.Image"), System.Drawing.Image)
        Me.BtnUpdateRecords.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnUpdateRecords.Location = New System.Drawing.Point(757, 542)
        Me.BtnUpdateRecords.Name = "BtnUpdateRecords"
        Me.BtnUpdateRecords.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdateRecords.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUpdateRecords.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnUpdateRecords.OnHoverImage = Nothing
        Me.BtnUpdateRecords.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnUpdateRecords.Radius = 7
        Me.BtnUpdateRecords.Size = New System.Drawing.Size(184, 38)
        Me.BtnUpdateRecords.TabIndex = 49
        Me.BtnUpdateRecords.Text = "Update Records"
        Me.BtnUpdateRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSearch.BorderRadius = 7
        Me.txtSearch.BorderThickness = 3
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = Global.LoginForm.My.Resources.Resources.search
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(10, 0)
        Me.txtSearch.Location = New System.Drawing.Point(16, 90)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Filter by Casenumber"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(616, 40)
        Me.txtSearch.TabIndex = 44
        Me.txtSearch.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 37)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "MANAGE RECORDS"
        '
        'ManageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 768)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboPriority)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageForm"
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.dgvinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cboStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboPriority As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BtnUpdateRecords As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvinfo As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
