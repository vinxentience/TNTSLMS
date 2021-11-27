Imports MySql.Data.MySqlClient
Public Class Students
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"

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
                    Dim LAST_NAME = Reader.GetString("LNAME")
                    Dim LRN = Reader.GetString("LRN")
                    If SearchBox.Text = FIRST_NAME Or SearchBox.Text = LAST_NAME Or SearchBox.Text = LRN Or SearchBox.Text = USER_NAME Then
                        profpiccontainer.Image = Image.FromStream(ms)
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
                Dim LRN = Reader.GetString("LRN")
                Dim GENDER = Reader.GetString("GENDER")
                Dim EMAIL = Reader.GetString("EMAIL")
                Dim ADDRESS = Reader.GetString("ADDRESS")
                Dim GRDLVL = Reader.GetString("GRADE_LEVEL")
                Dim SECTION = Reader.GetString("SECTION")
                Dim DOB = Reader.GetDateTime("DOB")

                If SearchBox.Text = FIRST_NAME Or SearchBox.Text = LAST_NAME Or SearchBox.Text = LRN Or SearchBox.Text = USER_NAME Then
                    FNAME_SHOW.Text = FIRST_NAME
                    LNAME_SHOW.Text = LAST_NAME
                    GENDER_SHOW.Text = GENDER
                    EMAIL_SHOW.Text = EMAIL
                    ADDRESS_SHOW.Text = ADDRESS
                    LRN_SHOW.Text = LRN
                    GRDLVL_SHOW.Text = GRDLVL
                    SECTION_SHOW.Text = SECTION
                    DateTimePicker1.Text = DOB
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If LRN_SHOW.Text = "[No Data]" Then
            MsgBox("User not found.")
        Else
            UpdateUser.Show()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Dispose()
        Me.Close()
        Librarian.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        GenerateIDCARD.Show()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TableGridViewMode_Students.Show()
    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        RegistrationForm.Show()

    End Sub
End Class