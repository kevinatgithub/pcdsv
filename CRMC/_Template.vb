Public Class _Template

    Public seqno As String
    Public template As DPFP.Template
    Public result As Boolean = False

    Sub New(seqno As String, template As DPFP.Template)
        Me.seqno = seqno
        Me.template = template
    End Sub

End Class
