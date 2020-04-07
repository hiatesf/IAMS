Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Imports System.IO.StreamWriter
Public Class RequirementMgmt
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection

    Private Sub RequirementMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ClearSelection()
        Me.CenterToScreen()
        Update.Enabled = False
        FilterData("")
        Try
            Dim strQuery As String
            strQuery = "Select rid, (Select Standards from Standards where sid = Requirements.Standards) As Standard, (Select ClauseNo from Clause where cid = Requirements.ClauseNo) as Clause, Subheader, Requirement, ObjEvi, (Select Department from Department where did = Requirements.Department) as Department from Requirements;
                        Select (Select Standards from Standards where sid = Clause.Standard) As Standard, ClauseNo from Clause;
                        Select Department from Department"
            sqlCon = New SqlConnection(Strconn)
            Dim Sqladapter As New SqlDataAdapter(strQuery, sqlCon)
            Dim Sqldataset As New DataSet
            Sqladapter.Fill(Sqldataset)
            DataGridView1.DataSource = Sqldataset.Tables(0)
            DataGridView1.Columns("rid").Visible = False
            DataGridView2.DataSource = Sqldataset.Tables(1)
            DepartmentGrid.DataSource = Sqldataset.Tables(2)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            For Each Deprow As DataGridViewRow In DepartmentGrid.Rows
                If Deprow.Cells("SelectionDep").Value = True Then
                    For Each Selrow As DataGridViewRow In DataGridView2.Rows
                        If Selrow.Cells("Selection").Value = True Then
                            sqlCon = New SqlConnection(Strconn)
                            Using (sqlCon)
                                Dim sqlComm As New SqlCommand()
                                sqlComm.Connection = sqlCon
                                sqlComm.CommandText = "InsertIntoRequirements"
                                sqlComm.CommandType = CommandType.StoredProcedure
                                sqlComm.Parameters.AddWithValue("ClauseNo", Selrow.Cells("ClauseNo").Value.ToString)
                                sqlComm.Parameters.AddWithValue("Standards", Selrow.Cells("Standard").Value.ToString)
                                sqlComm.Parameters.AddWithValue("Department", Deprow.Cells("Department").Value.ToString)
                                sqlComm.Parameters.AddWithValue("Subheader", Subheader.Text)
                                sqlComm.Parameters.AddWithValue("Requiement", Requirement.Text)
                                sqlComm.Parameters.AddWithValue("ObjEvi", ObjEvidence.Text)
                                sqlCon.Open()
                                sqlComm.ExecuteNonQuery()
                                sqlCon.Close()
                            End Using
                        End If
                    Next
                End If
            Next
            MessageBox.Show("New requirement(s) is(are) added successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RequirementMgmt_Load(e, e)
            For Each ctrl As Control In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                    ctrl.Text = Nothing
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        'For Each fld As Control In GroupBox1.Controls
        '    If fld.Text = Nothing Then
        '        MsgBox("Please fill up all fields", vbOKOnly)
        '        Exit Sub
        '    End If
        'Next
        Try
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "UpdateRequirements"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("rid", IAMSKey.Text)
                sqlComm.Parameters.AddWithValue("Subheader", Subheader.Text)
                sqlComm.Parameters.AddWithValue("Requiement", Requirement.Text)
                sqlComm.Parameters.AddWithValue("ObjEvi", ObjEvidence.Text)
                sqlComm.Parameters.AddWithValue("ClauseNo", DataGridView2.Rows(0).Cells("ClauseNo").Value)
                sqlComm.Parameters.AddWithValue("Standards", DataGridView2.Rows(0).Cells("Standards").Value)
                sqlComm.Parameters.AddWithValue("Department", DataGridView2.Rows(0).Cells("Department").Value)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                MessageBox.Show("The details are updated successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RequirementMgmt_Load(e, e)
                For Each ctrl As Control In GroupBox1.Controls
                    If TypeOf ctrl Is TextBox Then
                        ctrl.Text = Nothing
                    End If
                Next
            End Using
            Update.Enabled = False
            Save.Enabled = True
            SearchText.Visible = True
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Update.Enabled = True
            Save.Enabled = False
            SearchText.Visible = False
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Update.Enabled = True
            Save.Enabled = False
            SearchText.Visible = False
            Dim ID As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim strQuery As String
            strQuery = "SELECT * FROM Requirements where rid = @rid"
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                sqlComm.Parameters.AddWithValue("@rid", ID)
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        IAMSKey.Text = sqlReader.Item("rId").ToString()
                        Subheader.Text = sqlReader.Item("Subheader").ToString()
                        Requirement.Text = sqlReader.Item("Requirement").ToString()
                        ObjEvidence.Text = sqlReader.Item("ObjEvi").ToString()
                    End While
                End If
                sqlReader.Close()
            End Using
            Dim refreshnow As New RefreshmeGeneral()
            Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("Select Standards.Standards, Clause.ClauseNo from Standards, Clause where Standards.sid = (select Standards from Requirements where rid = '" & ID & "') And Clause.cid = (select ClauseNo from Requirements where rid = '" & ID & "')")
            DataGridView2.DataSource = StrQueryR
            DataGridView2.Rows(0).Cells(0).Value = True
            StrQueryR = refreshnow.RefreshmeGeneral("Select Department from Department where did = (select department from Requirements where rid = '" & ID & "')")
            DepartmentGrid.DataSource = StrQueryR
            DataGridView2.Rows(0).Cells(0).Value = True
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Update.Enabled = False
            Save.Enabled = True
            SearchText.Visible = True
        End Try
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim ExporttoExcel As New Export
        Dim Location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + "Complete Requirements.xls"
        ExporttoExcel.Export_Click(e, e, DataGridView1, Location)
    End Sub

    Public Sub FilterData(ValuetoSearch As String)
        Dim strquery As String = "select (Select Standards from Standards where sid = Clause.Standard) As Standard, ClauseNo from Clause Where concat((Select Standards from Standards where sid = Clause.Standard), ClauseNo) Like '%" & ValuetoSearch & "%'"
        sqlCon = New SqlConnection(strConn)
        Dim Sqladapter As New SqlDataAdapter(strquery, sqlCon)
        Dim Sqldataset As New DataTable()
        Sqladapter.Fill(Sqldataset)
        DataGridView2.DataSource = Sqldataset
    End Sub
    Private Sub SearchText_TextChanged(sender As Object, e As EventArgs) Handles SearchText.TextChanged
        FilterData(SearchText.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            DataGridView1.ClearSelection()
            DataGridView2.ClearSelection()
            For Each ctrl As Control In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = Nothing
                End If
            Next
            Dim refreshnow As New RefreshmeGeneral()
            Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("Select rid, (Select Standards from Standards where sid = Requirements.Standards) As Standard, (Select ClauseNo from Clause where cid = Requirements.ClauseNo) as Clause, Subheader, Requirement, ObjEvi from Requirements")
            DataGridView1.DataSource = StrQueryR
            DataGridView1.Columns("rid").Visible = False
            StrQueryR = refreshnow.RefreshmeGeneral("Select (Select Standards from Standards where sid = Clause.Standard) As Standard, ClauseNo from Clause Where concat((Select Standards from Standards where sid = Clause.Standard), ClauseNo) NOT in (Select concat((Select Standards from Standards where sid = Requirements.Standards), (Select ClauseNo from Clause where cid = Requirements.ClauseNo))from Requirements)")
            DataGridView2.DataSource = StrQueryR
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Save.Enabled = True
        Update.Enabled = False
        SearchText.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim getdata As New GetdataSet
        Dim Strquery As String = "Select rid, (Select Standards from Standards where sid = Requirements.Standards) As Standard, (Select ClauseNo from Clause where cid = Requirements.ClauseNo) as Clause, Subheader, Requirement, ObjEvi, (Select Department from Department where did = Requirements.Department) as Department from Requirements
                                    Where concat
                                            (rid, 
                                            (Select Standards from Standards where sid = Requirements.Standards),
                                            (Select ClauseNo from Clause where cid = Requirements.ClauseNo),
                                            Subheader, 
                                            Requirement, 
                                            ObjEvi,
											(Select Department from Department where did = Requirements.Department))
                                            Like '%" + TextBox1.Text + "%'"
        DataGridView1.DataSource = getdata.GetDataset(Strquery).Tables(0)
    End Sub
End Class