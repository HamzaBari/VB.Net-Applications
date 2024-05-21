<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PictureFunPlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PictureFunPlay))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.ButtonLeft = New System.Windows.Forms.Button()
        Me.ButtonRight = New System.Windows.Forms.Button()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonSmall = New System.Windows.Forms.Button()
        Me.ButtonLarge = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpLbl = New System.Windows.Forms.Label()
        Me.Swap = New System.Windows.Forms.Button()
        Me.Image = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Swapback = New System.Windows.Forms.Button()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(455, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Picture 'Fun' Play"
        '
        'ButtonUp
        '
        Me.ButtonUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUp.Location = New System.Drawing.Point(819, 57)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(97, 44)
        Me.ButtonUp.TabIndex = 2
        Me.ButtonUp.Text = "Up"
        Me.ToolTip1.SetToolTip(Me.ButtonUp, "Press Up")
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ButtonLeft
        '
        Me.ButtonLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLeft.Location = New System.Drawing.Point(696, 143)
        Me.ButtonLeft.Name = "ButtonLeft"
        Me.ButtonLeft.Size = New System.Drawing.Size(97, 44)
        Me.ButtonLeft.TabIndex = 3
        Me.ButtonLeft.Text = "Left"
        Me.ToolTip1.SetToolTip(Me.ButtonLeft, "Press Left")
        Me.ButtonLeft.UseVisualStyleBackColor = True
        '
        'ButtonRight
        '
        Me.ButtonRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRight.Location = New System.Drawing.Point(945, 143)
        Me.ButtonRight.Name = "ButtonRight"
        Me.ButtonRight.Size = New System.Drawing.Size(97, 44)
        Me.ButtonRight.TabIndex = 4
        Me.ButtonRight.Text = "Right"
        Me.ToolTip1.SetToolTip(Me.ButtonRight, "Press Right")
        Me.ButtonRight.UseVisualStyleBackColor = True
        '
        'ButtonDown
        '
        Me.ButtonDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDown.Location = New System.Drawing.Point(819, 237)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(97, 44)
        Me.ButtonDown.TabIndex = 5
        Me.ButtonDown.Text = "Down"
        Me.ToolTip1.SetToolTip(Me.ButtonDown, "Press Down")
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.Location = New System.Drawing.Point(819, 143)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(97, 44)
        Me.ButtonReset.TabIndex = 6
        Me.ButtonReset.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.ButtonReset, "Press Reset")
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonSmall
        '
        Me.ButtonSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSmall.Location = New System.Drawing.Point(764, 392)
        Me.ButtonSmall.Name = "ButtonSmall"
        Me.ButtonSmall.Size = New System.Drawing.Size(97, 42)
        Me.ButtonSmall.TabIndex = 7
        Me.ButtonSmall.Text = "Small"
        Me.ToolTip1.SetToolTip(Me.ButtonSmall, "Press Small")
        Me.ButtonSmall.UseVisualStyleBackColor = True
        '
        'ButtonLarge
        '
        Me.ButtonLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLarge.Location = New System.Drawing.Point(881, 392)
        Me.ButtonLarge.Name = "ButtonLarge"
        Me.ButtonLarge.Size = New System.Drawing.Size(97, 42)
        Me.ButtonLarge.TabIndex = 8
        Me.ButtonLarge.Text = "Large"
        Me.ToolTip1.SetToolTip(Me.ButtonLarge, "Press Large")
        Me.ButtonLarge.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(1018, 556)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(97, 42)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Press Close")
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMainMenu.Location = New System.Drawing.Point(776, 556)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(212, 42)
        Me.BtnMainMenu.TabIndex = 10
        Me.BtnMainMenu.Text = "Back To Main Menu"
        Me.ToolTip1.SetToolTip(Me.BtnMainMenu, "Press Main Menu ")
        Me.BtnMainMenu.UseVisualStyleBackColor = True
        '
        'HelpLbl
        '
        Me.HelpLbl.AutoSize = True
        Me.HelpLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpLbl.ForeColor = System.Drawing.Color.White
        Me.HelpLbl.Location = New System.Drawing.Point(9, 588)
        Me.HelpLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HelpLbl.Name = "HelpLbl"
        Me.HelpLbl.Size = New System.Drawing.Size(0, 24)
        Me.HelpLbl.TabIndex = 11
        '
        'Swap
        '
        Me.Swap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Swap.Location = New System.Drawing.Point(12, 9)
        Me.Swap.Name = "Swap"
        Me.Swap.Size = New System.Drawing.Size(106, 46)
        Me.Swap.TabIndex = 12
        Me.Swap.Text = "Swap"
        Me.Swap.UseVisualStyleBackColor = True
        '
        'Image
        '
        Me.Image.Image = Global.Login_Page.My.Resources.Resources.aircraft
        Me.Image.Location = New System.Drawing.Point(127, 143)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(340, 217)
        Me.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image.TabIndex = 13
        Me.Image.TabStop = False
        '
        'Swapback
        '
        Me.Swapback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Swapback.Location = New System.Drawing.Point(124, 9)
        Me.Swapback.Name = "Swapback"
        Me.Swapback.Size = New System.Drawing.Size(131, 46)
        Me.Swapback.TabIndex = 14
        Me.Swapback.Text = "Swap Back"
        Me.Swapback.UseVisualStyleBackColor = True
        '
        'PictureFunPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1127, 619)
        Me.Controls.Add(Me.Swapback)
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.Swap)
        Me.Controls.Add(Me.HelpLbl)
        Me.Controls.Add(Me.BtnMainMenu)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ButtonLarge)
        Me.Controls.Add(Me.ButtonSmall)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonDown)
        Me.Controls.Add(Me.ButtonRight)
        Me.Controls.Add(Me.ButtonLeft)
        Me.Controls.Add(Me.ButtonUp)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PictureFunPlay"
        Me.Text = "Picture Fun Play"
        Me.ToolTip1.SetToolTip(Me, "Picture Fun Play Form")
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonUp As Button
    Friend WithEvents ButtonLeft As Button
    Friend WithEvents ButtonRight As Button
    Friend WithEvents ButtonDown As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ButtonSmall As Button
    Friend WithEvents ButtonLarge As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpLbl As Label
    Friend WithEvents Swap As Button
    Friend WithEvents Image As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Swapback As Button
End Class
