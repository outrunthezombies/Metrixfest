Imports Newtonsoft.Json.Linq

Public Class FormJson
    Private jiraIssues As New List(Of JiraIssue)
    Private jiraColumns As New List(Of JiraColumn)

    Private Sub SpitOutColumnValues(header As String)
        Dim output As String = ""
        output &= header & vbCrLf
        output &= "______________________________________" & vbCrLf
        For Each thing As JiraColumn In jiraColumns
            output &= "Index: " & thing.Index & vbCrLf _
                & "ID: " & thing.ID & vbCrLf _
                & "Name: " & thing.Name & vbCrLf _
                & "Rate Start: " & thing.RateStart & vbCrLf _
                & "Rate End: " & thing.RateEnd & vbCrLf _
                & "System Calculated Rate: " & thing.CalculatedRate & vbCrLf _
                & "System Calc. Rate Str: " & thing.CalculatedRateAsString _
                & vbCrLf & vbCrLf
        Next
        output &= "______________________________________" & vbCrLf & vbCrLf
        txtRates.Text = output
    End Sub

    Private Sub SpitOutIssueValues()
        Dim output As String = ""

        For Each thing As JiraIssue In jiraIssues
            output &= "Key: " & thing.Key & vbCrLf _
                & "Summary: " & thing.Summary & vbCrLf _
                & "Swimlane ID: " & thing.SwimLaneID & vbCrLf
            For i = 0 To thing.WorkingTime.Length - 1
                output &= "Working Time - " & jiraColumns(i).Name & ": " & thing.WorkingTime(i) & ", " & thing.WorkingTimeAsStringByColumn(i) & vbCrLf
            Next
            For i = 0 To thing.LeaveTime.Length - 1
                output &= "Leave Time - " & jiraColumns(i).Name & ": " & thing.LeaveTime(i) & ", " & thing.LeaveTimeAsStringByColumn(i) & vbCrLf
            Next
            For i = 0 To thing.TotalTime.Length - 1
                output &= "Total Time - " & jiraColumns(i).Name & ": " & thing.TotalTime(i) & ", " & thing.TotalTimeAsStringByColumn(i) & vbCrLf
            Next
            output &= "______________________________________" & vbCrLf & vbCrLf
        Next
        txtIssues.Text = output
    End Sub
    Private Function CreateTimeArray(value As JProperty) As Array
        MsgBox(value.Count)
        MsgBox(value.Value.Count)
        Dim totalTimes(value.Value.Count - 1) As Int64
        For i = 0 To value.Value.Count - 1
            totalTimes(i) = value.Value(i).Value(Of Int64)
        Next
        Return totalTimes
    End Function

    Private Sub BuildJiraIssuesAndColumnsFromJson()
        Dim json As JObject = JObject.Parse(txtJson.Text)
        Dim data As List(Of JToken) = json.Children().ToList
        txtRates.Clear()
        jiraIssues.Clear()
        jiraColumns.Clear()

        For Each item As JProperty In data
            item.CreateReader()
            Select Case item.Name
                Case "issues"
                    Dim issues As List(Of JToken) = item.Children().Children().ToList
                    For Each issue As JObject In issues
                        issue.CreateReader()
                        Dim values As List(Of JToken) = issue.Children().ToList
                        Dim newJiraIssue As New JiraIssue

                        For Each value As JProperty In values
                            value.CreateReader()
                            Select Case value.Name
                                Case "key"
                                    newJiraIssue.Key = value.Value
                                Case "summary"
                                    newJiraIssue.Summary = value.Value
                                Case "swimlaneId"
                                    newJiraIssue.SwimLaneID = value.Value
                                Case "totalTime"
                                    newJiraIssue.TotalTime = CreateTimeArray(value)
                                Case "workingTime"
                                    newJiraIssue.WorkingTime = CreateTimeArray(value)
                                Case "leaveTimes"
                                    newJiraIssue.LeaveTime = CreateTimeArray(value)
                            End Select
                        Next
                        jiraIssues.Add(newJiraIssue)
                    Next
                Case "columns"
                    Dim columns As List(Of JToken) = item.Children().Children().ToList
                    Dim index As Integer = 0
                    For Each column As JObject In columns
                        column.CreateReader()
                        Dim jiraColumn As New JiraColumn

                        Dim values As List(Of JToken) = column.Children().ToList
                        For Each value As JProperty In values
                            Select Case value.Name
                                Case "id"
                                    jiraColumn.ID = CInt(value.Value)
                                Case "name"
                                    jiraColumn.Name = value.Value
                            End Select
                        Next
                        jiraColumn.Index = index
                        jiraColumns.Add(jiraColumn)
                        index += 1
                    Next
                    SpitOutColumnValues("After Columns:")
                Case "workRateData"
                    Dim workRateData As List(Of JToken) = item.Children().Children().ToList
                    For Each workRate As JProperty In workRateData
                        workRate.CreateReader()
                        Select Case workRate.Name
                            Case "timezone"
                                'MsgBox(workRate.Value) 'Time zone value
                            Case "rates"
                                Dim rates As List(Of JToken) = workRate.Children().Children().ToList
                                Dim i As Integer = 0
                                For Each rate As JObject In rates
                                    rate.CreateReader()
                                    Dim values As List(Of JToken) = rate.Children().ToList
                                    Dim tempColumn As JiraColumn = jiraColumns(i)

                                    For Each value As JProperty In values
                                        value.CreateReader()
                                        Select Case value.Name
                                            Case "start"
                                                tempColumn.RateStart = value.Value
                                            Case "end"
                                                tempColumn.RateEnd = value.Value
                                            Case "rate"
                                                tempColumn.Rate = value.Value
                                        End Select
                                    Next
                                    tempColumn = Nothing
                                    SpitOutColumnValues("After Rate: " & i)
                                    i += 1
                                Next
                        End Select
                    Next
                    SpitOutColumnValues("After All Values:")
                    SpitOutIssueValues()
            End Select
        Next
    End Sub
    Private Sub btnParse_Click(sender As Object, e As EventArgs) Handles btnParse.Click
        Call BuildJiraIssuesAndColumnsFromJson()
    End Sub
End Class