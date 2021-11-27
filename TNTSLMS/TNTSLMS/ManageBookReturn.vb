Imports MySql.Data.MySqlClient
Public Class ManageBookReturn
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet, dbDataSet2 As New DataTable
    Dim Reader As MySqlDataReader

    Private Sub ManageBookReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterrecords("")
        datagrid_style()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = ("SELECT  b.BORROWER_ID  As 'Borrower ID', DATE_FORMAT(b.DATE_BORROWED, '%Y-%m-%d')  As 'Date Borrowed', DATE_FORMAT(b.DUE_DATE, '%Y-%m-%d') As 'Due Date',  b.BOOK_NAME  As 'Book Name', b.book_isbn_id As 'ISBN', a.LRN  As 'LRN', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE b.status = 'Unreturned'Or b.status = 'Overdue'")
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            RETURN_PANEL.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub Borrowing()
        dbDataSet2.Clear()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA2 As New MySqlDataAdapter
        Dim bSource2 As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT quantity, user_borrow FROM book_list WHERE BOOK_ISBN_ID = '" & ISBN_ID.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA2.SelectCommand = Command
            SDA2.Fill(dbDataSet2)
            bSource2.DataSource = dbDataSet2
            borrowing_dgv.DataSource = bSource2
            SDA2.Update(dbDataSet2)
            Dim table2 As Integer
            table2 = borrowing_dgv.CurrentRow.Index
            BORROW_COUNT.Text = borrowing_dgv.Item(1, table2).Value.ToString

            If borrowing_dgv.Item(1, table2).Value.ToString = String.Empty Then
                BORROW_COUNT.Text = "0"
            End If
        Catch ex As Exception

        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Sub filterrecords(ByVal search As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim query As String = "SELECT  b.BORROWER_ID  As 'Borrower ID', DATE_FORMAT(b.DATE_BORROWED, '%Y-%m-%d')  As 'Date Borrowed', DATE_FORMAT(b.DUE_DATE, '%Y-%m-%d') As 'Due Date',  b.BOOK_NAME  As 'Book Name', b.book_isbn_id As 'ISBN', a.LRN  As 'LRN', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE b.status = 'Unreturned' Or b.status = 'Overdue'"
        Command = New MySqlCommand(query, MysqlConn)
        Dim adapter = New MySqlDataAdapter(Command)
        Dim dt As New DataTable
        adapter.Fill(dt)
        RETURN_PANEL.DataSource = dt
    End Sub

    Sub datagrid_style()
        For i As Integer = 0 To RETURN_PANEL.RowCount - 1
            If i Mod 2 = 0 Then
                RETURN_PANEL.Rows(i).DefaultCellStyle.BackColor = Color.White
            Else
                RETURN_PANEL.Rows(i).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
            End If
        Next
    End Sub

    Private Sub RETURN_PANEL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles RETURN_PANEL.CellContentClick

        Dim i As Integer
        i = RETURN_PANEL.CurrentRow.Index

        B_ID.Text = RETURN_PANEL.Item(0, i).Value.ToString
        B_DATE.Text = RETURN_PANEL.Item(1, i).Value.ToString
        D_DATE.Text = RETURN_PANEL.Item(2, i).Value.ToString
        B_NAME.Text = RETURN_PANEL.Item(3, i).Value.ToString
        ISBN_ID.Text = RETURN_PANEL.Item(4, i).Value.ToString
        Borrowing()
    End Sub

    Private Sub RETURN_PANEL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RETURN_PANEL.CellClick

        Dim i As Integer
        i = RETURN_PANEL.CurrentRow.Index

        B_ID.Text = RETURN_PANEL.Item(0, i).Value.ToString
        B_DATE.Text = RETURN_PANEL.Item(1, i).Value.ToString
        D_DATE.Text = RETURN_PANEL.Item(2, i).Value.ToString
        B_NAME.Text = RETURN_PANEL.Item(3, i).Value.ToString
        ISBN_ID.Text = RETURN_PANEL.Item(4, i).Value.ToString
        STUD_ID_SEARCH.Text = RETURN_PANEL.Item(5, i).Value.ToString
        Borrowing()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Try
            MysqlConn.Open()
            Dim Query As String
            BORROW_COUNT.Text = Val(BORROW_COUNT.Text) - 1
            Query = "UPDATE tntslibrarymanagementsystem.book_list SET availability = 'Available', user_borrow = '" & BORROW_COUNT.Text & "' WHERE book_isbn_id = '" & ISBN_ID.Text & "' "
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            If BORROW_COUNT.Text <= -1 Or BORROW_COUNT.Text = 0 Then
                BORROW_COUNT.Text = 0
            End If

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
            Query = "UPDATE tntslibrarymanagementsystem.borrower SET status = 'Returned', date_returned = '" & todayDate.ToString("yyyy/MM/dd") & "' WHERE date_borrowed = '" & B_DATE.Text & "' AND book_isbn_id = '" & ISBN_ID.Text & "' AND BORROWER_ID = '" & B_ID.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            If ISBN_ID.Text = "[No Data]" Or ISBN_ID.Text = "" Then
                MsgBox("There are no data selected.")
            Else
                MessageBox.Show("Book Successfully Returned")
                STUD_ID_SEARCH.Text = ""
                B_ID.Text = "[No Data]"
                D_DATE.Text = "[No Data]"
                B_DATE.Text = "[No Data]"
                B_NAME.Text = "[No Data]"
                ISBN_ID.Text = "[No Data]"
            End If


            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        filterrecords("")
    End Sub

    Private Sub STUD_ID_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles STUD_ID_SEARCH.TextChanged
        dbDataSet.Clear() 'Important! To Prevent Rows Duplication 
        RETURN_PANEL.Refresh()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        If STUD_ID_SEARCH.Text = "" Then
            filterrecords("")
        Else
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "SELECT  b.BORROWER_ID  As 'Borrower ID', DATE_FORMAT(b.DATE_BORROWED, '%Y-%m-%d')  As 'Date Borrowed', DATE_FORMAT(b.DUE_DATE, '%Y-%m-%d') As 'Due Date',  b.BOOK_NAME  As 'Book Name', b.book_isbn_id As 'ISBN', a.LRN  As 'LRN', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE a.LRN = '" & STUD_ID_SEARCH.Text & "' And b.status <> 'Returned'"
                Command = New MySqlCommand(Query, MysqlConn)
                SDA.SelectCommand = Command
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                RETURN_PANEL.DataSource = bSource
                SDA.Update(dbDataSet)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        End If


        'MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        'Dim Reader As MySqlDataReader

        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "SELECT * FROM tntslibrarymanagementsystem.user_info"
        '    Command = New MySqlCommand(Query, MysqlConn)
        '    Reader = Command.ExecuteReader

        '    While Reader.Read()
        '        Dim LRN_ID_READER = Reader.GetString("LRN")

        '        If STUD_ID_SEARCH.Text = LRN_ID_READER Then
        '            filterrecords("")
        '        End If


        '    End While
        '    MysqlConn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    MysqlConn.Dispose()
        'End Try
    End Sub

    Private Sub RETURN_PANEL_KeyDown(sender As Object, e As KeyEventArgs) Handles RETURN_PANEL.KeyDown

        Dim i As Integer
        i = RETURN_PANEL.CurrentRow.Index

        B_ID.Text = RETURN_PANEL.Item(0, i).Value.ToString
        B_DATE.Text = RETURN_PANEL.Item(1, i).Value.ToString
        D_DATE.Text = RETURN_PANEL.Item(2, i).Value.ToString
        B_NAME.Text = RETURN_PANEL.Item(3, i).Value.ToString
        ISBN_ID.Text = RETURN_PANEL.Item(4, i).Value.ToString
        STUD_ID_SEARCH.Text = RETURN_PANEL.Item(5, i).Value.ToString
        Borrowing()
    End Sub

    Private Sub RETURN_PANEL_KeyUp(sender As Object, e As KeyEventArgs) Handles RETURN_PANEL.KeyUp
        Dim i As Integer
        i = RETURN_PANEL.CurrentRow.Index

        B_ID.Text = RETURN_PANEL.Item(0, i).Value.ToString
        B_DATE.Text = RETURN_PANEL.Item(1, i).Value.ToString
        D_DATE.Text = RETURN_PANEL.Item(2, i).Value.ToString
        B_NAME.Text = RETURN_PANEL.Item(3, i).Value.ToString
        ISBN_ID.Text = RETURN_PANEL.Item(4, i).Value.ToString
        STUD_ID_SEARCH.Text = RETURN_PANEL.Item(5, i).Value.ToString
        Borrowing()
    End Sub
End Class
