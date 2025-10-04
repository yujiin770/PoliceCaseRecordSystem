Public Class SplashScreen

    Private Sub Progressbar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Optional: You can display the value somewhere
        Me.Text = "Progress: " & progressbar.Value.ToString() & "%"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If progressbar.Value < progressbar.Maximum Then
            progressbar.Value += 6 ' Increase progress

        Else
            Timer1.Stop()

            LoginForm.Show()
            background.Hide()
            Me.Hide()
        End If
    End Sub

    Private Sub GunaPictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaPictureBox1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        progressbar.Minimum = 0
        progressbar.Maximum = 100
        progressbar.Value = 0
        GunaTransition1.Show(GunaPictureBox1)
       
        Timer1.Interval = 100 ' 100 milliseconds

        progressbar.Value = 0 ' Reset the progress
        Timer1.Start() ' Start the timer

        background.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub progressbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles progressbar.Click

    End Sub
End Class
