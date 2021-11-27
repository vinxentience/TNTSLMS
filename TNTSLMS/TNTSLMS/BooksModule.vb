Imports MySql.Data.MySqlClient
Public Class BooksModule
    Dim MysqlConn As New MySqlConnection("server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem")

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * FROM tntslibrarymanagementsystem.book_list WHERE CONCAT (book_isbn_id, book_name, author, genre, volume, published) like '%" & valueToSearch & "%'"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView_book.DataSource = table

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        FilterData(SearchBox.Text)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        bookinventory.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Dispose()
        Me.Close()
        Librarian.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LibraryUser.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BooksModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class