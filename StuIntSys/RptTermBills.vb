Public Class RptTermBills

    Private Sub RptTermBills_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Me.EvMavdbDataSet1.Clear()

    End Sub

    Private Sub RptTermBills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        lblid.Text = TerminalBills.lblbillid.Text
        Try
            Me.tbTermBillTableAdapter.qrybill(Me.EvMavdbDataSet1.tbTermBill, lblid.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.tbTermBillTableAdapter.FillByBID(Me.EvMavdbDataSet1.tbTermBill, StudentIDToolStripTextBox.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

   
End Class