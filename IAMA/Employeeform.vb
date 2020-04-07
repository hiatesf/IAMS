Imports System.Data.SqlClient 'Import SQL Capabilities
'Imports System.Data.SqlClient.SqlDataReader
Imports System.Configuration
Public Class Employeeform
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        For Each fld As Control In Me.Controls
            fld.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Left
        Next
        For Each fld As Control In GroupBox1.Controls
            If fld.Text = "" Then
                MsgBox("Please fill up all fields", vbOKOnly)
                Exit Sub
            End If
        Next
        Try
            sqlCon = New SqlConnection(Strconn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "InsertIntoemployee"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("eid", EmpID.Text)
                sqlComm.Parameters.AddWithValue("FName", FName.Text)
                sqlComm.Parameters.AddWithValue("LName", LName.Text)
                sqlComm.Parameters.AddWithValue("MName", MName.Text)
                sqlComm.Parameters.AddWithValue("EmailID", EmailID.Text)
                sqlComm.Parameters.AddWithValue("Gender", Gender.Text)
                sqlComm.Parameters.AddWithValue("Department", Department.Text)
                sqlComm.Parameters.AddWithValue("Role", Role.Text)
                sqlComm.Parameters.AddWithValue("Status", Status.Text)
                sqlComm.Parameters.AddWithValue("DOB", DOB.Value.Date)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                MessageBox.Show("A new client has been created successfully!", "Message - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim refreshnow As New RefreshmeGeneral()
                Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("select Eid, Fname, MName, LName, EmailID, (select Department from Department where DId = Employee.Department) as Dept, 
            Gender, (select role from iamsrole where rid = Employee.Role) as Role1, Status, DOB from Employee")
                DataGridView1.DataSource = StrQueryR
                For Each ctrl As Control In GroupBox1.Controls
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                        ctrl.Text = ""
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = Nothing
            End If
        Next
        EmpID.Enabled = True
        Save.Enabled = True
        Update.Enabled = False
    End Sub
    Private Sub Employeeform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Try
            Dim strQuery As String
            strQuery = "select Department from Department; select role from iamsrole; 
            select Eid, Fname, MName, LName, EmailID, (select Department from Department where DId = Employee.Department) as Department, 
            Gender, (select role from iamsrole where rid = Employee.Role) as Role, Status, DOB from Employee"
            Dim Getdata As New GetdataSet()
            Dim Sqldataset As DataSet = Getdata.GetDataset(strQuery)
            Department.DataSource = Sqldataset.Tables(0)
            Department.DisplayMember = ("Department")
            Role.DataSource = Sqldataset.Tables(1)
            Role.DisplayMember = ("Role")
            DataGridView1.DataSource = Sqldataset.Tables(2)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DataGridView1.ClearSelection()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Update.Enabled = True
            Save.Enabled = False
            Dim ID As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim strQuery As String
            strQuery = "select Eid, Fname, MName, LName, EmailID, (select Department from Department where DId = Employee.Department) As Department, Gender, (select role from iamsrole where rid = Employee.Role) as Role, Status, DOB from Employee where Eid = @EiD"
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                sqlComm.Parameters.AddWithValue("@EID", ID.ToString())
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        EmpID.Text = sqlReader.Item("EID").ToString()
                        FName.Text = sqlReader.Item("FName").ToString()
                        MName.Text = sqlReader.Item("MName").ToString()
                        LName.Text = sqlReader.Item("LName").ToString()
                        EmailID.Text = sqlReader.Item("EmailID").ToString()
                        Department.Text = sqlReader.Item("Department").ToString()
                        Gender.Text = sqlReader.Item("Gender").ToString()
                        Role.Text = sqlReader.Item("Role").ToString()
                        Status.Text = sqlReader.Item("Status").ToString()
                        DOB.Text = sqlReader.Item("DOB").ToString()
                        EmpID.Enabled = False
                        Save.Enabled = False
                    End While
                End If
                sqlReader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Update.Enabled = False
            Save.Enabled = True
        End Try
    End Sub
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Try
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "UpdateEmployee"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("Eid", EmpID.Text)
                sqlComm.Parameters.AddWithValue("FName", FName.Text)
                sqlComm.Parameters.AddWithValue("LName", LName.Text)
                sqlComm.Parameters.AddWithValue("MName", MName.Text)
                sqlComm.Parameters.AddWithValue("EmailID", EmailID.Text)
                sqlComm.Parameters.AddWithValue("Gender", Gender.Text)
                sqlComm.Parameters.AddWithValue("Department", Department.Text)
                sqlComm.Parameters.AddWithValue("Role", Role.Text)
                sqlComm.Parameters.AddWithValue("Status", Status.Text)
                sqlComm.Parameters.AddWithValue("DOB", DOB.Value.Date)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                DataGridView1.Refresh()
                MessageBox.Show("The details are updated successfully!", "Message - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim refreshnow As New RefreshmeGeneral()
                Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("select Eid, Fname, MName, LName, EmailID, (select Department from Department where DId = Employee.Department) as Department, 
            Gender, (select role from iamsrole where rid = Employee.Role) as Role, Status, DOB from Employee")
                DataGridView1.DataSource = StrQueryR
                For Each ctrl As Control In GroupBox1.Controls
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                        ctrl.Text = Nothing
                    End If
                Next
            End Using
            Update.Enabled = False
            Save.Enabled = True
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Update.Enabled = False
            Save.Enabled = True
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Employeeform_Load(e, e)
        Me.Close()
    End Sub
End Class

