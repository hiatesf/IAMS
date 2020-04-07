<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AuditPlanB = New System.Windows.Forms.Button()
        Me.ReqMgmt = New System.Windows.Forms.Button()
        Me.Requirement = New System.Windows.Forms.Button()
        Me.Clauses = New System.Windows.Forms.Button()
        Me.Report = New System.Windows.Forms.Button()
        Me.AuditCycleB = New System.Windows.Forms.Button()
        Me.AChecklist = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AccessRightsB = New System.Windows.Forms.Button()
        Me.ChangeDefPass = New System.Windows.Forms.Button()
        Me.DBConfigB = New System.Windows.Forms.Button()
        Me.Role = New System.Windows.Forms.Button()
        Me.Employee = New System.Windows.Forms.Button()
        Me.User = New System.Windows.Forms.Button()
        Me.Category = New System.Windows.Forms.Button()
        Me.Department = New System.Windows.Forms.Button()
        Me.ClientMgmt = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Welcome = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Norwester", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1227, 54)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Internal Audit Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage3.Controls.Add(Me.AuditPlanB)
        Me.TabPage3.Controls.Add(Me.ReqMgmt)
        Me.TabPage3.Controls.Add(Me.Requirement)
        Me.TabPage3.Controls.Add(Me.Clauses)
        Me.TabPage3.Controls.Add(Me.Report)
        Me.TabPage3.Controls.Add(Me.AuditCycleB)
        Me.TabPage3.Controls.Add(Me.AChecklist)
        Me.TabPage3.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1223, 72)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Audit Mgmt."
        '
        'AuditPlanB
        '
        Me.AuditPlanB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AuditPlanB.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuditPlanB.Location = New System.Drawing.Point(352, 6)
        Me.AuditPlanB.Name = "AuditPlanB"
        Me.AuditPlanB.Size = New System.Drawing.Size(80, 60)
        Me.AuditPlanB.TabIndex = 13
        Me.AuditPlanB.Text = "Audit Plan"
        Me.AuditPlanB.UseVisualStyleBackColor = True
        '
        'ReqMgmt
        '
        Me.ReqMgmt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReqMgmt.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReqMgmt.Location = New System.Drawing.Point(180, 6)
        Me.ReqMgmt.Name = "ReqMgmt"
        Me.ReqMgmt.Size = New System.Drawing.Size(80, 60)
        Me.ReqMgmt.TabIndex = 12
        Me.ReqMgmt.Text = "Requirement Management"
        Me.ReqMgmt.UseVisualStyleBackColor = True
        '
        'Requirement
        '
        Me.Requirement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Requirement.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requirement.Location = New System.Drawing.Point(8, 6)
        Me.Requirement.Name = "Requirement"
        Me.Requirement.Size = New System.Drawing.Size(80, 60)
        Me.Requirement.TabIndex = 6
        Me.Requirement.Text = "Standard Management"
        Me.Requirement.UseVisualStyleBackColor = True
        '
        'Clauses
        '
        Me.Clauses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clauses.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clauses.Location = New System.Drawing.Point(94, 6)
        Me.Clauses.Name = "Clauses"
        Me.Clauses.Size = New System.Drawing.Size(80, 60)
        Me.Clauses.TabIndex = 7
        Me.Clauses.Text = "Clause Management"
        Me.Clauses.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.Report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Report.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Report.Location = New System.Drawing.Point(524, 6)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(80, 60)
        Me.Report.TabIndex = 11
        Me.Report.Text = "Report Management"
        Me.Report.UseVisualStyleBackColor = True
        '
        'AuditCycleB
        '
        Me.AuditCycleB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AuditCycleB.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuditCycleB.Location = New System.Drawing.Point(266, 6)
        Me.AuditCycleB.Name = "AuditCycleB"
        Me.AuditCycleB.Size = New System.Drawing.Size(80, 60)
        Me.AuditCycleB.TabIndex = 9
        Me.AuditCycleB.Text = "Audit Cycle"
        Me.AuditCycleB.UseVisualStyleBackColor = True
        '
        'AChecklist
        '
        Me.AChecklist.BackColor = System.Drawing.Color.Transparent
        Me.AChecklist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AChecklist.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AChecklist.Location = New System.Drawing.Point(438, 6)
        Me.AChecklist.Name = "AChecklist"
        Me.AChecklist.Size = New System.Drawing.Size(80, 60)
        Me.AChecklist.TabIndex = 10
        Me.AChecklist.Text = "Audit Checklist"
        Me.AChecklist.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage2.Controls.Add(Me.AccessRightsB)
        Me.TabPage2.Controls.Add(Me.ChangeDefPass)
        Me.TabPage2.Controls.Add(Me.DBConfigB)
        Me.TabPage2.Controls.Add(Me.Role)
        Me.TabPage2.Controls.Add(Me.Employee)
        Me.TabPage2.Controls.Add(Me.User)
        Me.TabPage2.Controls.Add(Me.Category)
        Me.TabPage2.Controls.Add(Me.Department)
        Me.TabPage2.Controls.Add(Me.ClientMgmt)
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1223, 72)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Configuration"
        '
        'AccessRightsB
        '
        Me.AccessRightsB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AccessRightsB.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccessRightsB.Location = New System.Drawing.Point(875, 9)
        Me.AccessRightsB.Name = "AccessRightsB"
        Me.AccessRightsB.Size = New System.Drawing.Size(80, 60)
        Me.AccessRightsB.TabIndex = 8
        Me.AccessRightsB.Text = "Access Rights"
        Me.AccessRightsB.UseVisualStyleBackColor = True
        '
        'ChangeDefPass
        '
        Me.ChangeDefPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeDefPass.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeDefPass.Location = New System.Drawing.Point(610, 6)
        Me.ChangeDefPass.Name = "ChangeDefPass"
        Me.ChangeDefPass.Size = New System.Drawing.Size(80, 60)
        Me.ChangeDefPass.TabIndex = 7
        Me.ChangeDefPass.Text = "Change Default Password"
        Me.ChangeDefPass.UseVisualStyleBackColor = True
        '
        'DBConfigB
        '
        Me.DBConfigB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DBConfigB.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBConfigB.Location = New System.Drawing.Point(524, 6)
        Me.DBConfigB.Name = "DBConfigB"
        Me.DBConfigB.Size = New System.Drawing.Size(80, 60)
        Me.DBConfigB.TabIndex = 6
        Me.DBConfigB.Text = "Database Configuration"
        Me.DBConfigB.UseVisualStyleBackColor = True
        '
        'Role
        '
        Me.Role.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Role.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Role.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role.Location = New System.Drawing.Point(8, 6)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(80, 60)
        Me.Role.TabIndex = 0
        Me.Role.Text = "Role Management"
        Me.Role.UseVisualStyleBackColor = True
        '
        'Employee
        '
        Me.Employee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Employee.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee.Location = New System.Drawing.Point(94, 6)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(80, 60)
        Me.Employee.TabIndex = 1
        Me.Employee.Text = "Employee Management"
        Me.Employee.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.User.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(180, 6)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(80, 60)
        Me.User.TabIndex = 2
        Me.User.Text = "User Management"
        Me.User.UseVisualStyleBackColor = True
        '
        'Category
        '
        Me.Category.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Category.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Category.Location = New System.Drawing.Point(352, 6)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(80, 60)
        Me.Category.TabIndex = 3
        Me.Category.Text = "Findings Category"
        Me.Category.UseVisualStyleBackColor = True
        '
        'Department
        '
        Me.Department.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Department.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department.Location = New System.Drawing.Point(266, 6)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(80, 60)
        Me.Department.TabIndex = 4
        Me.Department.Text = "Department Management"
        Me.Department.UseVisualStyleBackColor = True
        '
        'ClientMgmt
        '
        Me.ClientMgmt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClientMgmt.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientMgmt.Location = New System.Drawing.Point(438, 6)
        Me.ClientMgmt.Name = "ClientMgmt"
        Me.ClientMgmt.Size = New System.Drawing.Size(80, 60)
        Me.ClientMgmt.TabIndex = 5
        Me.ClientMgmt.Text = "Client Management"
        Me.ClientMgmt.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1231, 100)
        Me.TabControl1.TabIndex = 16
        '
        'Welcome
        '
        Me.Welcome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Welcome.AutoSize = True
        Me.Welcome.BackColor = System.Drawing.Color.Transparent
        Me.Welcome.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome.Location = New System.Drawing.Point(1174, 106)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(46, 16)
        Me.Welcome.TabIndex = 19
        Me.Welcome.Text = "Label3"
        Me.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.ItemSize = New System.Drawing.Size(106, 29)
        Me.TabControl2.Location = New System.Drawing.Point(4, 106)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.Padding = New System.Drawing.Point(15, 7)
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1227, 642)
        Me.TabControl2.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(5, 756)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 36)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Close Tab"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(113, 756)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 36)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Close All Tabs"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(965, 769)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1232, 796)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Welcome)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Landing Window - IAMS"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Requirement As Button
    Friend WithEvents Clauses As Button
    Friend WithEvents Report As Button
    Friend WithEvents AuditCycleB As Button
    Friend WithEvents AChecklist As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Role As Button
    Friend WithEvents Employee As Button
    Friend WithEvents User As Button
    Friend WithEvents Category As Button
    Friend WithEvents Department As Button
    Friend WithEvents ClientMgmt As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DBConfigB As Button
    Friend WithEvents ChangeDefPass As Button
    Friend WithEvents ReqMgmt As Button
    Friend WithEvents AuditPlanB As Button
    Friend WithEvents AccessRightsB As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Welcome As Label
End Class
