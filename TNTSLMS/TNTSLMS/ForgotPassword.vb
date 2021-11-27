Imports MySql.Data.MySqlClient
Public Class ForgotPassword
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim USER_NAME_TXT As String
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles USERNAME_CONTAINER.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM tntslibrarymanagementsystem.user_info;"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read()
                Dim USER_NAME_TXT = Reader.GetString("USER_NAME")
                Dim LRN_TXT = Reader.GetString("LRN")
                Dim QUESTION = Reader.GetString("Question")

                If USERNAME_CONTAINER.Text = USER_NAME_TXT And USERNAME_CONTAINER.Text = LRN_TXT Then
                    Question_Container_1.Text = QUESTION
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles SHOW_HIDE_PASS.CheckedChanged
        If SHOW_HIDE_PASS.Checked = False Then
            PASSWORD_HERE.PasswordChar = "*"
        Else
            PASSWORD_HERE.PasswordChar = ""
        End If
    End Sub

    Private Sub PASSWORD_HERE_TextChanged(sender As Object, e As EventArgs) Handles PASSWORD_HERE.TextChanged

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
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
                Dim ANSWER = Reader.GetString("Answer")
                Dim PASSWORD = Reader.GetString("PASSWORD")
                Dim USERNAME = Reader.GetString("USER_NAME")

                If ANSWER_CONTAINER.Text = ANSWER And USERNAME_CONTAINER.Text = USERNAME Then
                    PASSWORD_HERE.Text = PASSWORD
                Else
                    ErrorMsg.Show()
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ANSWER_CONTAINER_TextChanged(sender As Object, e As EventArgs) Handles ANSWER_CONTAINER.TextChanged
        ANSWER_CONTAINER.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(ANSWER_CONTAINER.Text)
        ANSWER_CONTAINER.Select(ANSWER_CONTAINER.Text.Length, 0)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class