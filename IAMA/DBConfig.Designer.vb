<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DBConfig
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Test = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.DBName = New System.Windows.Forms.TextBox()
        Me.Server = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Address (e.g. 192.168.1.157/SQLEXPRESS)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Database Name"
        '
        'Test
        '
        Me.Test.Location = New System.Drawing.Point(54, 387)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(125, 33)
        Me.Test.TabIndex = 6
        Me.Test.Text = "Test"
        Me.Test.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(185, 387)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(139, 33)
        Me.Save.TabIndex = 7
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        '
        'Password
        '
        Me.Password.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsApplication1.My.MySettings.Default, "Password", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Password.Location = New System.Drawing.Point(54, 331)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(268, 26)
        Me.Password.TabIndex = 5
        Me.Password.Text = Global.WindowsApplication1.My.MySettings.Default.Password
        '
        'Username
        '
        Me.Username.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsApplication1.My.MySettings.Default, "Username", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Username.Location = New System.Drawing.Point(52, 259)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(270, 26)
        Me.Username.TabIndex = 3
        Me.Username.Text = Global.WindowsApplication1.My.MySettings.Default.Username
        '
        'DBName
        '
        Me.DBName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsApplication1.My.MySettings.Default, "DBName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DBName.Location = New System.Drawing.Point(52, 187)
        Me.DBName.Name = "DBName"
        Me.DBName.Size = New System.Drawing.Size(270, 26)
        Me.DBName.TabIndex = 2
        Me.DBName.Text = Global.WindowsApplication1.My.MySettings.Default.DBName
        '
        'Server
        '
        Me.Server.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WindowsApplication1.My.MySettings.Default, "Server", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Server.Location = New System.Drawing.Point(50, 116)
        Me.Server.Name = "Server"
        Me.Server.Size = New System.Drawing.Size(272, 26)
        Me.Server.TabIndex = 1
        Me.Server.Text = Global.WindowsApplication1.My.MySettings.Default.Server
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "DATABASE CONFIGURATION"
        '
        'DBConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(394, 456)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.DBName)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DBConfig"
        Me.Text = "Database Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Server As TextBox
    Friend WithEvents DBName As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Test As Button
    Friend WithEvents Save As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
