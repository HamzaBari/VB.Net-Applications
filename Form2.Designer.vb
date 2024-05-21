<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNotepad = New System.Windows.Forms.Button()
        Me.BtnPictureFunPlay = New System.Windows.Forms.Button()
        Me.BtnSpeakbox = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnLoop = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip6 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCalc
        '
        Me.BtnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalc.Location = New System.Drawing.Point(40, 75)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(195, 35)
        Me.BtnCalc.TabIndex = 2
        Me.BtnCalc.Text = "Learning Tools"
        Me.ToolTip2.SetToolTip(Me.BtnCalc, "Click Calculator Button")
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(267, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Main Menu"
        '
        'BtnNotepad
        '
        Me.BtnNotepad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotepad.Location = New System.Drawing.Point(40, 324)
        Me.BtnNotepad.Name = "BtnNotepad"
        Me.BtnNotepad.Size = New System.Drawing.Size(206, 35)
        Me.BtnNotepad.TabIndex = 6
        Me.BtnNotepad.Text = "Notepad"
        Me.ToolTip3.SetToolTip(Me.BtnNotepad, "Click Notepad Button")
        Me.BtnNotepad.UseVisualStyleBackColor = True
        '
        'BtnPictureFunPlay
        '
        Me.BtnPictureFunPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPictureFunPlay.Location = New System.Drawing.Point(40, 209)
        Me.BtnPictureFunPlay.Name = "BtnPictureFunPlay"
        Me.BtnPictureFunPlay.Size = New System.Drawing.Size(206, 34)
        Me.BtnPictureFunPlay.TabIndex = 7
        Me.BtnPictureFunPlay.Text = "Picture Fun Play"
        Me.ToolTip3.SetToolTip(Me.BtnPictureFunPlay, "Click Picture Fun Play Button")
        Me.BtnPictureFunPlay.UseVisualStyleBackColor = True
        '
        'BtnSpeakbox
        '
        Me.BtnSpeakbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSpeakbox.Location = New System.Drawing.Point(401, 75)
        Me.BtnSpeakbox.Name = "BtnSpeakbox"
        Me.BtnSpeakbox.Size = New System.Drawing.Size(167, 35)
        Me.BtnSpeakbox.TabIndex = 8
        Me.BtnSpeakbox.Text = "Speak Box"
        Me.ToolTip4.SetToolTip(Me.BtnSpeakbox, "Click Speak Box Button")
        Me.BtnSpeakbox.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(261, 208)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(122, 35)
        Me.BtnQuit.TabIndex = 9
        Me.BtnQuit.Text = "Quit"
        Me.ToolTip6.SetToolTip(Me.BtnQuit, "Click Quit Button")
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnLoop
        '
        Me.BtnLoop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoop.Location = New System.Drawing.Point(401, 208)
        Me.BtnLoop.Name = "BtnLoop"
        Me.BtnLoop.Size = New System.Drawing.Size(167, 35)
        Me.BtnLoop.TabIndex = 10
        Me.BtnLoop.Text = "Loops"
        Me.ToolTip5.SetToolTip(Me.BtnLoop, "Click Loops Button")
        Me.BtnLoop.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(401, 324)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 35)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Web Editor"
        Me.ToolTip1.SetToolTip(Me.Button2, "Open Web Editor")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(414, 395)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 11
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(621, 432)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLoop)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnSpeakbox)
        Me.Controls.Add(Me.BtnPictureFunPlay)
        Me.Controls.Add(Me.BtnNotepad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCalc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ToolTip1.SetToolTip(Me, "Main Menu Page")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnNotepad As Button
    Friend WithEvents BtnPictureFunPlay As Button
    Friend WithEvents BtnSpeakbox As Button
    Friend WithEvents BtnQuit As Button
    Public WithEvents Label1 As Label
    Friend WithEvents BtnLoop As Button
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip6 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
