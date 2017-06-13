<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_SCAN_OPTIONS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_SCAN_OPTIONS))
        Me._IMSS_SCAN_Button = New System.Windows.Forms.Button()
        Me._IMSS_Cancel_button = New System.Windows.Forms.Button()
        Me._IMSS_TITLE_PICTUREBOX = New System.Windows.Forms.PictureBox()
        Me._IMSS_TEXT_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_FileName_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_FileSize_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_FileType_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_MAIN_PANEL = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ViewItem_Button = New DevComponents.DotNetBar.ButtonX()
        CType(Me._IMSS_TITLE_PICTUREBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MAIN_PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_SCAN_Button
        '
        Me._IMSS_SCAN_Button.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SCAN_Button.Location = New System.Drawing.Point(279, 122)
        Me._IMSS_SCAN_Button.Name = "_IMSS_SCAN_Button"
        Me._IMSS_SCAN_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_SCAN_Button.TabIndex = 2
        Me._IMSS_SCAN_Button.Text = "&Scan Now"
        Me._IMSS_SCAN_Button.UseVisualStyleBackColor = True
        '
        '_IMSS_Cancel_button
        '
        Me._IMSS_Cancel_button.Location = New System.Drawing.Point(198, 122)
        Me._IMSS_Cancel_button.Name = "_IMSS_Cancel_button"
        Me._IMSS_Cancel_button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel_button.TabIndex = 3
        Me._IMSS_Cancel_button.Text = "&Cancel"
        Me._IMSS_Cancel_button.UseVisualStyleBackColor = True
        '
        '_IMSS_TITLE_PICTUREBOX
        '
        Me._IMSS_TITLE_PICTUREBOX.Location = New System.Drawing.Point(23, 33)
        Me._IMSS_TITLE_PICTUREBOX.Name = "_IMSS_TITLE_PICTUREBOX"
        Me._IMSS_TITLE_PICTUREBOX.Size = New System.Drawing.Size(100, 73)
        Me._IMSS_TITLE_PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_TITLE_PICTUREBOX.TabIndex = 0
        Me._IMSS_TITLE_PICTUREBOX.TabStop = False
        '
        '_IMSS_TEXT_Label
        '
        Me._IMSS_TEXT_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_TEXT_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_TEXT_Label.Location = New System.Drawing.Point(23, 12)
        Me._IMSS_TEXT_Label.Name = "_IMSS_TEXT_Label"
        Me._IMSS_TEXT_Label.Size = New System.Drawing.Size(177, 15)
        Me._IMSS_TEXT_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TEXT_Label.TabIndex = 3
        Me._IMSS_TEXT_Label.Text = "Details for the current scan process :"
        '
        '_IMSS_FileName_Label
        '
        Me._IMSS_FileName_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_FileName_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_FileName_Label.Location = New System.Drawing.Point(129, 33)
        Me._IMSS_FileName_Label.Name = "_IMSS_FileName_Label"
        Me._IMSS_FileName_Label.Size = New System.Drawing.Size(56, 15)
        Me._IMSS_FileName_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_FileName_Label.TabIndex = 4
        Me._IMSS_FileName_Label.Text = "Fiel Name :"
        '
        '_IMSS_FileSize_Label
        '
        Me._IMSS_FileSize_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_FileSize_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_FileSize_Label.Location = New System.Drawing.Point(129, 54)
        Me._IMSS_FileSize_Label.Name = "_IMSS_FileSize_Label"
        Me._IMSS_FileSize_Label.Size = New System.Drawing.Size(48, 15)
        Me._IMSS_FileSize_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_FileSize_Label.TabIndex = 5
        Me._IMSS_FileSize_Label.Text = "File Size :"
        '
        '_IMSS_FileType_Label
        '
        Me._IMSS_FileType_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_FileType_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_FileType_Label.Location = New System.Drawing.Point(129, 75)
        Me._IMSS_FileType_Label.Name = "_IMSS_FileType_Label"
        Me._IMSS_FileType_Label.Size = New System.Drawing.Size(52, 15)
        Me._IMSS_FileType_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_FileType_Label.TabIndex = 6
        Me._IMSS_FileType_Label.Text = "File Type :"
        '
        '_IMSS_MAIN_PANEL
        '
        Me._IMSS_MAIN_PANEL.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MAIN_PANEL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MAIN_PANEL.Controls.Add(Me.LabelX4)
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_FileType_Label)
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_FileSize_Label)
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_FileName_Label)
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_TEXT_Label)
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_TITLE_PICTUREBOX)
        Me._IMSS_MAIN_PANEL.Dock = System.Windows.Forms.DockStyle.Top
        Me._IMSS_MAIN_PANEL.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MAIN_PANEL.Name = "_IMSS_MAIN_PANEL"
        Me._IMSS_MAIN_PANEL.Size = New System.Drawing.Size(361, 120)
        Me._IMSS_MAIN_PANEL.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MAIN_PANEL.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MAIN_PANEL.Style.BackColor2.Color = System.Drawing.Color.White
        Me._IMSS_MAIN_PANEL.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MAIN_PANEL.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MAIN_PANEL.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me._IMSS_MAIN_PANEL.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MAIN_PANEL.Style.GradientAngle = 90
        Me._IMSS_MAIN_PANEL.TabIndex = 1
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(129, 96)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(173, 15)
        Me.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Scan At : http://www.virustotal.com"
        '
        '_IMSS_ViewItem_Button
        '
        Me._IMSS_ViewItem_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_ViewItem_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_ViewItem_Button.Location = New System.Drawing.Point(6, 122)
        Me._IMSS_ViewItem_Button.Name = "_IMSS_ViewItem_Button"
        Me._IMSS_ViewItem_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_ViewItem_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ViewItem_Button.TabIndex = 4
        Me._IMSS_ViewItem_Button.Text = "View Item"
        '
        'IMSS_SCAN_OPTIONS
        '
        Me.AcceptButton = Me._IMSS_SCAN_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 147)
        Me.Controls.Add(Me._IMSS_ViewItem_Button)
        Me.Controls.Add(Me._IMSS_Cancel_button)
        Me.Controls.Add(Me._IMSS_SCAN_Button)
        Me.Controls.Add(Me._IMSS_MAIN_PANEL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(377, 185)
        Me.MinimumSize = New System.Drawing.Size(377, 185)
        Me.Name = "IMSS_SCAN_OPTIONS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan Details"
        CType(Me._IMSS_TITLE_PICTUREBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MAIN_PANEL.ResumeLayout(False)
        Me._IMSS_MAIN_PANEL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_SCAN_Button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Cancel_button As System.Windows.Forms.Button
    Friend WithEvents _IMSS_TITLE_PICTUREBOX As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_TEXT_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FileName_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FileSize_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FileType_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_MAIN_PANEL As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ViewItem_Button As DevComponents.DotNetBar.ButtonX
End Class
