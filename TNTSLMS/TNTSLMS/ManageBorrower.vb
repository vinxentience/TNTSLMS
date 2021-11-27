Public Class ManageBorrower
    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim manageBorrower As New BorrowReadingMaterial
        If manageBorrower.Visible = True Then
            Panel1.Controls.Add(manageBorrower)
            manageBorrower.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Dim manageBorrowerList As New Borrower_List
        If manageBorrowerList.Visible = True Then
            Panel1.Controls.Add(manageBorrowerList)
            manageBorrowerList.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Dim manageBorrowerReturn As New ManageBookReturn
        If manageBorrowerReturn.Visible = True Then
            Panel1.Controls.Add(manageBorrowerReturn)
            manageBorrowerReturn.BringToFront()
        Else
            Panel1.Controls.Clear()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
