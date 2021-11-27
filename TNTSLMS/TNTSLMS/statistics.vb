Imports MySql.Data.MySqlClient
Public Class statistics
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbDataSet, dbDataSet2, dbDataSet3, dbDataSet4 As New DataTable
    Dim book1, book2, book3 As String

    Private Sub genderrank_Click(sender As Object, e As EventArgs) Handles genderrank.Click

    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click

    End Sub

    Private Sub book_count_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles book_count.CellContentClick

    End Sub

    Dim book1count, book2count, book3count As Integer

    Private Sub statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA, SDA2, SDA3, SDA4 As New MySqlDataAdapter
        Dim bSource, bSource2, bSource3, bSource4 As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT nbb, book_name FROM tntslibrarymanagementsystem.book_list ORDER BY NBB DESC LIMIT 3"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            statTable_bookcount.DataSource = bSource
            SDA.Update(dbDataSet)

            Dim i As Integer
            i = statTable_bookcount.CurrentRow.Index
            BookRank.Series("Most Borrowed Books").Points.AddXY(statTable_bookcount.Item(1, i).Value.ToString, statTable_bookcount.Item(0, i).Value())
            BookRank.Series("Most Borrowed Books").Points.AddXY(statTable_bookcount.Rows(1).Cells(1).Value, statTable_bookcount.Rows(1).Cells(0).Value())
            BookRank.Series("Most Borrowed Books").Points.AddXY(statTable_bookcount.Rows(2).Cells(1).Value, statTable_bookcount.Rows(2).Cells(0).Value)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT COUNT(GENDER) FROM tntslibrarymanagementsystem.user_info WHERE GENDER = 'Male' AND USER_LEVEL = 'LIBRARY USER'"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA2.SelectCommand = Command
            SDA2.Fill(dbDataSet2)
            bSource2.DataSource = dbDataSet2
            statTable_gender_Male.DataSource = bSource2
            SDA2.Update(dbDataSet2)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT COUNT(GENDER) FROM tntslibrarymanagementsystem.user_info WHERE GENDER = 'Female' AND USER_LEVEL = 'LIBRARY USER'"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA3.SelectCommand = Command
            SDA3.Fill(dbDataSet3)
            bSource3.DataSource = dbDataSet3
            statTable_gender_Female.DataSource = bSource3
            SDA3.Update(dbDataSet3)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        genderrank.Series("Series2").Points.AddXY("Male", statTable_gender_Male.Rows(0).Cells(0).Value)
        genderrank.Series("Series2").Points.AddXY("Female", statTable_gender_Female.Rows(0).Cells(0).Value)

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT SUM(quantity) FROM tntslibrarymanagementsystem.book_list"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA4.SelectCommand = Command
            SDA4.Fill(dbDataSet4)
            bSource4.DataSource = dbDataSet4
            book_count.DataSource = bSource4
            SDA4.Update(dbDataSet4)
            numberofbooks.Text = book_count.Rows(0).Cells(0).Value

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub
End Class
