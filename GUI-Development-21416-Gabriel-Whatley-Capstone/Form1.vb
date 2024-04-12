'Name: Gabriel Whatley - gabriel.whatley@gmail.com
'Date: 4/12/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Capstone program that calculates and displays the number of days between 5 user supplied dates and today's date.

Imports System.Text.Json
Public Class Form1

    Dim writer As System.IO.StreamWriter
    Dim reader As System.IO.StreamReader

    Dim db_file_name As String ' Global variable to support changing the DB file location mid-run.

    Public date_list As New List(Of Date) ' Create a list of Date objects to store our 5 dates in.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        db_file_name = "database.ddb"

        If IO.File.Exists(db_file_name) = True Then ' Check to make sure the savings.txt file exists.
            readFile(db_file_name)
        Else
            IO.File.Create(db_file_name) 'Create the DDB file if it doesn't already exist.
        End If

        UpdateListBox()
    End Sub

    Private Sub readFile(file_name As String)
        reader = New IO.StreamReader(file_name) ' Instantiate a reader object and store it in reader.
        Dim lines As String = reader.ReadLine() ' Store the data read from the file in a variable.
        reader.Close() ' Close the reader
        Try
            date_list = JsonSerializer.Deserialize(Of List(Of Date))(lines) ' Read the entire file into an array split by newline characters.
        Catch ex As System.ArgumentNullException ' Catch the exception where the database file is empty and JsonSerializer has nothing to serialize.
            MsgBox("The database file is currently empty. Do not be alarmed.", 1, "Helpful Message") ' Display a helpful and calming message to the user :^)
        End Try
    End Sub

    Private Sub WriteFile(date_list As List(Of Date), file_name As String)
        writer = New IO.StreamWriter(file_name)
        writer.WriteLine(JsonSerializer.Serialize(date_list))
        writer.Close()
    End Sub

    Public Sub AddDate(new_date As Date)
        date_list.Add(new_date) ' Add the new date to the date list.
        UpdateListBox() ' Update the listbox to show the newly added date.
    End Sub

    Public Sub RemoveDate(remove_index)
        date_list.RemoveAt(remove_index) ' Removes the date at the specified index in the date_list
        UpdateListBox() ' Update the listbox display to reflect the deleted date.
    End Sub

    Private Sub UpdateListBox()
        ListBox1.Items.Clear() ' Remove the current items in the listbox so they can be refreshed.
        For Each d In date_list ' Iterate through the date_list.
            ListBox1.Items.Add(CalculateDays(d)) ' Generate the calculation strings and add them to the listbox.
        Next
    End Sub

    Private Function CalculateDays(start_date As Date)
        Dim diff As Long = DateAndTime.DateDiff(DateInterval.Day, start_date, Date.Now) ' Calculate the difference in days between the two days.
        Dim output_string = $"{diff} days since {start_date:d}" ' Generate a string using the diff and a formatted date string.
        Return output_string
    End Function

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If date_list.Count >= 5 Then ' If there are too many dates in the database warn the user that they can't add without deleting.
            MsgBox("Sorry, there are already 5 dates, you will need to remove one.")
            Exit Sub
        End If
        Form2.ShowDialog() ' Show the modal dialog for adding dates.
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If date_list.Count <= 0 Then ' If there are no dates in the database warn the user that they cannot delete.
            MsgBox("Sorry, there aren't any dates to remove, you will need to add one.")
            Exit Sub
        End If
        Form3.ShowDialog() ' Show the modal dialog for removing dates.
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        WriteFile(date_list, db_file_name) ' Save the DB file before closing
        Close() ' Shut it down!
    End Sub

    Private Sub NewDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDatabaseToolStripMenuItem.Click

    End Sub
End Class