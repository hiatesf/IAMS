Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Public Class GetdataSet
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Public Function GetDataset(ByVal Input As String) As DataSet
        Dim strQuery As String
        strQuery = Input
        sqlCon = New SqlConnection(strConn)
        Dim Sqladapter As New SqlDataAdapter(strQuery, sqlCon)
        Dim Sqldataset As New DataSet
        Sqladapter.Fill(Sqldataset)
        Return (Sqldataset)
    End Function
End Class
