Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports
Public Class generate_book_list
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader


    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        dbDataSet.Clear() 'Important! To Prevent Rows Duplication 
        LIST_OF_BOOKS.Refresh()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT book_isbn_id As 'ISBN', book_name As 'Book Name', author As 'Author', genre As 'Genre', DATE_FORMAT (accessioned_date, '%Y / %m / %d') As 'Accessioned Date' FROM tntslibrarymanagementsystem.book_list  WHERE accessioned_date BETWEEN '" & DateTimePicker_From.Text & "' AND '" & DateTimePicker_To.Text & "'  "
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LIST_OF_BOOKS.DataSource = bSource
            SDA.Update(dbDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        generate_report.Close()
        Librarian.Show()
    End Sub

    Private Sub DateTimePicker_From_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_From.ValueChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim rptDoc As ReportDocument
        rptDoc = New generate_booklist()
        generate_book_list_viewer.CrystalReportViewer1.ReportSource = rptDoc

        rptDoc.SetDataSource(dbDataSet)
        generate_book_list_viewer.ShowDialog()
        generate_book_list_viewer.Dispose()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim manageBook As New ManageBook
        If manageBook.Visible = True Then
            Librarian.Panel1.Controls.Add(manageBook)
            manageBook.BringToFront()
        Else
            Librarian.Panel1.Controls.Clear()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class