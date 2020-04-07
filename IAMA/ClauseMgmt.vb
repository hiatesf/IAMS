Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Public Class ClauseMgmt
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection

    Private Sub ClauseMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ClearSelection()
        Me.CenterToScreen()
        Update.Enabled = False
        Standards.Items.Clear()
        Try
            Dim strQuery As String
            strQuery = "Select Standards from Standards; SELECT ClauseNo, (Select Standards from Standards where sid = Clause.Standard) As Standard, Content FROM Clause"
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        Standards.Items.Add(sqlReader.Item("Standards"))
                    End While
                End If
            End Using
            sqlCon = New SqlConnection(strConn)
            Dim Sqladapter As New SqlDataAdapter(strQuery, sqlCon)
            Dim Sqldataset As New DataSet
            Sqladapter.Fill(Sqldataset)
            DataGridView1.DataSource = Sqldataset.Tables(1)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Update.Enabled = True
            Save.Enabled = False
            Dim ID As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim strQuery As String
            strQuery = "SELECT * FROM Clause where ClauseNo = @ClauseNo; Select Standards from Standards where sid = (SELECT Standard FROM Clause where ClauseNo = @ClauseNo)"
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                sqlComm.Parameters.AddWithValue("@ClauseNo", ID.ToString())
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        IAMSKey.Text = sqlReader.Item("CId").ToString()
                        ClauseNo.Text = sqlReader.Item("ClauseNo").ToString()
                        Content.Text = sqlReader.Item("Content").ToString()
                    End While
                    sqlReader.NextResult()
                    While (sqlReader.Read())
                        Standards.Text = sqlReader.Item("Standards").ToString()
                    End While
                End If
                sqlReader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Update.Enabled = False
            Save.Enabled = True
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        For Each fld As Control In GroupBox1.Controls
            If fld.Text = Nothing Then
                MsgBox("Please fill up all fields", vbOKOnly)
                Exit Sub
            End If
        Next
        Try
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "InsertIntoClause"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("ClauseNo", ClauseNo.Text)
                sqlComm.Parameters.AddWithValue("Standard", Standards.Text)
                sqlComm.Parameters.AddWithValue("Content", Content.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                MessageBox.Show("A new client has been created successfully!", "Message - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim refreshnow As New RefreshmeGeneral()
                Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("SELECT ClauseNo, (Select Standards from Standards where sid = Clause.Standard) As Standard, Content FROM Clause; Select Standards from Standards")
                DataGridView1.DataSource = StrQueryR
                For Each ctrl As Control In GroupBox1.Controls
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                        ctrl.Text = Nothing
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Try
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "UpdateClause"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("CID", IAMSKey.Text)
                sqlComm.Parameters.AddWithValue("ClauseNo", ClauseNo.Text)
                sqlComm.Parameters.AddWithValue("Standard", Standards.Text)
                sqlComm.Parameters.AddWithValue("Content", Content.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                DataGridView1.Refresh()
                MessageBox.Show("The details are updated successfully!", "Message - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Dim refreshnow As New RefreshmeGeneral()
                Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("SELECT ClauseNo, (Select Standards from Standards where sid = Clause.Standard) As Standard, Content FROM Clause; Select Standards from Standards")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            DataGridView1.ClearSelection()
            For Each ctrl As Control In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                    ctrl.Text = Nothing
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
        Save.Enabled = True
        Update.Enabled = False
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim ExporttoExcel As New Export
        Dim Location As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\" + "Clause Management.xls"
        ExporttoExcel.Export_Click(e, e, DataGridView1, Location)
    End Sub
End Class