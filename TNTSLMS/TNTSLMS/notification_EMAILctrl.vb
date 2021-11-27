Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class notification_EMAILctrl
    Dim message As New MailMessage
    Dim smtp As New SmtpClient
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub USER_ID_TextChanged(sender As Object, e As EventArgs) Handles USER_ID.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM tntslibrarymanagementsystem.user_info"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read()
                Dim LRN_ID_READER = Reader.GetString("LRN")
                Dim EMAIL_READER = Reader.GetString("email")
                Dim FNAME_READER = Reader.GetString("fname")
                Dim LNAME_READER = Reader.GetString("lname")

                If USER_ID.Text = LRN_ID_READER Then
                    Sent_To.Text = EMAIL_READER
                    FULLNAME.Text = FNAME_READER + " " + LNAME_READER
                    Sent_To.Enabled = True
                    Sent_Subject.Enabled = True
                    Sent_Message.Enabled = True
                    Sent_Message.Enabled = False
                    enableEdit.CheckState = CheckState.Unchecked

                    Sent_Message.Text = "Good Day! " + "'" & FULLNAME.Text & "'" + " The book you borrowed is already on due date. Kindly return the reading material. Thank you"
                End If


            End While
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Dim Mail As New MailMessage
            Mail.Subject = Sent_Subject.Text
            Mail.To.Add(Sent_To.Text)
            Mail.From = New MailAddress("tntslibrarynotification@gmail.com")
            Mail.Body = Sent_Message.Text
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("tntslibrarynotification@gmail.com", "elibhubtntslibrary")
            SMTP.Port = 587
            SMTP.Send(Mail)
            MsgBox("Message Successfully Sent.")
            Sent_To.Text = ""
            Sent_Subject.Text = ""
            Sent_Message.Text = ""
            USER_ID.Text = ""
            FULLNAME.Text = "[No Data]"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub enableEdit_CheckedChanged(sender As Object, e As EventArgs) Handles enableEdit.CheckedChanged
        If enableEdit.CheckState = CheckState.Checked Then
            Sent_Message.Enabled = True
            Sent_Message.Text = "Good Day! " + "'" & FULLNAME.Text & "'" + " The book you borrowed is already on due date. Kindly return the reading material. Thank you"
        Else
            Sent_Message.Enabled = False
            Sent_Message.Text = "Good Day! " + "'" & FULLNAME.Text & "'" + " The book you borrowed is already on due date. Kindly return the reading material. Thank you"
        End If
    End Sub

    Private Sub notification_EMAILctrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sent_Message.Text = "Good Day! " + "'" & FULLNAME.Text & "'" + " The book you borrowed is already on due date. Kindly return the reading material. Thank you"
    End Sub
End Class
