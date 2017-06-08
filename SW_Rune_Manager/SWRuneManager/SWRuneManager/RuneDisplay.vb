'Rune Display Class for displaying the runes the user wants to see

Public Class RuneDisplay
    'Variables
    Dim database As New DataBaseManagement 'Instantiates a new database of type DataBaseManagement to access its methods
    Dim runeType As String 'Stores the rune type selected from the previous form

    'Allows the user to return to the rune management form
    Private Sub RuneMngBtn_Click(sender As Object, e As EventArgs) Handles RuneMngBtn.Click
        ListView1.Items.Clear()
        Me.Close()
    End Sub 'RuneMngBtn Click event end

    'Changes the name of the form and the name of the top label denpending on what rune type the user selected, also stores the
    'selected rune type in a local variable. Will show a different button option if the user selects the trash runes to view
    Private Sub RuneDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        runeType = RuneManagerV2.selectedRune 'local variable for the type of rune selected

        'Changes the button text if the selected type is TRASH
        If runeType = "TRASH" Then
            TrashBtn.Text = "Delete Trash Runes"
        End If
        Me.Text = runeType + " Runes"
        Me.CenterToScreen()
    End Sub 'RuneDisplay Load event end

    'Moves the selected runes to the trash bin, or deletes the trash runes from the database if the user chose to view
    'the trash runes in the earlier form
    Private Sub TrashBtn_Click(sender As Object, e As EventArgs) Handles TrashBtn.Click
        database.CreateDBConnection() 'opens database connection

        'If trash runes were selected, change the function of the button
        If runeType = "TRASH" Then
            database.DeleteTrashRunes()
            MsgBox("Runes successfully deleted.", 0, "Runes Deleted") 'successful deletion
            ListView1.Items.Clear() 'clears the list box
            Me.Close() 'closes for form to return to the rune manager form
        Else 'else the button allows the user to move selected runes to the trash
            For i = 0 To ListView1.Items.Count - 1 Step 1
                If ListView1.Items(i).Checked = True Then
                    database.MoveToTrash(RuneManagerV2.runeIDArray(i + 1)) 'moves selected runes to the trash, using an sql update command
                End If
            Next
            MsgBox("Runes successfully moved.", 0, "Runes Moved") 'successfully moved
            ListView1.Items.Clear() 'clears the listview
            Me.Close() 'closes the form to return to the previous form
        End If

        database.CloseDBConnection() 'closes the database connection
    End Sub 'TrashBtn Click event end

    'Shows the rune manager upon this form closing
    Private Sub RuneDisplay_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        RuneManagerV2.Show()
    End Sub 'RuneDisplay Closing event end

End Class 'RuneDisplay Class end