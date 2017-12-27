<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptTermBills
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbTermBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EvMavdbDataSet1 = New EvMav_SMS.EvMavdbDataSet1()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbTermBillTableAdapter = New EvMav_SMS.EvMavdbDataSet1TableAdapters.tbTermBillTableAdapter()
        Me.FillByBIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.StudentIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.StudentIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lblid = New System.Windows.Forms.Label()
        CType(Me.tbTermBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvMavdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.FillByBIDToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbTermBillBindingSource
        '
        Me.tbTermBillBindingSource.DataMember = "tbTermBill"
        Me.tbTermBillBindingSource.DataSource = Me.EvMavdbDataSet1
        '
        'EvMavdbDataSet1
        '
        Me.EvMavdbDataSet1.DataSetName = "EvMavdbDataSet1"
        Me.EvMavdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ReportViewer1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 512)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.tbTermBillBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EvMav_SMS.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 16)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(671, 434)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbTermBillTableAdapter
        '
        Me.tbTermBillTableAdapter.ClearBeforeFill = True
        '
        'FillByBIDToolStrip
        '
        Me.FillByBIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentIDToolStripLabel, Me.StudentIDToolStripTextBox, Me.ToolStripButton1})
        Me.FillByBIDToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByBIDToolStrip.Name = "FillByBIDToolStrip"
        Me.FillByBIDToolStrip.Size = New System.Drawing.Size(733, 25)
        Me.FillByBIDToolStrip.TabIndex = 2
        Me.FillByBIDToolStrip.Text = "FillByBIDToolStrip"
        '
        'StudentIDToolStripLabel
        '
        Me.StudentIDToolStripLabel.Name = "StudentIDToolStripLabel"
        Me.StudentIDToolStripLabel.Size = New System.Drawing.Size(60, 22)
        Me.StudentIDToolStripLabel.Text = "StudentID:"
        '
        'StudentIDToolStripTextBox
        '
        Me.StudentIDToolStripTextBox.Name = "StudentIDToolStripTextBox"
        Me.StudentIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.EvMav_SMS.My.Resources.Resources.accept_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(674, 27)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(39, 13)
        Me.lblid.TabIndex = 3
        Me.lblid.Text = "Label1"
        Me.lblid.Visible = False
        '
        'RptTermBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 560)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.FillByBIDToolStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RptTermBills"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RptTermBills"
        CType(Me.tbTermBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvMavdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.FillByBIDToolStrip.ResumeLayout(False)
        Me.FillByBIDToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbTermBillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EvMavdbDataSet1 As EvMav_SMS.EvMavdbDataSet1
    Friend WithEvents tbTermBillTableAdapter As EvMav_SMS.EvMavdbDataSet1TableAdapters.tbTermBillTableAdapter
    Friend WithEvents FillByBIDToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents StudentIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents StudentIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblid As System.Windows.Forms.Label
End Class
