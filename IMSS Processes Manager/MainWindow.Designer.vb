<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_Main_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_StatusStrip = New System.Windows.Forms.StatusStrip()
        Me._IMSS_TOTALE_PROCESS_STATUSBAR = New System.Windows.Forms.ToolStripStatusLabel()
        Me._IMSS_CPU_USAGE_Label = New System.Windows.Forms.ToolStripStatusLabel()
        Me._IMSS_PhysicalMemory_Label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_PROCESSES_CONTROLER = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me._IMSS_PROCESSES_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me.BetterListViewColumnHeader1_1_ = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader5_5_ = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader2_2_ = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader7_7_ = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader6_6_ = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader8_8_ = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_PROCESSES_ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ScanProcessFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchProcessOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViaNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViaDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EndProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendResumeProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangePriorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeCriticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboveNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BelowNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LowestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemoryDumpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EverythingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_User_ScanOnline = New System.Windows.Forms.Button()
        Me._IMSS_User_EndProcess_Button = New System.Windows.Forms.Button()
        Me._IMSS_User_NewTask = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me._IMSS_PROCESSES_SYSTEM_LIST = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS__ImageName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Priority = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_UserName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_PID = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_MemoryWorkingSet = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Description = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_NetWork_ImageName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_NetWork_Priority = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_NetWork_UserName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_NetWork_PID = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_NetWork_MemoryWorkingSet = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_NetWork_Description = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me._IMSS_LOCAL_SERVICES_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_LOCALSERVICE_ImageName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LOCALSERVICE_Priority = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LOCALSERVICE_UserName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LOCALSERVICE_PID = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LOCALSERVICE_MemoryWorkingSet = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LOCALSERVICE_Description = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me._IMSS_IMAGES = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_PROCESSES_Tap = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_APLICATION_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me.BetterListViewColumnHeader1 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me.BetterListViewColumnHeader2 = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_APPLICAT_ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me._IMSS_SwitchTo_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_BringToFront_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_Separator1_Context = New System.Windows.Forms.ToolStripSeparator()
        Me._IMSS_Minimize_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_Maximize_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_Separator2_Context = New System.Windows.Forms.ToolStripSeparator()
        Me._IMSS_EndTask_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_GoToProcess_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_Separator3_Context = New System.Windows.Forms.ToolStripSeparator()
        Me._IMSS_OpenFileLocation_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_ScanOnline_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_NewTaskRun_Context = New System.Windows.Forms.ToolStripMenuItem()
        Me._IMSS_END_TASK_Button = New System.Windows.Forms.Button()
        Me._IMSS_SwitchTo_Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._IMSS_Application_Tap = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me._IMSS_SERVICES_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_Name = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Status = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ServiceType = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Services_SuperTap = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_Send_MessageBox_Button = New System.Windows.Forms.Button()
        Me._IMSS_Logoff = New System.Windows.Forms.Button()
        Me._IMSS_Disconnect_Button = New System.Windows.Forms.Button()
        Me._IMSS_USERS_LISTVIEW = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_User = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ID = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Users_Status = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Session = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_UserAccount = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_DomainName = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_ConnectTime = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_LoginTime = New ComponentOwl.BetterListView.BetterListViewColumnHeader()
        Me._IMSS_Performance_SuperTap = New DevComponents.DotNetBar.SuperTabItem()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me._IMSS_APPLICATION_REFRESH_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me._IMSS_GET_CPU_USAGE_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me._IMSS_Main_Panel.SuspendLayout()
        Me._IMSS_StatusStrip.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me._IMSS_PROCESSES_CONTROLER.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me._IMSS_PROCESSES_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_PROCESSES_ContextMenu.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me._IMSS_PROCESSES_SYSTEM_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me._IMSS_PROCESSES_NETWORK_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me._IMSS_LOCAL_SERVICES_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me._IMSS_APLICATION_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_APPLICAT_ContextMenu.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me._IMSS_SERVICES_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel4.SuspendLayout()
        CType(Me._IMSS_USERS_LISTVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_Main_Panel
        '
        Me._IMSS_Main_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_Main_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Main_Panel.Controls.Add(Me._IMSS_StatusStrip)
        Me._IMSS_Main_Panel.Controls.Add(Me.SuperTabControl1)
        Me._IMSS_Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_Main_Panel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_Main_Panel.Name = "_IMSS_Main_Panel"
        Me._IMSS_Main_Panel.Size = New System.Drawing.Size(394, 422)
        Me._IMSS_Main_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_Main_Panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_Main_Panel.Style.BackColor2.Color = System.Drawing.Color.White
        Me._IMSS_Main_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_Main_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_Main_Panel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_Main_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_Main_Panel.Style.GradientAngle = 90
        Me._IMSS_Main_Panel.TabIndex = 0
        '
        '_IMSS_StatusStrip
        '
        Me._IMSS_StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._IMSS_TOTALE_PROCESS_STATUSBAR, Me._IMSS_CPU_USAGE_Label, Me._IMSS_PhysicalMemory_Label})
        Me._IMSS_StatusStrip.Location = New System.Drawing.Point(0, 398)
        Me._IMSS_StatusStrip.Name = "_IMSS_StatusStrip"
        Me._IMSS_StatusStrip.Size = New System.Drawing.Size(394, 24)
        Me._IMSS_StatusStrip.TabIndex = 1
        Me._IMSS_StatusStrip.Text = "StatusStrip1"
        '
        '_IMSS_TOTALE_PROCESS_STATUSBAR
        '
        Me._IMSS_TOTALE_PROCESS_STATUSBAR.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me._IMSS_TOTALE_PROCESS_STATUSBAR.Name = "_IMSS_TOTALE_PROCESS_STATUSBAR"
        Me._IMSS_TOTALE_PROCESS_STATUSBAR.Size = New System.Drawing.Size(62, 19)
        Me._IMSS_TOTALE_PROCESS_STATUSBAR.Text = "Processes"
        '
        '_IMSS_CPU_USAGE_Label
        '
        Me._IMSS_CPU_USAGE_Label.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me._IMSS_CPU_USAGE_Label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._IMSS_CPU_USAGE_Label.Name = "_IMSS_CPU_USAGE_Label"
        Me._IMSS_CPU_USAGE_Label.Size = New System.Drawing.Size(105, 19)
        Me._IMSS_CPU_USAGE_Label.Text = "            CPU Usge :"
        '
        '_IMSS_PhysicalMemory_Label
        '
        Me._IMSS_PhysicalMemory_Label.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me._IMSS_PhysicalMemory_Label.Name = "_IMSS_PhysicalMemory_Label"
        Me._IMSS_PhysicalMemory_Label.Size = New System.Drawing.Size(102, 19)
        Me._IMSS_PhysicalMemory_Label.Text = "Physical Memory"
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(394, 422)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_Application_Tap, Me._IMSS_PROCESSES_Tap, Me._IMSS_Services_SuperTap, Me._IMSS_Performance_SuperTap})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me._IMSS_PROCESSES_CONTROLER)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(394, 397)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me._IMSS_PROCESSES_Tap
        '
        '_IMSS_PROCESSES_CONTROLER
        '
        Me._IMSS_PROCESSES_CONTROLER.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_PROCESSES_CONTROLER.Controls.Add(Me.TabPage1)
        Me._IMSS_PROCESSES_CONTROLER.Controls.Add(Me.TabPage2)
        Me._IMSS_PROCESSES_CONTROLER.Controls.Add(Me.TabPage3)
        Me._IMSS_PROCESSES_CONTROLER.Controls.Add(Me.TabPage4)
        Me._IMSS_PROCESSES_CONTROLER.ImageList = Me._IMSS_IMAGES
        Me._IMSS_PROCESSES_CONTROLER.Location = New System.Drawing.Point(5, 3)
        Me._IMSS_PROCESSES_CONTROLER.Name = "_IMSS_PROCESSES_CONTROLER"
        Me._IMSS_PROCESSES_CONTROLER.SelectedIndex = 0
        Me._IMSS_PROCESSES_CONTROLER.Size = New System.Drawing.Size(386, 367)
        Me._IMSS_PROCESSES_CONTROLER.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me._IMSS_PROCESSES_LISTVIEW)
        Me.TabPage1.Controls.Add(Me._IMSS_User_ScanOnline)
        Me.TabPage1.Controls.Add(Me._IMSS_User_EndProcess_Button)
        Me.TabPage1.Controls.Add(Me._IMSS_User_NewTask)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(378, 340)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '_IMSS_PROCESSES_LISTVIEW
        '
        Me._IMSS_PROCESSES_LISTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_PROCESSES_LISTVIEW.Columns.AddRange(New Object() {Me.BetterListViewColumnHeader1_1_, Me.BetterListViewColumnHeader5_5_, Me.BetterListViewColumnHeader2_2_, Me.BetterListViewColumnHeader7_7_, Me.BetterListViewColumnHeader6_6_, Me.BetterListViewColumnHeader8_8_})
        Me._IMSS_PROCESSES_LISTVIEW.ContextMenuStrip = Me._IMSS_PROCESSES_ContextMenu
        Me._IMSS_PROCESSES_LISTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_PROCESSES_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_PROCESSES_LISTVIEW.Location = New System.Drawing.Point(3, 3)
        Me._IMSS_PROCESSES_LISTVIEW.MultiSelect = False
        Me._IMSS_PROCESSES_LISTVIEW.Name = "_IMSS_PROCESSES_LISTVIEW"
        Me._IMSS_PROCESSES_LISTVIEW.Size = New System.Drawing.Size(367, 230)
        Me._IMSS_PROCESSES_LISTVIEW.TabIndex = 4
        '
        'BetterListViewColumnHeader1_1_
        '
        Me.BetterListViewColumnHeader1_1_.Name = "BetterListViewColumnHeader1_1_"
        Me.BetterListViewColumnHeader1_1_.Text = "Image Name"
        Me.BetterListViewColumnHeader1_1_.Width = 101
        '
        'BetterListViewColumnHeader5_5_
        '
        Me.BetterListViewColumnHeader5_5_.Name = "BetterListViewColumnHeader5_5_"
        Me.BetterListViewColumnHeader5_5_.Text = "Priority"
        Me.BetterListViewColumnHeader5_5_.Width = 61
        '
        'BetterListViewColumnHeader2_2_
        '
        Me.BetterListViewColumnHeader2_2_.Name = "BetterListViewColumnHeader2_2_"
        Me.BetterListViewColumnHeader2_2_.Text = "User Name"
        Me.BetterListViewColumnHeader2_2_.Width = 81
        '
        'BetterListViewColumnHeader7_7_
        '
        Me.BetterListViewColumnHeader7_7_.Name = "BetterListViewColumnHeader7_7_"
        Me.BetterListViewColumnHeader7_7_.Text = "PID"
        Me.BetterListViewColumnHeader7_7_.Width = 44
        '
        'BetterListViewColumnHeader6_6_
        '
        Me.BetterListViewColumnHeader6_6_.Name = "BetterListViewColumnHeader6_6_"
        Me.BetterListViewColumnHeader6_6_.Text = "Memory(Private Working Set)"
        Me.BetterListViewColumnHeader6_6_.Width = 45
        '
        'BetterListViewColumnHeader8_8_
        '
        Me.BetterListViewColumnHeader8_8_.Name = "BetterListViewColumnHeader8_8_"
        Me.BetterListViewColumnHeader8_8_.Text = "Description"
        '
        '_IMSS_PROCESSES_ContextMenu
        '
        Me._IMSS_PROCESSES_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanProcessFileToolStripMenuItem, Me.OpenFileLocationToolStripMenuItem, Me.SearchProcessOnlineToolStripMenuItem, Me.ToolStripSeparator1, Me.EndProcessToolStripMenuItem, Me.NewProcessToolStripMenuItem, Me.SuspendResumeProcessToolStripMenuItem, Me.ToolStripSeparator2, Me.ChangePriorityToolStripMenuItem, Me.MemoryDumpToolStripMenuItem, Me.ToolStripSeparator3, Me.PropertiesToolStripMenuItem})
        Me._IMSS_PROCESSES_ContextMenu.Name = "_IMSS_PROCESSES_ContextMenu"
        Me._IMSS_PROCESSES_ContextMenu.Size = New System.Drawing.Size(214, 220)
        '
        'ScanProcessFileToolStripMenuItem
        '
        Me.ScanProcessFileToolStripMenuItem.Name = "ScanProcessFileToolStripMenuItem"
        Me.ScanProcessFileToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ScanProcessFileToolStripMenuItem.Text = "Scan Process File"
        '
        'OpenFileLocationToolStripMenuItem
        '
        Me.OpenFileLocationToolStripMenuItem.Name = "OpenFileLocationToolStripMenuItem"
        Me.OpenFileLocationToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.OpenFileLocationToolStripMenuItem.Text = "Open File Location"
        '
        'SearchProcessOnlineToolStripMenuItem
        '
        Me.SearchProcessOnlineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViaNameToolStripMenuItem, Me.ViaDescriptionToolStripMenuItem})
        Me.SearchProcessOnlineToolStripMenuItem.Name = "SearchProcessOnlineToolStripMenuItem"
        Me.SearchProcessOnlineToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SearchProcessOnlineToolStripMenuItem.Text = "Online Search"
        '
        'ViaNameToolStripMenuItem
        '
        Me.ViaNameToolStripMenuItem.Name = "ViaNameToolStripMenuItem"
        Me.ViaNameToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ViaNameToolStripMenuItem.Text = "Via Name"
        '
        'ViaDescriptionToolStripMenuItem
        '
        Me.ViaDescriptionToolStripMenuItem.Name = "ViaDescriptionToolStripMenuItem"
        Me.ViaDescriptionToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ViaDescriptionToolStripMenuItem.Text = "Via Description"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'EndProcessToolStripMenuItem
        '
        Me.EndProcessToolStripMenuItem.Name = "EndProcessToolStripMenuItem"
        Me.EndProcessToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.EndProcessToolStripMenuItem.Text = "End Process"
        '
        'NewProcessToolStripMenuItem
        '
        Me.NewProcessToolStripMenuItem.Name = "NewProcessToolStripMenuItem"
        Me.NewProcessToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.NewProcessToolStripMenuItem.Text = "New Process"
        '
        'SuspendResumeProcessToolStripMenuItem
        '
        Me.SuspendResumeProcessToolStripMenuItem.Name = "SuspendResumeProcessToolStripMenuItem"
        Me.SuspendResumeProcessToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SuspendResumeProcessToolStripMenuItem.Text = "Suspend | Resume process"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'ChangePriorityToolStripMenuItem
        '
        Me.ChangePriorityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeCriticalToolStripMenuItem, Me.HighestToolStripMenuItem, Me.AboveNormalToolStripMenuItem, Me.NormalToolStripMenuItem, Me.BelowNormalToolStripMenuItem, Me.LowestToolStripMenuItem, Me.IdleToolStripMenuItem})
        Me.ChangePriorityToolStripMenuItem.Name = "ChangePriorityToolStripMenuItem"
        Me.ChangePriorityToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ChangePriorityToolStripMenuItem.Text = "Change Priority"
        '
        'TimeCriticalToolStripMenuItem
        '
        Me.TimeCriticalToolStripMenuItem.Name = "TimeCriticalToolStripMenuItem"
        Me.TimeCriticalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TimeCriticalToolStripMenuItem.Text = "Time Critical"
        '
        'HighestToolStripMenuItem
        '
        Me.HighestToolStripMenuItem.Name = "HighestToolStripMenuItem"
        Me.HighestToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HighestToolStripMenuItem.Text = "Highest"
        '
        'AboveNormalToolStripMenuItem
        '
        Me.AboveNormalToolStripMenuItem.Name = "AboveNormalToolStripMenuItem"
        Me.AboveNormalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboveNormalToolStripMenuItem.Text = "Above Normal"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'BelowNormalToolStripMenuItem
        '
        Me.BelowNormalToolStripMenuItem.Name = "BelowNormalToolStripMenuItem"
        Me.BelowNormalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BelowNormalToolStripMenuItem.Text = "Below Normal"
        '
        'LowestToolStripMenuItem
        '
        Me.LowestToolStripMenuItem.Name = "LowestToolStripMenuItem"
        Me.LowestToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LowestToolStripMenuItem.Text = "Lowest"
        '
        'IdleToolStripMenuItem
        '
        Me.IdleToolStripMenuItem.Name = "IdleToolStripMenuItem"
        Me.IdleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IdleToolStripMenuItem.Text = "Idle"
        '
        'MemoryDumpToolStripMenuItem
        '
        Me.MemoryDumpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectedToolStripMenuItem, Me.EverythingToolStripMenuItem})
        Me.MemoryDumpToolStripMenuItem.Name = "MemoryDumpToolStripMenuItem"
        Me.MemoryDumpToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MemoryDumpToolStripMenuItem.Text = "Memory Dump"
        '
        'SelectedToolStripMenuItem
        '
        Me.SelectedToolStripMenuItem.Name = "SelectedToolStripMenuItem"
        Me.SelectedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectedToolStripMenuItem.Text = "Selected"
        '
        'EverythingToolStripMenuItem
        '
        Me.EverythingToolStripMenuItem.Name = "EverythingToolStripMenuItem"
        Me.EverythingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EverythingToolStripMenuItem.Text = "Everything"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(210, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        '_IMSS_User_ScanOnline
        '
        Me._IMSS_User_ScanOnline.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_User_ScanOnline.Location = New System.Drawing.Point(135, 239)
        Me._IMSS_User_ScanOnline.Name = "_IMSS_User_ScanOnline"
        Me._IMSS_User_ScanOnline.Size = New System.Drawing.Size(78, 23)
        Me._IMSS_User_ScanOnline.TabIndex = 7
        Me._IMSS_User_ScanOnline.Text = "Scan Process"
        Me._IMSS_User_ScanOnline.UseVisualStyleBackColor = True
        '
        '_IMSS_User_EndProcess_Button
        '
        Me._IMSS_User_EndProcess_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_User_EndProcess_Button.Location = New System.Drawing.Point(219, 239)
        Me._IMSS_User_EndProcess_Button.Name = "_IMSS_User_EndProcess_Button"
        Me._IMSS_User_EndProcess_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_User_EndProcess_Button.TabIndex = 6
        Me._IMSS_User_EndProcess_Button.Text = "End Process"
        Me._IMSS_User_EndProcess_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_User_NewTask
        '
        Me._IMSS_User_NewTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_User_NewTask.Location = New System.Drawing.Point(300, 239)
        Me._IMSS_User_NewTask.Name = "_IMSS_User_NewTask"
        Me._IMSS_User_NewTask.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_User_NewTask.TabIndex = 5
        Me._IMSS_User_NewTask.Text = "New Task"
        Me._IMSS_User_NewTask.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me._IMSS_PROCESSES_SYSTEM_LIST)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(378, 365)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SYSTEM"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        '_IMSS_PROCESSES_SYSTEM_LIST
        '
        Me._IMSS_PROCESSES_SYSTEM_LIST.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_PROCESSES_SYSTEM_LIST.Columns.AddRange(New Object() {Me._IMSS__ImageName, Me._IMSS_Priority, Me._IMSS_UserName, Me._IMSS_PID, Me._IMSS_MemoryWorkingSet, Me._IMSS_Description})
        Me._IMSS_PROCESSES_SYSTEM_LIST.ContextMenuStrip = Me._IMSS_PROCESSES_ContextMenu
        Me._IMSS_PROCESSES_SYSTEM_LIST.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_PROCESSES_SYSTEM_LIST.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_PROCESSES_SYSTEM_LIST.Location = New System.Drawing.Point(3, 3)
        Me._IMSS_PROCESSES_SYSTEM_LIST.MultiSelect = False
        Me._IMSS_PROCESSES_SYSTEM_LIST.Name = "_IMSS_PROCESSES_SYSTEM_LIST"
        Me._IMSS_PROCESSES_SYSTEM_LIST.Size = New System.Drawing.Size(367, 280)
        Me._IMSS_PROCESSES_SYSTEM_LIST.TabIndex = 8
        '
        '_IMSS__ImageName
        '
        Me._IMSS__ImageName.Name = "_IMSS__ImageName"
        Me._IMSS__ImageName.Text = "Image Name"
        Me._IMSS__ImageName.Width = 101
        '
        '_IMSS_Priority
        '
        Me._IMSS_Priority.Name = "_IMSS_Priority"
        Me._IMSS_Priority.Text = "Priority"
        Me._IMSS_Priority.Width = 61
        '
        '_IMSS_UserName
        '
        Me._IMSS_UserName.Name = "_IMSS_UserName"
        Me._IMSS_UserName.Text = "User Name"
        Me._IMSS_UserName.Width = 81
        '
        '_IMSS_PID
        '
        Me._IMSS_PID.Name = "_IMSS_PID"
        Me._IMSS_PID.Text = "PID"
        Me._IMSS_PID.Width = 44
        '
        '_IMSS_MemoryWorkingSet
        '
        Me._IMSS_MemoryWorkingSet.Name = "_IMSS_MemoryWorkingSet"
        Me._IMSS_MemoryWorkingSet.Text = "Memory(Private Working Set)"
        Me._IMSS_MemoryWorkingSet.Width = 45
        '
        '_IMSS_Description
        '
        Me._IMSS_Description.Name = "_IMSS_Description"
        Me._IMSS_Description.Text = "Description"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(135, 289)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Scan Process"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(219, 289)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "End Process"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(300, 289)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "New Task"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me._IMSS_PROCESSES_NETWORK_LISTVIEW)
        Me.TabPage3.Controls.Add(Me.Button7)
        Me.TabPage3.Controls.Add(Me.Button8)
        Me.TabPage3.Controls.Add(Me.Button9)
        Me.TabPage3.ImageIndex = 2
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(378, 365)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "NETWORK"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        '_IMSS_PROCESSES_NETWORK_LISTVIEW
        '
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.Columns.AddRange(New Object() {Me._IMSS_NetWork_ImageName, Me._IMSS_NetWork_Priority, Me._IMSS_NetWork_UserName, Me._IMSS_NetWork_PID, Me._IMSS_NetWork_MemoryWorkingSet, Me._IMSS_NetWork_Description})
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.ContextMenuStrip = Me._IMSS_PROCESSES_ContextMenu
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.Location = New System.Drawing.Point(3, 3)
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.MultiSelect = False
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.Name = "_IMSS_PROCESSES_NETWORK_LISTVIEW"
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.Size = New System.Drawing.Size(367, 305)
        Me._IMSS_PROCESSES_NETWORK_LISTVIEW.TabIndex = 12
        '
        '_IMSS_NetWork_ImageName
        '
        Me._IMSS_NetWork_ImageName.Name = "_IMSS_NetWork_ImageName"
        Me._IMSS_NetWork_ImageName.Text = "Image Name"
        Me._IMSS_NetWork_ImageName.Width = 101
        '
        '_IMSS_NetWork_Priority
        '
        Me._IMSS_NetWork_Priority.Name = "_IMSS_NetWork_Priority"
        Me._IMSS_NetWork_Priority.Text = "Priority"
        Me._IMSS_NetWork_Priority.Width = 61
        '
        '_IMSS_NetWork_UserName
        '
        Me._IMSS_NetWork_UserName.Name = "_IMSS_NetWork_UserName"
        Me._IMSS_NetWork_UserName.Text = "User Name"
        Me._IMSS_NetWork_UserName.Width = 81
        '
        '_IMSS_NetWork_PID
        '
        Me._IMSS_NetWork_PID.Name = "_IMSS_NetWork_PID"
        Me._IMSS_NetWork_PID.Text = "PID"
        Me._IMSS_NetWork_PID.Width = 44
        '
        '_IMSS_NetWork_MemoryWorkingSet
        '
        Me._IMSS_NetWork_MemoryWorkingSet.Name = "_IMSS_NetWork_MemoryWorkingSet"
        Me._IMSS_NetWork_MemoryWorkingSet.Text = "Memory(Private Working Set)"
        Me._IMSS_NetWork_MemoryWorkingSet.Width = 45
        '
        '_IMSS_NetWork_Description
        '
        Me._IMSS_NetWork_Description.Name = "_IMSS_NetWork_Description"
        Me._IMSS_NetWork_Description.Text = "Description"
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Location = New System.Drawing.Point(135, 314)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(78, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Scan Process"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Location = New System.Drawing.Point(219, 314)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "End Process"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.Location = New System.Drawing.Point(300, 314)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "New Task"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me._IMSS_LOCAL_SERVICES_LISTVIEW)
        Me.TabPage4.Controls.Add(Me.Button10)
        Me.TabPage4.Controls.Add(Me.Button11)
        Me.TabPage4.Controls.Add(Me.Button12)
        Me.TabPage4.ImageIndex = 3
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(378, 365)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "LOCAL SERVICE"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        '_IMSS_LOCAL_SERVICES_LISTVIEW
        '
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.Columns.AddRange(New Object() {Me._IMSS_LOCALSERVICE_ImageName, Me._IMSS_LOCALSERVICE_Priority, Me._IMSS_LOCALSERVICE_UserName, Me._IMSS_LOCALSERVICE_PID, Me._IMSS_LOCALSERVICE_MemoryWorkingSet, Me._IMSS_LOCALSERVICE_Description})
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.ContextMenuStrip = Me._IMSS_PROCESSES_ContextMenu
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.Location = New System.Drawing.Point(3, 3)
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.MultiSelect = False
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.Name = "_IMSS_LOCAL_SERVICES_LISTVIEW"
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.Size = New System.Drawing.Size(367, 305)
        Me._IMSS_LOCAL_SERVICES_LISTVIEW.TabIndex = 16
        '
        '_IMSS_LOCALSERVICE_ImageName
        '
        Me._IMSS_LOCALSERVICE_ImageName.Name = "_IMSS_LOCALSERVICE_ImageName"
        Me._IMSS_LOCALSERVICE_ImageName.Text = "Image Name"
        Me._IMSS_LOCALSERVICE_ImageName.Width = 101
        '
        '_IMSS_LOCALSERVICE_Priority
        '
        Me._IMSS_LOCALSERVICE_Priority.Name = "_IMSS_LOCALSERVICE_Priority"
        Me._IMSS_LOCALSERVICE_Priority.Text = "Priority"
        Me._IMSS_LOCALSERVICE_Priority.Width = 61
        '
        '_IMSS_LOCALSERVICE_UserName
        '
        Me._IMSS_LOCALSERVICE_UserName.Name = "_IMSS_LOCALSERVICE_UserName"
        Me._IMSS_LOCALSERVICE_UserName.Text = "User Name"
        Me._IMSS_LOCALSERVICE_UserName.Width = 81
        '
        '_IMSS_LOCALSERVICE_PID
        '
        Me._IMSS_LOCALSERVICE_PID.Name = "_IMSS_LOCALSERVICE_PID"
        Me._IMSS_LOCALSERVICE_PID.Text = "PID"
        Me._IMSS_LOCALSERVICE_PID.Width = 44
        '
        '_IMSS_LOCALSERVICE_MemoryWorkingSet
        '
        Me._IMSS_LOCALSERVICE_MemoryWorkingSet.Name = "_IMSS_LOCALSERVICE_MemoryWorkingSet"
        Me._IMSS_LOCALSERVICE_MemoryWorkingSet.Text = "Memory(Private Working Set)"
        Me._IMSS_LOCALSERVICE_MemoryWorkingSet.Width = 45
        '
        '_IMSS_LOCALSERVICE_Description
        '
        Me._IMSS_LOCALSERVICE_Description.Name = "_IMSS_LOCALSERVICE_Description"
        Me._IMSS_LOCALSERVICE_Description.Text = "Description"
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.Location = New System.Drawing.Point(135, 314)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(78, 23)
        Me.Button10.TabIndex = 19
        Me.Button10.Text = "Scan Process"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.Location = New System.Drawing.Point(219, 314)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "End Process"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.Location = New System.Drawing.Point(300, 314)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 23)
        Me.Button12.TabIndex = 17
        Me.Button12.Text = "New Task"
        Me.Button12.UseVisualStyleBackColor = True
        '
        '_IMSS_IMAGES
        '
        Me._IMSS_IMAGES.ImageStream = CType(resources.GetObject("_IMSS_IMAGES.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_IMAGES.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_IMAGES.Images.SetKeyName(0, "_IMSS_User_Icon_16x16.png")
        Me._IMSS_IMAGES.Images.SetKeyName(1, "_IMSS_SystemProcesses_Icon_16x16.png")
        Me._IMSS_IMAGES.Images.SetKeyName(2, "_IMSS_NetWork_Icon_16x16.png")
        Me._IMSS_IMAGES.Images.SetKeyName(3, "_IMSS_LocalService_Icon_16x16.png")
        '
        '_IMSS_PROCESSES_Tap
        '
        Me._IMSS_PROCESSES_Tap.AttachedControl = Me.SuperTabControlPanel1
        Me._IMSS_PROCESSES_Tap.GlobalItem = False
        Me._IMSS_PROCESSES_Tap.Name = "_IMSS_PROCESSES_Tap"
        Me._IMSS_PROCESSES_Tap.Text = "Processes"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me._IMSS_APLICATION_LISTVIEW)
        Me.SuperTabControlPanel3.Controls.Add(Me._IMSS_END_TASK_Button)
        Me.SuperTabControlPanel3.Controls.Add(Me._IMSS_SwitchTo_Button)
        Me.SuperTabControlPanel3.Controls.Add(Me.Button1)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(394, 397)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me._IMSS_Application_Tap
        '
        '_IMSS_APLICATION_LISTVIEW
        '
        Me._IMSS_APLICATION_LISTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_APLICATION_LISTVIEW.Columns.AddRange(New Object() {Me.BetterListViewColumnHeader1, Me.BetterListViewColumnHeader2})
        Me._IMSS_APLICATION_LISTVIEW.ContextMenuStrip = Me._IMSS_APPLICAT_ContextMenu
        Me._IMSS_APLICATION_LISTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_APLICATION_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_APLICATION_LISTVIEW.Location = New System.Drawing.Point(14, 10)
        Me._IMSS_APLICATION_LISTVIEW.MultiSelect = False
        Me._IMSS_APLICATION_LISTVIEW.Name = "_IMSS_APLICATION_LISTVIEW"
        Me._IMSS_APLICATION_LISTVIEW.Size = New System.Drawing.Size(367, 331)
        Me._IMSS_APLICATION_LISTVIEW.TabIndex = 0
        '
        'BetterListViewColumnHeader1
        '
        Me.BetterListViewColumnHeader1.Name = "BetterListViewColumnHeader1"
        Me.BetterListViewColumnHeader1.Text = "Task"
        Me.BetterListViewColumnHeader1.Width = 281
        '
        'BetterListViewColumnHeader2
        '
        Me.BetterListViewColumnHeader2.Name = "BetterListViewColumnHeader2"
        Me.BetterListViewColumnHeader2.Text = "Status"
        Me.BetterListViewColumnHeader2.Width = 81
        '
        '_IMSS_APPLICAT_ContextMenu
        '
        Me._IMSS_APPLICAT_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._IMSS_SwitchTo_Context, Me._IMSS_BringToFront_Context, Me._IMSS_Separator1_Context, Me._IMSS_Minimize_Context, Me._IMSS_Maximize_Context, Me._IMSS_Separator2_Context, Me._IMSS_EndTask_Context, Me._IMSS_GoToProcess_Context, Me._IMSS_Separator3_Context, Me._IMSS_OpenFileLocation_Context, Me._IMSS_ScanOnline_Context, Me._IMSS_NewTaskRun_Context})
        Me._IMSS_APPLICAT_ContextMenu.Name = "_IMSS_APPLICAT_ContextMenu"
        Me._IMSS_APPLICAT_ContextMenu.Size = New System.Drawing.Size(174, 220)
        '
        '_IMSS_SwitchTo_Context
        '
        Me._IMSS_SwitchTo_Context.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SwitchTo_Context.Name = "_IMSS_SwitchTo_Context"
        Me._IMSS_SwitchTo_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_SwitchTo_Context.Text = "Switch To"
        '
        '_IMSS_BringToFront_Context
        '
        Me._IMSS_BringToFront_Context.Name = "_IMSS_BringToFront_Context"
        Me._IMSS_BringToFront_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_BringToFront_Context.Text = "Bring To Front "
        '
        '_IMSS_Separator1_Context
        '
        Me._IMSS_Separator1_Context.Name = "_IMSS_Separator1_Context"
        Me._IMSS_Separator1_Context.Size = New System.Drawing.Size(170, 6)
        '
        '_IMSS_Minimize_Context
        '
        Me._IMSS_Minimize_Context.Name = "_IMSS_Minimize_Context"
        Me._IMSS_Minimize_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_Minimize_Context.Text = "Minimize"
        '
        '_IMSS_Maximize_Context
        '
        Me._IMSS_Maximize_Context.Name = "_IMSS_Maximize_Context"
        Me._IMSS_Maximize_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_Maximize_Context.Text = "Maximize"
        '
        '_IMSS_Separator2_Context
        '
        Me._IMSS_Separator2_Context.Name = "_IMSS_Separator2_Context"
        Me._IMSS_Separator2_Context.Size = New System.Drawing.Size(170, 6)
        '
        '_IMSS_EndTask_Context
        '
        Me._IMSS_EndTask_Context.Name = "_IMSS_EndTask_Context"
        Me._IMSS_EndTask_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_EndTask_Context.Text = "End Task"
        '
        '_IMSS_GoToProcess_Context
        '
        Me._IMSS_GoToProcess_Context.Name = "_IMSS_GoToProcess_Context"
        Me._IMSS_GoToProcess_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_GoToProcess_Context.Text = "Go To Process"
        '
        '_IMSS_Separator3_Context
        '
        Me._IMSS_Separator3_Context.Name = "_IMSS_Separator3_Context"
        Me._IMSS_Separator3_Context.Size = New System.Drawing.Size(170, 6)
        '
        '_IMSS_OpenFileLocation_Context
        '
        Me._IMSS_OpenFileLocation_Context.Name = "_IMSS_OpenFileLocation_Context"
        Me._IMSS_OpenFileLocation_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_OpenFileLocation_Context.Text = "Open File Location"
        '
        '_IMSS_ScanOnline_Context
        '
        Me._IMSS_ScanOnline_Context.Name = "_IMSS_ScanOnline_Context"
        Me._IMSS_ScanOnline_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_ScanOnline_Context.Text = "Scan Online"
        '
        '_IMSS_NewTaskRun_Context
        '
        Me._IMSS_NewTaskRun_Context.Name = "_IMSS_NewTaskRun_Context"
        Me._IMSS_NewTaskRun_Context.Size = New System.Drawing.Size(173, 22)
        Me._IMSS_NewTaskRun_Context.Text = "New Task (Run...)"
        Me._IMSS_NewTaskRun_Context.Visible = False
        '
        '_IMSS_END_TASK_Button
        '
        Me._IMSS_END_TASK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_END_TASK_Button.Location = New System.Drawing.Point(138, 346)
        Me._IMSS_END_TASK_Button.Name = "_IMSS_END_TASK_Button"
        Me._IMSS_END_TASK_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_END_TASK_Button.TabIndex = 3
        Me._IMSS_END_TASK_Button.Text = "End Task"
        Me._IMSS_END_TASK_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_SwitchTo_Button
        '
        Me._IMSS_SwitchTo_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_SwitchTo_Button.Location = New System.Drawing.Point(219, 346)
        Me._IMSS_SwitchTo_Button.Name = "_IMSS_SwitchTo_Button"
        Me._IMSS_SwitchTo_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_SwitchTo_Button.TabIndex = 2
        Me._IMSS_SwitchTo_Button.Text = "Switch To"
        Me._IMSS_SwitchTo_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(300, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "New Task ..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_IMSS_Application_Tap
        '
        Me._IMSS_Application_Tap.AttachedControl = Me.SuperTabControlPanel3
        Me._IMSS_Application_Tap.GlobalItem = False
        Me._IMSS_Application_Tap.Name = "_IMSS_Application_Tap"
        Me._IMSS_Application_Tap.Text = "Applications"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.cmdResume)
        Me.SuperTabControlPanel2.Controls.Add(Me.cmdPause)
        Me.SuperTabControlPanel2.Controls.Add(Me.cmdStop)
        Me.SuperTabControlPanel2.Controls.Add(Me.cmdStart)
        Me.SuperTabControlPanel2.Controls.Add(Me._IMSS_SERVICES_LISTVIEW)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(394, 397)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me._IMSS_Services_SuperTap
        '
        'cmdResume
        '
        Me.cmdResume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdResume.Location = New System.Drawing.Point(306, 345)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(75, 23)
        Me.cmdResume.TabIndex = 7
        Me.cmdResume.Text = "&Resume"
        '
        'cmdPause
        '
        Me.cmdPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPause.Location = New System.Drawing.Point(226, 345)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdPause.TabIndex = 6
        Me.cmdPause.Text = "&Pause"
        '
        'cmdStop
        '
        Me.cmdStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdStop.Location = New System.Drawing.Point(94, 345)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 5
        Me.cmdStop.Text = "S&top"
        '
        'cmdStart
        '
        Me.cmdStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdStart.Location = New System.Drawing.Point(14, 345)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 4
        Me.cmdStart.Text = "&Start"
        '
        '_IMSS_SERVICES_LISTVIEW
        '
        Me._IMSS_SERVICES_LISTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_SERVICES_LISTVIEW.Columns.AddRange(New Object() {Me._IMSS_Name, Me._IMSS_Status, Me._IMSS_ServiceType})
        Me._IMSS_SERVICES_LISTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SERVICES_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_SERVICES_LISTVIEW.Location = New System.Drawing.Point(14, 10)
        Me._IMSS_SERVICES_LISTVIEW.MultiSelect = False
        Me._IMSS_SERVICES_LISTVIEW.Name = "_IMSS_SERVICES_LISTVIEW"
        Me._IMSS_SERVICES_LISTVIEW.Size = New System.Drawing.Size(367, 331)
        Me._IMSS_SERVICES_LISTVIEW.TabIndex = 1
        '
        '_IMSS_Name
        '
        Me._IMSS_Name.Name = "_IMSS_Name"
        Me._IMSS_Name.Text = "Name"
        '
        '_IMSS_Status
        '
        Me._IMSS_Status.Name = "_IMSS_Status"
        Me._IMSS_Status.Text = "Status"
        Me._IMSS_Status.Width = 105
        '
        '_IMSS_ServiceType
        '
        Me._IMSS_ServiceType.Name = "_IMSS_ServiceType"
        Me._IMSS_ServiceType.Text = "Service Type"
        '
        '_IMSS_Services_SuperTap
        '
        Me._IMSS_Services_SuperTap.AttachedControl = Me.SuperTabControlPanel2
        Me._IMSS_Services_SuperTap.GlobalItem = False
        Me._IMSS_Services_SuperTap.Name = "_IMSS_Services_SuperTap"
        Me._IMSS_Services_SuperTap.Text = "Services"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Controls.Add(Me._IMSS_Send_MessageBox_Button)
        Me.SuperTabControlPanel4.Controls.Add(Me._IMSS_Logoff)
        Me.SuperTabControlPanel4.Controls.Add(Me._IMSS_Disconnect_Button)
        Me.SuperTabControlPanel4.Controls.Add(Me._IMSS_USERS_LISTVIEW)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(394, 397)
        Me.SuperTabControlPanel4.TabIndex = 0
        Me.SuperTabControlPanel4.TabItem = Me._IMSS_Performance_SuperTap
        '
        '_IMSS_Send_MessageBox_Button
        '
        Me._IMSS_Send_MessageBox_Button.Location = New System.Drawing.Point(277, 345)
        Me._IMSS_Send_MessageBox_Button.Name = "_IMSS_Send_MessageBox_Button"
        Me._IMSS_Send_MessageBox_Button.Size = New System.Drawing.Size(104, 23)
        Me._IMSS_Send_MessageBox_Button.TabIndex = 5
        Me._IMSS_Send_MessageBox_Button.Text = "Send Message..."
        Me._IMSS_Send_MessageBox_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_Logoff
        '
        Me._IMSS_Logoff.Location = New System.Drawing.Point(196, 345)
        Me._IMSS_Logoff.Name = "_IMSS_Logoff"
        Me._IMSS_Logoff.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Logoff.TabIndex = 4
        Me._IMSS_Logoff.Text = "Logoff"
        Me._IMSS_Logoff.UseVisualStyleBackColor = True
        '
        '_IMSS_Disconnect_Button
        '
        Me._IMSS_Disconnect_Button.Location = New System.Drawing.Point(115, 345)
        Me._IMSS_Disconnect_Button.Name = "_IMSS_Disconnect_Button"
        Me._IMSS_Disconnect_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Disconnect_Button.TabIndex = 3
        Me._IMSS_Disconnect_Button.Text = "Disconnect"
        Me._IMSS_Disconnect_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_USERS_LISTVIEW
        '
        Me._IMSS_USERS_LISTVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_USERS_LISTVIEW.Columns.AddRange(New Object() {Me._IMSS_User, Me._IMSS_ID, Me._IMSS_Users_Status, Me._IMSS_Session, Me._IMSS_UserAccount, Me._IMSS_DomainName, Me._IMSS_ConnectTime, Me._IMSS_LoginTime})
        Me._IMSS_USERS_LISTVIEW.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_USERS_LISTVIEW.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Sortable
        Me._IMSS_USERS_LISTVIEW.Location = New System.Drawing.Point(15, 8)
        Me._IMSS_USERS_LISTVIEW.MultiSelect = False
        Me._IMSS_USERS_LISTVIEW.Name = "_IMSS_USERS_LISTVIEW"
        Me._IMSS_USERS_LISTVIEW.Size = New System.Drawing.Size(367, 333)
        Me._IMSS_USERS_LISTVIEW.TabIndex = 2
        '
        '_IMSS_User
        '
        Me._IMSS_User.Name = "_IMSS_User"
        Me._IMSS_User.Text = "User"
        '
        '_IMSS_ID
        '
        Me._IMSS_ID.Name = "_IMSS_ID"
        Me._IMSS_ID.Text = "ID"
        Me._IMSS_ID.Width = 30
        '
        '_IMSS_Users_Status
        '
        Me._IMSS_Users_Status.Name = "_IMSS_Users_Status"
        Me._IMSS_Users_Status.Text = "Status"
        Me._IMSS_Users_Status.Width = 78
        '
        '_IMSS_Session
        '
        Me._IMSS_Session.Name = "_IMSS_Session"
        Me._IMSS_Session.Text = "Session"
        Me._IMSS_Session.Width = 65
        '
        '_IMSS_UserAccount
        '
        Me._IMSS_UserAccount.Name = "_IMSS_UserAccount"
        Me._IMSS_UserAccount.Text = "User Account"
        '
        '_IMSS_DomainName
        '
        Me._IMSS_DomainName.Name = "_IMSS_DomainName"
        Me._IMSS_DomainName.Text = "Domain Name"
        '
        '_IMSS_ConnectTime
        '
        Me._IMSS_ConnectTime.Name = "_IMSS_ConnectTime"
        Me._IMSS_ConnectTime.Text = "Connect Time "
        '
        '_IMSS_LoginTime
        '
        Me._IMSS_LoginTime.Name = "_IMSS_LoginTime"
        Me._IMSS_LoginTime.Text = "Login Time"
        '
        '_IMSS_Performance_SuperTap
        '
        Me._IMSS_Performance_SuperTap.AttachedControl = Me.SuperTabControlPanel4
        Me._IMSS_Performance_SuperTap.GlobalItem = False
        Me._IMSS_Performance_SuperTap.Name = "_IMSS_Performance_SuperTap"
        Me._IMSS_Performance_SuperTap.Text = "Users"
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(0, 422)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(394, 0)
        Me.DockSite4.TabIndex = 4
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 0)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 422)
        Me.DockSite1.TabIndex = 1
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(394, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 422)
        Me.DockSite2.TabIndex = 2
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 422)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(394, 0)
        Me.DockSite8.TabIndex = 8
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 0)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 422)
        Me.DockSite5.TabIndex = 5
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(394, 0)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 422)
        Me.DockSite6.TabIndex = 6
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(394, 0)
        Me.DockSite7.TabIndex = 7
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 0)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(394, 0)
        Me.DockSite3.TabIndex = 3
        Me.DockSite3.TabStop = False
        '
        '_IMSS_APPLICATION_REFRESH_TIMER
        '
        Me._IMSS_APPLICATION_REFRESH_TIMER.Interval = 3000
        '
        '_IMSS_GET_CPU_USAGE_TIMER
        '
        Me._IMSS_GET_CPU_USAGE_TIMER.Interval = 2000
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 422)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me._IMSS_Main_Panel)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(410, 460)
        Me.Name = "MainWindow"
        Me.Text = "IMSS Processes Manager"
        Me._IMSS_Main_Panel.ResumeLayout(False)
        Me._IMSS_Main_Panel.PerformLayout()
        Me._IMSS_StatusStrip.ResumeLayout(False)
        Me._IMSS_StatusStrip.PerformLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me._IMSS_PROCESSES_CONTROLER.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me._IMSS_PROCESSES_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_PROCESSES_ContextMenu.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me._IMSS_PROCESSES_SYSTEM_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me._IMSS_PROCESSES_NETWORK_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me._IMSS_LOCAL_SERVICES_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel3.ResumeLayout(False)
        CType(Me._IMSS_APLICATION_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_APPLICAT_ContextMenu.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me._IMSS_SERVICES_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel4.ResumeLayout(False)
        CType(Me._IMSS_USERS_LISTVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_Main_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_PROCESSES_Tap As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_Services_SuperTap As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_Application_Tap As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_END_TASK_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_SwitchTo_Button As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents _IMSS_APLICATION_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents BetterListViewColumnHeader1 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader2 As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_Performance_SuperTap As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_APPLICATION_REFRESH_TIMER As System.Windows.Forms.Timer
    Friend WithEvents _IMSS_StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents _IMSS_TOTALE_PROCESS_STATUSBAR As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents _IMSS_CPU_USAGE_Label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents _IMSS_PhysicalMemory_Label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents _IMSS_GET_CPU_USAGE_TIMER As System.Windows.Forms.Timer
    Friend WithEvents _IMSS_APPLICAT_ContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents _IMSS_SwitchTo_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_BringToFront_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_Separator1_Context As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _IMSS_Minimize_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_Maximize_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_Separator2_Context As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _IMSS_EndTask_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_GoToProcess_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_ScanOnline_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_Separator3_Context As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _IMSS_OpenFileLocation_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_NewTaskRun_Context As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_IMAGES As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_PROCESSES_CONTROLER As System.Windows.Forms.TabControl
    Friend WithEvents BetterListViewColumnHeader1_1_ As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader5_5_ As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader2_2_ As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader7_7_ As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader6_6_ As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents BetterListViewColumnHeader8_8_ As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_PROCESSES_SYSTEM_LIST As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS__ImageName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Priority As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_UserName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_PID As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_MemoryWorkingSet As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Description As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_PROCESSES_NETWORK_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_NetWork_ImageName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_NetWork_Priority As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_NetWork_UserName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_NetWork_PID As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_NetWork_MemoryWorkingSet As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_NetWork_Description As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents _IMSS_LOCAL_SERVICES_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_LOCALSERVICE_ImageName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LOCALSERVICE_Priority As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LOCALSERVICE_UserName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LOCALSERVICE_PID As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LOCALSERVICE_MemoryWorkingSet As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LOCALSERVICE_Description As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents _IMSS_PROCESSES_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_User_ScanOnline As System.Windows.Forms.Button
    Friend WithEvents _IMSS_User_EndProcess_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_User_NewTask As System.Windows.Forms.Button
    Friend WithEvents _IMSS_PROCESSES_ContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ScanProcessFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchProcessOnlineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EndProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendResumeProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChangePriorityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeCriticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboveNormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BelowNormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LowestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemoryDumpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EverythingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViaNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViaDescriptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _IMSS_SERVICES_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_Name As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Status As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ServiceType As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents cmdResume As System.Windows.Forms.Button
    Friend WithEvents cmdPause As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents _IMSS_USERS_LISTVIEW As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_User As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ID As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Users_Status As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Session As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_UserAccount As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_DomainName As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_ConnectTime As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_LoginTime As ComponentOwl.BetterListView.BetterListViewColumnHeader
    Friend WithEvents _IMSS_Disconnect_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Send_MessageBox_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Logoff As System.Windows.Forms.Button

End Class
