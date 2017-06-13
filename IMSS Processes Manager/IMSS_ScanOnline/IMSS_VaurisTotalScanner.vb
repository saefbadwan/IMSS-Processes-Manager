Public Class IMSS_VaurisTotalScanner
    Private _IMSS_VirusTotalClass As New IMSS_VirusTotal
    Private _IMSS_ViurusTotalUploaderPath_Var As String = String.Empty
    Private _IMSS_StartsWebBrowser As New Threading.Thread(AddressOf _IMSS_WebBrowser)
    Public Sub New(ByVal _IMSS_ViurusTotalUploaderPath As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        On Error Resume Next
        Control.CheckForIllegalCrossThreadCalls = False
        _IMSS_ViurusTotalUploaderPath_Var = _IMSS_ViurusTotalUploaderPath
        If Not _IMSS_ViurusTotalUploaderPath = "none" Then
            _IMSS_StartsWebBrowser.Start()
        Else
            WebBrowser1.Stop()
            WebBrowser1.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub _IMSS_WebBrowser()
        On Error Resume Next
        WebBrowser1.Navigate(_IMSS_VirusTotalClass.checkFile(_IMSS_ViurusTotalUploaderPath_Var))
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        On Error Resume Next
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            _IMSS_LoadingImage.Enabled = False
            _IMSS_LoadingPanel.Visible = False
            Me.Text = "IMSS Virus Total Scanner (...)"
        End If
    End Sub

    Private Sub IMSS_VaurisTotalScanner_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try : _IMSS_StartsWebBrowser.Abort() : Catch ex As Exception : End Try
    End Sub

End Class