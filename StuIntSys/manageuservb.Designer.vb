<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageuservb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageuservb))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.logid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfavc = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.cmdupdate = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PwdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FavcolorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SisDataSet9 = New StuIntSys.sisDataSet9()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New StuIntSys.sisDataSet8TableAdapters.loginTableAdapter()
        Me.TbUserTableAdapter = New StuIntSys.sisDataSet9TableAdapters.tbUserTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SisDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox1.Controls.Add(Me.logid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtfavc)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(41, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'logid
        '
        Me.logid.Location = New System.Drawing.Point(101, 52)
        Me.logid.Name = "logid"
        Me.logid.Size = New System.Drawing.Size(100, 20)
        Me.logid.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "User ID"
        '
        'txtfavc
        '
        Me.txtfavc.Location = New System.Drawing.Point(101, 111)
        Me.txtfavc.Name = "txtfavc"
        Me.txtfavc.Size = New System.Drawing.Size(100, 20)
        Me.txtfavc.TabIndex = 3
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(101, 80)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(100, 20)
        Me.txtpass.TabIndex = 2
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(101, 22)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fav Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(318, 64)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 1
        Me.cmdadd.Text = "ADD"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Location = New System.Drawing.Point(318, 94)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdupdate.TabIndex = 2
        Me.cmdupdate.Text = "CHANGE"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Location = New System.Drawing.Point(318, 124)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 23)
        Me.cmddelete.TabIndex = 3
        Me.cmddelete.Text = "DELETE"
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LoginIDDataGridViewTextBoxColumn, Me.PwdDataGridViewTextBoxColumn, Me.FavcolorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbUserBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LoginIDDataGridViewTextBoxColumn
        '
        Me.LoginIDDataGridViewTextBoxColumn.DataPropertyName = "LoginID"
        Me.LoginIDDataGridViewTextBoxColumn.HeaderText = "LoginID"
        Me.LoginIDDataGridViewTextBoxColumn.Name = "LoginIDDataGridViewTextBoxColumn"
        '
        'PwdDataGridViewTextBoxColumn
        '
        Me.PwdDataGridViewTextBoxColumn.DataPropertyName = "Pwd"
        Me.PwdDataGridViewTextBoxColumn.HeaderText = "Pwd"
        Me.PwdDataGridViewTextBoxColumn.Name = "PwdDataGridViewTextBoxColumn"
        '
        'FavcolorDataGridViewTextBoxColumn
        '
        Me.FavcolorDataGridViewTextBoxColumn.DataPropertyName = "Favcolor"
        Me.FavcolorDataGridViewTextBoxColumn.HeaderText = "Favcolor"
        Me.FavcolorDataGridViewTextBoxColumn.Name = "FavcolorDataGridViewTextBoxColumn"
        '
        'TbUserBindingSource
        '
        Me.TbUserBindingSource.DataMember = "tbUser"
        Me.TbUserBindingSource.DataSource = Me.SisDataSet9
        '
        'SisDataSet9
        '
        Me.SisDataSet9.DataSetName = "sisDataSet9"
        Me.SisDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TbUserTableAdapter
        '
        Me.TbUserTableAdapter.ClearBeforeFill = True
        '
        'manageuservb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(459, 354)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.cmdupdate)
        Me.Controls.Add(Me.cmdadd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "manageuservb"
        Me.Text = "Add Accounts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SisDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtfavc As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdadd As Button
    Friend WithEvents cmdupdate As Button
    Friend WithEvents cmddelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As sisDataSet8TableAdapters.loginTableAdapter
    Friend WithEvents logid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SisDataSet9 As sisDataSet9
    Friend WithEvents TbUserBindingSource As BindingSource
    Friend WithEvents TbUserTableAdapter As sisDataSet9TableAdapters.tbUserTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PwdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FavcolorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
