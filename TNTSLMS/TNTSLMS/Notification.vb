Public Class Notification
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim notificationEMAIL As New notification_EMAILctrl
        If notificationEMAIL.Visible = True Then
            Librarian.Panel1.Controls.Add(notificationEMAIL)
            notificationEMAIL.BringToFront()
        Else
            Librarian.Panel1.Controls.Clear()
        End If
        Me.Close()
        'notification_email.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim notificationSMS As New notification_SMSctrl
        If notificationSMS.Visible = True Then
            Librarian.Panel1.Controls.Add(notificationSMS)
            notificationSMS.BringToFront()
        Else
            Librarian.Panel1.Controls.Clear()
        End If
        Me.Close()
        'notification_sms.Show()
    End Sub
End Class