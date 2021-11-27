Public Class SplashScreen

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.15
        If Me.Opacity >= 1 Then
            Timer1.Enabled = False
            Me.Opacity = 1
        End If

        If Me.Opacity = 1 Then
            Timer2.Enabled = True
            Timer2.Start()
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            Timer2.Stop()
            Login.Show()
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class