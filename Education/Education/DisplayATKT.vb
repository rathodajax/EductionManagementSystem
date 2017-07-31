Public Class DisplayATKT

    Private Sub dgv2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellContentClick
        Try
            If dgv2.Rows.Count > 1 Then
                Dim r As Integer = dgv2.CurrentCell.RowIndex
                Dim c As Integer = dgv2.CurrentCell.ColumnIndex
                If c = 0 Then
                    tos = r
                    SetMode("View")
                    SetResultMasterID(Val(dgv2.Rows(r).Cells(13).Value))
                    AddResult.Show()
                    AddResult.MarkEntry_Load(New Object, New System.EventArgs)
                    AddResult.ViewMode()
                    AddResult.Button1.Enabled = True
                    AddResult.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SetQuery(GetLastQuery)
        display.LoadResult(display.dgv1)
        display.f = False
        AddResult.Close()
    End Sub

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = MousePosition
        If (Me.Location.Y + Me.Height) >= (display.dgv1.Location.Y + display.Height) Then
            Me.Location = New Size(MousePosition.X, (MousePosition.Y - Me.Height) - 50)
        End If
        Try
            PictureBox1.Image = Image.FromFile(Application.StartupPath + GetString("SELECT STU_PHOTO FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + dgv2.Rows(0).Cells(4).Value.ToString + "'"))
        Catch ex As Exception
            PictureBox1.Image = Image.FromFile(Application.StartupPath + "\Images\default.jpg")
        End Try

    End Sub
End Class