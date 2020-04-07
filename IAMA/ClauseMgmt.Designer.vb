<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClauseMgmt
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Save = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Standards = New System.Windows.Forms.ComboBox()
        Me.Standard = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Content = New System.Windows.Forms.TextBox()
        Me.ClauseNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IAMSKey = New System.Windows.Forms.TextBox()
        Me.Export = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(40, 409)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(86, 33)
        Me.Save.TabIndex = 43
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(350, 26)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(570, 360)
        Me.DataGridView1.TabIndex = 42
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(132, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 33)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Enabled = False
        Me.Update.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(228, 409)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(90, 33)
        Me.Update.TabIndex = 46
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Standards)
        Me.GroupBox1.Controls.Add(Me.Standard)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Content)
        Me.GroupBox1.Controls.Add(Me.ClauseNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 301)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'Standards
        '
        Me.Standards.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Standards.FormattingEnabled = True
        Me.Standards.Location = New System.Drawing.Point(27, 120)
        Me.Standards.Name = "Standards"
        Me.Standards.Size = New System.Drawing.Size(228, 24)
        Me.Standards.TabIndex = 7
        '
        'Standard
        '
        Me.Standard.AutoSize = True
        Me.Standard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Standard.Location = New System.Drawing.Point(24, 99)
        Me.Standard.Name = "Standard"
        Me.Standard.Size = New System.Drawing.Size(60, 16)
        Me.Standard.TabIndex = 6
        Me.Standard.Text = "Standard"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(e.g. 7,  7.1,  7.1.2  etc..)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clause No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Content / Header"
        '
        'Content
        '
        Me.Content.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Content.Location = New System.Drawing.Point(27, 194)
        Me.Content.Multiline = True
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(228, 74)
        Me.Content.TabIndex = 1
        '
        'ClauseNo
        '
        Me.ClauseNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClauseNo.Location = New System.Drawing.Point(27, 52)
        Me.ClauseNo.Name = "ClauseNo"
        Me.ClauseNo.Size = New System.Drawing.Size(228, 22)
        Me.ClauseNo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ADD CLAUSES / SUB-CLAUSES"
        '
        'IAMSKey
        '
        Me.IAMSKey.Location = New System.Drawing.Point(248, 69)
        Me.IAMSKey.Name = "IAMSKey"
        Me.IAMSKey.Size = New System.Drawing.Size(70, 20)
        Me.IAMSKey.TabIndex = 47
        Me.IAMSKey.Visible = False
        '
        'Export
        '
        Me.Export.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Export.Location = New System.Drawing.Point(834, 409)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(86, 33)
        Me.Export.TabIndex = 48
        Me.Export.Text = "Export"
        Me.Export.UseVisualStyleBackColor = True
        '
        'ClauseMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(979, 514)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.IAMSKey)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Update)
        Me.DoubleBuffered = True
        Me.Name = "ClauseMgmt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clause Management"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Save As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Update As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Content As TextBox
    Friend WithEvents ClauseNo As TextBox
    Friend WithEvents Standards As ComboBox
    Friend WithEvents Standard As Label
    Friend WithEvents IAMSKey As TextBox
    Friend WithEvents Export As Button
End Class
