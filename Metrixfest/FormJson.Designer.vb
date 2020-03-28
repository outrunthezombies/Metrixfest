<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJson))
        Me.txtJson = New System.Windows.Forms.TextBox()
        Me.btnParse = New System.Windows.Forms.Button()
        Me.txtRates = New System.Windows.Forms.TextBox()
        Me.txtIssues = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtJson
        '
        Me.txtJson.Location = New System.Drawing.Point(12, 34)
        Me.txtJson.Multiline = True
        Me.txtJson.Name = "txtJson"
        Me.txtJson.Size = New System.Drawing.Size(472, 536)
        Me.txtJson.TabIndex = 0
        Me.txtJson.Text = resources.GetString("txtJson.Text")
        '
        'btnParse
        '
        Me.btnParse.Location = New System.Drawing.Point(490, 34)
        Me.btnParse.Name = "btnParse"
        Me.btnParse.Size = New System.Drawing.Size(75, 23)
        Me.btnParse.TabIndex = 1
        Me.btnParse.Text = "Parse"
        Me.btnParse.UseVisualStyleBackColor = True
        '
        'txtRates
        '
        Me.txtRates.Location = New System.Drawing.Point(490, 322)
        Me.txtRates.Multiline = True
        Me.txtRates.Name = "txtRates"
        Me.txtRates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRates.Size = New System.Drawing.Size(692, 248)
        Me.txtRates.TabIndex = 2
        '
        'txtIssues
        '
        Me.txtIssues.Location = New System.Drawing.Point(490, 63)
        Me.txtIssues.Multiline = True
        Me.txtIssues.Name = "txtIssues"
        Me.txtIssues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIssues.Size = New System.Drawing.Size(692, 253)
        Me.txtIssues.TabIndex = 3
        '
        'frmJson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 604)
        Me.Controls.Add(Me.txtIssues)
        Me.Controls.Add(Me.txtRates)
        Me.Controls.Add(Me.btnParse)
        Me.Controls.Add(Me.txtJson)
        Me.Name = "frmJson"
        Me.Text = "JSON Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtJson As TextBox
    Friend WithEvents btnParse As Button
    Friend WithEvents txtRates As TextBox
    Friend WithEvents txtIssues As TextBox
End Class
