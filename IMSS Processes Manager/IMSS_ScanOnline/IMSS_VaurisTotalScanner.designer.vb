<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_VaurisTotalScanner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_VaurisTotalScanner))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_LoadingPanel = New System.Windows.Forms.Panel()
        Me._IMSS_LoadingLabel = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_LoadingImage = New System.Windows.Forms.PictureBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me._IMSS_MainPanel.SuspendLayout()
        Me._IMSS_LoadingPanel.SuspendLayout()
        CType(Me._IMSS_LoadingImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_LoadingPanel)
        Me._IMSS_MainPanel.Controls.Add(Me.WebBrowser1)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(1163, 515)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.BorderWidth = 0
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_LoadingPanel
        '
        Me._IMSS_LoadingPanel.BackColor = System.Drawing.Color.White
        Me._IMSS_LoadingPanel.Controls.Add(Me._IMSS_LoadingLabel)
        Me._IMSS_LoadingPanel.Controls.Add(Me._IMSS_LoadingImage)
        Me._IMSS_LoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_LoadingPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_LoadingPanel.Name = "_IMSS_LoadingPanel"
        Me._IMSS_LoadingPanel.Size = New System.Drawing.Size(1163, 515)
        Me._IMSS_LoadingPanel.TabIndex = 2
        '
        '_IMSS_LoadingLabel
        '
        Me._IMSS_LoadingLabel.AutoSize = True
        '
        '
        '
        Me._IMSS_LoadingLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_LoadingLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_LoadingLabel.Location = New System.Drawing.Point(525, 276)
        Me._IMSS_LoadingLabel.Name = "_IMSS_LoadingLabel"
        Me._IMSS_LoadingLabel.Size = New System.Drawing.Size(118, 18)
        Me._IMSS_LoadingLabel.TabIndex = 2
        Me._IMSS_LoadingLabel.Text = "Uploading File ..."
        '
        '_IMSS_LoadingImage
        '
        Me._IMSS_LoadingImage.BackColor = System.Drawing.Color.White
        Me._IMSS_LoadingImage.Image = Global.IMSS_Processes_Manager.My.Resources.Resources._IMSS_ProcessesManager_Loading_Icon_400x50
        Me._IMSS_LoadingImage.Location = New System.Drawing.Point(381, 220)
        Me._IMSS_LoadingImage.Name = "_IMSS_LoadingImage"
        Me._IMSS_LoadingImage.Size = New System.Drawing.Size(400, 50)
        Me._IMSS_LoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_LoadingImage.TabIndex = 1
        Me._IMSS_LoadingImage.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1163, 515)
        Me.WebBrowser1.TabIndex = 0
        '
        'IMSS_VaurisTotalScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 515)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IMSS_VaurisTotalScanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Virus Total Scanner"
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_LoadingPanel.ResumeLayout(False)
        Me._IMSS_LoadingPanel.PerformLayout()
        CType(Me._IMSS_LoadingImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents _IMSS_LoadingImage As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_LoadingPanel As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_LoadingLabel As DevComponents.DotNetBar.LabelX
End Class
