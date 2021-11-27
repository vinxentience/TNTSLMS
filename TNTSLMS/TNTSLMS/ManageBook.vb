Imports MySql.Data.MySqlClient
Public Class ManageBook
    Dim MysqlConn As New MySqlConnection("server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem")
    Dim ISBNID, BOOK_NAME, AUTHOR_NAME, VOLUME_TYPE, YEAR_PUBLISHED, B_CONDITION, GENRE_BOOK As String
    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * FROM tntslibrarymanagementsystem.book_list WHERE CONCAT (book_isbn_id, book_name, author, genre, volume, published) like '%" & valueToSearch & "%'"
        Dim command As New MySqlCommand(searchQuery, MysqlConn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView_book.DataSource = table

    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        FilterData(SearchBox.Text.Replace("'", "\'"))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        bookinventory.Show()
    End Sub

    Private Sub DataGridView_book_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_book.CellContentClick

    End Sub

    Private Sub DataGridView_book_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView_book.CellFormatting
        Dim dgv As DataGridView = Me.DataGridView_book
        For i As Integer = 0 To dgv.Rows.Count - 1
            For ColNo As Integer = 7 To 7
                If dgv.Rows(i).Cells(ColNo).Value = "Available" Then

                    dgv.Rows(i).Cells(ColNo).Style.BackColor = Color.MediumSeaGreen
                Else
                    dgv.Rows(i).Cells(ColNo).Style.BackColor = Color.Firebrick
                End If
            Next
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TableGridViewMode_BookList.Show()
        TableGridViewMode_BookList.ISBN_ID.Text = ISBNID
        TableGridViewMode_BookList.B_NAME.Text = BOOK_NAME
        TableGridViewMode_BookList.AUTHOR.Text = AUTHOR_NAME
        TableGridViewMode_BookList.VOLUME.Text = VOLUME_TYPE
        TableGridViewMode_BookList.Y_PUBLISHED.Text = YEAR_PUBLISHED
        TableGridViewMode_BookList.Book_Condition.Text = B_CONDITION
        TableGridViewMode_BookList.GENRE.Text = GENRE_BOOK

    End Sub

    Private Sub DataGridView_book_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_book.CellClick
        Dim i As Integer
        i = DataGridView_book.CurrentRow.Index
        ISBNID = DataGridView_book.Item(0, i).Value
        BOOK_NAME = DataGridView_book.Item(1, i).Value
        AUTHOR_NAME = DataGridView_book.Item(2, i).Value
        GENRE_BOOK = DataGridView_book.Item(3, i).Value
        VOLUME_TYPE = DataGridView_book.Item(4, i).Value
        YEAR_PUBLISHED = DataGridView_book.Item(5, i).Value
        B_CONDITION = DataGridView_book.Item(6, i).Value

    End Sub

    Private Sub SearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
