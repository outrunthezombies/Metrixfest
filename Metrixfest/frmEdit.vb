Public Class frmEdit
    Private vRecordType As RecordType
    Private iRecordType As Integer = -1

    Public Property pRecordType() As Integer
        Get
            Return vRecordType
        End Get
        Set(ByVal value As Integer)
            vRecordType = value
        End Set
    End Property

    Public Property RecordType() As Integer
        Get
            Return iRecordType
        End Get
        Set(value As Integer)
            iRecordType = value
        End Set
    End Property

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim sqlInsertUpdate As String = ""

        Select Case pRecordType
            Case modCommon.RecordType.CycleTime
                sqlInsertUpdate = sqlInsertUpdateCycleTime()
            Case modCommon.RecordType.Health
                sqlInsertUpdate = sqlInsertUpdateHealth()
        End Select

        Try
            If openDBConnection(sqlInsertUpdate) Then oOleDbCommand.ExecuteReader()
        Catch ex As Exception
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in btnUpdate_Click-->openDBConnection with" & sqlInsertUpdate)
        Finally
            Call closeDBConnection()
            frmMain.loadCycleTimeTable()
            Me.Close()
        End Try
    End Sub

    Private Function sqlInsertUpdateCycleTime() As String
        If iRecordType < 0 Then
            Return "INSERT INTO Cycle_Time (cycle_type,lob,team_key,cycle_date,days) " &
                "VALUES (""" & txtType.Text & """,""" & txtLOB.Text & """,""" &
                txtTeam.Text & """,""" & calDate.Value & """," & txtValue.Text & ")"
        Else
            Return "UPDATE Cycle_Time SET cycle_date=""" & calDate.Value &
                """, days = """ & txtValue.Text & """ WHERE id=" & iRecordType.ToString
        End If
    End Function

    Private Function sqlInsertUpdateHealth() As String
        If iRecordType < 0 Then
            Return "INSERT INTO Cycle_Time (cycle_type,lob,team_key,cycle_date,days) " &
                "VALUES (""" & txtType.Text & """,""" & txtLOB.Text & """,""" &
                txtTeam.Text & """,""" & calDate.Value & """," & txtValue.Text & ")"
        Else
            Return "UPDATE Cycle_Time SET cycle_date=""" & calDate.Value &
                """, days = """ & txtValue.Text & """ WHERE id=" & iRecordType.ToString
        End If
    End Function
End Class