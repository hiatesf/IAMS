Public Class Export
    Public Sub Export_Click(sender As Object, e As EventArgs, Datagridview1 As DataGridView, Location As String)
        'Dim mFileStream As New IO.StreamWriter("C:\\Users\\VA\\Desktop\Requirements.xls", False)
        Dim mFileStream As New IO.StreamWriter(Location, False)
        Try
            mFileStream.WriteLine("<?xml version=""1.0""?>")
            mFileStream.WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            mFileStream.WriteLine("<ss:Workbook xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet"">")
            mFileStream.WriteLine("<ss:Styles>")
            mFileStream.WriteLine("<ss:Style ss:ID=""1"">")
            mFileStream.WriteLine("<ss:Font ss:Bold=""1""/>")
            mFileStream.WriteLine("<ss:FontName=""Courier New""/>")
            mFileStream.WriteLine("</ss:Style>")
            mFileStream.WriteLine("</ss:Styles>")
            mFileStream.WriteLine("<ss:Worksheet ss:Name=""Sheet1"">")
            mFileStream.WriteLine("<ss:Table>")
            For x As Integer = 0 To Datagridview1.Columns.Count - 1
                mFileStream.WriteLine("<ss:Column ss:Width=""{0}""/>", Datagridview1.Columns.Item(x).Width)
            Next
            mFileStream.WriteLine("<ss:Row ss:StyleID=""1"">")
            For i As Integer = 0 To Datagridview1.Columns.Count - 1
                mFileStream.WriteLine("<ss:Cell>")
                mFileStream.WriteLine(String.Format("<ss:Data ss:Type=""String"">{0}</ss:Data>", Datagridview1.Columns.Item(i).HeaderText))
                mFileStream.WriteLine("</ss:Cell>")
            Next
            mFileStream.WriteLine("</ss:Row>")
            For intRow As Integer = 0 To Datagridview1.RowCount - 2
                mFileStream.WriteLine(String.Format("<ss:Row ss:Height =""{0}"">", Datagridview1.Rows(intRow).Height))
                For intCol As Integer = 0 To Datagridview1.Columns.Count - 1
                    mFileStream.WriteLine("<ss:Cell>")
                    mFileStream.WriteLine(String.Format("<ss:Data ss:Type=""String"">{0}</ss:Data>", Datagridview1.Item(intCol, intRow).Value.ToString))
                    mFileStream.WriteLine("</ss:Cell>")
                Next
                mFileStream.WriteLine("</ss:Row>")
            Next
            mFileStream.WriteLine("</ss:Table>")
            mFileStream.WriteLine("</ss:Worksheet>")
            mFileStream.WriteLine("</ss:Workbook>")
            mFileStream.Close()
            mFileStream.Dispose()
            mFileStream = Nothing
            MessageBox.Show("The data has been exported successfully!", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            mFileStream.Close()
            mFileStream.Dispose()
            mFileStream = Nothing
            MessageBox.Show("Error While Exporting Data To Excel. Error : " & ex.Message)
        End Try
    End Sub
End Class
