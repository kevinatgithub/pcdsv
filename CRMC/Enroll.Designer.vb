<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enroll
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
        Me.lbl_seqno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.lbl_mname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_lfinger = New System.Windows.Forms.Button()
        Me.btn_rfinger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_seqno
        '
        Me.lbl_seqno.AutoSize = True
        Me.lbl_seqno.Location = New System.Drawing.Point(129, 21)
        Me.lbl_seqno.Name = "lbl_seqno"
        Me.lbl_seqno.Size = New System.Drawing.Size(39, 13)
        Me.lbl_seqno.TabIndex = 0
        Me.lbl_seqno.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First"
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Location = New System.Drawing.Point(129, 50)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(39, 13)
        Me.lbl_fname.TabIndex = 2
        Me.lbl_fname.Text = "Label2"
        '
        'lbl_mname
        '
        Me.lbl_mname.AutoSize = True
        Me.lbl_mname.Location = New System.Drawing.Point(129, 81)
        Me.lbl_mname.Name = "lbl_mname"
        Me.lbl_mname.Size = New System.Drawing.Size(39, 13)
        Me.lbl_mname.TabIndex = 4
        Me.lbl_mname.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Middle"
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Location = New System.Drawing.Point(129, 112)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(39, 13)
        Me.lbl_lname.TabIndex = 6
        Me.lbl_lname.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Last"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sequence No"
        '
        'btn_lfinger
        '
        Me.btn_lfinger.Location = New System.Drawing.Point(39, 153)
        Me.btn_lfinger.Name = "btn_lfinger"
        Me.btn_lfinger.Size = New System.Drawing.Size(128, 23)
        Me.btn_lfinger.TabIndex = 7
        Me.btn_lfinger.Text = "Scan Left Finger"
        Me.btn_lfinger.UseVisualStyleBackColor = True
        '
        'btn_rfinger
        '
        Me.btn_rfinger.Location = New System.Drawing.Point(184, 153)
        Me.btn_rfinger.Name = "btn_rfinger"
        Me.btn_rfinger.Size = New System.Drawing.Size(128, 23)
        Me.btn_rfinger.TabIndex = 8
        Me.btn_rfinger.Text = "Scan Right Finger"
        Me.btn_rfinger.UseVisualStyleBackColor = True
        '
        'Enroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 220)
        Me.Controls.Add(Me.btn_rfinger)
        Me.Controls.Add(Me.btn_lfinger)
        Me.Controls.Add(Me.lbl_lname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_mname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_seqno)
        Me.Name = "Enroll"
        Me.Text = "Enroll"
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents lbl_seqno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_fname As System.Windows.Forms.Label
    Friend WithEvents lbl_mname As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_lname As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_lfinger As System.Windows.Forms.Button
    Friend WithEvents btn_rfinger As System.Windows.Forms.Button
End Class
