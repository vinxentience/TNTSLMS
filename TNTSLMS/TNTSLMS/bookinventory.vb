Imports MySql.Data.MySqlClient
Public Class bookinventory
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim quantityVal As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label7.Click, Label5.Click, Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles AUTHOR.TextChanged, Y_PUBLISHED.TextChanged, VOLUME.TextChanged, GENRE.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()

            If String.IsNullOrEmpty(ISBN.Text) Then
                MessageBox.Show("Please Enter the ISBN")
            End If

            If String.IsNullOrEmpty(B_NAME.Text) Then
                MessageBox.Show("Please Enter the Book Title")
            End If

            If Quantity.Text = "0" Then
                MessageBox.Show("Invalid quantity value.")
                Quantity.Text = "1"
            End If

            Dim Query As String
            Dim todayDate As Date = Date.Today
            Query = "INSERT INTO tntslibrarymanagementsystem.book_list (book_isbn_id, book_name, author, genre, volume, published, status, accessioned_date, quantity) VALUES ('" & ISBN.Text & "', '" & B_NAME.Text & "', '" & AUTHOR.Text & "', '" & GENRE.Text & "', '" & VOLUME.Text & "', '" & Y_PUBLISHED.Text & "', '" & Book_Condition.Text & "', '" & todayDate.ToString("yyyy/MM/dd") & "', '" & Quantity.Text & "') "
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Book Added!")
            BooksModule.DataGridView_book.Refresh()

            Me.Close()
            Librarian.Show()
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub bookinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        quantityVal += 1
        Quantity.Text = quantityVal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If quantityVal <= 1 Then
            Quantity.Text = 1
        Else
            quantityVal -= 1
            Quantity.Text = quantityVal
        End If
    End Sub
End Class