Imports System.Drawing.Printing ' Required for printing classes
' --- ADD THESE LINES AT THE VERY TOP OF THE FILE ---

Imports System.IO
Public Class ReportsFrm
    Private isFormLoading As Boolean = True
    ' This variable will hold the data for the report after it's generated.
    Private reportData As DataTable = Nothing
    Private Sub ReportsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Security Check
        If SESSION Is Nothing OrElse SESSION("Role").ToString() <> "Admin" Then
            MsgBox("You do not have permission to view this page.", MsgBoxStyle.Critical, "Access Denied")
            Guna2GroupBox1.Enabled = False
            Return
        End If

        InitializeReportOptions()


        isFormLoading = False
    End Sub

    ' Sets up the dropdowns and date pickers with default values.
    Private Sub InitializeReportOptions()
        ' The "Generate Report" button is now hidden.


        cboReportType.Items.Clear()
        cboReportType.Items.Add("Incident Summary Report")
        cboReportType.SelectedIndex = 0

        dtpStartDate.Value = New Date(Date.Now.Year, Date.Now.Month, 1)
        dtpEndDate.Value = Date.Now
    End Sub

    ' --- NEW: This event handler fires whenever either date is changed. ---
    Private Sub DateRange_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles dtpStartDate.ValueChanged, dtpEndDate.ValueChanged
        ' --- STEP 3: Check the flag in the event handler ---
        ' If the form is loading, do nothing.
        If isFormLoading Then
            Return
        End If

        ' The code will only reach here if the user MANUALLY changes a date after the form has loaded.
        GenerateAndDisplayReport()
    End Sub

    ' --- NEW: This is now the central function for generating the report. ---
    Private Sub GenerateAndDisplayReport()
        reportData = GetIncidentsByDateRange(dtpStartDate.Value, dtpEndDate.Value)

        If reportData Is Nothing OrElse reportData.Rows.Count = 0 Then
            PrintPreviewControl1.Document = Nothing
            ' --- NEW: Reset stats labels when there's no data ---
            lblTotalIncidents.Text = "0"
            lblMostCommonType.Text = "N/A"
            lblHighPriorityCount.Text = "0"
            MsgBox("No records found for the selected date range.", MsgBoxStyle.Information, "No Data")
            Return
        End If

        PrintPreviewControl1.Document = PrintDocument1

        ' --- START OF NEW CODE: Calculate and Display Statistics ---
        ' 1. Total Incidents
        lblTotalIncidents.Text = reportData.Rows.Count.ToString()

        ' 2. Most Common Case Type
        If reportData.Rows.Count > 0 Then
            Dim mostCommonType = reportData.AsEnumerable().
                                          GroupBy(Function(row) row.Field(Of String)("CaseType")).
                                          OrderByDescending(Function(g) g.Count()).
                                          Select(Function(g) g.Key).
                                          FirstOrDefault()
            lblMostCommonType.Text = mostCommonType
        End If

        ' 3. Count of High/Urgent Priority Incidents
        Dim highPriorityCount = reportData.AsEnumerable().
                                         Where(Function(row) row.Field(Of String)("Priority").ToLower() = "high" OrElse
                                                             row.Field(Of String)("Priority").ToLower() = "urgent").
                                         Count()
        lblHighPriorityCount.Text = highPriorityCount.ToString()
        ' --- END OF NEW CODE ---

        ' Optional: Log this action
        LogActivity(SESSION("Username").ToString(), "Generate Report", "Generated an Incident Summary Report for " & dtpStartDate.Value.ToShortDateString() & " to " & dtpEndDate.Value.ToShortDateString())
    End Sub



    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' This is where we draw the report onto the virtual page.

        ' --- 1. DEFINE FONTS AND RESOURCES (with corrected syntax) ---
        Using headerFont As New Font("Arial", 16, FontStyle.Bold)
            Using titleFont As New Font("Arial", 14, FontStyle.Bold)
                Using dateFont As New Font("Arial", 10, FontStyle.Italic)
                    Using tableHeaderFont As New Font("Segoe UI", 9, FontStyle.Bold)
                        Using tableCellFont As New Font("Segoe UI", 8, FontStyle.Regular)
                            Using blackBrush As New SolidBrush(Color.Black)
                                Using blackPen As New Pen(Color.Black, 1)

                                    ' --- All the drawing logic goes INSIDE the innermost Using block ---

                                    Dim pageBounds As Rectangle = e.MarginBounds
                                    Dim currentY As Single = pageBounds.Top
                                    Dim centerX As Single = pageBounds.Left + pageBounds.Width / 2

                                    ' --- 2. DRAW HEADER ---
                                    Dim headerText As String = "Marulas Police Station"
                                    Dim headerSize As SizeF = e.Graphics.MeasureString(headerText, headerFont)
                                    Dim headerX As Single = centerX - (headerSize.Width / 2)
                                    e.Graphics.DrawString(headerText, headerFont, blackBrush, headerX, currentY)
                                    currentY += headerSize.Height

                                    Dim titleText As String = cboReportType.SelectedItem.ToString()
                                    Dim titleSize As SizeF = e.Graphics.MeasureString(titleText, titleFont)
                                    Dim titleX As Single = centerX - (titleSize.Width / 2)
                                    e.Graphics.DrawString(titleText, titleFont, blackBrush, titleX, currentY)
                                    currentY += titleSize.Height

                                    Dim dateText As String = "For the period: " & dtpStartDate.Value.ToString("dd-MMM-yyyy") & " to " & dtpEndDate.Value.ToString("dd-MMM-yyyy")
                                    Dim dateSize As SizeF = e.Graphics.MeasureString(dateText, dateFont)
                                    Dim dateX As Single = centerX - (dateSize.Width / 2)
                                    e.Graphics.DrawString(dateText, dateFont, blackBrush, dateX, currentY)
                                    currentY += dateSize.Height + 20

                                    ' --- 3. DRAW THE DATA TABLE HEADER ---
                                    Dim tableX As Single = pageBounds.Left
                                    Dim colWidths() As Single = {80, 100, 150, 150, 80, pageBounds.Width - 560}
                                    Dim colHeaders() As String = {"Date", "Case Number", "Case Type", "Status", "Priority", "Location"}

                                    For i As Integer = 0 To colHeaders.Length - 1
                                        e.Graphics.DrawString(colHeaders(i), tableHeaderFont, blackBrush, tableX, currentY)
                                        tableX += colWidths(i)
                                    Next
                                    currentY += 20
                                    e.Graphics.DrawLine(blackPen, pageBounds.Left, currentY, pageBounds.Right, currentY)
                                    currentY += 5

                                    ' --- 4. DRAW THE DATA ROWS (LOOP) ---
                                    If reportData IsNot Nothing Then
                                        For Each row As DataRow In reportData.Rows
                                            If currentY + 40 > pageBounds.Bottom Then
                                                e.HasMorePages = True
                                                Return
                                            End If

                                            tableX = pageBounds.Left
                                            e.Graphics.DrawString(CDate(row("IncidentDate")).ToString("dd-MM-yyyy"), tableCellFont, blackBrush, tableX, currentY)
                                            tableX += colWidths(0)
                                            e.Graphics.DrawString(row("CaseNumber").ToString(), tableCellFont, blackBrush, tableX, currentY)
                                            tableX += colWidths(1)
                                            e.Graphics.DrawString(row("CaseType").ToString(), tableCellFont, blackBrush, tableX, currentY)
                                            tableX += colWidths(2)
                                            e.Graphics.DrawString(row("Status").ToString(), tableCellFont, blackBrush, tableX, currentY)
                                            tableX += colWidths(3)
                                            e.Graphics.DrawString(row("Priority").ToString(), tableCellFont, blackBrush, tableX, currentY)
                                            tableX += colWidths(4)
                                            Dim locationRect As New RectangleF(tableX, currentY, colWidths(5), 40)
                                            e.Graphics.DrawString(row("Location").ToString(), tableCellFont, blackBrush, locationRect)
                                            currentY += 40
                                        Next
                                    End If

                                    ' --- 5. CLEANUP ---
                                    e.HasMorePages = False

                                End Using ' blackPen
                            End Using ' blackBrush
                        End Using ' tableCellFont
                    End Using ' tableHeaderFont
                End Using ' dateFont
            End Using ' titleFont
        End Using ' headerFont
    End Sub

    Private Sub btnExportPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportPDF.Click
        ' Check if a report is currently displayed.
        If reportData Is Nothing OrElse reportData.Rows.Count = 0 Then
            MsgBox("There is no report data to export.", MsgBoxStyle.Information, "No Data to Export")
            Return
        End If

        ' The "Print to PDF" logic remains the same.
        Dim pdfPrinterName As String = "Microsoft Print to PDF"
        Dim printerExists As Boolean = False
        For Each printer As String In PrinterSettings.InstalledPrinters
            If printer = pdfPrinterName Then
                printerExists = True
                Exit For
            End If
        Next

        If Not printerExists Then
            MsgBox("The 'Microsoft Print to PDF' printer was not found.", MsgBoxStyle.Critical, "PDF Printer Not Found")
            Return
        End If

        PrintDocument1.PrinterSettings.PrinterName = pdfPrinterName

        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = PrintDocument1
        printPreviewDialog.Text = "Export Report to PDF"
        printPreviewDialog.WindowState = FormWindowState.Maximized
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintPreviewControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewControl1.Click

    End Sub

    Private Sub Guna2GroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class