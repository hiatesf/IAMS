Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Public Class DBConfig
    Private sqlCon As SqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Test.Click
        Try
            Dim strConn As String = "Data Source ='" & Server.Text & "';Initial Catalog='" &
                DBName.Text & "';User='" & Username.Text & "';Password='" & Password.Text & "'"
            Dim strQuery As String = "SELECT 1"
            sqlCon = New SqlConnection(strConn)
            Dim Sqladapter As New SqlDataAdapter(strQuery, sqlCon)
            Dim Sqldataset As New DataSet
            Sqladapter.Fill(Sqldataset)
            MessageBox.Show("Connection Established!!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Connection Unsuccessful. Please try again", "Important Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            Dim wrapper As New Simple3Des("CalteK#123")
            My.Settings.Server = Server.Text
            My.Settings.DBName = DBName.Text
            My.Settings.Username = wrapper.EncryptData(Username.Text)
            My.Settings.Password = wrapper.EncryptData(Password.Text)
            My.Settings.Save()
            MessageBox.Show("Configuration Completed. The application will restart now. Open this window again and click Test button to check connection!!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            My.Settings.Reload()
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("Exception Identified in Encryption Process" & ex.Message, "Important Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DBConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        On Error Resume Next
        Dim wrapper As New Simple3Des("CalteK#123")
        Me.CenterToScreen()
        '    Server.Text = My.Settings.Server
        '    DBName.Text = My.Settings.DBName
        'Username.Text = wrapper.DecryptData(My.Settings.Username.ToString)
        'Password.Text = wrapper.DecryptData(My.Settings.Password.ToString)
        'Catch ex As Exception
        '   MessageBox.Show("Exception Identified in Decryption Process" & vbNewLine & vbNewLine & ex.Message, "Important Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class