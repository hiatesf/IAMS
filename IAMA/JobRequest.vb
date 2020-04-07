Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Imports System.IO.StreamWriter
Public Class JobRequest
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Private Sub JobRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Focus5018DataSet.mr001' table. You can move, or remove it, as needed.
        Me.Mr001TableAdapter.Fill(Me.Focus5018DataSet.mr001)
        Me.WindowState = FormWindowState.Maximized
        Me.CenterToScreen()
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RichTextBox Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl In GroupBox2.Controls
            If TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RichTextBox Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl In Me.Controls
            ctrl.Enabled = True
        Next
        Try
            Dim strQuery As String
            strQuery = "Select CName from Client;
                        Select FName from Employee;
                        Select AuditID from AuditCycle"
            Dim Getdata As New GetdataSet()
            Dim Sqldataset As DataSet = Getdata.GetDataset(strQuery)
            Client.DataSource = Sqldataset.Tables(0)
            Client.DisplayMember = "CName"
            Client.ValueMember = "CName"
            Sales.DataSource = Sqldataset.Tables(1)
            Sales.DisplayMember = "FName"
            Sales.ValueMember = "FName"
            Count.Text = DataGridView2.Rows.Count & " Records found"
            Sqldataset.Dispose()
        Catch ex As Exception
            MessageBox.Show("SJMS has identified an Exception. Please share the following message with your SJMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim Field_Check As New Field_Validation
        Dim Field_Count As Integer
        Field_Count = Field_Check.ValidateFields(GroupBox1) + Field_Check.ValidateFields(GroupBox2) + Field_Check.ValidateFields(GroupBox3)
        If Field_Count > 0 Then
            MsgBox("Please fill up all fields", vbOKOnly)
            Exit Sub
        End If
        'For Each fld As Control In GroupBox1.Controls
        '    If TypeOf fld Is ComboBox Or TypeOf fld Is TextBox Or TypeOf fld Is RichTextBox Then
        '        If fld.Text = Nothing Then
        '            fld.BackColor = Color.Yellow
        '            'MsgBox("Please fill up all fields", vbOKOnly)
        '            'Exit Sub
        '        End If
        '    End If
        'Next
        'Try
        '    sqlCon = New SqlConnection(Strconn)
        '    Using (sqlCon)
        '        Dim sqlComm As New SqlCommand()
        '        sqlComm.Connection = sqlCon
        '        sqlComm.CommandText = "InsertIntoCompliance"
        '        sqlComm.CommandType = CommandType.StoredProcedure
        '        sqlComm.Parameters.AddWithValue("RID", IAMSKey.Text)
        '        sqlComm.Parameters.AddWithValue("Department", Department.Text)
        '        sqlComm.Parameters.AddWithValue("AStartdate", AStartDate.Value.Date)
        '        sqlComm.Parameters.AddWithValue("AEnddate", AEndDate.Value.Date)
        '        sqlComm.Parameters.AddWithValue("Comments", Comments.Text)
        '        sqlComm.Parameters.AddWithValue("AOJ", AOJ.Text)
        '        sqlComm.Parameters.AddWithValue("Auditor", Form2.Welcome.Text)
        '        sqlComm.Parameters.AddWithValue("Auditee", Aduitee.Text)
        '        sqlComm.Parameters.AddWithValue("FC", Finding.Text)
        '        sqlComm.Parameters.AddWithValue("AuditCycle", AID.Text)
        '        sqlCon.Open()
        '        sqlComm.ExecuteNonQuery()
        '        sqlCon.Close()
        '        For Each TB1 In GroupBox3.Controls
        '            If TypeOf TB1 Is TextBox Then
        '                TB1.Text = Nothing
        '            End If
        '        Next
        '        Button2_Click(e, e)
        '        DGColor(DataGridView2)
        '    End Using
        '    MessageBox.Show("New compliance item(s) is(are) added successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class