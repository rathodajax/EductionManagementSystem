Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Module mdlGlobalModule

    Public cnCon As New OleDbConnection
    Public adptr As New OleDbDataAdapter
    Public dtbl As DataTable
    Public cmdCom As OleDbCommand

    Public rptdoc As ReportDocument

    Public Sub openCon()
        cnCon = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")
        Try
            cnCon.Open()
        Catch ex As Exception
            MsgBox("Not Connected")
        End Try

    End Sub

    Public Function getRecs(ByVal qry As String) As DataTable

        openCon()
        adptr = New OleDbDataAdapter(qry, cnCon)
        dtbl = New DataTable
        adptr.Fill(dtbl)
        Return dtbl

    End Function

    Public Sub performInsert(ByVal qry As String)
        openCon()
        cmdCom = New OleDbCommand(qry, cnCon)
        Try
            cmdCom.ExecuteNonQuery()
            MsgBox("Saved Successfully")
        Catch ex As Exception
            MsgBox("Error In Record Insertion")
        End Try
    End Sub

    Public Sub performInsert1(ByVal qry As String)
        openCon()
        cmdCom = New OleDbCommand(qry, cnCon)
        Try
            cmdCom.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Function getRD(ByVal path As String) As ReportDocument
        openCon()

        rptdoc = New ReportDocument
        rptdoc.Load(path)

        Return rptdoc

    End Function

End Module
