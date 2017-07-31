Imports System.Data.OleDb
Module connection1
    'Public con As OleDbConnection
    Dim adpt As OleDbDataAdapter
    Dim tbl As DataTable
    Dim cmd As New OleDbCommand
    Public Sub connect()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dept.mdb")
        Try
            con.Open()
        Catch
            MsgBox("Not Connected")
        End Try
    End Sub

    'Public Function getdata(ByVal qry As String) As DataTable
    '    connect()
    '    adpt = New OleDbDataAdapter(qry, con)
    '    tbl = New DataTable
    '    adpt.Fill(tbl)
    '    Return tbl
    'End Function
    Public Sub insertqry(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        'Try
        cmd.ExecuteNonQuery()
        MsgBox("inserted successfully....")

        'Catch ex As Exception
        '    MsgBox("error in inserting" + ex.ToString)

        'End Try
    End Sub
    Public Sub insertqry2(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        'Try
        cmd.ExecuteNonQuery()
        ' MsgBox("inserted successfully....")

        'Catch ex As Exception
        '    MsgBox("error in inserting" + ex.ToString)

        'End Try
    End Sub
    Public Sub updateqry(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        'Try
        cmd.ExecuteNonQuery()
        MsgBox("update successfully....")

        'Catch ex As Exception
        '    MsgBox("error in update" + ex.ToString)
        'End Try
    End Sub

    Public Sub deleteqry(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("delete successfully....")

        Catch ex As Exception
            MsgBox("error in delete")
        End Try
    End Sub

    Public Function getInt(ByVal qry As String) As Integer
        connect()
        adpt = New OleDbDataAdapter(qry, con)
        tbl = New DataTable
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Return Val(tbl.Rows(0).Item(0).ToString())
        Else
            Return 0
        End If
    End Function
    Public Function getstr(ByVal qry As String) As String

        connect()
        adpt = New OleDbDataAdapter(qry, con)
        tbl = New DataTable
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Return tbl.Rows(0).Item(0).ToString()
        Else
            Return ""
        End If
    End Function
End Module
