<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnCycle = New System.Windows.Forms.Button()
        Me.grpCycleTimes = New System.Windows.Forms.GroupBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Index = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CycleDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CycleTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboTeam = New System.Windows.Forms.ComboBox()
        Me.cboLob = New System.Windows.Forms.ComboBox()
        Me.cboCycleType = New System.Windows.Forms.ComboBox()
        Me.btnChartData = New System.Windows.Forms.Button()
        Me.btnJsonTest = New System.Windows.Forms.Button()
        Me.grpCycleTimes.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCycle
        '
        Me.btnCycle.Location = New System.Drawing.Point(287, 12)
        Me.btnCycle.Name = "btnCycle"
        Me.btnCycle.Size = New System.Drawing.Size(125, 21)
        Me.btnCycle.TabIndex = 1
        Me.btnCycle.Text = "Show Cycle Times"
        Me.btnCycle.UseVisualStyleBackColor = True
        '
        'grpCycleTimes
        '
        Me.grpCycleTimes.Controls.Add(Me.dgvData)
        Me.grpCycleTimes.Location = New System.Drawing.Point(12, 68)
        Me.grpCycleTimes.Name = "grpCycleTimes"
        Me.grpCycleTimes.Size = New System.Drawing.Size(400, 216)
        Me.grpCycleTimes.TabIndex = 3
        Me.grpCycleTimes.TabStop = False
        Me.grpCycleTimes.Text = "Cycle Times"
        Me.grpCycleTimes.Visible = False
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Index, Me.CycleDate, Me.CycleTime})
        Me.dgvData.Location = New System.Drawing.Point(6, 19)
        Me.dgvData.MultiSelect = False
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(388, 192)
        Me.dgvData.TabIndex = 7
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
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(81, 39)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(63, 23)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(150, 39)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 39)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(63, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboTeam
        '
        Me.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeam.FormattingEnabled = True
        Me.cboTeam.Location = New System.Drawing.Point(204, 12)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(77, 21)
        Me.cboTeam.TabIndex = 4
        '
        'cboLob
        '
        Me.cboLob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLob.FormattingEnabled = True
        Me.cboLob.Location = New System.Drawing.Point(112, 12)
        Me.cboLob.Name = "cboLob"
        Me.cboLob.Size = New System.Drawing.Size(86, 21)
        Me.cboLob.TabIndex = 5
        '
        'cboCycleType
        '
        Me.cboCycleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCycleType.FormattingEnabled = True
        Me.cboCycleType.Location = New System.Drawing.Point(12, 12)
        Me.cboCycleType.Name = "cboCycleType"
        Me.cboCycleType.Size = New System.Drawing.Size(94, 21)
        Me.cboCycleType.TabIndex = 6
        '
        'btnChartData
        '
        Me.btnChartData.Location = New System.Drawing.Point(332, 39)
        Me.btnChartData.Name = "btnChartData"
        Me.btnChartData.Size = New System.Drawing.Size(80, 23)
        Me.btnChartData.TabIndex = 10
        Me.btnChartData.Text = "Chart Data"
        Me.btnChartData.UseVisualStyleBackColor = True
        '
        'btnJsonTest
        '
        Me.btnJsonTest.Location = New System.Drawing.Point(231, 39)
        Me.btnJsonTest.Name = "btnJsonTest"
        Me.btnJsonTest.Size = New System.Drawing.Size(85, 23)
        Me.btnJsonTest.TabIndex = 11
        Me.btnJsonTest.Text = "JSON Test"
        Me.btnJsonTest.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 293)
        Me.Controls.Add(Me.btnJsonTest)
        Me.Controls.Add(Me.btnChartData)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.cboCycleType)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboLob)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboTeam)
        Me.Controls.Add(Me.btnCycle)
        Me.Controls.Add(Me.grpCycleTimes)
        Me.Name = "frmMain"
        Me.Text = "Metrixfest Data Entry"
        Me.grpCycleTimes.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub cboLob_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLob.SelectedValueChanged
        Call populateTeams()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call populateCycleTypes()
        Call populateLOB()
    End Sub

    Friend WithEvents btnCycle As Button
    Friend WithEvents grpCycleTimes As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Index As DataGridViewTextBoxColumn
    Friend WithEvents CycleDate As DataGridViewTextBoxColumn
    Friend WithEvents CycleTime As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
    Friend WithEvents cboTeam As ComboBox
    Friend WithEvents cboLob As ComboBox
    Friend WithEvents cboCycleType As ComboBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnChartData As Button
    Friend WithEvents btnJsonTest As Button
End Class
