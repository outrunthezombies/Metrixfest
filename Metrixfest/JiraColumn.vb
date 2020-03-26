Public Class JiraColumn
    Private indexID As Integer
    Public Property Index As Integer
        Get
            Return indexID
        End Get
        Set(value As Integer)
            indexID = value
        End Set
    End Property

    Private JiraID As String
    Public Property ID As String
        Get
            Return JiraID
        End Get
        Set(value As String)
            JiraID = value
        End Set
    End Property

    Private columnName As String
    Public Property Name As String
        Get
            Return columnName
        End Get
        Set(value As String)
            columnName = value
        End Set
    End Property

    Private workRateStart, workRateEnd, workRateRate As Int64
    Public Property RateStart As Int64
        Get
            Return workRateStart
        End Get
        Set(value As Int64)
            workRateStart = value
        End Set
    End Property
    Public Property RateEnd As Int64
        Get
            Return workRateEnd
        End Get
        Set(value As Int64)
            workRateEnd = value
        End Set
    End Property
    Public Property Rate As Int64
        Get
            Return workRateRate
        End Get
        Set(value As Int64)
            workRateRate = value
        End Set
    End Property
    Public ReadOnly Property CalculatedRate As Int64
        Get
            Return workRateEnd - workRateStart
        End Get
    End Property
    Public ReadOnly Property CalculatedRateAsString As String
        Get
            Return GetSystemTimeAsString(workRateEnd - workRateStart)
        End Get
    End Property
End Class