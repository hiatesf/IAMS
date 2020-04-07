Imports System.Configuration
Imports System.Data.SqlClient
Public Class ConnStr
    Dim wrapper As New Simple3Des("CalteK#123")
    'Public StrCon As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" &
    'wrapper.DecryptData(My.Settings.Username.ToString) & "';Password='" & wrapper.DecryptData(My.Settings.Password.ToString) & "'"
    'Public StrCon As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Public StrCon As String = "Data Source=192.168.1.157;Initial Catalog=IAMA;Persist Security Info=True;User ID=sa;Password=Sap+0514"
    'Public StrCon As String = "Data Source=118.201.50.12;Initial Catalog=IAMA;Persist Security Info=True;User ID=sa;Password=Sap+0514"
End Class
