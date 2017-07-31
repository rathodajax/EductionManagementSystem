Imports System.Data.OleDb
Imports System.Data
Module Globalclass
    'Dim con As New OleDbConnection
    'Dim adpt As New OleDbDataAdapter
    'Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    'Dim tbl As DataTable

    'Public Sub connect()
    '    con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT 1.mdb")
    '    'con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\MCA\EDU_PROJECT\EditByClassmate\EDUACHMODULE\DEPT 1.mdb")

    '    Try
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    '        con.Open()
    '    Catch ex As Exception
    '        MsgBox("Not Connected")
    '    End Try
    'End Sub

    'Public Function getdata(ByVal qry As String) As DataTable
    '    connect()
    '    adpt = New OleDbDataAdapter(qry, con)
    '    tbl = New DataTable
    '    adpt.Fill(tbl)
    '    Return tbl
    'End Function

    'Public Sub executeInsert(ByVal qry As String)
    '    Try
    '        connect()
    '    Catch ex As Exception
    '        MsgBox("Not Connected")
    '    End Try

    '    cmd = New OleDbCommand(qry, con)
    '    Try
    '        cmd.ExecuteNonQuery()
    '        MsgBox("Inserted Successfully")
    '    Catch ex As Exception
    '        MsgBox("Error in insertion")
    '    End Try
    'End Sub
    Public Sub executeUpdate(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully")
        Catch ex As Exception
            MsgBox("Error in Updation")
        End Try
    End Sub
    Public Sub executeDelete(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteScalar()
            MsgBox("Deleted Successfully")
        Catch ex As Exception
            MsgBox("Error in Deletion")
        End Try
    End Sub
    Public Sub executeInsert2(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in Insertion")
        End Try
    End Sub
    Public Sub executeUpdate2(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in Updation")
        End Try
    End Sub
    Public Sub executeDelete2(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Error in Deletion")
        End Try
    End Sub
    Public Function GetSingleField(ByVal qry As String) As Integer
        Try
            connect()
            cmd = New OleDb.OleDbCommand(qry, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                If dr.Item(0).ToString.Equals("") Then
                    Return 1
                Else
                    Return Val(dr.Item(0))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "GetSingleField")
            Return -1
        End Try
    End Function
End Module

