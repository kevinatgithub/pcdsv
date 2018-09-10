<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verify_Donor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verify_Donor))
        Me.pb_finger = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_finger = New System.Windows.Forms.Label()
        Me.pb_success = New System.Windows.Forms.PictureBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.pb_invalid = New System.Windows.Forms.PictureBox()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.pb_finger,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_success,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pb_invalid,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pb_finger
        '
        Me.pb_finger.BackColor = System.Drawing.Color.White
        Me.pb_finger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_finger.Location = New System.Drawing.Point(12, 12)
        Me.pb_finger.Name = "pb_finger"
        Me.pb_finger.Size = New System.Drawing.Size(100, 127)
        Me.pb_finger.TabIndex = 1
        Me.pb_finger.TabStop = false
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(118, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Verify Blood Donor's"
        '
        'lbl_finger
        '
        Me.lbl_finger.AutoSize = true
        Me.lbl_finger.Location = New System.Drawing.Point(217, 23)
        Me.lbl_finger.Name = "lbl_finger"
        Me.lbl_finger.Size = New System.Drawing.Size(57, 13)
        Me.lbl_finger.TabIndex = 3
        Me.lbl_finger.Text = "Left Finger"
        '
        'pb_success
        '
        Me.pb_success.Image = CType(resources.GetObject("pb_success.Image"),System.Drawing.Image)
        Me.pb_success.Location = New System.Drawing.Point(121, 58)
        Me.pb_success.Name = "pb_success"
        Me.pb_success.Size = New System.Drawing.Size(48, 48)
        Me.pb_success.TabIndex = 4
        Me.pb_success.TabStop = false
        Me.pb_success.Visible = false
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = true
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_status.Location = New System.Drawing.Point(175, 68)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(84, 24)
        Me.lbl_status.TabIndex = 5
        Me.lbl_status.Text = "STATUS"
        Me.lbl_status.Visible = false
        '
        'pb_invalid
        '
        Me.pb_invalid.Image = CType(resources.GetObject("pb_invalid.Image"),System.Drawing.Image)
        Me.pb_invalid.Location = New System.Drawing.Point(121, 58)
        Me.pb_invalid.Name = "pb_invalid"
        Me.pb_invalid.Size = New System.Drawing.Size(48, 48)
        Me.pb_invalid.TabIndex = 6
        Me.pb_invalid.TabStop = false
        Me.pb_invalid.Visible = false
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(121, 116)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 7
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = true
        '
        'Verify_Donor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 151)
        Me.ControlBox = false
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.pb_invalid)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.pb_success)
        Me.Controls.Add(Me.lbl_finger)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pb_finger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Verify_Donor"
        Me.Style = MetroFramework.MetroColorStyle.Lime
        CType(Me.pb_finger,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_success,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pb_invalid,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pb_finger As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_finger As System.Windows.Forms.Label
    Friend WithEvents pb_success As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents pb_invalid As System.Windows.Forms.PictureBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
End Class
