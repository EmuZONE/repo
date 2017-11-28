Imports System.Net
Public Class Loader
    Dim Web As WebClient
    Private Sub Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Process.Start("data\script\ld.exe")
        Catch ex As Exception
            MsgBox("Die Datei wurde nicht gefunden")
        End Try
    End Sub
End Class