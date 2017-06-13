<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _IMSS_NEW_TASK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_IMSS_NEW_TASK))
        Me._IMSS_MAIN_PANEL = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Browse_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_PROCESSESNAME_TextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMASS_Run = New System.Windows.Forms.Button()
        Me._IMSS_Cancel = New System.Windows.Forms.Button()
        Me._IMSS_TEXT_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_TITLE_PICUTERBOX = New System.Windows.Forms.PictureBox()
        Me._IMSS_MAIN_PANEL.SuspendLayout()
        CType(Me._IMSS_TITLE_PICUTERBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_MAIN_PANEL
        '
        Me._IMSS_MAIN_PANEL.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MAIN_PANEL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_TITLE_PICUTERBOX)
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_TEXT_Label)
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_PROCESSESNAME_TextBox)
        Me._IMSS_MAIN_PANEL.Controls.Add(Me._IMSS_Browse_Button)
        Me._IMSS_MAIN_PANEL.Dock = System.Windows.Forms.DockStyle.Top
        Me._IMSS_MAIN_PANEL.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MAIN_PANEL.Name = "_IMSS_MAIN_PANEL"
        Me._IMSS_MAIN_PANEL.Size = New System.Drawing.Size(391, 72)
        Me._IMSS_MAIN_PANEL.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MAIN_PANEL.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me._IMSS_MAIN_PANEL.Style.BackColor2.Color = System.Drawing.Color.White
        Me._IMSS_MAIN_PANEL.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MAIN_PANEL.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MAIN_PANEL.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me._IMSS_MAIN_PANEL.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MAIN_PANEL.Style.GradientAngle = 90
        Me._IMSS_MAIN_PANEL.TabIndex = 0
        '
        '_IMSS_Browse_Button
        '
        Me._IMSS_Browse_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Browse_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Browse_Button.Location = New System.Drawing.Point(284, 31)
        Me._IMSS_Browse_Button.Name = "_IMSS_Browse_Button"
        Me._IMSS_Browse_Button.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Browse_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Browse_Button.TabIndex = 0
        Me._IMSS_Browse_Button.Text = "Browse"
        '
        '_IMSS_PROCESSESNAME_TextBox
        '
        '
        '
        '
        Me._IMSS_PROCESSESNAME_TextBox.Border.Class = "TextBoxBorder"
        Me._IMSS_PROCESSESNAME_TextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_PROCESSESNAME_TextBox.Location = New System.Drawing.Point(41, 33)
        Me._IMSS_PROCESSESNAME_TextBox.Name = "_IMSS_PROCESSESNAME_TextBox"
        Me._IMSS_PROCESSESNAME_TextBox.Size = New System.Drawing.Size(237, 20)
        Me._IMSS_PROCESSESNAME_TextBox.TabIndex = 1
        '
        '_IMASS_Run
        '
        Me._IMASS_Run.Location = New System.Drawing.Point(304, 76)
        Me._IMASS_Run.Name = "_IMASS_Run"
        Me._IMASS_Run.Size = New System.Drawing.Size(75, 23)
        Me._IMASS_Run.TabIndex = 1
        Me._IMASS_Run.Text = "Run"
        Me._IMASS_Run.UseVisualStyleBackColor = True
        '
        '_IMSS_Cancel
        '
        Me._IMSS_Cancel.Location = New System.Drawing.Point(223, 76)
        Me._IMSS_Cancel.Name = "_IMSS_Cancel"
        Me._IMSS_Cancel.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Cancel.TabIndex = 2
        Me._IMSS_Cancel.Text = "Cancel"
        Me._IMSS_Cancel.UseVisualStyleBackColor = True
        '
        '_IMSS_TEXT_Label
        '
        Me._IMSS_TEXT_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_TEXT_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_TEXT_Label.Location = New System.Drawing.Point(41, 12)
        Me._IMSS_TEXT_Label.Name = "_IMSS_TEXT_Label"
        Me._IMSS_TEXT_Label.Size = New System.Drawing.Size(299, 15)
        Me._IMSS_TEXT_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_TEXT_Label.TabIndex = 2
        Me._IMSS_TEXT_Label.Text = "Type program name to run or browse for a program top run it."
        '
        '_IMSS_TITLE_PICUTERBOX
        '
        Me._IMSS_TITLE_PICUTERBOX.Image = Global.IMSS_Processes_Manager.My.Resources.Resources._IMSS_ProcessesManager_Run_Icon_24x24
        Me._IMSS_TITLE_PICUTERBOX.Location = New System.Drawing.Point(4, 27)
        Me._IMSS_TITLE_PICUTERBOX.Name = "_IMSS_TITLE_PICUTERBOX"
        Me._IMSS_TITLE_PICUTERBOX.Size = New System.Drawing.Size(32, 32)
        Me._IMSS_TITLE_PICUTERBOX.TabIndex = 3
        Me._IMSS_TITLE_PICUTERBOX.TabStop = False
        '
        '_IMSS_NEW_TASK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 103)
        Me.Controls.Add(Me._IMSS_Cancel)
        Me.Controls.Add(Me._IMASS_Run)
        Me.Controls.Add(Me._IMSS_MAIN_PANEL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(407, 141)
        Me.MinimumSize = New System.Drawing.Size(407, 141)
        Me.Name = "_IMSS_NEW_TASK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Run ..."
        Me._IMSS_MAIN_PANEL.ResumeLayout(False)
        Me._IMSS_MAIN_PANEL.PerformLayout()
        CType(Me._IMSS_TITLE_PICUTERBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MAIN_PANEL As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_TITLE_PICUTERBOX As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_TEXT_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_PROCESSESNAME_TextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_Browse_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMASS_Run As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Cancel As System.Windows.Forms.Button
End Class
