<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewgrade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewgrade))
        Me.lvUser = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.stuid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.classt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vacdate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ntb = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.promo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.subject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.classw = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.exams = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Grade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.remarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.att1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.att2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.classtrem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.headrem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.headname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.yr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtgrade = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsub = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvUser
        '
        Me.lvUser.BackColor = System.Drawing.Color.SandyBrown
        Me.lvUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.stuid, Me.fname, Me.lname, Me.sem, Me.classt, Me.vacdate, Me.ntb, Me.promo, Me.subject, Me.classw, Me.exams, Me.total, Me.Grade, Me.remarks, Me.att1, Me.ColumnHeader1, Me.att2, Me.classtrem, Me.headrem, Me.headname, Me.yr})
        Me.lvUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvUser.ForeColor = System.Drawing.Color.Maroon
        Me.lvUser.FullRowSelect = True
        Me.lvUser.Location = New System.Drawing.Point(0, 76)
        Me.lvUser.Name = "lvUser"
        Me.lvUser.Size = New System.Drawing.Size(886, 460)
        Me.lvUser.TabIndex = 1
        Me.lvUser.UseCompatibleStateImageBehavior = False
        Me.lvUser.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        '
        'stuid
        '
        Me.stuid.Text = "StudentID"
        '
        'fname
        '
        Me.fname.Text = "Firstname"
        '
        'lname
        '
        Me.lname.Text = "Lastname"
        '
        'sem
        '
        Me.sem.Text = "Sem"
        '
        'classt
        '
        Me.classt.Text = "ClassTeacher"
        '
        'vacdate
        '
        Me.vacdate.Text = "VacDate"
        '
        'ntb
        '
        Me.ntb.Text = "Reopening"
        '
        'promo
        '
        Me.promo.Text = "Promoted"
        '
        'subject
        '
        Me.subject.Text = "Subject"
        '
        'classw
        '
        Me.classw.Text = "ClassW"
        '
        'exams
        '
        Me.exams.Text = "Exams"
        '
        'total
        '
        Me.total.Text = "Total"
        '
        'Grade
        '
        Me.Grade.Text = "Grade"
        '
        'remarks
        '
        Me.remarks.Text = "Remarks"
        '
        'att1
        '
        Me.att1.Text = "PresentLec"
        '
        'att2
        '
        Me.att2.Text = "TotalL"
        '
        'classtrem
        '
        Me.classtrem.Text = "ClassTRem"
        '
        'headrem
        '
        Me.headrem.Text = "HeadRem"
        '
        'headname
        '
        Me.headname.Text = "Headname"
        '
        'yr
        '
        Me.yr.Text = "Yr"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.StuIntSys.My.Resources.Resources.WDF_2472894
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtgrade)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtprom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtsub)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(613, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Grade"
        '
        'txtgrade
        '
        Me.txtgrade.Location = New System.Drawing.Point(593, 50)
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.Size = New System.Drawing.Size(88, 20)
        Me.txtgrade.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(380, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sem"
        '
        'txtsem
        '
        Me.txtsem.Location = New System.Drawing.Point(360, 50)
        Me.txtsem.Name = "txtsem"
        Me.txtsem.Size = New System.Drawing.Size(88, 20)
        Me.txtsem.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(488, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Promoted To"
        '
        'txtprom
        '
        Me.txtprom.Location = New System.Drawing.Point(478, 50)
        Me.txtprom.Name = "txtprom"
        Me.txtprom.Size = New System.Drawing.Size(88, 20)
        Me.txtprom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(142, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(264, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Subject"
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(244, 50)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(88, 20)
        Me.txtsub.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search By:"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(129, 50)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(88, 20)
        Me.txtfname.TabIndex = 0
        '
        'viewgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 532)
        Me.Controls.Add(Me.lvUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "viewgrade"
        Me.Text = "View Grades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvUser As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents id As ColumnHeader
    Friend WithEvents stuid As ColumnHeader
    Friend WithEvents fname As ColumnHeader
    Friend WithEvents lname As ColumnHeader
    Friend WithEvents sem As ColumnHeader
    Friend WithEvents classt As ColumnHeader
    Friend WithEvents vacdate As ColumnHeader
    Friend WithEvents ntb As ColumnHeader
    Friend WithEvents promo As ColumnHeader
    Friend WithEvents subject As ColumnHeader
    Friend WithEvents classw As ColumnHeader
    Friend WithEvents exams As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents Grade As ColumnHeader
    Friend WithEvents remarks As ColumnHeader
    Friend WithEvents att1 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents att2 As ColumnHeader
    Friend WithEvents classtrem As ColumnHeader
    Friend WithEvents headrem As ColumnHeader
    Friend WithEvents headname As ColumnHeader
    Friend WithEvents yr As ColumnHeader
    Friend WithEvents txtsub As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsem As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
