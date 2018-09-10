<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donors))
        Me.dgv_donors = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.donor_donation_stat = New MetroFramework.Controls.MetroLabel()
        Me.donor_region = New MetroFramework.Controls.MetroLabel()
        Me.donor_prov = New MetroFramework.Controls.MetroLabel()
        Me.donor_city = New MetroFramework.Controls.MetroLabel()
        Me.donor_brgy = New MetroFramework.Controls.MetroLabel()
        Me.donor_nostblk = New MetroFramework.Controls.MetroLabel()
        Me.donor_bdate = New MetroFramework.Controls.MetroLabel()
        Me.donor_gender = New MetroFramework.Controls.MetroLabel()
        Me.donor_fullname = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb_lfinger_ok = New System.Windows.Forms.PictureBox()
        Me.pb_rfinger_not_ok = New System.Windows.Forms.PictureBox()
        Me.pb_lfinger_not_ok = New System.Windows.Forms.PictureBox()
        Me.pb_rfinger_ok = New System.Windows.Forms.PictureBox()
        Me.dgv_donation_history = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_search_fname = New MetroFramework.Controls.MetroTextBox()
        Me.txt_search_lname = New MetroFramework.Controls.MetroTextBox()
        Me.mbtn_search = New MetroFramework.Controls.MetroButton()
        Me.mbtn_clear = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.enroll_lfinger = New MetroFramework.Controls.MetroButton()
        Me.verify_lfinger = New MetroFramework.Controls.MetroButton()
        Me.enroll_rfinger = New MetroFramework.Controls.MetroButton()
        Me.verify_rfinger = New MetroFramework.Controls.MetroButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.mbtn_searchfinger = New MetroFramework.Controls.MetroButton()
        Me.pb_picture = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_donors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_lfinger_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rfinger_not_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_lfinger_not_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_rfinger_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_donation_history, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_donors
        '
        Me.dgv_donors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_donors.Location = New System.Drawing.Point(23, 102)
        Me.dgv_donors.Name = "dgv_donors"
        Me.dgv_donors.Size = New System.Drawing.Size(674, 532)
        Me.dgv_donors.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.donor_donation_stat)
        Me.Panel1.Controls.Add(Me.donor_region)
        Me.Panel1.Controls.Add(Me.donor_prov)
        Me.Panel1.Controls.Add(Me.donor_city)
        Me.Panel1.Controls.Add(Me.donor_brgy)
        Me.Panel1.Controls.Add(Me.donor_nostblk)
        Me.Panel1.Controls.Add(Me.donor_bdate)
        Me.Panel1.Controls.Add(Me.donor_gender)
        Me.Panel1.Controls.Add(Me.donor_fullname)
        Me.Panel1.Controls.Add(Me.MetroLabel12)
        Me.Panel1.Controls.Add(Me.MetroLabel11)
        Me.Panel1.Controls.Add(Me.MetroLabel10)
        Me.Panel1.Controls.Add(Me.MetroLabel9)
        Me.Panel1.Controls.Add(Me.MetroLabel8)
        Me.Panel1.Controls.Add(Me.MetroLabel7)
        Me.Panel1.Controls.Add(Me.MetroLabel6)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Location = New System.Drawing.Point(722, 234)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 225)
        Me.Panel1.TabIndex = 6
        '
        'donor_donation_stat
        '
        Me.donor_donation_stat.AutoSize = True
        Me.donor_donation_stat.Location = New System.Drawing.Point(117, 192)
        Me.donor_donation_stat.Name = "donor_donation_stat"
        Me.donor_donation_stat.Size = New System.Drawing.Size(45, 19)
        Me.donor_donation_stat.TabIndex = 57
        Me.donor_donation_stat.Text = "Name"
        '
        'donor_region
        '
        Me.donor_region.AutoSize = True
        Me.donor_region.Location = New System.Drawing.Point(117, 163)
        Me.donor_region.Name = "donor_region"
        Me.donor_region.Size = New System.Drawing.Size(45, 19)
        Me.donor_region.TabIndex = 56
        Me.donor_region.Text = "Name"
        '
        'donor_prov
        '
        Me.donor_prov.AutoSize = True
        Me.donor_prov.Location = New System.Drawing.Point(117, 140)
        Me.donor_prov.Name = "donor_prov"
        Me.donor_prov.Size = New System.Drawing.Size(45, 19)
        Me.donor_prov.TabIndex = 55
        Me.donor_prov.Text = "Name"
        '
        'donor_city
        '
        Me.donor_city.AutoSize = True
        Me.donor_city.Location = New System.Drawing.Point(117, 117)
        Me.donor_city.Name = "donor_city"
        Me.donor_city.Size = New System.Drawing.Size(45, 19)
        Me.donor_city.TabIndex = 54
        Me.donor_city.Text = "Name"
        '
        'donor_brgy
        '
        Me.donor_brgy.AutoSize = True
        Me.donor_brgy.Location = New System.Drawing.Point(117, 94)
        Me.donor_brgy.Name = "donor_brgy"
        Me.donor_brgy.Size = New System.Drawing.Size(45, 19)
        Me.donor_brgy.TabIndex = 53
        Me.donor_brgy.Text = "Name"
        '
        'donor_nostblk
        '
        Me.donor_nostblk.AutoSize = True
        Me.donor_nostblk.Location = New System.Drawing.Point(117, 70)
        Me.donor_nostblk.Name = "donor_nostblk"
        Me.donor_nostblk.Size = New System.Drawing.Size(45, 19)
        Me.donor_nostblk.TabIndex = 52
        Me.donor_nostblk.Text = "Name"
        '
        'donor_bdate
        '
        Me.donor_bdate.AutoSize = True
        Me.donor_bdate.Location = New System.Drawing.Point(117, 48)
        Me.donor_bdate.Name = "donor_bdate"
        Me.donor_bdate.Size = New System.Drawing.Size(45, 19)
        Me.donor_bdate.TabIndex = 51
        Me.donor_bdate.Text = "Name"
        '
        'donor_gender
        '
        Me.donor_gender.AutoSize = True
        Me.donor_gender.Location = New System.Drawing.Point(117, 25)
        Me.donor_gender.Name = "donor_gender"
        Me.donor_gender.Size = New System.Drawing.Size(45, 19)
        Me.donor_gender.TabIndex = 50
        Me.donor_gender.Text = "Name"
        '
        'donor_fullname
        '
        Me.donor_fullname.AutoSize = True
        Me.donor_fullname.Location = New System.Drawing.Point(117, 3)
        Me.donor_fullname.Name = "donor_fullname"
        Me.donor_fullname.Size = New System.Drawing.Size(45, 19)
        Me.donor_fullname.TabIndex = 49
        Me.donor_fullname.Text = "Name"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(5, 192)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel12.TabIndex = 48
        Me.MetroLabel12.Text = "Status"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(3, 163)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel11.TabIndex = 47
        Me.MetroLabel11.Text = "Region"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(3, 140)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel10.TabIndex = 46
        Me.MetroLabel10.Text = "Province"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 117)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel9.TabIndex = 45
        Me.MetroLabel9.Text = "City/Municipality"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 94)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel8.TabIndex = 44
        Me.MetroLabel8.Text = "Barangay"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 70)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel7.TabIndex = 43
        Me.MetroLabel7.Text = "No./St./Blk."
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 48)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel6.TabIndex = 42
        Me.MetroLabel6.Text = "Date of Birth"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 25)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel5.TabIndex = 41
        Me.MetroLabel5.Text = "Gender"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 3)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel4.TabIndex = 40
        Me.MetroLabel4.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(722, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'pb_lfinger_ok
        '
        Me.pb_lfinger_ok.BackColor = System.Drawing.Color.Transparent
        Me.pb_lfinger_ok.Image = CType(resources.GetObject("pb_lfinger_ok.Image"), System.Drawing.Image)
        Me.pb_lfinger_ok.Location = New System.Drawing.Point(722, 585)
        Me.pb_lfinger_ok.Name = "pb_lfinger_ok"
        Me.pb_lfinger_ok.Size = New System.Drawing.Size(48, 48)
        Me.pb_lfinger_ok.TabIndex = 20
        Me.pb_lfinger_ok.TabStop = False
        Me.pb_lfinger_ok.Visible = False
        '
        'pb_rfinger_not_ok
        '
        Me.pb_rfinger_not_ok.BackColor = System.Drawing.Color.Transparent
        Me.pb_rfinger_not_ok.Image = CType(resources.GetObject("pb_rfinger_not_ok.Image"), System.Drawing.Image)
        Me.pb_rfinger_not_ok.Location = New System.Drawing.Point(908, 585)
        Me.pb_rfinger_not_ok.Name = "pb_rfinger_not_ok"
        Me.pb_rfinger_not_ok.Size = New System.Drawing.Size(48, 48)
        Me.pb_rfinger_not_ok.TabIndex = 26
        Me.pb_rfinger_not_ok.TabStop = False
        Me.pb_rfinger_not_ok.Visible = False
        '
        'pb_lfinger_not_ok
        '
        Me.pb_lfinger_not_ok.BackColor = System.Drawing.Color.Transparent
        Me.pb_lfinger_not_ok.Image = CType(resources.GetObject("pb_lfinger_not_ok.Image"), System.Drawing.Image)
        Me.pb_lfinger_not_ok.Location = New System.Drawing.Point(722, 585)
        Me.pb_lfinger_not_ok.Name = "pb_lfinger_not_ok"
        Me.pb_lfinger_not_ok.Size = New System.Drawing.Size(48, 48)
        Me.pb_lfinger_not_ok.TabIndex = 27
        Me.pb_lfinger_not_ok.TabStop = False
        Me.pb_lfinger_not_ok.Visible = False
        '
        'pb_rfinger_ok
        '
        Me.pb_rfinger_ok.BackColor = System.Drawing.Color.Transparent
        Me.pb_rfinger_ok.Image = CType(resources.GetObject("pb_rfinger_ok.Image"), System.Drawing.Image)
        Me.pb_rfinger_ok.Location = New System.Drawing.Point(908, 585)
        Me.pb_rfinger_ok.Name = "pb_rfinger_ok"
        Me.pb_rfinger_ok.Size = New System.Drawing.Size(48, 48)
        Me.pb_rfinger_ok.TabIndex = 28
        Me.pb_rfinger_ok.TabStop = False
        Me.pb_rfinger_ok.Visible = False
        '
        'dgv_donation_history
        '
        Me.dgv_donation_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_donation_history.Location = New System.Drawing.Point(722, 466)
        Me.dgv_donation_history.Name = "dgv_donation_history"
        Me.dgv_donation_history.Size = New System.Drawing.Size(356, 113)
        Me.dgv_donation_history.TabIndex = 29
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(931, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 64)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(22, 69)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel1.TabIndex = 33
        Me.MetroLabel1.Text = "First Name :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(214, 69)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "Last Name :"
        '
        'txt_search_fname
        '
        Me.txt_search_fname.Location = New System.Drawing.Point(108, 69)
        Me.txt_search_fname.Name = "txt_search_fname"
        Me.txt_search_fname.Size = New System.Drawing.Size(100, 23)
        Me.txt_search_fname.TabIndex = 35
        '
        'txt_search_lname
        '
        Me.txt_search_lname.Location = New System.Drawing.Point(298, 69)
        Me.txt_search_lname.Name = "txt_search_lname"
        Me.txt_search_lname.Size = New System.Drawing.Size(100, 23)
        Me.txt_search_lname.TabIndex = 36
        '
        'mbtn_search
        '
        Me.mbtn_search.Location = New System.Drawing.Point(437, 69)
        Me.mbtn_search.Name = "mbtn_search"
        Me.mbtn_search.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_search.TabIndex = 37
        Me.mbtn_search.Text = "Search"
        '
        'mbtn_clear
        '
        Me.mbtn_clear.Location = New System.Drawing.Point(518, 69)
        Me.mbtn_clear.Name = "mbtn_clear"
        Me.mbtn_clear.Size = New System.Drawing.Size(75, 23)
        Me.mbtn_clear.TabIndex = 38
        Me.mbtn_clear.Text = "Clear"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(763, 71)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel3.TabIndex = 39
        Me.MetroLabel3.Text = "Donor Profile"
        '
        'enroll_lfinger
        '
        Me.enroll_lfinger.Location = New System.Drawing.Point(776, 585)
        Me.enroll_lfinger.Name = "enroll_lfinger"
        Me.enroll_lfinger.Size = New System.Drawing.Size(110, 23)
        Me.enroll_lfinger.TabIndex = 40
        Me.enroll_lfinger.Text = "Enroll Left Finger"
        '
        'verify_lfinger
        '
        Me.verify_lfinger.Location = New System.Drawing.Point(776, 614)
        Me.verify_lfinger.Name = "verify_lfinger"
        Me.verify_lfinger.Size = New System.Drawing.Size(110, 23)
        Me.verify_lfinger.TabIndex = 41
        Me.verify_lfinger.Text = "Verify Left Finger"
        '
        'enroll_rfinger
        '
        Me.enroll_rfinger.Location = New System.Drawing.Point(968, 585)
        Me.enroll_rfinger.Name = "enroll_rfinger"
        Me.enroll_rfinger.Size = New System.Drawing.Size(110, 23)
        Me.enroll_rfinger.TabIndex = 42
        Me.enroll_rfinger.Text = "Enroll Right Finger"
        '
        'verify_rfinger
        '
        Me.verify_rfinger.Location = New System.Drawing.Point(968, 614)
        Me.verify_rfinger.Name = "verify_rfinger"
        Me.verify_rfinger.Size = New System.Drawing.Size(110, 23)
        Me.verify_rfinger.TabIndex = 43
        Me.verify_rfinger.Text = "Verify Right Finger"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1014, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'mbtn_searchfinger
        '
        Me.mbtn_searchfinger.Location = New System.Drawing.Point(599, 69)
        Me.mbtn_searchfinger.Name = "mbtn_searchfinger"
        Me.mbtn_searchfinger.Size = New System.Drawing.Size(98, 23)
        Me.mbtn_searchfinger.TabIndex = 45
        Me.mbtn_searchfinger.Text = "Verify Donor"
        '
        'pb_picture
        '
        Me.pb_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_picture.Location = New System.Drawing.Point(727, 104)
        Me.pb_picture.Name = "pb_picture"
        Me.pb_picture.Size = New System.Drawing.Size(182, 130)
        Me.pb_picture.TabIndex = 46
        Me.pb_picture.TabStop = False
        '
        'Donors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 653)
        Me.Controls.Add(Me.pb_picture)
        Me.Controls.Add(Me.mbtn_searchfinger)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.verify_rfinger)
        Me.Controls.Add(Me.enroll_rfinger)
        Me.Controls.Add(Me.verify_lfinger)
        Me.Controls.Add(Me.enroll_lfinger)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.mbtn_clear)
        Me.Controls.Add(Me.mbtn_search)
        Me.Controls.Add(Me.txt_search_lname)
        Me.Controls.Add(Me.txt_search_fname)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.dgv_donation_history)
        Me.Controls.Add(Me.pb_rfinger_ok)
        Me.Controls.Add(Me.pb_lfinger_not_ok)
        Me.Controls.Add(Me.pb_rfinger_not_ok)
        Me.Controls.Add(Me.pb_lfinger_ok)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_donors)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Donors"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Donor Status Verifier"
        CType(Me.dgv_donors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_lfinger_ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_rfinger_not_ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_lfinger_not_ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_rfinger_ok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_donation_history, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents dgv_donors As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pb_lfinger_ok As System.Windows.Forms.PictureBox
    Friend WithEvents pb_rfinger_not_ok As System.Windows.Forms.PictureBox
    Friend WithEvents pb_lfinger_not_ok As System.Windows.Forms.PictureBox
    Friend WithEvents pb_rfinger_ok As System.Windows.Forms.PictureBox
    Friend WithEvents dgv_donation_history As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_search_fname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_search_lname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mbtn_search As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtn_clear As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_donation_stat As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_region As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_prov As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_city As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_brgy As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_nostblk As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_bdate As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_gender As MetroFramework.Controls.MetroLabel
    Friend WithEvents donor_fullname As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents enroll_lfinger As MetroFramework.Controls.MetroButton
    Friend WithEvents verify_lfinger As MetroFramework.Controls.MetroButton
    Friend WithEvents enroll_rfinger As MetroFramework.Controls.MetroButton
    Friend WithEvents verify_rfinger As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents mbtn_searchfinger As MetroFramework.Controls.MetroButton
    Friend WithEvents pb_picture As System.Windows.Forms.PictureBox

End Class
