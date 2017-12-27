<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrading))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtyr = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPromot = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.DPKVac = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbotrm = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.DPKNTB = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtClassT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRem = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTot = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtExams = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtClassW = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboSubject = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thirty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seventy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtHMName = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtHMRem = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTeachRem = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtAtt2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtAtt1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Indigo
        Me.GroupBox1.Controls.Add(Me.txtyr)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtPromot)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.DPKVac)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.cbotrm)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.DPKNTB)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtClassT)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtLN)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFN)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(2, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 129)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtyr
        '
        Me.txtyr.Location = New System.Drawing.Point(207, 67)
        Me.txtyr.MaxLength = 4
        Me.txtyr.Name = "txtyr"
        Me.txtyr.Size = New System.Drawing.Size(72, 20)
        Me.txtyr.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(166, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Year"
        '
        'txtPromot
        '
        Me.txtPromot.Location = New System.Drawing.Point(536, 95)
        Me.txtPromot.Name = "txtPromot"
        Me.txtPromot.Size = New System.Drawing.Size(148, 20)
        Me.txtPromot.TabIndex = 8
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(453, 97)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(75, 13)
        Me.Label30.TabIndex = 22
        Me.Label30.Text = "Promoted to"
        '
        'DPKVac
        '
        Me.DPKVac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPKVac.Location = New System.Drawing.Point(99, 96)
        Me.DPKVac.Name = "DPKVac"
        Me.DPKVac.Size = New System.Drawing.Size(96, 20)
        Me.DPKVac.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(4, 100)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(88, 13)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "Vacation Date"
        '
        'cbotrm
        '
        Me.cbotrm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotrm.FormattingEnabled = True
        Me.cbotrm.Items.AddRange(New Object() {"First Sem", "Second Sem", "Third Sem", "Fourth Sem", "Fifth Sem", "Sixth Sem"})
        Me.cbotrm.Location = New System.Drawing.Point(346, 67)
        Me.cbotrm.Name = "cbotrm"
        Me.cbotrm.Size = New System.Drawing.Size(81, 21)
        Me.cbotrm.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.StuIntSys.My.Resources.Resources.User
        Me.PictureBox1.Location = New System.Drawing.Point(207, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 22)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(72, 10)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(119, 20)
        Me.txtid.TabIndex = 0
        '
        'DPKNTB
        '
        Me.DPKNTB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPKNTB.Location = New System.Drawing.Point(346, 95)
        Me.DPKNTB.Name = "DPKNTB"
        Me.DPKNTB.Size = New System.Drawing.Size(101, 20)
        Me.DPKNTB.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Next Term Begins"
        '
        'txtClassT
        '
        Me.txtClassT.Location = New System.Drawing.Point(537, 70)
        Me.txtClassT.Name = "txtClassT"
        Me.txtClassT.Size = New System.Drawing.Size(147, 20)
        Me.txtClassT.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(440, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Class Teacher"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Term"
        '
        'txtSem
        '
        Me.txtSem.Location = New System.Drawing.Point(482, 38)
        Me.txtSem.Name = "txtSem"
        Me.txtSem.Size = New System.Drawing.Size(103, 20)
        Me.txtSem.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sem"
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(280, 39)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.ReadOnly = True
        Me.txtLN.Size = New System.Drawing.Size(123, 20)
        Me.txtLN.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lastname"
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(72, 38)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.ReadOnly = True
        Me.txtFN.Size = New System.Drawing.Size(144, 20)
        Me.txtFN.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Firstname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtRem)
        Me.GroupBox2.Controls.Add(Me.txtGrade)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtTot)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtExams)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtClassW)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cboSubject)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dgv)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 523)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grading"
        '
        'Button5
        '
        Me.Button5.ImageIndex = 20
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(654, 117)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 26)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "User.gif")
        Me.ImageList1.Images.SetKeyName(1, "wordpd.gif")
        Me.ImageList1.Images.SetKeyName(2, "3d chart.ico")
        Me.ImageList1.Images.SetKeyName(3, "add2.ico")
        Me.ImageList1.Images.SetKeyName(4, "add_32.ico")
        Me.ImageList1.Images.SetKeyName(5, "admin.ico")
        Me.ImageList1.Images.SetKeyName(6, "BlocNote.ico")
        Me.ImageList1.Images.SetKeyName(7, "CALC 32x32.ico")
        Me.ImageList1.Images.SetKeyName(8, "Chart1 16.ico")
        Me.ImageList1.Images.SetKeyName(9, "configuration.ico")
        Me.ImageList1.Images.SetKeyName(10, "connect.ico")
        Me.ImageList1.Images.SetKeyName(11, "Contact-Add.ico")
        Me.ImageList1.Images.SetKeyName(12, "Course.ico")
        Me.ImageList1.Images.SetKeyName(13, "createReport.ico")
        Me.ImageList1.Images.SetKeyName(14, "Database.ico")
        Me.ImageList1.Images.SetKeyName(15, "Database-Security.ico")
        Me.ImageList1.Images.SetKeyName(16, "Database-Wizard.ico")
        Me.ImageList1.Images.SetKeyName(17, "Datbase.ico")
        Me.ImageList1.Images.SetKeyName(18, "Datbase 16.ico")
        Me.ImageList1.Images.SetKeyName(19, "db-Post.ico")
        Me.ImageList1.Images.SetKeyName(20, "Delete.ico")
        Me.ImageList1.Images.SetKeyName(21, "disconnect.ico")
        Me.ImageList1.Images.SetKeyName(22, "disk_32.ico")
        Me.ImageList1.Images.SetKeyName(23, "help 32.ico")
        Me.ImageList1.Images.SetKeyName(24, "History.ico")
        Me.ImageList1.Images.SetKeyName(25, "home.ico")
        Me.ImageList1.Images.SetKeyName(26, "Home1.ico")
        Me.ImageList1.Images.SetKeyName(27, "Home_New1.ico")
        Me.ImageList1.Images.SetKeyName(28, "House.ICO")
        Me.ImageList1.Images.SetKeyName(29, "inventory.ico")
        Me.ImageList1.Images.SetKeyName(30, "inventory_48.ico")
        Me.ImageList1.Images.SetKeyName(31, "OFF 32.ico")
        Me.ImageList1.Images.SetKeyName(32, "ok 16.ico")
        Me.ImageList1.Images.SetKeyName(33, "Printer1.ICO")
        Me.ImageList1.Images.SetKeyName(34, "Printer_New1.ICO")
        Me.ImageList1.Images.SetKeyName(35, "refresh.ico")
        Me.ImageList1.Images.SetKeyName(36, "safe.ico")
        Me.ImageList1.Images.SetKeyName(37, "Save.ico")
        Me.ImageList1.Images.SetKeyName(38, "Settings.ico")
        Me.ImageList1.Images.SetKeyName(39, "star_32.ico")
        Me.ImageList1.Images.SetKeyName(40, "stude.ico")
        Me.ImageList1.Images.SetKeyName(41, "studen.ico")
        Me.ImageList1.Images.SetKeyName(42, "Student.ico")
        Me.ImageList1.Images.SetKeyName(43, "submit.ico")
        Me.ImageList1.Images.SetKeyName(44, "Tag-Green 16.ico")
        Me.ImageList1.Images.SetKeyName(45, "tag-orange_16.ico")
        Me.ImageList1.Images.SetKeyName(46, "Tag-Red 16.ico")
        Me.ImageList1.Images.SetKeyName(47, "Tag-Yellow.ico")
        Me.ImageList1.Images.SetKeyName(48, "today.ico")
        Me.ImageList1.Images.SetKeyName(49, "Unlock_New1.ico")
        Me.ImageList1.Images.SetKeyName(50, "user2 16.ico")
        Me.ImageList1.Images.SetKeyName(51, "User3.ico")
        Me.ImageList1.Images.SetKeyName(52, "User 16.ico")
        Me.ImageList1.Images.SetKeyName(53, "user delete.ico")
        Me.ImageList1.Images.SetKeyName(54, "user edit.ico")
        Me.ImageList1.Images.SetKeyName(55, "warning_32.ico")
        Me.ImageList1.Images.SetKeyName(56, "Waste Bin.ico")
        Me.ImageList1.Images.SetKeyName(57, "welch edit.ico")
        Me.ImageList1.Images.SetKeyName(58, "welch print.ico")
        Me.ImageList1.Images.SetKeyName(59, "welch search.ico")
        Me.ImageList1.Images.SetKeyName(60, "windows-media-player.ico")
        Me.ImageList1.Images.SetKeyName(61, "Zoom.ico")
        Me.ImageList1.Images.SetKeyName(62, "1.jpg")
        Me.ImageList1.Images.SetKeyName(63, "2.jpg")
        Me.ImageList1.Images.SetKeyName(64, "3.jpg")
        Me.ImageList1.Images.SetKeyName(65, "4.jpg")
        Me.ImageList1.Images.SetKeyName(66, "5.jpg")
        Me.ImageList1.Images.SetKeyName(67, "6.jpg")
        Me.ImageList1.Images.SetKeyName(68, "7.jpg")
        Me.ImageList1.Images.SetKeyName(69, "8.jpg")
        Me.ImageList1.Images.SetKeyName(70, "9.jpg")
        Me.ImageList1.Images.SetKeyName(71, "10.jpg")
        Me.ImageList1.Images.SetKeyName(72, "11.jpg")
        Me.ImageList1.Images.SetKeyName(73, "12.jpg")
        Me.ImageList1.Images.SetKeyName(74, "13.jpg")
        Me.ImageList1.Images.SetKeyName(75, "14.jpg")
        Me.ImageList1.Images.SetKeyName(76, "15.jpg")
        Me.ImageList1.Images.SetKeyName(77, "16.jpg")
        Me.ImageList1.Images.SetKeyName(78, "030520121509.jpg")
        Me.ImageList1.Images.SetKeyName(79, "Account User 1.jpg")
        Me.ImageList1.Images.SetKeyName(80, "Account User Add.jpg")
        Me.ImageList1.Images.SetKeyName(81, "Account User Edit.jpg")
        Me.ImageList1.Images.SetKeyName(82, "bud1.jpg")
        Me.ImageList1.Images.SetKeyName(83, "bud2.jpg")
        Me.ImageList1.Images.SetKeyName(84, "db.jpg")
        Me.ImageList1.Images.SetKeyName(85, "h1.jpg")
        Me.ImageList1.Images.SetKeyName(86, "h3.jpg")
        Me.ImageList1.Images.SetKeyName(87, "t1.jpg")
        Me.ImageList1.Images.SetKeyName(88, "train2.jpg")
        Me.ImageList1.Images.SetKeyName(89, "User.jpg")
        Me.ImageList1.Images.SetKeyName(90, "3.png")
        Me.ImageList1.Images.SetKeyName(91, "6.png")
        Me.ImageList1.Images.SetKeyName(92, "cancel-icon.png")
        Me.ImageList1.Images.SetKeyName(93, "close-icon.png")
        Me.ImageList1.Images.SetKeyName(94, "networkexplorer_dll_20_10.png")
        Me.ImageList1.Images.SetKeyName(95, "view_refresh.png")
        '
        'Button4
        '
        Me.Button4.ImageIndex = 19
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(653, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 27)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.SeaShell
        Me.Label14.Location = New System.Drawing.Point(538, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Remarks"
        '
        'txtRem
        '
        Me.txtRem.Location = New System.Drawing.Point(534, 36)
        Me.txtRem.Name = "txtRem"
        Me.txtRem.ReadOnly = True
        Me.txtRem.Size = New System.Drawing.Size(97, 20)
        Me.txtRem.TabIndex = 5
        Me.txtRem.Text = "-"
        Me.txtRem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(466, 35)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(47, 20)
        Me.txtGrade.TabIndex = 4
        Me.txtGrade.Text = "-"
        Me.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.SeaShell
        Me.Label13.Location = New System.Drawing.Point(467, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Grade"
        '
        'txtTot
        '
        Me.txtTot.Location = New System.Drawing.Point(382, 36)
        Me.txtTot.Name = "txtTot"
        Me.txtTot.ReadOnly = True
        Me.txtTot.Size = New System.Drawing.Size(53, 20)
        Me.txtTot.TabIndex = 3
        Me.txtTot.Text = "-"
        Me.txtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.SeaShell
        Me.Label12.Location = New System.Drawing.Point(379, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Total(100%)"
        '
        'txtExams
        '
        Me.txtExams.Location = New System.Drawing.Point(298, 36)
        Me.txtExams.Name = "txtExams"
        Me.txtExams.Size = New System.Drawing.Size(58, 20)
        Me.txtExams.TabIndex = 2
        Me.txtExams.Text = "0"
        Me.txtExams.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.SeaShell
        Me.Label11.Location = New System.Drawing.Point(299, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Exams(70%)"
        '
        'txtClassW
        '
        Me.txtClassW.Location = New System.Drawing.Point(203, 36)
        Me.txtClassW.Name = "txtClassW"
        Me.txtClassW.Size = New System.Drawing.Size(57, 20)
        Me.txtClassW.TabIndex = 1
        Me.txtClassW.Text = "0"
        Me.txtClassW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.SeaShell
        Me.Label10.Location = New System.Drawing.Point(191, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Class Work(30%)"
        '
        'cboSubject
        '
        Me.cboSubject.FormattingEnabled = True
        Me.cboSubject.Items.AddRange(New Object() {"IPT", "C++", "Dec", "DM", "Sad", "Ca", "DS", "Dbms", "Uida", "OPT", "SCS", "FWD"})
        Me.cboSubject.Location = New System.Drawing.Point(45, 36)
        Me.cboSubject.Name = "cboSubject"
        Me.cboSubject.Size = New System.Drawing.Size(146, 21)
        Me.cboSubject.TabIndex = 0
        Me.cboSubject.Text = "--Select Subject--"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.SeaShell
        Me.Label9.Location = New System.Drawing.Point(96, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Subject"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subject, Me.thirty, Me.seventy, Me.tot, Me.grade, Me.Remarks})
        Me.dgv.Location = New System.Drawing.Point(45, 65)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(605, 251)
        Me.dgv.TabIndex = 6
        '
        'subject
        '
        Me.subject.HeaderText = "Subject"
        Me.subject.Name = "subject"
        Me.subject.ReadOnly = True
        '
        'thirty
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Olive
        Me.thirty.DefaultCellStyle = DataGridViewCellStyle1
        Me.thirty.HeaderText = "Class Work(30%)"
        Me.thirty.Name = "thirty"
        Me.thirty.ReadOnly = True
        Me.thirty.Width = 80
        '
        'seventy
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.seventy.DefaultCellStyle = DataGridViewCellStyle2
        Me.seventy.HeaderText = "Exams(70%)"
        Me.seventy.Name = "seventy"
        Me.seventy.ReadOnly = True
        Me.seventy.Width = 80
        '
        'tot
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tot.DefaultCellStyle = DataGridViewCellStyle3
        Me.tot.HeaderText = "Total(100%)"
        Me.tot.Name = "tot"
        Me.tot.ReadOnly = True
        '
        'grade
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grade.DefaultCellStyle = DataGridViewCellStyle4
        Me.grade.HeaderText = "Grade"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        Me.grade.Width = 80
        '
        'Remarks
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Remarks.DefaultCellStyle = DataGridViewCellStyle5
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        Me.Remarks.Width = 120
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(Me.txtHMName)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.txtHMRem)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txtTeachRem)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtAtt2)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.txtAtt1)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(605, 149)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COMMENTS"
        '
        'txtHMName
        '
        Me.txtHMName.Location = New System.Drawing.Point(223, 105)
        Me.txtHMName.Name = "txtHMName"
        Me.txtHMName.Size = New System.Drawing.Size(231, 20)
        Me.txtHMName.TabIndex = 4
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(12, 105)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(181, 13)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Name of Headmaster/Mistress:"
        '
        'txtHMRem
        '
        Me.txtHMRem.Location = New System.Drawing.Point(223, 76)
        Me.txtHMRem.Name = "txtHMRem"
        Me.txtHMRem.Size = New System.Drawing.Size(345, 20)
        Me.txtHMRem.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(10, 79)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(207, 13)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "Headmaster's/Mistresss's Remarks:"
        '
        'txtTeachRem
        '
        Me.txtTeachRem.Location = New System.Drawing.Point(223, 44)
        Me.txtTeachRem.Name = "txtTeachRem"
        Me.txtTeachRem.Size = New System.Drawing.Size(345, 20)
        Me.txtTeachRem.TabIndex = 2
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 51)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(154, 13)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Class Teacher's Remarks:"
        '
        'txtAtt2
        '
        Me.txtAtt2.Location = New System.Drawing.Point(376, 17)
        Me.txtAtt2.Name = "txtAtt2"
        Me.txtAtt2.Size = New System.Drawing.Size(62, 20)
        Me.txtAtt2.TabIndex = 1
        Me.txtAtt2.Text = "80"
        Me.txtAtt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Maroon
        Me.Label27.Location = New System.Drawing.Point(316, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Out of"
        '
        'txtAtt1
        '
        Me.txtAtt1.Location = New System.Drawing.Point(223, 16)
        Me.txtAtt1.Name = "txtAtt1"
        Me.txtAtt1.Size = New System.Drawing.Size(79, 20)
        Me.txtAtt1.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 20)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Attendance:"
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(382, 484)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(207, 483)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmGrading
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button3
        Me.ClientSize = New System.Drawing.Size(703, 661)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGrading"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grading System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents DPKNTB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtClassT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DPKVac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbotrm As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtAtt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtAtt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPromot As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtHMName As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtHMRem As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtTeachRem As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtRem As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTot As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtExams As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtClassW As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboSubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents thirty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents seventy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtyr As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
