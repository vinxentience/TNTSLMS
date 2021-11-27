Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Public Class generate_book_borrower
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader

    Sub filterrecords(ByVal search As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim query As String = "SELECT lrn, fname, lname, gender, email, address, DATE_FORMAT(dob,'%d/%m/%Y'), grade_level, section, USER_NAME FROM tntslibrarymanagementsystem.user_info"
        Command = New MySqlCommand(query, MysqlConn)
        Dim adapter = New MySqlDataAdapter(Command)
        Dim dt As New DataTable
        adapter.Fill(dt)
        LIST_OF_BORROWERS.DataSource = dt
    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Query = "SELECT a.LRN  As 'LRN', b.BORROWER_ID  As 'Borrower ID', a.FNAME  As 'First Name', a.LNAME  As 'Last Name', a.GRADE_LEVEL As 'Grade Level', a.SECTION  As 'Section', b.BOOK_NAME  As 'Book Name', b.DUE_DATE  As 'Due Date', DATE_FORMAT(b.DATE_BORROWED, '%Y/%m/%d')  As 'Date Borrowed', b.DATE_RETURNED  As 'Date Returned' FROM tntslibrarymanagementsystem.user_info a INNER JOIN tntslibrarymanagementsystem.borrower b ON a.borrower_id = b.borrower_id WHERE b.DATE_BORROWED BETWEEN '" & DateTimePicker_From.Text & "' AND '" & DateTimePicker_To.Text & "' "
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim rptDoc As ReportDocument
        rptDoc = New generate_bookborrower()
        generate_book_borrower_viewer.CrystalReportViewer1.ReportSource = rptDoc

        rptDoc.SetDataSource(dbDataSet)
        generate_book_borrower_viewer.ShowDialog()
        generate_book_borrower_viewer.Dispose()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class