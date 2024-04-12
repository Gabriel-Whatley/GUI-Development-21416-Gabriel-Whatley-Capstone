Public Class Form2
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub btn_okay_Click(sender As Object, e As EventArgs) Handles btn_okay.Click
        Form1.AddDate(DateTimePicker.Value) ' Add the date value to the date_list
        Close()
    End Sub
End Class