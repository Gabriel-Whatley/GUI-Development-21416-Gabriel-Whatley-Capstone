Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear() ' Remove the current items in the listbox so they can be refreshed.
        For Each d In Form1.date_list ' Iterate through the date_list.
            ListBox1.Items.Add(d) ' Generate the calculation strings and add them to the listbox.
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub btn_okay_Click(sender As Object, e As EventArgs) Handles btn_okay.Click
        Form1.RemoveDate(ListBox1.SelectedIndex)
        Close()
    End Sub
End Class