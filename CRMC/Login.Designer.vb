<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.mbtn_login = New MetroFramework.Controls.MetroButton()
        Me.mbtn_cancel = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mtxt_user_id = New MetroFramework.Controls.MetroTextBox()
        Me.mtxt_pword = New MetroFramework.Controls.MetroTextBox()
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 68)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'mbtn_login
        '
        Me.mbtn_login.Location = New System.Drawing.Point(210, 138)
        Me.mbtn_login.Name = "mbtn_login"
        Me.mbtn_login.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_login.TabIndex = 2
        Me.mbtn_login.Text = "Login"
        '
        'mbtn_cancel
        '
        Me.mbtn_cancel.Location = New System.Drawing.Point(301, 138)
        Me.mbtn_cancel.Name = "mbtn_cancel"
        Me.mbtn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_cancel.TabIndex = 3
        Me.mbtn_cancel.Text = "Cancel"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(122, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel1.TabIndex = 10
        Me.MetroLabel1.Text = "User Name :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(122, 100)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 11
        Me.MetroLabel2.Text = "Password :"
        '
        'mtxt_user_id
        '
        Me.mtxt_user_id.Location = New System.Drawing.Point(210, 63)
        Me.mtxt_user_id.Name = "mtxt_user_id"
        Me.mtxt_user_id.Size = New System.Drawing.Size(166, 23)
        Me.mtxt_user_id.TabIndex = 0
        '
        'mtxt_pword
        '
        Me.mtxt_pword.Location = New System.Drawing.Point(210, 100)
        Me.mtxt_pword.Name = "mtxt_pword"
        Me.mtxt_pword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtxt_pword.Size = New System.Drawing.Size(166, 23)
        Me.mtxt_pword.TabIndex = 1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 179)
        Me.Controls.Add(Me.mtxt_pword)
        Me.Controls.Add(Me.mtxt_user_id)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.mbtn_cancel)
        Me.Controls.Add(Me.mbtn_login)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Log On"
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents mbtn_login As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtxt_user_id As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtxt_pword As MetroFramework.Controls.MetroTextBox
End Class
