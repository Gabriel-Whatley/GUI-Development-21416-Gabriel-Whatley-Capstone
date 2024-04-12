'Name: Gabriel Whatley - gabriel.whatley@gmail.com
'Date: 4/12/24
'Class: CPSC 3118 - Graphical User Interface Development - CRN:21416
'Instructor: Bruce Montgomery
'Program Description: Capstone program that calculates and displays the number of days between 5 user supplied dates and today's date.
'I know the UI isn't very attractive but I feel like the effort put into the serializing and file saving functionality is more important
'to the usefulness of the application.

Imports System.IO
Imports System.Text.Json

Public Class Form1

    Dim writer As System.IO.StreamWriter
    Dim reader As System.IO.StreamReader

    Dim db_file_name As String ' Global variable to support changing the DB file location mid-run.

    Public date_list As New List(Of Date) ' Create a list of Date objects to store our 5 dates in.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        db_file_name = "database.ddb" ' Default to database.ddb when first opened.

        If IO.File.Exists(db_file_name) = False Then ' Check to make sure the savings.txt file exists.
            Dim file As FileStream = IO.File.Create(db_file_name) 'Create the DDB file if it doesn't already exist.
            file.Close() ' Close the newly created file.
            WriteFile(date_list, db_file_name)
        End If

        ReadFile(db_file_name) ' Read the database file on load.

        UpdateListBox() ' Update the list box.
    End Sub

    Private Sub ReadFile(file_name As String)
        reader = New IO.StreamReader(file_name) ' Instantiate a reader object and store it in reader.
        Dim lines As String = reader.ReadLine() ' Store the data read from the file in a variable.
        reader.Close() ' Close the reader
        Try
            date_list = JsonSerializer.Deserialize(Of List(Of Date))(lines) ' Read the entire file into an array split by newline characters.
        Catch ex As System.ArgumentNullException
            System.Diagnostics.Debug.WriteLine("Error has occurred: " + ex.ToString) ' If jsonserialiser complains about an empty file ignore it but write to the debug console just in case.
        End Try
    End Sub

    Private Sub WriteFile(date_list As List(Of Date), file_name As String)
        writer = New IO.StreamWriter(file_name) ' Create a writer to write the file.
        writer.WriteLine(JsonSerializer.Serialize(date_list)) ' Serialize the date_list to JSON so it can be written to the file.
        writer.Close() ' Close the writer when it's done.
    End Sub

    Public Sub AddDate(new_date As Date)
        date_list.Add(new_date) ' Add the new date to the date list.
        UpdateListBox() ' Update the listbox to show the newly added date.
    End Sub

    Public Sub RemoveDate(remove_index)
        date_list.RemoveAt(remove_index) ' Removes the date at the specified index in the date_list.
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
            MsgBox("Sorry, there are already 5 dates, you will need to remove one.", "Warning")
            Exit Sub
        End If
        Form2.ShowDialog() ' Show the modal dialog for adding dates.
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        If date_list.Count <= 0 Then ' If there are no dates in the database warn the user that they cannot delete.
            MsgBox("Sorry, there aren't any dates to remove, you will need to add one.", "Warning")
            Exit Sub
        End If
        Form3.ShowDialog() ' Show the modal dialog for removing dates.
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        WriteFile(date_list, db_file_name) ' Save the DB file before closing.
        Close() ' Shut it down!
    End Sub

    Private Sub NewDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDatabaseToolStripMenuItem.Click
        Dim fd As SaveFileDialog = New SaveFileDialog() ' Open the save file dialog, only allow users to save .ddb (Date Database) files.

        fd.Title = "Save Database File"
        fd.InitialDirectory = My.Application.Info.DirectoryPath
        fd.Filter = "Date Database Files (*.ddb)|*.ddb"
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            WriteFile(date_list, fd.FileName) ' Write the file to the new file name.
        End If
    End Sub

    Private Sub OpenDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaseToolStripMenuItem.Click
        Dim fd As OpenFileDialog = New OpenFileDialog() ' Open the open file dialog, only allow users to select .ddb (Date Database) files.

        fd.Title = "Open Database File"
        fd.InitialDirectory = My.Application.Info.DirectoryPath
        fd.Filter = "Date Database Files (*.ddb)|*.ddb"
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            db_file_name = fd.FileName
        End If
        ReadFile(db_file_name) ' Read the newly selected file.
        UpdateListBox() ' Update the listbox with the contents.
    End Sub
End Class