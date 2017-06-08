'RuneManager class allows the user to select which runes they would like to view

Public Class RuneManagerV2
    'Variables
    Dim selected As Object
    Public selectedRune As String
    Dim database As New DataBaseManagement 'instantiates a new database of type DataBaseManagement to access its methods
    Public runeIDArray(200) As String 'array to hold the number of runes to be shown in the next form

    'Allows the user to select a type of rune to view, and then goes to a new form to see the runes of that type
    Private Sub ViewBtn_Click(sender As Object, e As EventArgs) Handles ViewBtn.Click
        RuneDisplay.FormNameLbl.Text = selectedRune + " Runes:" 'Changes the name of the runedisplay form depending on which rune type was selected

        database.CreateDBConnection() 'opens database connection
        database.ViewRunes() 'runs the view runes method from the DataBaseManagement Class

        Dim count = database.dataReader.FieldCount() 'Finds out how many things are in the datareader
        Dim iterations As Integer = 1 'how many iterations have gone through
        runeIDArray(0) = "0" 'sets the first rune id in the array to 0
        If database.dataReader.HasRows Then 'if there are still rows in the reader
            Do While database.dataReader.Read() 'while the reader can still read the rows
                Dim runeInformation As String = "" 'reset the runeInformation variable
                runeIDArray(iterations) = database.dataReader.GetValue(0).ToString() 'Put the rune ID from the reader into the array
                For i = 1 To count - 1 Step 1 'for statement to iterate through the rest of the reader
                    runeInformation &= database.dataReader.GetValue(i).ToString() + ", " 'append the rune information string with the information from the reader
                Next 'For loop
                iterations += 1 'increment number of iterations
                RuneDisplay.ListView1.Items.Add(runeInformation) 'add the information from the reader to the listview
            Loop 'Do While loop
        End If 'If database.datareader.HasRows end

        database.dataReader.Close() 'close the datareader
        database.CloseDBConnection() 'close the database connection
        Me.Hide() 'hide this form
        RuneDisplay.Show() 'go to the rune display form
    End Sub 'ViewBtn Click event end

    'Fills the slectedRune variable with the currently selected type whenever the combo box value is changed
    Private Sub RunesCmbBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RunesCmbBx.SelectedIndexChanged
        selected = RunesCmbBx.SelectedItem 'get the selection as an object
        selectedRune = selected.ToString() 'change that object to a string
    End Sub 'RunesCmbBx Changed event end

    'Exits the application when the user closes it
    Private Sub RuneManagerV2_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub 'RuneManagerV2 Closing event end

    'Changes the name of the form and centers it upon loading
    Private Sub RuneManagerV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Rune Manager"
        Me.CenterToScreen()
    End Sub 'RuneManagerV2 Load event end

End Class 'RuneManagerV2 Class end