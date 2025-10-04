Public Class Dashboard

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        ' --- ADD THIS CODE AT THE TOP ---
        ' Check if the SESSION variable exists and contains user data.
        If SESSION IsNot Nothing Then
            ' Get the username and role from the session.
            Dim username As String = SESSION("Username").ToString()
            Dim userRole As String = SESSION("Role").ToString()

            ' Set the text of your new label.
            lblWelcomeUser.Text = "Welcome, " & username & " (" & userRole & ")"
        Else
            ' Failsafe in case the dashboard is loaded without a logged-in user.
            lblWelcomeUser.Text = "Welcome, Guest"
        End If
        ' --- END OF NEW CODE ---

        ' When the dashboard loads, update everything.
        ' We wrap this in a Try...Catch block to handle any potential database errors gracefully.
        Try
            LoadDashboardStats()
            LoadCaseTypeChart()
            LoadRecentCases()
        Catch ex As Exception
            MsgBox("Failed to load all dashboard components. Error: " & ex.Message, MsgBoxStyle.Critical, "Dashboard Error")
        End Try

        Timer1.Interval = 1000 ' 1 second
        Timer1.Start()

        ' --- ADD THIS SECURITY CHECK FOR NAVIGATION ---
        If SESSION IsNot Nothing AndAlso SESSION("Role").ToString() <> "Admin" Then
            ' Assuming you have buttons named like this, hide them for non-admins.
            ' btnManageRecords.Visible = False ' Hides the button entirely
            ' btnArchiveRecords.Visible = False

        End If
    End Sub

#Region "Data Loading Subroutines"

    ' This is your existing subroutine for the statistic labels.
    Sub LoadDashboardStats()
        LblTotalCases.Text = GetTotalCaseCount().ToString()
        LblActiveCases.Text = GetActiveCaseCount().ToString()
        ResolvedCases.Text = GetResolvedCaseCount().ToString()
    End Sub

    ' --- NEW SUBROUTINE to populate the pie chart ---
    Sub LoadCaseTypeChart()
        ' Get the data from the utility function.
        Dim chartData As DataTable = GetCaseTypeBreakdown()

        ' --- Step 1: Clear EVERYTHING to ensure a clean slate ---
        chartCaseTypes.Series.Clear()
        chartCaseTypes.ChartAreas.Clear()
        chartCaseTypes.Titles.Clear()
        chartCaseTypes.Legends.Clear() ' Also clear legends for a fresh start

        ' Check if we actually got any data to display.
        If chartData.Rows.Count = 0 Then
            chartCaseTypes.Titles.Add("No case data available to display.")
            Return
        End If

        ' --- Step 2: Manually create and configure our ChartArea ---
        ' We create it first and give it a name we can rely on.
        Dim chartArea As New System.Windows.Forms.DataVisualization.Charting.ChartArea("MyChartArea")
        chartArea.Area3DStyle.Enable3D = True ' Make it 3D
        chartCaseTypes.ChartAreas.Add(chartArea)

        ' --- Step 3: Manually create and configure our Series ---
        Dim series As New System.Windows.Forms.DataVisualization.Charting.Series("CaseTypes")
        series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        series.XValueMember = "CaseType"
        series.YValueMembers = "CaseCount"
        series.IsValueShownAsLabel = True ' Show numbers on the slices
        series.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        series.LabelForeColor = Color.White
        chartCaseTypes.Series.Add(series)

        ' --- Step 4: Add a Title and Legend ---
        chartCaseTypes.Titles.Add("")
        chartCaseTypes.Titles(0).Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Dim legend As New System.Windows.Forms.DataVisualization.Charting.Legend("MyLegend")
        legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right
        chartCaseTypes.Legends.Add(legend)
        series.Legend = "MyLegend" ' Link the series to our new legend

        ' --- Step 5: NOW, bind the data ---
        ' By binding last, the chart uses our pre-configured objects instead of creating its own.
        chartCaseTypes.DataSource = chartData
        chartCaseTypes.DataBind() ' Explicitly tell the chart to bind to the data source
    End Sub

    ' --- NEW SUBROUTINE to populate the "Recently Added" grid ---
    Sub LoadRecentCases()
        ' Get the 5 most recent cases.
        dgvRecentCases.DataSource = GetRecentCases()

        ' Apply a simplified style to this grid.
        StyleRecentCasesGrid()
    End Sub

    ' --- NEW SUBROUTINE to style the "Recently Added" grid ---
    Sub StyleRecentCasesGrid()
        ' Basic appearance
        dgvRecentCases.ReadOnly = True
        dgvRecentCases.AllowUserToAddRows = False
        dgvRecentCases.RowHeadersVisible = False
        dgvRecentCases.BorderStyle = BorderStyle.None
        dgvRecentCases.BackgroundColor = Color.WhiteSmoke
        dgvRecentCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentCases.CellBorderStyle = DataGridViewCellBorderStyle.None ' Cleaner look

        ' Header style to match your theme
        dgvRecentCases.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 41, 34)
        dgvRecentCases.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvRecentCases.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        dgvRecentCases.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvRecentCases.ColumnHeadersHeight = 35
        dgvRecentCases.EnableHeadersVisualStyles = False

        ' --- THIS IS THE FIX ---
        ' Define the complete style for the rows, including the selection color.
        Dim defaultRowStyle As New DataGridViewCellStyle()
        defaultRowStyle.Font = New Font("Segoe UI", 9)
        defaultRowStyle.BackColor = Color.White
        defaultRowStyle.ForeColor = Color.FromArgb(40, 40, 40) ' Dark text
        ' Use a light, non-intrusive red for the selection highlight
        defaultRowStyle.SelectionBackColor = Color.FromArgb(255, 224, 220)
        defaultRowStyle.SelectionForeColor = Color.Black ' Ensure selected text is readable

        dgvRecentCases.DefaultCellStyle = defaultRowStyle
        dgvRecentCases.RowTemplate.Height = 30
        ' --- END OF FIX ---

        ' Column sizing
        dgvRecentCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

#End Region

    ' --- (Your existing label click events remain here) ---
    Private Sub LblTotalCases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTotalCases.Click
    End Sub
    Private Sub LblActiveCases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblActiveCases.Click
    End Sub
    Private Sub ResolvedCases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResolvedCases.Click
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

  

    Private Sub Guna2Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub
    Sub dashboardExit()
        GunaTransition1.HideSync(Guna2Panel1)
        GunaTransition2.HideSync(Guna2Panel2)
        GunaTransition3.HideSync(Guna2Panel3)
        GunaTransition4.HideSync(Guna2Panel4)
        GunaTransition5.HideSync(GunaButton1)
        GunaTransition6.HideSync(Label2)
        GunaTransition6.HideSync(AdminForm.Guna2Panel1)
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
     
    End Sub
End Class