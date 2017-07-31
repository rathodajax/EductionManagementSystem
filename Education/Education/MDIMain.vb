

Public Class MDIMain



    Private Sub BONAFIDEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BONAFIDEToolStripMenuItem.Click
        frmCertificates.MdiParent = Me
        frmCertificates.Show()
    End Sub

    Private Sub STUDENTQUERYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENTQUERYToolStripMenuItem.Click
        'frmStudQuery.Left = Me.Left - 300
        'frmStudQuery.Width = Me.Width + 600
        'frmStudQuery.Height = Me.Height - 10
        frmStudentReq.MdiParent = Me
        frmStudentReq.WindowState = FormWindowState.Maximized
        frmStudentReq.Show()
    End Sub

    Private Sub HARDWAREENGREPLYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HARDWAREENGREPLYToolStripMenuItem.Click
        frmHardwareRes.MdiParent = Me
        frmHardwareRes.WindowState = FormWindowState.Maximized
        frmHardwareRes.Show()
    End Sub

    Private Sub RECEIVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIVEToolStripMenuItem.Click
        Fees_Recieve.MdiParent = Me
        Fees_Recieve.Show()
    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectionCon()
        GlobalVariable.uname = "Student"

    End Sub

    Private Sub SALARYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALARYToolStripMenuItem.Click

        frmHome.MdiParent = Me
        frmHome.Show()
    End Sub


    Private Sub MAINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAINToolStripMenuItem.Click
        frmLib.MdiParent = Me
        frmLib.Show()
    End Sub

    Private Sub DISPLAYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISPLAYToolStripMenuItem.Click
        display.MdiParent = Me
        display.Show()
    End Sub

    Private Sub COMPANYMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPANYMASTERToolStripMenuItem.Click
        frmcompany.MdiParent = Me
        frmcompany.Show()
    End Sub

    Private Sub COMPANYARRIVALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPANYARRIVALToolStripMenuItem.Click
        frmcompnayArrival.MdiParent = Me
        frmcompnayArrival.Show()
    End Sub

    Private Sub STUDENTSELECTEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENTSELECTEDToolStripMenuItem.Click
        selectedstudent.MdiParent = Me
        selectedstudent.Show()
    End Sub

    Private Sub COMPANYDETAILToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPANYDETAILToolStripMenuItem.Click

    End Sub

    Private Sub SHOWEVENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWEVENTSToolStripMenuItem.Click
        frmgrid.MdiParent = Me
        frmgrid.Show()
    End Sub

    Private Sub ADDEVENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDEVENTSToolStripMenuItem.Click
        frmadd.MdiParent = Me
        frmadd.Show()
    End Sub


    Private Sub ADMISSIONTYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADMISSIONTYPEToolStripMenuItem.Click
        admission_type_master.MdiParent = Me
        admission_type_master.Show()

    End Sub

    Private Sub CITYMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CITYMASTERToolStripMenuItem.Click
        city_master.MdiParent = Me
        city_master.Show()

    End Sub

    Private Sub CASTMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CASTMASTERToolStripMenuItem.Click
        cast_master.MdiParent = Me
        cast_master.Show()

    End Sub

    Private Sub COLLEGEMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COLLEGEMASTERToolStripMenuItem.Click
        college_master.MdiParent = Me
        college_master.Show()

    End Sub

    Private Sub UNIVERSITYMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNIVERSITYMASTERToolStripMenuItem.Click
        university_master.MdiParent = Me
        university_master.Show()

    End Sub

    Private Sub DEGREEMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DEGREEMASTERToolStripMenuItem.Click
        degree_master.MdiParent = Me
        degree_master.Show()

    End Sub

    Private Sub STATEMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STATEMASTERToolStripMenuItem.Click
        state_master.MdiParent = Me
        state_master.Show()

    End Sub

    Private Sub ROUNDMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROUNDMASTERToolStripMenuItem.Click
        round_master.MdiParent = Me
        round_master.Show()

    End Sub

    Private Sub SEMESTERMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEMESTERMASTERToolStripMenuItem.Click
        semester_master.MdiParent = Me
        semester_master.Show()

    End Sub

    Private Sub NEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWToolStripMenuItem.Click
        MyFristForm.MdiParent = Me
        MyFristForm.Show()

    End Sub

    Private Sub SEARCHSTUDENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHSTUDENTToolStripMenuItem.Click
        frmsearch.MdiParent = Me
        frmsearch.Show()

    End Sub

    Private Sub VIEWSTUDENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWSTUDENTToolStripMenuItem.Click
        frmview.MdiParent = Me
        frmview.Show()

    End Sub

    Private Sub UPDATEROLLNOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEROLLNOToolStripMenuItem.Click
        frm_update.MdiParent = Me
        frm_update.Show()

    End Sub

    Private Sub STUDENTWISECERTIFICATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENTWISECERTIFICATEToolStripMenuItem.Click
        frmStudentwise_Certificate_Filter.MdiParent = Me
        frmStudentwise_Certificate_Filter.Show()
    End Sub

    Private Sub YEARWISECERTIFICATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YEARWISECERTIFICATEToolStripMenuItem.Click
        frmYearwise_Certificate_Filter.MdiParent = Me
        frmYearwise_Certificate_Filter.Show()
    End Sub

    Private Sub STBUSPASSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STBUSPASSToolStripMenuItem.Click
        frmCertificate_Gujarati.MdiParent = Me
        frmCertificate_Gujarati.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        AttendanceSearch.MdiParent = Me
        AttendanceSearch.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmProjMng.MdiParent = Me
        frmProjMng.Show()
    End Sub

    Private Sub ACHIVEMENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACHIVEMENTSToolStripMenuItem.Click
        frmAchievement.MdiParent = Me
        frmAchievement.Show()
    End Sub

    Private Sub FEESREFUNDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FEESREFUNDToolStripMenuItem.Click
        Fees_Refund.MdiParent = Me
        Fees_Refund.Show()
    End Sub

    Private Sub FEESDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FEESDETAILSToolStripMenuItem.Click
        Fees_Details.MdiParent = Me
        Fees_Details.Show()
    End Sub
End Class
