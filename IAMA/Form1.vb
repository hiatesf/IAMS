Imports System.Data.SqlClient 'Import SQL Capabilities
Imports System.IO.Stream
Imports System.Configuration
Public Class UserForm
    'Private strConn As String = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.IAMAConnectionString").ConnectionString
    'Private strConn As String = "Data Source=VIKRAM\SQLEXPRESS;Initial Catalog=IAMA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    'Private strConn As String = "Data Source ='" & My.Settings.Server & "';Initial Catalog='" & My.Settings.DBName & "';User='" & My.Settings.Username & "';Password='" & My.Settings.Password & "'"
    Private Connection As New ConnStr
    Private Strconn As String = Connection.StrCon
    Private sqlCon As SqlConnection
    Public Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UDDataGridView.ClearSelection()
        Me.CenterToScreen()
        EmpID.Items.Clear()
        Try
            Dim strQuery As String
            strQuery = "SELECT Eid FROM Employee where Eid NOT in (Select EMPID from Userdata); Select EmpID, Username from Userdata"
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        EmpID.Items.Add(sqlReader.Item("EID"))
                    End While
                End If
                sqlReader.Close()
            End Using
            sqlCon = New SqlConnection(strConn)
            Dim Sqladapter As New SqlDataAdapter(strQuery, sqlCon)
            Dim Sqldataset As New DataSet
            Sqladapter.Fill(Sqldataset)
            UDDataGridView.DataSource = Sqldataset.Tables(1)
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            For Each fld As Control In GroupBox1.Controls
                If fld.Text = "" Then
                    MsgBox("Please fill up all fields", vbOKOnly)
                    Exit Sub
                End If
            Next
            If Password.Text <> Repassword.Text Then
                MsgBox("Password does not match. Please reenter the same password", vbOKOnly)
                Password.Text = ""
                Repassword.Text = ""
                Exit Sub
            Else
                'To upload Image to DB from a picture box
                Dim wrapper As New Simple3Des(Username.Text)
                Dim fi As New System.IO.FileInfo(Userphoto.ImageLocation)
                Dim fs As System.IO.FileStream = fi.OpenRead
                Dim lBytes As Long = fs.Length
                Dim myImage(lBytes) As Byte
                fs.Read(myImage, 0, lBytes)
                fs.Close()
                sqlCon = New SqlConnection(strConn)
                Using (sqlCon)
                    Dim sqlComm As New SqlCommand()
                    sqlComm.Connection = sqlCon
                    sqlComm.CommandText = "InsertIntouserdata"
                    sqlComm.CommandType = CommandType.StoredProcedure
                    sqlComm.Parameters.AddWithValue("Username", Username.Text)
                    sqlComm.Parameters.AddWithValue("EmpID", Convert.ToInt32(EmpID.Text))
                    sqlComm.Parameters.AddWithValue("Password", wrapper.EncryptData(Password.Text))
                    sqlComm.Parameters.AddWithValue("Repassword", wrapper.EncryptData(Repassword.Text))
                    sqlComm.Parameters.AddWithValue("@Photo", myImage)
                    sqlCon.Open()
                    sqlComm.ExecuteNonQuery()
                    sqlCon.Close()
                    MessageBox.Show("A new user has been created successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim refreshnow As New RefreshmeGeneral()
                    Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("Select EmpID, Username from Userdata")
                    UDDataGridView.DataSource = StrQueryR
                    For Each ctrl As Control In GroupBox1.Controls
                        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                            ctrl.Text = Nothing
                        End If
                    Next
                    Userphoto.Image = Nothing
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Try
            Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()
            ImageDialogue.Title = "Please Select your Image."
            ImageDialogue.InitialDirectory = "C:\"
            ImageDialogue.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp;"
            ImageDialogue.RestoreDirectory = False
            If ImageDialogue.ShowDialog() = DialogResult.OK Then
                Userphoto.Image = Image.FromFile(ImageDialogue.FileName)
                Userphoto.ImageLocation = ImageDialogue.FileName
            End If
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Userphoto.Image = Nothing
    End Sub
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Try
            If Password.Text <> Repassword.Text Then
                MsgBox("Password does not match. Please reenter the same password", vbOKOnly)
                Password.Text = ""
                Repassword.Text = ""
                Exit Sub
            Else
                Dim wrapper As New Simple3Des(Username.Text)
                Dim fi As New System.IO.FileInfo(Userphoto.ImageLocation)
                Dim fs As System.IO.FileStream = fi.OpenRead
                Dim lBytes As Long = fs.Length
                Dim myImage(lBytes) As Byte
                fs.Read(myImage, 0, lBytes)
                fs.Close()
                sqlCon = New SqlConnection(strConn)
                Using (sqlCon)
                    Dim sqlComm As New SqlCommand()
                    sqlComm.Connection = sqlCon
                    sqlComm.CommandText = "UpdateUserdata"
                    sqlComm.CommandType = CommandType.StoredProcedure
                    sqlComm.Parameters.AddWithValue("Username", Username.Text)
                    'sqlComm.Parameters.AddWithValue("EmpID", Convert.ToInt32(EmpID.Text))
                    sqlComm.Parameters.AddWithValue("Password", wrapper.EncryptData(Password.Text))
                    sqlComm.Parameters.AddWithValue("Repassword", wrapper.EncryptData(Repassword.Text))
                    sqlComm.Parameters.AddWithValue("Photo", myImage)
                    sqlCon.Open()
                    sqlComm.ExecuteNonQuery()
                    UDDataGridView.Refresh()
                    MessageBox.Show("The details are updated successfully!", "Message - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Dim refreshnow As New RefreshmeGeneral()
                    Dim StrQueryR As DataTable = refreshnow.RefreshmeGeneral("Select EmpID, Username from Userdata")
                    UDDataGridView.DataSource = StrQueryR
                    For Each ctrl As Control In GroupBox1.Controls
                        If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                            ctrl.Text = Nothing
                        End If
                    Next
                    Userphoto.Image = Nothing
                End Using
                Update.Enabled = False
                Save.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Update.Enabled = False
            Save.Enabled = True
        End Try
    End Sub
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Try
            UDDataGridView.ClearSelection()
            For Each ctrl As Control In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                    ctrl.Text = Nothing
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Userphoto.Image = Nothing
        EmpID.Enabled = True
        Save.Enabled = True
        Update.Enabled = False
        Username.Enabled = True
    End Sub
    Private Sub UDDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles UDDataGridView.CellDoubleClick
        Try
            Update.Enabled = True
            Save.Enabled = False
            Dim ID As Object = UDDataGridView.Rows(e.RowIndex).Cells(1).Value
            Dim wrapper As New Simple3Des(ID.ToString())
            Dim strQuery As String
            strQuery = "SELECT * FROM Userdata where Username = @Username"
            sqlCon = New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                sqlComm.Parameters.AddWithValue("@Username", ID.ToString())
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        EmpID.Text = Nothing
                        Username.Text = sqlReader.Item("Username").ToString()
                        Password.Text = wrapper.DecryptData(sqlReader.Item("Password").ToString())
                        Repassword.Text = wrapper.DecryptData(sqlReader.Item("RePassword").ToString())
                        'To Download Image from DB And display in picture box
                        Dim imageData As Byte() = DirectCast(sqlReader.Item("Photo"), Byte())
                        Dim mem As New System.IO.MemoryStream(imageData)
                        Userphoto.Image = Image.FromStream(mem)
                        Save.Enabled = False
                        Username.Enabled = False
                        EmpID.Enabled = False
                    End While
                End If
                sqlReader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("IAMS has identified an Exception. Please share the following message with your IAMS Administrator for more clarifications" & vbNewLine & vbNewLine & ex.Message, "Error - IAMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Update.Enabled = False
            Save.Enabled = True
        End Try
    End Sub
    Private Sub Clsfrm_Click(sender As Object, e As EventArgs) Handles Clsfrm.Click
        Me.Close()
    End Sub

End Class




