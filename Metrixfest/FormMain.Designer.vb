<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnCycle = New System.Windows.Forms.Button()
        Me.GrpCycleTimes = New System.Windows.Forms.GroupBox()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.Index = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CycleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CycleTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.CboTeam = New System.Windows.Forms.ComboBox()
        Me.CboLob = New System.Windows.Forms.ComboBox()
        Me.CboCycleType = New System.Windows.Forms.ComboBox()
        Me.BtnChartData = New System.Windows.Forms.Button()
        Me.BtnJsonTest = New System.Windows.Forms.Button()
        Me.GrpCycleTimes.SuspendLayout()
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCycle
        '
        Me.BtnCycle.Location = New System.Drawing.Point(287, 12)
        Me.BtnCycle.Name = "BtnCycle"
        Me.BtnCycle.Size = New System.Drawing.Size(125, 21)
        Me.BtnCycle.TabIndex = 1
        Me.BtnCycle.Text = "Show Cycle Times"
        Me.BtnCycle.UseVisualStyleBackColor = True
        '
        'GrpCycleTimes
        '
        Me.GrpCycleTimes.Controls.Add(Me.DgvData)
        Me.GrpCycleTimes.Location = New System.Drawing.Point(12, 68)
        Me.GrpCycleTimes.Name = "GrpCycleTimes"
        Me.GrpCycleTimes.Size = New System.Drawing.Size(400, 216)
        Me.GrpCycleTimes.TabIndex = 3
        Me.GrpCycleTimes.TabStop = False
        Me.GrpCycleTimes.Text = "Cycle Times"
        Me.GrpCycleTimes.Visible = False
        '
        'DgvData
        '
        Me.DgvData.AllowUserToAddRows = False
        Me.DgvData.AllowUserToDeleteRows = False
        Me.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Index, Me.CycleDate, Me.CycleTime})
        Me.DgvData.Location = New System.Drawing.Point(6, 19)
        Me.DgvData.MultiSelect = False
        Me.DgvData.Name = "DgvData"
        Me.DgvData.ReadOnly = True
        Me.DgvData.Size = New System.Drawing.Size(388, 192)
        Me.DgvData.TabIndex = 7
        '
        'Index
        '
        Me.Index.HeaderText = "Index"
        Me.Index.Name = "Index"
        Me.Index.ReadOnly = True
        Me.Index.Visible = False
        '
        'CycleDate
        '
        Me.CycleDate.HeaderText = "Date"
        Me.CycleDate.Name = "CycleDate"
        Me.CycleDate.ReadOnly = True
        '
        'CycleTime
        '
        Me.CycleTime.HeaderText = "Cycle Time"
        Me.CycleTime.Name = "CycleTime"
        Me.CycleTime.ReadOnly = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(81, 39)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(63, 23)
        Me.BtnEdit.TabIndex = 9
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(150, 39)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(63, 23)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(12, 39)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(63, 23)
        Me.BtnAdd.TabIndex = 5
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'CboTeam
        '
        Me.CboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTeam.FormattingEnabled = True
        Me.CboTeam.Location = New System.Drawing.Point(204, 12)
        Me.CboTeam.Name = "CboTeam"
        Me.CboTeam.Size = New System.Drawing.Size(77, 21)
        Me.CboTeam.TabIndex = 4
        '
        'CboLob
        '
        Me.CboLob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLob.FormattingEnabled = True
        Me.CboLob.Location = New System.Drawing.Point(112, 12)
        Me.CboLob.Name = "CboLob"
        Me.CboLob.Size = New System.Drawing.Size(86, 21)
        Me.CboLob.TabIndex = 5
        '
        'CboCycleType
        '
        Me.CboCycleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCycleType.FormattingEnabled = True
        Me.CboCycleType.Location = New System.Drawing.Point(12, 12)
        Me.CboCycleType.Name = "CboCycleType"
        Me.CboCycleType.Size = New System.Drawing.Size(94, 21)
        Me.CboCycleType.TabIndex = 6
        '
        'BtnChartData
        '
        Me.BtnChartData.Location = New System.Drawing.Point(332, 39)
        Me.BtnChartData.Name = "BtnChartData"
        Me.BtnChartData.Size = New System.Drawing.Size(80, 23)
        Me.BtnChartData.TabIndex = 10
        Me.BtnChartData.Text = "Chart Data"
        Me.BtnChartData.UseVisualStyleBackColor = True
        '
        'BtnJsonTest
        '
        Me.BtnJsonTest.Location = New System.Drawing.Point(231, 39)
        Me.BtnJsonTest.Name = "BtnJsonTest"
        Me.BtnJsonTest.Size = New System.Drawing.Size(85, 23)
        Me.BtnJsonTest.TabIndex = 11
        Me.BtnJsonTest.Text = "JSON Test"
        Me.BtnJsonTest.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 293)
        Me.Controls.Add(Me.BtnJsonTest)
        Me.Controls.Add(Me.BtnChartData)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.CboCycleType)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.CboLob)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.CboTeam)
        Me.Controls.Add(Me.BtnCycle)
        Me.Controls.Add(Me.GrpCycleTimes)
        Me.Name = "FormMain"
        Me.Text = "Metrixfest Data Entry"
        Me.GrpCycleTimes.ResumeLayout(False)
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub cboLob_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboLob.SelectedValueChanged
        Call PopulateTeams()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call PopulateCycleTypes()
        Call PopulateLOB()
    End Sub

    Friend WithEvents BtnCycle As Button
    Friend WithEvents GrpCycleTimes As GroupBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents Index As DataGridViewTextBoxColumn
    Friend WithEvents CycleDate As DataGridViewTextBoxColumn
    Friend WithEvents CycleTime As DataGridViewTextBoxColumn
    Friend WithEvents BtnDelete As Button
    Friend WithEvents CboTeam As ComboBox
    Friend WithEvents CboLob As ComboBox
    Friend WithEvents CboCycleType As ComboBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnChartData As Button
    Friend WithEvents BtnJsonTest As Button
End Class
