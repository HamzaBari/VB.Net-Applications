Public Class MainMenu

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Close() 'If this button is pressed then close the Main Menu Form.
        ShowHelpMessage("Form Closes") 'Close help message
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        LT.Show()   'If this button is pressed then open the Calculator Form.
        ShowHelpMessage("Open Calculator") 'Open Calculator form
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnSpeakbox.Click
        Speak.Show()    'If this button is pressed then open the SpeakBox Form.
        ShowHelpMessage("Open SpeakBox") 'Open SpeakBox form
    End Sub

    Private Sub BtnNotepad_Click(sender As Object, e As EventArgs) Handles BtnNotepad.Click
        Notepad.Show()  'If this button is pressed then open the Notepad Form.
        ShowHelpMessage("Open Notepad") 'Open Notepad form
    End Sub

    Private Sub BtnPictureFunPlay_Click(sender As Object, e As EventArgs) Handles BtnPictureFunPlay.Click
        PictureFunPlay.Show()   'If this button is pressed then open the Picture Fun Play Form.
        ShowHelpMessage("Open Picture Fun Play") 'Open Picture Fun Play form
    End Sub

    Private Sub BtnLoop_Click(sender As Object, e As EventArgs) Handles BtnLoop.Click
        Loops.Show()   'If this button is pressed then open the Loops Form. 
        ShowHelpMessage("Open Loops") 'Open Open Loops form
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebEditor.Show()
        ShowHelpMessage("Open Web Editor") 'Open Web Editor form
    End Sub

    'This is where all the button are you would use them to navigate to other forms.

    'On-Screen Help 
    Private Sub ShowHelpMessage(ByVal strHelpMsg As String)
        Label2.Text = strHelpMsg
    End Sub

End Class
