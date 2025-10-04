Public Class AddRecordFrm


    ' --- NEW PROPERTIES ---
    ' This will tell the form if it should "Add" or "Update"
    Public FormMode As String = "Add" ' Default to "Add" mode
    ' This will hold the ID of the record we are editing
    Public SelectedIncidentID As Integer = 0
    Private Sub ClearFields()
        ' --- Clear Case Details ---
        TxtCaseNumber.Clear()
        CboIncidentDate.Value = Date.Now ' Reset to today's date
        CboIncidentTime.Value = Date.Now ' Reset to the current time
        txtlocation.Clear()
        CheckBoxPoliceInitiatedCaseNoComplaint.Checked = False

        ' Reset ComboBoxes to the first item (index 0)
        If txtCaseType.Items.Count > 0 Then txtCaseType.SelectedIndex = 0
        If CboStatus.Items.Count > 0 Then CboStatus.SelectedIndex = 0
        If CboPriority.Items.Count > 0 Then CboPriority.SelectedIndex = 0

        ' --- Clear Complainant Details ---
        txtComplainantLastName.Clear()
        txtComplainantFirstName.Clear()
        txtComplainantMiddleName.Clear()
        txtComplainantContactNumber.Clear()
        txtComplainantAddress.Clear()

        ' --- Clear Suspect Details ---
        txtSuspectDetails.Clear()
        txtSuspectFirstName.Clear()
        txtSuspectMiddleName.Clear()
        txtSuspectAliasName.Clear()
        txtSuspectDescription.Clear()

        ' --- Clear Narrative Details ---
        TxtIncidentNarrativeDetailseofEvent.Clear()
        TxtReportingOfficer.Clear()

        ' --- Set focus back to the first field for the next entry ---
        TxtCaseNumber.Focus()
    End Sub

    Private Sub LoadDataForUpdate()
        If SelectedIncidentID <= 0 Then Return

        Dim query As String = "SELECT * FROM IncidentRecords WHERE IncidentID = @IncidentID"
        connection.AddParam("@IncidentID", SelectedIncidentID.ToString())

        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Dim incidentData As DataRow = connection.Data.Tables(0).Rows(0)

            ' Populate all the controls on this form
            TxtCaseNumber.Text = incidentData("CaseNumber") & ""
            CboIncidentDate.Value = CDate(incidentData("IncidentDate"))
            Dim incidentTimeSpan As TimeSpan = CType(incidentData("IncidentTime"), TimeSpan)
            CboIncidentTime.Value = Date.Today + incidentTimeSpan
            txtlocation.Text = incidentData("Location") & ""
            CheckBoxPoliceInitiatedCaseNoComplaint.Checked = CBool(incidentData("PoliceInitiatedCase"))
            txtCaseType.Text = incidentData("CaseType") & ""
            CboStatus.Text = incidentData("Status") & ""
            CboPriority.Text = incidentData("Priority") & ""
            ' ... continue populating ALL other controls ...
            txtComplainantLastName.Text = incidentData("ComplainantLastName") & ""
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
        End If
    End Sub

    Private Sub InitializeComboBoxes()
        ' --- Populate Case Type ComboBox ---
        ' Note: Your control is named txtCaseType but the event is SelectedIndexChanged,
        ' so I'm treating it as a ComboBox.
        txtCaseType.Items.Clear() ' Clear existing items first
        txtCaseType.Items.Add("Theft")
        txtCaseType.Items.Add("Assault")
        txtCaseType.Items.Add("Vandalism")
        txtCaseType.Items.Add("Burglary")
        txtCaseType.Items.Add("Robbery")
        txtCaseType.Items.Add("Traffic Violation")
        txtCaseType.Items.Add("Missing Person")
        txtCaseType.Items.Add("Public Disturbance")
        txtCaseType.Items.Add("Domestic Dispute")
        txtCaseType.Items.Add("Fraud")
        txtCaseType.Items.Add("Drugs")
        txtCaseType.Items.Add("Other")
        ' Set a default selection
        If txtCaseType.Items.Count > 0 Then txtCaseType.SelectedIndex = 0

        ' --- Populate Priority ComboBox ---
        CboPriority.Items.Clear()
        CboPriority.Items.Add("Low")
        CboPriority.Items.Add("Medium")
        CboPriority.Items.Add("High")
        CboPriority.Items.Add("Urgent")
        ' Set a default selection
        If CboPriority.Items.Count > 0 Then CboPriority.SelectedIndex = 0

        CboStatus.Items.Clear() ' Clear it first

        If FormMode = "Add" Then
            ' If we are ADDING a new record, only provide the initial statuses.
            CboStatus.Items.Add("New")
            CboStatus.Items.Add("Open")

        ElseIf FormMode = "Update" Then
            ' If we are UPDATING an existing record, provide ALL possible statuses.
            CboStatus.Items.Add("New")
            CboStatus.Items.Add("Open")
            CboStatus.Items.Add("Under Investigation")
            CboStatus.Items.Add("Pending")
            CboStatus.Items.Add("Closed - Unfounded")
            CboStatus.Items.Add("Closed - Arrest Made")
            CboStatus.Items.Add("Closed - Resolved")
        End If

        ' Set a default selection if the list is not empty.
        If CboStatus.Items.Count > 0 Then CboStatus.SelectedIndex = 0
    End Sub

    Private Sub AddRecordFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SESSION IsNot Nothing Then
            TxtReportingOfficer.Text = SESSION("Username").ToString()
        End If


        InitializeComboBoxes()

        ' Configure DateTimePicker for manual time entry
        CboIncidentTime.Format = DateTimePickerFormat.Custom
        CboIncidentTime.CustomFormat = "HH:mm:ss"   ' Display format
        CboIncidentTime.ShowUpDown = True           ' Allow manual typing
        ' This is the original code to fill the dropdowns
        InitializeComboBoxes()
        If FormMode = "Add" Then
            ' Assuming the button is GunaButton2, as you mentioned.
            GunaButton2.Visible = False
            btnManageAttachments.Visible = False
            GunaButton1.Location = New Point(609, 710)
            BtnSaveRecords.Location = New Point(799, 710)
            ' --- NEW LOGIC ---
            ' If we are in "Update" mode, change the form and load the data
        ElseIf FormMode = "Update" Then
            ' Change titles and button text for clarity
            Label2.Text = "Update Incident Record"
            GunaButton2.Visible = True
            GunaLabel7.Text = ""
            ' Assuming your save button is named BtnSaveRecords
            BtnSaveRecords.Text = "Update Record"
            GunaButton1.Location = New Point(418, 707)
            ' Make the unique Case Number read-only to prevent accidental changes
            TxtCaseNumber.ReadOnly = True
            Guna2Panel1.Visible = True


            btnManageAttachments.Visible = True ' Make the button visible for existing records.
            ' Load the existing data for the selected record
            LoadDataForUpdate()
        End If
    End Sub

 

    Private Sub BtnSaveRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveRecords.Click
        ' --- Step 1: Gather all data from the controls ---
        ' (This part is the same as we've done before)
        Dim caseNum As String = TxtCaseNumber.Text.Trim()
        Dim incDate As Date = CboIncidentDate.Value
        Dim incTime As Date = CboIncidentTime.Value
        Dim loc As String = txtlocation.Text
        Dim isPoliceInit As Boolean = CheckBoxPoliceInitiatedCaseNoComplaint.Checked
        Dim caseType As String = txtCaseType.Text
        Dim status As String = CboStatus.Text
        Dim priority As String = CboPriority.Text
        Dim compLName As String = txtComplainantLastName.Text
        Dim compFName As String = txtComplainantFirstName.Text
        Dim compMName As String = txtComplainantMiddleName.Text
        Dim compContact As String = txtComplainantContactNumber.Text
        Dim compAddr As String = txtComplainantAddress.Text
        Dim suspDetails As String = txtSuspectDetails.Text
        Dim suspFName As String = txtSuspectFirstName.Text
        Dim suspMName As String = txtSuspectMiddleName.Text
        Dim suspAlias As String = txtSuspectAliasName.Text
        Dim suspDesc As String = txtSuspectDescription.Text
        Dim narrative As String = TxtIncidentNarrativeDetailseofEvent.Text
        Dim officer As String = TxtReportingOfficer.Text

        ' --- Step 2: Check the form's mode and call the correct function ---
        If FormMode = "Add" Then
            ' This is the "Add New Record" logic
            If String.IsNullOrWhiteSpace(caseNum) Then
                MsgBox("Case Number is a required field.", MsgBoxStyle.Exclamation)
                Return
            End If
            If CaseNumberExists(caseNum) Then
                MsgBox("This Case Number already exists. Please enter a unique one.", MsgBoxStyle.Critical)
                Return
            End If

            ' --- THIS IS THE FIX: Call SaveIncident with ALL the variables ---
            If SaveIncident(caseNum, incDate, incTime, loc, isPoliceInit, caseType, status, priority,
                            compLName, compFName, compMName, compContact, compAddr, suspDetails,
                            suspFName, suspMName, suspAlias, suspDesc, narrative, officer) Then
                MsgBox("Record saved successfully!", MsgBoxStyle.Information)
                ClearFields() ' Clear the form for the next entry
                ManageForm.LoadData()
                Dashboard.LoadDashboardStats()
                Dashboard.LoadCaseTypeChart()
                Dashboard.LoadRecentCases()
            Else
                MsgBox("Failed to save the record.", MsgBoxStyle.Critical)
            End If

        ElseIf FormMode = "Update" Then
            ' This is the "Update Existing Record" logic

            ' --- THIS IS THE FIX: Call UpdateIncident with ALL the variables ---
            If UpdateIncident(SelectedIncidentID, caseNum, incDate, incTime, loc, isPoliceInit, caseType, status, priority,
                              compLName, compFName, compMName, compContact, compAddr, suspDetails,
                              suspFName, suspMName, suspAlias, suspDesc, narrative, officer) Then
                MsgBox("Record updated successfully!", MsgBoxStyle.Information)
                Me.Close() ' Close the form after the update is complete
                Dashboard.LoadDashboardStats()
                Dashboard.LoadCaseTypeChart()
                Dashboard.LoadRecentCases()
                ArchiveFrm.LoadArchivedData()
                ClearFields()
            Else
                MsgBox("Failed to update the record.", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub btnManageAttachments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageAttachments.Click
         Dim attachmentsFrm As New AttachmentsForm()
        attachmentsFrm.SelectedIncidentID = Me.SelectedIncidentID
        attachmentsFrm.SelectedCaseNumber = Me.TxtCaseNumber.Text

        ' The default mode is "Edit", which is correct for an Admin.
        ' No need to set the FormMode here.

        attachmentsFrm.ShowDialog()
       
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        Me.Hide()
    End Sub

    Private Sub Guna2GroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class
