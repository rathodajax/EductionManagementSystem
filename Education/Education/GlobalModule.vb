Imports System.Data.OleDb

Module GlobalModule
    'Public con As New OleDbConnection
    Public adpt As New OleDbDataAdapter
    Public dt As DataTable
    Public sql As String = ""
    Public cmd As OleDbCommand

    Public Sub openCon()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")
        con.Open()
    End Sub

    Public Function getData(ByVal qry As String) As DataTable
        Try
            openCon()
            adpt = New OleDbDataAdapter(qry, con)
            dt = New DataTable
            adpt.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

End Module
