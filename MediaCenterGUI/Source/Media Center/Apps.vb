Public Class Apps

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Loader.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start("ftp\FileZillaPortable.exe")
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class