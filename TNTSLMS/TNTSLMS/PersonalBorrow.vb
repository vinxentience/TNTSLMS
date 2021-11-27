Imports MySql.Data.MySqlClient
Public Class PersonalBorrow
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader

    Sub filterrecords(ByVal search As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim query As String = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', b.DUE_DATE  As 'Due Date', DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d')  As 'Date Borrowed', b.DATE_RETURNED  As 'Date Returned' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE USER_NAME = '" & LibraryUser.USER_NAME_PROFILE.Text & "' b.DATE_BORROWED BETWEEN '" & DateTimePicker_From.Text & "' AND '" & DateTimePicker_To.Text & "' "
        Command = New MySqlCommand(query, MysqlConn)
        Dim adapter = New MySqlDataAdapter(Command)
        Dim dt As New DataTable
        adapter.Fill(dt)
        DataGridView_personalborrow.DataSource = dt
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        dbDataSet.Clear() 'Important! To Prevent Rows Duplication 
        DataGridView_personalborrow.Refresh()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', b.DUE_DATE  As 'Due Date', DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d')  As 'Date Borrowed', b.DATE_RETURNED  As 'Date Returned', b.STATUS As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE a.USER_NAME = '" & LibraryUser.user_id.Text & "' AND b.DATE_BORROWED BETWEEN '" & DateTimePicker_From.Text & "' AND '" & DateTimePicker_To.Text & "' "
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_personalborrow.DataSource = bSource
            SDA.Update(dbDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub DataGridView_personalborrow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_personalborrow.CellContentClick

    End Sub

    Private Sub DataGridView_personalborrow_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView_personalborrow.CellFormatting
        Dim dgv As DataGridView = Me.DataGridView_personalborrow
        For i As Integer = 0 To dgv.Rows.Count - 1
            For ColNo As Integer = 10 To 10
                If dgv.Rows(i).Cells(ColNo).Value = "Returned" Then

                    dgv.Rows(i).Cells(ColNo).Style.BackColor = Color.MediumSeaGreen
                Else
                    dgv.Rows(i).Cells(ColNo).Style.BackColor = Color.Firebrick
                End If
            Next
        Next
    End Sub


    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged

        dbDataSet.Clear() 'Important! To Prevent Rows Duplication 
        DataGridView_personalborrow.Refresh()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', b.DUE_DATE  As 'Due Date', b.DATE_BORROWED  As 'Date Borrowed', b.DATE_RETURNED  As 'Date Returned', b.STATUS  As 'Status' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE b.status = '" & ComboBox2.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_personalborrow.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged

    End Sub

End Class
