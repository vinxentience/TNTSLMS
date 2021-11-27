Imports MySql.Data.MySqlClient
Public Class TableGridViewMode_Students
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
        DataGridView_students.DataSource = dt
    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterrecords("")

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT lrn As 'LRN', fname As 'First Name', lname As 'Last Name', gender As 'Gender', email As 'EMAIL', address As 'Address', DATE_FORMAT(dob,'%d/%m/%Y') As 'Date of Birth', grade_level As 'Grade Level', section As 'Section', USER_NAME As 'User Name' FROM tntslibrarymanagementsystem.user_info"
            Command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView_students.DataSource = bSource
            SDA.Update(dbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub DataGridView_students_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_students.CellContentClick


    End Sub

    Private Sub DataGridView_students_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView_students.MouseClick
        Dim i As Integer
        i = DataGridView_students.CurrentRow.Index

        LRN.Text = DataGridView_students.Item(0, i).Value
        FNAME.Text = DataGridView_students.Item(1, i).Value
        LNAME.Text = DataGridView_students.Item(2, i).Value
        GENDER.Text = DataGridView_students.Item(3, i).Value
        EMAIL.Text = DataGridView_students.Item(4, i).Value
        ADDRESS.Text = DataGridView_students.Item(5, i).Value
        DOB.Text = DataGridView_students.Item(6, i).Value
        GRDLVL.Text = DataGridView_students.Item(7, i).Value
        SECTION.Text = DataGridView_students.Item(8, i).Value

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
        Dim query As String = "UPDATE tntslibrarymanagementsystem.user_info SET LRN = '" & LRN.Text & "', FNAME = '" & FNAME.Text & "', LNAME = '" & LNAME.Text & "', GENDER = '" & GENDER.Text & "', EMAIL = '" & EMAIL.Text & "', ADDRESS = '" & ADDRESS.Text & "', DOB = '" & DOB.Text & "', GRADE_LEVEL = '" & GRDLVL.Text & "', SECTION = '" & SECTION.Text & "' Where LRN = '" & LRN.Text & "'"
        MysqlConn.Open()
        Command = New MySqlCommand(query, MysqlConn)
        Command.ExecuteNonQuery()
        If FNAME.Text = "" Or LNAME.Text = "" Or GENDER.Text = "" Or EMAIL.Text = "" Or ADDRESS.Text = "" Or DOB.Text = "" Or GRDLVL.Text = "" Or SECTION.Text = "" Then
            MsgBox("Please fill up all the information. Do not leave any blank text box as it will result an error.")
        Else
            MsgBox("Records Updated Successfully")
            filterrecords("")
        End If
        MysqlConn.Close()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If FNAME.Text = "" Or LNAME.Text = "" Then
            MsgBox("Please fill up all the information. Do not leave any blank text box as it will result an error.")
        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you really want to delete this user?", "Exit", MessageBoxButtons.YesNo)

            If dialog = DialogResult.Yes Then
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server = localhost; userid = root; password = canlas; database = tntslibrarymanagementsystem; Convert Zero Datetime=True"
                Dim query As String = "DELETE FROM tntslibrarymanagementsystem.user_info Where LRN = '" & LRN.Text & "'"
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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Students.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub DataGridView_students_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_students.CellClick
        Dim i As Integer
        i = DataGridView_students.CurrentRow.Index

        LRN.Text = DataGridView_students.Item(0, i).Value
        FNAME.Text = DataGridView_students.Item(1, i).Value
        LNAME.Text = DataGridView_students.Item(2, i).Value
        GENDER.Text = DataGridView_students.Item(3, i).Value
        EMAIL.Text = DataGridView_students.Item(4, i).Value
        ADDRESS.Text = DataGridView_students.Item(5, i).Value
        DOB.Text = DataGridView_students.Item(6, i).Value
        GRDLVL.Text = DataGridView_students.Item(7, i).Value
        SECTION.Text = DataGridView_students.Item(8, i).Value
    End Sub

    Private Sub DataGridView_students_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView_students.KeyDown
        Dim i As Integer
        i = DataGridView_students.CurrentRow.Index

        LRN.Text = DataGridView_students.Item(0, i).Value
        FNAME.Text = DataGridView_students.Item(1, i).Value
        LNAME.Text = DataGridView_students.Item(2, i).Value
        GENDER.Text = DataGridView_students.Item(3, i).Value
        EMAIL.Text = DataGridView_students.Item(4, i).Value
        ADDRESS.Text = DataGridView_students.Item(5, i).Value
        DOB.Text = DataGridView_students.Item(6, i).Value
        GRDLVL.Text = DataGridView_students.Item(7, i).Value
        SECTION.Text = DataGridView_students.Item(8, i).Value
    End Sub
End Class