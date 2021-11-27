Imports MySql.Data.MySqlClient
Public Class TableGridViewMode_BookList
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim Reader As MySqlDataReader
    Dim quantityVal As Integer
    Sub filterrecords(ByVal search As String)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim query As String = "SELECT * FROM tntslibrarymanagementsystem.book_list"
        Command = New MySqlCommand(query, MysqlConn)
        Dim adapter = New MySqlDataAdapter(Command)
        Dim dt As New DataTable
        adapter.Fill(dt)
        DataGridView_booklist.DataSource = dt
    End Sub


    Private Sub TableGridViewMode_BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterrecords("")

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM tntslibrarymanagementsystem.book_list"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_booklist.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Quantity.Text = "0" Then
            MessageBox.Show("Invalid quantity value.")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
            Dim query As String = "UPDATE tntslibrarymanagementsystem.book_list SET BOOK_NAME = '" & B_NAME.Text & "', AUTHOR = '" & AUTHOR.Text & "', VOLUME = '" & VOLUME.Text & "', GENRE = '" & GENRE.Text & "', PUBLISHED = '" & Y_PUBLISHED.Text & "', QUANTITY = '" & Quantity.Text & "' Where BOOK_ISBN_ID = '" & ISBN_ID.Text & "'"
            MysqlConn.Open()
            Command = New MySqlCommand(query, MysqlConn)
            Command.ExecuteNonQuery()
            If ISBN_ID.Text = "" Or B_NAME.Text = "" Then
                MsgBox("Please fill up all the information. Do not leave any blank text box as it will result an error.")
            Else
                MsgBox("Records Updated Successfully")
                filterrecords("")
            End If
            MysqlConn.Close()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ISBN_ID.Text = "" Or B_NAME.Text = "" Then
            MsgBox("Please fill up all the information. Do not leave any blank text box as it will result an error.")
        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you really want to delete this user?", "Exit", MessageBoxButtons.YesNo)

            If dialog = DialogResult.Yes Then
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
                Dim query As String = "DELETE FROM tntslibrarymanagementsystem.book_list Where BOOK_ISBN_ID = '" & ISBN_ID.Text & "'"
                MysqlConn.Open()
                Command = New MySqlCommand(query, MysqlConn)
                Command.ExecuteNonQuery()
                filterrecords("")
            Else
                filterrecords("")
            End If
        End If
        MysqlConn.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_booklist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_booklist.CellContentClick

    End Sub

    Private Sub DataGridView_booklist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_booklist.CellClick
        Dim i As Integer
        i = DataGridView_booklist.CurrentRow.Index
        ISBN_ID.Text = DataGridView_booklist.Item(0, i).Value
        B_NAME.Text = DataGridView_booklist.Item(1, i).Value
        AUTHOR.Text = DataGridView_booklist.Item(2, i).Value
        GENRE.Text = DataGridView_booklist.Item(3, i).Value
        VOLUME.Text = DataGridView_booklist.Item(4, i).Value
        Y_PUBLISHED.Text = DataGridView_booklist.Item(5, i).Value
        Book_Condition.Text = DataGridView_booklist.Item(6, i).Value
        Quantity.Text = DataGridView_booklist.Item(10, i).Value
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