<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttachmentsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttachmentsForm))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvAttachments = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Evidence = New System.Windows.Forms.Label()
        Me.lblCaseNumber = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.btnRemoveFile = New Guna.UI.WinForms.GunaButton()
        Me.btnSaveFile = New Guna.UI.WinForms.GunaButton()
        Me.btnAddFile = New Guna.UI.WinForms.GunaButton()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgvAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 7
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.dgvAttachments)
        Me.Guna2GroupBox1.Controls.Add(Me.Evidence)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(953, 574)
        Me.Guna2GroupBox1.TabIndex = 51
        '
        'dgvAttachments
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAttachments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAttachments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAttachments.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttachments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAttachments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAttachments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAttachments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAttachments.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAttachments.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAttachments.EnableHeadersVisualStyles = False
        Me.dgvAttachments.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAttachments.Location = New System.Drawing.Point(10, 57)
        Me.dgvAttachments.Name = "dgvAttachments"
        Me.dgvAttachments.RowHeadersVisible = False
        Me.dgvAttachments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAttachments.Size = New System.Drawing.Size(918, 498)
        Me.dgvAttachments.TabIndex = 50
        Me.dgvAttachments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvAttachments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttachments.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvAttachments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvAttachments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvAttachments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvAttachments.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttachments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAttachments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAttachments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAttachments.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAttachments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAttachments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAttachments.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvAttachments.ThemeStyle.ReadOnly = False
        Me.dgvAttachments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvAttachments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAttachments.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAttachments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAttachments.ThemeStyle.RowsStyle.Height = 22
        Me.dgvAttachments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvAttachments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Evidence
        '
        Me.Evidence.AutoSize = True
        Me.Evidence.BackColor = System.Drawing.Color.Transparent
        Me.Evidence.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Evidence.ForeColor = System.Drawing.Color.White
        Me.Evidence.Location = New System.Drawing.Point(5, 2)
        Me.Evidence.Name = "Evidence"
        Me.Evidence.Size = New System.Drawing.Size(111, 30)
        Me.Evidence.TabIndex = 55
        Me.Evidence.Text = "View Case"
        '
        'lblCaseNumber
        '
        Me.lblCaseNumber.AutoSize = True
        Me.lblCaseNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblCaseNumber.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaseNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblCaseNumber.Location = New System.Drawing.Point(10, 8)
        Me.lblCaseNumber.Name = "lblCaseNumber"
        Me.lblCaseNumber.Size = New System.Drawing.Size(151, 45)
        Me.lblCaseNumber.TabIndex = 51
        Me.lblCaseNumber.Text = "Evidence"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.lblCaseNumber)
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(985, 745)
        Me.Guna2Panel1.TabIndex = 59
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton2.BorderSize = 3
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(0, 0)
        Me.GunaButton2.Location = New System.Drawing.Point(12, 698)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton2.Radius = 7
        Me.GunaButton2.Size = New System.Drawing.Size(150, 38)
        Me.GunaButton2.TabIndex = 58
        Me.GunaButton2.Text = "Back"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRemoveFile
        '
        Me.btnRemoveFile.Animated = True
        Me.btnRemoveFile.AnimationHoverSpeed = 0.07!
        Me.btnRemoveFile.AnimationSpeed = 0.03!
        Me.btnRemoveFile.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveFile.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnRemoveFile.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRemoveFile.BorderSize = 3
        Me.btnRemoveFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveFile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRemoveFile.FocusedColor = System.Drawing.Color.Empty
        Me.btnRemoveFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRemoveFile.Image = CType(resources.GetObject("btnRemoveFile.Image"), System.Drawing.Image)
        Me.btnRemoveFile.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnRemoveFile.Location = New System.Drawing.Point(482, 698)
        Me.btnRemoveFile.Name = "btnRemoveFile"
        Me.btnRemoveFile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRemoveFile.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRemoveFile.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnRemoveFile.OnHoverImage = Nothing
        Me.btnRemoveFile.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRemoveFile.Radius = 7
        Me.btnRemoveFile.Size = New System.Drawing.Size(150, 38)
        Me.btnRemoveFile.TabIndex = 57
        Me.btnRemoveFile.Text = "Remove File"
        Me.btnRemoveFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Animated = True
        Me.btnSaveFile.AnimationHoverSpeed = 0.07!
        Me.btnSaveFile.AnimationSpeed = 0.03!
        Me.btnSaveFile.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveFile.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSaveFile.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveFile.BorderSize = 3
        Me.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSaveFile.FocusedColor = System.Drawing.Color.Empty
        Me.btnSaveFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveFile.Image = CType(resources.GetObject("btnSaveFile.Image"), System.Drawing.Image)
        Me.btnSaveFile.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnSaveFile.Location = New System.Drawing.Point(649, 698)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveFile.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveFile.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnSaveFile.OnHoverImage = Nothing
        Me.btnSaveFile.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSaveFile.Radius = 7
        Me.btnSaveFile.Size = New System.Drawing.Size(150, 38)
        Me.btnSaveFile.TabIndex = 56
        Me.btnSaveFile.Text = "Save Select File"
        Me.btnSaveFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddFile
        '
        Me.btnAddFile.Animated = True
        Me.btnAddFile.AnimationHoverSpeed = 0.07!
        Me.btnAddFile.AnimationSpeed = 0.03!
        Me.btnAddFile.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFile.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnAddFile.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAddFile.BorderSize = 3
        Me.btnAddFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddFile.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAddFile.Image = CType(resources.GetObject("btnAddFile.Image"), System.Drawing.Image)
        Me.btnAddFile.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnAddFile.Location = New System.Drawing.Point(815, 698)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAddFile.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAddFile.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnAddFile.OnHoverImage = Nothing
        Me.btnAddFile.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAddFile.Radius = 7
        Me.btnAddFile.Size = New System.Drawing.Size(150, 38)
        Me.btnAddFile.TabIndex = 49
        Me.btnAddFile.Text = "Add New File"
        Me.btnAddFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AttachmentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 748)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.btnRemoveFile)
        Me.Controls.Add(Me.btnSaveFile)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.btnAddFile)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttachmentsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttachmentsForm"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.dgvAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvAttachments As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnAddFile As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSaveFile As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnRemoveFile As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblCaseNumber As System.Windows.Forms.Label
    Friend WithEvents Evidence As System.Windows.Forms.Label
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
