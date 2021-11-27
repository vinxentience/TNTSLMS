Imports MySql.Data.MySqlClient
Public Class GenerateIDCARD
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Private Sub GenerateIDCARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime = true;"
        '
        'Try
        'MysqlConn.Open()
        'Dim Query As String
        'Query = "SELECT * FROM tntslibrarymanagementsystem.user_info"
        'Command = New MySqlCommand(Query, MysqlConn)
        'Reader = Command.ExecuteReader
        '
        'While Reader.Read()
        'Dim data = Reader("PROFILEPIC")
        'Dim LRN_ID = Reader.GetString("LRN")
        'Dim BORROWER_ID = Reader.GetString("borrower_id")
        'Dim F_NAME = Reader.GetString("LNAME")
        'Dim L_NAME = Reader.GetString("FNAME")
        'Dim GRADE = Reader.GetString("GRADE_LEVEL")
        'Dim SECTION = Reader.GetString("SECTION")
        'Dim NAGPUYOSA = Reader.GetString("ADDRESS")

        'Dim bits As Byte()

        'If TypeOf data Is DBNull Then
        'bits = New Byte() {}
        'Else
        'bits = CType(data, Byte())
        'End If
        '        Using ms As New IO.MemoryStream(bits)
        'Dim USER_NAME = Reader.GetString("USER_NAME")
        'Dim FIRST_NAME = Reader.GetString("FNAME")
        'Dim LAST_NAME = Reader.GetString("LNAME")
        'Dim LRN = Reader.GetString("LRN")
        '
        'If STUDENT_LRN.Text = LRN Then
        'PROFILEPIC.Image = Image.FromStream(ms)
        'STUDENT_LRN.Text = LRN_ID
        'FULLNAME.Text = F_NAME + " " + L_NAME
        'GRDLVL.Text = GRADE
        'SCTN.Text = SECTION
        'ADDRSS.Text = NAGPUYOSA
        'USRNM.Text = USER_NAME
        'BRRWRNO.Text = BORROWER_ID
        'End If
        'End Using
        '
        'Dim data2 = Reader("QR_CODE")
        'Dim bits2 As Byte()
        '
        'If TypeOf data2 Is DBNull Then
        'bits2 = New Byte() {}
        'Else
        'bits2 = CType(data2, Byte())
        'End If
        'Using ms2 As New IO.MemoryStream(bits2)
        'Dim USER_NAME = Reader.GetString("USER_NAME")
        'Dim FIRST_NAME = Reader.GetString("FNAME")
        'Dim LAST_NAME = Reader.GetString("LNAME")
        'Dim LRN = Reader.GetString("LRN")
        'If STUDENT_LRN.Text = LRN And FULLNAME.Text = FIRST_NAME + " " + LAST_NAME Then
        'QRPIC.Image = Image.FromStream(ms2)
        'End If
        '        End Using
        'End While


        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'Finally
        'MysqlConn.Dispose()
        'End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print()
    End Sub
End Class