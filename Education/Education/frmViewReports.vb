﻿Imports CrystalDecisions.CrystalReports.Engine
Public Class frmViewReports

    Private Sub ViewReports_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
