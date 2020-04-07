Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Public Class Standards
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Public Sub CreateDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ClearSelection()
        Me.CenterToScreen()
        Update.Enabled = False
        Try
            Dim strQuery As String
            strQuery = "SELECT Standards FROM Standards"
            sqlCon = New SqlConnection(strConn)
            Dim Sqladapter As New SqlDataAdapter(strQuery, sqlCon)
            Dim Sqldataset As New DataSet
            Sqladapter.Fill(Sqldataset)
            DataGridView1.DataSource = Sqldataset.Tables(0)
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
            strQuery = "SELECT * FROM Standards where Standards = @Standards"
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                sqlComm.Parameters.AddWithValue("@Standards", ID.ToString())
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        IAMSKey.Text = sqlReader.Item("sid").ToString()
                        Standard.Text = sqlReader.Item("Standards").ToString()
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

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Try
            For Each fld As Control In GroupBox1.Controls
                If fld.Text = Nothing Then
                    MsgBox("Please fill up all fields", vbOKOnly)
                    Exit Sub
                End If
            Next
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "UpdateStandards"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("sid", IAMSKey.Text)
                sqlComm.Parameters.AddWithValue("Standards", Standard.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                MessageBox.Show("The details are updated successfully", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Refreshme()
                Dim refreshnow As New RefreshmeGeneral()
                Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("SELECT Standards FROM Standards")
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
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Update.Enabled = True
            Save.Enabled = False
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            For Each fld As Control In GroupBox1.Controls
                If fld.Text = Nothing Then
                    MsgBox("Please fill up all fields", vbOKOnly)
                    Exit Sub
                End If
            Next
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "InsertIntoStandards"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("Standards", Standard.Text)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
                sqlCon.Close()
                MessageBox.Show("A new standard has been created successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim refreshnow As New RefreshmeGeneral()
                Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("SELECT Standards FROM Standards")
                DataGridView1.DataSource = StrQueryR
                For Each ctrl As Control In GroupBox1.Controls
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                        ctrl.Text = Nothing
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Clr.Click
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
    'Private Sub Refreshme()
    '    Try
    '        Dim strQuery As String
    '        strQuery = "SELECT Standards FROM Standards"
    '        sqlCon = New SqlConnection(strConn)
    '        Dim Sqladapter As New SqlDataAdapter(strQuery, sqlCon)
    '        Dim Sqldataset As New DataSet
    '        Sqladapter.Fill(Sqldataset)
    '        DataGridView1.DataSource = Sqldataset.Tables(0)
    '    Catch ex As Exception
    '        MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OK,
    '                        MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class