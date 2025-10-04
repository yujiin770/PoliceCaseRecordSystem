Imports System.Data.SqlClient

Module connection
    Public ConnString = "Server=.\SQLEXPRESS; Database=DBPoliceRecord; Trusted_Connection=True;"

    Public Connect As New SqlConnection(ConnString)

    Public Parameters As New List(Of SqlParameter)

    Public Data As DataSet

    Public Datacount As Integer

    Public Sub Open()
        If Connect.State = ConnectionState.Closed Then
            Connect.Open()
        End If
    End Sub

    Public Sub Close()
        If Connect.State = ConnectionState.Open Then
            Connect.Close()
        End If
    End Sub

    Public Sub AddParam(ByVal Key As String, ByVal value As String)
        Parameters.Add(New SqlParameter(Key, value))
    End Sub

    Public Function Query(ByVal command_query As String)
        Open()

        Dim command As New SqlCommand(command_query, Connect)

        If Parameters.Count > 0 Then
            For Each param As SqlParameter In Parameters
                command.Parameters.Add(param)
            Next
            Parameters.Clear()
        End If


        Dim Adapter As New SqlDataAdapter(command)

        Data = New DataSet
        Datacount = Adapter.Fill(Data)

        Close()
        Return Datacount > 0
    End Function

    Public Function Execute(ByVal command_query As String) As Boolean
        Dim affectedRows As Integer = 0

        Try
            Open()
            Dim command As New SqlCommand(command_query, Connect)

            ' Add parameters if they exist 
            If Parameters.Count > 0 Then
                For Each param As SqlParameter In Parameters
                    command.Parameters.Add(param)
                Next
                Parameters.Clear()
            End If
            affectedRows = command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("A database error occurred: " & ex.Message, MsgBoxStyle.Critical, "Database Execution Error")
            Return False
        Finally
            Close()
        End Try
        Return affectedRows > 0
    End Function

    Public Function ExecuteScalar(ByVal command_query As String) As Object
        Dim result As Object = Nothing
        Try
            Open()
            Dim command As New SqlCommand(command_query, Connect)

            ' Add parameters if they exist
            If Parameters.Count > 0 Then
                For Each param As SqlParameter In Parameters
                    command.Parameters.Add(param)
                Next
                Parameters.Clear()
            End If
            result = command.ExecuteScalar()

        Catch ex As Exception
            MsgBox("A database error occurred: " & ex.Message, MsgBoxStyle.Critical, "Database Scalar Error")
        Finally
            Close()
        End Try

        Return result
    End Function


    ' version of AddParam to your connection module.
    Public Sub AddParam(ByVal Key As String, ByVal value As Object)
        Parameters.Add(New SqlParameter(Key, value))
    End Sub
End Module
