Imports MessagingToolkit.QRCode
Imports MySql.Data.MySqlClient
Public Class QR_GENERATOR
    Private Sub QR_GENERATOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder()

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles USER_NAME.TextChanged
        Try
            QR_CONTAINER.Image = QR_Generator.Encode(USER_NAME.Text)
            QR_Generator.QRCodeScale = 6

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim placename As String
        If USER_NAME.Lines.Count() > 0 Then
            placename = USER_NAME.Lines(0)
        Else
            placename = String.Empty
        End If


        Dim MysqlConn As MySqlConnection
        Dim Command As MySqlCommand

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from tntslibrarymanagementsystem.user_info"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read()
                Dim USER_NAME_READ = Reader.GetString("USER_NAME")
                If USER_NAME_READ = USER_NAME.Text Then
                    MsgBox("Username Already Exist")
                    USER_NAME.Text = ""
                End If

            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(QR_CONTAINER.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub QR_CONTAINER_Click(sender As Object, e As EventArgs) Handles QR_CONTAINER.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        eLIBHUBCAMERA.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If USER_NAME.Text.Length = 0 Then
            MsgBox("Please Enter your Username")
        End If

        If USER_NAME.Text.Length <= 7 Then
            MsgBox("Password Must Contain 8 Characters or Higher")
            USER_NAME.Text = ""
        ElseIf USER_NAME.Text.Length > 7 Then
            SaveFileDialog1.ShowDialog()
            eLIBHUBCAMERA.Show()
            Me.Hide()
        End If

        Using SaveFileDialog1

            SaveFileDialog1.InitialDirectory = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "C:\TNTS LIBRARY SYSTEM\QR_CODE")

        End Using

    End Sub
End Class