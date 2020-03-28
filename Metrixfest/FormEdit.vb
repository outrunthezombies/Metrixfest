Public Class FormEdit
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim sqlInsertUpdate As String = ""

        Select Case pRecordType
            Case ModuleCommon.RecordType.CycleTime
                sqlInsertUpdate = sqlInsertUpdateCycleTime()
            Case ModuleCommon.RecordType.Health
                sqlInsertUpdate = sqlInsertUpdateHealth()
        End Select

        Try
            If OpenDBConnection(sqlInsertUpdate) Then oOleDbCommand.ExecuteReader()
        Catch ex As Exception
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in btnUpdate_Click-->openDBConnection with" & sqlInsertUpdate)
        Finally
            Call CloseDBConnection()
            FormMain.LoadCycleTimeTable()
            Me.Close()
        End Try
    End Sub

    Private Function sqlInsertUpdateCycleTime() As String
        If iRecordType < 0 Then
            Return "INSERT INTO Cycle_Time (cycle_type,lob,team_key,cycle_date,days) " &
                "VALUES (""" & TxtType.Text & """,""" & TxtLOB.Text & """,""" &
                TxtTeam.Text & """,""" & CalDate.Value & """," & TxtValue.Text & ")"
        Else
            Return "UPDATE Cycle_Time SET cycle_date=""" & CalDate.Value &
                """, days = """ & TxtValue.Text & """ WHERE id=" & iRecordType.ToString
        End If
    End Function

    Private Function sqlInsertUpdateHealth() As String
        If iRecordType < 0 Then
            Return "INSERT INTO Cycle_Time (cycle_type,lob,team_key,cycle_date,days) " &
                "VALUES (""" & TxtType.Text & """,""" & TxtLOB.Text & """,""" &
                TxtTeam.Text & """,""" & CalDate.Value & """," & TxtValue.Text & ")"
        Else
            Return "UPDATE Cycle_Time SET cycle_date=""" & CalDate.Value &
                """, days = """ & TxtValue.Text & """ WHERE id=" & iRecordType.ToString
        End If
    End Function
End Class