Imports MySql.Data.MySqlClient

Delegate Sub FunctionCall(ByVal param)

Public Class Donors
    Inherits MetroFramework.Forms.MetroForm

    Private db As Database

    Public adapter As MySqlDataAdapter = Nothing

    Public CurDonor As New _Donor

    Public SearchByScan As Search_By_Verification

    Public Sub New()

        InitializeComponent()
        refreshList()
        addButtonsToRows()

        dgv_donors.Columns(0).Visible = False   'Hide Seqno Column
        dgv_donors.Columns(6).Width = 30    'Adjust Left Finger Column Size
        dgv_donors.Columns(7).Width = 30    'Adjust Right Finger Column Size



        refreshDonorInformationPanel()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New Database

    End Sub

    Public fields As String = "seqno as 'Donor ID', fname as 'First Name', mname as 'Middle Name', lname as 'Last Name', `gender` as 'Gender', DATE_FORMAT(bdate, '%d/%m/%Y') as 'Birth Date', IF(lfinger IS NOT NULL, 'Yes', '') as 'Left', IF(rfinger IS NOT NULL, 'Yes', '') as 'Right'"

    Public Sub refreshList()
        adapter = Database.db.executeDataSet("SELECT " & Me.fields & " from donor WHERE 1 = 0")
        doRefreshList()
    End Sub

    Public Sub refreshList(filter As String)
        Dim cmd As String = "SELECT " & Me.fields & " from donor WHERE " & filter
        adapter = Database.db.executeDataSet(cmd)
        doRefreshList()
    End Sub

    Public Sub refreshListWithFilter()

        If txt_search_fname.Text.Length > 0 Or txt_search_lname.Text.Length > 0 Then
            Dim filters(1) As String
            If txt_search_fname.Text.Length > 0 Then
                filters(0) = " fname like '%" & txt_search_fname.Text & "%' "
            Else
                filters(0) = "1 = 1"
            End If
            If txt_search_lname.Text.Length > 0 Then
                filters(1) = " lname like '%" & txt_search_lname.Text & "%' "
            Else
                filters(1) = "1 = 1"
            End If
            Dim filter As String = String.Join(" AND ", filters)
            refreshList(filter)
        End If
    End Sub

    Public Sub doRefreshList()


        Dim ds As New DataSet()
        Try
            adapter.Fill(ds)
            dgv_donors.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub addButtonsToRows()

        Dim btn As New DataGridViewButtonColumn()
        dgv_donors.Columns.Add(btn)
        btn.HeaderText = ""
        btn.Text = "Select"
        btn.Width = 50
        btn.UseColumnTextForButtonValue = True


    End Sub


    Private Sub dgv_donors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_donors.CellContentClick
        Dim seqno As String = dgv_donors.Rows(e.RowIndex).Cells(1).Value.ToString()

        If e.ColumnIndex = 0 Then
            CurDonor = _Donor.find(seqno)
            refreshDonorInformationPanel()

        End If
    End Sub

    Public Sub refreshDonorInformationPanel()
        donor_fullname.Text = CurDonor.lname & ", " & CurDonor.fname & " " & CurDonor.mname
        donor_gender.Text = CurDonor.gender
        donor_bdate.Text = CurDonor.bdate
        donor_nostblk.Text = CurDonor.nostblk
        donor_brgy.Text = CurDonor.brgy
        donor_city.Text = CurDonor.city
        donor_prov.Text = CurDonor.prov
        donor_region.Text = CurDonor.region

        refreshDonationHistory()

        If CurDonor.seqno Is Nothing Then
            donor_donation_stat.Text = ""
        ElseIf CurDonor.donation_stat = "Y" Or CurDonor.donation_stat = "" Then
            donor_donation_stat.Text = "May Donate"
            donor_donation_stat.ForeColor = Color.Green
        Else
            donor_donation_stat.Text = "Cannot Donate"
            donor_donation_stat.ForeColor = Color.Red
        End If

        If Not CurDonor.seqno Is Nothing Then
            enroll_lfinger.Enabled = True
            enroll_rfinger.Enabled = True
        End If

        If CurDonor.hasLfinger Then
            pb_lfinger_ok.Visible = True
            pb_lfinger_not_ok.Visible = False
            verify_lfinger.Enabled = True
        Else
            pb_lfinger_ok.Visible = False
            pb_lfinger_not_ok.Visible = True
            verify_lfinger.Enabled = False
        End If

        If CurDonor.hasRfinger Then
            pb_rfinger_ok.Visible = True
            pb_rfinger_not_ok.Visible = False
            verify_rfinger.Enabled = True
        Else
            pb_rfinger_ok.Visible = False
            pb_rfinger_not_ok.Visible = True
            verify_rfinger.Enabled = False
        End If

        If Not CurDonor.photo Is Nothing Then
            pb_picture.Image = New Bitmap(CurDonor.photo, pb_picture.Size)
        Else
            pb_picture.Image = Nothing
        End If
    End Sub


    Private Sub enroll_lfinger_Click(sender As Object, e As EventArgs) Handles enroll_lfinger.Click
        Dim capture As New Capturing(CurDonor.seqno, 0, Me)
        capture.Show()

    End Sub

    Private Sub enroll_rfinger_Click(sender As Object, e As EventArgs) Handles enroll_rfinger.Click
        Dim capture As New Capturing(CurDonor.seqno, 1, Me)
        capture.Show()

    End Sub

    Public Sub refreshDonationHistory()
        If Not CurDonor.seqno Is Nothing Then
            Dim cmd As String = "SELECT f.facility_name As 'BSF' , DATE_FORMAT(d.created_dt,'%m-%d-%Y') As 'Date', d.mh_pe_remark As 'Remarks' FROM donation d INNER JOIN r_facility f ON (d.facility_cd = f.facility_cd) WHERE d.seqno = '" & CurDonor.seqno & "' ORDER BY d.created_dt DESC"

            adapter = Database.db.executeDataSet(cmd)
            Dim ds As New DataSet()
            Try
                adapter.Fill(ds)
                dgv_donation_history.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dgv_donation_history.Columns(0).Width = 130     'Adjust BSF Column size
        Else
            dgv_donation_history.DataSource = Nothing
        End If
    End Sub

    Private Sub verify_lfinger_Click(sender As Object, e As EventArgs) Handles verify_lfinger.Click
        Dim verification As New Verify_Donor(CurDonor.lfinger_template, 0)
        verification.Show()
    End Sub

    Private Sub verify_rfinger_Click(sender As Object, e As EventArgs) Handles verify_rfinger.Click
        Dim verification As New Verify_Donor(CurDonor.rfinger_template, 1)
        verification.Show()
    End Sub

    Private Sub txt_search_fname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search_fname.KeyDown
        If e.KeyCode = Keys.Enter Then
            refreshListWithFilter()
        End If
    End Sub


    Private Sub txt_search_lname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search_lname.KeyDown
        If e.KeyCode = Keys.Enter Then
            refreshListWithFilter()
        End If
    End Sub

    
    Private Sub mbtn_search_Click(sender As Object, e As EventArgs) Handles mbtn_search.Click
        refreshListWithFilter()
    End Sub

    Private Sub mbtn_clear_Click(sender As Object, e As EventArgs) Handles mbtn_clear.Click
        refreshList()
        txt_search_fname.Text = ""
        txt_search_lname.Text = ""
        CurDonor = New _Donor
        refreshDonorInformationPanel()
    End Sub

    Private Sub mbtn_searchfinger_Click(sender As Object, e As EventArgs) Handles mbtn_searchfinger.Click
        If Not SearchByScan Is Nothing Then
            SearchByScan.Close()
        End If
        SearchByScan = New Search_By_Verification(Me)
        SearchByScan.Show()
    End Sub
End Class
