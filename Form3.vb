Public Class LT

    'This is where the varibles are being declaryed 
    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim Operations As Integer
    Dim Operator_selector As Boolean = False

    'These are where all the buttons are programed wihin the calculator using the IF Statement 

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click     'Start of the number buttons in the calculator
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "1"
        Else
            AnswerBox.Text += "1"   'number 1
        End If
        ShowHelpMessage("Number 1 Clicked") 'Number 1 Help
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "2"
        Else
            AnswerBox.Text += "2"   'number 2
        End If
        ShowHelpMessage("Number 2 Clicked") 'Number 2 Help
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "3"
        Else
            AnswerBox.Text += "3"   'number 3
        End If
        ShowHelpMessage("Number 3 Clicked") 'Number 3 Help
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "4"
        Else
            AnswerBox.Text += "4"   'number 4
        End If
        ShowHelpMessage("Number 4 Clicked") 'Number 4 Help
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "5"
        Else
            AnswerBox.Text += "5"   'number 5
        End If
        ShowHelpMessage("Number 5 Clicked") 'Number 5 Help
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "6"
        Else
            AnswerBox.Text += "6"   'number 6
        End If
        ShowHelpMessage("Number 6 Clicked") 'Number 6 Help
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "7"
        Else
            AnswerBox.Text += "7"   'number 7
        End If
        ShowHelpMessage("Number 7 Clicked") 'Number 7 Help
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "8"
        Else
            AnswerBox.Text += "8"   'number 8
        End If
        ShowHelpMessage("Number 8 Clicked") 'Number 8 Help
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "9"
        Else
            AnswerBox.Text += "9" 'number 9
        End If
        ShowHelpMessage("Number 9 Clicked") 'Number 9 Help
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If AnswerBox.Text <> "0" Then
            AnswerBox.Text += "0"   'number 0
        End If
        ShowHelpMessage("Number 0 Clicked") 'Number 0 Help
    End Sub

    'End of the number buttons in the calculator


    Private Sub BtnDecimalpoint_Click(sender As Object, e As EventArgs) Handles BtnDecimalpoint.Click
        AnswerBox.Text = AnswerBox.Text & (".") 'decimal poing (.) used for decimal numbers
        ShowHelpMessage("Dec-pt Clicked") 'Number Decimal-Point (Dec-pt is a short form of Decimal Point) Help
    End Sub     'the decimal point didn't work in the first go then I looked into the code deeply and made the chnage therefore it workerd as i forget to put the (&) sign.

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        Firstnum = AnswerBox.Text
        AnswerBox.Text = "0"
        Operator_selector = True
        Operations = 1 ' = + this is the button to add
        ShowHelpMessage("Add Clicked") 'Add Help
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        Firstnum = AnswerBox.Text
        AnswerBox.Text = "0"
        Operator_selector = True
        Operations = 2 ' = - this is the button to subtract
        ShowHelpMessage("Subtract Clicked") 'Subtract Help
    End Sub

    Private Sub BtnTimes_Click(sender As Object, e As EventArgs) Handles BtnTimes.Click
        Firstnum = AnswerBox.Text
        AnswerBox.Text = "0"
        Operator_selector = True
        Operations = 3 ' = x this is the button to multiply
        ShowHelpMessage("Multiply Clicked") 'Multiply Help
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        Firstnum = AnswerBox.Text
        AnswerBox.Text = "0"
        Operator_selector = True
        Operations = 4 ' = / this is the button to divide
        ShowHelpMessage("Divide Clicked") 'Divide Help
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        AnswerBox.Clear() 'anyting in the answer box is clered instantly after pressing this button
        ShowHelpMessage("AnswerBox Cleared") 'AnswerBox Cleared Help
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show() 'This buttone navigates to the main menu
        ShowHelpMessage("Main Menu") 'Main Menu Help
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click '= equals button
        If Operator_selector = True Then
            Secondnum = AnswerBox.Text
            If Operations = 1 Then
                AnswerBox.Text = Firstnum + Secondnum
            ElseIf Operations = 2 Then
                AnswerBox.Text = Firstnum - Secondnum
            ElseIf Operations = 3 Then
                AnswerBox.Text = Firstnum * Secondnum
            Else
                If Secondnum = 0 Then
                    AnswerBox.Text = "404Error!" 'shows an error message if used incorrectely 
                Else
                    AnswerBox.Text = Firstnum / Secondnum
                End If      'these are the varibles being used after they've been declayred
            End If
            Operator_selector = False
        End If
        ShowHelpMessage("The Answer") 'Answer Help
    End Sub

    'On-Screen Help 
    Private Sub ShowHelpMessage(ByVal strHelpMsg As String)
        LBL2.Text = strHelpMsg
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close() 'the form closes 
    End Sub


    ' Second section strats after making an improvemnt. 
    ' This second section is about video player.
    ' The code below shows the code for opening the video from the hard drive.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        ShowHelpMessage("The video is appering")
    End Sub

    ' This is when the video needs to be closed.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        ShowHelpMessage("Form Closes")
    End Sub

    ' I've have made improvements to this form. I had to chnage the colour to light dark grey because the video player was balck. 
End Class