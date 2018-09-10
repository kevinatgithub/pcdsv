Public Class Verify_Donor
    Inherits MetroFramework.Forms.MetroForm
    Implements DPFP.Capture.EventHandler


    Private Template As DPFP.Template

    Private Verificator As DPFP.Verification.Verification
    Private mode As Integer

    Public Event OnTemplate(ByVal template)

    Private Capturer As DPFP.Capture.Capture

    Public Sub New(template As DPFP.Template, mode As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Template = template

        Me.mode = mode
        Verificator = New DPFP.Verification.Verification

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



    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        DrawPicture(ConvertSampleToBitmap(Sample))

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

        ' Check quality of the sample and start verification if it's good
        If Not features Is Nothing Then
            ' Compare the feature set with our template
            Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
            Verificator.Verify(features, Template, result)
            Invoke(New FunctionCall(AddressOf _updateResult), result.Verified)
        End If
    End Sub

    Public Sub _updateResult(result As Boolean)

        If result Then
            lbl_status.Text = "VERIFIED"
            lbl_status.ForeColor = Color.Green
            pb_success.Visible = True
            pb_invalid.Visible = False

        Else
            lbl_status.Text = "INVALID"
            lbl_status.ForeColor = Color.Red
            pb_success.Visible = False
            pb_invalid.Visible = True
        End If
        lbl_status.Visible = True

    End Sub

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

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality

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

    Private Sub Verify_Donor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.mode = 0 Then
            lbl_finger.Text = "Left Finger"
        Else
            lbl_finger.Text = "Right Finger"
        End If

        StartCapture()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Invoke(New FunctionCall(AddressOf _close), True)
    End Sub

    Private Sub _close()
        StopCapture()
        Me.Close()

    End Sub
End Class