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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewDatabaseToolStripMenuItem = New ToolStripMenuItem()
        OpenDatabaseToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        DatesToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        RemoveToolStripMenuItem = New ToolStripMenuItem()
        ListBox1 = New ListBox()
        ToolStripSeparator1 = New ToolStripSeparator()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(109, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 74)
        Label1.TabIndex = 0
        Label1.Text = "How many days" & vbCrLf & "have elapsed?"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, DatesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(440, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenDatabaseToolStripMenuItem, NewDatabaseToolStripMenuItem, ToolStripSeparator1, QuitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewDatabaseToolStripMenuItem
        ' 
        NewDatabaseToolStripMenuItem.Name = "NewDatabaseToolStripMenuItem"
        NewDatabaseToolStripMenuItem.Size = New Size(180, 22)
        NewDatabaseToolStripMenuItem.Text = "Save As"
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
        ' DatesToolStripMenuItem
        ' 
        DatesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, RemoveToolStripMenuItem})
        DatesToolStripMenuItem.Name = "DatesToolStripMenuItem"
        DatesToolStripMenuItem.Size = New Size(48, 20)
        DatesToolStripMenuItem.Text = "Dates"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(180, 22)
        NewToolStripMenuItem.Text = "Add"
        ' 
        ' RemoveToolStripMenuItem
        ' 
        RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        RemoveToolStripMenuItem.Size = New Size(180, 22)
        RemoveToolStripMenuItem.Text = "Remove"
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 37
        ListBox1.Location = New Point(40, 146)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(360, 189)
        ListBox1.TabIndex = 7
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(177, 6)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 355)
        ControlBox = False
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "How Many Days?"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents NewDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator

End Class
