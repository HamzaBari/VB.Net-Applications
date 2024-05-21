Public Class WebEditor
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles Textarea1.TextChanged
        WebBrowser1.DocumentText = (Textarea1.Text)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Textarea1.Clear()
        'This is where you clear the notepad 
    End Sub

    'All of these are loated within the menu strip
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim dlg As SaveFileDialog = New SaveFileDialog  'declayring the varible 
            dlg.Title = "Save"      'adding the correct name on the menu
            dlg.Filter = "html (*.html)|*.html"
            'saving in what file
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Textarea1.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
            End If
        Catch ex As Exception : End Try
    End Sub 'press this to save the file.

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "html (*.html)|*.html"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Textarea1.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception : End Try
    End Sub 'press this to open a new file.

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Textarea1.Cut()  'Cut the text in the textarea
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Textarea1.Copy() 'Copy the text in the textarea
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Textarea1.Paste() 'Paste the text in the textarea
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Textarea1.Undo() 'Undo the text in the textarea
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        Textarea1.Redo() 'Redo the text in the textarea
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog  'declare the varible 
            dlg.Font = Textarea1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Textarea1.Font = dlg.Font
            End If
        Catch ex As Exception : End Try
    End Sub      'change the font of the text

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog    'declare the varible 
            dlg.Color = Textarea1.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Textarea1.ForeColor = dlg.Color
            End If
        Catch ex As Exception : End Try
    End Sub     'change the colour of the text

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Textarea1.SelectAll() 'select all in the text area
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreview1.Show() 'show print preview
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Print1.ShowDialog() 'print the document 'there was an error but, I fixed it by adding the correct dialog name.
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        MainMenu.Show() 'open main menu
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Close()
    End Sub
End Class