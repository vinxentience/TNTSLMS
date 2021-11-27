Imports MySql.Data.MySqlClient
Public Class ManageUser
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged

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
                    If SearchBox.Text = FIRST_NAME Or SearchBox.Text = LAST_NAME Or SearchBox.Text = LRN Or SearchBox.Text = USER_NAME Then
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
                Dim CNumber = Reader.GetString("CONTACT_NUMBER")
                Dim DOB = Reader.GetDateTime("DOB")
                Dim BORROWID = Reader.GetString("BORROWER_ID")
                Dim USERID = Reader.GetString("LRN")

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
                    BID_SHOW.Text = BORROWID
                    UID_SHOW.Text = USER_NAME
                    CONTACT_SHOW.Text = CNumber
                End If
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        If LRN_SHOW.Text = "[No Data]" Then
            MsgBox("User not found.")
        Else
            UpdateUser.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TableGridViewMode_Students.Show()
        TableGridViewMode_Students.FNAME.Text = Me.FNAME_SHOW.Text
        TableGridViewMode_Students.LNAME.Text = Me.LNAME_SHOW.Text
        TableGridViewMode_Students.GENDER.Text = Me.GENDER_SHOW.Text
        TableGridViewMode_Students.ADDRESS.Text = Me.ADDRESS_SHOW.Text
        TableGridViewMode_Students.GRDLVL.Text = Me.GRDLVL_SHOW.Text
        TableGridViewMode_Students.DOB.Text = Me.DateTimePicker1.Text
        TableGridViewMode_Students.SECTION.Text = Me.SECTION_SHOW.Text
        TableGridViewMode_Students.EMAIL.Text = Me.EMAIL_SHOW.Text
        TableGridViewMode_Students.LRN.Text = Me.LRN_SHOW.Text

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        GenerateIDCARD.Show()
        GenerateIDCARD.STUDENT_LRN.Text = Me.LRN_SHOW.Text
        GenerateIDCARD.FULLNAME.Text = Me.FNAME_SHOW.Text + " " + Me.LNAME_SHOW.Text
        GenerateIDCARD.SCTN.Text = Me.SECTION_SHOW.Text
        GenerateIDCARD.ADDRSS.Text = Me.ADDRESS_SHOW.Text
        GenerateIDCARD.USRNM.Text = Me.UID_SHOW.Text
        GenerateIDCARD.BRRWRNO.Text = Me.BID_SHOW.Text
        GenerateIDCARD.PROFILEPIC.Image = Me.profpiccontainer.Image
        GenerateIDCARD.QRPIC.Image = Me.qrcontainer.Image
    End Sub

    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
