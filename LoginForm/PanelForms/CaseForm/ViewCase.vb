Imports System.Data.SqlClient
Imports System.Drawing.Printing ' Required for printing classes
Public Class ViewCase

    Public SelectedIncidentID As Integer
    Private Sub TxtCaseNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCaseNumber.TextChanged

    End Sub

    Private Sub CboIncidentDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboIncidentDate.ValueChanged

    End Sub

    Private Sub txtlocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlocation.TextChanged

    End Sub

    Private Sub CheckBoxPoliceInitiatedCaseNoComplaint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxPoliceInitiatedCaseNoComplaint.CheckedChanged

    End Sub

    Private Sub txtCaseType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CboIncidentTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboIncidentTime.ValueChanged

    End Sub

    Private Sub CboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CboPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtComplainantLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComplainantLastName.TextChanged

    End Sub

    Private Sub txtComplainantFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComplainantFirstName.TextChanged

    End Sub

    Private Sub txtComplainantMiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComplainantMiddleName.TextChanged

    End Sub

    Private Sub txtComplainantContactNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComplainantContactNumber.TextChanged

    End Sub

    Private Sub txtComplainantAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComplainantAddress.TextChanged

    End Sub

    Private Sub txtSuspectDetails_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuspectDetails.TextChanged

    End Sub

    Private Sub txtSuspectFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuspectFirstName.TextChanged

    End Sub

    Private Sub txtSuspectMiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuspectMiddleName.TextChanged

    End Sub

    Private Sub txtSuspectAliasName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuspectAliasName.TextChanged

    End Sub

    Private Sub txtSuspectDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuspectDescription.TextChanged

    End Sub

    Private Sub TxtIncidentNarrativeDetailseofEvent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIncidentNarrativeDetailseofEvent.TextChanged

    End Sub

    Private Sub TxtReportingOfficer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReportingOfficer.TextChanged

    End Sub

    Private Sub ViewCase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' First, check if we received a valid ID. If not, close the form.
        If SelectedIncidentID <= 0 Then
            MsgBox("No record was selected to view.", MsgBoxStyle.Exclamation, "Invalid ID")
            Me.Close()
            Return
        End If

        ' Now, load the data for the selected incident
        LoadIncidentData()

        ' Finally, make all controls read-only so the user can't edit the data
        SetControlsToReadOnly()
    End Sub

     Private Sub LoadIncidentData()
        Dim query As String = "SELECT * FROM IncidentRecords WHERE IncidentID = @IncidentID"
        connection.AddParam("@IncidentID", SelectedIncidentID.ToString())

        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Dim incidentData As DataRow = connection.Data.Tables(0).Rows(0)

            ' --- Populate every control on the form ---
            IncidentID.Text = incidentData("IncidentID") & ""
            TxtCaseNumber.Text = incidentData("CaseNumber") & ""
            ' ... (all your other existing fields are populated here) ...
            CboIncidentDate.Value = CDate(incidentData("IncidentDate"))
            Dim incidentTimeSpan As TimeSpan = CType(incidentData("IncidentTime"), TimeSpan)
            CboIncidentTime.Value = Date.Today + incidentTimeSpan
            txtlocation.Text = incidentData("Location") & ""
            CheckBoxPoliceInitiatedCaseNoComplaint.Checked = CBool(incidentData("PoliceInitiatedCase"))
            txtCaseType.Text = incidentData("CaseType") & ""
            txtStatus.Text = incidentData("Status") & ""
            txtPriority.Text = incidentData("Priority") & ""

            ' Populate the "Record Created" timestamp
            If Not IsDBNull(incidentData("RecordCreationTimestamp")) Then
                Dim creationDateUTC As DateTime = CDate(incidentData("RecordCreationTimestamp"))
                Dim creationDateLocal As DateTime = creationDateUTC.ToLocalTime()
                txtRecordCreated.Text = creationDateLocal.ToString("dd MMMM yyyy 'at' hh:mm tt")
            Else
                txtRecordCreated.Text = "Not Available"
            End If

            ' --- NEW LOGIC ADDED HERE FOR LAST MODIFIED ---
            ' Check if the LastModifiedTimestamp is not null
            If Not IsDBNull(incidentData("LastModifiedTimestamp")) Then
                ' Get the UTC DateTime from the database
                Dim modifiedDateUTC As DateTime = CDate(incidentData("LastModifiedTimestamp"))
                ' Convert it to the user's local time zone
                Dim modifiedDateLocal As DateTime = modifiedDateUTC.ToLocalTime()
                ' Format the LOCAL time for display
                txtLastModified.Text = modifiedDateLocal.ToString("dd MMMM yyyy 'at' hh:mm tt")
            Else
                ' If the record has never been modified, the value will be NULL in the database
                txtLastModified.Text = "Never modified"
            End If
            ' --- END OF NEW LOGIC ---

            ' Complainant Details
            txtComplainantLastName.Text = incidentData("ComplainantLastName") & ""
            ' ... (and so on for all other textboxes) ...
            txtComplainantFirstName.Text = incidentData("ComplainantFirstName") & ""
            txtComplainantMiddleName.Text = incidentData("ComplainantMiddleName") & ""
            txtComplainantContactNumber.Text = incidentData("ComplainantContactNumber") & ""
            txtComplainantAddress.Text = incidentData("ComplainantAddress") & ""
            txtSuspectDetails.Text = incidentData("SuspectDetails") & ""
            txtSuspectFirstName.Text = incidentData("SuspectFirstName") & ""
            txtSuspectMiddleName.Text = incidentData("SuspectMiddleName") & ""
            txtSuspectAliasName.Text = incidentData("SuspectAliasName") & ""
            txtSuspectDescription.Text = incidentData("SuspectDescription") & ""
            TxtIncidentNarrativeDetailseofEvent.Text = incidentData("IncidentNarrativeDetails") & ""
            TxtReportingOfficer.Text = incidentData("ReportingOfficer") & ""

        Else
            MsgBox("Could not find the details for the selected record. It may have been deleted.", MsgBoxStyle.Critical, "Data Not Found")
            Me.Close()
        End If
    End Sub

    ' This subroutine will now work perfectly for the new TextBoxes
    Private Sub SetControlsToReadOnly()
        For Each ctrl As Control In Me.Controls
            DisableControlsRecursive(ctrl)
        Next
    End Sub

    Private Sub DisableControlsRecursive(ByVal parentControl As Control)
        If TypeOf parentControl Is TextBox Then
            ' This now correctly handles txtCaseType, txtStatus, and txtPriority
            CType(parentControl, TextBox).ReadOnly = True
        ElseIf TypeOf parentControl Is DateTimePicker Then
            CType(parentControl, DateTimePicker).Enabled = False
        ElseIf TypeOf parentControl Is CheckBox Then
            CType(parentControl, CheckBox).Enabled = False
        End If

        If parentControl.HasChildren Then
            For Each childCtrl As Control In parentControl.Controls
                DisableControlsRecursive(childCtrl)
            Next
        End If
    End Sub


    Private Sub BtnSaveRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveRecords.Click
        Me.Hide()
    End Sub

    Private Sub txtRecordCreated_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecordCreated.TextChanged

    End Sub

    Private Sub LastModified_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastModified.TextChanged

    End Sub

    Private Sub btnViewAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAttachment.Click
        Dim attachmentsFrm As New AttachmentsForm()
        attachmentsFrm.SelectedIncidentID = Me.SelectedIncidentID
        attachmentsFrm.SelectedCaseNumber = TxtCaseNumber.Text

        ' --- START OF THE FIX ---
        ' Check the role of the currently logged-in user.
        If SESSION IsNot Nothing AndAlso SESSION("Role").ToString() = "Admin" Then
            ' If the user is an Admin, open the form in full "Edit" mode.
            attachmentsFrm.FormMode = "Edit"
        Else
            ' For any other user (like an Officer), open in restricted "ViewOnly" mode.
            attachmentsFrm.FormMode = "ViewOnly"
        End If
        ' --- END OF THE FIX ---

        attachmentsFrm.ShowDialog()
    
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub txtPriority_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPriority.TextChanged

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        ' Use a PrintPreviewDialog to let the user see the report before printing.
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = PrintDocument1 ' Tell the preview which document to use
        printPreviewDialog.WindowState = FormWindowState.Maximized ' Open it full screen
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' This subroutine is where we "draw" everything onto the page.

        ' --- 1. DEFINE FONTS AND BRUSHES for a more formal look ---
        ' Arial is a clean, modern font for headers.
        ' Times New Roman is a classic, formal font for body text.
        Using stationFont As New Font("Arial", 20, FontStyle.Bold)
            Using titleFont As New Font("Arial", 16, FontStyle.Bold)
                Using sectionFont As New Font("Arial", 11, FontStyle.Bold Or FontStyle.Underline)
                    Using labelFont As New Font("Arial", 10, FontStyle.Bold)
                        Using valueFont As New Font("Arial", 10, FontStyle.Regular)
                            Using footerFont As New Font("Arial", 10, FontStyle.Regular)
                                Using blackBrush As New SolidBrush(Color.Black)
                                    Using blackPen As New Pen(Color.Black, 2)

                                        ' Get the printable area of the page, respecting the margins.
                                        Dim pageBounds As Rectangle = e.MarginBounds
                                        Dim currentY As Single = pageBounds.Top ' This is our vertical cursor.
                                        Dim centerX As Single = pageBounds.Left + pageBounds.Width / 2

                                        ' --- 2. DRAW THE CENTERED HEADER ---
                                        Dim logo As Image = My.Resources.Police_Logo
                                        ' Calculate the position to center the logo.
                                        Dim logoWidth As Single = 100 ' Use a smaller, cleaner logo size
                                        Dim logoX As Single = centerX - (logoWidth / 2)
                                        Dim logoRect As New Rectangle(logoX, currentY, logoWidth, logoWidth)
                                        e.Graphics.DrawImage(logo, logoRect)

                                        currentY += logoRect.Height + 5 ' Move down past the logo

                                        ' Calculate the position to center the station name text.
                                        Dim stationText As String = "MARULAS POLICE STATION"
                                        Dim stationTextSize As SizeF = e.Graphics.MeasureString(stationText, stationFont)
                                        Dim stationTextX As Single = centerX - (stationTextSize.Width / 2)
                                        e.Graphics.DrawString(stationText, stationFont, blackBrush, stationTextX, currentY)

                                        ' --- 3. DRAW THE MAIN TITLE ---
                                        currentY += stationTextSize.Height + 10
                                        Dim titleText As String = "INCIDENT REPORT"
                                        Dim titleSize As SizeF = e.Graphics.MeasureString(titleText, titleFont)
                                        Dim titleX As Single = centerX - (titleSize.Width / 2)
                                        e.Graphics.DrawString(titleText, titleFont, blackBrush, titleX, currentY)

                                        currentY += titleSize.Height + 5
                                        e.Graphics.DrawLine(blackPen, pageBounds.Left, currentY, pageBounds.Right, currentY)
                                        currentY += 25 ' Add space after the line.

                                        ' --- 4. CREATE A HELPER SUBROUTINE for drawing fields with word wrapping ---
                                        ' This is much more robust than the old method.
                                        Dim DrawWrappedField = Sub(label As String, value As String)
                                                                   ' Define the area for the label.
                                                                   Dim labelRect As New RectangleF(pageBounds.Left, currentY, 150, 40)
                                                                   e.Graphics.DrawString(label, labelFont, blackBrush, labelRect)

                                                                   ' Define the area for the value, allowing it to wrap.
                                                                   Dim valueX As Single = pageBounds.Left + labelRect.Width + 10
                                                                   Dim valueWidth As Single = pageBounds.Width - labelRect.Width - 10
                                                                   Dim valueRect As New RectangleF(valueX, currentY, valueWidth, pageBounds.Height - currentY)

                                                                   ' Measure how much vertical space the wrapped text will actually take up.
                                                                   Dim valueSize As SizeF = e.Graphics.MeasureString(value, valueFont, valueWidth)

                                                                   ' Draw the value text.
                                                                   e.Graphics.DrawString(value, valueFont, blackBrush, valueRect)

                                                                   ' Move the vertical cursor down by the height of the wrapped text, plus a little padding.
                                                                   currentY += valueSize.Height + 10
                                                               End Sub

                                        ' --- 5. DRAW THE REPORT SECTIONS using the helper subroutine ---

                                        ' Case Details section
                                        DrawWrappedField("Case Number:", TxtCaseNumber.Text)
                                        DrawWrappedField("Date of Incident:", CboIncidentDate.Value.ToString("dd MMMM yyyy"))
                                        DrawWrappedField("Time of Incident:", CboIncidentTime.Value.ToString("hh:mm tt"))
                                        DrawWrappedField("Location:", txtlocation.Text) ' This will now wrap if the location is long.
                                        DrawWrappedField("Case Type:", txtCaseType.Text)
                                        DrawWrappedField("Status:", txtStatus.Text)
                                        DrawWrappedField("Priority:", txtPriority.Text)
                                        DrawWrappedField("Reporting Officer:", TxtReportingOfficer.Text)
                                        currentY += 15 ' Add extra space between sections

                                        ' Complainant Details section
                                        e.Graphics.DrawString("COMPLAINANT DETAILS", sectionFont, blackBrush, pageBounds.Left, currentY)
                                        currentY += 30
                                        DrawWrappedField("Complainant Name:", txtComplainantFirstName.Text & " " & txtComplainantMiddleName.Text & " " & txtComplainantLastName.Text)
                                        DrawWrappedField("Contact Number:", txtComplainantContactNumber.Text)
                                        DrawWrappedField("Address:", txtComplainantAddress.Text) ' This will now wrap.
                                        currentY += 15

                                        ' Suspect Details section
                                        e.Graphics.DrawString("SUSPECT DETAILS", sectionFont, blackBrush, pageBounds.Left, currentY)
                                        currentY += 30
                                        DrawWrappedField("Suspect Name:", txtSuspectFirstName.Text & " " & txtSuspectMiddleName.Text)
                                        DrawWrappedField("Alias:", txtSuspectAliasName.Text)
                                        DrawWrappedField("Description:", txtSuspectDescription.Text) ' This will now wrap.
                                        currentY += 15

                                        ' --- 6. DRAW THE NARRATIVE ---
                                        e.Graphics.DrawString("INCIDENT NARRATIVE", sectionFont, blackBrush, pageBounds.Left, currentY)
                                        currentY += 30
                                        Dim narrativeRect As New RectangleF(pageBounds.Left, currentY, pageBounds.Width, pageBounds.Height - currentY - 50)
                                        e.Graphics.DrawString(TxtIncidentNarrativeDetailseofEvent.Text, valueFont, blackBrush, narrativeRect)

                                        ' --- 7. DRAW THE FOOTER ---
                                        Dim footerText As String = "Printed on: " & DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt")
                                        Dim footerSize As SizeF = e.Graphics.MeasureString(footerText, footerFont)
                                        Dim footerX As Single = pageBounds.Right - footerSize.Width
                                        Dim footerY As Single = pageBounds.Bottom + 10 ' Place it slightly below the margin
                                        e.Graphics.DrawString(footerText, footerFont, blackBrush, footerX, footerY)

                                    End Using
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using
        End Using

    End Sub
End Class