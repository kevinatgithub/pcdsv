Public Class Enroll



    Public seqno As String
    Public donor As _Donor

    

    Public Sub New(seqno As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.seqno = seqno
        donor = _Donor.find(seqno)
    End Sub

    Private Sub Enroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_seqno.Text = donor.seqno
        lbl_fname.Text = donor.fname
        lbl_mname.Text = donor.mname
        lbl_lname.Text = donor.lname

    End Sub

    


    'Private Sub btn_lfinger_Click(sender As Object, e As EventArgs) Handles btn_lfinger.Click
    '    Dim lfinger As New Capturing(Me.seqno, 0, Me)
    '    lfinger.Show()
    'End Sub

    'Private Sub btn_rfinger_Click(sender As Object, e As EventArgs) Handles btn_rfinger.Click
    '    Dim rfinger As New Capturing(Me.seqno, 1, Me)
    '    rfinger.Show()
    'End Sub
End Class