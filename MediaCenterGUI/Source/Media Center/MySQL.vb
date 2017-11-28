Public Class MySQL

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://dev.mysql.com/get/Downloads/MySQLInstaller/mysql-installer-community-5.6.38.0.msi")
    End Sub
End Class