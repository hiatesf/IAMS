Imports System.Data.SqlClient 'Import SQL Capabilities
Public Class AccessRights
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Private Sub AccessRights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Dim StrQuery As String = "Select BID, ButtonName from Buttonlist Where BID NOT in (Select BID from RoleButton);
                                    Select BID, ButtonName from Buttonlist Where BID in (Select BID from RoleButton);
                                    Select role from iamsrole;
                                    select iamsrole.Role, ButtonList.ButtonName from iamsrole, ButtonList, RoleButton where iamsrole.rid = Rolebutton.RId and ButtonList.Bid = Rolebutton.BId"
        Dim Getdata As New GetdataSet()
        Dim Sqldataset As DataSet = Getdata.GetDataset(StrQuery)
        UMapForms.DataSource = Sqldataset.Tables(0)
        MapForms.DataSource = Sqldataset.Tables(1)
        RoleSel.DataSource = Sqldataset.Tables(2)
        RoleSel.DisplayMember = ("Role")
        RoleSel.ValueMember = ("Role")
        RoleSel.Text = Nothing
        DataGridView1.DataSource = Sqldataset.Tables(3)
        UMapCount.Text = UMapForms.Rows.Count & " Records found"
        MapCount.Text = MapForms.Rows.Count & " Records found"
        MapCountS.Text = DataGridView1.Rows.Count & " Records found"
    End Sub

    Private Sub RoleSel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoleSel.SelectedIndexChanged
        Dim StrQuery As String = "Select BID, ButtonName from Buttonlist Where BID NOT in (Select BId from RoleButton Where rid =(select rid from iamsrole where Role='" + RoleSel.Text + "'));
                                    Select BID, ButtonName from Buttonlist Where BID in (Select BId from RoleButton Where rid =(select rid from iamsrole where Role='" + RoleSel.Text + "'))"
        Dim Getdata As New GetdataSet()
        Dim Sqldataset As DataSet = Getdata.GetDataset(StrQuery)
        UMapForms.DataSource = Sqldataset.Tables(0)
        MapForms.DataSource = Sqldataset.Tables(1)
        UMapForms.DataBindings.Clear()
        MapForms.DataBindings.Clear()
        Sqldataset.Dispose()
        UMapCount.Text = UMapForms.Rows.Count & " Records found"
        MapCount.Text = MapForms.Rows.Count & " Records found"
        MapCountS.Text = DataGridView1.Rows.Count & " Records found"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Add.Click
        If RoleSel.Text = Nothing Then
            MessageBox.Show("Please select a role to perfom this action", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            AddRemove(UMapForms, MapForms)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Addall.Click
        If RoleSel.Text = Nothing Then
            MessageBox.Show("Please select a role to perfom this action", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UMapForms.SelectAll()
            AddRemove(UMapForms, MapForms)
        End If
    End Sub

    Private Sub Remove1_Click(sender As Object, e As EventArgs) Handles Remove1.Click
        AddRemove(MapForms, UMapForms)
    End Sub

    Private Sub Remove1All_Click(sender As Object, e As EventArgs) Handles Remove1All.Click
        MapForms.SelectAll()
        AddRemove(MapForms, UMapForms)
    End Sub

    Public Sub AddRemove(FromDg As DataGridView, ToDG As DataGridView)
        'Dim checkColumn = New DataGridViewCheckBoxColumn()
        'checkColumn.Name = "Selection"
        'checkColumn.HeaderText = "Select"
        'checkColumn.Width = 50
        'checkColumn.ReadOnly = False
        'ToDG.Columns.Add(checkColumn)
        For Each Selrow As DataGridViewRow In FromDg.SelectedRows
            Dim AR As DataRow = ToDG.DataSource.NewRow
            For CellRef As Integer = 0 To FromDg.ColumnCount - 1
                AR(CellRef) = Selrow.Cells(CellRef).Value
            Next
            ToDG.DataSource.Rows.Add(AR)
            FromDg.Rows.Remove(Selrow)
            'Selrow.Cells(FromDg.ColumnCount - 1).Value = True
        Next
    End Sub

    Private Sub UMapFormsSearch_TextChanged(sender As Object, e As EventArgs) Handles UMapFormsSearch.TextChanged
        Dim strquery As String = "Select BID, ButtonName from Buttonlist Where BID NOT in (Select BID from RoleButton Where rid =(select rid from iamsrole where Role='" + RoleSel.Text + "'))
                                  and concat(Bid, ButtonName) Like '%" + UMapFormsSearch.Text + "%'"
        FilterData(UMapFormsSearch.Text, UMapForms, strquery)
        UMapCount.Text = UMapForms.Rows.Count & " Records found"
    End Sub

    Private Sub MapFormsSearch_TextChanged(sender As Object, e As EventArgs) Handles MapFormsSearch.TextChanged
        Dim strquery As String = "Select BID, ButtonName from Buttonlist Where BID in (Select BID from RoleButton Where rid =(select rid from iamsrole where Role='" + RoleSel.Text + "'))
                                  and concat(Bid, ButtonName) Like '%" + MapFormsSearch.Text + "%'"
        FilterData(MapFormsSearch.Text, MapForms, strquery)
        MapCount.Text = MapForms.Rows.Count & " Records found"
    End Sub

    Public Sub FilterData(ValuetoSearch As String, DG As DataGridView, StrQuery As String)
        Dim Getdata As New GetdataSet()
        Dim Sqldataset As DataSet = Getdata.GetDataset(strquery)
        DG.Refresh()
        DG.DataSource = Sqldataset.Tables(0)
    End Sub

    Private Sub SummarySearch_TextChanged(sender As Object, e As EventArgs) Handles SummarySearch.TextChanged
        Dim strquery As String = "select iamsrole.Role, ButtonList.ButtonName from iamsrole, ButtonList, RoleButton where iamsrole.rid = Rolebutton.RId and ButtonList.Bid = Rolebutton.BId
                                  and concat(iamsrole.Role, ButtonList.ButtonName) Like '%" + SummarySearch.Text + "%'"
        FilterData(SummarySearch.Text, DataGridView1, strquery)
        MapCountS.Text = DataGridView1.Rows.Count & " Records found"
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        AccessRights_Load(e, e)
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If RoleSel.Text = Nothing Then
            MessageBox.Show("Please select a role to perfom this action", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                sqlCon = New SqlConnection(Strconn)
                Using (sqlCon)
                    Dim sqlComm As New SqlCommand()
                    sqlComm.Connection = sqlCon
                    sqlComm.CommandText = "DeleteRoleButton"
                    sqlComm.CommandType = CommandType.StoredProcedure
                    sqlComm.Parameters.AddWithValue("rid", RoleSel.Text)
                    sqlCon.Open()
                    sqlComm.ExecuteNonQuery()
                    sqlCon.Close()
                End Using
                For Each Selrow As DataGridViewRow In MapForms.Rows
                    sqlCon = New SqlConnection(Strconn)
                    Using (sqlCon)
                        Dim sqlComm As New SqlCommand()
                        sqlComm.Connection = sqlCon
                        sqlComm.CommandText = "InsertIntoRoleButton"
                        sqlComm.CommandType = CommandType.StoredProcedure
                        sqlComm.Parameters.AddWithValue("BID", Selrow.Cells(1).Value.ToString)
                        sqlComm.Parameters.AddWithValue("RID", RoleSel.Text)
                        sqlCon.Open()
                        sqlComm.ExecuteNonQuery()
                        sqlCon.Close()
                    End Using
                Next
                MessageBox.Show("Role has been mapped successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AccessRights_Load(e, e)
            Catch ex As Exception
                MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class