Public Class Speak

    Private Sub Talk_Click(sender As Object, e As EventArgs) Handles Talk.Click
        Dim Speak As Object     'declare varible 
        Speak = CreateObject("SAPI.spvoice")   'enter text of what needs to be spoken
        Speak.speak(Speakbox.Text)      'press this button to speak
        ShowHelpMessage("Text is Spoken") 'Text Spoken Help
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MainMenu.Click
        MainMenu.Show()    'show main menu
        ShowHelpMessage("Main Menu") 'Main Menu Button Help
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Close() 'close the form 
        ShowHelpMessage("Close") 'Close Button Help
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Speakbox.Clear()    'clear the speak box when the button is clicked
        HelpMessageShown.Text = "Cleared" 'OnScreen Help Cleared
    End Sub

    'On-Screen Help 
    Private Sub ShowHelpMessage(ByVal strHelpMsg As String)
        LBLHelp.Text = strHelpMsg
    End Sub

End Class