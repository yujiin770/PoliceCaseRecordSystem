<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Animation5 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation4 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim Animation6 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation3 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblTotalCases = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblActiveCases = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ResolvedCases = New System.Windows.Forms.Label()
        Me.lblResolvedCases = New System.Windows.Forms.Label()
        Me.chartCaseTypes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvRecentCases = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.lblWelcomeUser = New System.Windows.Forms.Label()
        Me.GunaTransition2 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaTransition3 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaTransition4 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaTransition5 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaTransition6 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartCaseTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecentCases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 47)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "DASHBOARD"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaTransition3.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(734, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 39)
        Me.Label1.TabIndex = 38
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.LblTotalCases)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.GunaTransition3.SetDecoration(Me.Guna2Panel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Guna2Panel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Guna2Panel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Guna2Panel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Guna2Panel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Guna2Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(33, 123)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(281, 162)
        Me.Guna2Panel1.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition4.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition3.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = Global.LoginForm.My.Resources.Resources.cases
        Me.PictureBox1.Location = New System.Drawing.Point(29, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'LblTotalCases
        '
        Me.LblTotalCases.AutoSize = True
        Me.LblTotalCases.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.LblTotalCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.LblTotalCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.LblTotalCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.LblTotalCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.LblTotalCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.LblTotalCases, Guna.UI.Animation.DecorationType.None)
        Me.LblTotalCases.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalCases.ForeColor = System.Drawing.Color.Black
        Me.LblTotalCases.Location = New System.Drawing.Point(109, 78)
        Me.LblTotalCases.Name = "LblTotalCases"
        Me.LblTotalCases.Size = New System.Drawing.Size(73, 30)
        Me.LblTotalCases.TabIndex = 39
        Me.LblTotalCases.Text = "1, 247"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 37)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Total Cases"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.BorderThickness = 3
        Me.Guna2Panel2.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.LblActiveCases)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.GunaTransition3.SetDecoration(Me.Guna2Panel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Guna2Panel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Guna2Panel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Guna2Panel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Guna2Panel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Guna2Panel2, Guna.UI.Animation.DecorationType.None)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(358, 123)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(281, 162)
        Me.Guna2Panel2.TabIndex = 42
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition4.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition3.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox2.Image = Global.LoginForm.My.Resources.Resources.activities
        Me.PictureBox2.Location = New System.Drawing.Point(20, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'LblActiveCases
        '
        Me.LblActiveCases.AutoSize = True
        Me.LblActiveCases.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.LblActiveCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.LblActiveCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.LblActiveCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.LblActiveCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.LblActiveCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.LblActiveCases, Guna.UI.Animation.DecorationType.None)
        Me.LblActiveCases.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActiveCases.ForeColor = System.Drawing.Color.Black
        Me.LblActiveCases.Location = New System.Drawing.Point(123, 78)
        Me.LblActiveCases.Name = "LblActiveCases"
        Me.LblActiveCases.Size = New System.Drawing.Size(37, 30)
        Me.LblActiveCases.TabIndex = 40
        Me.LblActiveCases.Text = "89"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Label4, Guna.UI.Animation.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 37)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Active Cases"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.BorderThickness = 3
        Me.Guna2Panel3.Controls.Add(Me.PictureBox3)
        Me.Guna2Panel3.Controls.Add(Me.ResolvedCases)
        Me.Guna2Panel3.Controls.Add(Me.lblResolvedCases)
        Me.GunaTransition3.SetDecoration(Me.Guna2Panel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Guna2Panel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Guna2Panel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Guna2Panel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Guna2Panel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Guna2Panel3, Guna.UI.Animation.DecorationType.None)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(676, 123)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(281, 162)
        Me.Guna2Panel3.TabIndex = 40
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition4.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition3.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox3.Image = Global.LoginForm.My.Resources.Resources.resolved
        Me.PictureBox3.Location = New System.Drawing.Point(20, 59)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'ResolvedCases
        '
        Me.ResolvedCases.AutoSize = True
        Me.ResolvedCases.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.ResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.ResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.ResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.ResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.ResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.ResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.ResolvedCases.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResolvedCases.ForeColor = System.Drawing.Color.Black
        Me.ResolvedCases.Location = New System.Drawing.Point(107, 78)
        Me.ResolvedCases.Name = "ResolvedCases"
        Me.ResolvedCases.Size = New System.Drawing.Size(67, 30)
        Me.ResolvedCases.TabIndex = 40
        Me.ResolvedCases.Text = "1,159"
        '
        'lblResolvedCases
        '
        Me.lblResolvedCases.AutoSize = True
        Me.lblResolvedCases.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.lblResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.lblResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.lblResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.lblResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.lblResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.lblResolvedCases, Guna.UI.Animation.DecorationType.None)
        Me.lblResolvedCases.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolvedCases.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblResolvedCases.Location = New System.Drawing.Point(15, 11)
        Me.lblResolvedCases.Name = "lblResolvedCases"
        Me.lblResolvedCases.Size = New System.Drawing.Size(159, 30)
        Me.lblResolvedCases.TabIndex = 38
        Me.lblResolvedCases.Text = "Resolved Cases"
        '
        'chartCaseTypes
        '
        Me.chartCaseTypes.BackImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chartCaseTypes.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.chartCaseTypes.ChartAreas.Add(ChartArea1)
        Me.GunaTransition5.SetDecoration(Me.chartCaseTypes, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.chartCaseTypes, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition3.SetDecoration(Me.chartCaseTypes, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.chartCaseTypes, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.chartCaseTypes, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.chartCaseTypes, Guna.UI.Animation.DecorationType.None)
        Legend1.Name = "Legend1"
        Me.chartCaseTypes.Legends.Add(Legend1)
        Me.chartCaseTypes.Location = New System.Drawing.Point(3, 42)
        Me.chartCaseTypes.Name = "chartCaseTypes"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartCaseTypes.Series.Add(Series1)
        Me.chartCaseTypes.Size = New System.Drawing.Size(475, 345)
        Me.chartCaseTypes.TabIndex = 46
        Me.chartCaseTypes.Text = "Chart1"
        '
        'dgvRecentCases
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvRecentCases.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRecentCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentCases.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecentCases.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecentCases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecentCases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentCases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRecentCases.ColumnHeadersHeight = 4
        Me.GunaTransition2.SetDecoration(Me.dgvRecentCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition3.SetDecoration(Me.dgvRecentCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.dgvRecentCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.dgvRecentCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.dgvRecentCases, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.dgvRecentCases, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecentCases.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRecentCases.EnableHeadersVisualStyles = False
        Me.dgvRecentCases.GridColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvRecentCases.Location = New System.Drawing.Point(3, 42)
        Me.dgvRecentCases.Name = "dgvRecentCases"
        Me.dgvRecentCases.RowHeadersVisible = False
        Me.dgvRecentCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecentCases.Size = New System.Drawing.Size(387, 345)
        Me.dgvRecentCases.TabIndex = 47
        Me.dgvRecentCases.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvRecentCases.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecentCases.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRecentCases.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRecentCases.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRecentCases.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRecentCases.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecentCases.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgvRecentCases.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecentCases.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecentCases.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecentCases.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRecentCases.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRecentCases.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvRecentCases.ThemeStyle.ReadOnly = False
        Me.dgvRecentCases.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecentCases.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecentCases.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecentCases.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRecentCases.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRecentCases.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecentCases.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel4.BorderRadius = 15
        Me.Guna2Panel4.BorderThickness = 3
        Me.Guna2Panel4.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2Panel4.Controls.Add(Me.Guna2GroupBox2)
        Me.GunaTransition3.SetDecoration(Me.Guna2Panel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Guna2Panel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Guna2Panel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Guna2Panel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Guna2Panel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Guna2Panel4, Guna.UI.Animation.DecorationType.None)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(33, 311)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(924, 434)
        Me.Guna2Panel4.TabIndex = 48
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 7
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.dgvRecentCases)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaTransition6.SetDecoration(Me.Guna2GroupBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Guna2GroupBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Guna2GroupBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Guna2GroupBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Guna2GroupBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition3.SetDecoration(Me.Guna2GroupBox1, Guna.UI.Animation.DecorationType.None)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(15, 22)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(393, 390)
        Me.Guna2GroupBox1.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Label5, Guna.UI.Animation.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 30)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Recently Added"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox2.BorderRadius = 7
        Me.Guna2GroupBox2.Controls.Add(Me.chartCaseTypes)
        Me.Guna2GroupBox2.Controls.Add(Me.Label6)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaTransition6.SetDecoration(Me.Guna2GroupBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Guna2GroupBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Guna2GroupBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Guna2GroupBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Guna2GroupBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition3.SetDecoration(Me.Guna2GroupBox2, Guna.UI.Animation.DecorationType.None)
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(414, 22)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(481, 390)
        Me.Guna2GroupBox2.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition3.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.Label6, Guna.UI.Animation.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 30)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Case Breakdown by Type"
        '
        'Timer1
        '
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton1.BorderSize = 3
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition3.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(0, 0)
        Me.GunaButton1.Location = New System.Drawing.Point(741, 56)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaButton1.Radius = 5
        Me.GunaButton1.Size = New System.Drawing.Size(215, 47)
        Me.GunaButton1.TabIndex = 44
        Me.GunaButton1.Text = "Add Records"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransition1.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0.0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0.0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 0
        Animation5.Padding = New System.Windows.Forms.Padding(0)
        Animation5.RotateCoeff = 0.0!
        Animation5.RotateLimit = 0.0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0.0!
        Animation5.TransparencyCoeff = 0.0!
        Me.GunaTransition1.DefaultAnimation = Animation5
        '
        'lblWelcomeUser
        '
        Me.lblWelcomeUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaTransition3.SetDecoration(Me.lblWelcomeUser, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me.lblWelcomeUser, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me.lblWelcomeUser, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.lblWelcomeUser, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.lblWelcomeUser, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me.lblWelcomeUser, Guna.UI.Animation.DecorationType.None)
        Me.lblWelcomeUser.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblWelcomeUser.Location = New System.Drawing.Point(32, 64)
        Me.lblWelcomeUser.Name = "lblWelcomeUser"
        Me.lblWelcomeUser.Size = New System.Drawing.Size(282, 39)
        Me.lblWelcomeUser.TabIndex = 49
        '
        'GunaTransition2
        '
        Me.GunaTransition2.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransition2.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0.0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0.0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0.0!
        Animation4.RotateLimit = 0.0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0.0!
        Animation4.TransparencyCoeff = 0.0!
        Me.GunaTransition2.DefaultAnimation = Animation4
        '
        'GunaTransition3
        '
        Me.GunaTransition3.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransition3.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.GunaTransition3.DefaultAnimation = Animation1
        '
        'GunaTransition4
        '
        Me.GunaTransition4.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransition4.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0.0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0.0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0.0!
        Animation6.RotateLimit = 0.0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0.0!
        Animation6.TransparencyCoeff = 0.0!
        Me.GunaTransition4.DefaultAnimation = Animation6
        '
        'GunaTransition5
        '
        Me.GunaTransition5.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransition5.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0.0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0.0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0.0!
        Animation3.RotateLimit = 0.0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0.0!
        Animation3.TransparencyCoeff = 0.0!
        Me.GunaTransition5.DefaultAnimation = Animation3
        '
        'GunaTransition6
        '
        Me.GunaTransition6.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.GunaTransition6.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 0.0!
        Me.GunaTransition6.DefaultAnimation = Animation2
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1146, 768)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcomeUser)
        Me.GunaTransition3.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition4.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition5.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition6.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartCaseTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecentCases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTotalCases As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblActiveCases As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ResolvedCases As System.Windows.Forms.Label
    Friend WithEvents lblResolvedCases As System.Windows.Forms.Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents chartCaseTypes As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents dgvRecentCases As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaTransition3 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaTransition6 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaTransition5 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaTransition2 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaTransition4 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents lblWelcomeUser As System.Windows.Forms.Label
End Class
