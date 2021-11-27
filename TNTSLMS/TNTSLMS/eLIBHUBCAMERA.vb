Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class eLIBHUBCAMERA
    Dim Camera As VideoCaptureDevice
    Dim bmp As Bitmap
    Private Sub eLIBHUBCAMERA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub START_Click(sender As Object, e As EventArgs) Handles START.Click
        Dim CAMERAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If CAMERAS.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Camera = CAMERAS.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            Camera.Start()
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        LiveCam.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        RegistrationForm.profpiccontainer.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub CAPTURE_Click(sender As Object, e As EventArgs) Handles CAPTURE.Click
        CapturedCam.Image = LiveCam.Image

        If CapturedCam.Image Is Nothing Then
            MessageBox.Show("Start the camera first")
        End If

    End Sub

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click

        If CapturedCam.Image Is Nothing Then
            MessageBox.Show("Start the camera first")
        Else

            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to set this as your profile picture?", "Exit", MessageBoxButtons.YesNo)

            If dialog = DialogResult.Yes Then
                SaveFileDialog1.ShowDialog()
                RegistrationForm.Show()
                Me.Close()
                Camera.Stop()
            End If

            If dialog = DialogResult.No Then
                Dim frm = New eLIBHUBCAMERA
                frm.Show()
                Me.Close()
                Camera.Stop()

            End If

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegistrationForm.Show()
        Me.Close()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        Try
            Dim img As New Bitmap(CapturedCam.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Using SaveFileDialog1

            SaveFileDialog1.InitialDirectory = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "C:\TNTS LIBRARY SYSTEM\PROFILE_PICTURES")

        End Using

    End Sub

    Private Sub SaveFileDialog1_Disposed(sender As Object, e As EventArgs) Handles SaveFileDialog1.Disposed

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class