<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
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
        Me.GrpEdit = New System.Windows.Forms.GroupBox()
        Me.LblTeam = New System.Windows.Forms.Label()
        Me.LblLOB = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.LblType = New System.Windows.Forms.Label()
        Me.LblValue = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.CalDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtValue = New System.Windows.Forms.TextBox()
        Me.TxtTeam = New System.Windows.Forms.TextBox()
        Me.TxtLOB = New System.Windows.Forms.TextBox()
        Me.TxtType = New System.Windows.Forms.TextBox()
        Me.GrpEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpEdit
        '
        Me.GrpEdit.Controls.Add(Me.LblTeam)
        Me.GrpEdit.Controls.Add(Me.LblLOB)
        Me.GrpEdit.Controls.Add(Me.BtnCancel)
        Me.GrpEdit.Controls.Add(Me.BtnUpdate)
        Me.GrpEdit.Controls.Add(Me.LblType)
        Me.GrpEdit.Controls.Add(Me.LblValue)
        Me.GrpEdit.Controls.Add(Me.LblDate)
        Me.GrpEdit.Controls.Add(Me.CalDate)
        Me.GrpEdit.Controls.Add(Me.TxtValue)
        Me.GrpEdit.Controls.Add(Me.TxtTeam)
        Me.GrpEdit.Controls.Add(Me.TxtLOB)
        Me.GrpEdit.Controls.Add(Me.TxtType)
        Me.GrpEdit.Location = New System.Drawing.Point(12, 12)
        Me.GrpEdit.Name = "GrpEdit"
        Me.GrpEdit.Size = New System.Drawing.Size(345, 201)
        Me.GrpEdit.TabIndex = 0
        Me.GrpEdit.TabStop = False
        Me.GrpEdit.Text = "Edit"
        '
        'LblTeam
        '
        Me.LblTeam.AutoSize = True
        Me.LblTeam.Location = New System.Drawing.Point(43, 76)
        Me.LblTeam.Name = "LblTeam"
        Me.LblTeam.Size = New System.Drawing.Size(37, 13)
        Me.LblTeam.TabIndex = 14
        Me.LblTeam.Text = "Team:"
        '
        'LblLOB
        '
        Me.LblLOB.AutoSize = True
        Me.LblLOB.Location = New System.Drawing.Point(43, 50)
        Me.LblLOB.Name = "LblLOB"
        Me.LblLOB.Size = New System.Drawing.Size(31, 13)
        Me.LblLOB.TabIndex = 13
        Me.LblLOB.Text = "LOB:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(173, 157)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(76, 157)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Location = New System.Drawing.Point(43, 22)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(34, 13)
        Me.LblType.TabIndex = 10
        Me.LblType.Text = "Type:"
        '
        'LblValue
        '
        Me.LblValue.AutoSize = True
        Me.LblValue.Location = New System.Drawing.Point(43, 129)
        Me.LblValue.Name = "LblValue"
        Me.LblValue.Size = New System.Drawing.Size(37, 13)
        Me.LblValue.TabIndex = 9
        Me.LblValue.Text = "Value:"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(43, 106)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(33, 13)
        Me.LblDate.TabIndex = 8
        Me.LblDate.Text = "Date:"
        '
        'CalDate
        '
        Me.CalDate.Location = New System.Drawing.Point(121, 100)
        Me.CalDate.Name = "CalDate"
        Me.CalDate.Size = New System.Drawing.Size(200, 20)
        Me.CalDate.TabIndex = 7
        '
        'TxtValue
        '
        Me.TxtValue.Location = New System.Drawing.Point(121, 126)
        Me.TxtValue.Name = "TxtValue"
        Me.TxtValue.Size = New System.Drawing.Size(100, 20)
        Me.TxtValue.TabIndex = 5
        '
        'TxtTeam
        '
        Me.TxtTeam.Enabled = False
        Me.TxtTeam.Location = New System.Drawing.Point(121, 73)
        Me.TxtTeam.Name = "TxtTeam"
        Me.TxtTeam.Size = New System.Drawing.Size(100, 20)
        Me.TxtTeam.TabIndex = 4
        '
        'TxtLOB
        '
        Me.TxtLOB.Enabled = False
        Me.TxtLOB.Location = New System.Drawing.Point(121, 47)
        Me.TxtLOB.Name = "TxtLOB"
        Me.TxtLOB.Size = New System.Drawing.Size(100, 20)
        Me.TxtLOB.TabIndex = 3
        '
        'TxtType
        '
        Me.TxtType.Enabled = False
        Me.TxtType.Location = New System.Drawing.Point(121, 19)
        Me.TxtType.Name = "TxtType"
        Me.TxtType.Size = New System.Drawing.Size(100, 20)
        Me.TxtType.TabIndex = 2
        '
        'FormEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 227)
        Me.Controls.Add(Me.GrpEdit)
        Me.Name = "FormEdit"
        Me.Text = "Edit Cycle Time"
        Me.GrpEdit.ResumeLayout(False)
        Me.GrpEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrpEdit As GroupBox
    Friend WithEvents TxtValue As TextBox
    Friend WithEvents TxtTeam As TextBox
    Friend WithEvents TxtLOB As TextBox
    Friend WithEvents TxtType As TextBox
    Friend WithEvents CalDate As DateTimePicker
    Friend WithEvents LblType As Label
    Friend WithEvents LblValue As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents LblTeam As Label
    Friend WithEvents LblLOB As Label
End Class
