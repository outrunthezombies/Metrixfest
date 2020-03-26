Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMain
    Private sqlCycleTimes = "SELECT ID,cycle_date,days From Cycle_Time"
    Private sqlDeleteCycleTime = "DELETE FROM Cycle_Time WHERE id="

    Public Sub loadCycleTimeTable()
        grpCycleTimes.Visible = False

        If cboLob.SelectedIndex > -1 And cboTeam.SelectedIndex > -1 And cboCycleType.SelectedIndex > -1 Then
            grpCycleTimes.Text = StrConv("Cycle: " & Replace(cboCycleType.Text, "_", " "), VbStrConv.ProperCase)
            Call loadCycleTimes()
            grpCycleTimes.Visible = True
        End If
    End Sub

    Private Sub btnCycle_Click(sender As Object, e As EventArgs) Handles btnCycle.Click
        Call loadCycleTimeTable()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sRowinfo As String
        Dim iResponse As Integer
        Dim iDBIndex As Integer

        If dgvData.Rows.Count > 0 Then
            With dgvData
                iDBIndex = .Rows(.CurrentCell.RowIndex).Cells(0).Value
                sRowinfo = "Delete Row: " & vbCrLf & vbCrLf & "For Date: " & vbCrLf &
            .Rows(.CurrentCell.RowIndex).Cells(1).Value & vbCrLf &
            "With Value: " & .Rows(.CurrentCell.RowIndex).Cells(2).Value
            End With

            iResponse = MsgBox(sRowinfo, vbYesNoCancel, "Are you sure you want to delete this row?")

            Select Case iResponse
                Case vbYes
                    If deleteCycleTime(iDBIndex) Then
                        MsgBox("Deleted")
                    Else
                        MsgBox("Not Complete")
                    End If
                    Call loadCycleTimes()
                Case vbNo
                    MsgBox("Aborted")
            End Select
        Else
            MsgBox("No available data")
        End If
    End Sub

    Private Function deleteCycleTime(index As Integer) As Boolean
        Try
            If openDBConnection(sqlDeleteCycleTime & index.ToString) Then oOleDbCommand.ExecuteReader()
        Catch ex As Exception
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in deleteCycleTime-->openDBConnection with" & sqlDeleteCycleTime & index.ToString)
            Return vbFalse
        Finally
            Call closeDBConnection()
        End Try
        Return vbTrue
    End Function

    Private Sub loadCycleTimes()
        Dim i As Integer
        Dim sql As String

        sql = sqlCycleTimes & " WHERE lob = """ & cboLob.SelectedItem.ToString() &
            """ AND team_key = """ & cboTeam.SelectedItem.ToString() &
            """ AND cycle_type = """ & cboCycleType.SelectedItem.ToString &
            """ ORDER BY cycle_date DESC"
        Debug.Print("loadCycleTimes(): SQL: " & sql)
        dgvData.Rows.Clear()

        Try
            i = 0

            If openDBConnection(sql) Then

                oOleDbDataReader = oOleDbCommand.ExecuteReader()

                Do While oOleDbDataReader.Read()
                    Dim str(oOleDbDataReader.FieldCount - 1) As String
                    For i = 0 To oOleDbDataReader.FieldCount - 1 Step 1
                        str(i) = oOleDbDataReader.GetValue(i)
                    Next i
                    Me.dgvData.Rows.Add(str)
                    i = i + 1
                Loop

                oOleDbDataReader.Close()

            End If
        Catch ex As Exception
            MsgBox("Function failed, check logs")
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in loadCycleTime")
        Finally
            oOleDbDataReader = Nothing

            Call closeDBConnection()
        End Try
    End Sub

    Private Sub populateComboBox(ByRef sql As String, ByRef cbo As ComboBox)
        Try
            If openDBConnection(sql) Then

                oOleDbDataReader = oOleDbCommand.ExecuteReader()

                Do While oOleDbDataReader.Read()
                    cbo.Items.Add(oOleDbDataReader.GetValue(0))
                Loop

                oOleDbDataReader.Close()
            End If
        Catch ex As Exception
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in populateComboBox")
        Finally
            oOleDbDataReader = Nothing

            Call closeDBConnection()
        End Try
    End Sub

    Private Sub populateCycleTypes()
        Dim sql = "SELECT DISTINCT cycle_type from Cycle_Types ORDER BY cycle_type"
        cboCycleType.Items.Clear()
        populateComboBox(sql, cboCycleType)
    End Sub

    Private Sub populateLOB()
        Dim sql = "SELECT DISTINCT lob from Areas ORDER BY lob"
        cboLob.Items.Clear()
        populateComboBox(sql, cboLob)
    End Sub

    Private Sub populateTeams()
        Dim sql = "SELECT DISTINCT team_key from Areas WHERE lob = '" & cboLob.SelectedItem.ToString & "' ORDER BY team_key"
        cboTeam.Items.Clear()
        populateComboBox(sql, cboTeam)
    End Sub

    Private Sub cboLob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLob.SelectedIndexChanged
        grpCycleTimes.Visible = False
    End Sub

    Private Sub cboTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeam.SelectedIndexChanged
        grpCycleTimes.Visible = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvData.Rows.Count > 0 Then
            With frmEdit
                .pRecordType = RecordType.CycleTime
                .grpEdit.Text = "Edit Record"
                .btnUpdate.Text = "Update"
                .RecordType = dgvData.Rows(dgvData.CurrentCell.RowIndex).Cells(0).Value
                .calDate.Value = dgvData.Rows(dgvData.CurrentCell.RowIndex).Cells(1).Value
                .txtValue.Text = dgvData.Rows(dgvData.CurrentCell.RowIndex).Cells(2).Value
                .txtType.Text = cboCycleType.SelectedItem.ToString
                .txtLOB.Text = cboLob.SelectedItem.ToString
                .txtTeam.Text = cboTeam.SelectedItem.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmEdit
            .pRecordType = RecordType.CycleTime
            .grpEdit.Text = "Add Record"
            .btnUpdate.Text = "Add"
            .txtType.Text = cboCycleType.SelectedItem.ToString
            .txtLOB.Text = cboLob.SelectedItem.ToString
            .txtTeam.Text = cboTeam.SelectedItem.ToString
            .ShowDialog()
        End With
    End Sub

    Private Sub cboCycleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCycleType.SelectedIndexChanged
        Call loadCycleTimeTable()
    End Sub

    Private Sub btnChartData_Click(sender As Object, e As EventArgs) Handles btnChartData.Click
        Dim i As Integer
        Dim dp As DataPoint

        frmGraph.chtMetrics.Series.Clear()
        frmGraph.chtMetrics.Series.Add(grpCycleTimes.Text)
            frmGraph.chtMetrics.Series(grpCycleTimes.Text).ChartType = SeriesChartType.Column
            For i = 0 To dgvData.Rows.Count - 1 Step 1
                dp = New DataPoint
                dp.SetValueXY(dgvData.Rows(i).Cells(1).Value, dgvData.Rows(i).Cells(2).Value)
                frmGraph.chtMetrics.Series(0).Points.Add(dp)
                frmGraph.chtMetrics.ChartAreas(0).AxisX.IsReversed = True
            Next
        frmGraph.ShowDialog()
    End Sub

    Private Sub btnJsonTest_Click(sender As Object, e As EventArgs) Handles btnJsonTest.Click
        frmJson.ShowDialog()
    End Sub
End Class