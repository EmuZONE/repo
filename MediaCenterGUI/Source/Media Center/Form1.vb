Public Class Form1

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Pair.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start("kodi.exe")
            If CheckBox1.Checked Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Repos.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        IPTV.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Process.Start("downloader\JDownloader2.exe")
            If CheckBox1.Checked Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Try
            Process.Start("system\folder.exe")
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FAQ.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Process.Start("sql\heidisql.exe")
            If CheckBox1.Checked Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Apps.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MySQL.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FileZillaFTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileZillaFTPToolStripMenuItem.Click
        Try
            Process.Start("ftp\FileZillaPortable.exe")
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub MediaManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediaManagerToolStripMenuItem.Click
        Try
            Process.Start("medit\Media-Manager.exe")
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub MP3TagEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP3TagEditorToolStripMenuItem.Click
        Try
            Process.Start("mp3tag\Mp3tag.exe")
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub SQLDatabaseManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLDatabaseManagerToolStripMenuItem.Click
        Try
            Process.Start("sql\heidisql.exe")
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub PlaylistConverterM3UXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaylistConverterM3UXMLToolStripMenuItem.Click
        Try
            Process.Start("pls\Playlists Converter.exe")
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub DownloadSkinsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadSkinsToolStripMenuItem.Click
        Skins.Show()
    End Sub

    Private Sub TexturenEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TexturenEditorToolStripMenuItem.Click
        Try
            Process.Start("system\Kodi.Texture.exe")
        Catch ex As Exception
            MsgBox("Die Anwendung konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
