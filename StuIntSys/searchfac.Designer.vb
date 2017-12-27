<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchfac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchfac))
        Me.lvList = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lvList
        '
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.fn})
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lvList.FullRowSelect = True
        Me.lvList.Location = New System.Drawing.Point(0, 16)
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(264, 505)
        Me.lvList.TabIndex = 4
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "StaffID"
        Me.id.Width = 100
        '
        'fn
        '
        Me.fn.Text = "Firstname"
        Me.fn.Width = 100
        '
        'txtsearch
        '
        Me.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsearch.Location = New System.Drawing.Point(0, 0)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(264, 20)
        Me.txtsearch.TabIndex = 3
        '
        'searchfac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 521)
        Me.Controls.Add(Me.lvList)
        Me.Controls.Add(Me.txtsearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "searchfac"
        Me.Text = "Search Faculty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvList As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents fn As ColumnHeader
    Friend WithEvents txtsearch As TextBox
End Class
