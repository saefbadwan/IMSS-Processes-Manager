' بسم الله الرحمن الرحيم
Public Class IMSS_SCAN_OPTIONS
    Private _IMSS_TARGET_PATH_VAR As String = String.Empty
    Public Sub New(ByVal _IMSS_TARGET_PATH As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_TARGET_PATH_VAR = _IMSS_TARGET_PATH
    End Sub
    Private Sub _IMSS_Cancel_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel_button.Click
        Me.Close()
    End Sub

    Private Sub IMSS_SCAN_OPTIONS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_TITLE_PICTUREBOX.Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_TARGET_PATH_VAR).ToBitmap(), 100, 73)
        If IO.Path.GetFileName(_IMSS_TARGET_PATH_VAR).Length > 33 Then _IMSS_FileName_Label.Text = "File Name : " & IO.Path.GetFileName(_IMSS_TARGET_PATH_VAR).Substring(0, 33) Else _
                    _IMSS_FileName_Label.Text = "File Name : " & IO.Path.GetFileName(_IMSS_TARGET_PATH_VAR)
        _IMSS_FileSize_Label.Text = "File Size : " & _IMSS_FormatFileSize(New IO.FileInfo(_IMSS_TARGET_PATH_VAR).Length)
        _IMSS_FileType_Label.Text = "File Type : " & _IMSS_GetFileType(IO.Path.GetExtension(_IMSS_TARGET_PATH_VAR))
    End Sub

    Private Sub _IMSS_ViewItem_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ViewItem_Button.Click
        Try : Process.Start(IO.Path.GetDirectoryName(_IMSS_TARGET_PATH_VAR)) : Catch ex As Exception : End Try
    End Sub
    Private Function _IMSS_GetFileType(ByVal _IMSS_FilePath As String) As String
        Select Case _IMSS_FilePath
            Case ".exe"
                Return "Executable applicatin(.exe)" : Exit Select
            Case ".com"
                Return "Command File(.com)" : Exit Select
            Case ".shs"
                Return "Shell Scrap Object(.shs)" : Exit Select
            Case ".PIF"
                Return "Program Information File(.com)" : Exit Select
            Case ".VB"
                Return "VBScript File(.exe)" : Exit Select
            Case ".BAT"
                Return "Batch File(.com)" : Exit Select
            Case ".CMD"
                Return "Command Script(.exe)" : Exit Select
            Case ".SCT"
                Return "Windows Scriptlet(.com)" : Exit Select
            Case ".lnk"
                Return "Windows File Shortcut(.lnk)" : Exit Select
            Case Else
                Return "Unknown extension !" : Exit Select
        End Select
    End Function

    Private Sub _IMSS_SCAN_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SCAN_Button.Click
        Dim IMSS_VaurisTotalScanner As New IMSS_VaurisTotalScanner(_IMSS_TARGET_PATH_VAR)
        IMSS_VaurisTotalScanner.ShowDialog()
        Me.Close()
    End Sub
End Class