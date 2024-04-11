<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lbl_day_1 = New Label()
        lbl_day_2 = New Label()
        lbl_day_3 = New Label()
        lbl_day_4 = New Label()
        lbl_day_5 = New Label()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        AddANewDayToolStripMenuItem = New ToolStripMenuItem()
        OpenDatabaseToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(196, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(409, 37)
        Label1.TabIndex = 0
        Label1.Text = "How many days has it been!?!?"
        ' 
        ' lbl_day_1
        ' 
        lbl_day_1.AutoSize = True
        lbl_day_1.Location = New Point(380, 100)
        lbl_day_1.Name = "lbl_day_1"
        lbl_day_1.Size = New Size(41, 15)
        lbl_day_1.TabIndex = 1
        lbl_day_1.Text = "Label2"
        ' 
        ' lbl_day_2
        ' 
        lbl_day_2.AutoSize = True
        lbl_day_2.Location = New Point(380, 115)
        lbl_day_2.Name = "lbl_day_2"
        lbl_day_2.Size = New Size(41, 15)
        lbl_day_2.TabIndex = 2
        lbl_day_2.Text = "Label3"
        ' 
        ' lbl_day_3
        ' 
        lbl_day_3.AutoSize = True
        lbl_day_3.Location = New Point(380, 130)
        lbl_day_3.Name = "lbl_day_3"
        lbl_day_3.Size = New Size(41, 15)
        lbl_day_3.TabIndex = 3
        lbl_day_3.Text = "Label4"
        ' 
        ' lbl_day_4
        ' 
        lbl_day_4.AutoSize = True
        lbl_day_4.Location = New Point(380, 145)
        lbl_day_4.Name = "lbl_day_4"
        lbl_day_4.Size = New Size(41, 15)
        lbl_day_4.TabIndex = 4
        lbl_day_4.Text = "Label5"
        ' 
        ' lbl_day_5
        ' 
        lbl_day_5.AutoSize = True
        lbl_day_5.Location = New Point(380, 160)
        lbl_day_5.Name = "lbl_day_5"
        lbl_day_5.Size = New Size(41, 15)
        lbl_day_5.TabIndex = 5
        lbl_day_5.Text = "Label6"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddANewDayToolStripMenuItem, OpenDatabaseToolStripMenuItem, QuitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' AddANewDayToolStripMenuItem
        ' 
        AddANewDayToolStripMenuItem.Name = "AddANewDayToolStripMenuItem"
        AddANewDayToolStripMenuItem.Size = New Size(180, 22)
        AddANewDayToolStripMenuItem.Text = "Add a new day"
        ' 
        ' OpenDatabaseToolStripMenuItem
        ' 
        OpenDatabaseToolStripMenuItem.Name = "OpenDatabaseToolStripMenuItem"
        OpenDatabaseToolStripMenuItem.Size = New Size(180, 22)
        OpenDatabaseToolStripMenuItem.Text = "Open Database"
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(180, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_day_5)
        Controls.Add(lbl_day_4)
        Controls.Add(lbl_day_3)
        Controls.Add(lbl_day_2)
        Controls.Add(lbl_day_1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_day_1 As Label
    Friend WithEvents lbl_day_2 As Label
    Friend WithEvents lbl_day_3 As Label
    Friend WithEvents lbl_day_4 As Label
    Friend WithEvents lbl_day_5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddANewDayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem

End Class
