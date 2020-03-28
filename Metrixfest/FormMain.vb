Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormMain
    Private sqlCycleTimes = "SELECT ID,cycle_date,days From Cycle_Time"
    Private sqlDeleteCycleTime = "DELETE FROM Cycle_Time WHERE id="

    Public Sub LoadCycleTimeTable()
        GrpCycleTimes.Visible = False

        If CboLob.SelectedIndex > -1 And CboTeam.SelectedIndex > -1 And CboCycleType.SelectedIndex > -1 Then
            GrpCycleTimes.Text = StrConv("Cycle: " & Replace(CboCycleType.Text, "_", " "), VbStrConv.ProperCase)
            Call LoadCycleTimes()
            GrpCycleTimes.Visible = True
        End If
    End Sub

    Private Sub BtnCycle_Click(sender As Object, e As EventArgs) Handles BtnCycle.Click
        Call LoadCycleTimeTable()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim sRowinfo As String
        Dim iResponse As Integer
        Dim iDBIndex As Integer

        If DgvData.Rows.Count > 0 Then
            With DgvData
                iDBIndex = .Rows(.CurrentCell.RowIndex).Cells(0).Value
                sRowinfo = "Delete Row: " & vbCrLf & vbCrLf & "For Date: " & vbCrLf &
            .Rows(.CurrentCell.RowIndex).Cells(1).Value & vbCrLf &
            "With Value: " & .Rows(.CurrentCell.RowIndex).Cells(2).Value
            End With

            iResponse = MsgBox(sRowinfo, vbYesNoCancel, "Are you sure you want to delete this row?")

            Select Case iResponse
                Case vbYes
                    If DeleteCycleTime(iDBIndex) Then
                        MsgBox("Deleted")
                    Else
                        MsgBox("Not Complete")
                    End If
                    Call LoadCycleTimes()
                Case vbNo
                    MsgBox("Aborted")
            End Select
        Else
            MsgBox("No available data")
        End If
    End Sub

    Private Function DeleteCycleTime(index As Integer) As Boolean
        Try
            If OpenDBConnection(sqlDeleteCycleTime & index.ToString) Then oOleDbCommand.ExecuteReader()
        Catch ex As Exception
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in deleteCycleTime-->openDBConnection with" & sqlDeleteCycleTime & index.ToString)
            Return vbFalse
        Finally
            Call CloseDBConnection()
        End Try
        Return vbTrue
    End Function

    Private Sub LoadCycleTimes()
        Dim sql As String

        sql = sqlCycleTimes & " WHERE lob = """ & CboLob.SelectedItem.ToString() &
            """ AND team_key = """ & CboTeam.SelectedItem.ToString() &
            """ AND cycle_type = """ & CboCycleType.SelectedItem.ToString() &
            """ ORDER BY cycle_date DESC"
        Debug.Print("loadCycleTimes(): SQL: " & sql)
        DgvData.Rows.Clear()

        Try
            If OpenDBConnection(sql) Then

                oOleDbDataReader = oOleDbCommand.ExecuteReader()

                Do While oOleDbDataReader.Read()
                    Dim str(oOleDbDataReader.FieldCount - 1) As String
                    For i = 0 To oOleDbDataReader.FieldCount - 1 Step 1
                        str(i) = oOleDbDataReader.GetValue(i)
                    Next
                    Me.DgvData.Rows.Add(str)
                Loop

                oOleDbDataReader.Close()

            End If
        Catch ex As Exception
            MsgBox("Function failed, check logs")
            My.Application.Log.WriteException(ex, TraceEventType.Error, "Exception in loadCycleTime")
        Finally
            oOleDbDataReader = Nothing

            Call CloseDBConnection()
        End Try
    End Sub

    Private Sub PopulateComboBox(ByRef sql As String, ByRef cbo As ComboBox)
        Try
            If OpenDBConnection(sql) Then

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

            Call CloseDBConnection()
        End Try
    End Sub

    Private Sub PopulateCycleTypes()
        Dim sql = "SELECT DISTINCT cycle_type from Cycle_Types ORDER BY cycle_type"
        CboCycleType.Items.Clear()
        PopulateComboBox(sql, CboCycleType)
    End Sub

    Private Sub PopulateLOB()
        Dim sql = "SELECT DISTINCT lob from Areas ORDER BY lob"
        CboLob.Items.Clear()
        PopulateComboBox(sql, CboLob)
    End Sub

    Private Sub PopulateTeams()
        Dim sql = "SELECT DISTINCT team_key from Areas WHERE lob = '" & CboLob.SelectedItem.ToString & "' ORDER BY team_key"
        CboTeam.Items.Clear()
        PopulateComboBox(sql, CboTeam)
    End Sub

    Private Sub CboLob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboLob.SelectedIndexChanged
        GrpCycleTimes.Visible = False
    End Sub

    Private Sub CboTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTeam.SelectedIndexChanged
        GrpCycleTimes.Visible = False
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If DgvData.Rows.Count > 0 Then
            With FormEdit
                .pRecordType = RecordType.CycleTime
                .GrpEdit.Text = "Edit Record"
                .BtnUpdate.Text = "Update"
                .RecordType = DgvData.Rows(DgvData.CurrentCell.RowIndex).Cells(0).Value
                .CalDate.Value = DgvData.Rows(DgvData.CurrentCell.RowIndex).Cells(1).Value
                .TxtValue.Text = DgvData.Rows(DgvData.CurrentCell.RowIndex).Cells(2).Value
                .TxtType.Text = CboCycleType.SelectedItem.ToString
                .TxtLOB.Text = CboLob.SelectedItem.ToString
                .TxtTeam.Text = CboTeam.SelectedItem.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        With FormEdit
            .pRecordType = RecordType.CycleTime
            .GrpEdit.Text = "Add Record"
            .BtnUpdate.Text = "Add"
            .TxtType.Text = CboCycleType.SelectedItem.ToString
            .TxtLOB.Text = CboLob.SelectedItem.ToString
            .TxtTeam.Text = CboTeam.SelectedItem.ToString
            .ShowDialog()
        End With
    End Sub

    Private Sub CboCycleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCycleType.SelectedIndexChanged
        Call LoadCycleTimeTable()
    End Sub

    Private Sub BtnChartData_Click(sender As Object, e As EventArgs) Handles BtnChartData.Click
        Dim dp As DataPoint

        frmGraph.chtMetrics.Series.Clear()
        frmGraph.chtMetrics.Series.Add(GrpCycleTimes.Text)
        frmGraph.chtMetrics.Series(GrpCycleTimes.Text).ChartType = SeriesChartType.Column
        For i = 0 To DgvData.Rows.Count - 1 Step 1
            dp = New DataPoint
            dp.SetValueXY(DgvData.Rows(i).Cells(1).Value, DgvData.Rows(i).Cells(2).Value)
            frmGraph.chtMetrics.Series(0).Points.Add(dp)
            frmGraph.chtMetrics.ChartAreas(0).AxisX.IsReversed = True
        Next
        frmGraph.ShowDialog()
    End Sub

    Private Sub BtnJsonTest_Click(sender As Object, e As EventArgs) Handles BtnJsonTest.Click
        FormJson.ShowDialog()
    End Sub
End Class