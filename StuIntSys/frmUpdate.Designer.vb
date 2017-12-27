<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstuid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.La = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.lvUser = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ln = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.oth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gen = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gfn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gln = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gtel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gemail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.resid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.stat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.StuIntSys.My.Resources.Resources.WDF_2472894
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtstuid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.La)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(200, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Student Id"
        '
        'txtstuid
        '
        Me.txtstuid.Location = New System.Drawing.Point(193, 49)
        Me.txtstuid.Name = "txtstuid"
        Me.txtstuid.Size = New System.Drawing.Size(88, 20)
        Me.txtstuid.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(546, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Semester"
        '
        'txtsem
        '
        Me.txtsem.Location = New System.Drawing.Point(526, 49)
        Me.txtsem.Name = "txtsem"
        Me.txtsem.Size = New System.Drawing.Size(88, 20)
        Me.txtsem.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(651, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Residence"
        '
        'txtres
        '
        Me.txtres.Location = New System.Drawing.Point(644, 49)
        Me.txtres.Name = "txtres"
        Me.txtres.Size = New System.Drawing.Size(88, 20)
        Me.txtres.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(308, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Firstname"
        '
        'La
        '
        Me.La.AutoSize = True
        Me.La.BackColor = System.Drawing.Color.Transparent
        Me.La.ForeColor = System.Drawing.Color.White
        Me.La.Location = New System.Drawing.Point(430, 25)
        Me.La.Name = "La"
        Me.La.Size = New System.Drawing.Size(61, 13)
        Me.La.TabIndex = 18
        Me.La.Text = "Lastname"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(410, 49)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(88, 20)
        Me.txtlname.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(102, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Search By:"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(311, 49)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(84, 20)
        Me.txtfname.TabIndex = 1
        '
        'lvUser
        '
        Me.lvUser.BackColor = System.Drawing.Color.SandyBrown
        Me.lvUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.FN, Me.ln, Me.oth, Me.gen, Me.sem, Me.Gfn, Me.Gln, Me.Gtel, Me.Gemail, Me.resid, Me.stat})
        Me.lvUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvUser.ForeColor = System.Drawing.Color.Maroon
        Me.lvUser.FullRowSelect = True
        Me.lvUser.Location = New System.Drawing.Point(49, 90)
        Me.lvUser.Name = "lvUser"
        Me.lvUser.Size = New System.Drawing.Size(765, 419)
        Me.lvUser.TabIndex = 0
        Me.lvUser.UseCompatibleStateImageBehavior = False
        Me.lvUser.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "Student ID"
        Me.id.Width = 100
        '
        'FN
        '
        Me.FN.Text = "Firstname"
        Me.FN.Width = 100
        '
        'ln
        '
        Me.ln.Text = "Lastname"
        Me.ln.Width = 100
        '
        'oth
        '
        Me.oth.Text = "Othername"
        Me.oth.Width = 100
        '
        'gen
        '
        Me.gen.Text = "Gender"
        '
        'sem
        '
        Me.sem.Text = "Semester"
        Me.sem.Width = 100
        '
        'Gfn
        '
        Me.Gfn.Text = "Guardian Firstname"
        Me.Gfn.Width = 100
        '
        'Gln
        '
        Me.Gln.Text = "Guardian Lastname"
        Me.Gln.Width = 100
        '
        'Gtel
        '
        Me.Gtel.Text = "Tel"
        Me.Gtel.Width = 100
        '
        'Gemail
        '
        Me.Gemail.Text = "Email"
        Me.Gemail.Width = 100
        '
        'resid
        '
        Me.resid.Text = "Residence"
        Me.resid.Width = 100
        '
        'stat
        '
        Me.stat.Text = "Status"
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.StuIntSys.My.Resources.Resources.WDF_2472894
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 510)
        Me.Controls.Add(Me.lvUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmUpdate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Students"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvUser As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents FN As System.Windows.Forms.ColumnHeader
    Friend WithEvents ln As System.Windows.Forms.ColumnHeader
    Friend WithEvents sem As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents oth As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gfn As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gln As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gtel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gemail As System.Windows.Forms.ColumnHeader
    Friend WithEvents resid As System.Windows.Forms.ColumnHeader
    Friend WithEvents gen As System.Windows.Forms.ColumnHeader
    Friend WithEvents stat As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents La As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtstuid As TextBox
End Class
