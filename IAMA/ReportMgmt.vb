Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Imports System.IO.StreamWriter
Imports System.Windows.Forms.DataVisualization.Charting
Public Class ReportMgmt
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Private Sub ReportMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.CenterToScreen()
        Try
            Dim strQuery As String
            strQuery = "Select AuditID from AuditCycle"
            Dim Getdata As New GetdataSet()
            AID.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            AID.DisplayMember = ("AuditID")
            AID.ValueMember = ("AuditID")
            CAID.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            CAID.DisplayMember = ("AuditID")
            CAID.ValueMember = ("AuditID")
            CRAID.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            CRAID.DisplayMember = ("AuditID")
            CRAID.ValueMember = ("AuditID")
            AID.Text = Nothing
            CAID.Text = Nothing
            CRAID.Text = Nothing
            Preview_Click(e, e)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AID.SelectedIndexChanged
        Try
            Dim strQuery As String
            'strQuery = "Select 
            '                     AP.AId As Plan_ID,
            '                     (Select AuditID from AuditCycle where Acid = AP.AuditID) As Audit_Cycle,
            '                     (Select Standards from Standards where sid = AP.Criteria) As Standards,
            '                     (Select Department from Department where DId = AP.Department) As Department,
            '                     AP.AuditDate as P_Date,
            '                     AP.Comments as P_Comments,
            '                     (Select CONCAT(Fname,' ', LName) from Employee where Eid = AP.EMPID) as P_Auditor,
            '                     AA.ActualId as Actual_ID,
            '                     AA.AuditDate As A_AuditDate,
            '                     AA.Comments As A_Comments,
            '                     (Select CONCAT(Fname,' ', LName) from Employee where Eid = AA.EMPID) As A_Auditor,
            '                     AA.Status as Audit_Status,
            '                     AP.ExecuteStatus as Execute_Status
            '                     from AuditPlan As AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId 
            'Where AuditID = (Select ACId from AuditCycle where AuditID = '" + AID.Text + "')"

            strQuery = "Select 
                            AP.AId As [Plan ID],
                            (Select AuditID from AuditCycle where Acid = AP.AuditID) As [Audit Cycle],
                            (Select Standards from Standards where sid = AP.Criteria) As Standards,
                            (Select Department from Department where DId = AP.Department) As Department,
                            AP.AuditDate as [Planned Date],
                            AP.Comments as [Plan Comments],
                            (Select CONCAT(Fname,' ', LName) from Employee where Eid = AP.EMPID) as [Planned Auditor],
                            AA.ActualId as [Actual ID],
                            AA.AuditDate As [Actual AuditDate],
                            AA.Comments As [Actual Comments],
                            (Select CONCAT(Fname,' ', LName) from Employee where Eid = AA.EMPID) As [Actual Auditor],
							AA.Status as [Audit Status],
							PAS.CDate As [Circulated Date],
							PAS.RDate As [Received Date],
							PAS.VDate As [Verified Date],
							PAS.EComments as [Effectiveness],
							PAS.CloseStatus as [Closure Status]
                            from AuditPlan AP LEFT JOIN AuditActual As AA ON AP.AID = AA.PlanId
							LEFT JOIN PostAuditStatus PAS ON AP.AuditID = PAS.AuditID AND AP.Department = PAS.Department
							Where AP.AuditID = (Select ACId from AuditCycle where AuditID = '" + AID.Text + "')"
            Dim Getdata As New GetdataSet()
            DataGridView1.DataSource = Getdata.GetDataset(strQuery).Tables(0)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message With your IAMS Administrator For more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AID_SelectedValueChanged(sender As Object, e As EventArgs) Handles AID.SelectedValueChanged
        AID_SelectedIndexChanged(e, e)
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Try
            Dim strQuery As String
            strQuery = "Select 
                        (Select Description from FCategory Where Fid = Compliance.FC) as FC, 
                        COUNT(*) As Count FROM Compliance 
                        Where 
                        AuditCycle = (Select ACID from AuditCycle Where AuditID = '" + CAID.Text + "') and 
                        Department = (Select Did from Department Where Department = '" + CDepartment.Text + "')
                        Group by FC;
                        SELECT 
                        (Select Description from FCategory Where Fid = Compliance.FC) as FC, 
                        COUNT(*) As Count FROM Compliance 
                        Where 
                        Department = (Select Did from Department Where Department = '" + CDepartment.Text + "')
	                    Group by FC;
                        SELECT 
                        (Select Description from FCategory Where Fid = Compliance.FC) as FC, 
                        COUNT(*) As Count FROM Compliance 
	                    Group by FC"
            Dim Getdata As New GetdataSet()
            DataGridView2.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            Dim Ds As DataTable = Getdata.GetDataset(strQuery).Tables(0)
            Chart1.Series.Clear()
            Chart1.Titles.Clear()
            Chart2.Series.Clear()
            Chart2.Titles.Clear()
            Chart3.Series.Clear()
            Chart3.Titles.Clear()
            Chart1.Series.Add("Finding Vs Count")
            Chart1.Titles.Add("Findings - " & CAID.Text & "-" + CDepartment.Text)
            Chart1.Series("Finding Vs Count").XValueMember = "FC"
            Chart1.Series("Finding Vs Count").YValueMembers = "Count"
            Chart1.ChartAreas("ChartArea1").AxisX.Title = "Types of Findings"
            Chart1.ChartAreas("ChartArea1").AxisY.Title = "No. of Occurences"
            Chart1.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            Chart2.Series.Add("Finding Vs Count")
            Chart2.Titles.Add("Overall Findings" + "-" + CDepartment.Text)
            Chart2.Series("Finding Vs Count").XValueMember = "FC"
            Chart2.Series("Finding Vs Count").YValueMembers = "Count"
            Chart2.ChartAreas("ChartArea1").AxisX.Title = "Types Of Findings"
            Chart2.ChartAreas("ChartArea1").AxisY.Title = "No. Of Occurences"
            Chart2.DataSource = Getdata.GetDataset(strQuery).Tables(1)
            Chart3.Series.Add("Finding Vs Count")
            Chart3.Titles.Add("Total Findings - All Cycles & All Departments")
            Chart3.Series("Finding Vs Count").XValueMember = "FC"
            Chart3.Series("Finding Vs Count").YValueMembers = "Count"
            Chart3.ChartAreas("ChartArea1").AxisX.Title = "Types Of Findings"
            Chart3.ChartAreas("ChartArea1").AxisY.Title = "No. Of Occurences"
            Chart3.DataSource = Getdata.GetDataset(strQuery).Tables(2)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message With your IAMS Administrator For more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CAID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CAID.SelectedIndexChanged
        Try
            CDepartment.Text = Nothing
            Dim strQuery As String
            strQuery = "Select Distinct (Select Department from Department Where DID = Auditplan.Department) As Department from AuditPlan Where AuditID = (Select ACId from AuditCycle where AuditID = '" + CAID.Text + "')"
            Dim Getdata As New GetdataSet()
            CDepartment.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            CDepartment.DisplayMember = ("Department")
            CDepartment.ValueMember = ("Department")
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CAID_SelectedValueChanged(sender As Object, e As EventArgs) Handles CAID.SelectedValueChanged
        CAID_SelectedIndexChanged(e, e)
    End Sub

    Private Sub CRAID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CRAID.SelectedIndexChanged
        Try
            Dim strQuery As String
            strQuery = "SELECT 
                        (Select Description from FCategory Where Fid = Compliance.FC) as FC,
                        COUNT(*) As Count FROM Compliance 
                        Where 
                        AuditCycle = (Select ACID from AuditCycle Where AuditID = '" + CAID.Text + "') and 
                        Department = (Select Did from Department Where Department = '" + CDepartment.Text + "')
                        Group by FC"
            Dim Getdata As New GetdataSet()
            CDepartment.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            CDepartment.DisplayMember = ("Department")
            CDepartment.ValueMember = ("Department")
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click
        Try
            Dim strQuery As String
            strQuery = "SELECT 
                        (Select Description from FCategory Where Fid = Compliance.FC) as [Finding Category], 
                        count(*)as Count,
                        COUNT(*) * 100/ sum(COUNT(*)) over() as [Occurence Rate]
                        FROM Compliance
                        Where 
                        AuditCycle = (Select ACID from AuditCycle Where AuditID = '" + CRAID.Text + "')
                        Group by FC;
                        Select [Audit Cycle], Compliance, [Non-Compliance]
                        from
                        (Select (Select AuditID from AuditCycle Where ACID = Compliance.AuditCycle) as [Audit Cycle], Status, count(*) as CT from Compliance group by AuditCycle, Status) up
                        PIVOT
                        (Sum(CT) for Status in (Compliance, [Non-Compliance])) as pvt
                        order by [Audit Cycle]"
            Dim Getdata As New GetdataSet()
            DataGridView3.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            DataGridView5.DataSource = Getdata.GetDataset(strQuery).Tables(1)
            'Dim Ds As DataTable = Getdata.GetDataset(strQuery).Tables(0)
            Chart6.Series.Clear()
            Chart6.Titles.Clear()
            Chart4.Series.Clear()
            Chart4.Titles.Clear()
            Chart5.Series.Clear()
            Chart5.Titles.Clear()
            Chart6.Series.Add("Occurence Count")
            Chart6.Titles.Add("Compliance Occurence Count - " & CRAID.Text)
            Chart6.Series("Occurence Count").XValueMember = "Finding Category"
            Chart6.Series("Occurence Count").YValueMembers = "Count"
            Chart6.ChartAreas("ChartArea1").AxisX.Title = "<--- Finding Category --->"
            Chart6.ChartAreas("ChartArea1").AxisY.Title = "<--- No. of Occurences --->"
            Chart6.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            Chart4.Series.Add("Occurence Rate")
            Chart4.Titles.Add("Compliance Rate" + "-" & CRAID.Text)
            Chart4.Series("Occurence Rate").XValueMember = "Finding Category"
            Chart4.Series("Occurence Rate").YValueMembers = "Occurence Rate"
            Chart4.ChartAreas("ChartArea1").AxisX.Title = "<--- Finding Category --->"
            Chart4.ChartAreas("ChartArea1").AxisY.Title = "<--- Occurence (%) --->"
            Chart4.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            Chart5.Series.Add("Compliance")
            Chart5.Series.Add("Non-Compliance")
            Chart5.Titles.Add("Status Across Cycles")
            Chart5.Series("Compliance").XValueMember = "Audit Cycle"
            Chart5.Series("Compliance").YValueMembers = ("Compliance")
            Chart5.Series("Non-Compliance").XValueMember = "Audit Cycle"
            Chart5.Series("Non-Compliance").YValueMembers = ("Non-Compliance")
            Chart5.ChartAreas("ChartArea1").AxisX.Title = "<--- Audit Cycles --->"
            Chart5.ChartAreas("ChartArea1").AxisY.Title = "No. Of Occurences"
            Chart5.DataSource = Getdata.GetDataset(strQuery).Tables(1)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message With your IAMS Administrator For more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Preview_Click(sender As Object, e As EventArgs) Handles Preview.Click
        Try
            Dim strQuery As String
            strQuery = "Select (Select AuditID from AuditCycle Where ACID = Compliance.AuditCycle) as [Audit Cycle], count(distinct(Auditor)) as [No. of Auditors] from Compliance group by AuditCycle"
            Dim Getdata As New GetdataSet()
            DataGridView6.DataSource = Getdata.GetDataset(strQuery).Tables(0)
            Chart9.Series.Clear()
            Chart9.Titles.Clear()
            Chart9.Series.Add("Auditors Usage")
            Chart9.Titles.Add("Auditor Usage Across Audit Cycles")
            Chart9.Series("Auditors Usage").XValueMember = "Audit Cycle"
            Chart9.Series("Auditors Usage").YValueMembers = "No. of Auditors"
            Chart9.ChartAreas("ChartArea1").AxisX.Title = "<--- Audit Cycles --->"
            Chart9.ChartAreas("ChartArea1").AxisY.Title = "<--- No. of Auditors --->"
            Chart9.DataSource = Getdata.GetDataset(strQuery).Tables(0)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message With your IAMS Administrator For more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim ExporttoExcel As New Export
        Dim Location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + AID.Text + "_AuditSummary.xls"
        ExporttoExcel.Export_Click(e, e, DataGridView1, Location)
    End Sub
End Class