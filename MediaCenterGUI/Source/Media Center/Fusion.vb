Public Class Fusion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser2.GoBack()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser2.GoForward()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        WebBrowser2.GoHome()
    End Sub
End Class