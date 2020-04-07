<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AuditChecklist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Standard = New System.Windows.Forms.TextBox()
        Me.Clause = New System.Windows.Forms.TextBox()
        Me.Requirement = New System.Windows.Forms.TextBox()
        Me.Subheader = New System.Windows.Forms.TextBox()
        Me.POJ = New System.Windows.Forms.TextBox()
        Me.Comments = New System.Windows.Forms.TextBox()
        Me.AOJ = New System.Windows.Forms.TextBox()
        Me.Finding = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Department = New System.Windows.Forms.ComboBox()
        Me.AID = New System.Windows.Forms.ComboBox()
        Me.Aduitee = New System.Windows.Forms.ComboBox()
        Me.Auditee = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.AEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Update = New System.Windows.Forms.Button()
        Me.Export = New System.Windows.Forms.Button()
        Me.MK = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SearchRequirement = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SearchChecklist = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Count = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.IAMSKey = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(422, 380)
        Me.DataGridView1.TabIndex = 83
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Location = New System.Drawing.Point(34, 46)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1053, 382)
        Me.DataGridView2.TabIndex = 85
        '
        'Standard
        '
        Me.Standard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Standard.Location = New System.Drawing.Point(28, 53)
        Me.Standard.Name = "Standard"
        Me.Standard.Size = New System.Drawing.Size(183, 22)
        Me.Standard.TabIndex = 86
        '
        'Clause
        '
        Me.Clause.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clause.Location = New System.Drawing.Point(234, 53)
        Me.Clause.Name = "Clause"
        Me.Clause.Size = New System.Drawing.Size(183, 22)
        Me.Clause.TabIndex = 87
        '
        'Requirement
        '
        Me.Requirement.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Requirement.Location = New System.Drawing.Point(28, 111)
        Me.Requirement.Multiline = True
        Me.Requirement.Name = "Requirement"
        Me.Requirement.Size = New System.Drawing.Size(389, 82)
        Me.Requirement.TabIndex = 89
        '
        'Subheader
        '
        Me.Subheader.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subheader.Location = New System.Drawing.Point(439, 53)
        Me.Subheader.Name = "Subheader"
        Me.Subheader.Size = New System.Drawing.Size(197, 22)
        Me.Subheader.TabIndex = 88
        '
        'POJ
        '
        Me.POJ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POJ.Location = New System.Drawing.Point(28, 233)
        Me.POJ.Multiline = True
        Me.POJ.Name = "POJ"
        Me.POJ.Size = New System.Drawing.Size(389, 58)
        Me.POJ.TabIndex = 90
        '
        'Comments
        '
        Me.Comments.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comments.Location = New System.Drawing.Point(439, 111)
        Me.Comments.Multiline = True
        Me.Comments.Name = "Comments"
        Me.Comments.Size = New System.Drawing.Size(431, 82)
        Me.Comments.TabIndex = 91
        '
        'AOJ
        '
        Me.AOJ.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AOJ.Location = New System.Drawing.Point(439, 233)
        Me.AOJ.Multiline = True
        Me.AOJ.Name = "AOJ"
        Me.AOJ.Size = New System.Drawing.Size(431, 58)
        Me.AOJ.TabIndex = 92
        '
        'Finding
        '
        Me.Finding.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Finding.FormattingEnabled = True
        Me.Finding.Location = New System.Drawing.Point(665, 51)
        Me.Finding.Name = "Finding"
        Me.Finding.Size = New System.Drawing.Size(205, 24)
        Me.Finding.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 23)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Standard(s)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 23)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Clause"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(439, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Subheader"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(662, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 23)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Finding Category"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 23)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Requirement:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 23)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Potential Objective Evidences :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(436, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 23)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Comments"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(436, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 23)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Objective Evidences :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Department)
        Me.GroupBox1.Controls.Add(Me.AID)
        Me.GroupBox1.Controls.Add(Me.Aduitee)
        Me.GroupBox1.Controls.Add(Me.Auditee)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.AEndDate)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.AStartDate)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 320)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._14173_200
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(210, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 24)
        Me.Button2.TabIndex = 115
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._14173_200
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(210, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 24)
        Me.Button1.TabIndex = 114
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Department
        '
        Me.Department.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department.FormattingEnabled = True
        Me.Department.Location = New System.Drawing.Point(16, 100)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(188, 24)
        Me.Department.TabIndex = 113
        '
        'AID
        '
        Me.AID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AID.FormattingEnabled = True
        Me.AID.Location = New System.Drawing.Point(16, 42)
        Me.AID.Name = "AID"
        Me.AID.Size = New System.Drawing.Size(188, 24)
        Me.AID.TabIndex = 112
        '
        'Aduitee
        '
        Me.Aduitee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aduitee.FormattingEnabled = True
        Me.Aduitee.Location = New System.Drawing.Point(19, 279)
        Me.Aduitee.Name = "Aduitee"
        Me.Aduitee.Size = New System.Drawing.Size(185, 24)
        Me.Aduitee.TabIndex = 111
        '
        'Auditee
        '
        Me.Auditee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Auditee.Location = New System.Drawing.Point(21, 257)
        Me.Auditee.Name = "Auditee"
        Me.Auditee.Size = New System.Drawing.Size(183, 23)
        Me.Auditee.TabIndex = 110
        Me.Auditee.Text = "Auditee"
        Me.Auditee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 196)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 23)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Audit End Date"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AEndDate
        '
        Me.AEndDate.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AEndDate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AEndDate.Location = New System.Drawing.Point(19, 222)
        Me.AEndDate.Name = "AEndDate"
        Me.AEndDate.Size = New System.Drawing.Size(185, 22)
        Me.AEndDate.TabIndex = 108
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(183, 23)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Audit Start Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AStartDate
        '
        Me.AStartDate.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AStartDate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AStartDate.Location = New System.Drawing.Point(19, 162)
        Me.AStartDate.Name = "AStartDate"
        Me.AStartDate.Size = New System.Drawing.Size(185, 22)
        Me.AStartDate.TabIndex = 106
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 23)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Departments Assigned"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 23)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Audit Cycle"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Update)
        Me.GroupBox2.Controls.Add(Me.Export)
        Me.GroupBox2.Controls.Add(Me.MK)
        Me.GroupBox2.Controls.Add(Me.Reset)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Location = New System.Drawing.Point(1233, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 320)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        '
        'Update
        '
        Me.Update.Enabled = False
        Me.Update.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(160, 45)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(128, 35)
        Me.Update.TabIndex = 4
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.Export.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Export.Location = New System.Drawing.Point(17, 154)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(128, 35)
        Me.Export.TabIndex = 3
        Me.Export.Text = "Export"
        Me.Export.UseVisualStyleBackColor = True
        '
        'MK
        '
        Me.MK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MK.Location = New System.Drawing.Point(160, 99)
        Me.MK.Name = "MK"
        Me.MK.Size = New System.Drawing.Size(128, 35)
        Me.MK.TabIndex = 2
        Me.MK.Text = "Mark Complete"
        Me.MK.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(17, 99)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(128, 35)
        Me.Reset.TabIndex = 1
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(17, 45)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(128, 35)
        Me.Save.TabIndex = 0
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Finding)
        Me.GroupBox3.Controls.Add(Me.AOJ)
        Me.GroupBox3.Controls.Add(Me.Comments)
        Me.GroupBox3.Controls.Add(Me.POJ)
        Me.GroupBox3.Controls.Add(Me.Requirement)
        Me.GroupBox3.Controls.Add(Me.Subheader)
        Me.GroupBox3.Controls.Add(Me.Clause)
        Me.GroupBox3.Controls.Add(Me.Standard)
        Me.GroupBox3.Location = New System.Drawing.Point(295, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(907, 320)
        Me.GroupBox3.TabIndex = 107
        Me.GroupBox3.TabStop = False
        '
        'SearchRequirement
        '
        Me.SearchRequirement.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchRequirement.Location = New System.Drawing.Point(74, 20)
        Me.SearchRequirement.Name = "SearchRequirement"
        Me.SearchRequirement.Size = New System.Drawing.Size(206, 22)
        Me.SearchRequirement.TabIndex = 104
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 23)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Search"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 23)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Search"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SearchChecklist
        '
        Me.SearchChecklist.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchChecklist.Location = New System.Drawing.Point(89, 18)
        Me.SearchChecklist.Name = "SearchChecklist"
        Me.SearchChecklist.Size = New System.Drawing.Size(265, 22)
        Me.SearchChecklist.TabIndex = 109
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Count)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.SearchRequirement)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(452, 451)
        Me.GroupBox4.TabIndex = 111
        Me.GroupBox4.TabStop = False
        '
        'Count
        '
        Me.Count.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Count.AutoSize = True
        Me.Count.BackColor = System.Drawing.Color.Transparent
        Me.Count.Location = New System.Drawing.Point(399, 31)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(39, 13)
        Me.Count.TabIndex = 113
        Me.Count.Text = "Label9"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.SearchChecklist)
        Me.GroupBox5.Controls.Add(Me.DataGridView2)
        Me.GroupBox5.Location = New System.Drawing.Point(470, 371)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1103, 451)
        Me.GroupBox5.TabIndex = 111
        Me.GroupBox5.TabStop = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(986, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 114
        Me.Label16.Text = "Label9"
        '
        'IAMSKey
        '
        Me.IAMSKey.Location = New System.Drawing.Point(12, 338)
        Me.IAMSKey.Name = "IAMSKey"
        Me.IAMSKey.Size = New System.Drawing.Size(84, 20)
        Me.IAMSKey.TabIndex = 112
        Me.IAMSKey.Visible = False
        '
        'AuditChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1584, 877)
        Me.Controls.Add(Me.IAMSKey)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AuditChecklist"
        Me.Text = "AuditChecklist"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Standard As TextBox
    Friend WithEvents Clause As TextBox
    Friend WithEvents Requirement As TextBox
    Friend WithEvents Subheader As TextBox
    Friend WithEvents POJ As TextBox
    Friend WithEvents Comments As TextBox
    Friend WithEvents AOJ As TextBox
    Friend WithEvents Finding As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents AStartDate As DateTimePicker
    Friend WithEvents SearchRequirement As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents SearchChecklist As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents AEndDate As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents IAMSKey As TextBox
    Friend WithEvents Count As Label
    Friend WithEvents Reset As Button
    Friend WithEvents Save As Button
    Friend WithEvents MK As Button
    Friend WithEvents Export As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Aduitee As ComboBox
    Friend WithEvents Auditee As Label
    Friend WithEvents Department As ComboBox
    Friend WithEvents AID As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Update As Button
End Class
