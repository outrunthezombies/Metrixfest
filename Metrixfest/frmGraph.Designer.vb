<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cboChartType = New System.Windows.Forms.ComboBox()
        Me.chtMetrics = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chtMetrics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboChartType
        '
        Me.cboChartType.FormattingEnabled = True
        Me.cboChartType.Items.AddRange(New Object() {"Bar", "Pie", "Line"})
        Me.cboChartType.Location = New System.Drawing.Point(1057, 12)
        Me.cboChartType.Name = "cboChartType"
        Me.cboChartType.Size = New System.Drawing.Size(77, 21)
        Me.cboChartType.TabIndex = 3
        '
        'chtMetrics
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtMetrics.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtMetrics.Legends.Add(Legend1)
        Me.chtMetrics.Location = New System.Drawing.Point(12, 12)
        Me.chtMetrics.Name = "chtMetrics"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtMetrics.Series.Add(Series1)
        Me.chtMetrics.Size = New System.Drawing.Size(1028, 536)
        Me.chtMetrics.TabIndex = 2
        Me.chtMetrics.Text = "Chart for Metrics"
        '
        'frmGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 565)
        Me.Controls.Add(Me.cboChartType)
        Me.Controls.Add(Me.chtMetrics)
        Me.Name = "frmGraph"
        Me.Text = "Metrics"
        CType(Me.chtMetrics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboChartType As ComboBox
    Friend WithEvents chtMetrics As DataVisualization.Charting.Chart
End Class
