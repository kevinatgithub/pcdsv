Public Class Capturing
    Inherits MetroFramework.Forms.MetroForm
    Implements DPFP.Capture.EventHandler




    Public seqno As String
    Public mode As Integer
    Public caller As Donors

    Public Event OnTemplate(ByVal template)

    Private Enroller As DPFP.Processing.Enrollment
    Private Capturer As DPFP.Capture.Capture

    Public count As Integer = 0

    Public Sub New(seqno As String, mode As Integer, caller As Donors)
        InitializeComponent()
        Me.seqno = seqno
        Me.mode = mode
        Me.caller = caller
        Init()
        StartCapture()
    End Sub


    Protected Overridable Sub Init()
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

        Enroller = New DPFP.Processing.Enrollment()         ' Create an enrollment.
    End Sub

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        DrawPicture(ConvertSampleToBitmap(Sample))
        updateCounter()

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        ' Check quality of the sample and add to enroller if it's good
        If (Not features Is Nothing) Then
            Try
                Enroller.AddFeatures(features)              ' Add feature set to template.
            Catch

            Finally

                ' Check if template has been created.
                Select Case Enroller.TemplateStatus
                    Case DPFP.Processing.Enrollment.Status.Ready        ' Report success and stop capturing
                        RaiseEvent OnTemplate(Enroller.Template)
                        Dim converted As Byte() = TemplateManager.templateToByte(Enroller.Template)

                        If mode = 0 Then
                            Database.db.saveFinger(Me.seqno, converted, 0)

                        Else
                            Database.db.saveFinger(Me.seqno, converted, 1)
                        End If
                        caller.CurDonor = _Donor.find(Me.seqno)
                        Invoke(New FunctionCall(AddressOf caller.refreshDonorInformationPanel), True)
                        Invoke(New FunctionCall(AddressOf caller.refreshListWithFilter), True)
                        StopCapture()
                        Invoke(New FunctionCall(AddressOf _close), count)

                    Case DPFP.Processing.Enrollment.Status.Failed       ' Report failure and restart capturing
                        Enroller.Clear()
                        StopCapture()
                        RaiseEvent OnTemplate(Nothing)
                        StopCapture()
                        Invoke(New FunctionCall(AddressOf Me.Close), True)
                        MsgBox("Donor Enrollment Failed, Try Again")
                End Select

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
        Try
            extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        Catch ex As Exception

        End Try

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
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        pb_lfinger.Image = New Bitmap(bmp, pb_lfinger.Size)
    End Sub

    Private Sub updateCounter()
        count += 1
        Invoke(New FunctionCall(AddressOf _updateCounter), count)
    End Sub

    Private Sub _updateCounter(count)
        lbl_counter.Text = count
    End Sub

    Private Sub _close()
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        StopCapture()
        Invoke(New FunctionCall(AddressOf Me.Close), True)
    End Sub
End Class