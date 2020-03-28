Imports System.Text
Imports Atlassian.Jira
Imports System.Data.OleDb

Module ModuleCommon
    Private username As String = "gbsalsman@gmail.com"
    Private password As String = "Rollins!970"
    Private encodedcredentials As String = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password))
    Private restServer As String = "https://controlcharttest.atlassian.net"
    Private restUrl = "/rest/greenhopper/latest/rapid/charts/controlchart?rapidViewId=1&swimlaneId=2&days=14&projectKey=TP"
    Private jiraProjectKey As String = "controlcharttest"
    Private jqlQuery As String = "project = controlcharttest"
    Private itemsPerPage As Integer = 100
    Private itemStart As Integer = 0

    Private sDBPath As String = "C:\Users\Greg\source\repos\Metrixfest\Metrixfest\metrixfest.mdb"
    Private sConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" & sDBPath & ";Persist Security Info=False;"
    Public oOleDbConnection As OleDbConnection
    Public oOleDbCommand As OleDbCommand
    Public oOleDbDataReader As OleDbDataReader
    Public Enum RecordType
        CycleTime = 0
        Health = 1
    End Enum

    Public Function OpenDBConnection(sql As String) As Boolean
        Try
            oOleDbConnection = New OleDbConnection()
            oOleDbConnection.ConnectionString = sConnectionString
            oOleDbConnection.Open()
            If oOleDbConnection.State = ConnectionState.Open Then
                oOleDbCommand = New OleDbCommand(sql, oOleDbConnection)
            End If

            Return vbTrue
        Catch ex As Exception
            oOleDbCommand = Nothing
            oOleDbConnection = Nothing
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in openDBConnection")

            Return vbFalse
        End Try
    End Function

    Public Sub CloseDBConnection()
        Try
            oOleDbConnection.Close()
        Catch ex As Exception
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in closeDBConnection")
        Finally
            oOleDbCommand = Nothing
            oOleDbConnection = Nothing
        End Try
    End Sub

    Private Function GetJsonData() As String

        Dim jiraConn As Jira = Jira.CreateOAuthRestClient(restServer, consumerKey:="", consumerSecret:="", oAuthAccessToken:="", oAuthTokenSecret:="")

        Dim issueList As Task(Of IPagedQueryResult(Of Issue)) = jiraConn.Issues.GetIssuesFromJqlAsync(jqlQuery)

        Dim i As Task = issueList.Result

        'await ForEachIssue(jiraConn, jiraProjectKey, Issue)

        Return issueList.ToString
    End Function

    Private Async Function ForEachIssue(jiraObject As Jira, projectKey As String, actionItem As Action(Of Issue)) As Task

        Dim itemsPerPage As Integer = 100
        Dim startAt As Integer = 0

        While True
            Dim result = Await jiraObject.Issues.GetIssuesFromJqlAsync(jqlQuery, itemsPerPage, startAt)
            If result.Count() = 0 Then
                Exit While

                For Each Issue In result
                    'actionItem()
                Next
            End If
        End While

        startAt = startAt + itemsPerPage
    End Function

    Public Function GetSystemTimeAsString(ByVal input As Int64) As String
        Dim iSpan As TimeSpan = TimeSpan.FromMilliseconds(input)
        Dim output As String = ""

        If iSpan.Days > 0 Then
            output &= iSpan.Days & " days, "
        End If
        If iSpan.Hours > 0 Then
            output &= iSpan.Hours & " hours, "
        End If
        If iSpan.Minutes > 0 Then
            output &= iSpan.Minutes & " minutes, "
        End If
        output &= iSpan.Seconds & " seconds"

        Return output
    End Function
End Module