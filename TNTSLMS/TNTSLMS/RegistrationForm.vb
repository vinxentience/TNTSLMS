Imports MySql.Data.MySqlClient
Imports System.IO
Public Class RegistrationForm
    Dim gender As String
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles UploadImg.Click
        Dim opf As New OpenFileDialog
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        opf.Filter = "Choose Image(*.JPG; *.PNG; *.GIF)|*.jpg;*.png;*.gif"

        Using opf

            opf.InitialDirectory = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "C:\TNTS LIBRARY SYSTEM\PROFILE_PICTURES")

        End Using
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            profpiccontainer.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub opf_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opf.FileOk

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub profpiccontainer_Click(sender As Object, e As EventArgs) Handles profpiccontainer.Click

    End Sub

    Private Sub capture_photo_Click(sender As Object, e As EventArgs)
        eLIBHUBCAMERA.Show()
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.USER_NAME.Text = QR_GENERATOR.USER_NAME.Text
        autogenerate_id()
    End Sub



    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles UPLOAD_QR.Click
        Dim opf_QR As New OpenFileDialog
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        opf_QR.Filter = "Choose Image(*.JPG; *.PNG; *.GIF)|*.jpg;*.png;*.gif"
        Using opf_QR

            opf_QR.InitialDirectory = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "C:\TNTS LIBRARY SYSTEM\QR_CODE")

        End Using

        If opf_QR.ShowDialog = Windows.Forms.DialogResult.OK Then

            QR_CONTAINER.Image = Image.FromFile(opf_QR.FileName)

        End If
    End Sub

    Private Sub LRN_TextChanged(sender As Object, e As EventArgs) Handles LRN.TextChanged

    End Sub

    Private Sub FNAME_TextChanged(sender As Object, e As EventArgs) Handles FNAME.TextChanged

        FNAME.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(FNAME.Text)
        FNAME.Select(FNAME.Text.Length, 0)
    End Sub

    Private Sub LNAME_TextChanged(sender As Object, e As EventArgs) Handles LNAME.TextChanged
        LNAME.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(LNAME.Text)
        LNAME.Select(LNAME.Text.Length, 0)
    End Sub

    Private Sub Answer_Box_TextChanged(sender As Object, e As EventArgs) Handles Answer_Box.TextChanged
        Answer_Box.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Answer_Box.Text)
        Answer_Box.Select(Answer_Box.Text.Length, 0)
    End Sub

    Private Sub ADDRESS_TextChanged(sender As Object, e As EventArgs) Handles ADDRESS.TextChanged
        ADDRESS.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(ADDRESS.Text)
        ADDRESS.Select(ADDRESS.Text.Length, 0)
    End Sub

    Private Sub QR_CONTAINER_Click_1(sender As Object, e As EventArgs) Handles QR_CONTAINER.Click

    End Sub

    Private Sub autogenerate_id()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim query As String = "SELECT * FROM tntslibrarymanagementsystem.user_info"
        Command = New MySqlCommand(query, MysqlConn)
        Command.Connection = MysqlConn
        MysqlConn.Open()

        Dim maxid As Object
        Dim strid As String
        Dim intid As Integer

        Command.CommandText = "Select Max(borrower_id) From tntslibrarymanagementsystem.user_info"

        maxid = Command.ExecuteScalar
        If maxid Is DBNull.Value Then
            intid = 1
        Else
            strid = CType(maxid, String)
            intid = CType(strid, String)
            intid = intid + 1

        End If
        GeneratedNo.Text = intid


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If FNAME.Text = "" Or LNAME.Text = "" Or ADDRESS.Text = "" Or USERLVL_BOX.Text = "" Or LRN.Text = "" Or PASS.Text = "" Or RetypePASS.Text = "" Or Question_Box.Text = "" Or Answer_Box.Text = "" Then
            MsgBox("Please Fill in the needed information.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If RetypePASS.Text = PASS.Text Then
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"

                Dim command As New MySqlCommand("INSERT INTO tntslibrarymanagementsystem.user_info (LRN, USER_NAME, PASSWORD, FNAME, LNAME, EMAIL, ADDRESS, GENDER, DOB, PROFILEPIC, QUESTION, ANSWER, QR_CODE, GRADE_LEVEL, CONTACT_NUMBER, SECTION, BORROWER_ID, USER_LEVEL, MNAME) VALUES (@LRN , @USER_NAME, @PASS, @FNAME, @LNAME, @EMAIL, @ADDRESS, '" & gender & "' , @DateOfBirth, @PROFILE, @Question_Box, @Answer_Box, @QR, @GRDLVL, @CONTACT, @SECTION, @BORROW, @USERLVL, @MNAME)", MysqlConn)

                Dim ms As New MemoryStream

                profpiccontainer.Image.Save(ms, profpiccontainer.Image.RawFormat)

                Dim msQR As New MemoryStream
                QR_CONTAINER.Image.Save(msQR, QR_CONTAINER.Image.RawFormat)

                command.Parameters.Add("@lrn", MySqlDbType.VarChar).Value = LRN.Text
                command.Parameters.Add("@USER_NAME", MySqlDbType.VarChar).Value = USER_NAME.Text
                command.Parameters.Add("@PASS", MySqlDbType.VarChar).Value = PASS.Text
                command.Parameters.Add("@FNAME", MySqlDbType.VarChar).Value = FNAME.Text
                command.Parameters.Add("@MNAME", MySqlDbType.VarChar).Value = MNAME.Text
                command.Parameters.Add("@LNAME", MySqlDbType.VarChar).Value = LNAME.Text
                command.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = EMAIL.Text
                command.Parameters.Add("@ADDRESS", MySqlDbType.VarChar).Value = ADDRESS.Text
                command.Parameters.Add("@DateOfBirth", MySqlDbType.VarChar).Value = DateOfBirth.Text
                command.Parameters.Add("@PROFILE", MySqlDbType.LongBlob).Value = ms.ToArray()
                command.Parameters.Add("@Question_Box", MySqlDbType.VarChar).Value = Question_Box.Text
                command.Parameters.Add("@Answer_Box", MySqlDbType.VarChar).Value = Answer_Box.Text
                command.Parameters.Add("@QR", MySqlDbType.Blob).Value = msQR.ToArray()
                command.Parameters.Add("@GRDLVL", MySqlDbType.VarChar).Value = GRADELVL.Text
                command.Parameters.Add("@CONTACT", MySqlDbType.VarChar).Value = CONTACT.Text
                command.Parameters.Add("@SECTION", MySqlDbType.VarChar).Value = SECTION.Text
                command.Parameters.Add("@USERLVL", MySqlDbType.VarChar).Value = USERLVL_BOX.Text
                command.Parameters.Add("@BORROW", MySqlDbType.VarChar).Value = GeneratedNo.Text


                Try
                    MysqlConn.Open()

                    If command.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Image Inserted!")
                    Else
                        MessageBox.Show("Image Not Inserted")
                    End If

                    MessageBox.Show("Account Created!")
                    Me.Close()
                    Login.Show()
                    MysqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            Else
                MsgBox("Password does not match.")
            End If
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LRN.Text = ""
        PASS.Text = ""
        RetypePASS.Text = ""
        USERLVL_BOX.Text = ""
        FNAME.Text = ""
        LNAME.Text = ""
        EMAIL.Text = ""
        ADDRESS.Text = ""
        Question_Box.Text = ""
        Answer_Box.Text = ""
        GRADELVL.Text = ""
        CONTACT.Text = ""
        SECTION.Text = ""
        MNAME.Text = ""
    End Sub

    Private Sub USERLVL_BOX_SelectedValueChanged(sender As Object, e As EventArgs) Handles USERLVL_BOX.SelectedValueChanged
        If USERLVL_BOX.Text = "LIBRARIAN" Then
            SECTION.Enabled = False
            GRADELVL.Enabled = False
            SECTION.Text = ""
            GRADELVL.Text = ""
        Else
            SECTION.Enabled = True
            GRADELVL.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub SECTION_TextChanged(sender As Object, e As EventArgs) Handles SECTION.TextChanged
        SECTION.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(SECTION.Text)
        SECTION.Select(SECTION.Text.Length, 0)
    End Sub

    Private Sub USERLVL_BOX_TextChanged(sender As Object, e As EventArgs) Handles USERLVL_BOX.TextChanged
        If USERLVL_BOX.Text.Length() <= 3 Then
            USERLVL_BOX.Text = ""
            MsgBox("You are not allowed to input text on a combobox.")
        ElseIf USERLVL_BOX.Text.Length() = 0 Then
            USERLVL_BOX.Text = ""
        End If
    End Sub

    Private Sub GRADELVL_TextChanged(sender As Object, e As EventArgs) Handles GRADELVL.TextChanged
        If GRADELVL.Text.Length() <= 3 Then
            GRADELVL.Text = ""
            MsgBox("You are not allowed to input text on a combobox.")
        ElseIf GRADELVL.Text.Length() = 0 Then
            GRADELVL.Text = ""
        End If
    End Sub

    Private Sub Question_Box_TextChanged(sender As Object, e As EventArgs) Handles Question_Box.TextChanged
        If Question_Box.Text.Length() <= 3 Then
            Question_Box.Text = ""
            MsgBox("You are not allowed to input text on a combobox.")
        ElseIf Question_Box.Text.Length() = 0 Then
            Question_Box.Text = ""
        End If
    End Sub

    Private Sub FNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles FNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles LNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub EMAIL_KeyDown(sender As Object, e As KeyEventArgs) Handles EMAIL.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ADDRESS_KeyDown(sender As Object, e As KeyEventArgs) Handles ADDRESS.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub CONTACT_KeyDown(sender As Object, e As KeyEventArgs) Handles CONTACT.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub SECTION_KeyDown(sender As Object, e As KeyEventArgs) Handles SECTION.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub LRN_KeyDown(sender As Object, e As KeyEventArgs) Handles LRN.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PASS_KeyDown(sender As Object, e As KeyEventArgs) Handles PASS.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RetypePASS_KeyDown(sender As Object, e As KeyEventArgs) Handles RetypePASS.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Answer_Box_KeyDown(sender As Object, e As KeyEventArgs) Handles Answer_Box.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PASS_TextChanged(sender As Object, e As EventArgs) Handles PASS.TextChanged
        PASS.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToLower(PASS.Text)
        PASS.Select(PASS.Text.Length, 0)
    End Sub

    Private Sub RetypePASS_TextChanged(sender As Object, e As EventArgs) Handles RetypePASS.TextChanged
        RetypePASS.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToLower(RetypePASS.Text)
        RetypePASS.Select(RetypePASS.Text.Length, 0)
    End Sub

    Private Sub MNAME_TextChanged(sender As Object, e As EventArgs) Handles MNAME.TextChanged
        FNAME.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(FNAME.Text)
        FNAME.Select(FNAME.Text.Length, 0)
    End Sub

    Private Sub MNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles MNAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class