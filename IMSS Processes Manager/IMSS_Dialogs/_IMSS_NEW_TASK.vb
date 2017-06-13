Public Class _IMSS_NEW_TASK

    Private Sub _IMASS_Run_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMASS_Run.Click
        Try
            Process.Start(_IMSS_PROCESSESNAME_TextBox.Text) : Me.Close()
        Catch ex As Exception : _IMSS_PROCESSESNAME_TextBox.Clear() _
           : MessageBox.Show("ERROR : " & ex.Message.ToString(), Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) : End Try
    End Sub

    Private Sub _IMSS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel.Click
        Me.Close()
    End Sub
End Class