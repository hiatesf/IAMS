<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobRequest
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IAMSKey = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tel = New System.Windows.Forms.TextBox()
        Me.Contact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Remarks = New System.Windows.Forms.TextBox()
        Me.Postalcode = New System.Windows.Forms.TextBox()
        Me.Country = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Client = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Instrument = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Mr001BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Focus5018DataSet = New WindowsApplication1.Focus5018DataSet()
        Me.Range = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Make = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cert = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PreCert = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalPts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Sales = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.JobNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DOR = New System.Windows.Forms.DateTimePicker()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Count = New System.Windows.Forms.Label()
        Me.AddInst = New System.Windows.Forms.Button()
        Me.AddClient = New System.Windows.Forms.Button()
        Me.Preview = New System.Windows.Forms.Button()
        Me.Mr001TableAdapter = New WindowsApplication1.Focus5018DataSetTableAdapters.mr001TableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mr001BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Focus5018DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IAMSKey
        '
        Me.IAMSKey.Location = New System.Drawing.Point(40, 38)
        Me.IAMSKey.Margin = New System.Windows.Forms.Padding(4)
        Me.IAMSKey.Name = "IAMSKey"
        Me.IAMSKey.Size = New System.Drawing.Size(103, 26)
        Me.IAMSKey.TabIndex = 40
        Me.IAMSKey.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Tel)
        Me.GroupBox1.Controls.Add(Me.Contact)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Remarks)
        Me.GroupBox1.Controls.Add(Me.Postalcode)
        Me.GroupBox1.Controls.Add(Me.Country)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Client)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 72)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(406, 395)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "PPE Req."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(123, 307)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(260, 68)
        Me.ListBox1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Contact / Tel."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Country / P.Code"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tel
        '
        Me.Tel.Location = New System.Drawing.Point(267, 182)
        Me.Tel.Name = "Tel"
        Me.Tel.Size = New System.Drawing.Size(119, 26)
        Me.Tel.TabIndex = 10
        '
        'Contact
        '
        Me.Contact.Location = New System.Drawing.Point(124, 182)
        Me.Contact.Name = "Contact"
        Me.Contact.Size = New System.Drawing.Size(137, 26)
        Me.Contact.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Remarks"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Remarks
        '
        Me.Remarks.Location = New System.Drawing.Point(122, 225)
        Me.Remarks.Multiline = True
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(262, 69)
        Me.Remarks.TabIndex = 7
        '
        'Postalcode
        '
        Me.Postalcode.Location = New System.Drawing.Point(268, 139)
        Me.Postalcode.Name = "Postalcode"
        Me.Postalcode.Size = New System.Drawing.Size(118, 26)
        Me.Postalcode.TabIndex = 6
        '
        'Country
        '
        Me.Country.Location = New System.Drawing.Point(124, 139)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(137, 26)
        Me.Country.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(123, 67)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(262, 60)
        Me.Address.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Client
        '
        Me.Client.FormattingEnabled = True
        Me.Client.Location = New System.Drawing.Point(122, 26)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(263, 26)
        Me.Client.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(471, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "JOB REQUEST"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(454, 158)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1098, 269)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Instrument, Me.Range, Me.Make, Me.Model, Me.Quantity, Me.Cert, Me.PreCert, Me.CalPts})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(4, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1090, 246)
        Me.DataGridView1.TabIndex = 0
        '
        'Instrument
        '
        Me.Instrument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Instrument.DataSource = Me.Mr001BindingSource
        Me.Instrument.DisplayMember = "Name"
        Me.Instrument.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Instrument.HeaderText = "Instrument"
        Me.Instrument.Name = "Instrument"
        Me.Instrument.ToolTipText = "Enter Name of the instrument"
        Me.Instrument.ValueMember = "Name"
        '
        'Mr001BindingSource
        '
        Me.Mr001BindingSource.DataMember = "mr001"
        Me.Mr001BindingSource.DataSource = Me.Focus5018DataSet
        '
        'Focus5018DataSet
        '
        Me.Focus5018DataSet.DataSetName = "Focus5018DataSet"
        Me.Focus5018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Range
        '
        Me.Range.HeaderText = "Range"
        Me.Range.Name = "Range"
        '
        'Make
        '
        Me.Make.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Make.HeaderText = "Make"
        Me.Make.Name = "Make"
        '
        'Model
        '
        Me.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Cert
        '
        Me.Cert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cert.HeaderText = "Cert. Type"
        Me.Cert.Items.AddRange(New Object() {"Singlas", "Non-Singlas"})
        Me.Cert.Name = "Cert"
        Me.Cert.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'PreCert
        '
        Me.PreCert.HeaderText = "Pre. Cert."
        Me.PreCert.Name = "PreCert"
        '
        'CalPts
        '
        Me.CalPts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CalPts.HeaderText = "Cal. Points"
        Me.CalPts.Name = "CalPts"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Sales)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.JobNo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.DOR)
        Me.GroupBox3.Location = New System.Drawing.Point(453, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1095, 90)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(653, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Safety Course Requirements:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox1.Location = New System.Drawing.Point(487, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 26)
        Me.ComboBox1.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(656, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(428, 26)
        Me.TextBox1.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(484, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "RA Required"
        '
        'Sales
        '
        Me.Sales.FormattingEnabled = True
        Me.Sales.Location = New System.Drawing.Point(323, 44)
        Me.Sales.Name = "Sales"
        Me.Sales.Size = New System.Drawing.Size(149, 26)
        Me.Sales.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Requested by"
        '
        'JobNo
        '
        Me.JobNo.Location = New System.Drawing.Point(168, 44)
        Me.JobNo.Name = "JobNo"
        Me.JobNo.Size = New System.Drawing.Size(137, 26)
        Me.JobNo.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(165, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Job No.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date(s) of Request"
        '
        'DOR
        '
        Me.DOR.CalendarFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOR.CustomFormat = "dd-MMM-yyyy"
        Me.DOR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOR.Location = New System.Drawing.Point(17, 48)
        Me.DOR.Name = "DOR"
        Me.DOR.Size = New System.Drawing.Size(133, 22)
        Me.DOR.TabIndex = 0
        Me.DOR.Value = New Date(2019, 4, 12, 0, 0, 0, 0)
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(458, 434)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(86, 33)
        Me.Submit.TabIndex = 45
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(550, 434)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(90, 33)
        Me.Reset.TabIndex = 46
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Enabled = False
        Me.Update.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(838, 435)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(90, 32)
        Me.Update.TabIndex = 47
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Enabled = False
        Me.Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(1032, 435)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(90, 32)
        Me.Delete.TabIndex = 48
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView2)
        Me.GroupBox4.Location = New System.Drawing.Point(40, 474)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1512, 283)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 22)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(1506, 258)
        Me.DataGridView2.TabIndex = 0
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Count.Location = New System.Drawing.Point(1501, 766)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(47, 14)
        Me.Count.TabIndex = 1
        Me.Count.Text = "Label10"
        '
        'AddInst
        '
        Me.AddInst.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddInst.Location = New System.Drawing.Point(650, 435)
        Me.AddInst.Name = "AddInst"
        Me.AddInst.Size = New System.Drawing.Size(86, 32)
        Me.AddInst.TabIndex = 16
        Me.AddInst.Text = "Add Inst."
        Me.AddInst.UseVisualStyleBackColor = True
        '
        'AddClient
        '
        Me.AddClient.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddClient.Location = New System.Drawing.Point(742, 435)
        Me.AddClient.Name = "AddClient"
        Me.AddClient.Size = New System.Drawing.Size(90, 32)
        Me.AddClient.TabIndex = 50
        Me.AddClient.Text = "Add Client"
        Me.AddClient.UseVisualStyleBackColor = True
        '
        'Preview
        '
        Me.Preview.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preview.Location = New System.Drawing.Point(936, 435)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(90, 32)
        Me.Preview.TabIndex = 51
        Me.Preview.Text = "Preview"
        Me.Preview.UseVisualStyleBackColor = True
        '
        'Mr001TableAdapter
        '
        Me.Mr001TableAdapter.ClearBeforeFill = True
        '
        'JobRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1565, 789)
        Me.Controls.Add(Me.Preview)
        Me.Controls.Add(Me.AddClient)
        Me.Controls.Add(Me.AddInst)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IAMSKey)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "JobRequest"
        Me.Text = "Job Request"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mr001BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Focus5018DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IAMSKey As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Client As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents Postalcode As TextBox
    Friend WithEvents Country As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Remarks As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DOR As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Submit As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tel As TextBox
    Friend WithEvents Contact As TextBox
    Friend WithEvents JobNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Sales As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Count As Label
    Friend WithEvents AddInst As Button
    Friend WithEvents AddClient As Button
    Friend WithEvents Preview As Button
    Friend WithEvents Focus5018DataSet As Focus5018DataSet
    Friend WithEvents Mr001BindingSource As BindingSource
    Friend WithEvents Mr001TableAdapter As Focus5018DataSetTableAdapters.mr001TableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Instrument As DataGridViewComboBoxColumn
    Friend WithEvents Range As DataGridViewTextBoxColumn
    Friend WithEvents Make As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Cert As DataGridViewComboBoxColumn
    Friend WithEvents PreCert As DataGridViewTextBoxColumn
    Friend WithEvents CalPts As DataGridViewTextBoxColumn
End Class
