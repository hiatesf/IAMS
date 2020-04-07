Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Public Class AuditChecklist
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection

    Private Sub AuditChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conn As New SqlConnection()
            Dim Strquery As String = "Select distinct(select AuditID from AuditCycle Where ACId=AuditPlan.AuditID) As AuditCycle from AuditPlan
                                        Where EMPID = (Select EMPID from Userdata Where Username = '" & Form2.Welcome.Text & "');
                                    Select Description from FCategory;
                                    Select EID from Employee;"
            Dim Getdata As New GetdataSet
            Finding.DataSource = Getdata.GetDataset(Strquery).Tables(1)
            Finding.DisplayMember = ("Description")
            AID.DataSource = Getdata.GetDataset(Strquery).Tables(0)
            AID.DisplayMember = ("AuditCycle")
            Aduitee.DataSource = Getdata.GetDataset(Strquery).Tables(2)
            Aduitee.DisplayMember = ("EID")
            Count.Text = DataGridView1.Rows.Count & " Records found"
            Label16.Text = DataGridView2.Rows.Count & " Records found"
            AuditCycle.Text = Nothing
            Department.Text = Nothing
            Finding.Text = Nothing
            Aduitee.Text = Nothing
            AID.Enabled = True
            Department.Enabled = True
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AID.SelectedIndexChanged
    '    Try
    '        Dim Getdata As New GetdataSet
    '        Dim Strquery As String = "Select distinct((Select Department from Department where Did = Auditplan.Department)) As Department from AuditPlan Where AuditID = (Select ACid from AuditCycle Where AuditID='" + AID.Text + "')
    '                                And EMPID = (Select EMPID from Userdata Where Username = '" + Form2.Welcome.Text + "')"
    '        Department.DataSource = Getdata.GetDataset(Strquery).Tables(0)
    '        Department.DisplayMember = ("Department")
    '        Count.Text = DataGridView1.Rows.Count & " Records found"
    '        Label16.Text = DataGridView2.Rows.Count & " Records found"
    '    Catch ex As Exception
    '        MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
    '                    MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Department.SelectedIndexChanged
    '    Try
    '        Dim Getdata As New GetdataSet
    '        Dim Strquery As String = "Select 
    '                                 RID As ID,
    '                                (Select Standards from Standards Where sid = Requirements.Standards) As Standard,  
    '                                (Select ClauseNo from Clause Where Cid = Requirements.ClauseNo) As Clauses,  
    '                                Subheader,
    '                                Requirement,
    '                                ObjEvi
    '                                From Requirements where Department = (Select did from department where department = '" + Department.Text + "');
    '                                Select 
    '                                CID, RID, Comments, 
    '                                (Select FC from FCategory Where FID = FC) as Status,
    '                                 AOJ as Obj_Evi,
    '                                (Select Fname from Employee where EID = Auditee) As Auditee,
    '                                from Compliance"
    '        DataGridView1.DataSource = Getdata.GetDataset(Strquery).Tables(0)
    '        Count.Text = DataGridView1.Rows.Count & " Records found"
    '        DataGridView2.DataSource = Getdata.GetDataset(Strquery).Tables(1)
    '        Label16.Text = DataGridView2.Rows.Count & " Records found"
    '        'DataGridView1.Columns(0).Visible = False
    '        'Dim Data As DataTable = Getdata.GetDataset(Strquery).Tables(1)
    '        'Dim X As Integer = 0
    '        'Dim Y As Integer = 20
    '        'Dim L As Integer = 300
    '        'Dim B As Integer = 100
    '        'For i As Integer = 0 To 6
    '        '    For j As Integer = 0 To Getdata.GetDataset(Strquery).Tables(0).Rows(0).Item("Count") - 1
    '        '        Dim TB As New TextBox
    '        '        Panel1.Controls.Add(TB)
    '        '        TB.Name = i & j
    '        '        If i = 0 Or i = 1 Or i = 2 Or i = 3 Or i = 4 Then
    '        '            TB.Text = Data.Rows(j).Item(i).ToString()
    '        '            TB.Enabled = False
    '        '        Else
    '        '        End If
    '        '        If i = 0 Or i = 1 Or i = 2 Then
    '        '            L = 100
    '        '        Else
    '        '            L = 350
    '        '        End If
    '        '        TB.Size = New Size(L, B)
    '        '        TB.Multiline = True
    '        '        TB.WordWrap = True
    '        '        TB.Location = New Point(X, Y)
    '        '        Y = Y + (B + 5) + 20
    '        '    Next
    '        '    X = L + X + 5
    '        '    Y = 20
    '        'Next
    '        'Panel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom Or AnchorStyles.Top
    '        'Panel1.AutoScroll = True
    '    Catch ex As Exception
    '        MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
    '                    MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim ID As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim strQuery As String
            strQuery = "Select 
                        RID As ID,
                    (Select Standards from Standards Where sid = Requirements.Standards) As Standard,  
                    (Select ClauseNo from Clause Where Cid = Requirements.ClauseNo) As Clauses,  
                    Subheader,
                    Requirement,
                    ObjEvi
                    From Requirements where RID = '" & ID & "'"
            Dim GetData As New GetdataSet()
            Dim SQLDataset As DataSet = GetData.GetDataset(strQuery)
            IAMSKey.Text = SQLDataset.Tables(0).Rows(0).Item("ID").ToString()
            Standard.Text = SQLDataset.Tables(0).Rows(0).Item("Standard").ToString()
            Clause.Text = SQLDataset.Tables(0).Rows(0).Item("Clauses").ToString()
            Subheader.Text = SQLDataset.Tables(0).Rows(0).Item("Subheader").ToString()
            Requirement.Text = SQLDataset.Tables(0).Rows(0).Item("Requirement").ToString()
            POJ.Text = SQLDataset.Tables(0).Rows(0).Item("ObjEvi").ToString()
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub AuditCycle_SelectedValueChanged(sender As Object, e As EventArgs) Handles AID.SelectedValueChanged
    '    Try
    '        Dim Getdata As New GetdataSet
    '        Dim Strquery As String = "Select distinct((Select Department from Department where Did = Auditplan.Department)) As Department from AuditPlan Where AuditID = (Select ACid from AuditCycle Where AuditID='" + AID.Text + "')
    '                                And EMPID = (Select EMPID from Userdata Where Username = '" + Form2.Welcome.Text + "')"
    '        Department.DataSource = Getdata.GetDataset(Strquery).Tables(0)
    '        Department.DisplayMember = ("Department")
    '        Count.Text = DataGridView1.Rows.Count & " Records found"
    '    Catch ex As Exception
    '        MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
    '                    MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub Department_SelectedValueChanged(sender As Object, e As EventArgs) Handles Department.SelectedValueChanged
    '    Try
    '        Dim Getdata As New GetdataSet
    '        Dim Strquery As String = "Select 
    '                                 RID As ID,
    '                                (Select Standards from Standards Where sid = Requirements.Standards) As Standard,  
    '                                (Select ClauseNo from Clause Where Cid = Requirements.ClauseNo) As Clauses,  
    '                                Subheader,
    '                                Requirement,
    '                                ObjEvi
    '                                From Requirements where Department = (Select did from department where department = '" + Department.Text + "')"
    '        DataGridView1.DataSource = Getdata.GetDataset(Strquery).Tables(0)
    '        Count.Text = DataGridView1.Rows.Count & " Records found"
    '    Catch ex As Exception
    '        MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
    '                    MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub SearchRequirement_TextChanged(sender As Object, e As EventArgs) Handles SearchRequirement.TextChanged
        Try
            Dim strquery As String = "Select 
                                    RID As ID,
                                    (Select Standards from Standards Where sid = Requirements.Standards) As Standard,  
                                    (Select ClauseNo from Clause Where Cid = Requirements.ClauseNo) As Clauses,  
                                    Subheader,
                                    Requirement,
                                    ObjEvi
                                    From Requirements
                                    Where 
                                    concat (RID,
                                    (Select Standards from Standards Where sid = Requirements.Standards),  
                                    (Select ClauseNo from Clause Where Cid = Requirements.ClauseNo),  
                                    Subheader,
                                    Requirement,
                                    ObjEvi) Like '%" & SearchRequirement.Text & "%' 
                                    and 
                                    Department = (Select did from department where department = '" + Department.Text + "')
                                    and RId NOT IN (Select RID from Compliance Where AuditCycle = (Select ACID from AuditCycle Where AuditID = '" + AID.Text + "'))"
            Dim Getdata As New GetdataSet()
            Dim Sqldataset As DataSet = Getdata.GetDataset(strquery)
            DataGridView1.Refresh()
            DataGridView1.DataSource = Sqldataset.Tables(0)
            Count.Text = DataGridView1.Rows.Count & " Records found"
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchChecklist_TextChanged(sender As Object, e As EventArgs) Handles SearchChecklist.TextChanged
        Try
            Dim Getdata As New GetdataSet
            Dim Strquery As String = "Select
                                    CID As ID, 
                                    (Select Standards From Standards Where SID = Requirements.Standards) As Standard,
                                    (Select ClauseNo From Clause Where CId = Requirements.ClauseNo) As Clause,
                                    Requirements.Subheader,
                                    Requirements.Requirement,
                                    Requirements.ObjEvi as P_Evi,
                                    (Select Department From Department Where DId = Requirements.Department) As Department,
                                    Compliance.Comments,
                                    Compliance.AOJ as A_Evi,
                                    (Select FC From FCategory Where FId = Compliance.FC) As Finding,
                                    (Select Cat From FCategory Where FId = Compliance.FC) As Compliance,
                                    (Select AuditID From AuditCycle Where ACId = Compliance.AuditCycle) As Cycle,
                                    Compliance.AStartDate As Start_Date,
                                    Compliance.AEndDate As End_Date,
                                    (Select FName From Employee Where EID = Compliance.Auditee) As Auditee,
                                    (Select FName From Employee Where EID = Compliance.Auditor) As Auditor
                                    from Requirements join Compliance on Requirements.RID = Compliance.RID
                                    Where
                                    Concat (
                                            (Select Standards From Standards Where SID = Requirements.Standards),
                                            (Select ClauseNo From Clause Where CId = Requirements.ClauseNo),
                                            Subheader,
                                            Requirement,
                                            Comments,
                                            Requirements.ObjEvi,
                                            Compliance.AOJ, 
                                            (Select FC From FCategory Where FId = Compliance.FC),
                                            (Select Cat From FCategory Where FId = Compliance.FC),  
                                            (Select FName From Employee Where EID = Compliance.Auditee)
                                            ) Like '%" & SearchChecklist.Text & "%' 
                                    and
                                    Requirements.Department = (Select DId From Department Where Department = '" + Department.Text + "')
                                    and
                                    Compliance.AuditCycle = (Select ACID From AuditCycle Where AuditID = '" + AID.Text + "')"
            DataGridView2.DataSource = Getdata.GetDataset(Strquery).Tables(0)
            Label16.Text = DataGridView2.Rows.Count & " Records found"
            DGColor(DataGridView2)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        For Each fld As Control In GroupBox1.Controls
            If TypeOf fld Is ComboBox Or TypeOf fld Is TextBox Or TypeOf fld Is RichTextBox Then
                If fld.Text = Nothing Then
                    MsgBox("Please fill up all fields", vbOKOnly)
                    Exit Sub
                End If
            End If
        Next
        Try
            sqlCon = New SqlConnection(Strconn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "InsertIntoCompliance"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("RID", IAMSKey.Text)
                sqlComm.Parameters.AddWithValue("Department", Department.Text)
                sqlComm.Parameters.AddWithValue("AStartdate", AStartDate.Value.Date)
                sqlComm.Parameters.AddWithValue("AEnddate", AEndDate.Value.Date)
                sqlComm.Parameters.AddWithValue("Comments", Comments.Text)
                sqlComm.Parameters.AddWithValue("AOJ", AOJ.Text)
                sqlComm.Parameters.AddWithValue("Auditor", Form2.Welcome.Text)
                sqlComm.Parameters.AddWithValue("Auditee", Aduitee.Text)
                sqlComm.Parameters.AddWithValue("FC", Finding.Text)
                sqlComm.Parameters.AddWithValue("AuditCycle", AID.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                sqlCon.Close()
                For Each TB1 In GroupBox3.Controls
                    If TypeOf TB1 Is TextBox Then
                        TB1.Text = Nothing
                    End If
                Next
                Button2_Click(e, e)
                DGColor(DataGridView2)
            End Using
            MessageBox.Show("New compliance item(s) is(are) added successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Getdata As New GetdataSet
            Dim Strquery As String = "Select distinct((Select Department from Department where Did = Auditplan.Department)) As Department from AuditPlan Where AuditID = (Select ACid from AuditCycle Where AuditID='" + AID.Text + "')
                                    And EMPID = (Select EMPID from Userdata Where Username = '" + Form2.Welcome.Text + "') and AID NOT IN (Select AID from AuditPlan Where ExecuteStatus= 'Completed' or ExecuteStatus = 'Cancelled' or ExecuteStatus = 'Complete by Auditor')"
            Department.DataSource = Getdata.GetDataset(Strquery).Tables(0)
            Department.DisplayMember = ("Department")
            Count.Text = DataGridView1.Rows.Count & " Records found"
            AID.Enabled = False
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim Getdata As New GetdataSet
            Dim Strquery As String = "Select 
                                     RID As ID,
                                    (Select Standards from Standards Where sid = Requirements.Standards) As Standard,  
                                    (Select ClauseNo from Clause Where Cid = Requirements.ClauseNo) As Clauses,  
                                    Subheader,
                                    Requirement,
                                    ObjEvi
                                    From Requirements where Department = (Select did from department where department = '" + Department.Text + "')
                                    and RId NOT IN (Select RID from Compliance Where AuditCycle = (Select ACID from AuditCycle Where AuditID = '" + AID.Text + "'));
                                    select
                                    CID As ID, 
                                    (Select Standards From Standards Where SID = Requirements.Standards) As Standard,
                                    (Select ClauseNo From Clause Where CId = Requirements.ClauseNo) As Clause,
                                    Requirements.Subheader,
                                    Requirements.Requirement,
                                    Requirements.ObjEvi as P_Evi,
                                    (Select Department From Department Where DId = Requirements.Department) As Department,
                                    Compliance.Comments,
                                    Compliance.AOJ as A_Evi,
                                    (Select FC From FCategory Where FId = Compliance.FC) As Finding,
                                    (Select Cat From FCategory Where FId = Compliance.FC) As Compliance,
                                    (Select AuditID From AuditCycle Where ACId = Compliance.AuditCycle) As Cycle,
                                    Compliance.AStartDate As Start_Date,
                                    Compliance.AEndDate As End_Date,
                                    (Select FName From Employee Where EID = Compliance.Auditee) As Auditee,
                                    (Select FName From Employee Where EID = Compliance.Auditor) As Auditor
                                    from Requirements join Compliance on Requirements.RID = Compliance.RID
                                    Where Requirements.Department = (Select DId From Department Where Department = '" + Department.Text + "')
                                    and
                                    Compliance.AuditCycle = (Select ACID From AuditCycle Where AuditID = '" + AID.Text + "');"
            DataGridView1.DataSource = Getdata.GetDataset(Strquery).Tables(0)
            Count.Text = DataGridView1.Rows.Count & " Records found"
            DataGridView2.DataSource = Getdata.GetDataset(Strquery).Tables(1)
            Label16.Text = DataGridView2.Rows.Count & " Records found"
            DGColor(DataGridView2)
            Department.Enabled = False
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Finding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Finding.SelectedIndexChanged
        Try
            Dim Getdata As New GetdataSet
            Dim Strquery As String = "Select Cat from FCategory Where Description = '" + Finding.Text + "'"
            If Not Getdata.GetDataset(Strquery).Tables(0).Rows.Count = 0 Then
                If Not Getdata.GetDataset(Strquery).Tables(0).Rows(0).Item("Cat") = "Compliance" Then
                    GroupBox3.BackColor = Color.IndianRed
                Else
                    GroupBox3.BackColor = Color.DarkSeaGreen
                End If
            Else
                GroupBox3.BackColor = Color.PowderBlue
            End If
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Finding_SelectedValueChanged(sender As Object, e As EventArgs) Handles Finding.SelectedValueChanged
        Finding_SelectedIndexChanged(e, e)
    End Sub

    Public Sub DGColor(DG As DataGridView)
        Try
            For Each rows As DataGridViewRow In DG.Rows
                If Not rows.Cells("Compliance").Value = "Compliance" Then
                    rows.DefaultCellStyle.BackColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Try
            Update.Enabled = True
            Save.Enabled = False
            Dim ID As Object = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            Dim strQuery As String
            strQuery = "select
                                    CID As ID, 
                                    (Select Standards From Standards Where SID = Requirements.Standards) As Standard,
                                    (Select ClauseNo From Clause Where CId = Requirements.ClauseNo) As Clause,
                                    Requirements.Subheader,
                                    Requirements.Requirement,
                                    Requirements.ObjEvi as P_Evi,
                                    (Select Department From Department Where DId = Requirements.Department) As Department,
                                    Compliance.Comments,
                                    Compliance.AOJ as A_Evi,
                                    (Select Description From FCategory Where FId = Compliance.FC) As Finding,
                                    (Select AuditID From AuditCycle Where ACId = Compliance.AuditCycle) As Cycle,
                                    Compliance.AStartDate As Start_Date,
                                    Compliance.AEndDate As End_Date,
                                    Auditee,
                                    (Select FName From Employee Where EID = Compliance.Auditor) As Auditor
                                    from Requirements join Compliance on Requirements.RID = Compliance.RID
                                    Where CID = '" & ID & "'"
            Dim GetData As New GetdataSet()
            Dim SQLDataset As DataSet = GetData.GetDataset(strQuery)
            IAMSKey.Text = SQLDataset.Tables(0).Rows(0).Item("ID").ToString()
            Standard.Text = SQLDataset.Tables(0).Rows(0).Item("Standard").ToString()
            Clause.Text = SQLDataset.Tables(0).Rows(0).Item("Clause").ToString()
            Subheader.Text = SQLDataset.Tables(0).Rows(0).Item("Subheader").ToString()
            Requirement.Text = SQLDataset.Tables(0).Rows(0).Item("Requirement").ToString()
            POJ.Text = SQLDataset.Tables(0).Rows(0).Item("P_Evi").ToString()
            Department.Text = SQLDataset.Tables(0).Rows(0).Item("Department").ToString()
            Comments.Text = SQLDataset.Tables(0).Rows(0).Item("Comments").ToString()
            AOJ.Text = SQLDataset.Tables(0).Rows(0).Item("A_Evi").ToString()
            Finding.Text = SQLDataset.Tables(0).Rows(0).Item("Finding").ToString()
            AID.Text = SQLDataset.Tables(0).Rows(0).Item("Cycle").ToString()
            AStartDate.Text = SQLDataset.Tables(0).Rows(0).Item("Start_Date").ToString()
            AEndDate.Text = SQLDataset.Tables(0).Rows(0).Item("End_Date").ToString()
            Aduitee.Text = SQLDataset.Tables(0).Rows(0).Item("Auditee").ToString()
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Update.Enabled = False
            Save.Enabled = True
        End Try
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        For Each ctrl As Control In GroupBox3.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = Nothing
            End If
        Next
        Save.Enabled = True
        Update.Enabled = False
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        For Each fld As Control In GroupBox1.Controls
            If TypeOf fld Is ComboBox Or TypeOf fld Is TextBox Or TypeOf fld Is RichTextBox Then
                If fld.Text = Nothing Then
                    MsgBox("Please fill up all fields", vbOKOnly)
                    Exit Sub
                End If
            End If
        Next
        Try
            sqlCon = New SqlConnection(Strconn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "UpdateCompliance"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("CID", IAMSKey.Text)
                sqlComm.Parameters.AddWithValue("Comments", Comments.Text)
                sqlComm.Parameters.AddWithValue("AOJ", AOJ.Text)
                sqlComm.Parameters.AddWithValue("Auditee", Aduitee.Text)
                sqlComm.Parameters.AddWithValue("FC", Finding.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                sqlCon.Close()
                For Each TB1 In GroupBox3.Controls
                    If TypeOf TB1 Is TextBox Then
                        TB1.Text = Nothing
                    End If
                Next
                Button2_Click(e, e)
                DGColor(DataGridView2)
            End Using
            Update.Enabled = False
            Save.Enabled = True
            MessageBox.Show("Compliance item is updated successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Update.Enabled = False
            Save.Enabled = True
        End Try
    End Sub

    Private Sub MK_Click(sender As Object, e As EventArgs) Handles MK.Click
        Try
            If DataGridView1.Rows.Count = 0 Then
                sqlCon = New SqlConnection(Strconn)
                Using (sqlCon)
                    Dim sqlComm As New SqlCommand()
                    sqlComm.Connection = sqlCon
                    sqlComm.CommandText = "UpdateAuditPlanFromAuditor"
                    sqlComm.CommandType = CommandType.StoredProcedure
                    sqlComm.Parameters.AddWithValue("AID", AID.Text)
                    sqlComm.Parameters.AddWithValue("Department", Department.Text)
                    sqlCon.Open()
                    sqlComm.ExecuteNonQuery()
                    sqlCon.Close()
                End Using
                MessageBox.Show("Audit Status has been updated successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("The audit cannot be marked as complete unless the checklist is completely filled", "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim ExporttoExcel As New Export
        'Dim Location As String = "C:\\Users\\VA\\Desktop\Requirements.xls"
        Dim Location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + Department.Text + "_Checklist.xls"
        ExporttoExcel.Export_Click(e, e, DataGridView2, Location)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class