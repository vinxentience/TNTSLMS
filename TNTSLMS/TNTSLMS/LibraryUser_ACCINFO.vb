Imports MySql.Data.MySqlClient
Public Class LibraryUser_ACCINFO
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader

    Private Sub LibraryUser_ACCINFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.USER_SHOW.Text = LibraryUser.USER_NAME_PROFILE.Text

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
                    If USER_SHOW.Text = FIRST_NAME + " " + LAST_NAME Then
                        profpiccontainer.Image = Image.FromStream(ms)
                    End If
                End Using

                Dim data2 = Reader("QR_CODE")
                Dim bits2 As Byte()

                If TypeOf data2 Is DBNull Then
                    bits2 = New Byte() {}
                Else
                    bits2 = CType(data2, Byte())
                End If
                Using ms2 As New IO.MemoryStream(bits2)
                    Dim USER_NAME = Reader.GetString("USER_NAME")
                    Dim FIRST_NAME = Reader.GetString("FNAME")
                    Dim LAST_NAME = Reader.GetString("LNAME")
                    Dim LRN = Reader.GetString("LRN")
                    If USER_SHOW.Text = FIRST_NAME + " " + LAST_NAME Then
                        qrcontainer.Image = Image.FromStream(ms2)
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

                If USER_SHOW.Text = FIRST_NAME + " " + LAST_NAME Then
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
End Class
