Imports MySql.Data.MySqlClient
Public Class BorrowReadingMaterial
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader
    Private Sub STUD_ID_TextChanged(sender As Object, e As EventArgs) Handles STUD_ID.TextChanged
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
                Dim GRDLVL = Reader.GetString("GRADE_LEVEL")
                Dim BORROWID = Reader.GetString("borrower_id")

                If STUD_ID.Text = LRN Then
                    STUD_NAME.Text = FIRST_NAME + " " + LAST_NAME
                    UNAME.Text = USER_NAME
                    STUD_LEVEL.Text = GRDLVL
                    BorrowNo.Text = BORROWID
                    ISBN_NO.Enabled = True
                End If

                If STUD_ID.Text = "0" Then
                    STUD_NAME.Text = ""
                    UNAME.Text = ""
                    STUD_LEVEL.Text = ""
                    BorrowNo.Text = ""
                    ISBN_NO.Enabled = False
                End If

            End While
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ISBN_NO_TextChanged(sender As Object, e As EventArgs) Handles ISBN_NO.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        Dim Reader As MySqlDataReader
        Borrowing()
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM tntslibrarymanagementsystem.book_list"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read()
                Dim ISBN = Reader.GetString("BOOK_ISBN_ID")
                Dim AUTHOR_NAME = Reader.GetString("AUTHOR")
                Dim B_NAME = Reader.GetString("BOOK_NAME")
                Dim GENRE = Reader.GetString("GENRE")
                Dim PUBLISHED = Reader.GetString("PUBLISHED")
                Dim numbercounter = Reader.GetString("nbb")
                Dim AVAILABLEorNah = Reader.GetString("Availability")
                Dim BOOK_VOLUME = Reader.GetString("volume")

                If ISBN_NO.Text = ISBN Then
                    AUTHOR.Text = AUTHOR_NAME
                    BOOK_NAME.Text = B_NAME
                    GENRE_TYPE.Text = GENRE
                    PUBLISHED_YEAR.Text = PUBLISHED
                    status_show.Text = AVAILABLEorNah
                    counterborrow.Text = numbercounter
                    VOLUME.Text = BOOK_VOLUME
                End If

                If Label15.Text = Label16.Text Then
                    status_show.Text = "Unavailable"
                End If

            End While
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim Reader As MySqlDataReader

        If status_show.Text = "Available" Then
            counterborrow.Text = Val(counterborrow.Text) + 1
            Label16.Text = Val(Label16.Text) + 1
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE tntslibrarymanagementsystem.book_list SET nbb = '" & counterborrow.Text & "', user_borrow = '" & Label16.Text & "' WHERE book_isbn_id = '" & ISBN_NO.Text & "' "
                Command = New MySqlCommand(Query, MysqlConn)
                Reader = Command.ExecuteReader

                MysqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            Try
                MysqlConn.Open()
                Dim Query As String
                Dim todayDate As Date = Date.Today
                Dim dueDate As Date = DateAdd("d", 5, todayDate)
                Query = "INSERT INTO tntslibrarymanagementsystem.borrower (borrower_id, book_isbn_id, book_name, due_date, date_borrowed, status, volume) VALUES ('" & BorrowNo.Text & "', '" & ISBN_NO.Text & "', '" & convertQuotes(BOOK_NAME.Text) & "', '" & dueDate.ToString("yyyy/MM/dd") & "', '" & todayDate.ToString("yyyy/MM/dd") & "', 'Unreturned', '" & VOLUME.Text & "') "
                Command = New MySqlCommand(Query, MysqlConn)
                Reader = Command.ExecuteReader

                MsgBox("Book Successfully Borrowed")

                ' Dim manageBorrowerCtrl As New BorrowReadingMaterial
                'If manageBorrowerCtrl.Visible = True Then
                'ManageBorrower.Panel1.Controls.Add(manageBorrowerCtrl)
                'manageBorrowerCtrl.BringToFront()
                'Else
                'ManageBorrower.Panel1.Controls.Clear()
                'End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

        Else
            MsgBox("Sorry the book is unavailable.")
        End If

        If Label15.Text = Label16.Text Then
            status_show.Text = "Unavailable"
        End If

    End Sub

    Public Function convertQuotes(ByVal str As String) As String
        convertQuotes = str.Replace("'", "''")
    End Function

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Public Sub Borrowing()
        dbDataSet.Clear()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT quantity, user_borrow FROM book_list WHERE BOOK_ISBN_ID = '" & ISBN_NO.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            borrowing_dgv.DataSource = bSource
            SDA.Update(dbDataSet)
            Dim i As Integer
            i = borrowing_dgv.CurrentRow.Index
            Label15.Text = borrowing_dgv.Item(0, i).Value.ToString
            Label16.Text = borrowing_dgv.Item(1, i).Value.ToString

            If borrowing_dgv.Item(1, i).Value.ToString = String.Empty Then
                Label16.Text = "0"
            End If
        Catch ex As Exception

        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BorrowReadingMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub borrowing_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles borrowing_dgv.CellContentClick

    End Sub
End Class
