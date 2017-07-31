Public Class frmvideo
    Dim i As Integer
    Public Sub videos()
        i = view_video.ListView1.SelectedIndices(Val(view_video.ListView1.SelectedItems(0).Text.ToString))
        AxWindowsMediaPlayer1.URL = view_video.ListView1.SelectedItems(0).Text.ToString
    End Sub


    Private Sub frmvideo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        videos()
        view_video.Hide()
    End Sub
End Class