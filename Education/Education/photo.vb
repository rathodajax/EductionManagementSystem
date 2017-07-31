Public Class photo
    Dim str As String
    Dim count As Integer
    Dim i As Integer


    Private Sub photo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        photos()
    End Sub

    Public Sub photos()
        i = view_image.ListView1.SelectedIndices(Val(view_image.ListView1.SelectedItems(0).Text.ToString))

        PictureBox1.Image = Image.FromFile(view_image.ListView1.SelectedItems(0).Text.ToString())
    End Sub
    Public Sub photomove()
        PictureBox1.Image = Image.FromFile(view_image.ListView1.Items(i).Text.ToString())
    End Sub

   Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        i = 0
        photomove()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If i < view_image.ListView1.Items.Count - 1 Then
            i += 1
        Else
            i = view_image.ListView1.Items.Count - 1

        End If
        photomove()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        i = view_image.ListView1.Items.Count - 1
        photomove()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If i > 0 Then
            i -= 1
        Else
            i = 0
        End If
        photomove()

    End Sub

    Private Sub pNav_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pNav.Paint

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If i <> -1 Then
            str = "DELETE FROM EVENT_DETAIL WHERE PVPATH='" & view_image.ListView1.Items(i).Text & "'"
            getdata(str)
            MsgBox("DATA DELETE SUCCESSFULLY")

            If i > 0 Then
                view_image.ListView1.Items.RemoveAt(i)
                i -= 1
                photomove()
            Else
                PictureBox1.Image = Nothing
                i = -1
                photomove()
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class