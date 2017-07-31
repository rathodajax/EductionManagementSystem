Imports System.Data.OleDb


Public Class Concls

    'Dim con As OleDbConnection
    Dim adp As New OleDbDataAdapter
    Dim query As String = ""
    Dim cmd As New OleDbCommand
    Dim dt As DataTable
    Public uname As String
    Dim ds As DataSet




    Public Sub New()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\DEPT.mdb")
        con.Open()
    End Sub
    Public Function GetTable(ByVal str As String) As DataTable
        Try
            query = "SELECT * FROM " + str

            adp = New OleDbDataAdapter(query, con)

            ds = New DataSet()
            ds.Clear()

            adp.Fill(ds)
            dt = New DataTable
            dt.Clear()

            dt = ds.Tables(0)
            Return dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
 
    Public Function GetTableQury(ByVal str As String) As DataTable
        adp = New OleDbDataAdapter(str, con)
        ds = New DataSet()
        ds.Clear()

        adp.Fill(ds)
        dt = New DataTable
        dt.Clear()

        dt = ds.Tables(0)
        Return dt
    End Function
    Public Function GetTableQuryExecScalar(ByVal str As String) As Integer
        Dim i As Integer = 0
        cmd = New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = str
        i = cmd.ExecuteScalar

        Return i
    End Function
    Public Function GetTableQuryExecScalarStr(ByVal str As String) As String
        Dim str1 As String = ""
        cmd = New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = str
        str1 = cmd.ExecuteScalar

        Return str1
    End Function
    Public Sub setUname(ByVal str As String)
        Me.uname = ""
        Me.uname = str
    End Sub
    Public Function getUname() As String
        Return Me.uname
    End Function
    Public Function InsertData(ByVal str As String) As Integer
        Dim i As Integer = 0
        cmd = New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = str
        i = cmd.ExecuteNonQuery()
        Return i


    End Function
    Public Function updateData(ByVal str As String) As Integer
        Dim i As Integer = 0
        cmd = New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = str
        i = cmd.ExecuteNonQuery()
        Return i
    End Function









End Class


