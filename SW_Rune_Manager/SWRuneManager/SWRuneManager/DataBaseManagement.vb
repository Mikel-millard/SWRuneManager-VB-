'Class to control all the database actions, sql commands and creating and closing the database connection

Imports System.Data.OleDb 'Imports the OleDb database

Public Class DataBaseManagement
    'Class Variables
    Dim con As New OleDbConnection 'connection for the database
    Dim cmd As New OleDbCommand 'command variable for running the sql command
    Dim strSQL As String 'string to store the sql command
    Public dataReader As OleDbDataReader 'datareader to get the correct runes to display

    'Creates and opens a database connection
    Public Sub CreateDBConnection()
        con = New OleDbConnection("PROVIDER = Microsoft.Jet.OLEDB.4.0; Data Source = E:\CS 367\SW_Rune_Manager\SWRuneManager\RuneDatabase.mdb")
        con.Open()
    End Sub

    'Closes the database connection
    Public Sub CloseDBConnection()
        con.Close()
    End Sub

    'Sub routine to import the CSV file of runes to the database
    Public Sub CSVImport(ByVal file As String)
        'Try catch block to catch any exceptions with the parsing of the file
        Try
            Using ioReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(file) 'parses the file
                DeleteTable() 'deletes any information currently in the database so that the import goes smoothly
                ioReader.TextFieldType = FileIO.FieldType.Delimited
                ioReader.SetDelimiters(",") 'sets the delimiter to , so it can find the correct fields in the file
                While Not ioReader.EndOfData 'runs the loop unitl we arrive at the end of the file
                    Dim fileCurrentRow As String() = ioReader.ReadFields() 'stores the current row in an array of strings

                    'Variables to go through the array and get the correct strings for the variable
                    Dim runeID, equipped, runeSet, slot, stars, level, price, primary, prefix, sub1, sub2, sub3, sub4, effeciency As String
                    runeID = fileCurrentRow(0)
                    equipped = fileCurrentRow(1)
                    runeSet = fileCurrentRow(2)
                    slot = fileCurrentRow(3)
                    stars = fileCurrentRow(4)
                    level = fileCurrentRow(5)
                    price = fileCurrentRow(6)
                    primary = fileCurrentRow(7)
                    prefix = fileCurrentRow(8)
                    sub1 = fileCurrentRow(9)
                    sub2 = fileCurrentRow(10)
                    sub3 = fileCurrentRow(11)
                    sub4 = fileCurrentRow(12)
                    effeciency = fileCurrentRow(13)

                    'SQL statement to insert the current row of information into the database
                    strSQL = "INSERT INTO RunesV2 VALUES (" + runeID + ",'" + equipped + "','" + runeSet + "'," + slot + "," + stars + "," + level + "," +
                    price + ",'" + primary + "','" + prefix + "','" + sub1 + "','" + sub2 + "','" + sub3 + "','" + sub4 + "','" + effeciency + "'" + ")"

                    'Executes the SQL command
                    cmd = New OleDbCommand(strSQL, con)
                    cmd.ExecuteNonQuery()
                End While 'Not ioReader.EndofData while end

            End Using 'ioReader using end

            'Gives a success message if the import went smoothly
            MsgBox("Runes successfully imported.", 0, "Runes Imported")

            'Moves to the rune manager form
            ImportForm.Hide()
            RuneManagerV2.Show()
        Catch ex As Exception
            'Gives error message if the file wasn't a valid file to import
            MsgBox("Please select a valid file .CSV before continuing.", 0, "Import Error")
        End Try 'import csv try//catch end

    End Sub 'CSVImport() sub end

    'Sub routine for maunually importing each rune into the database, takes the required fields as arguments
    Public Sub ManualImport(runeID As String, equipped As String, runeSet As String, slot As String, stars As String, level As String,
                            price As String, primary As String, prefix As String, sub1 As String, sub2 As String, sub3 As String,
                            sub4 As String, effeciency As String)

        'SQL statement to insert the information into the database
        strSQL = "INSERT INTO RunesV2 VALUES (" + runeID + ",'" + equipped + "','" + runeSet + "'," + slot + "," + stars + "," + level + ",'" +
                    price + "','" + primary + "','" + prefix + "','" + sub1 + "','" + sub2 + "','" + sub3 + "','" + sub4 + "','" + effeciency + "'" + ")"

        'Executes the database command
        cmd = New OleDbCommand(strSQL, con)
        cmd.ExecuteNonQuery()

        'Success message when the import is successful
        MsgBox("Rune successfully entered into the database", 0, "Rune Entered")
    End Sub 'ManualImport() sub end

    'Sub routine to delete the information in the current table
    Public Sub DeleteTable()
        'SQL statement to delete
        strSQL = "DELETE * FROM RunesV2"

        'Executes the SQL statement
        cmd = New OleDbCommand(strSQL, con)
        cmd.ExecuteNonQuery()

        'Succcess message
        MsgBox("Database entries successfully deleted.", 0, "Entries Deleted")
    End Sub 'DeleteTable() sub end

    'Allows the Rune Display form to get the right rune information from the database
    Public Sub ViewRunes()
        'Select statement to get the correct rune information
        strSQL = "SELECT Rune_ID, Slot, Primary_Effect, Prefix_Effect, Substat_1, Substat_2, Substat_3, Substat_4, Effeciency FROM RunesV2 WHERE Category = '" +
            RuneManagerV2.selectedRune + "'"

        'Executes the SQL command
        cmd = New OleDbCommand(strSQL, con)
        dataReader = cmd.ExecuteReader()
    End Sub 'ViewRunes() sub end

    'Allows the user to move selected runes to the trash and updates the table to reflect that
    Public Sub MoveToTrash(runeID As String)
        'SQL update command
        strSQL = "UPDATE RunesV2 SET Category = 'Trash' WHERE Rune_ID = " + runeID

        'Executes the SQL command
        cmd = New OleDbCommand(strSQL, con)
        cmd.ExecuteNonQuery()
    End Sub 'MoveToTrash() sub end

    'Allows the user to delete the trash runes when they are ready to and deletes them from the database as well
    Public Sub DeleteTrashRunes()
        'Delete SQL command
        strSQL = "DELETE * FROM RunesV2 WHERE Category = 'Trash'"

        'Executes the SQL command
        cmd = New OleDbCommand(strSQL, con)
        cmd.ExecuteNonQuery()
    End Sub 'DeleteTrashRunes() sub

End Class 'End of database management class
