<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
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
        Me.UDDataGridView = New System.Windows.Forms.DataGridView()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Repassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmpID = New System.Windows.Forms.ComboBox()
        Me.Update = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Userphoto = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Clsfrm = New System.Windows.Forms.Button()
        CType(Me.UDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Userphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UDDataGridView
        '
        Me.UDDataGridView.AllowUserToAddRows = False
        Me.UDDataGridView.AllowUserToDeleteRows = False
        Me.UDDataGridView.AllowUserToOrderColumns = True
        Me.UDDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UDDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UDDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UDDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UDDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.UDDataGridView.Location = New System.Drawing.Point(309, 55)
        Me.UDDataGridView.MultiSelect = False
        Me.UDDataGridView.Name = "UDDataGridView"
        Me.UDDataGridView.ReadOnly = True
        Me.UDDataGridView.RowHeadersVisible = False
        Me.UDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UDDataGridView.Size = New System.Drawing.Size(345, 454)
        Me.UDDataGridView.TabIndex = 29
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(13, 128)
        Me.Username.Multiline = True
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(217, 25)
        Me.Username.TabIndex = 33
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(13, 204)
        Me.Password.MaxLength = 15
        Me.Password.Multiline = True
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(217, 25)
        Me.Password.TabIndex = 34
        '
        'Repassword
        '
        Me.Repassword.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Repassword.Location = New System.Drawing.Point(13, 278)
        Me.Repassword.MaxLength = 15
        Me.Repassword.Multiline = True
        Me.Repassword.Name = "Repassword"
        Me.Repassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Repassword.Size = New System.Drawing.Size(217, 25)
        Me.Repassword.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Re-enter Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Emp ID"
        '
        'EmpID
        '
        Me.EmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmpID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.FormattingEnabled = True
        Me.EmpID.Location = New System.Drawing.Point(13, 58)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Size = New System.Drawing.Size(217, 24)
        Me.EmpID.TabIndex = 40
        '
        'Update
        '
        Me.Update.Enabled = False
        Me.Update.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(334, 575)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(127, 35)
        Me.Update.TabIndex = 49
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(186, 575)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(127, 35)
        Me.Clear.TabIndex = 48
        Me.Clear.Text = "Reset"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(41, 575)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(127, 35)
        Me.Save.TabIndex = 47
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Username)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Controls.Add(Me.Repassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.EmpID)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 315)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(218, 515)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(75, 23)
        Me.Browse.TabIndex = 54
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Userphoto
        '
        Me.Userphoto.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Userphoto.Location = New System.Drawing.Point(41, 364)
        Me.Userphoto.Name = "Userphoto"
        Me.Userphoto.Size = New System.Drawing.Size(252, 145)
        Me.Userphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Userphoto.TabIndex = 52
        Me.Userphoto.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(306, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(237, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "*Double Click on a row below to edit user details."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(137, 515)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 55
        Me.Delete.Text = "Remove"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Clsfrm
        '
        Me.Clsfrm.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clsfrm.Location = New System.Drawing.Point(481, 575)
        Me.Clsfrm.Name = "Clsfrm"
        Me.Clsfrm.Size = New System.Drawing.Size(127, 35)
        Me.Clsfrm.TabIndex = 56
        Me.Clsfrm.Text = "Close"
        Me.Clsfrm.UseVisualStyleBackColor = True
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(720, 677)
        Me.Controls.Add(Me.Clsfrm)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Userphoto)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.UDDataGridView)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Save)
        Me.DoubleBuffered = True
        Me.Name = "UserForm"
        Me.Text = "User Credential Management"
        CType(Me.UDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Userphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UDDataGridView As DataGridView
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Repassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmpID As ComboBox
    Friend WithEvents Update As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Save As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Userphoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Browse As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Clsfrm As Button
End Class
