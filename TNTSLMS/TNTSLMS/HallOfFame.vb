Imports MySql.Data.MySqlClient
Public Class HallOfFame
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub HallOfFame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT nbb, book_name FROM tntslibrarymanagementsystem.book_list ORDER BY NBB DESC LIMIT 3"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            INVISIBLE_TABLE.DataSource = bSource
            SDA.Update(dbDataSet)
            '1st
            book1st.Text = dbDataSet.Rows(0).Item("book_name").ToString
            book1st_no.Text = dbDataSet.Rows(0).Item("nbb").ToString + " Times Being Borrowed"
            '2nd
            book2nd.Text = dbDataSet.Rows(1).Item("book_name").ToString
            book2nd_no.Text = dbDataSet.Rows(1).Item("nbb").ToString + " Times Being Borrowed"
            '3rd
            book3rd.Text = dbDataSet.Rows(2).Item("book_name").ToString
            book3rd_no.Text = dbDataSet.Rows(2).Item("nbb").ToString + " Times Being Borrowed"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Opacity = Me.Opacity + 0.15
        If Me.Opacity >= 1 Then
            Me.Opacity = 1
        End If
        If Me.Opacity = 1 Then
            Timer1.Stop()
        End If

    End Sub


End Class