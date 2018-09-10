Imports MySql.Data.MySqlClient

Public Class Search_By_Verification
    Inherits MetroFramework.Forms.MetroForm
    Implements DPFP.Capture.EventHandler

    Public Verifier As DPFP.Verification.Verification
    Public Capturer As DPFP.Capture.Capture
    Public caller As Donors

    Public templates As New Collection

    Public Sub New(caller As Donors)
        InitializeComponent()
        Me.caller = caller
        loadTemplates()
        lbl_templates.Text = "Out of " & templates.Count
        'pbar_progress.Maximum = templates.Count
        prepareScanner()
    End Sub

    Public Sub loadTemplates()

        Dim reader As MySqlDataReader = Database.db.execute("SELECT seqno,lfinger,rfinger FROM donor WHERE lfinger IS NOT NULL OR rfinger IS NOT NULL")
        Dim ms1, ms2 As IO.MemoryStream
        Dim b1, b2 As Byte()
        While reader.Read

            If Not reader("lfinger").ToString = "" Then
                b1 = reader("lfinger")
                ms1 = New IO.MemoryStream(b1)
                Dim d As New _Template(reader("seqno"), New DPFP.Template(ms1))
                templates.Add(d)
            End If

            If Not reader("rfinger").ToString = "" Then
                b2 = reader("rfinger")
                ms2 = New IO.MemoryStream(b2)
                Dim d As New _Template(reader("seqno"), New DPFP.Template(ms2))
                templates.Add(d)
            End If
        End While
    End Sub

    Sub prepareScanner()
        Verifier = New DPFP.Verification.Verification

        Try
            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.

            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                              ' Subscribe for capturing events.
            Else
                MsgBox("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MsgBox("Can't initiate capture operation!")
        End Try
    End Sub

    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing                          ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)              ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Protected Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()        ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function


    Protected Sub StartCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StartCapture()
                'MsgBox("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                MsgBox("Can't initiate capture!")
            End Try
        End If
    End Sub

    Protected Sub StopCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception
                MsgBox("Can't terminate capture!")
            End Try
        End If
    End Sub

    Protected Sub DrawPicture(ByVal bmp)
        Try
            Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        pb_finger.Image = New Bitmap(bmp, pb_finger.Size)
    End Sub

    
    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        DrawPicture(ConvertSampleToBitmap(Sample))

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

        ' Check quality of the sample and start verification if it's good
        If Not features Is Nothing Then

            For Each _template In templates
                ' Compare the feature set with our template
                Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
                Verifier.Verify(features, _template.template, result)
                _template.result = result.Verified
                Invoke(New FunctionCall(AddressOf _updateResult), _template)
            Next
            
        End If
    End Sub

    Sub _updateResult(_template)
        If _template.result Then
            StopCapture()
            lbl_status.Text = "Donor Found"
            lbl_status.ForeColor = Color.Green
            caller.CurDonor = _Donor.find(_template.seqno)
            caller.refreshDonorInformationPanel()
            caller.refreshList()
            lbl_scanning.Visible = False
            'Me.Close()

        Else
            Dim p As Integer = lbl_progress.Text
            p += 1
            'pbar_scanning.Value = (p / templates.Count) * 100
            lbl_progress.Text = p.ToString

            'ProgressBar1.Value = p
            'pbar_progress.Value = p

            If p >= templates.Count Then
                lbl_status.Text = "Donor Not Found"
                lbl_status.ForeColor = Color.Red
                lbl_scanning.Visible = False
                StopCapture()
            End If
        End If

    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        Invoke(New FunctionCall(AddressOf _showScanning), True)
    End Sub

    Sub _showScanning()
        lbl_scanning.Visible = True
    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality

    End Sub

    Private Sub Search_By_Verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartCapture()
    End Sub

    
End Class