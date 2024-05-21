Public Class PictureFunPlay

    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click
        Image.Top = Image.Top - 15 'image moves up as you press the up button
        'there was an error here as my image was moving down on the up button therefore I corrected my code by putting "= -15 " insted of " +15 "
        ShowHelpMessage("Up Button Clicked") 'Up Button Help
    End Sub

    Private Sub BtnDown_Click(sender As Object, e As EventArgs) Handles ButtonDown.Click
        Image.Top = Image.Top + 15  'image moves down as you press the down button
        ShowHelpMessage("Down Button Clicked") 'Down Button Help
    End Sub

    Private Sub BtnLeft_Click(sender As Object, e As EventArgs) Handles ButtonLeft.Click
        Image.Left = Image.Left - 7.5 'image moves left as you press the left button
        ShowHelpMessage("Left Button Clicked") 'Left Button Help
    End Sub

    Private Sub BtnRight_Click(sender As Object, e As EventArgs) Handles ButtonRight.Click
        Image.Left = Image.Left + 7.5
        ShowHelpMessage("Right Button Clicked") 'Right Button Help
    End Sub     'image moves to the right hand side as you press the right button

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        MsgBox("Reseting the image to its orginal postion") 'Message Box hlep for Reset Button
        Image.Width = 228
        Image.Height = 295
    End Sub     'reset the image to original 

    Private Sub BtnSmall_Click(sender As Object, e As EventArgs) Handles ButtonSmall.Click
        MsgBox("The Image is Made Smaller") 'Message Box hlep for Small Button
        Image.Width = 35
        Image.Height = 40
    End Sub     'make the image small

    Private Sub BtnLarge_Click(sender As Object, e As EventArgs) Handles ButtonLarge.Click
        MsgBox("The Image is Made Larger") 'Message Box hlep for Large Button
        Image.Width = 400
        Image.Height = 400
    End Sub     'make the image large

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Swap.Click
        Image.Image = My.Resources.image1
        ShowHelpMessage("Image is Changed") 'The image changes
    End Sub

    Private Sub Swapback_Click(sender As Object, e As EventArgs) Handles Swapback.Click
        Image.Image = My.Resources.aircraft
        ShowHelpMessage("Image is Changes back") 'The image changes back
    End Sub

    'On-Screen Help 
    Private Sub ShowHelpMessage(ByVal strHelpMsg As String)
        HelpLbl.Text = strHelpMsg
    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        MainMenu.Show() 'show main menu
        ShowHelpMessage("Main Menu is Clicked") 'Main Menu Button Help
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close() 'close the form
        ShowHelpMessage("Close Form") 'Close Form Help
    End Sub

End Class