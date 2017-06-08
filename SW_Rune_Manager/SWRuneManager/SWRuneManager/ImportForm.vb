'ImportForm for the 

Public Class ImportForm
    'Instantiates a new database of DataBaseManagement type to have access to that class' methods
    Dim database As New DataBaseManagement

    'Moves the user to the the Manual Iport form after deleting the contents of the database
    Private Sub ManImpBtn_Click(sender As Object, e As EventArgs) Handles ManImpBtn.Click
        'Warning message that the current database contents will be deleted if the user continues
        If MessageBox.Show("This will delete the current runes in the database. Would you like to continue?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'If they select Yes, then the database is deleted and they move to the manual import form
            database.CreateDBConnection()
            database.DeleteTable()
            database.CloseDBConnection()
            Me.Hide()
            ManualEntry.Show()
        End If 'End warning if
    End Sub 'ManImpBtn Click event end

    'Imports the selected CSV file to the database
    Private Sub ImpFileBtn_Click(sender As Object, e As EventArgs) Handles ImpFileBtn.Click
        'Opens the connection, imports the selected file, then closes the connection
        database.CreateDBConnection()
        database.CSVImport(CSVFileTxt.Text)
        database.CloseDBConnection()
    End Sub 'ImpFileBtn Click event end

    'Allows the user to browse for a CSV file they want to import
    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        'Opens a dialog for the user to find the correct file and opens it
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            CSVFileTxt.Text = dialog.FileName
        End If 'End dialog result menu
    End Sub 'BrowseBtn Click event end

    'Moves the user to the rune management form
    Private Sub RuneManagementBtn_Click(sender As Object, e As EventArgs) Handles RuneManagementBtn.Click
        'Hides the current form and opens a new form
        Me.Hide()
        RuneManagerV2.Show()
    End Sub 'RuneManagementBtn Click event end

    'Exits the appliction when the user closes the form
    Private Sub ImportForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub 'ImportForm Closing event end

    'Changes the top bar text and centers the form on form load
    Private Sub ImportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Import CSV File"
        Me.CenterToScreen()
    End Sub 'ImportForm Load event end

End Class 'ImportForm Class end
