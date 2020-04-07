Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Imports System.IO.StreamWriter
Public Class AuditPlan
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Public Sub AuditPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.CenterToScreen()
        TabPage2.Focus()
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
        Addtorow.Enabled = True
        SearchText.Enabled = True
        Tab.Enabled = True
        Update.Enabled = False
        Delete.Enabled = False
        AuditorGrid.Enabled = True
        AuditorGridAct.Enabled = True
        CriteriaGrid.Enabled = True
        CriteriaGridAct.Enabled = True
        UpdateStatus.Enabled = False
        SearchTextAct.Enabled = True
        'Auditdate.MinDate = DateTime.Now() 
        Try
            Dim strQuery As String
            strQuery = "Select Standards from Standards; 
                        Select Concat(FName, ' ', LName) As Name, EID from Employee;
                        Select Concat(FName, ' ', LName) As Name, EID from Employee where EID NOt in (Select distinct EMPID from Auditplan);
                        Select 
                            AiD As ID, 
                            (Select AuditID from AuditCycle where ACId = AuditPlan.AuditID) As AuditID, 
                            (Select Standards from Standards where sid = AuditPlan.Criteria) As Standards ,
                            (Select Department from Department where Did = AuditPlan.Department) As Department, 
                            AuditDate, 
                            Comments, 
                            (Select concat(FName, ' ', LName) from Employee where Eid = AuditPlan.EmpID) As Auditor
							from AuditPlan Where 
							AuditID = (select ACId from AuditCycle where AuditID='" + AuditID.Text + "') AND AID NOT IN
							(Select AID from AuditPlan Where ExecuteStatus= 'Completed' or ExecuteStatus = 'Cancelled');
                        Select DID, Department from Department;
                        Select AuditID from AuditCycle;
                        Select AuditID As AuditID from AuditCycle;
                        Select 
                            AP.AId As P_ID,
                            (Select AuditID from AuditCycle where Acid = AP.AuditID) As Audit_Cycle,
                            (Select Standards from Standards where sid = AP.Criteria) As Standards,
                            (Select Department from Department where DId = AP.Department) As Department,
                            AP.AuditDate as P_Date,
                            AP.Comments as P_Comments,
                            (Select CONCAT(Fname,' ', LName) from Employee where Eid = AP.EMPID) as P_Auditor,
                            AA.ActualId as A_ID,
                            AA.AuditDate As A_AuditDate,
                            AA.Comments As A_Comments,
                            (Select CONCAT(Fname,' ', LName) from Employee where Eid = AA.EMPID) As A_Auditor,
                            AA.Status as Audit_Status,
                            AP.ExecuteStatus as Execute_Status
                            from AuditPlan As AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId 
							Where AId NOT IN 
							(Select 
                            AId from AuditPlan As AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId Where Status = 'Completed' or Status = 'Cancelled');
                            Select 
                            AP.AId As [Plan ID],
                            (Select AuditID from AuditCycle where Acid = AP.AuditID) As [Audit Cycle],
                            (Select Department from Department where DId = AP.Department) As Department,
                            AP.AuditDate as [Planned Date],
                            AA.AuditDate As [Actual AuditDate],
							AA.Status as [Audit Status],
							PAS.CDate As [Circulated Date],
							PAS.RDate As [Received Date Date],
							PAS.VDate As [Verified Date],
							PAS.EComments as [Effectiveness],
							PAS.CloseStatus as [Closure Status]
                            from AuditPlan AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId
							LEFT JOIN PostAuditStatus PAS ON AP.AuditID = PAS.AuditID AND AP.Department = PAS.Department
							Where AP.AId IN 
							(Select 
                            AId from AuditPlan As AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId 
							Where Status = 'Completed')"
            Dim Getdata As New GetdataSet()
            Dim Sqldataset As DataSet = Getdata.GetDataset(strQuery)
            CriteriaGrid.DataSource = Sqldataset.Tables(0)
            CriteriaGridAct.DataSource = Sqldataset.Tables(0)
            AuditorGrid.DataSource = Sqldataset.Tables(1)
            AuditorGridAct.DataSource = Sqldataset.Tables(1)
            UnAllocAuditorGrid.DataSource = Sqldataset.Tables(2)
            ActAuditor.DataSource = Sqldataset.Tables(1)
            DataGridView1.DataSource = Sqldataset.Tables(3)
            DataGridView1Act.DataSource = Sqldataset.Tables(7)
            DataGridView2.DataSource = Sqldataset.Tables(8)
            Department.DataSource = Sqldataset.Tables(4)
            Department.DisplayMember = "Department"
            Department.ValueMember = "Department"
            DepartmentAct.DataSource = Sqldataset.Tables(4)
            DepartmentAct.DisplayMember = "Department"
            DepartmentAct.ValueMember = "Department"
            AuditID.DataSource = Sqldataset.Tables(5)
            AuditID.DisplayMember = "AuditID"
            AuditID.ValueMember = "AuditID"
            ActAuditID.DataSource = Sqldataset.Tables(6)
            ActAuditID.DisplayMember = "AuditID"
            ActAuditID.ValueMember = "AuditID"
            Count.Text = DataGridView1.Rows.Count & " Records found"
            CountAct.Text = DataGridView1Act.Rows.Count & " Records found"
            Sqldataset.Dispose()
            'DGCOlor(DataGridView2)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Addtorow_Click(sender As Object, e As EventArgs) Handles Addtorow.Click
        For Each fld As Control In GroupBox1.Controls
            If TypeOf fld Is ComboBox Or TypeOf fld Is TextBox Or TypeOf fld Is RichTextBox Then
                If fld.Text = Nothing Then
                    MsgBox("Please fill up all fields", vbOKOnly)
                    Exit Sub
                End If
            End If
        Next
        Try
            For Each Selrow As DataGridViewRow In CriteriaGrid.Rows
                If Selrow.Cells("CriteriaSelection").Value = True Then
                    For Each Selrow1 As DataGridViewRow In AuditorGrid.Rows
                        If Selrow1.Cells("AuditorSelection").Value = True Then
                            sqlCon = New SqlConnection(strConn)
                            Using (sqlCon)
                                Dim sqlComm As New SqlCommand()
                                sqlComm.Connection = sqlCon
                                sqlComm.CommandText = "InsertIntoAuditPlan"
                                sqlComm.CommandType = CommandType.StoredProcedure
                                sqlComm.Parameters.AddWithValue("AuditID", AuditID.Text)
                                sqlComm.Parameters.AddWithValue("Department", Department.Text)
                                sqlComm.Parameters.AddWithValue("Auditdate", Auditdate.Value.Date)
                                sqlComm.Parameters.AddWithValue("Comments", CommentsBox.Text)
                                sqlComm.Parameters.AddWithValue("EID", Selrow1.Cells("EID").Value.ToString)
                                sqlComm.Parameters.AddWithValue("Criteria", Selrow.Cells("Standards").Value.ToString)
                                sqlCon.Open()
                                sqlComm.ExecuteNonQuery()
                                sqlCon.Close()
                            End Using
                        End If
                    Next
                End If
            Next
            MessageBox.Show("New audit plan item(s) is(are) added successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AuditPlan_Load(e, e)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Department_SelectedValueChanged(sender As Object, e As EventArgs) Handles Department.SelectedValueChanged
        Try
            Dim strQuery As String
            strQuery = "Select Concat(FName, ' ', LName) As Name, EID from Employee where Eid NOT IN 
                        (Select EID from Employee Where Department = (Select Did from Department where Department = '" & Department.Text & "'))"
            Dim Getdata As New GetdataSet()
            Dim Sqldataset As DataSet = Getdata.GetDataset(strQuery)
            AuditorGrid.DataSource = Sqldataset.Tables(0)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchText_TextChanged(sender As Object, e As EventArgs) Handles SearchText.TextChanged
        FilterData(SearchText.Text, DataGridView1, AuditID.Text)
        Dim strquery As String = "Select 
                            AiD As ID, 
                            (Select AuditID from AuditCycle where ACId = AuditPlan.AuditID) As AuditID, 
                            (Select Standards from Standards where sid = AuditPlan.Criteria) As Standards ,
                            (Select Department from Department where Did = AuditPlan.Department) As Department, 
                            AuditDate, 
                            Comments, 
							(Select concat(FName, ' ', LName) from Employee where Eid = AuditPlan.EmpID) As Auditor
							from AuditPlan 
                            Where 
                                    concat(
                                    (Select AuditID from AuditCycle where ACId = AuditPlan.AuditID), 
                                    (Select Standards from Standards where sid = AuditPlan.Criteria), 
                                    (Select Department from Department where Did = AuditPlan.Department), 
                                    (Select concat(FName, ' ', LName) from Employee where Eid = AuditPlan.EmpID),
                                    Auditdate
                                        ) Like 
                                            '%" & SearchText.Text & "%' AND 
							AuditID = (select ACId from AuditCycle where AuditID='" + AuditID.Text + "') AND AID NOT IN
							(Select AID from AuditPlan Where ExecuteStatus= 'Completed' or ExecuteStatus = 'Cancelled')"

        Dim Getdata As New GetdataSet()
        Dim Sqldataset As DataSet = Getdata.GetDataset(strquery)
        DataGridView1.Refresh()
        DataGridView1.DataSource = Sqldataset.Tables(0)
        Count.Text = DataGridView1.Rows.Count & " Records found"
    End Sub

    Public Sub FilterData(ValuetoSearch As String, DG As DataGridView, Key As String)
        Dim strquery As String = "Select 
                         AiD As ID, 
                        (Select AuditID from AuditCycle where ACId = AuditPlan.AuditID) As AuditID, 
                        (Select Standards from Standards where sid = AuditPlan.Criteria) As Standards ,
                        (Select Department from Department where Did = AuditPlan.Department) As Department, 
                        Auditdate,
                        Comments,
                        (Select concat(FName, ' ', LName) from Employee where Eid = AuditPlan.EmpID) As Auditor  
                            From AuditPlan 
                            Where 
                                concat(
                                    (Select AuditID from AuditCycle where ACId = AuditPlan.AuditID), 
                                    (Select Standards from Standards where sid = AuditPlan.Criteria), 
                                    (Select Department from Department where Did = AuditPlan.Department), 
                                    (Select concat(FName, ' ', LName) from Employee where Eid = AuditPlan.EmpID),
                                    Auditdate
                                        ) Like 
                                            '%" & ValuetoSearch & "%' AND AuditID = (select ACId from AuditCycle where AuditID='" + Key + "')"

        Dim Getdata As New GetdataSet()
        Dim Sqldataset As DataSet = Getdata.GetDataset(strquery)
        DG.Refresh()
        DG.DataSource = Sqldataset.Tables(0)
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        AuditPlan_Load(e, e)
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
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "UpdateAuditPlan"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("AiD", IAMSKey.Text)
                sqlComm.Parameters.AddWithValue("AuditID", AuditID.Text)
                sqlComm.Parameters.AddWithValue("Department", Department.Text)
                sqlComm.Parameters.AddWithValue("Auditdate", Auditdate.Value.Date)
                sqlComm.Parameters.AddWithValue("Comments", CommentsBox.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                sqlCon.Close()
            End Using
            MessageBox.Show("New requirement(s) is(are) added successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AuditPlan_Load(e, e)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Update.Enabled = True
            Delete.Enabled = True
            Addtorow.Enabled = False
            SearchText.Enabled = False
            Dim ID As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim strQuery As String
            strQuery = "SELECT * FROM AuditPlan where Aid = '" & ID & "'; 
                        Select AiD, 
                        (Select AuditID from AuditCycle where ACId = AuditPlan.AuditID) As AuditID, 
                        (Select Standards from Standards where sid = AuditPlan.Criteria) As Standards ,
                        (Select Department from Department where Did = AuditPlan.Department) As Department, 
                        Auditdate,
                        Comments,
                        (Select concat(FName, ' ', LName) from Employee where Eid = AuditPlan.EmpID) As Name  
                        From AuditPlan where Aid = '" & ID & "'"
            Dim GetData As New GetdataSet()
            Dim SQLDataset As DataSet = GetData.GetDataset(strQuery)
            IAMSKey.Text = SQLDataset.Tables(1).Rows(0).Item("AID").ToString()
            Department.Text = SQLDataset.Tables(1).Rows(0).Item("Department").ToString()
            Auditdate.Text = SQLDataset.Tables(1).Rows(0).Item("Auditdate").ToString()
            CommentsBox.Text = SQLDataset.Tables(1).Rows(0).Item("Comments").ToString()
            strQuery = "Select Standards from Standards where sid = (select criteria from AuditPlan where Aid = '" & ID & "');
                        Select concat(FName, ' ', LName) from Employee where Eid = (select EMPID from AuditPlan where Aid = '" & ID & "')"
            CriteriaGrid.DataSource = GetData.GetDataset(strQuery).Tables(0)
            CriteriaGrid.Rows(0).Cells(0).Value = True
            CriteriaGrid.Enabled = False
            AuditorGrid.DataSource = GetData.GetDataset(strQuery).Tables(1)
            AuditorGrid.Rows(0).Cells(0).Value = True
            AuditorGrid.Enabled = False
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Update.Enabled = False
            Delete.Enabled = False
            Addtorow.Enabled = True
            SearchText.Enabled = True
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "DeleteAuditPlan"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("AiD", IAMSKey.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                sqlCon.Close()
            End Using
            MessageBox.Show("Requirement is deleted successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AuditPlan_Load(e, e)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AuditID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AuditID.SelectedIndexChanged
        Index_Value_Change(DataGridView1, AuditID.Text)
        Count.Text = DataGridView1.Rows.Count & " Records found"
    End Sub

    Private Sub AuditID_SelectedValueChanged(sender As Object, e As EventArgs) Handles AuditID.SelectedValueChanged
        Index_Value_Change(DataGridView1, AuditID.Text)
        Count.Text = DataGridView1.Rows.Count & " Records found"
    End Sub

    Private Sub SearchTextAct_TextChanged(sender As Object, e As EventArgs) Handles SearchTextAct.TextChanged
        Dim strquery As String = "Select 
                            AP.AId As P_ID,
                            (Select AuditID from AuditCycle where Acid = AP.AuditID) As Audit_Cycle,
                            (Select Standards from Standards where sid = AP.Criteria) As Standards,
                            (Select Department from Department where DId = AP.Department) As Department,
                            AP.AuditDate as P_Date,
                            AP.Comments as P_Comments,
                            (Select CONCAT(Fname,' ', LName) from Employee where Eid = AP.EMPID) as P_Auditor,
                            AA.ActualId as A_ID,
                            AA.AuditDate As A_AuditDate,
                            AA.Comments As A_Comments,
                            (Select CONCAT(Fname,' ', LName) from Employee where Eid = AA.EMPID) As A_Auditor,
                            AA.Status as Audit_Status,
                            AP.ExecuteStatus as Execute_Status
                            from AuditPlan As AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId 
							Where 
                            concat (AP.AId,
                            (Select AuditID from AuditCycle where Acid = AP.AuditID),
                            (Select Standards from Standards where sid = AP.Criteria),
                            (Select Department from Department where DId = AP.Department),
                            (Select CONCAT(Fname,' ', LName) from Employee where Eid = AP.EMPID),
                            (Select CONCAT(Fname,' ', LName) from Employee where Eid = AA.EMPID),
                            AP.ExecuteStatus,
                            AA.Status) Like '%" & SearchTextAct.Text & "%'
                            AND 
                            AId NOT IN 
							(Select AId from AuditPlan As AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId 
                            Where Status = 'Completed' or Status = 'Cancelled')"
        Dim Getdata As New GetdataSet()
        Dim Sqldataset As DataSet = Getdata.GetDataset(strquery)
        DataGridView1Act.Refresh()
        DataGridView1Act.DataSource = Sqldataset.Tables(0)
        CountAct.Text = DataGridView1Act.Rows.Count & " Records found"
    End Sub

    Public Sub Index_Value_Change(DG As DataGridView, Key As String)
        Try
            DG.DataBindings.Clear()
            Dim strQuery As String
            strQuery = "Select 
                            AiD As ID, 
                            (Select AuditID from AuditCycle where ACId = AuditPlan.AuditID) As AuditID, 
                            (Select Standards from Standards where sid = AuditPlan.Criteria) As Standards ,
                            (Select Department from Department where Did = AuditPlan.Department) As Department, 
                            AuditDate, 
                            Comments, 
                            (Select concat(FName, ' ', LName) from Employee where Eid = AuditPlan.EmpID) As Auditor
							from AuditPlan Where 
							AuditID = (select ACId from AuditCycle where AuditID='" + Key + "') AND AID NOT IN
							(Select AID from AuditPlan Where ExecuteStatus= 'Completed' or ExecuteStatus = 'Cancelled')"
            Dim Getdata As New GetdataSet()
            Dim Sqldataset As DataSet = Getdata.GetDataset(strQuery)
            DG.DataSource = Sqldataset.Tables(0)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateStatus_Click(sender As Object, e As EventArgs) Handles UpdateStatus.Click
        For Each fld As Control In GroupBox2.Controls
            If TypeOf fld Is ComboBox Or TypeOf fld Is TextBox Or TypeOf fld Is RichTextBox Then
                If fld.Text = Nothing Then
                    MsgBox("Please fill up all fields", vbOKOnly)
                    Exit Sub
                End If
            End If
        Next
        Try
            For Each Selrow As DataGridViewRow In ActAuditor.SelectedRows
                'If Selrow.Cells("ActAuditorSelection").Value = True Then
                sqlCon = New SqlConnection(Strconn)
                Using (sqlCon)
                    Dim sqlComm As New SqlCommand()
                    sqlComm.Connection = sqlCon
                    sqlComm.CommandText = "InsertIntoAuditActual"
                    sqlComm.CommandType = CommandType.StoredProcedure
                    sqlComm.Parameters.AddWithValue("PlanID", IAMSKeyAct.Text)
                    sqlComm.Parameters.AddWithValue("Auditdate", ActAuditDate.Value.Date)
                    sqlComm.Parameters.AddWithValue("Comments", ActComments.Text)
                    sqlComm.Parameters.AddWithValue("EID", Selrow.Cells("EID").Value.ToString)
                    sqlComm.Parameters.AddWithValue("Status", AuditStatus.Text)
                    sqlCon.Open()
                    sqlComm.ExecuteNonQuery()
                    sqlCon.Close()
                End Using
                'End If
            Next
            MessageBox.Show("New audit plan item(s) is(are) added successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            AuditPlan_Load(e, e)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1Act_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1Act.CellDoubleClick
        Try
            UpdateStatus.Enabled = True
            SearchTextAct.Enabled = False
            Dim ID As Object = DataGridView1Act.Rows(e.RowIndex).Cells(0).Value
            Dim ID1 As Object = DataGridView1Act.Rows(e.RowIndex).Cells(7).Value
            Dim strQuery As String
            strQuery = "Select 
                        AP.AId As P_ID,
                        (Select AuditID from AuditCycle where Acid = AP.AuditID) As Audit_Cycle,
                        (Select Standards from Standards where sid = AP.Criteria) As Standards,
                        (Select Department from Department where DId = AP.Department) As Department,
                        AP.AuditDate as P_Date,
                        AP.Comments as P_Comments,
                        (Select CONCAT(Fname,' ', LName) from Employee where Eid = AP.EMPID) as P_Auditor,
                        AA.ActualId as A_ID,
                        AA.AuditDate As A_AuditDate,
                        AA.Comments As A_Comments,
                        (Select CONCAT(Fname,' ', LName) from Employee where Eid = AA.EMPID) As A_Auditor,
                        AA.Status as Audit_Status
                        from AuditPlan As AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId where AP.AID = '" & ID & "'"
            Dim GetData As New GetdataSet()
            Dim SQLDataset As DataSet = GetData.GetDataset(strQuery)
            IAMSKeyAct.Text = SQLDataset.Tables(0).Rows(0).Item("P_ID").ToString()
            ActAuditID.Text = SQLDataset.Tables(0).Rows(0).Item("Audit_Cycle").ToString()
            DepartmentAct.Text = SQLDataset.Tables(0).Rows(0).Item("Department").ToString()
            AuditDateAct.Text = SQLDataset.Tables(0).Rows(0).Item("P_Date").ToString()
            CommentsAct.Text = SQLDataset.Tables(0).Rows(0).Item("P_Comments").ToString()
            ActAuditDate.Text = SQLDataset.Tables(0).Rows(0).Item("A_Auditdate").ToString()
            ActComments.Text = SQLDataset.Tables(0).Rows(0).Item("A_Comments").ToString()
            AuditStatus.Text = SQLDataset.Tables(0).Rows(0).Item("Audit_Status").ToString()
            strQuery = "Select Standards from Standards where sid = (select criteria from AuditPlan where Aid = '" & ID & "');
                        Select concat(FName, ' ', LName) from Employee where Eid = (select EMPID from AuditPlan where Aid = '" & ID & "')"
            CriteriaGridAct.DataSource = GetData.GetDataset(strQuery).Tables(0)
            CriteriaGridAct.Rows(0).Cells(0).Value = True
            CriteriaGridAct.Enabled = False
            AuditorGridAct.DataSource = GetData.GetDataset(strQuery).Tables(1)
            AuditorGridAct.Rows(0).Cells(0).Value = True
            AuditorGridAct.Enabled = False
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            UpdateStatus.Enabled = False
            SearchTextAct.Enabled = True
        End Try
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim ExporttoExcel As New Export
        Dim Location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + AuditID.Text + "_AuditPlan.xls"
        ExporttoExcel.Export_Click(e, e, DataGridView1, Location)
    End Sub

    Private Sub ExportAct_Click(sender As Object, e As EventArgs) Handles ExportAct.Click
        Dim ExporttoExcel As New Export
        Dim Location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + ActAuditID.Text + "_AuditActual.xls"
        ExporttoExcel.Export_Click(e, e, DataGridView1Act, Location)
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Try
            UpdateRCA.Enabled = True
            SearchRCA.Enabled = False
            AIDP.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
            DepartmentP.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            UpdateRCA.Enabled = False
            SearchRCA.Enabled = True
        End Try
    End Sub

    Private Sub UpdateRCA_Click(sender As Object, e As EventArgs) Handles UpdateRCA.Click
        For Each fld As Control In GroupBox3.Controls
            If TypeOf fld Is ComboBox Or TypeOf fld Is TextBox Or TypeOf fld Is RichTextBox Or TypeOf fld Is DateTimePicker Then
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
                sqlComm.CommandText = "InsertIntoPostStatus"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("AIDP", AIDP.Text)
                sqlComm.Parameters.AddWithValue("DepartmentP", DepartmentP.Text)
                sqlComm.Parameters.AddWithValue("CDate", C1Date.Value.Date)
                sqlComm.Parameters.AddWithValue("VDate", VDate.Value.Date)
                sqlComm.Parameters.AddWithValue("RDate", RDAte.Value.Date)
                sqlComm.Parameters.AddWithValue("EComments", EComments.Text)
                sqlComm.Parameters.AddWithValue("CloseStatus", CloseStatus.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                sqlCon.Close()
            End Using
            MessageBox.Show("Post Audit Status has been updated successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetRCA_Click(e, e)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DGCOlor(DG As DataGridView)
        Try
            For Each rows As DataGridViewRow In DG.Rows
                If Not rows.Cells("Closure Status").Value = "Closed" Then
                    rows.DefaultCellStyle.BackColor = Color.IndianRed
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResetRCA_Click(sender As Object, e As EventArgs) Handles ResetRCA.Click
        For Each ctrl In GroupBox3.Controls
            If TypeOf ctrl Is ComboBox Or TypeOf ctrl Is RichTextBox Then
                ctrl.Text = Nothing
            End If
        Next
    End Sub

    Private Sub SearchRCA_TextChanged(sender As Object, e As EventArgs) Handles SearchRCA.TextChanged
        Dim strquery As String = "Select 
                            AP.AId As [Plan ID],
                            (Select AuditID from AuditCycle where Acid = AP.AuditID) As [Audit Cycle],
                            (Select Department from Department where DId = AP.Department) As Department,
                            AP.AuditDate as [Planned Date],
                            AA.AuditDate As [Actual AuditDate],
							AA.Status as [Audit Status],
							PAS.CDate As [Circulated Date],
							PAS.RDate As [Received Date Date],
							PAS.VDate As [Verified Date],
							PAS.EComments as [Effectiveness],
							PAS.CloseStatus as [Closure Status]
                            from AuditPlan AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId
							LEFT JOIN PostAuditStatus PAS ON AP.AuditID = PAS.AuditID AND AP.Department = PAS.Department
							Where concat(AP.AId,
                            (Select AuditID from AuditCycle where Acid = AP.AuditID),
                            (Select Department from Department where DId = AP.Department),
                            PAS.EComments,
                            PAS.CloseStatus,
                            AA.Status) Like '%" + SearchRCA.Text + "%' and AP.AId IN 
							(Select 
                            AId from AuditPlan As AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId 
							Where Status = 'Completed')"
        Dim Getdata As New GetdataSet()
        Dim Sqldataset As DataSet = Getdata.GetDataset(strquery)
        DataGridView2.Refresh()
        DataGridView2.DataSource = Sqldataset.Tables(0)
        Label20.Text = DataGridView2.Rows.Count & " Records found"
    End Sub
End Class