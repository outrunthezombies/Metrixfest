<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.grpEdit = New System.Windows.Forms.GroupBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblLOB = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.calDate = New System.Windows.Forms.DateTimePicker()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.txtLOB = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.grpEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEdit
        '
        Me.grpEdit.Controls.Add(Me.lblTeam)
        Me.grpEdit.Controls.Add(Me.lblLOB)
        Me.grpEdit.Controls.Add(Me.btnCancel)
        Me.grpEdit.Controls.Add(Me.btnUpdate)
        Me.grpEdit.Controls.Add(Me.lblType)
        Me.grpEdit.Controls.Add(Me.lblValue)
        Me.grpEdit.Controls.Add(Me.lblDate)
        Me.grpEdit.Controls.Add(Me.calDate)
        Me.grpEdit.Controls.Add(Me.txtValue)
        Me.grpEdit.Controls.Add(Me.txtTeam)
        Me.grpEdit.Controls.Add(Me.txtLOB)
        Me.grpEdit.Controls.Add(Me.txtType)
        Me.grpEdit.Location = New System.Drawing.Point(12, 12)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Size = New System.Drawing.Size(345, 201)
        Me.grpEdit.TabIndex = 0
        Me.grpEdit.TabStop = False
        Me.grpEdit.Text = "Edit"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(43, 76)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(37, 13)
        Me.lblTeam.TabIndex = 14
        Me.lblTeam.Text = "Team:"
        '
        'lblLOB
        '
        Me.lblLOB.AutoSize = True
        Me.lblLOB.Location = New System.Drawing.Point(43, 50)
        Me.lblLOB.Name = "lblLOB"
        Me.lblLOB.Size = New System.Drawing.Size(31, 13)
        Me.lblLOB.TabIndex = 13
        Me.lblLOB.Text = "LOB:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(173, 157)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(76, 157)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(43, 22)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 10
        Me.lblType.Text = "Type:"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(43, 129)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(37, 13)
        Me.lblValue.TabIndex = 9
        Me.lblValue.Text = "Value:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(43, 106)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date:"
        '
        'calDate
        '
        Me.calDate.Location = New System.Drawing.Point(121, 100)
        Me.calDate.Name = "calDate"
        Me.calDate.Size = New System.Drawing.Size(200, 20)
        Me.calDate.TabIndex = 7
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(121, 126)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 5
        '
        'txtTeam
        '
        Me.txtTeam.Enabled = False
        Me.txtTeam.Location = New System.Drawing.Point(121, 73)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(100, 20)
        Me.txtTeam.TabIndex = 4
        '
        'txtLOB
        '
        Me.txtLOB.Enabled = False
        Me.txtLOB.Location = New System.Drawing.Point(121, 47)
        Me.txtLOB.Name = "txtLOB"
        Me.txtLOB.Size = New System.Drawing.Size(100, 20)
        Me.txtLOB.TabIndex = 3
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.Location = New System.Drawing.Point(121, 19)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 20)
        Me.txtType.TabIndex = 2
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 227)
        Me.Controls.Add(Me.grpEdit)
        Me.Name = "frmEdit"
        Me.Text = "Edit Cycle Time"
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpEdit As GroupBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents txtLOB As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents calDate As DateTimePicker
    Friend WithEvents lblType As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblLOB As Label
End Class
