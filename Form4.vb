Public Class Notepad

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextArea.Clear()  'This is where you clear the notepad 
        ClearLBL.Text = "Cleared"
    End Sub

    'All of these are loated within the menu strip
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog  'declayring the varible 
            dlg.Title = "Save"      'adding the correct name on the menu
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"    'saving in what file
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                TextArea.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try
        ShowHelpMessage("Notepad Saved") 'Save Help Message
    End Sub 'press this to save the file.

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                TextArea.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception : End Try
        ShowHelpMessage("Opned New Notepad") 'Opening New Notepad Help Message
    End Sub 'press this to open a new file.

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextArea.Cut()  'Cut the text in the textarea
        ShowHelpMessage("Text Cutted") 'Cut Help Message
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextArea.Copy() 'Copy the text in the textarea
        ShowHelpMessage("Text Copied") 'Copied Help Message
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextArea.Paste() 'Paste the text in the textarea
        ShowHelpMessage("Text Pasted") 'Pasted Help Message
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextArea.Undo() 'Undo the text in the textarea
        ShowHelpMessage("Undo - go back to normal") 'Undo Help Message
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        TextArea.Redo() 'Redo the text in the textarea
        ShowHelpMessage("Redo - go back to Before") 'Redo Help Message
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog  'declare the varible 
            dlg.Font = TextArea.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                TextArea.Font = dlg.Font
            End If
        Catch ex As Exception : End Try
        ShowHelpMessage("Font Changed") 'Font Help Message
    End Sub     'change the colour of the font e.g. bold

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog    'declare the varible 
            dlg.Color = TextArea.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                TextArea.ForeColor = dlg.Color
            End If
        Catch ex As Exception : End Try
        ShowHelpMessage("Font Colour Changed") 'Font Colour Help Message
    End Sub     'change the colour of the text

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextArea.SelectAll() 'select all in the text area
        ShowHelpMessage("All Text Highlighted") 'Select All Help Message
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreview1.Show() 'show print preview
        ShowHelpMessage("Print Preview PDF") 'Print Preview Help Message
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Print1.ShowDialog() 'print the document 'there was an error but, I fixed it by adding the correct dialog name.
        ShowHelpMessage("Notepad Page Printed") 'Print Help Message
    End Sub

    'On-Screen Help 
    Private Sub ShowHelpMessage(ByVal strHelpMsg As String)
        LBLHelp.Text = strHelpMsg
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        MainMenu.Show() 'open main menu
        ShowHelpMessage("Back to Main Menu") 'Main Menu Help Message
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Close() 'close the notepad
        ShowHelpMessage("Close the Notepad") 'Close Notepad Help Message
    End Sub

End Class