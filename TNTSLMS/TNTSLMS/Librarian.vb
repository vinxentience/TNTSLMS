Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Librarian
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Librarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim showStat As New statistics
        If showStat.Visible = True Then
            Panel1.Controls.Add(showStat)
            showStat.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If


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
                Dim data = Reader("PROFILEPIC")
                Dim bits As Byte()

                If TypeOf data Is DBNull Then
                    bits = New Byte() {}
                Else
                    bits = CType(data, Byte())
                End If
                Using ms As New IO.MemoryStream(bits)
                    Dim USER_NAME = Reader.GetString("USER_NAME")
                    Dim FIRST_NAME = Reader.GetString("FNAME")
                    If Login.U_NAME.Text = USER_NAME Then
                        profile_viewer_container.Image = Image.FromStream(ms)
                    End If

                End Using
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM tntslibrarymanagementsystem.user_info"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read()
                Dim USER_NAME = Reader.GetString("USER_NAME")
                Dim FIRST_NAME = Reader.GetString("FNAME")
                Dim LAST_NAME = Reader.GetString("LNAME")

                If Login.U_NAME.Text = USER_NAME Then
                    USER_NAME_PROFILE.Text = FIRST_NAME + " " + LAST_NAME
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Timer1.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        If RectangleShape1.Width < 280 Then
            RectangleShape1.Width = RectangleShape1.Width + 1
        End If

        If RectangleShape1.Width > 0 Then

            RectangleShape1.Width = RectangleShape1.Width - 1
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim manageBook As New ManageBook
        If manageBook.Visible = True Then
            Panel1.Controls.Add(manageBook)
            manageBook.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim manageUser As New ManageUser
        If manageUser.Visible = True Then
            Panel1.Controls.Add(manageUser)
            manageUser.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim manageBorrower As New ManageBorrower
        If manageBorrower.Visible = True Then
            Panel1.Controls.Add(manageBorrower)
            manageBorrower.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If

        Dim manageSubBorrower As New BorrowReadingMaterial
        If manageSubBorrower.Visible = True Then
            manageBorrower.Panel1.Controls.Add(manageSubBorrower)
            manageSubBorrower.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        generate_report.Show()
        Notification.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Notification.Show()
        generate_report.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to sign out?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        Else Me.Show()

        End If
    End Sub


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeNow.Text = Date.Now.ToString("hh:mm:ss tt")
        DateNow.Text = Date.Now.ToString("dd")
        MonthNow.Text = Date.Now.ToString("MMM")
        YearNow.Text = Date.Now.ToString("yyyy")
        DayOfTheWeek.Text = Date.Today.DayOfWeek.ToString()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim showStat As New statistics
        If showStat.Visible = True Then
            Panel1.Controls.Add(showStat)
            showStat.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If
    End Sub
End Class
