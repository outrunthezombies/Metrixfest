Public Class JiraIssue
    Private issuekey, issueSummary, issueSwimLaneId As String
    Public Property Key As String
        Get
            Return issuekey
        End Get
        Set(value As String)
            issuekey = value
        End Set
    End Property

    Public Property Summary As String
        Get
            Return issueSummary
        End Get
        Set(value As String)
            issueSummary = value
        End Set
    End Property

    Public Property SwimLaneID As String
        Get
            Return issueSwimLaneId
        End Get
        Set(value As String)
            issueSwimLaneId = value
        End Set
    End Property

    Private issueTotalTime, issueWorkingTime, issueLeaveTime As Array
    Public Property TotalTime As Array
        Get
            Return issueTotalTime
        End Get
        Set(value As Array)
            issueTotalTime = value
        End Set
    End Property
    Public ReadOnly Property TotalTimeByColumn(column As Integer) As Int64
        Get
            Return issueTotalTime(column)
        End Get
    End Property
    Public ReadOnly Property TotalTimeAsStringByColumn(column As Integer) As String
        Get
            Return GetSystemTimeAsString(issueTotalTime(column))
        End Get
    End Property
    Public Property WorkingTime As Array
        Get
            Return issueWorkingTime
        End Get
        Set(value As Array)
            issueWorkingTime = value
        End Set
    End Property
    Public ReadOnly Property WorkingTimeAsStringByColumn(column As Integer) As String
        Get
            Return GetSystemTimeAsString(issueWorkingTime(column))
        End Get
    End Property
    Public Property LeaveTime As Array
        Get
            Return issueLeaveTime
        End Get
        Set(value As Array)
            issueLeaveTime = value
        End Set
    End Property
    Public ReadOnly Property LeaveTimeAsStringByColumn(column As Integer) As String
        Get
            Try
                Dim ticks As Double = Double.Parse(issueLeaveTime(column))
                Dim time As TimeSpan = TimeSpan.FromMilliseconds(ticks)
                Dim startdate As DateTime = New DateTime(1970, 1, 1) + time
                '                Return DateTime.Parse(issueLeaveTime(column)).ToString("dd/MM/yyyy hh:mm:ss tt")
                Return startdate.ToString
            Catch ex As Exception
                Return Now ' Format(Now, "dd/MM/yyyy")
            End Try
        End Get
    End Property
End Class