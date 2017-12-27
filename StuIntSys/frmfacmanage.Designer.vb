<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfacmanage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfacmanage))
        Me.TbEnrollTableAdapter = New StuIntSys.sisDataSetTableAdapters.tbEnrollTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TbStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SisDataSet1 = New StuIntSys.sisDataSet1()
        Me.cmdcloses = New System.Windows.Forms.Button()
        Me.cmdUpdates = New System.Windows.Forms.Button()
        Me.cmdsaves = New System.Windows.Forms.Button()
        Me.cmdSearchs = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cmdDeletes = New System.Windows.Forms.Button()
        Me.TbStaffTableAdapter = New StuIntSys.sisDataSet1TableAdapters.tbStaffTableAdapter()
        Me.TbEnrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.txtgender = New System.Windows.Forms.ComboBox()
        Me.txttitle = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtoname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtstaffid = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Picture = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SisDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbEnrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbEnrollTableAdapter
        '
        Me.TbEnrollTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.Lastname, Me.Other, Me.Gender, Me.Position, Me.Tel, Me.Picture})
        Me.DataGridView1.DataSource = Me.TbStaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(605, 503)
        Me.DataGridView1.TabIndex = 7
        '
        'TbStaffBindingSource
        '
        Me.TbStaffBindingSource.DataMember = "tbStaff"
        Me.TbStaffBindingSource.DataSource = Me.SisDataSet1
        '
        'SisDataSet1
        '
        Me.SisDataSet1.DataSetName = "sisDataSet1"
        Me.SisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'cmdUpdates
        '
        Me.cmdUpdates.Location = New System.Drawing.Point(304, 32)
        Me.cmdUpdates.Name = "cmdUpdates"
        Me.cmdUpdates.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdates.TabIndex = 3
        Me.cmdUpdates.Text = "Update"
        Me.cmdUpdates.UseVisualStyleBackColor = True
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
        'cmdSearchs
        '
        Me.cmdSearchs.Location = New System.Drawing.Point(120, 32)
        Me.cmdSearchs.Name = "cmdSearchs"
        Me.cmdSearchs.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearchs.TabIndex = 1
        Me.cmdSearchs.Text = "Search"
        Me.cmdSearchs.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(14, 34)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 20)
        Me.txtsearch.TabIndex = 0
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
        'TbStaffTableAdapter
        '
        Me.TbStaffTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Brown
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtposition)
        Me.GroupBox1.Controls.Add(Me.txtgender)
        Me.GroupBox1.Controls.Add(Me.txttitle)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtoname)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.txtstaffid)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(613, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 266)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Faculty Info"
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
        'txtposition
        '
        Me.txtposition.Location = New System.Drawing.Point(291, 191)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(100, 20)
        Me.txtposition.TabIndex = 9
        '
        'txtgender
        '
        Me.txtgender.FormattingEnabled = True
        Me.txtgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtgender.Location = New System.Drawing.Point(71, 218)
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(241, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Position"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Contact No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gender"
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
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(288, 164)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(100, 20)
        Me.txtcontact.TabIndex = 8
        '
        'txtstaffid
        '
        Me.txtstaffid.Location = New System.Drawing.Point(71, 68)
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.Size = New System.Drawing.Size(100, 20)
        Me.txtstaffid.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(71, 36)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(62, 20)
        Me.txtid.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Othername"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "LastName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FirstName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Staff ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Staff ID"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'Lastname
        '
        Me.Lastname.DataPropertyName = "Lastname"
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.Name = "Lastname"
        '
        'Other
        '
        Me.Other.DataPropertyName = "Other"
        Me.Other.HeaderText = "Othername"
        Me.Other.Name = "Other"
        '
        'Gender
        '
        Me.Gender.DataPropertyName = "Gender"
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        '
        'Position
        '
        Me.Position.DataPropertyName = "Position"
        Me.Position.HeaderText = "Position"
        Me.Position.Name = "Position"
        '
        'Tel
        '
        Me.Tel.DataPropertyName = "Tel"
        Me.Tel.HeaderText = "Tel"
        Me.Tel.Name = "Tel"
        '
        'Picture
        '
        Me.Picture.DataPropertyName = "Picture"
        Me.Picture.HeaderText = "Picture"
        Me.Picture.Name = "Picture"
        '
        'frmfacmanage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(1043, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdcloses)
        Me.Controls.Add(Me.cmdUpdates)
        Me.Controls.Add(Me.cmdsaves)
        Me.Controls.Add(Me.cmdSearchs)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.cmdDeletes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmfacmanage"
        Me.Text = "frmfacmanage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SisDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbEnrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbEnrollTableAdapter As sisDataSetTableAdapters.tbEnrollTableAdapter
    Friend WithEvents TbEnrollBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmdcloses As Button
    Friend WithEvents cmdUpdates As Button
    Friend WithEvents cmdsaves As Button
    Friend WithEvents cmdSearchs As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents cmdDeletes As Button
    Friend WithEvents SisDataSet1 As sisDataSet1
    Friend WithEvents TbStaffBindingSource As BindingSource
    Friend WithEvents TbStaffTableAdapter As sisDataSet1TableAdapters.tbStaffTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtposition As TextBox
    Friend WithEvents txtgender As ComboBox
    Friend WithEvents txttitle As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtoname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtstaffid As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Other As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Tel As DataGridViewTextBoxColumn
    Friend WithEvents Picture As DataGridViewImageColumn
End Class
