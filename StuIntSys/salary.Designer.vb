<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class salary
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salary))
        Me.TbTermBillTableAdapter = New StuIntSys.sisDataSet6TableAdapters.tbTermBillTableAdapter()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.cmdclear = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbTermBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtstatus = New System.Windows.Forms.ComboBox()
        Me.txtsem = New System.Windows.Forms.ComboBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtstuid = New System.Windows.Forms.TextBox()
        Me.txtbillid = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillCostDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SisDataSet7 = New StuIntSys.sisDataSet7()
        Me.TbBillTableAdapter = New StuIntSys.sisDataSet7TableAdapters.tbBillTableAdapter()
        Me.cmdSearchs = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        CType(Me.TbTermBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SisDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbTermBillTableAdapter
        '
        Me.TbTermBillTableAdapter.ClearBeforeFill = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Location = New System.Drawing.Point(640, 183)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdupdate.TabIndex = 5
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Location = New System.Drawing.Point(640, 149)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 4
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'cmdclear
        '
        Me.cmdclear.Location = New System.Drawing.Point(640, 117)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(75, 23)
        Me.cmdclear.TabIndex = 3
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'BillidDataGridViewTextBoxColumn
        '
        Me.BillidDataGridViewTextBoxColumn.DataPropertyName = "Billid"
        Me.BillidDataGridViewTextBoxColumn.HeaderText = "Billid"
        Me.BillidDataGridViewTextBoxColumn.Name = "BillidDataGridViewTextBoxColumn"
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
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
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'BillCostDataGridViewTextBoxColumn
        '
        Me.BillCostDataGridViewTextBoxColumn.DataPropertyName = "BillCost"
        Me.BillCostDataGridViewTextBoxColumn.HeaderText = "BillCost"
        Me.BillCostDataGridViewTextBoxColumn.Name = "BillCostDataGridViewTextBoxColumn"
        '
        'BillDateDataGridViewTextBoxColumn
        '
        Me.BillDateDataGridViewTextBoxColumn.DataPropertyName = "BillDate"
        Me.BillDateDataGridViewTextBoxColumn.HeaderText = "BillDate"
        Me.BillDateDataGridViewTextBoxColumn.Name = "BillDateDataGridViewTextBoxColumn"
        '
        'SemDataGridViewTextBoxColumn
        '
        Me.SemDataGridViewTextBoxColumn.DataPropertyName = "Sem"
        Me.SemDataGridViewTextBoxColumn.HeaderText = "Sem"
        Me.SemDataGridViewTextBoxColumn.Name = "SemDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(640, 88)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 23)
        Me.cmdsave.TabIndex = 2
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtstatus)
        Me.GroupBox1.Controls.Add(Me.txtsem)
        Me.GroupBox1.Controls.Add(Me.txtdate)
        Me.GroupBox1.Controls.Add(Me.txtcost)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.txtstuid)
        Me.GroupBox1.Controls.Add(Me.txtbillid)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 203)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtstatus
        '
        Me.txtstatus.FormattingEnabled = True
        Me.txtstatus.Items.AddRange(New Object() {"Paid", "Unpaid"})
        Me.txtstatus.Location = New System.Drawing.Point(365, 127)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(121, 21)
        Me.txtstatus.TabIndex = 10
        '
        'txtsem
        '
        Me.txtsem.FormattingEnabled = True
        Me.txtsem.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.txtsem.Location = New System.Drawing.Point(365, 97)
        Me.txtsem.Name = "txtsem"
        Me.txtsem.Size = New System.Drawing.Size(121, 21)
        Me.txtsem.TabIndex = 9
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(365, 71)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(110, 20)
        Me.txtdate.TabIndex = 8
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(365, 41)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(100, 20)
        Me.txtcost.TabIndex = 7
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(365, 13)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(100, 20)
        Me.txtdesc.TabIndex = 6
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(92, 130)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(100, 20)
        Me.txtlname.TabIndex = 5
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(92, 103)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(100, 20)
        Me.txtfname.TabIndex = 4
        '
        'txtstuid
        '
        Me.txtstuid.Location = New System.Drawing.Point(92, 71)
        Me.txtstuid.Name = "txtstuid"
        Me.txtstuid.Size = New System.Drawing.Size(100, 20)
        Me.txtstuid.TabIndex = 2
        '
        'txtbillid
        '
        Me.txtbillid.Location = New System.Drawing.Point(92, 44)
        Me.txtbillid.Name = "txtbillid"
        Me.txtbillid.Size = New System.Drawing.Size(100, 20)
        Me.txtbillid.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(92, 13)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(73, 20)
        Me.txtid.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(330, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Month"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bill Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bill Cost"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(298, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lastname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Staff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bill ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.BillidDataGridViewTextBoxColumn1, Me.StaffIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn1, Me.LastnameDataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn1, Me.BillCostDataGridViewTextBoxColumn1, Me.BillDateDataGridViewTextBoxColumn1, Me.MonthDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.TbBillBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(712, 285)
        Me.DataGridView1.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'BillidDataGridViewTextBoxColumn1
        '
        Me.BillidDataGridViewTextBoxColumn1.DataPropertyName = "Billid"
        Me.BillidDataGridViewTextBoxColumn1.HeaderText = "Billid"
        Me.BillidDataGridViewTextBoxColumn1.Name = "BillidDataGridViewTextBoxColumn1"
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn1
        '
        Me.FirstnameDataGridViewTextBoxColumn1.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn1.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn1.Name = "FirstnameDataGridViewTextBoxColumn1"
        '
        'LastnameDataGridViewTextBoxColumn1
        '
        Me.LastnameDataGridViewTextBoxColumn1.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn1.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn1.Name = "LastnameDataGridViewTextBoxColumn1"
        '
        'DescriptionDataGridViewTextBoxColumn1
        '
        Me.DescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.Name = "DescriptionDataGridViewTextBoxColumn1"
        '
        'BillCostDataGridViewTextBoxColumn1
        '
        Me.BillCostDataGridViewTextBoxColumn1.DataPropertyName = "BillCost"
        Me.BillCostDataGridViewTextBoxColumn1.HeaderText = "BillCost"
        Me.BillCostDataGridViewTextBoxColumn1.Name = "BillCostDataGridViewTextBoxColumn1"
        '
        'BillDateDataGridViewTextBoxColumn1
        '
        Me.BillDateDataGridViewTextBoxColumn1.DataPropertyName = "BillDate"
        Me.BillDateDataGridViewTextBoxColumn1.HeaderText = "BillDate"
        Me.BillDateDataGridViewTextBoxColumn1.Name = "BillDateDataGridViewTextBoxColumn1"
        '
        'MonthDataGridViewTextBoxColumn
        '
        Me.MonthDataGridViewTextBoxColumn.DataPropertyName = "Month"
        Me.MonthDataGridViewTextBoxColumn.HeaderText = "Month"
        Me.MonthDataGridViewTextBoxColumn.Name = "MonthDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn1
        '
        Me.StatusDataGridViewTextBoxColumn1.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn1.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn1.Name = "StatusDataGridViewTextBoxColumn1"
        '
        'TbBillBindingSource
        '
        Me.TbBillBindingSource.DataMember = "tbBill"
        Me.TbBillBindingSource.DataSource = Me.SisDataSet7
        '
        'SisDataSet7
        '
        Me.SisDataSet7.DataSetName = "sisDataSet7"
        Me.SisDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbBillTableAdapter
        '
        Me.TbBillTableAdapter.ClearBeforeFill = True
        '
        'cmdSearchs
        '
        Me.cmdSearchs.Location = New System.Drawing.Point(640, 50)
        Me.cmdSearchs.Name = "cmdSearchs"
        Me.cmdSearchs.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearchs.TabIndex = 1
        Me.cmdSearchs.Text = "Search"
        Me.cmdSearchs.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(624, 24)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 20)
        Me.txtsearch.TabIndex = 0
        '
        'salary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(736, 532)
        Me.Controls.Add(Me.cmdSearchs)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdclear)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "salary"
        Me.Text = "Faculty Salary"
        CType(Me.TbTermBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SisDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbTermBillTableAdapter As sisDataSet6TableAdapters.tbTermBillTableAdapter
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmddelete As Button
    Friend WithEvents cmdclear As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BillidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BillCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BillDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbTermBillBindingSource As BindingSource
    Friend WithEvents cmdsave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtstatus As ComboBox
    Friend WithEvents txtsem As ComboBox
    Friend WithEvents txtdate As DateTimePicker
    Friend WithEvents txtcost As TextBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtstuid As TextBox
    Friend WithEvents txtbillid As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SisDataSet7 As sisDataSet7
    Friend WithEvents TbBillBindingSource As BindingSource
    Friend WithEvents TbBillTableAdapter As sisDataSet7TableAdapters.tbBillTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BillidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BillCostDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BillDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents cmdSearchs As Button
    Friend WithEvents txtsearch As TextBox
End Class
