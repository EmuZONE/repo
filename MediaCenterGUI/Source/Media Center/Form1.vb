Imports System.Net
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
            If RadioButton1.Checked Then
                Process.Start("downloader\JDownloader2.exe")
                Try
                Catch ex As Exception
                    MsgBox("Die Anwendung konnte nicht gefunden werden.")
                End Try
            End If
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click
        Process.Start("https://raw.githubusercontent.com/EmuZONE/IPTV/master/iptv/kodi/kodi.m3u")
    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        MsgBox("EmuZONE Media Center GUI: Version 1.02 Beta")
    End Sub

    Private Sub ÜberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜberToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub OpenloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenloadToolStripMenuItem.Click
        MsgBox("Die Folgende Seite wird in einem externen Webbrowser geöffnet.")
        Process.Start("https://olpair.com/")
    End Sub

    Private Sub TheVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheVideoToolStripMenuItem.Click
        MsgBox("Die Folgende Seite wird in einem externen Webbrowser geöffnet.")
        Process.Start("https://tvad.me/pair")
    End Sub

    Private Sub FlashXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlashXToolStripMenuItem.Click
        MsgBox("Die Folgende Seite wird in einem externen Webbrowser geöffnet.")
        Process.Start("https://flashx.tv/pair/")
    End Sub

    Private Sub ExodusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExodusToolStripMenuItem.Click
        Try
            Process.Start("plugins\script\exodus.exe")
        Catch ex As Exception
            MsgBox("Die gewünschte Datei konnte nicht gefunden werden.")
        End Try

    End Sub

    Private Sub MP3StreamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MP3StreamToolStripMenuItem.Click
        Try
            Process.Start("plugins\script\mp3streams.exe")
        Catch ex As Exception
            MsgBox("Die gewünschte Datei konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub XStreamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XStreamToolStripMenuItem.Click
        Try
            Process.Start("plugins\script\xstream.exe")
        Catch ex As Exception
            MsgBox("Die gewünschte Datei konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub DownloadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem1.Click
        Try
            Process.Start("sql\Setup\loadmgr.exe")
        Catch ex As Exception
            MsgBox("Die gewünschte Datei konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub StartenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartenToolStripMenuItem.Click
        Try
            Process.Start("C:\Program Files (x86)\PremiumSoft\Navicat Premium\navicat.exe")
        Catch ex As Exception
            MsgBox("Das Programm Navicat muss zuerst heruntergeladen und installiert werden. Der Download wird nun gestartet, die Installation muss Manuell durchgeführt werden. Das heruntergeladene Archiv ist in dem Verzeichnis [sql] zu finden.")
            Process.Start("sql\Setup\loadmgr.exe")
        End Try
    End Sub

    Private Sub HeidiSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeidiSQLToolStripMenuItem.Click
        Try
            Process.Start("sql\heidisql.exe")
        Catch ex As Exception
            MsgBox("Die gewünschte Datei konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub DownloadToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem2.Click
        Try
            Process.Start("iptv\Listen\Script\iptv.exe")
        Catch ex As Exception
            MsgBox("Die gewünschte Datei konnte nicht gefunden werden.")
        End Try
    End Sub

    Private Sub AnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnzeigenToolStripMenuItem.Click
        Try
            Process.Start("iptv\Listen\PayTV.xml")
        Catch ex As Exception
            MsgBox("Die gewünschte Datei konnte nicht gefunden werden und muss deshalb heruntergeladen werden.")
            Process.Start("iptv\Listen\Script\iptv.exe")
        End Try
    End Sub
End Class
