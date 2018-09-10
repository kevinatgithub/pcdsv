Public Class Verify

    Public seqno As String

    Public Sub New(seqno As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.seqno = seqno
    End Sub
    Private Sub Verify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_seqno.Text = seqno
    End Sub
End Class