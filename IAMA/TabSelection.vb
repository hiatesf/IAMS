Public Class TabSelection
    Public Sub TabSelect(Tabcontrol2 As TabControl, Header As String, FormName As Form)
        For Each page As TabPage In Tabcontrol2.TabPages
            If page.Text = Header Then
                Tabcontrol2.SelectedTab = page
                Exit Sub
            Else
            End If
        Next
        FormName.TopLevel = False
        Dim tp = New TabPage(Header)
        Tabcontrol2.TabPages.Add(tp)
        tp.Controls.Add(FormName)
        FormName.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        FormName.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        FormName.Dock = DockStyle.Fill
        FormName.Show()
        FormName.AutoScroll = True
        tp.AutoScroll = True
        'FormName.DoubleBuffered = True
        'FormName.BackColor = Color.WhiteSmoke
        Tabcontrol2.SelectedTab = tp
    End Sub

    Private Function Form_load(Tabcontrol2 As TabControl, Header As String) As String
        For Each page As TabPage In Tabcontrol2.TabPages
            If page.Text = Header Then
                Form_load = True
                Return Form_load
                Exit Function
            Else
            End If
        Next
        Form_load = False
        Return Form_load
    End Function
End Class
