<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Capturing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Capturing))
        Me.pb_lfinger = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_counter = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        CType(Me.pb_lfinger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_lfinger
        '
        Me.pb_lfinger.BackColor = System.Drawing.Color.White
        Me.pb_lfinger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_lfinger.Location = New System.Drawing.Point(12, 12)
        Me.pb_lfinger.Name = "pb_lfinger"
        Me.pb_lfinger.Size = New System.Drawing.Size(100, 127)
        Me.pb_lfinger.TabIndex = 0
        Me.pb_lfinger.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Status : Capturing ("
        '
        'lbl_counter
        '
        Me.lbl_counter.AutoSize = True
        Me.lbl_counter.Location = New System.Drawing.Point(224, 48)
        Me.lbl_counter.Name = "lbl_counter"
        Me.lbl_counter.Size = New System.Drawing.Size(13, 13)
        Me.lbl_counter.TabIndex = 1
        Me.lbl_counter.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "out of 4)"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(133, 115)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Capturing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 151)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_counter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pb_lfinger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Capturing"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        CType(Me.pb_lfinger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_lfinger As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_counter As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
End Class
