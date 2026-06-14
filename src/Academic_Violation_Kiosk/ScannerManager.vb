Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Windows.Compatibility

Public Class ScannerManager
    Private videoSource As VideoCaptureDevice
    Private reader As New BarcodeReader()

    Public Event ScanComplete(decodedText As String)

    Public Sub StartCamera(pictureBox As PictureBox)
        Dim videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If videoDevices.Count > 0 Then
            videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)

            AddHandler videoSource.NewFrame, Sub(sender, eventArgs)
                                                 Try
                                                     Dim uiFrame As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

                                                     If pictureBox.Image IsNot Nothing Then pictureBox.Image.Dispose()
                                                     pictureBox.Image = uiFrame

                                                     Using scanFrame As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
                                                         Dim source As New BitmapLuminanceSource(scanFrame)
                                                         Dim result = reader.Decode(source)

                                                         If result IsNot Nothing Then
                                                             RaiseEvent ScanComplete(result.Text)
                                                         End If
                                                     End Using

                                                 Catch ex As Exception
                                                 End Try
                                             End Sub

            videoSource.Start()
        End If
    End Sub

    Public Sub StopCamera()
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
            videoSource = Nothing
        End If
    End Sub
End Class