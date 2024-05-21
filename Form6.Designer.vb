<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Speak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Speak))
        Me.MainMenu = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.FillForms = New System.Windows.Forms.Label()
        Me.Talk = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.HelpMessageShown = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LBLHelp = New System.Windows.Forms.Label()
        Me.Speakbox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenu.ForeColor = System.Drawing.Color.Black
        Me.MainMenu.Location = New System.Drawing.Point(16, 542)
        Me.MainMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MainMenu.Size = New System.Drawing.Size(173, 55)
        Me.MainMenu.TabIndex = 9
        Me.MainMenu.Text = "Main Menu"
        Me.ToolTip1.SetToolTip(Me.MainMenu, "Main Menu Button")
        Me.MainMenu.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.ForeColor = System.Drawing.Color.Black
        Me.Quit.Location = New System.Drawing.Point(511, 542)
        Me.Quit.Margin = New System.Windows.Forms.Padding(4)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(173, 55)
        Me.Quit.TabIndex = 10
        Me.Quit.Text = "Quit"
        Me.ToolTip1.SetToolTip(Me.Quit, "Quit Button")
        Me.Quit.UseVisualStyleBackColor = True
        '
        'FillForms
        '
        Me.FillForms.AutoSize = True
        Me.FillForms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillForms.ForeColor = System.Drawing.Color.White
        Me.FillForms.Location = New System.Drawing.Point(279, 11)
        Me.FillForms.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FillForms.Name = "FillForms"
        Me.FillForms.Size = New System.Drawing.Size(138, 29)
        Me.FillForms.TabIndex = 0
        Me.FillForms.Text = "Speak Box"
        '
        'Talk
        '
        Me.Talk.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Talk.ForeColor = System.Drawing.Color.Black
        Me.Talk.Location = New System.Drawing.Point(219, 90)
        Me.Talk.Margin = New System.Windows.Forms.Padding(4)
        Me.Talk.Name = "Talk"
        Me.Talk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Talk.Size = New System.Drawing.Size(295, 90)
        Me.Talk.TabIndex = 11
        Me.Talk.Text = "Talk"
        Me.ToolTip1.SetToolTip(Me.Talk, "Talk Button")
        Me.Talk.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.Color.Black
        Me.Clear.Location = New System.Drawing.Point(16, 454)
        Me.Clear.Margin = New System.Windows.Forms.Padding(4)
        Me.Clear.Name = "Clear"
        Me.Clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Clear.Size = New System.Drawing.Size(173, 55)
        Me.Clear.TabIndex = 13
        Me.Clear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.Clear, "Clear Button")
        Me.Clear.UseVisualStyleBackColor = True
        '
        'HelpMessageShown
        '
        Me.HelpMessageShown.AutoSize = True
        Me.HelpMessageShown.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpMessageShown.Location = New System.Drawing.Point(246, 467)
        Me.HelpMessageShown.Name = "HelpMessageShown"
        Me.HelpMessageShown.Size = New System.Drawing.Size(0, 29)
        Me.HelpMessageShown.TabIndex = 14
        '
        'LBLHelp
        '
        Me.LBLHelp.AutoSize = True
        Me.LBLHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHelp.Location = New System.Drawing.Point(240, 467)
        Me.LBLHelp.Name = "LBLHelp"
        Me.LBLHelp.Size = New System.Drawing.Size(0, 29)
        Me.LBLHelp.TabIndex = 15
        '
        'Speakbox
        '
        Me.Speakbox.Location = New System.Drawing.Point(16, 209)
        Me.Speakbox.Name = "Speakbox"
        Me.Speakbox.Size = New System.Drawing.Size(668, 238)
        Me.Speakbox.TabIndex = 16
        Me.Speakbox.Text = ""
        '
        'Speak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(700, 612)
        Me.Controls.Add(Me.Speakbox)
        Me.Controls.Add(Me.LBLHelp)
        Me.Controls.Add(Me.HelpMessageShown)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Talk)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.FillForms)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Speak"
        Me.Text = "Speak Box"
        Me.ToolTip1.SetToolTip(Me, "Speak box page")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As Button
    Friend WithEvents Quit As Button
    Friend WithEvents FillForms As Label
    Friend WithEvents Talk As Button
    Friend WithEvents Clear As Button
    Friend WithEvents HelpMessageShown As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LBLHelp As Label
    Friend WithEvents Speakbox As RichTextBox
End Class
