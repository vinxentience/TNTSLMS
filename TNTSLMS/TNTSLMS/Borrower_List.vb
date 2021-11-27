Imports MySql.Data.MySqlClient
Public Class Borrower_List
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader
    Sub filterrecords(ByVal search As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim query As String = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', DATE_FORMAT(b.DUE_DATE, '%Y/%m/%d') As 'Due Date',  DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d') As 'Date Borrowed',  DATE_FORMAT(b.DATE_RETURNED, '%Y/%m/%d') As 'Date Returned', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id"
        Command = New MySqlCommand(query, MysqlConn)
        Dim adapter = New MySqlDataAdapter(Command)
        Dim dt As New DataTable
        adapter.Fill(dt)
        LIST_OF_BORROWERS.DataSource = dt
    End Sub

    Private Sub Borrower_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterrecords("")

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', DATE_FORMAT(b.DUE_DATE, '%Y/%m/%d') As 'Due Date', DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d') As 'Date Borrowed',  DATE_FORMAT(b.DATE_RETURNED, '%Y/%m/%d') As 'Date Returned', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LIST_OF_BORROWERS.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            Dim queryOVERDUE As String = "UPDATE tntslibrarymanagementsystem.borrower SET status = 'Overdue' WHERE DATE_FORMAT(due_date, '%Y/%m/%d') < '" & Date.Now.ToString("yyyy/MM/dd") & "' And date_returned IS NULL"
            MysqlConn.Open()
            CommandOVERDUE = New MySqlCommand(queryOVERDUE, MysqlConn)
            CommandOVERDUE.ExecuteNonQuery()
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        dbDataSet.Clear() 'Important! To Prevent Rows Duplication 
        LIST_OF_BORROWERS.Refresh()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', DATE_FORMAT(b.DUE_DATE, '%Y/%m/%d') As 'Due Date', DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d') As 'Date Borrowed',  DATE_FORMAT(b.DATE_RETURNED, '%Y/%m/%d') As 'Date Returned', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE b.DATE_BORROWED BETWEEN '" & DateTimePicker_From.Text & "' AND '" & DateTimePicker_To.Text & "' "
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LIST_OF_BORROWERS.DataSource = bSource
            SDA.Update(dbDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LIST_OF_BORROWERS_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles LIST_OF_BORROWERS.CellFormatting
        Dim dgv As DataGridView = Me.LIST_OF_BORROWERS
        For i As Integer = 0 To dgv.Rows.Count - 1
            For ColNo As Integer = 10 To 10
                If dgv.Rows(i).Cells(ColNo).Value = "Returned" Then
                    dgv.Rows(i).Cells(ColNo).Style.BackColor = Color.MediumSeaGreen
                ElseIf dgv.Rows(i).Cells(ColNo).Value = "Unreturned" Then
                    dgv.Rows(i).Cells(ColNo).Style.BackColor = Color.Yellow
                ElseIf dgv.Rows(i).Cells(ColNo).Value = "Overdue" Then
                    dgv.Rows(i).Cells(ColNo).Style.BackColor = Color.Firebrick
                End If
            Next
        Next
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        dbDataSet.Clear() 'Important! To Prevent Rows Duplication 
        LIST_OF_BORROWERS.Refresh()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', DATE_FORMAT(b.DUE_DATE, '%Y/%m/%d') As 'Due Date', DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d') As 'Date Borrowed',  DATE_FORMAT(b.DATE_RETURNED, '%Y/%m/%d') As 'Date Returned', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE a.GRADE_LEVEL = '" & ComboBox1.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LIST_OF_BORROWERS.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged

        dbDataSet.Clear() 'Important! To Prevent Rows Duplication 
        LIST_OF_BORROWERS.Refresh()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', DATE_FORMAT(b.DUE_DATE, '%Y/%m/%d') As 'Due Date', DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d') As 'Date Borrowed',  DATE_FORMAT(b.DATE_RETURNED, '%Y/%m/%d') As 'Date Returned', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE b.status = '" & ComboBox2.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LIST_OF_BORROWERS.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text.Length > 1 Then
            ComboBox2.Enabled = False
            TextBox1.Enabled = False
        Else
            ComboBox2.Enabled = True
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        If ComboBox2.Text.Length > 1 Then
            ComboBox1.Enabled = False
            TextBox1.Enabled = False
        Else
            ComboBox1.Enabled = True
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dbDataSet.Clear() 'Important! To Prevent Rows Duplication 
        LIST_OF_BORROWERS.Refresh()

        If TextBox1.Text.Length >= 1 Then
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
        Else
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        End If

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', DATE_FORMAT(b.DUE_DATE, '%Y/%m/%d') As 'Due Date', DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d') As 'Date Borrowed',  DATE_FORMAT(b.DATE_RETURNED, '%Y/%m/%d') As 'Date Returned', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE a.LRN = '" & TextBox1.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LIST_OF_BORROWERS.DataSource = bSource
            SDA.Update(dbDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LIST_OF_BORROWERS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LIST_OF_BORROWERS.CellContentClick

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
