Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient

Public Class QR_Scanner
    WithEvents MyWebcam As WebCamCapture
    Dim Reader As QRCodeDecoder
    Dim ReaderPic As MySqlDataReader


    Private Sub MyWebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles MyWebcam.ImageCaptured
        QR_CONTAINER.Image = e.WebCamImage

    End Sub

    Private Sub StartWebcam()
        Try
            StopWebcam()
            MyWebcam = New WebCamCapture
            MyWebcam.Start(0)
            MyWebcam.Start(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub StopWebcam()
        Try
            MyWebcam.Stop()
            MyWebcam.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        StartWebcam()
        TextBox1.Clear()
    End Sub

    Private Sub QR_Scanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'Scans the received image
        Try
            StopWebcam()
            Reader = New QRCodeDecoder
            TextBox1.Text = Reader.Decode(New Data.QRCodeBitmapImage(QR_CONTAINER.Image))

        Catch ex As Exception
            StartWebcam()
        End Try

        'Reads the Profile Picture and User Name

        Dim MysqlConn As MySqlConnection
        MysqlConn = New MySqlConnection
        Dim Command As MySqlCommand
        Dim MySqlReader As MySqlDataReader
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"

        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT * FROM tntslibrarymanagementsystem.user_info"
            Command = New MySqlCommand(Query, MysqlConn)
            ReaderPic = Command.ExecuteReader

            While ReaderPic.Read()
                Dim data = ReaderPic("PROFILEPIC")
                Dim bits As Byte()

                If TypeOf data Is DBNull Then
                    bits = New Byte() {}
                Else
                    bits = CType(data, Byte())
                End If
                Using ms As New IO.MemoryStream(bits)
                    Dim USER_NAME = ReaderPic.GetString("USER_NAME")

                    If TextBox1.Text = USER_NAME Then
                        PROFILEPIC_QR.Image = Image.FromStream(ms)
                    End If

                End Using
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        MysqlConn.Close()

        MysqlConn.Open()
        Try

            Dim Query As String
            Query = "SELECT * FROM tntslibrarymanagementsystem.user_info"
            Command = New MySqlCommand(Query, MysqlConn)
            MySqlReader = Command.ExecuteReader

            Try
                While MySqlReader.Read()
                    Dim USER_NAME = MySqlReader.GetString("USER_NAME")
                    Dim FIRST_NAME = MySqlReader.GetString("FNAME")
                    Dim PASSWORD = MySqlReader.GetString("PASSWORD")

                    If TextBox1.Text = USER_NAME Then
                        InputBox.Show()
                        MsgBox("QR code successfully scanned")
                    End If

                End While
            Catch ex As Exception
                MsgBox("QR code not successfully scanned")
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MysqlConn.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        StopWebcam()
    End Sub
End Class
