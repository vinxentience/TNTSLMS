Imports MySql.Data.MySqlClient
Public Class InputBox


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MysqlConn As MySqlConnection
        MysqlConn = New MySqlConnection
        Dim Command As MySqlCommand
        Dim MySqlReader As MySqlDataReader
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"

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

                    If PASSBOX.Text = PASSWORD And QR_Scanner.TextBox1.Text = USER_NAME Then
                        LibraryUser.Show()
                        Me.Close()
                        QR_Scanner.Close()
                    End If

                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MysqlConn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        QR_Scanner.Close()
        QR_Scanner.Show()
    End Sub
End Class