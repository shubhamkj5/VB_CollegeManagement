<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmanage))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HometownDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GFirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GResidenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateEnrollDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbEnrollBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SisDataSet3 = New StuIntSys.sisDataSet3()
        Me.TbEnrollTableAdapter = New StuIntSys.sisDataSetTableAdapters.tbEnrollTableAdapter()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cmdSearchs = New System.Windows.Forms.Button()
        Me.cmdsaves = New System.Windows.Forms.Button()
        Me.cmdUpdates = New System.Windows.Forms.Button()
        Me.cmdDeletes = New System.Windows.Forms.Button()
        Me.cmdcloses = New System.Windows.Forms.Button()
        Me.TbEnrollTableAdapter1 = New StuIntSys.sisDataSet3TableAdapters.tbEnrollTableAdapter()
        Me.TbEnrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtgemail = New System.Windows.Forms.TextBox()
        Me.txtgcontact = New System.Windows.Forms.TextBox()
        Me.txtgresidence = New System.Windows.Forms.TextBox()
        Me.txtglname = New System.Windows.Forms.TextBox()
        Me.txtgfname = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.ComboBox()
        Me.txtfees = New System.Windows.Forms.TextBox()
        Me.txtenroll = New System.Windows.Forms.DateTimePicker()
        Me.txtsem = New System.Windows.Forms.ComboBox()
        Me.txtdob = New System.Windows.Forms.DateTimePicker()
        Me.txtgender = New System.Windows.Forms.ComboBox()
        Me.txttitle = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtoname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txthome = New System.Windows.Forms.TextBox()
        Me.txtstuid = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbEnrollBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SisDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbEnrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.OthernameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.HometownDataGridViewTextBoxColumn, Me.SemDataGridViewTextBoxColumn, Me.GFirstnameDataGridViewTextBoxColumn, Me.GLastnameDataGridViewTextBoxColumn, Me.GTelDataGridViewTextBoxColumn, Me.GEmailDataGridViewTextBoxColumn, Me.GResidenceDataGridViewTextBoxColumn, Me.DateEnrollDataGridViewTextBoxColumn, Me.PictureDataGridViewImageColumn, Me.FeesDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbEnrollBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(2, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(605, 503)
        Me.DataGridView1.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'OthernameDataGridViewTextBoxColumn
        '
        Me.OthernameDataGridViewTextBoxColumn.DataPropertyName = "Othername"
        Me.OthernameDataGridViewTextBoxColumn.HeaderText = "Othername"
        Me.OthernameDataGridViewTextBoxColumn.Name = "OthernameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'HometownDataGridViewTextBoxColumn
        '
        Me.HometownDataGridViewTextBoxColumn.DataPropertyName = "Hometown"
        Me.HometownDataGridViewTextBoxColumn.HeaderText = "Hometown"
        Me.HometownDataGridViewTextBoxColumn.Name = "HometownDataGridViewTextBoxColumn"
        '
        'SemDataGridViewTextBoxColumn
        '
        Me.SemDataGridViewTextBoxColumn.DataPropertyName = "Sem"
        Me.SemDataGridViewTextBoxColumn.HeaderText = "Sem"
        Me.SemDataGridViewTextBoxColumn.Name = "SemDataGridViewTextBoxColumn"
        '
        'GFirstnameDataGridViewTextBoxColumn
        '
        Me.GFirstnameDataGridViewTextBoxColumn.DataPropertyName = "GFirstname"
        Me.GFirstnameDataGridViewTextBoxColumn.HeaderText = "GFirstname"
        Me.GFirstnameDataGridViewTextBoxColumn.Name = "GFirstnameDataGridViewTextBoxColumn"
        '
        'GLastnameDataGridViewTextBoxColumn
        '
        Me.GLastnameDataGridViewTextBoxColumn.DataPropertyName = "GLastname"
        Me.GLastnameDataGridViewTextBoxColumn.HeaderText = "GLastname"
        Me.GLastnameDataGridViewTextBoxColumn.Name = "GLastnameDataGridViewTextBoxColumn"
        '
        'GTelDataGridViewTextBoxColumn
        '
        Me.GTelDataGridViewTextBoxColumn.DataPropertyName = "GTel"
        Me.GTelDataGridViewTextBoxColumn.HeaderText = "GTel"
        Me.GTelDataGridViewTextBoxColumn.Name = "GTelDataGridViewTextBoxColumn"
        '
        'GEmailDataGridViewTextBoxColumn
        '
        Me.GEmailDataGridViewTextBoxColumn.DataPropertyName = "GEmail"
        Me.GEmailDataGridViewTextBoxColumn.HeaderText = "GEmail"
        Me.GEmailDataGridViewTextBoxColumn.Name = "GEmailDataGridViewTextBoxColumn"
        '
        'GResidenceDataGridViewTextBoxColumn
        '
        Me.GResidenceDataGridViewTextBoxColumn.DataPropertyName = "GResidence"
        Me.GResidenceDataGridViewTextBoxColumn.HeaderText = "GResidence"
        Me.GResidenceDataGridViewTextBoxColumn.Name = "GResidenceDataGridViewTextBoxColumn"
        '
        'DateEnrollDataGridViewTextBoxColumn
        '
        Me.DateEnrollDataGridViewTextBoxColumn.DataPropertyName = "DateEnroll"
        Me.DateEnrollDataGridViewTextBoxColumn.HeaderText = "DateEnroll"
        Me.DateEnrollDataGridViewTextBoxColumn.Name = "DateEnrollDataGridViewTextBoxColumn"
        '
        'PictureDataGridViewImageColumn
        '
        Me.PictureDataGridViewImageColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewImageColumn.HeaderText = "Picture"
        Me.PictureDataGridViewImageColumn.Name = "PictureDataGridViewImageColumn"
        '
        'FeesDataGridViewTextBoxColumn
        '
        Me.FeesDataGridViewTextBoxColumn.DataPropertyName = "Fees"
        Me.FeesDataGridViewTextBoxColumn.HeaderText = "Fees"
        Me.FeesDataGridViewTextBoxColumn.Name = "FeesDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'TbEnrollBindingSource1
        '
        Me.TbEnrollBindingSource1.DataMember = "tbEnroll"
        Me.TbEnrollBindingSource1.DataSource = Me.SisDataSet3
        '
        'SisDataSet3
        '
        Me.SisDataSet3.DataSetName = "sisDataSet3"
        Me.SisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbEnrollTableAdapter
        '
        Me.TbEnrollTableAdapter.ClearBeforeFill = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(14, 34)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 20)
        Me.txtsearch.TabIndex = 0
        '
        'cmdSearchs
        '
        Me.cmdSearchs.Location = New System.Drawing.Point(120, 32)
        Me.cmdSearchs.Name = "cmdSearchs"
        Me.cmdSearchs.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearchs.TabIndex = 1
        Me.cmdSearchs.Text = "Search"
        Me.cmdSearchs.UseVisualStyleBackColor = True
        '
        'cmdsaves
        '
        Me.cmdsaves.Location = New System.Drawing.Point(223, 31)
        Me.cmdsaves.Name = "cmdsaves"
        Me.cmdsaves.Size = New System.Drawing.Size(75, 23)
        Me.cmdsaves.TabIndex = 2
        Me.cmdsaves.Text = "Save"
        Me.cmdsaves.UseVisualStyleBackColor = True
        '
        'cmdUpdates
        '
        Me.cmdUpdates.Location = New System.Drawing.Point(304, 32)
        Me.cmdUpdates.Name = "cmdUpdates"
        Me.cmdUpdates.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdates.TabIndex = 3
        Me.cmdUpdates.Text = "Update"
        Me.cmdUpdates.UseVisualStyleBackColor = True
        '
        'cmdDeletes
        '
        Me.cmdDeletes.Location = New System.Drawing.Point(385, 32)
        Me.cmdDeletes.Name = "cmdDeletes"
        Me.cmdDeletes.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeletes.TabIndex = 4
        Me.cmdDeletes.Text = "Delete"
        Me.cmdDeletes.UseVisualStyleBackColor = True
        '
        'cmdcloses
        '
        Me.cmdcloses.Location = New System.Drawing.Point(491, 32)
        Me.cmdcloses.Name = "cmdcloses"
        Me.cmdcloses.Size = New System.Drawing.Size(75, 23)
        Me.cmdcloses.TabIndex = 5
        Me.cmdcloses.Text = "Close"
        Me.cmdcloses.UseVisualStyleBackColor = True
        '
        'TbEnrollTableAdapter1
        '
        Me.TbEnrollTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Brown
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtstatus)
        Me.GroupBox2.Controls.Add(Me.txtfees)
        Me.GroupBox2.Controls.Add(Me.txtenroll)
        Me.GroupBox2.Controls.Add(Me.txtsem)
        Me.GroupBox2.Controls.Add(Me.txtdob)
        Me.GroupBox2.Controls.Add(Me.txtgender)
        Me.GroupBox2.Controls.Add(Me.txttitle)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtoname)
        Me.GroupBox2.Controls.Add(Me.txtlname)
        Me.GroupBox2.Controls.Add(Me.txtfname)
        Me.GroupBox2.Controls.Add(Me.txthome)
        Me.GroupBox2.Controls.Add(Me.txtstuid)
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(613, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 571)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Info"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.StuIntSys.My.Resources.Resources.noimage
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(288, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 95)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtgemail)
        Me.GroupBox3.Controls.Add(Me.txtgcontact)
        Me.GroupBox3.Controls.Add(Me.txtgresidence)
        Me.GroupBox3.Controls.Add(Me.txtglname)
        Me.GroupBox3.Controls.Add(Me.txtgfname)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 206)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Guardian"
        '
        'txtgemail
        '
        Me.txtgemail.Location = New System.Drawing.Point(92, 145)
        Me.txtgemail.Name = "txtgemail"
        Me.txtgemail.Size = New System.Drawing.Size(100, 20)
        Me.txtgemail.TabIndex = 7
        '
        'txtgcontact
        '
        Me.txtgcontact.Location = New System.Drawing.Point(92, 118)
        Me.txtgcontact.Name = "txtgcontact"
        Me.txtgcontact.Size = New System.Drawing.Size(100, 20)
        Me.txtgcontact.TabIndex = 6
        '
        'txtgresidence
        '
        Me.txtgresidence.Location = New System.Drawing.Point(92, 90)
        Me.txtgresidence.Name = "txtgresidence"
        Me.txtgresidence.Size = New System.Drawing.Size(100, 20)
        Me.txtgresidence.TabIndex = 5
        '
        'txtglname
        '
        Me.txtglname.Location = New System.Drawing.Point(92, 63)
        Me.txtglname.Name = "txtglname"
        Me.txtglname.Size = New System.Drawing.Size(100, 20)
        Me.txtglname.TabIndex = 4
        '
        'txtgfname
        '
        Me.txtgfname.Location = New System.Drawing.Point(92, 35)
        Me.txtgfname.Name = "txtgfname"
        Me.txtgfname.Size = New System.Drawing.Size(100, 20)
        Me.txtgfname.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Email"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 118)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Contact No"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Residence"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Lastname"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Firstname"
        '
        'txtstatus
        '
        Me.txtstatus.FormattingEnabled = True
        Me.txtstatus.Items.AddRange(New Object() {"Active", "Closed"})
        Me.txtstatus.Location = New System.Drawing.Point(288, 283)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(121, 21)
        Me.txtstatus.TabIndex = 13
        '
        'txtfees
        '
        Me.txtfees.Location = New System.Drawing.Point(71, 286)
        Me.txtfees.Name = "txtfees"
        Me.txtfees.Size = New System.Drawing.Size(100, 20)
        Me.txtfees.TabIndex = 9
        '
        'txtenroll
        '
        Me.txtenroll.Location = New System.Drawing.Point(288, 241)
        Me.txtenroll.Name = "txtenroll"
        Me.txtenroll.Size = New System.Drawing.Size(132, 20)
        Me.txtenroll.TabIndex = 12
        '
        'txtsem
        '
        Me.txtsem.FormattingEnabled = True
        Me.txtsem.Items.AddRange(New Object() {"First", "Second", "Third", "Fourth", "Fifth", "Sixth"})
        Me.txtsem.Location = New System.Drawing.Point(288, 201)
        Me.txtsem.Name = "txtsem"
        Me.txtsem.Size = New System.Drawing.Size(121, 21)
        Me.txtsem.TabIndex = 11
        '
        'txtdob
        '
        Me.txtdob.Location = New System.Drawing.Point(71, 250)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(135, 20)
        Me.txtdob.TabIndex = 8
        '
        'txtgender
        '
        Me.txtgender.FormattingEnabled = True
        Me.txtgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtgender.Location = New System.Drawing.Point(71, 217)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(121, 21)
        Me.txtgender.TabIndex = 7
        '
        'txttitle
        '
        Me.txttitle.FormattingEnabled = True
        Me.txttitle.Items.AddRange(New Object() {"Mr.", "Mrs.", "Ms"})
        Me.txttitle.Location = New System.Drawing.Point(71, 102)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(121, 21)
        Me.txttitle.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(245, 286)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Fees"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(223, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Date Enroll"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(254, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Sem"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(224, 167)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Hometown"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 256)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "DOB"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 226)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Gender"
        '
        'txtoname
        '
        Me.txtoname.Location = New System.Drawing.Point(71, 188)
        Me.txtoname.Name = "txtoname"
        Me.txtoname.Size = New System.Drawing.Size(100, 20)
        Me.txtoname.TabIndex = 5
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(71, 160)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(100, 20)
        Me.txtlname.TabIndex = 4
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(71, 132)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(100, 20)
        Me.txtfname.TabIndex = 3
        '
        'txthome
        '
        Me.txthome.Location = New System.Drawing.Point(288, 164)
        Me.txthome.Name = "txthome"
        Me.txthome.Size = New System.Drawing.Size(100, 20)
        Me.txthome.TabIndex = 10
        '
        'txtstuid
        '
        Me.txtstuid.Location = New System.Drawing.Point(71, 68)
        Me.txtstuid.Name = "txtstuid"
        Me.txtstuid.Size = New System.Drawing.Size(100, 20)
        Me.txtstuid.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(71, 36)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(62, 20)
        Me.txtid.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 191)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Othername"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 163)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "LastName"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 135)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "FirstName"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 102)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Title"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 71)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Student ID"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 36)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(18, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "ID"
        '
        'frmmanage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1053, 595)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdcloses)
        Me.Controls.Add(Me.cmdDeletes)
        Me.Controls.Add(Me.cmdUpdates)
        Me.Controls.Add(Me.cmdsaves)
        Me.Controls.Add(Me.cmdSearchs)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmanage"
        Me.Text = "Manage Students"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbEnrollBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SisDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbEnrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TbEnrollBindingSource As BindingSource
    Friend WithEvents TbEnrollTableAdapter As sisDataSetTableAdapters.tbEnrollTableAdapter
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents cmdSearchs As Button
    Friend WithEvents cmdsaves As Button
    Friend WithEvents cmdUpdates As Button
    Friend WithEvents cmdDeletes As Button
    Friend WithEvents cmdcloses As Button
    Friend WithEvents SisDataSet3 As sisDataSet3
    Friend WithEvents TbEnrollBindingSource1 As BindingSource
    Friend WithEvents TbEnrollTableAdapter1 As sisDataSet3TableAdapters.tbEnrollTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OthernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HometownDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GFirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GLastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GResidenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateEnrollDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents FeesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtgemail As TextBox
    Friend WithEvents txtgcontact As TextBox
    Friend WithEvents txtgresidence As TextBox
    Friend WithEvents txtglname As TextBox
    Friend WithEvents txtgfname As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtstatus As ComboBox
    Friend WithEvents txtfees As TextBox
    Friend WithEvents txtenroll As DateTimePicker
    Friend WithEvents txtsem As ComboBox
    Friend WithEvents txtdob As DateTimePicker
    Friend WithEvents txtgender As ComboBox
    Friend WithEvents txttitle As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtoname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txthome As TextBox
    Friend WithEvents txtstuid As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
End Class
