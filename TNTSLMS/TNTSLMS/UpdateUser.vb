Imports MySql.Data.MySqlClient
Public Class UpdateUser
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim gender As String
    Private Sub EMAIL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                Dim USER_NAME = Reader.GetString("USER_NAME")
                Dim FIRST_NAME = Reader.GetString("FNAME")
                Dim LAST_NAME = Reader.GetString("LNAME")
                Dim LRN = Reader.GetString("LRN")

                If Students.FNAME_SHOW.Text = FIRST_NAME Then
                    LRN_CONTAINER.Text = LRN
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE_USER.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to save changes?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
            Dim Reader As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE tntslibrarymanagementsystem.user_info SET FNAME = '" & FNAME.Text & "', LNAME = '" & LNAME.Text & "', GENDER = '" & gender & "' , EMAIL = '" & EMAIL_UPDATE.Text & "', DOB = '" & DateOfBirth.Text & "' WHERE LRN = '" & LRN_CONTAINER.Text & "'"
                Command = New MySqlCommand(Query, MysqlConn)
                Reader = Command.ExecuteReader
                MessageBox.Show("Account Updated")
                Me.Hide()
                Students.Show()
                MysqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Else Me.Show()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Female"
    End Sub
End Class