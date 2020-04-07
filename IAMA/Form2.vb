Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Public Class Form2
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Private Populate As New TabSelection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        FormBorderStyle = FormBorderStyle.Fixed3D
        Label1.Width = Me.Width - 1
        Label1.Left = Me.Width / 2 - Label1.Width / 2
        TabControl1.Width = Me.Width - 1
        'TabControl1.Height = Me.Height - Label1.Height - 1
        TabControl1.Left = Me.Width / 2 - TabControl1.Width / 2
        Timer1.Start()
        Try
            Dim strQuery As String
            strQuery = "Select  
                        (Select AuditID from AuditCycle where ACId = AuditPlan.AuditID) As Audit_Cycle, 
                        (Select Department from Department where Did = AuditPlan.Department) As Department, 
                        AuditDate, 
                        (Select concat(FName, ' ', LName) from Employee where Eid = AuditPlan.EmpID) As Auditor  
                        from AuditPlan where AuditDate = CONVERT (date, GETDATE());
                         Select ButtonName from ButtonList where BID IN 
                        (Select BID from RoleButton 
                        where rid = (Select Role from Employee 
                            Where EID = (Select EmpID from Userdata where Username = '" + Welcome.Text + "')))"
            If Welcome.Text = "Admin" Then GoTo Trial
            Dim Getdata As New GetdataSet()
            Dim Sqldataset As DataSet = Getdata.GetDataset(strQuery)
            ''DataGridView1.DataSource = Sqldataset.Tables(0)
            For Each tab As TabPage In Me.TabControl1.TabPages
                For Each fld As Button In tab.Controls
                    For i As Integer = 0 To Sqldataset.Tables(1).Rows.Count - 1
                        If fld.Name = Sqldataset.Tables(1).Rows(i).Item("ButtonName") Then
                            fld.Visible = True
                            Exit For
                        Else
                            fld.Visible = False
                        End If
                    Next
                Next
            Next
Trial:      Locaters(TabControl1)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Role_Click(sender As Object, e As EventArgs) Handles Role.Click
        'CreateRole.ShowDialog()
        Dim Header As String = "Role Management"
        Populate.TabSelect(TabControl2, Header, CreateRole)
    End Sub

    Private Sub Employee_Click(sender As Object, e As EventArgs) Handles Employee.Click
        'Employeeform.ShowDialog()
        Dim Header As String = "Employee Management"
        Populate.TabSelect(TabControl2, Header, Employeeform)
    End Sub

    Private Sub User_Click(sender As Object, e As EventArgs) Handles User.Click
        'UserForm.ShowDialog()
        Dim Header As String = "Credential Management"
        Populate.TabSelect(TabControl2, Header, UserForm)
    End Sub

    Private Sub Department_Click(sender As Object, e As EventArgs) Handles Department.Click
        'CreateDept.ShowDialog()
        Dim Header As String = "Department Management"
        Populate.TabSelect(TabControl2, Header, CreateDept)
    End Sub

    Private Sub Category_Click(sender As Object, e As EventArgs) Handles Category.Click
        'FindingCategory.ShowDialog()
        Dim Header As String = "Findings Category"
        Populate.TabSelect(TabControl2, Header, FindingCategory)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClientMgmt.Click
        'Clientform.ShowDialog()
        Dim Header As String = "Client Management"
        Populate.TabSelect(TabControl2, Header, Clientform)
    End Sub

    Private Sub RoleToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'CreateRole.ShowDialog()
        Dim Header As String = "Role Management"
        Populate.TabSelect(TabControl2, Header, CreateRole)
    End Sub

    Private Sub Requirement_Click(sender As Object, e As EventArgs) Handles Requirement.Click
        'Standards.ShowDialog()
        Dim Header As String = "Standards Management"
        Populate.TabSelect(TabControl2, Header, Standards)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DBConfigB.Click
        'DBConfig.ShowDialog()
        Dim Header As String = "Database Management"
        Populate.TabSelect(TabControl2, Header, DBConfig)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ChangeDefPass.Click
        'ChangeDefPassword.ShowDialog()
        Dim Header As String = "Job Request"
        Populate.TabSelect(TabControl2, Header, JobRequest)
    End Sub

    Private Sub Clauses_Click(sender As Object, e As EventArgs) Handles Clauses.Click
        'ClauseMgmt.ShowDialog()
        Dim Header As String = "Clause Management"
        Populate.TabSelect(TabControl2, Header, ClauseMgmt)
    End Sub

    Private Sub ReqMgmt_Click(sender As Object, e As EventArgs) Handles ReqMgmt.Click
        'RequirementMgmt.ShowDialog()
        Dim Header As String = "Requirement Management"
        Populate.TabSelect(TabControl2, Header, RequirementMgmt)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles AuditCycleB.Click
        Dim Header As String = "Audit Cycle"
        Populate.TabSelect(TabControl2, Header, AuditCycle)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles AuditPlanB.Click
        'AuditPlan.ShowDialog()
        Dim Header As String = "Audit Plan"
        Populate.TabSelect(TabControl2, Header, AuditPlan)
    End Sub

    Private Sub AccessRightsB_Click(sender As Object, e As EventArgs) Handles AccessRightsB.Click
        'AccessRights.ShowDialog()
        Dim Header As String = "Access Rights"
        Populate.TabSelect(TabControl2, Header, AccessRights)
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim tdp As TabPage = TabControl2.SelectedTab
        TabControl2.TabPages.Remove(tdp)
        tdp.Dispose()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        For Each tdp As TabPage In TabControl2.TabPages
            TabControl2.TabPages.Remove(tdp)
            tdp.Dispose()
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Now.ToString("h:mm:ss tt, dd MMMM yyyy")
    End Sub

    Private Sub AChecklist_Click(sender As Object, e As EventArgs) Handles AChecklist.Click
        'AuditChecklist.ShowDialog()
        Dim Header As String = "Audit Checklist"
        Populate.TabSelect(TabControl2, Header, AuditChecklist)
    End Sub
    Private Sub Locaters(Tabcontrol As TabControl)
        'Dim j As Integer = 5
        'For tabindex As Integer = 0 To Tabcontrol.TabPages.Count - 1
        '    Tabcontrol.SelectedIndex = tabindex
        '    For Each fld As Button In Tabcontrol.SelectedTab.Controls
        '        If fld.Visible = True Then
        '            fld.Location = New Point(j, 6)
        '            j = j + 80
        '        Else
        '        End If
        '    Next
        '    j = 5
        'Next
        Dim j As Integer = 5
        For Each tab As TabPage In TabControl1.TabPages
            TabControl1.SelectedTab = tab
            For Each fld As Button In tab.Controls
                If fld.Visible = True Then
                    fld.Location = New Point(j, 6)
                    j = j + 80
                Else
                End If
            Next
            j = 5
        Next
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Report.Click
        Dim Header As String = "Report Management"
        Populate.TabSelect(TabControl2, Header, ReportMgmt)
    End Sub
End Class

