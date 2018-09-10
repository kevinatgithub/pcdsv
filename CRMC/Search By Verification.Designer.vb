<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_By_Verification
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_By_Verification))
        Me.pb_finger = New System.Windows.Forms.PictureBox()
        Me.lbl_scanning = New MetroFramework.Controls.MetroLabel()
        Me.lbl_progress = New MetroFramework.Controls.MetroLabel()
        Me.lbl_templates = New MetroFramework.Controls.MetroLabel()
        Me.lbl_status = New System.Windows.Forms.Label()
        CType(Me.pb_finger,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pb_finger
        '
        Me.pb_finger.BackColor = System.Drawing.Color.White
        Me.pb_finger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_finger.Location = New System.Drawing.Point(8, 13)
        Me.pb_finger.Name = "pb_finger"
        Me.pb_finger.Size = New System.Drawing.Size(100, 110)
        Me.pb_finger.TabIndex = 2
        Me.pb_finger.TabStop = false
        '
        'lbl_scanning
        '
        Me.lbl_scanning.AutoSize = true
        Me.lbl_scanning.Location = New System.Drawing.Point(114, 24)
        Me.lbl_scanning.Name = "lbl_scanning"
        Me.lbl_scanning.Size = New System.Drawing.Size(61, 19)
        Me.lbl_scanning.TabIndex = 3
        Me.lbl_scanning.Text = "Scanning"
        Me.lbl_scanning.Visible = false
        '
        'lbl_progress
        '
        Me.lbl_progress.AutoSize = true
        Me.lbl_progress.Location = New System.Drawing.Point(114, 43)
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(16, 19)
        Me.lbl_progress.TabIndex = 4
        Me.lbl_progress.Text = "0"
        Me.lbl_progress.Visible = false
        '
        'lbl_templates
        '
        Me.lbl_templates.AutoSize = true
        Me.lbl_templates.Location = New System.Drawing.Point(136, 43)
        Me.lbl_templates.Name = "lbl_templates"
        Me.lbl_templates.Size = New System.Drawing.Size(58, 19)
        Me.lbl_templates.TabIndex = 5
        Me.lbl_templates.Text = "Out of 0"
        Me.lbl_templates.Visible = false
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = true
        Me.lbl_status.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_status.Location = New System.Drawing.Point(114, 60)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(0, 26)
        Me.lbl_status.TabIndex = 6
        '
        'Search_By_Verification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 133)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.lbl_templates)
        Me.Controls.Add(Me.lbl_progress)
        Me.Controls.Add(Me.lbl_scanning)
        Me.Controls.Add(Me.pb_finger)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Search_By_Verification"
        Me.Resizable = false
        CType(Me.pb_finger,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pb_finger As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_scanning As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_progress As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_templates As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_status As System.Windows.Forms.Label
End Class
