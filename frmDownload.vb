Imports System.Net

Public Class frmMain
    Public WithEvents downloader As WebClient = New WebClient
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim save As New SaveFileDialog
        save.Title = "Save File As"
        save.Filter = "Executable Files (*exe)|*.exe|MP3 Files (*.mp3)|*.mp3|Text Files (*.txt)|*.txt|All files (*.*)|*.*"

        'opens the save dialog window
        save.ShowDialog()
        'directory of where, and name of file to be saved
        txtSaveAs.Text = save.FileName
    End Sub

    Private Sub tmrDownload_Tick(sender As Object, e As EventArgs) Handles tmrDownload.Tick
        If prgDownload.Value = prgDownload.Maximum Then
            tmrDownload.Enabled = False
            MessageBox.Show("Download completed!")
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Try
            tmrDownload.Enabled = True
            downloader.DownloadFileAsync(New Uri(txtURL.Text), txtSaveAs.Text)
        Catch ex As Exception
            MessageBox.Show("Failed " & vbNewLine & ex.Message, "Error")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        prgDownload.Value = e.ProgressPercentage
        Me.Text = "My Downloader  " &
                            (e.BytesReceived / (1024 * 1024)).ToString("n2") & " MB" &
                            (e.TotalBytesToReceive / (1024 * 1024)).ToString("n2") & " MB" & FormatPercent(e.ProgressPercentage / 100, 0)
    End Sub

    Private Sub txtURL_TextChanged(sender As Object, e As EventArgs) Handles txtURL.TextChanged
        Me.cleanUp()
    End Sub

    Private Sub cleanUp()
        Me.Text = "My Downloader"
        txtSaveAs.Text = ""
        prgDownload.Value = 0
    End Sub
End Class
