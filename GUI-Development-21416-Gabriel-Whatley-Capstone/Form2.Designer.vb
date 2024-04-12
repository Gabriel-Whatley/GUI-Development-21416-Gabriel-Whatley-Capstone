<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DateTimePicker = New DateTimePicker()
        btn_okay = New Button()
        btn_cancel = New Button()
        SuspendLayout()
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Location = New Point(54, 52)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(200, 23)
        DateTimePicker.TabIndex = 0
        ' 
        ' btn_okay
        ' 
        btn_okay.Location = New Point(179, 116)
        btn_okay.Name = "btn_okay"
        btn_okay.Size = New Size(75, 23)
        btn_okay.TabIndex = 1
        btn_okay.Text = "Okay"
        btn_okay.UseVisualStyleBackColor = True
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Location = New Point(54, 116)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(75, 23)
        btn_cancel.TabIndex = 2
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(314, 187)
        ControlBox = False
        Controls.Add(btn_cancel)
        Controls.Add(btn_okay)
        Controls.Add(DateTimePicker)
        Name = "Form2"
        Text = "Add A Date"
        ResumeLayout(False)
    End Sub

    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents btn_okay As Button
    Friend WithEvents btn_cancel As Button
End Class
