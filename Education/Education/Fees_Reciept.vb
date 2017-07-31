Imports System.Data.OleDb
Public Class Fees_Reciept


    Dim cnn As OleDbConnection
    Dim command As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As Data.DataSet
    Dim sql As String = Nothing
    Dim connetionString = Nothing
    Sub connect()
        connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb"
        cnn = New OleDbConnection(connetionString)
        command = New OleDbCommand()
        cnn.Open()
        da = New OleDbDataAdapter(sql, cnn)
        ds = New Data.DataSet
    End Sub
    Private Sub Fees_Reciept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Reciept_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reciept_Viewer.Load

    End Sub

   
End Class