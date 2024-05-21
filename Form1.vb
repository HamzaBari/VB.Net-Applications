Public Class Login
    'Start Program
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TextboxUsername.Text = "10178341" And TextboxPassword.Text = "230800" Then MainMenu.Show() Else MsgBox("Sorry, Either Username or Password is invalid.", MsgBoxStyle.Critical, "Information")
        'First Textbox enter the username        'Second Textbox enter the Password  'Then open the main menu if inccorect then display the error message
        ShowHelpMessage("Press Login") 'On-Screen Help for Login Button
    End Sub
    'This is where the If Statement is being used.

    'On-Screen Help 
    Private Sub ShowHelpMessage(ByVal strHelpMsg As String)
        Label2.Text = strHelpMsg
    End Sub

    'On-Screen Help for Username Textbox
    Private Sub TextboxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextboxUsername.TextChanged
        ShowHelpMessage("Enter Username")
    End Sub

    'On-Screen Help for Password Textbox
    Private Sub TextboxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextboxPassword.TextChanged
        ShowHelpMessage("Enter Password")
    End Sub
End Class
