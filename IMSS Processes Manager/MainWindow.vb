'بسم الله الرحمن الرحيم
Imports System.Runtime.InteropServices
Imports System.Management
Imports ComponentOwl.BetterListView
Imports System.ServiceProcess
Imports Cassia
Public Class MainWindow
#Region "IMSS DLL TARGET VAR"
#Region "IMSS Show Window In Target Status"
    Private Declare Function ShowWindow Lib "user32" (ByVal handle As IntPtr, ByVal nCmdShow As Integer) As Integer ' IMSS Show target window
    Private Sub _IMSS_ShowAppWindow(ByVal _IMSS_TARGET As String, ByVal _IMSS_TARGET_STATUS As Integer)
        Try
            Dim localByName As Process() = Process.GetProcessesByName(_IMSS_TARGET)
            For Each p As Process In localByName
                ShowWindow(p.MainWindowHandle, _IMSS_TARGET_STATUS) ' SW_MAXIMIZE
            Next
        Catch ex As Exception : Me.Refresh() : End Try
    End Sub
#End Region
#Region "IMSS VAR FOR MEMORY USAGE"
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)> _
    Public Class MEMORYSTATUSEX
        Public dwLength As UInteger
        Public dwMemoryLoad As UInteger
        Public ullTotalPhys As ULong
        Public ullAvailPhys As ULong
        Public ullTotalPageFile As ULong
        Public ullAvailPageFile As ULong
        Public ullTotalVirtual As ULong
        Public ullAvailVirtual As ULong
        Public ullAvailExtendedVirtual As ULong
        Public Sub New()
            Me.dwLength = CUInt(Marshal.SizeOf(GetType(MEMORYSTATUSEX)))
        End Sub
    End Class
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Private Shared Function GlobalMemoryStatusEx(<[In](), Out()> ByVal lpBuffer As MEMORYSTATUSEX) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

#End Region
#Region "IMSS PROCESS UINT VAR"
    <DllImport("psapi")> _
    Public Shared Function EmptyWorkingSet(ByVal hProcess As IntPtr) As Boolean
    End Function
    <DllImport("kernel32.dll")> _
    Private Shared Function OpenThread(ByVal dwDesiredAccess As ThreadAccess, ByVal bInheritHandle As Boolean, ByVal dwThreadId As Integer) As IntPtr
    End Function
    <DllImport("kernel32.dll")> _
    Private Shared Function ResumeThread(ByVal hThread As IntPtr) As Integer
    End Function
    <DllImport("Kernel32.dll")> _
    Private Shared Function SuspendThread(ByVal hThread As IntPtr) As Integer
    End Function
    Public Enum ThreadAccess
        DIRECT_IMPERSONATION = &H200
        GET_CONTEXT = 8
        IMPERSONATE = &H100
        QUERY_INFORMATION = &H40
        SET_CONTEXT = &H10
        SET_INFORMATION = &H20
        SET_THREAD_TOKEN = &H80
        SUSPEND_RESUME = 2
        TERMINATE = 1
    End Enum
#End Region
#Region "IMSS File Properties Show Dialog Var"
    <DllImport("Shell32", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function
    Private Const SEE_MASK_INVOKEIDLIST = &HC
    Private Const SEE_MASK_NOCLOSEPROCESS = &H40
    Private Const SEE_MASK_FLAG_NO_UI = &H400
    Public Const SW_SHOW As Short = 5
    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)> Public lpDirectory As String
        Dim nShow As Integer
        Dim hInstApp As IntPtr
        Dim lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)> Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As Integer
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure
#End Region
#End Region
    Private Sub _IMSS_Application_Tap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Application_Tap.Click
        _IMSS_SELECTED_INDEX = 10
        _IMSS_LOAD_APPLICATION_LISTVIEW()
        If _IMSS_APLICATION_LISTVIEW.Items.Count > 0 Then _IMSS_APLICATION_LISTVIEW.Items(0).Selected = True
    End Sub

    Private Sub _IMSS_APPLICATION_REFRESH_TIMER_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_APPLICATION_REFRESH_TIMER.Tick
        _IMSS_LOAD_APPLICATION_LISTVIEW()
    End Sub
    Private _IMSS_ALL_PROCESS_COUNT As Integer = 0
    Private Sub _IMSS_LOAD_APPLICATION_LISTVIEW()
        On Error Resume Next
        _IMSS_APLICATION_LISTVIEW.BeginUpdate()
        _IMSS_ALL_PROCESS_COUNT = 0
        _IMSS_APLICATION_LISTVIEW.Items.Clear()
        For Each p As Process In Process.GetProcesses
            _IMSS_ALL_PROCESS_COUNT += 1
            If p.MainWindowTitle = String.Empty = False Then
                'Add the process name, the main window title, and the process ID (what windows uses to identify the process) to the listbox)
                With _IMSS_APLICATION_LISTVIEW.Items.Add(p.MainWindowTitle)
                    .Tag = p.ProcessName & "|" & p.Modules(0).FileName.ToString()
                    .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(p.Modules(0).FileName.ToString()).ToBitmap(), 16, 16)
                    .SubItems.Add("Running")
                End With
            End If
        Next
        _IMSS_TOTALE_PROCESS_STATUSBAR.Text = "Processes : " & _IMSS_ALL_PROCESS_COUNT & "     "
        _IMSS_APLICATION_LISTVIEW.EndUpdate()
    End Sub

    Private Sub _IMSS_PROCESSES_Tap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_PROCESSES_Tap.Click
        _IMSS_SELECTED_INDEX = 0
        _IMSS_APPLICATION_REFRESH_TIMER.Enabled = False
        _IMSS_PROCESSES_CONTROLER.SelectedTab = TabPage1
    End Sub

    Private Sub _IMSS_SwitchTo_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SwitchTo_Button.Click
        _IMSS_SwitchTo()
    End Sub
    Private Sub _IMSS_SwitchTo()
        On Error Resume Next
        If _IMSS_APLICATION_LISTVIEW.Items.Count > 1 Then _IMSS_ShowAppWindow(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(0, _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.IndexOf("|")), 6)
        Me.WindowState = FormWindowState.Minimized
        If _IMSS_APLICATION_LISTVIEW.Items.Count > 1 Then _IMSS_ShowAppWindow(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(0, _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.IndexOf("|")), 3)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _IMSS_PROCESS As New _IMSS_NEW_TASK
        _IMSS_PROCESS.ShowDialog() : _IMSS_LOAD_APPLICATION_LISTVIEW()
    End Sub
    Public Function _IMSS_GET_CPU_USAGE() As Integer
        Return _IMSS_CPU_Performance.NextValue()
    End Function
    Private _IMSS_CPU_Performance As New PerformanceCounter()
    Private Sub _IMSS_INSTALL_LOAD_VAR()
        _IMSS_CPU_Performance.CategoryName = "Processor"
        _IMSS_CPU_Performance.CounterName = "% Processor Time"
        _IMSS_CPU_Performance.InstanceName = "_Total"
    End Sub
    Private Function _IMSS_GetSystemRAMSize() As UInteger
        Try
            Dim result As New MEMORYSTATUSEX()
            If GlobalMemoryStatusEx(result) Then
                Return (100.0 * result.ullAvailPhys / result.ullTotalPhys)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message.ToString())
        End Try
        Return 0
    End Function

    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        _IMSS_PROCESSES_REFRESH.Abort()
    End Sub
    Private Sub _IMSS_Set_Search_Options()
        _IMSS_APLICATION_LISTVIEW.SearchSettings = New BetterListViewSearchSettings(
    _IMSS_APLICATION_LISTVIEW.SearchSettings.Mode,
    _IMSS_APLICATION_LISTVIEW.SearchSettings.Options Or BetterListViewSearchOptions.UpdateSearchHighlight,
    _IMSS_APLICATION_LISTVIEW.SearchSettings.SubItemIndices) : _IMSS_APLICATION_LISTVIEW.Focus()

        _IMSS_PROCESSES_LISTVIEW.SearchSettings = New BetterListViewSearchSettings(
_IMSS_PROCESSES_LISTVIEW.SearchSettings.Mode,
_IMSS_PROCESSES_LISTVIEW.SearchSettings.Options Or BetterListViewSearchOptions.UpdateSearchHighlight,
_IMSS_PROCESSES_LISTVIEW.SearchSettings.SubItemIndices)

        _IMSS_PROCESSES_SYSTEM_LIST.SearchSettings = New BetterListViewSearchSettings(
_IMSS_PROCESSES_SYSTEM_LIST.SearchSettings.Mode,
_IMSS_PROCESSES_SYSTEM_LIST.SearchSettings.Options Or BetterListViewSearchOptions.UpdateSearchHighlight,
_IMSS_PROCESSES_SYSTEM_LIST.SearchSettings.SubItemIndices)

        _IMSS_PROCESSES_NETWORK_LISTVIEW.SearchSettings = New BetterListViewSearchSettings(
_IMSS_PROCESSES_NETWORK_LISTVIEW.SearchSettings.Mode,
_IMSS_PROCESSES_NETWORK_LISTVIEW.SearchSettings.Options Or BetterListViewSearchOptions.UpdateSearchHighlight,
_IMSS_PROCESSES_NETWORK_LISTVIEW.SearchSettings.SubItemIndices)


        _IMSS_LOCAL_SERVICES_LISTVIEW.SearchSettings = New BetterListViewSearchSettings(
_IMSS_LOCAL_SERVICES_LISTVIEW.SearchSettings.Mode,
_IMSS_LOCAL_SERVICES_LISTVIEW.SearchSettings.Options Or BetterListViewSearchOptions.UpdateSearchHighlight,
_IMSS_LOCAL_SERVICES_LISTVIEW.SearchSettings.SubItemIndices)

        _IMSS_SERVICES_LISTVIEW.SearchSettings = New BetterListViewSearchSettings(
_IMSS_SERVICES_LISTVIEW.SearchSettings.Mode,
_IMSS_SERVICES_LISTVIEW.SearchSettings.Options Or BetterListViewSearchOptions.UpdateSearchHighlight,
_IMSS_SERVICES_LISTVIEW.SearchSettings.SubItemIndices)

    End Sub
    Dim _IMSS_PROCESSES_REFRESH As New Threading.Thread(AddressOf _IMSS_Get_Processes)
    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        _IMSS_Set_Search_Options()
        _IMSS_SELECTED_INDEX = 4
        _IMSS_LOAD_APPLICATION_LISTVIEW()
        _IMSS_INSTALL_LOAD_VAR()
        _IMSS_CPU_USAGE_Label.Text = "CPU usage : " & _IMSS_GET_CPU_USAGE() & "%" & "            "
        _IMSS_PhysicalMemory_Label.Text = "PhysicalMemory : " & Math.Round(100 - _IMSS_GetSystemRAMSize()) & "%" & "      "
        If _IMSS_APLICATION_LISTVIEW.Items.Count > 0 Then _IMSS_APLICATION_LISTVIEW.Items(0).Selected = True
        _IMSS_GET_CPU_USAGE_TIMER.Enabled = True
        _IMSS_APPLICATION_REFRESH_TIMER.Enabled = True
        _IMSS_PROCESSES_REFRESH.Priority = Threading.ThreadPriority.Normal
        _IMSS_PROCESSES_REFRESH.IsBackground = True
        _IMSS_PROCESSES_REFRESH.Start()
        _IMSS_SuspendedList.Clear()
    End Sub

    Private Sub _IMSS_GET_CPU_USAGE_TIMER_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_GET_CPU_USAGE_TIMER.Tick
        _IMSS_CPU_USAGE_Label.Text = "CPU usage : " & _IMSS_GET_CPU_USAGE() & "%" & "            "
        _IMSS_PhysicalMemory_Label.Text = "PhysicalMemory : " & Math.Round(100 - _IMSS_GetSystemRAMSize()) & "%" & "      "
    End Sub

    Private Sub _IMSS_END_TASK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_END_TASK_Button.Click
        _IMSS_EndTask()
    End Sub
    Private Sub _IMSS_EndTask()
        Try
            For Each p As Process In Process.GetProcessesByName(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(0, _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.IndexOf("|"))) : p.Kill() : Next
            _IMSS_LOAD_APPLICATION_LISTVIEW()
        Catch ex As Exception
            Shell("Taskkill /F /IM " & _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(0, _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.IndexOf("|")) & _
                  IO.Path.GetExtension(
           _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().IndexOf("|") + 1, _
                          _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Length() - _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().IndexOf("|") - 1)), AppWinStyle.Hide, True)
            _IMSS_LOAD_APPLICATION_LISTVIEW()
        End Try
    End Sub

    Private Sub _IMSS_APPLICAT_ContextMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _IMSS_APPLICAT_ContextMenu.Opening
        If Me._IMSS_APLICATION_LISTVIEW.SelectedItems.Count = 0 Then
            _IMSS_SET_CONTEXT_ITEMS(True, False)
            ' e.Cancel = True
        Else
            _IMSS_SET_CONTEXT_ITEMS(False, True)
        End If
    End Sub
    Private Sub _IMSS_SET_CONTEXT_ITEMS(ByVal _IMSS_ITEMS_TARGET As Boolean, ByVal _IMSS_ITEM_RETARGET As Boolean)
        _IMSS_SwitchTo_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_BringToFront_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_Minimize_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_Maximize_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_EndTask_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_GoToProcess_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_OpenFileLocation_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_ScanOnline_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_Separator1_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_Separator2_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_Separator3_Context.Visible = _IMSS_ITEM_RETARGET
        _IMSS_NewTaskRun_Context.Visible = _IMSS_ITEMS_TARGET
    End Sub
    Private Sub _IMSS_SwitchTo_Context_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SwitchTo_Context.Click
        _IMSS_SwitchTo()
    End Sub

    Private Sub _IMSS_BringToFront_Context_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_BringToFront_Context.Click
        MsgBox(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Text)
        AppActivate(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Text)
    End Sub

    Private Sub _IMSS_Minimize_Context_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Minimize_Context.Click
        If _IMSS_APLICATION_LISTVIEW.Items.Count > 1 Then _IMSS_ShowAppWindow(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(0, _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.IndexOf("|")), 6)
    End Sub

    Private Sub _IMSS_Maximize_Context_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Maximize_Context.Click
        If _IMSS_APLICATION_LISTVIEW.SelectedItems.Count <> 0 Then
            If Not String.IsNullOrEmpty(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Text) Then _IMSS_ShowAppWindow(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(0, _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.IndexOf("|")), 3)
        End If
    End Sub

    Private Sub _IMSS_EndTask_Context_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_EndTask_Context.Click
        _IMSS_EndTask()
    End Sub

    Private Sub _IMSS_OpenFileLocation_Context_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OpenFileLocation_Context.Click
        Try : Process.Start(IO.Path.GetDirectoryName(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().IndexOf("|") + 1, _
                          _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Length() - _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().IndexOf("|") - 1))) : Catch ex As Exception : End Try
    End Sub

    Private Sub _IMSS_ScanOnline_Context_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ScanOnline_Context.Click
        On Error GoTo _IMSS_ON_ERROR
        If Not _IMSS_APLICATION_LISTVIEW.IsUpdating = True Then
            Dim _IMSS_SCAN_OPTIONS As New IMSS_SCAN_OPTIONS(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().IndexOf("|") + 1, _
                  _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Length() - _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().IndexOf("|") - 1))
            _IMSS_SCAN_OPTIONS.ShowDialog()
        End If
_IMSS_ON_ERROR:

    End Sub
#Region "IMSS PROCESSES UINT CONTROL"

    Private Sub _IMSS_START_PROCESSES_SYSTEMS()
        If _IMSS_PROCESSES_LISTVIEW.InvokeRequired = True Then
            _IMSS_PROCESSES_LISTVIEW.BeginInvoke(New MethodInvoker(AddressOf _IMSS_Get_Processes))
        Else
            _IMSS_Get_Processes()
        End If
    End Sub

    Private _IMSS_CLEAR_LIST As Boolean = True
    Private Delegate Sub _IMSS_ADD_TO_PROCESS_LIST_DELEGATE(ByRef _IMSS_PROCESSES_LISTVIEW_TARGET As BetterListView, ByRef _IMSS_LIST_ITEM As List(Of BetterListViewItem), ByVal _IMSS_THREAD As MainWindow)
    Private Sub _IMSS_ADD_TO_PROCESS_LIST(ByRef _IMSS_PROCESSES_LISTVIEW_TARGET As BetterListView, ByRef _IMSS_LIST_ITEM As List(Of BetterListViewItem), ByVal _IMSS_THREAD As MainWindow)
        If _IMSS_PROCESSES_LISTVIEW_TARGET.InvokeRequired = True Then
            _IMSS_PROCESSES_LISTVIEW_TARGET.BeginInvoke(New _IMSS_ADD_TO_PROCESS_LIST_DELEGATE(AddressOf _IMSS_ADD_TO_PROCESS_LIST), _IMSS_PROCESSES_LISTVIEW_TARGET, _IMSS_LIST_ITEM, _IMSS_THREAD)
        Else
            If _IMSS_CLEAR_LIST = False Then
                _IMSS_PROCESSES_LISTVIEW.Items.Clear()
                _IMSS_PROCESSES_SYSTEM_LIST.Items.Clear()
                _IMSS_PROCESSES_NETWORK_LISTVIEW.Items.Clear()
                _IMSS_LOCAL_SERVICES_LISTVIEW.Items.Clear()
                _IMSS_CLEAR_LIST = True
            End If
            _IMSS_PROCESSES_LISTVIEW_TARGET.Items.AddRange(_IMSS_LIST_ITEM.ToArray)
        End If
    End Sub
    Private _IMSS_PROCESES_KEY As Boolean = True

    Private _IMSS_NEW_PROCESSES_ITEM As New List(Of BetterListViewItem)
    Private Sub _IMSS_Get_Processes()
        Do
            _IMSS_NEW_PROCESSES_ITEM.Clear()
            Dim _IMSS_PROCESSES_LIST() As Process = Process.GetProcesses()
            Dim counter = New PerformanceCounter()
            Dim processFileVersionInfo As System.Diagnostics.FileVersionInfo
            Dim _IMSS_ProcessInfo_OnError As String = String.Empty
            Dim _IMSS_UserName As String = Environment.UserName
            counter.CategoryName = ("Process")
            counter.CounterName = "Working Set - Private"
            For Each _IMSS_PROCESS As Process In _IMSS_PROCESSES_LIST
                counter.InstanceName = _IMSS_PROCESS.ProcessName
                Try
                    processFileVersionInfo = FileVersionInfo.GetVersionInfo(_IMSS_PROCESS.MainModule.FileName)
                    _IMSS_ProcessInfo_OnError = processFileVersionInfo.FileDescription
                Catch : _IMSS_ProcessInfo_OnError = "Unavailable" : End Try
                Dim _IMSS_PROCESS_ITEM As New BetterListViewItem(_IMSS_PROCESS.ProcessName & ".exe")
                Select Case _IMSS_SELECTED_INDEX
                    Case 0
                        If GetProcessUserName(_IMSS_PROCESS) = _IMSS_UserName Then
                            With _IMSS_PROCESS_ITEM
                                Try : .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_PROCESS.Modules(0).FileName).ToBitmap(), 16, 16) : Catch : .Image = My.Resources._IMSS_ProcessesManager_Run_Icon_24x24 : End Try
                                Try : .SubItems.Add(_IMSS_PROCESS.PriorityClass.ToString()) : Catch : .SubItems.Add("Unavailable") : End Try
                                .SubItems.Add(_IMSS_UserName)
                                .SubItems.Add(_IMSS_PROCESS.Id.ToString())
                                .SubItems.Add((counter.RawValue \ 1024) & "K")
                                .SubItems.Add(_IMSS_ProcessInfo_OnError)
                            End With
                            _IMSS_NEW_PROCESSES_ITEM.Add(_IMSS_PROCESS_ITEM)
                        End If
                    Case 1
                        If GetProcessUserName(_IMSS_PROCESS) = ("SYSTEM") Then
                            With _IMSS_PROCESS_ITEM
                                Try : .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_PROCESS.Modules(0).FileName).ToBitmap(), 16, 16) : Catch : .Image = My.Resources._IMSS_ProcessesManager_Run_Icon_24x24 : End Try
                                Try : .SubItems.Add(_IMSS_PROCESS.PriorityClass.ToString()) : Catch : .SubItems.Add("Unavailable") : End Try
                                .SubItems.Add("SYSTEM")
                                .SubItems.Add(_IMSS_PROCESS.Id.ToString())
                                .SubItems.Add((counter.RawValue \ 1024) & "K")
                                .SubItems.Add(_IMSS_ProcessInfo_OnError)
                            End With
                            _IMSS_NEW_PROCESSES_ITEM.Add(_IMSS_PROCESS_ITEM)
                        End If
                    Case 2
                        If GetProcessUserName(_IMSS_PROCESS) = ("NETWORK SERVICE") Then
                            With _IMSS_PROCESS_ITEM
                                Try : .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_PROCESS.Modules(0).FileName).ToBitmap(), 16, 16) : Catch : .Image = My.Resources._IMSS_ProcessesManager_Run_Icon_24x24 : End Try
                                Try : .SubItems.Add(_IMSS_PROCESS.PriorityClass.ToString()) : Catch : .SubItems.Add("Unavailable") : End Try
                                .SubItems.Add("NETWORK SERVICE")
                                .SubItems.Add(_IMSS_PROCESS.Id.ToString())
                                .SubItems.Add((counter.RawValue \ 1024) & "K")
                                .SubItems.Add(_IMSS_ProcessInfo_OnError)
                            End With
                            _IMSS_NEW_PROCESSES_ITEM.Add(_IMSS_PROCESS_ITEM)
                        End If
                    Case 3
                        If GetProcessUserName(_IMSS_PROCESS) = ("LOCAL SERVICE") Then
                            With _IMSS_PROCESS_ITEM
                                Try : .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_PROCESS.Modules(0).FileName).ToBitmap(), 16, 16) : Catch : .Image = My.Resources._IMSS_ProcessesManager_Run_Icon_24x24 : End Try
                                Try : .SubItems.Add(_IMSS_PROCESS.PriorityClass.ToString()) : Catch : .SubItems.Add("Unavailable") : End Try
                                .SubItems.Add("LOCAL SERVICE")
                                .SubItems.Add(_IMSS_PROCESS.Id.ToString())
                                .SubItems.Add((counter.RawValue \ 1024) & "K")
                                .SubItems.Add(_IMSS_ProcessInfo_OnError)
                            End With
                            _IMSS_NEW_PROCESSES_ITEM.Add(_IMSS_PROCESS_ITEM)
                        End If
                    Case 4
                        If GetProcessUserName(_IMSS_PROCESS) = _IMSS_UserName Then
                            With _IMSS_PROCESS_ITEM
                                Try : .Image = _IMSS_ResizeImage(Icon.ExtractAssociatedIcon(_IMSS_PROCESS.Modules(0).FileName).ToBitmap(), 16, 16) : Catch : .Image = My.Resources._IMSS_ProcessesManager_Run_Icon_24x24 : End Try
                                Try : .SubItems.Add(_IMSS_PROCESS.PriorityClass.ToString()) : Catch : .SubItems.Add("Unavailable") : End Try
                                .SubItems.Add(_IMSS_UserName)
                                .SubItems.Add(_IMSS_PROCESS.Id.ToString())
                                .SubItems.Add((counter.RawValue \ 1024) & "K")
                                .SubItems.Add(_IMSS_ProcessInfo_OnError)
                            End With
                            _IMSS_NEW_PROCESSES_ITEM.Add(_IMSS_PROCESS_ITEM)
                        End If
                    Case 10 : Exit For : Exit Select
                End Select
            Next _IMSS_PROCESS : _IMSS_CLEAR_LIST = False
            Select Case _IMSS_SELECTED_INDEX
                Case 0
                    _IMSS_PROCESSES_LISTVIEW.BeginUpdate() : _IMSS_ADD_TO_PROCESS_LIST(_IMSS_PROCESSES_LISTVIEW, _IMSS_NEW_PROCESSES_ITEM, Me) : _IMSS_PROCESSES_LISTVIEW.EndUpdate() : Exit Select
                Case 1
                    _IMSS_PROCESSES_SYSTEM_LIST.BeginUpdate() : _IMSS_ADD_TO_PROCESS_LIST(_IMSS_PROCESSES_SYSTEM_LIST, _IMSS_NEW_PROCESSES_ITEM, Me) : _IMSS_PROCESSES_SYSTEM_LIST.EndUpdate() : Exit Select
                Case 2
                    _IMSS_PROCESSES_NETWORK_LISTVIEW.BeginUpdate() : _IMSS_ADD_TO_PROCESS_LIST(_IMSS_PROCESSES_NETWORK_LISTVIEW, _IMSS_NEW_PROCESSES_ITEM, Me) : _IMSS_PROCESSES_NETWORK_LISTVIEW.EndUpdate() : Exit Select
                Case 3
                    _IMSS_LOCAL_SERVICES_LISTVIEW.BeginUpdate() : _IMSS_ADD_TO_PROCESS_LIST(_IMSS_LOCAL_SERVICES_LISTVIEW, _IMSS_NEW_PROCESSES_ITEM, Me) : _IMSS_LOCAL_SERVICES_LISTVIEW.EndUpdate() : Exit Select
                Case 4
                    _IMSS_PROCESSES_LISTVIEW.BeginUpdate() : _IMSS_ADD_TO_PROCESS_LIST(_IMSS_PROCESSES_LISTVIEW, _IMSS_NEW_PROCESSES_ITEM, Me) : _IMSS_PROCESSES_LISTVIEW.EndUpdate() : _IMSS_SELECTED_INDEX = 10 : Exit Select
                Case Else
                    System.Threading.Thread.Sleep(1000) : Exit Select
            End Select
            System.Threading.Thread.Sleep(1000)
        Loop Until _IMSS_PROCESES_KEY = False
    End Sub
    Private Function GetProcessUserName(ByVal Process As Process) As String
        Dim sq As New ObjectQuery("Select * from Win32_Process Where ProcessID = '" & Process.Id & "'")
        Dim searcher As New ManagementObjectSearcher(sq)
        If searcher.Get.Count = 0 Then Return Nothing
        For Each oReturn As ManagementObject In searcher.Get
            Dim o As String() = New String(1) {}
            'Invoke the method and populate the o var with the user name and domain                                           
            oReturn.InvokeMethod("GetOwner", DirectCast(o, Object()))
            Return o(0)
        Next
        Return "ERROR"
    End Function
    Private _IMSS_SELECTED_INDEX As Integer = 10
    Private Sub _IMSS_PROCESSES_CONTROLER_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_PROCESSES_CONTROLER.SelectedIndexChanged
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SELECTED_INDEX = 0
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SELECTED_INDEX = 1
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SELECTED_INDEX = 2
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SELECTED_INDEX = 3
        End If
    End Sub
#End Region

    Private Sub _IMSS_Performance_SuperTap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Performance_SuperTap.Click
        _IMSS_SELECTED_INDEX = 10
        _IMSS_USERS_LISTVIEW.Items.Clear()
        _IMSS_LIST_USERS()
    End Sub
    Private Sub _IMSS_LIST_USERS()
        _IMSS_USERS_LISTVIEW.Items.Clear()
        For Each session As ITerminalServicesSession In New TerminalServicesManager().GetSessions()
            If Not String.IsNullOrEmpty(session.UserName) Then
                With _IMSS_USERS_LISTVIEW.Items.Add(session.UserName)
                    .Image = My.Resources._IMSS_User_Icon_16x16
                    .SubItems.Add(session.SessionId.ToString())
                    .SubItems.Add(session.ConnectionState.ToString()).Image = My.Resources._IMSS_SERVICE_RUN_Icon_16x16
                    .SubItems.Add(session.WindowStationName)
                    .SubItems.Add(session.UserAccount.Value)
                    .SubItems.Add(session.DomainName)
                    .SubItems.Add(session.ConnectTime.ToString())
                    .SubItems.Add(session.LoginTime.ToString())
                End With
            End If
        Next
    End Sub

    Private Sub _IMSS_SendCommand_Session(ByVal _IMSS_COMMAND As Integer, Optional ByVal _IMSS_MESSAGEBOX As String = "_IMSS_MESSAGEBOX")
        For Each session As ITerminalServicesSession In New TerminalServicesManager().GetSessions()
            If Not String.IsNullOrEmpty(session.SessionId.ToString()) Then
                If Not String.IsNullOrEmpty(_IMSS_USERS_LISTVIEW.SelectedItems(0).SubItems(1).Text) Then
                    If session.SessionId.ToString() = _IMSS_USERS_LISTVIEW.SelectedItems(0).SubItems(1).Text Then
                        Select Case _IMSS_COMMAND
                            Case 0
                                session.Disconnect() : Exit Select
                            Case 1
                                session.Logoff() : Exit Select
                            Case 2
                                session.MessageBox(_IMSS_MESSAGEBOX) : Exit Select
                            Case Else
                                Exit Select
                        End Select
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub _IMSS_USERS_LISTVIEW_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_USERS_LISTVIEW.SelectedIndexChanged
        If Not _IMSS_USERS_LISTVIEW.SelectedItems.Count = 0 Then
            If Not String.IsNullOrEmpty(_IMSS_USERS_LISTVIEW.SelectedItems(0).SubItems(2).Text) = True Then
                If _IMSS_USERS_LISTVIEW.SelectedItems(0).SubItems(2).Text = "Active" Then
                    _IMSS_Disconnect_Button.Enabled = True
                    _IMSS_Logoff.Enabled = True
                    _IMSS_Send_MessageBox_Button.Enabled = False
                Else
                    _IMSS_Disconnect_Button.Enabled = False
                    _IMSS_Logoff.Enabled = False
                    _IMSS_Send_MessageBox_Button.Enabled = True
                End If
            End If
        Else
            _IMSS_Disconnect_Button.Enabled = False
            _IMSS_Logoff.Enabled = False
            _IMSS_Send_MessageBox_Button.Enabled = False
        End If
    End Sub
    Private Sub _IMSS_Disconnect_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Disconnect_Button.Click
        Try
            _IMSS_SendCommand_Session(0)
        Catch ex As Exception
            MessageBox.Show("ERROR : " & ex.Message.ToString(), Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub _IMSS_Logoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Logoff.Click
        Try
            _IMSS_SendCommand_Session(1)
        Catch ex As Exception
            MessageBox.Show("ERROR : " & ex.Message.ToString(), Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub _IMSS_Send_MessageBox_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Send_MessageBox_Button.Click
        Try
            Dim _IMSS_MESSAGE As String = InputBox("What the message do you want to send?", "Enter the messagee", "Your Massage here ...")
            If Not String.IsNullOrEmpty(_IMSS_MESSAGE) Then
                _IMSS_SendCommand_Session(2, _IMSS_MESSAGE)
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR : " & ex.Message.ToString(), Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub _IMSS_User_NewTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_User_NewTask.Click
        Button1_Click(Nothing, Nothing)
    End Sub
    Private Sub _IMSS_END_PROCESS(ByRef _IMSS_TARGET_LISTVEW As BetterListView)
        Try
            For Each p As Process In Process.GetProcessesByName(_IMSS_TARGET_LISTVEW.SelectedItems(0).Text.Replace(".exe", "")) : p.Kill() : Next
        Catch ex As Exception
            Shell("Taskkill /F /IM " & _IMSS_TARGET_LISTVEW.SelectedItems(0).Text, AppWinStyle.Hide, True)
        Finally
            _IMSS_PROCESSES_CONTROLER_SelectedIndexChanged(Nothing, Nothing)
        End Try
    End Sub
    Private Sub _IMSS_SCAN_ONLINE_PROCESS(ByRef _IMSS_TARGET_LISTVEW As BetterListView)
        Try
            For Each p As Process In Process.GetProcessesByName(_IMSS_TARGET_LISTVEW.SelectedItems(0).Text.Replace(".exe", ""))
                Dim _IMSS_SCAN_OPTIONS As New IMSS_SCAN_OPTIONS(p.Modules(0).FileName)
                _IMSS_SCAN_OPTIONS.Show()
                Exit For
            Next
        Catch
        Finally
            _IMSS_PROCESSES_CONTROLER_SelectedIndexChanged(Nothing, Nothing)
        End Try
    End Sub
    Private Sub _IMSS_User_EndProcess_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_User_EndProcess_Button.Click
        _IMSS_END_PROCESS(_IMSS_PROCESSES_LISTVIEW)
    End Sub

    Private Sub _IMSS_User_ScanOnline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_User_ScanOnline.Click
        _IMSS_SCAN_ONLINE_PROCESS(_IMSS_PROCESSES_LISTVIEW)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button1_Click(Nothing, Nothing)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button1_Click(Nothing, Nothing)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Button1_Click(Nothing, Nothing)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        _IMSS_SCAN_ONLINE_PROCESS(_IMSS_PROCESSES_SYSTEM_LIST)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        _IMSS_SCAN_ONLINE_PROCESS(_IMSS_PROCESSES_NETWORK_LISTVIEW)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        _IMSS_SCAN_ONLINE_PROCESS(_IMSS_LOCAL_SERVICES_LISTVIEW)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        _IMSS_END_PROCESS(_IMSS_PROCESSES_SYSTEM_LIST)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        _IMSS_END_PROCESS(_IMSS_PROCESSES_NETWORK_LISTVIEW)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        _IMSS_END_PROCESS(_IMSS_LOCAL_SERVICES_LISTVIEW)
    End Sub

    Private Sub _IMSS_GoToProcess_Context_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_GoToProcess_Context.Click
        For Each _IMSS_ITEM As BetterListViewItem In _IMSS_PROCESSES_LISTVIEW.Items
            If _IMSS_ITEM.Text.Contains(_IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().Substring(0, _IMSS_APLICATION_LISTVIEW.SelectedItems(0).Tag.ToString().IndexOf("|"))) Then
                SuperTabControl1.SelectedTab = _IMSS_PROCESSES_Tap
                _IMSS_ITEM.Selected = True
                _IMSS_ITEM.Focused = True
                _IMSS_ITEM.BackColor = Color.LightSkyBlue
                _IMSS_ITEM.EnsureVisible()
                Exit For
            Else
                _IMSS_ITEM.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub _IMSS_OPEN_FILE_LOCATION_PROCESS(ByRef _IMSS_TARGET_LISTVEW As BetterListView)
        Try
            For Each p As Process In Process.GetProcessesByName(_IMSS_TARGET_LISTVEW.SelectedItems(0).Text.Replace(".exe", ""))
                Try : Process.Start(IO.Path.GetDirectoryName(p.Modules(0).FileName)) : Catch : End Try
                Exit For
            Next
        Catch
        End Try
    End Sub
    Private Sub _IMSS_Online_Search_PROCESS(ByVal _IMSS_TARGET_STATUS As Integer, ByRef _IMSS_TARGET_LISTVEW As BetterListView)
        If _IMSS_TARGET_STATUS = 0 Then
            Try : Process.Start("https://www.google.co.uk/#q=" & _IMSS_TARGET_LISTVEW.SelectedItems(0).Text.Replace(".exe", "")) : Catch : End Try
        Else
            Try : Process.Start("https://www.google.co.uk/#q=" & _IMSS_TARGET_LISTVEW.SelectedItems(0).SubItems(5).Text) : Catch : End Try
        End If
    End Sub


    Private Sub NewProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProcessToolStripMenuItem.Click
        Button1_Click(Nothing, Nothing)
    End Sub
    Private _IMSS_SuspendedList As New Dictionary(Of String, BetterListViewItem)
    Private Sub _IMSS_SuspenedProcesses(ByRef _IMSS_TARGET_LIST_VIEW As BetterListView)
        For Each i As BetterListViewItem In _IMSS_TARGET_LIST_VIEW.SelectedItems
            If Not _IMSS_SuspendedList.ContainsKey(i.SubItems(3).Text) Then
                For Each thrd As ProcessThread In Process.GetProcessById(i.SubItems(3).Text).Threads
                    SuspendThread(OpenThread(ThreadAccess.SUSPEND_RESUME, False, thrd.Id))
                Next
                _IMSS_SuspendedList.Add(i.SubItems(3).Text, i)
                i.BackColor = Color.Red
            Else
                For Each thrd As ProcessThread In Process.GetProcessById(i.SubItems(3).Text).Threads
                    ResumeThread(OpenThread(ThreadAccess.SUSPEND_RESUME, False, thrd.Id))
                Next
                _IMSS_SuspendedList.Remove(i.SubItems(3).Text)
                i.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub _IMSS_SetPriority(ByRef _IMSS_TARGET_LIST_VIEW As BetterListView, ByVal plvl As ThreadPriorityLevel)
        For Each i As BetterListViewItem In _IMSS_TARGET_LIST_VIEW.SelectedItems
            Try
                Process.GetProcessById(i.SubItems(3).Text).Threads(0).PriorityLevel = plvl
            Catch ex As Exception
                MessageBox.Show("Error while trying to change priority level" & vbNewLine & """" & ex.Message & """", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
        _IMSS_PROCESSES_CONTROLER_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_EmptySelectedworkingSet(ByRef _IMSS_TARGET_LIST_VIEW As BetterListView)
        Try
            For Each i As BetterListViewItem In _IMSS_TARGET_LIST_VIEW.SelectedItems
                EmptyWorkingSet(i.SubItems(3).Text)
            Next
        Catch ex As Exception : End Try
    End Sub

    Private Sub EverythingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EverythingToolStripMenuItem.Click
        For Each p As Process In Process.GetProcesses
            Try
                EmptyWorkingSet(p.Handle)
            Catch ex As Exception : End Try
        Next
    End Sub

    Private Sub _IMSS_Properties(ByRef _IMSS_TARGET_LIST_VIEW As BetterListView)
        On Error GoTo _IMSS_ON_ERROR
        Dim sei As New SHELLEXECUTEINFO
        sei.cbSize = Marshal.SizeOf(sei)
        sei.lpVerb = "properties"
        For Each p As Process In Process.GetProcessesByName(_IMSS_TARGET_LIST_VIEW.SelectedItems(0).Text.Replace(".exe", ""))
            sei.lpFile = p.Modules(0).FileName
            Exit For
        Next
        sei.nShow = SW_SHOW
        sei.fMask = SEE_MASK_INVOKEIDLIST
        If Not ShellExecuteEx(sei) Then
            Dim ex As New System.ComponentModel.Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error())
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
_IMSS_ON_ERROR:
        ' MessageBox.Show("Pleas select item to show it's propertis !", Application.ProductName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub ScanProcessFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanProcessFileToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SCAN_ONLINE_PROCESS(_IMSS_PROCESSES_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SCAN_ONLINE_PROCESS(_IMSS_PROCESSES_SYSTEM_LIST)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SCAN_ONLINE_PROCESS(_IMSS_PROCESSES_NETWORK_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SCAN_ONLINE_PROCESS(_IMSS_LOCAL_SERVICES_LISTVIEW)
        End If
    End Sub

    Private Sub OpenFileLocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileLocationToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_OPEN_FILE_LOCATION_PROCESS(_IMSS_PROCESSES_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_OPEN_FILE_LOCATION_PROCESS(_IMSS_PROCESSES_SYSTEM_LIST)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_OPEN_FILE_LOCATION_PROCESS(_IMSS_PROCESSES_NETWORK_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_OPEN_FILE_LOCATION_PROCESS(_IMSS_LOCAL_SERVICES_LISTVIEW)
        End If
    End Sub

    Private Sub ViaNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViaNameToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_Online_Search_PROCESS(0, _IMSS_PROCESSES_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_Online_Search_PROCESS(0, _IMSS_PROCESSES_SYSTEM_LIST)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_Online_Search_PROCESS(0, _IMSS_PROCESSES_NETWORK_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_Online_Search_PROCESS(0, _IMSS_LOCAL_SERVICES_LISTVIEW)
        End If
    End Sub

    Private Sub ViaDescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViaDescriptionToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_Online_Search_PROCESS(1, _IMSS_PROCESSES_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_Online_Search_PROCESS(1, _IMSS_PROCESSES_SYSTEM_LIST)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_Online_Search_PROCESS(1, _IMSS_PROCESSES_NETWORK_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_Online_Search_PROCESS(1, _IMSS_LOCAL_SERVICES_LISTVIEW)
        End If
    End Sub
    Private Sub EndProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndProcessToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_END_PROCESS(_IMSS_PROCESSES_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_END_PROCESS(_IMSS_PROCESSES_SYSTEM_LIST)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_END_PROCESS(_IMSS_PROCESSES_NETWORK_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_END_PROCESS(_IMSS_LOCAL_SERVICES_LISTVIEW)
        End If
    End Sub

    Private Sub SuspendResumeProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspendResumeProcessToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SuspenedProcesses(_IMSS_PROCESSES_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SuspenedProcesses(_IMSS_PROCESSES_SYSTEM_LIST)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SuspenedProcesses(_IMSS_PROCESSES_NETWORK_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SuspenedProcesses(_IMSS_LOCAL_SERVICES_LISTVIEW)
        End If
    End Sub

    Private Sub TimeCriticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeCriticalToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_LISTVIEW, ThreadPriorityLevel.TimeCritical)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_SYSTEM_LIST, ThreadPriorityLevel.TimeCritical)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_NETWORK_LISTVIEW, ThreadPriorityLevel.TimeCritical)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SetPriority(_IMSS_LOCAL_SERVICES_LISTVIEW, ThreadPriorityLevel.TimeCritical)
        End If
    End Sub

    Private Sub HighestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighestToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_LISTVIEW, ThreadPriorityLevel.Highest)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_SYSTEM_LIST, ThreadPriorityLevel.Highest)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_NETWORK_LISTVIEW, ThreadPriorityLevel.Highest)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SetPriority(_IMSS_LOCAL_SERVICES_LISTVIEW, ThreadPriorityLevel.Highest)
        End If
    End Sub

    Private Sub AboveNormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboveNormalToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_LISTVIEW, ThreadPriorityLevel.AboveNormal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_SYSTEM_LIST, ThreadPriorityLevel.AboveNormal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_NETWORK_LISTVIEW, ThreadPriorityLevel.AboveNormal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SetPriority(_IMSS_LOCAL_SERVICES_LISTVIEW, ThreadPriorityLevel.AboveNormal)
        End If
    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_LISTVIEW, ThreadPriorityLevel.Normal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_SYSTEM_LIST, ThreadPriorityLevel.Normal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_NETWORK_LISTVIEW, ThreadPriorityLevel.Normal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SetPriority(_IMSS_LOCAL_SERVICES_LISTVIEW, ThreadPriorityLevel.Normal)
        End If
    End Sub

    Private Sub BelowNormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BelowNormalToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_LISTVIEW, ThreadPriorityLevel.BelowNormal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_SYSTEM_LIST, ThreadPriorityLevel.BelowNormal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_NETWORK_LISTVIEW, ThreadPriorityLevel.BelowNormal)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SetPriority(_IMSS_LOCAL_SERVICES_LISTVIEW, ThreadPriorityLevel.BelowNormal)
        End If
    End Sub

    Private Sub LowestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowestToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_LISTVIEW, ThreadPriorityLevel.Lowest)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_SYSTEM_LIST, ThreadPriorityLevel.Lowest)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_NETWORK_LISTVIEW, ThreadPriorityLevel.Lowest)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SetPriority(_IMSS_LOCAL_SERVICES_LISTVIEW, ThreadPriorityLevel.Lowest)
        End If
    End Sub

    Private Sub IdleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdleToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_LISTVIEW, ThreadPriorityLevel.Idle)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_SYSTEM_LIST, ThreadPriorityLevel.Idle)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_SetPriority(_IMSS_PROCESSES_NETWORK_LISTVIEW, ThreadPriorityLevel.Idle)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_SetPriority(_IMSS_LOCAL_SERVICES_LISTVIEW, ThreadPriorityLevel.Idle)
        End If
    End Sub

    Private Sub SelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_EmptySelectedworkingSet(_IMSS_PROCESSES_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_EmptySelectedworkingSet(_IMSS_PROCESSES_SYSTEM_LIST)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_EmptySelectedworkingSet(_IMSS_PROCESSES_NETWORK_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_EmptySelectedworkingSet(_IMSS_LOCAL_SERVICES_LISTVIEW)
        End If
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        If _IMSS_PROCESSES_CONTROLER.SelectedIndex = 0 Then
            _IMSS_Properties(_IMSS_PROCESSES_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 1 Then
            _IMSS_Properties(_IMSS_PROCESSES_SYSTEM_LIST)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 2 Then
            _IMSS_Properties(_IMSS_PROCESSES_NETWORK_LISTVIEW)
        ElseIf _IMSS_PROCESSES_CONTROLER.SelectedIndex = 3 Then
            _IMSS_Properties(_IMSS_LOCAL_SERVICES_LISTVIEW)
        End If
    End Sub
#Region "IMSS SERVICE UINT VAR"
    Private msvc As ServiceController
    Private controllers As New System.Collections.Generic.SortedList(Of String, ServiceController)
    Private Sub _IMSS_Services_SuperTap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Services_SuperTap.Click
        _IMSS_SELECTED_INDEX = 10
        Dim _IMSS_START_ENUM_SERVICES As New Threading.Thread(AddressOf _IMSS_EnumServices)
        _IMSS_START_ENUM_SERVICES.Start()
    End Sub

    Private Sub _IMSS_EnumServices()
        If _IMSS_SERVICES_LISTVIEW.InvokeRequired = True Then
            Invoke(New MethodInvoker(Sub()
                                         _IMSS_EnumServices()
                                     End Sub))
        Else
            Try
                Me._IMSS_SERVICES_LISTVIEW.Items.Clear()
                If controllers IsNot Nothing Then
                    controllers = New Generic.SortedList(Of String, ServiceController)
                End If

                Dim services As ServiceController() = ServiceController.GetServices()
                For Each controller As ServiceController In services
                    Application.DoEvents()
                    With Me._IMSS_SERVICES_LISTVIEW.Items.Add(controller.DisplayName)
                        .Image = My.Resources._IMSS_SERVICES_Icon_16x16
                        If controller.Status = ServiceControllerStatus.Running Then .SubItems.Add(controller.Status.ToString()).Image = My.Resources._IMSS_SERVICE_RUN_Icon_16x16 Else .SubItems.Add(controller.Status.ToString()).Image = My.Resources._IMSS_SERVICE_STOP_Icon_16x16
                        .SubItems.Add(controller.ServiceType.ToString())
                    End With
                    controllers.Add(controller.DisplayName, controller)
                Next controller : With _IMSS_SERVICES_LISTVIEW.Items(0) : .Selected = True : .Focused = True : End With
            Catch exp As Exception : End Try
        End If
    End Sub

    Private Sub _IMSS_SERVICES_LISTVIEW_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SERVICES_LISTVIEW.SelectedIndexChanged
        _IMSS_UpdateUIForSelectedService()
    End Sub

    Private Sub _IMSS_UpdateUIForSelectedService()
        ' Update the command buttons for the selected service.
        Dim strName As String
        Try
            If Me._IMSS_SERVICES_LISTVIEW.SelectedItems.Count = 1 Then
                strName = Me._IMSS_SERVICES_LISTVIEW.SelectedItems(0).SubItems(0).Text
                msvc = controllers.Item(strName)
                With msvc
                    ' If it's stopped, we should be able to start it
                    Me.cmdStart.Enabled = (.Status = ServiceControllerStatus.Stopped)
                    ' Check if we're allowed to try and stop it and make sure it's not
                    ' already stopped.
                    Me.cmdStop.Enabled = (.CanStop AndAlso (Not .Status = ServiceControllerStatus.Stopped))
                    ' Check if we're allowed to pause it and see if it is not paused
                    ' already.
                    Me.cmdPause.Enabled = (.CanPauseAndContinue AndAlso (Not .Status = ServiceControllerStatus.Paused))
                    ' If it's paused, we must be able to resume it.
                    Me.cmdResume.Enabled = (.Status = ServiceControllerStatus.Paused)
                End With
            End If
        Catch exp As Exception
            MsgBox("Cannot update UI.", MsgBoxStyle.OkOnly, Me.Text)
        End Try
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        Try
            msvc.Start()
            _IMSS_UpdateUIForSelectedService()
        Catch exp As Exception
            MsgBox("Cannot start service.", MsgBoxStyle.OkOnly, Application.ProductName.ToString())
        End Try
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        Try
            msvc.Stop()
            _IMSS_UpdateUIForSelectedService()
        Catch exp As Exception
            MsgBox("Cannot start service.", MsgBoxStyle.OkOnly, Application.ProductName.ToString())
        End Try
    End Sub

    Private Sub cmdPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPause.Click
        Try
            msvc.Pause()
            _IMSS_UpdateUIForSelectedService()
        Catch exp As Exception
            MsgBox("Cannot start service.", MsgBoxStyle.OkOnly, Application.ProductName.ToString())
        End Try
    End Sub

    Private Sub cmdResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResume.Click
        Try
            msvc.Continue()
            _IMSS_UpdateUIForSelectedService()
        Catch exp As Exception
            MsgBox("Cannot start service.", MsgBoxStyle.OkOnly, Application.ProductName.ToString())
        End Try
    End Sub
#End Region

End Class
