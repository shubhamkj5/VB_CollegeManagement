<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcomeusr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcomeusr))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.cmdlogout = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.rbview = New System.Windows.Forms.RibbonButton()
        Me.rbedit = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.rbviewf = New System.Windows.Forms.RibbonButton()
        Me.rbeditf = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.rbfeesshow = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel9 = New System.Windows.Forms.RibbonPanel()
        Me.rbfees = New System.Windows.Forms.RibbonButton()
        Me.rbsalary = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab3 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.rbgrading = New System.Windows.Forms.RibbonButton()
        Me.rbviewgrad = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab4 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel()
        Me.rbhelp = New System.Windows.Forms.RibbonButton()
        Me.rbabout = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel8 = New System.Windows.Forms.RibbonPanel()
        Me.rbman = New System.Windows.Forms.RibbonButton()
        Me.rblogout = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton3 = New System.Windows.Forms.RibbonButton()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.CaptionBarVisible = False
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.cmdlogout)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 116)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = Nothing
        '
        '
        '
        Me.Ribbon1.QuickAcessToolbar.Items.Add(Me.RibbonButton1)
        Me.Ribbon1.Size = New System.Drawing.Size(882, 147)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab4)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 2, 20, 0)
        Me.Ribbon1.Text = "Main"
        '
        'cmdlogout
        '
        Me.cmdlogout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.cmdlogout.Image = CType(resources.GetObject("cmdlogout.Image"), System.Drawing.Image)
        Me.cmdlogout.SmallImage = CType(resources.GetObject("cmdlogout.SmallImage"), System.Drawing.Image)
        Me.cmdlogout.Text = "Logout"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab1.Text = "Home"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.rbview)
        Me.RibbonPanel1.Items.Add(Me.rbedit)
        Me.RibbonPanel1.Text = "Student"
        '
        'rbview
        '
        Me.rbview.Image = Global.StuIntSys.My.Resources.Resources.Account_User_Add
        Me.rbview.SmallImage = CType(resources.GetObject("rbview.SmallImage"), System.Drawing.Image)
        Me.rbview.Text = "Search"
        '
        'rbedit
        '
        Me.rbedit.Image = Global.StuIntSys.My.Resources.Resources.Account_User_Edit
        Me.rbedit.SmallImage = Global.StuIntSys.My.Resources.Resources.Account_User_Edit
        Me.rbedit.Text = "Edit"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.rbviewf)
        Me.RibbonPanel2.Items.Add(Me.rbeditf)
        Me.RibbonPanel2.Text = "Faculty"
        '
        'rbviewf
        '
        Me.rbviewf.Image = Global.StuIntSys.My.Resources.Resources.teacher_icon
        Me.rbviewf.SmallImage = CType(resources.GetObject("rbviewf.SmallImage"), System.Drawing.Image)
        Me.rbviewf.Text = "Search"
        '
        'rbeditf
        '
        Me.rbeditf.Image = Global.StuIntSys.My.Resources.Resources.register2
        Me.rbeditf.SmallImage = CType(resources.GetObject("rbeditf.SmallImage"), System.Drawing.Image)
        Me.rbeditf.Text = "Edit"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel9)
        Me.RibbonTab2.Text = "Finance"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.rbfeesshow)
        Me.RibbonPanel3.Text = "Fees"
        '
        'rbfeesshow
        '
        Me.rbfeesshow.Image = Global.StuIntSys.My.Resources.Resources.ex
        Me.rbfeesshow.SmallImage = CType(resources.GetObject("rbfeesshow.SmallImage"), System.Drawing.Image)
        Me.rbfeesshow.Text = "Structure"
        '
        'RibbonPanel9
        '
        Me.RibbonPanel9.Items.Add(Me.rbfees)
        Me.RibbonPanel9.Items.Add(Me.rbsalary)
        Me.RibbonPanel9.Text = "Pay"
        '
        'rbfees
        '
        Me.rbfees.Image = Global.StuIntSys.My.Resources.Resources._4
        Me.rbfees.SmallImage = CType(resources.GetObject("rbfees.SmallImage"), System.Drawing.Image)
        Me.rbfees.Text = "Student Fees"
        '
        'rbsalary
        '
        Me.rbsalary.Image = Global.StuIntSys.My.Resources.Resources._6
        Me.rbsalary.SmallImage = CType(resources.GetObject("rbsalary.SmallImage"), System.Drawing.Image)
        Me.rbsalary.Text = "Faculty Salary"
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab3.Text = "Grading"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.rbgrading)
        Me.RibbonPanel4.Items.Add(Me.rbviewgrad)
        Me.RibbonPanel4.Text = "Browse"
        '
        'rbgrading
        '
        Me.rbgrading.Image = Global.StuIntSys.My.Resources.Resources.reports
        Me.rbgrading.SmallImage = CType(resources.GetObject("rbgrading.SmallImage"), System.Drawing.Image)
        Me.rbgrading.Text = "Grading"
        '
        'rbviewgrad
        '
        Me.rbviewgrad.Image = Global.StuIntSys.My.Resources.Resources.record_512
        Me.rbviewgrad.SmallImage = CType(resources.GetObject("rbviewgrad.SmallImage"), System.Drawing.Image)
        Me.rbviewgrad.Text = "View"
        '
        'RibbonTab4
        '
        Me.RibbonTab4.Panels.Add(Me.RibbonPanel5)
        Me.RibbonTab4.Panels.Add(Me.RibbonPanel8)
        Me.RibbonTab4.Text = "Utilities"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.Items.Add(Me.rbhelp)
        Me.RibbonPanel5.Items.Add(Me.rbabout)
        Me.RibbonPanel5.Text = "Application"
        '
        'rbhelp
        '
        Me.rbhelp.Image = Global.StuIntSys.My.Resources.Resources.add_stock
        Me.rbhelp.SmallImage = CType(resources.GetObject("rbhelp.SmallImage"), System.Drawing.Image)
        Me.rbhelp.Text = "Help"
        '
        'rbabout
        '
        Me.rbabout.Image = Global.StuIntSys.My.Resources.Resources.reports
        Me.rbabout.SmallImage = CType(resources.GetObject("rbabout.SmallImage"), System.Drawing.Image)
        Me.rbabout.Text = "About"
        '
        'RibbonPanel8
        '
        Me.RibbonPanel8.Items.Add(Me.rbman)
        Me.RibbonPanel8.Items.Add(Me.rblogout)
        Me.RibbonPanel8.Text = "Log"
        '
        'rbman
        '
        Me.rbman.Image = Global.StuIntSys.My.Resources.Resources.user_regestration
        Me.rbman.SmallImage = CType(resources.GetObject("rbman.SmallImage"), System.Drawing.Image)
        Me.rbman.Text = "Manage User"
        '
        'rblogout
        '
        Me.rblogout.Image = Global.StuIntSys.My.Resources.Resources.logout
        Me.rblogout.SmallImage = CType(resources.GetObject("rblogout.SmallImage"), System.Drawing.Image)
        Me.rblogout.Text = "Logout"
        '
        'RibbonButton2
        '
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        '
        'RibbonButton3
        '
        Me.RibbonButton3.Image = CType(resources.GetObject("RibbonButton3.Image"), System.Drawing.Image)
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        '
        'Welcomeusr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 524)
        Me.Controls.Add(Me.Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Welcomeusr"
        Me.Text = "HOME"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents rbview As RibbonButton
    Friend WithEvents rbedit As RibbonButton
    Friend WithEvents RibbonButton2 As RibbonButton
    Friend WithEvents RibbonButton3 As RibbonButton
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents rbviewf As RibbonButton
    Friend WithEvents RibbonTab2 As RibbonTab
    Friend WithEvents RibbonPanel3 As RibbonPanel
    Friend WithEvents rbfeesshow As RibbonButton
    Friend WithEvents RibbonTab3 As RibbonTab
    Friend WithEvents RibbonPanel4 As RibbonPanel
    Friend WithEvents rbgrading As RibbonButton
    Friend WithEvents rbviewgrad As RibbonButton
    Friend WithEvents RibbonTab4 As RibbonTab
    Friend WithEvents RibbonPanel5 As RibbonPanel
    Friend WithEvents rbhelp As RibbonButton
    Friend WithEvents rbabout As RibbonButton
    Friend WithEvents RibbonPanel8 As RibbonPanel
    Friend WithEvents rbman As RibbonButton
    Friend WithEvents cmdlogout As RibbonOrbMenuItem
    Friend WithEvents rblogout As RibbonButton
    Friend WithEvents rbeditf As RibbonButton
    Friend WithEvents RibbonPanel9 As RibbonPanel
    Friend WithEvents rbfees As RibbonButton
    Friend WithEvents rbsalary As RibbonButton
End Class
