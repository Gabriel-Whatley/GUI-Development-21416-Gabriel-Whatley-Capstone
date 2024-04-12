<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        btn_cancel = New Button()
        btn_okay = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label1.Location = New Point(31, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 37)
        Label1.TabIndex = 0
        Label1.Text = "Select a date to remove"
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Location = New Point(91, 167)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(75, 23)
        btn_cancel.TabIndex = 4
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' btn_okay
        ' 
        btn_okay.Location = New Point(216, 167)
        btn_okay.Name = "btn_okay"
        btn_okay.Size = New Size(75, 23)
        btn_okay.TabIndex = 3
        btn_okay.Text = "Okay"
        btn_okay.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(100, 63)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(161, 79)
        ListBox1.TabIndex = 5
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 214)
        ControlBox = False
        Controls.Add(ListBox1)
        Controls.Add(btn_cancel)
        Controls.Add(btn_okay)
        Controls.Add(Label1)
        Name = "Form3"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Remove a date"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_okay As Button
    Friend WithEvents ListBox1 As ListBox
End Class
