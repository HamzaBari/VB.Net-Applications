Public Class Loops

    Private Sub btnShow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDisplay.Click
        Dim first As Integer
        Dim second As Font = New Font("Calibri", 16, FontStyle.Underline, GraphicsUnit.Point) 'the style and font
        Dim myBrushhamza As New SolidBrush(Color.White) 'the colour
        'Declare varibles
        CreateGraphics.Clear(BackColor)
        For first = 1 To TextBoxTillwhen.Text     'The Quantity
            CreateGraphics.DrawString(first & " x " & TextBoxNumber.Text & " = " & first * 'Enter the multiple number
    TextBoxNumber.Text, second, myBrushhamza, 18, first * 25 + 46)
        Next first
        ShowHelpMessage("Show the Results")
    End Sub     'Timetables are shown upto how much quantity you want
    ' this represents the Loops.

    'On-Screen Help 
    Private Sub ShowHelpMessage(ByVal strHelpMsg As String)
        LblHelp.Text = strHelpMsg
    End Sub

    'Help for TextBoxNumber 
    Private Sub TextBoxNumber_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumber.TextChanged
        ShowHelpMessage("Choose a number")
    End Sub

    'Help for TextBoxTillwhen
    Private Sub TextBoxTillwhen_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTillwhen.TextChanged
        ShowHelpMessage("Choose, how many times")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnExplain.Click
        If RadioButton1.Checked = True Then 'this is the radio button 1.
            MsgBox("These are the Loops")
            ShowHelpMessage("Loops Explanation") 'Explanation help
        ElseIf RadioButton2.Checked = True Then 'this is the radio button 2.
            MsgBox("The loops would make sure that the multiples are getting multiplied non-stop")
            ShowHelpMessage("Loops Description") 'Loops description
        End If
        If CheckBox1.Checked = True Then 'this is the checkbox 1.
            MsgBox("Yes")
            ShowHelpMessage("Learn") 'Learning multiples help
        End If
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        MainMenu.Show()     'show main menu
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()     'close the form
    End Sub

End Class
' End Program