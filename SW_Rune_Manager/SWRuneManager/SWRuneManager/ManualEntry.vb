'Manual Entry Form allows the user to manually enter their runes into the database

Public Class ManualEntry
    'Instantiates a new database variable of DataBaseManagement class to have access to it's methods
    Dim database As New DataBaseManagement

    Dim iterations As Integer

    'Returns the user to the CSV import form
    Private Sub CSVImpBtn_Click(sender As Object, e As EventArgs) Handles CSVImpBtn.Click
        Me.Hide()
        ImportForm.Show()
    End Sub 'CSVImpBtn Click end

    'Moves the user to the rune management form
    Private Sub RuneMngBtn_Click(sender As Object, e As EventArgs) Handles RuneMngBtn.Click
        Me.Hide()
        RuneManagerV2.Show()
    End Sub 'RuneMngBtn Click even end

    'Exits the application if the user closes the window
    Private Sub ManualEntry_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub 'ManualEntry Closing sub end

    'Saves the rune information into the database as a new rune
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        'Variables and statements to assign the correct values to the variables
        Dim slot, stars, level As String
        Dim runeID = iterations
        Dim equipped = "Not Applicable"
        Dim runeSet = SetCmbBx.Text
        If SlotNum.Value > 0 OrElse SlotNum.Value <= 6 Then
            slot = SlotNum.Value
        Else
            slot = 0
        End If
        If StarsNum.Value > 0 OrElse StarsNum.Value <= 6 Then
            stars = SlotNum.Value
        Else
            stars = 0
        End If
        If LevelNum.Value >= 0 OrElse LevelNum.Value <= 15 Then
            level = LevelNum.Value
        Else
            level = 0
        End If
        Dim price = "Not Applicable"
        Dim primary = MainStatCmbBx.Text
        Dim prefix = "Not Applicable"
        Dim sub1 = Sub1CmbBx.Text + Sub1ValTxt.Text
        Dim sub2 = Sub2CmbBx.Text + Sub2ValTxt.Text
        Dim sub3 = Sub3CmbBx.Text + Sub3ValTxt.Text
        Dim sub4 = Sub4CmbBox.Text + Sub4ValTxt.Text
        Dim effeciency = "Not Applicable"

        'Makes the database connection, runes the sql command to insert the information, and then closes the connection
        database.CreateDBConnection()
        database.ManualImport(runeID, equipped, runeSet, slot, stars, level, price, primary, prefix, sub1, sub2, sub3, sub4, effeciency)
        database.CloseDBConnection()
        iterations += 1
    End Sub 'SaveBtn Click event end

    'Centers the form and renames the text on the title bar upon loading the form
    Private Sub ManualEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Rune Entry"
        Me.CenterToScreen()
        iterations = 1
    End Sub 'ManualEntry Load sub end


End Class 'ManualEntry Class end