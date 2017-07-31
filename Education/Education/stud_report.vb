
Imports System.Data.OleDb

Public Class stud_report
    'Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim adpt As OleDbDataAdapter
    Dim tbl As DataTable
    Dim rpt As New CrystalReport1
    Public Sub connect()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\STUD.mdb")
        Try
            con.Open()
        Catch ex As Exception
            MsgBox("Not connected")
        End Try
    End Sub
    Private Sub stud_report_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        CrystalReportViewer1.Height = Me.Height - 100
        CrystalReportViewer1.Width = Me.Width - 100
        connect()
        tbl = New DataTable
        adpt = New OleDbDataAdapter("SELECT * FROM STUD_BOOK_DETAIL", con)
        adpt.Fill(tbl)
        rpt.SetDataSource(tbl)
        CrystalReportViewer1.ReportSource = rpt
    End Sub



    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Me.WindowState = FormWindowState.Maximized
        CrystalReportViewer1.Height = Me.Height - 100
        CrystalReportViewer1.Width = Me.Width - 100
        connect()
        tbl = New DataTable
        adpt = New OleDbDataAdapter("SELECT * FROM STUD_BOOK_DETAIL WHERE STUD_NAME='" & stud.cmbsname.Text & "'", con)
        adpt.Fill(tbl)

        rpt.SetDataSource(tbl)
        rpt.Load("..\..\CrystalReport1.rpt")
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class