<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verify
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
        Me.SuspendLayout()
        '
        'lbl_seqno
        '
        Me.lbl_seqno.AutoSize = True
        Me.lbl_seqno.Location = New System.Drawing.Point(51, 70)
        Me.lbl_seqno.Name = "lbl_seqno"
        Me.lbl_seqno.Size = New System.Drawing.Size(39, 13)
        Me.lbl_seqno.TabIndex = 0
        Me.lbl_seqno.Text = "Label1"
        '
        'Verify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 504)
        Me.Controls.Add(Me.lbl_seqno)
        Me.Name = "Verify"
        Me.Text = "Verify"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_seqno As System.Windows.Forms.Label
End Class
