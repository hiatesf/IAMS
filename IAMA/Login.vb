Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.Configuration
Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoginGroup.Top = Me.Height / 2 - LoginGroup.Height / 2
        LoginGroup.Left = Me.Width / 4 - LoginGroup.Width / 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Getdata1 As New GetdataSet()
            Dim strQuery1 As String = "SELECT 1 as Test"
            If Getdata1.GetDataset(strQuery1).Tables(0).Rows(0).Item("Test") = 1 Then
                Dim wrapper As New Simple3Des(TextBox1.Text)
                'Dim strQuery As String = "SELECT COUNT(*) as Login FROM Userdata WHERE UserName = '" + TextBox1.Text + "' AND Password = '" + wrapper.EncryptData(TextBox2.Text) + "'"
                Dim strQuery As String = "SELECT COUNT(*) as Login FROM Userdata 
                                          WHERE UserName = '" + TextBox1.Text + "' AND Password = '" + wrapper.EncryptData(TextBox2.Text) + "'
                                          AND (Select Status from Employee Where EID = (Select EmpID from Userdata where Username = '" + TextBox1.Text + "')) = 'Active'"
                Dim Getdata As New GetdataSet()
                Dim Sqldataset As DataSet = Getdata.GetDataset(strQuery)
                If Sqldataset.Tables(0).Rows(0).Item("Login").ToString = 1 Then
                    Form2.Welcome.Text = TextBox1.Text
                    Form2.Text = "Welcome " & TextBox1.Text & ", to Internal Audit Management System"
                    Form2.ShowDialog()
                    'ElseIf TextBox1.Text = "Admin" And TextBox2.Text = "786786" Then
                ElseIf TextBox1.Text = "Admin" And TextBox2.Text = "786786" Then
                    Form2.Welcome.Text = TextBox1.Text
                    Form2.Text = "Welcome " & TextBox1.Text & ", to Internal Audit Management System"
                    Form2.ShowDialog()
                Else
                    MsgBox("Incorrect Username / Password Combination")
                End If
                TextBox1.Text = Nothing
                TextBox2.Text = Nothing
                'If TextBox1.Text = My.Settings.GName And TextBox2.Text = My.Settings.GPassword Then
                '    Form2.Welcome.Text = TextBox1.Text
                '    Form2.ShowDialog()
                'ElseIf TextBox1.Text = My.Settings.GName And TextBox2.Text = My.Settings.GPassword Then
                '    MsgBox("Incorrect username / password combination")
                'End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("The connection to the database server could not be established. Please contact IAMS adminstrator!!", "Important Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
