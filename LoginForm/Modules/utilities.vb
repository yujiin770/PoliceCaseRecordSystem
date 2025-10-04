Imports System.Data.SqlClient
Module utilities

    Public SESSION As DataRow

    Public Function Login(ByVal username As String, ByVal password As String) As Boolean
        ' Trim inputs (code remains the same)
        username = username.Trim()
        password = password.Trim()

        ' Validation (code remains the same)
        If String.IsNullOrEmpty(username) Then
            MsgBox("Username is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Validation Error")
            LoginForm.UsernameTxtBox.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(password) Then
            MsgBox("Password is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Validation Error")
            LoginForm.PasswordTextBox.Focus()
            Return False
        End If

        ' --- ADD THIS LINE FOR ROBUSTNESS ---
        connection.Parameters.Clear()

        Dim query = "SELECT *, Role FROM Users WHERE Username=@username AND Password=@password"

        connection.AddParam("@username", username)
        connection.AddParam("@password", password)

        ' The rest of the function remains exactly the same...
        Dim result = connection.Query(query)

        If result AndAlso connection.Data.Tables.Count > 0 AndAlso connection.Data.Tables(0).Rows.Count > 0 Then
            Dim user = connection.Data.Tables(0).Rows(0)
            MsgBox("Successfully Login, Welcome " & user("username"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Login")

            LogActivity(username, "User Login", "User '" & username & "' successfully logged in.")

            SESSION = user
            Return True
        End If

        MsgBox("Login Failed. Please check your username and password.", MsgBoxStyle.Critical, "Login Error")
        LoginForm.UsernameTxtBox.Clear()
        LoginForm.PasswordTextBox.Clear()
        LoginForm.UsernameTxtBox.Focus()
        Return False
    End Function

    Public Function SaveIncident(
        ByVal caseNumber As String, ByVal incidentDate As Date, ByVal incidentTime As Date,
        ByVal location As String, ByVal isPoliceInitiated As Boolean, ByVal caseType As String,
        ByVal status As String, ByVal priority As String, ByVal complainantLastName As String,
        ByVal complainantFirstName As String, ByVal complainantMiddleName As String,
        ByVal complainantContact As String, ByVal complainantAddress As String,
        ByVal suspectDetails As String, ByVal suspectFirstName As String, ByVal suspectMiddleName As String,
        ByVal suspectAlias As String, ByVal suspectDescription As String,
        ByVal narrative As String, ByVal reportingOfficer As String
    ) As Boolean

        ' Validation
        If String.IsNullOrWhiteSpace(caseNumber) Then
            MsgBox("Case Number is a required field.", MsgBoxStyle.Exclamation, "Validation Error")
            Return False
        End If

        ' The SQL INSERT statement using the recommended table structure with an ID
        Dim query As String = "INSERT INTO IncidentRecords (CaseNumber, IncidentDate, IncidentTime, Location, " &
                              "PoliceInitiatedCase, CaseType, Status, Priority, ComplainantLastName, " &
                              "ComplainantFirstName, ComplainantMiddleName, ComplainantContactNumber, " &
                              "ComplainantAddress, SuspectDetails, SuspectFirstName, SuspectMiddleName, " &
                              "SuspectAliasName, SuspectDescription, IncidentNarrativeDetails, ReportingOfficer) " &
                              "VALUES (@CaseNumber, @IncidentDate, @IncidentTime, @Location, @PoliceInitiatedCase, " &
                              "@CaseType, @Status, @Priority, @ComplainantLastName, @ComplainantFirstName, " &
                              "@ComplainantMiddleName, @ComplainantContactNumber, @ComplainantAddress, " &
                              "@SuspectDetails, @SuspectFirstName, @SuspectMiddleName, @SuspectAliasName, " &
                              "@SuspectDescription, @IncidentNarrativeDetails, @ReportingOfficer)"

        ' parameters to prevent SQL Injection
        connection.AddParam("@CaseNumber", caseNumber)
        connection.AddParam("@IncidentDate", incidentDate.ToString("yyyy-MM-dd"))
        connection.AddParam("@IncidentTime", incidentTime.ToString("HH:mm:ss"))
        connection.AddParam("@Location", location)
        connection.AddParam("@PoliceInitiatedCase", isPoliceInitiated)
        connection.AddParam("@CaseType", caseType)
        connection.AddParam("@Status", status)
        connection.AddParam("@Priority", priority)
        connection.AddParam("@ComplainantLastName", complainantLastName)
        connection.AddParam("@ComplainantFirstName", complainantFirstName)
        connection.AddParam("@ComplainantMiddleName", complainantMiddleName)
        connection.AddParam("@ComplainantContactNumber", complainantContact)
        connection.AddParam("@ComplainantAddress", complainantAddress)
        connection.AddParam("@SuspectDetails", suspectDetails)
        connection.AddParam("@SuspectFirstName", suspectFirstName)
        connection.AddParam("@SuspectMiddleName", suspectMiddleName)
        connection.AddParam("@SuspectAliasName", suspectAlias)
        connection.AddParam("@SuspectDescription", suspectDescription)
        connection.AddParam("@IncidentNarrativeDetails", narrative)
        connection.AddParam("@ReportingOfficer", reportingOfficer)

        ' --- THIS IS THE UPDATED PART ---
        ' Execute the query and store the result in a variable.
        Dim success As Boolean = connection.Execute(query)

        ' If the query was successful, log the activity.
        If success Then
            LogActivity(SESSION("Username").ToString(), "Create Incident", "Created new incident with Case Number: " & caseNumber)
        End If

        ' Return the result of the database operation.
        Return success




    End Function

    Public Function UpdateIncident(
    ByVal incidentID As Integer, ByVal caseNumber As String, ByVal incidentDate As Date, ByVal incidentTime As Date,
    ByVal location As String, ByVal isPoliceInitiated As Boolean, ByVal caseType As String,
    ByVal status As String, ByVal priority As String, ByVal complainantLastName As String,
    ByVal complainantFirstName As String, ByVal complainantMiddleName As String,
    ByVal complainantContact As String, ByVal complainantAddress As String,
    ByVal suspectDetails As String, ByVal suspectFirstName As String, ByVal suspectMiddleName As String,
    ByVal suspectAlias As String, ByVal suspectDescription As String,
    ByVal narrative As String, ByVal reportingOfficer As String
) As Boolean

        ' The SQL UPDATE statement. We update every field WHERE the IncidentID matches.
        Dim query As String = "UPDATE IncidentRecords SET " &
                              "CaseNumber = @CaseNumber, IncidentDate = @IncidentDate, IncidentTime = @IncidentTime, " &
                              "Location = @Location, PoliceInitiatedCase = @PoliceInitiatedCase, CaseType = @CaseType, " &
                              "Status = @Status, Priority = @Priority, ComplainantLastName = @ComplainantLastName, " &
                              "ComplainantFirstName = @ComplainantFirstName, ComplainantMiddleName = @ComplainantMiddleName, " &
                              "ComplainantContactNumber = @ComplainantContactNumber, ComplainantAddress = @ComplainantAddress, " &
                              "SuspectDetails = @SuspectDetails, SuspectFirstName = @SuspectFirstName, " &
                              "SuspectMiddleName = @SuspectMiddleName, SuspectAliasName = @SuspectAliasName, " &
                              "SuspectDescription = @SuspectDescription, IncidentNarrativeDetails = @IncidentNarrativeDetails, " &
                              "ReportingOfficer = @ReportingOfficer, LastModifiedTimestamp = GETUTCDATE() " &
                              "WHERE IncidentID = @IncidentID"

        ' parameters, including the IncidentID for the WHERE clause
        connection.AddParam("@IncidentID", incidentID.ToString())
        connection.AddParam("@CaseNumber", caseNumber)
        connection.AddParam("@IncidentDate", incidentDate.ToString("yyyy-MM-dd"))
        connection.AddParam("@IncidentTime", incidentTime.ToString("HH:mm:ss"))
        connection.AddParam("@Location", location)
        connection.AddParam("@PoliceInitiatedCase", isPoliceInitiated)
        connection.AddParam("@CaseType", caseType)
        connection.AddParam("@Status", status)
        connection.AddParam("@Priority", priority)
        connection.AddParam("@ComplainantLastName", complainantLastName)
        connection.AddParam("@ComplainantFirstName", complainantFirstName)
        connection.AddParam("@ComplainantMiddleName", complainantMiddleName)
        connection.AddParam("@ComplainantContactNumber", complainantContact)
        connection.AddParam("@ComplainantAddress", complainantAddress)
        connection.AddParam("@SuspectDetails", suspectDetails)
        connection.AddParam("@SuspectFirstName", suspectFirstName)
        connection.AddParam("@SuspectMiddleName", suspectMiddleName)
        connection.AddParam("@SuspectAliasName", suspectAlias)
        connection.AddParam("@SuspectDescription", suspectDescription)
        connection.AddParam("@IncidentNarrativeDetails", narrative)
        connection.AddParam("@ReportingOfficer", reportingOfficer)
        Dim success As Boolean = connection.Execute(query)
        If success Then
            ' --- ADD THIS LINE ---
            LogActivity(SESSION("Username").ToString(), "Update Incident", "Updated incident with Case Number: " & caseNumber)
        End If
        Return success
    End Function

    Public Function CaseNumberExists(ByVal caseNumber As String) As Boolean
        ' This query counts how many records match the given Case Number.
        Dim query As String = "SELECT COUNT(*) FROM IncidentRecords WHERE CaseNumber = @CaseNumber"

        ' Add the parameter for the query
        connection.AddParam("@CaseNumber", caseNumber)

        ' Execute the query
        If connection.Query(query) Then
            ' If the query ran successfully, check the result inside the DataSet
            If connection.Data.Tables.Count > 0 AndAlso connection.Data.Tables(0).Rows.Count > 0 Then
                Dim count As Integer = CInt(connection.Data.Tables(0).Rows(0)(0))

                ' If the count is greater than 0, it means the case number exists.
                Return count > 0
            End If
        End If

        ' If the query fails or returns no data, it doesn't exist.
        Return False
    End Function

    Public Function RemoveIncident(ByVal incidentID As Integer) As Boolean
        ' We need the case number for the log, so we must get it before deleting.
        Dim getCaseNumberQuery As String = "SELECT CaseNumber FROM IncidentRecords WHERE IncidentID = @IncidentID"
        connection.AddParam("@IncidentID", incidentID)
        Dim caseNumber As Object = connection.ExecuteScalar(getCaseNumberQuery)

        ' This query deletes a record based on its unique IncidentID
        Dim query As String = "DELETE FROM IncidentRecords WHERE IncidentID = @IncidentID"
        connection.AddParam("@IncidentID", incidentID)

        Dim success As Boolean = connection.Execute(query)
        If success AndAlso caseNumber IsNot Nothing Then
            ' --- ADD THIS LINE ---
            LogActivity(SESSION("Username").ToString(), "Remove Incident", "Removed incident with Case Number: " & caseNumber.ToString())
        End If
        Return success
    End Function

    Public Function GetTotalCaseCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM IncidentRecords"
        Dim result = connection.ExecuteScalar(query)
        ' If the result is not nothing, convert it to an integer. Otherwise, return 0.
        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
            Return CInt(result)
        Else
            Return 0
        End If
    End Function

    ' Gets the count of cases that are NOT closed.
    Public Function GetActiveCaseCount() As Integer
        ' The LIKE 'Closed%' covers all variations (Closed - Unfounded, Closed - Arrest Made, etc.)
        Dim query As String = "SELECT COUNT(*) FROM IncidentRecords WHERE Status NOT LIKE 'Closed%'"
        Dim result = connection.ExecuteScalar(query)
        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
            Return CInt(result)
        Else
            Return 0
        End If
    End Function

    ' Gets the count of cases that ARE closed.
    Public Function GetResolvedCaseCount() As Integer
        Dim query As String = "SELECT COUNT(*) FROM IncidentRecords WHERE Status LIKE 'Closed%'"
        Dim result = connection.ExecuteScalar(query)
        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
            Return CInt(result)
        Else
            Return 0
        End If
    End Function

    'chart
    Public Function GetCaseTypeBreakdown() As DataTable
        Dim query As String = "SELECT CaseType, COUNT(*) AS CaseCount FROM IncidentRecords GROUP BY CaseType"
        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable()
        End If
    End Function

    ' This function gets the top 10 most recently created records.
    Public Function GetRecentCases() As DataTable
        Dim query As String = "SELECT TOP 10 CaseNumber, IncidentDate, CaseType, Status FROM IncidentRecords ORDER BY RecordCreationTimestamp DESC"

        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable()
        End If
    End Function

    ' This function gets ONLY the closed/resolved cases for the archive form.
    Public Function GetArchivedCases() As DataTable

        Dim query As String = "SELECT IncidentID, CaseNumber, IncidentDate, Status, Priority, LastModifiedTimestamp FROM IncidentRecords " &
                              "WHERE Status LIKE 'Closed%' ORDER BY LastModifiedTimestamp DESC"

        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable() ' Return an empty table to prevent errors
        End If
    End Function

    ' This function updates a case's status back to "Under Investigation".
    Public Function ReopenCase(ByVal incidentID As Integer) As Boolean
        Dim query As String = "UPDATE IncidentRecords SET Status = 'Under Investigation', LastModifiedTimestamp = GETUTCDATE() WHERE IncidentID = @IncidentID"

        connection.AddParam("@IncidentID", incidentID.ToString())

        Return connection.Execute(query)
    End Function

    ' Gets a list of all attachments for a specific IncidentID.
    Public Function GetAttachmentsForCase(ByVal incidentID As Integer) As DataTable
        Dim query As String = "SELECT AttachmentID, FileName, FileType, DateAdded FROM Attachments WHERE IncidentID = @IncidentID"
        connection.AddParam("@IncidentID", incidentID.ToString())

        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable()
        End If
    End Function

    ' Adds a new file to the database.
    Public Function AddAttachment(ByVal incidentID As Integer, ByVal fileName As String, ByVal fileData As Byte(), ByVal fileType As String) As Boolean
        Dim query As String = "INSERT INTO Attachments (IncidentID, FileName, FileData, FileType) VALUES (@IncidentID, @FileName, @FileData, @FileType)"
        connection.AddParam("@IncidentID", incidentID)
        connection.AddParam("@FileName", fileName)
        connection.AddParam("@FileData", fileData)
        connection.AddParam("@FileType", fileType)

        Return connection.Execute(query)
    End Function

    'Gets a single file's data from the database for saving to disk.
    Public Function GetSingleAttachment(ByVal attachmentID As Integer) As DataRow
        Dim query As String = "SELECT FileName, FileData FROM Attachments WHERE AttachmentID = @AttachmentID"
        connection.AddParam("@AttachmentID", attachmentID.ToString())

        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0).Rows(0)
        Else
            Return Nothing
        End If
    End Function

    ' Removes an attachment from the database.
    Public Function RemoveAttachment(ByVal attachmentID As Integer) As Boolean
        Dim query As String = "DELETE FROM Attachments WHERE AttachmentID = @AttachmentID"
        connection.AddParam("@AttachmentID", attachmentID.ToString())
        Return connection.Execute(query)
    End Function

    'Checks if a username already exists in the database.
    Public Function UsernameExists(ByVal username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username"
        connection.AddParam("@Username", username)
        Dim result = connection.ExecuteScalar(query)
        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
            Return CInt(result) > 0
        End If
        Return False
    End Function

    'Creates a new user. For now, we'll hard-code the "Officer" role.
    Public Function CreateNewOfficer(ByVal username As String, ByVal password As String) As Boolean
        ' Note: You should ideally be hashing passwords, but for simplicity, we'll store them as plain text.
        Dim query As String = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, 'Officer')"
        connection.AddParam("@Username", username)
        connection.AddParam("@Password", password)

        ' --- THIS IS THE UPDATED PART ---
        ' Execute the query and store the result.
        Dim success As Boolean = connection.Execute(query)

        ' If the user was created successfully, log this important action.
        If success Then
            ' The user performing this action is the one currently logged in (the Admin).
            LogActivity(SESSION("Username").ToString(), "Create User", "Created a new Officer account for username: '" & username & "'.")
        End If

        ' Return the result.
        Return success
    End Function

    'Updates the password for a given username.
    Public Function UpdateUser(ByVal userID As Integer, ByVal newUsername As String, ByVal newPassword As String) As Boolean
        ' Build the query dynamically based on whether a new password was provided.
        Dim query As String
        Dim originalUsername As String = "" ' For logging purposes

        ' Get the original username before we change it, for the activity log.
        Dim getUsernameQuery As String = "SELECT Username FROM Users WHERE id = @id"
        connection.Parameters.Clear()
        connection.AddParam("@id", userID)
        Dim resultObj = connection.ExecuteScalar(getUsernameQuery)
        If resultObj IsNot Nothing Then
            originalUsername = resultObj.ToString()
        End If

        connection.Parameters.Clear() ' Clear params for the main update query

        If String.IsNullOrWhiteSpace(newPassword) Then
            ' Scenario 1: Only the username is being updated.
            query = "UPDATE Users SET Username = @Username WHERE id = @id"
        Else
            ' Scenario 2: Both username and password are being updated.
            query = "UPDATE Users SET Username = @Username, Password = @Password WHERE id = @id"
            connection.AddParam("@Password", newPassword)
        End If

        ' Add the parameters that are always required.
        connection.AddParam("@Username", newUsername)
        connection.AddParam("@id", userID)

        ' Execute the update.
        Dim success As Boolean = connection.Execute(query)
        If success Then
            ' Log this important security event.
            LogActivity(SESSION("Username").ToString(), "Update User", "Updated details for user '" & originalUsername & "'. New username: '" & newUsername & "'.")
        End If
        Return success
    End Function

    ' Gets a list of all usernames.
    Public Function GetAllUsernames() As DataTable
        Dim query As String = "SELECT Username FROM Users ORDER BY Username ASC"

        ' No parameters are needed for this query.
        connection.Parameters.Clear()

        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable() ' Return an empty table if no users are found.
        End If
    End Function

    'Activity logs----

    Public Sub LogActivity(ByVal username As String, ByVal actionType As String, ByVal details As String)
        ' --- ADD THIS LINE FOR ROBUSTNESS ---
        ' Ensures we start with a clean parameter list every time.
        connection.Parameters.Clear()

        Dim query As String = "INSERT INTO ActivityLogs (Username, ActionType, Details) VALUES (@Username, @ActionType, @Details)"

        connection.AddParam("@Username", username)
        connection.AddParam("@ActionType", actionType)
        connection.AddParam("@Details", details)

        connection.Execute(query)
    End Sub

    ' --- ADD THIS NEW FUNCTION ---
    ' Retrieves all records from the ActivityLogs table to display them.
    Public Function GetActivityLogs() As DataTable
        ' Select all logs, with the newest ones appearing first.
        Dim query As String = "SELECT LogTimestamp, Username, ActionType, Details FROM ActivityLogs ORDER BY LogTimestamp DESC"

        ' Clear any old parameters.
        connection.Parameters.Clear()

        ' Execute the query and check if it returned any data.
        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            ' If there are no logs, return an empty table to prevent errors.
            Return New DataTable()
        End If
    End Function

    ' --- ADD THIS NEW FUNCTION ---
    ' Gets all user data (UserID, Username, and Role) for the grid.
    Public Function GetAllUsers() As DataTable
        ' --- CHANGED THIS LINE ---
        Dim query As String = "SELECT id, Username, Role FROM Users ORDER BY Username ASC"
        connection.Parameters.Clear()
        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable()
        End If
    End Function

    ' --- ADD THIS NEW FUNCTION ---
    ' Removes a user from the database by UserID and logs the action.
    Public Function RemoveUser(ByVal userID As Integer, ByVal usernameToDelete As String) As Boolean
        ' Security Check: Prevent an admin from deleting their own account.
        ' --- CHANGED THIS LINE ---
        If userID = CInt(SESSION("id")) Then
            MsgBox("For security reasons, you cannot remove your own account while you are logged in.", MsgBoxStyle.Critical, "Action Forbidden")
            Return False
        End If

        ' --- CHANGED THIS LINE ---
        Dim query As String = "DELETE FROM Users WHERE id = @id"
        connection.Parameters.Clear()
        ' --- CHANGED THIS LINE ---
        connection.AddParam("@id", userID)

        Dim success As Boolean = connection.Execute(query)
        If success Then
            LogActivity(SESSION("Username").ToString(), "Remove User", "Removed user account: '" & usernameToDelete & "'.")
        End If
        Return success
    End Function

    ' --- ADD THIS NEW, POWERFUL FUNCTION to Utilities Module ---
    Public Function GetFilteredActivityLogs(ByVal searchTerm As String, ByVal username As String, ByVal startDate As Date, ByVal endDate As Date) As DataTable
        ' Start with the base query
        Dim baseQuery As String = "SELECT LogTimestamp, Username, ActionType, Details FROM ActivityLogs"
        Dim conditions As New List(Of String)
        connection.Parameters.Clear()

        ' Condition 1: Search Term in Details
        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            conditions.Add("Details LIKE @searchTerm")
            connection.AddParam("@searchTerm", "%" & searchTerm & "%")
        End If

        ' Condition 2: Filter by Username
        If Not String.IsNullOrWhiteSpace(username) AndAlso username <> "All Users" Then
            conditions.Add("Username = @username")
            connection.AddParam("@username", username)
        End If

        ' Condition 3: Filter by Date Range (inclusive)
        ' We use CONVERT to ignore the time part for the start/end date comparison
        conditions.Add("CONVERT(date, LogTimestamp) >= @startDate AND CONVERT(date, LogTimestamp) <= @endDate")
        connection.AddParam("@startDate", startDate)
        connection.AddParam("@endDate", endDate)

        ' Build the final query
        Dim finalQuery As String = baseQuery
        If conditions.Count > 0 Then
            finalQuery &= " WHERE " & String.Join(" AND ", conditions)
        End If
        finalQuery &= " ORDER BY LogTimestamp DESC"

        ' Execute and return the data
        If connection.Query(finalQuery) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable()
        End If
    End Function



    ' Gets a filtered list of archived (closed) cases.
    Public Function GetFilteredArchivedCases(ByVal searchTerm As String, ByVal startDate As Date, ByVal endDate As Date) As DataTable
        ' The base query only selects records with a "Closed" status.
        Dim baseQuery As String = "SELECT IncidentID, CaseNumber, IncidentDate, Status, Priority, LastModifiedTimestamp FROM IncidentRecords WHERE Status LIKE 'Closed%'"
        Dim conditions As New List(Of String)
        connection.Parameters.Clear()

        ' Condition 1: Search by Case Number or Complainant Name
        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            conditions.Add("(CaseNumber LIKE @searchTerm OR ComplainantLastName LIKE @searchTerm OR ComplainantFirstName LIKE @searchTerm)")
            connection.AddParam("@searchTerm", "%" & searchTerm & "%")
        End If

        ' Condition 2: Filter by the date the case was closed (LastModifiedTimestamp)
        ' We use CONVERT to ignore the time part for a full-day range comparison.
        conditions.Add("CONVERT(date, LastModifiedTimestamp) >= @startDate AND CONVERT(date, LastModifiedTimestamp) <= @endDate")
        connection.AddParam("@startDate", startDate)
        connection.AddParam("@endDate", endDate)

        ' Build the final query by adding the conditions to the base query.
        Dim finalQuery As String = baseQuery
        If conditions.Count > 0 Then
            finalQuery &= " AND " & String.Join(" AND ", conditions)
        End If
        finalQuery &= " ORDER BY LastModifiedTimestamp DESC" ' Show the most recently closed first.

        ' Execute the query
        If connection.Query(finalQuery) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable()
        End If
    End Function


    Public Function ArchiveIncident(ByVal incidentID As Integer) As Boolean
        ' Get the Case Number for logging.
        Dim getCaseNumberQuery As String = "SELECT CaseNumber FROM IncidentRecords WHERE IncidentID = @IncidentID"
        connection.Parameters.Clear()
        connection.AddParam("@IncidentID", incidentID)
        Dim caseNumber As Object = connection.ExecuteScalar(getCaseNumberQuery)

        ' This query UPDATES the status, it does not DELETE.
        Dim query As String = "UPDATE IncidentRecords SET Status = 'Closed - Archived', LastModifiedTimestamp = GETUTCDATE() WHERE IncidentID = @IncidentID"
        connection.Parameters.Clear()
        connection.AddParam("@IncidentID", incidentID)

        Dim success As Boolean = connection.Execute(query)
        If success AndAlso caseNumber IsNot Nothing Then
            LogActivity(SESSION("Username").ToString(), "Archive Incident", "Archived Case #: " & caseNumber.ToString())
        End If
        Return success
    End Function


    ' Permanently deletes an incident and all of its attachments. THIS IS IRREVERSIBLE.
    Public Function PermanentlyDeleteIncident(ByVal incidentID As Integer) As Boolean
        Dim success As Boolean = False
        Dim caseNumber As String = ""

        ' Step 1: Get the Case Number for logging before we delete it.
        Dim getCaseNumberQuery As String = "SELECT CaseNumber FROM IncidentRecords WHERE IncidentID = @IncidentID"
        connection.Parameters.Clear()
        connection.AddParam("@IncidentID", incidentID)
        Dim resultObj = connection.ExecuteScalar(getCaseNumberQuery)
        If resultObj IsNot Nothing Then
            caseNumber = resultObj.ToString()
        End If

        ' Step 2: Delete all attachments associated with this incident first.
        Dim deleteAttachmentsQuery As String = "DELETE FROM Attachments WHERE IncidentID = @IncidentID"
        connection.Parameters.Clear()
        connection.AddParam("@IncidentID", incidentID)
        connection.Execute(deleteAttachmentsQuery) ' We execute this even if it fails, to proceed to the main record

        ' Step 3: Delete the main incident record.
        Dim deleteIncidentQuery As String = "DELETE FROM IncidentRecords WHERE IncidentID = @IncidentID"
        connection.Parameters.Clear()
        connection.AddParam("@IncidentID", incidentID)
        success = connection.Execute(deleteIncidentQuery)

        ' Step 4: Log this critical action if successful.
        If success Then
            LogActivity(SESSION("Username").ToString(), "Permanent Deletion", "Permanently deleted archived Case #: " & caseNumber & " and all its attachments.")
        End If

        Return success
    End Function

    Public Function BackupDatabase(ByVal destinationPath As String) As Boolean
        ' The database name must match your database exactly.
        Dim dbName As String = "DBPoliceRecord"
        Dim query As String = "BACKUP DATABASE [" & dbName & "] TO DISK = @path WITH NOFORMAT, NOINIT, NAME = N'" & dbName & "-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10"

        connection.Parameters.Clear()
        connection.AddParam("@path", destinationPath)

        Try
            ' For backup/restore, we need to use a different connection string
            ' that connects to the 'master' database, which manages all other databases.
            Dim masterConnString As String = "Server=.\SQLEXPRESS; Database=master; Trusted_Connection=True;"
            Using masterConnection As New SqlConnection(masterConnString)
                masterConnection.Open()
                Dim command As New SqlCommand(query, masterConnection)
                command.Parameters.AddWithValue("@path", destinationPath)
                command.ExecuteNonQuery()
                masterConnection.Close()
            End Using
            Return True ' Return true if successful
        Catch ex As Exception
            MsgBox("Backup failed. Error: " & ex.Message & vbCrLf & vbCrLf & "Please ensure the application has permission to write to the selected folder and that no other process is using the database.", MsgBoxStyle.Critical, "Backup Error")
            Return False
        End Try
    End Function

    ' --- ADD THIS NEW FUNCTION to your Utilities Module ---
    ' Restores the database from a specified backup file. THIS IS DESTRUCTIVE.
    Public Function RestoreDatabase(ByVal backupFilePath As String) As Boolean
        Dim dbName As String = "DBPoliceRecord"

        ' This complex query is necessary to force the database offline, restore it, and bring it back online.
        Dim query As String = "ALTER DATABASE [" & dbName & "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " &
                              "RESTORE DATABASE [" & dbName & "] FROM DISK = @path WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5; " &
                              "ALTER DATABASE [" & dbName & "] SET MULTI_USER;"

        connection.Parameters.Clear()
        connection.AddParam("@path", backupFilePath)

        Try
            ' Just like backup, restore must be run from the 'master' database.
            Dim masterConnString As String = "Server=.\SQLEXPRESS; Database=master; Trusted_Connection=True;"
            Using masterConnection As New SqlConnection(masterConnString)
                masterConnection.Open()
                Dim command As New SqlCommand(query, masterConnection)
                command.Parameters.AddWithValue("@path", backupFilePath)
                command.ExecuteNonQuery()
                masterConnection.Close()
            End Using
            Return True
        Catch ex As Exception
            MsgBox("Restore failed. Error: " & ex.Message & vbCrLf & vbCrLf & "Please ensure the backup file is valid and that the application is not currently connected to the database.", MsgBoxStyle.Critical, "Restore Error")
            Return False
        End Try
    End Function

    ' --- ADD THIS NEW FUNCTION to your Utilities Module ---
    ' Gets all incident data within a specific date range for reporting.
    Public Function GetIncidentsByDateRange(ByVal startDate As Date, ByVal endDate As Date) As DataTable
        ' We select all relevant columns needed for a summary report.
        Dim query As String = "SELECT CaseNumber, IncidentDate, CaseType, Status, Priority, Location, ReportingOfficer " &
                              "FROM IncidentRecords " &
                              "WHERE IncidentDate >= @startDate AND IncidentDate <= @endDate " &
                              "ORDER BY IncidentDate ASC"

        connection.Parameters.Clear()
        connection.AddParam("@startDate", startDate.ToString("yyyy-MM-dd"))
        ' Add 1 day to the end date to ensure the entire day is included in the range.
        connection.AddParam("@endDate", endDate.AddDays(1).ToString("yyyy-MM-dd"))

        If connection.Query(query) AndAlso connection.Datacount > 0 Then
            Return connection.Data.Tables(0)
        Else
            Return New DataTable() ' Return an empty table if no records are found
        End If
    End Function


End Module
