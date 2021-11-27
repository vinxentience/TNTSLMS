Imports MySql.Data.MySqlClient
Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Command2 As MySqlCommand
    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Dim Query2 As String

            Query = "select * from tntslibrarymanagementsystem.user_info where USER_NAME = '" & U_NAME.Text & "' and password = '" & PASS.Text & "' "
            Query2 = "select USER_LEVEL from tntslibrarymanagementsystem.user_info"
            Dim QueryString As String = String.Concat(Query, ";", Query2)
            Command = New MySqlCommand(QueryString, MysqlConn)
            Reader = Command.ExecuteReader

            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1

            End While
            If count = 1 Then
                Dim USER_LEVEL = Reader.GetString("USER_LEVEL")
                'ADMIN
                If USER_LEVEL = "LIBRARIAN" Then
                    MessageBox.Show("Welcome! " + U_NAME.Text)
                    Call Admin()
                    Me.Hide()
                    U_NAME.Text = "USERNAME"
                    PASS.Text = "PASSWORD"
                End If
                'LIBRARYUSER
                If USER_LEVEL = "LIBRARY USER" Then
                    MessageBox.Show("Welcome! " + U_NAME.Text)
                    Call User()
                    Me.Hide()
                    U_NAME.Text = "USERNAME"
                    PASS.Text = "PASSWORD"
                End If
            Else
                MsgBox("Incorrect password/username.")

            End If

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub RegistrationLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegistrationLink.LinkClicked
        QR_GENERATOR.Show()
        Me.Hide()
    End Sub

    Private Sub User()
        LibraryUser.Show()
    End Sub

    Private Sub Admin()
        Librarian.Show()
    End Sub

    Private Sub F_Pass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles F_Pass.LinkClicked

        ForgotPassword.Show()
    End Sub

    Private Sub SHOW_HIDE_PASSWORD_CheckedChanged(sender As Object, e As EventArgs) Handles SHOW_HIDE_PASSWORD.CheckedChanged
        If SHOW_HIDE_PASSWORD.Checked = False Then
            PASS.PasswordChar = "*"
        Else
            PASS.PasswordChar = ""
        End If
    End Sub

    Private Sub PASS_TextChanged(sender As Object, e As EventArgs) Handles PASS.TextChanged
        PASS.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToLower(PASS.Text)
        PASS.Select(PASS.Text.Length, 0)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        QR_Scanner.Show()

    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click
        QR_GENERATOR.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click

    End Sub

    Private Sub U_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles U_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PASS_KeyDown(sender As Object, e As KeyEventArgs) Handles PASS.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub U_NAME_TextChanged(sender As Object, e As EventArgs) Handles U_NAME.TextChanged

    End Sub
End Class
