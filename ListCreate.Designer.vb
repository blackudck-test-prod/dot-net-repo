<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListCreate
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
        CreateButton = New Button()
        Label1 = New Label()
        ListTypeComboBox = New ComboBox()
        Label2 = New Label()
        ListNameBox = New TextBox()
        ListSelectComboBox = New ComboBox()
        Label3 = New Label()
        CheckedListBox1 = New CheckedListBox()
        Label4 = New Label()
        RichTextBox1 = New RichTextBox()
        Label5 = New Label()
        RoutineButton = New RadioButton()
        SpecificButton = New RadioButton()
        ListType = New GroupBox()
        RoutinePanel = New Panel()
        StoreTextBox = New TextBox()
        Store = New Label()
        GroupBox1 = New GroupBox()
        MonthlyButton = New RadioButton()
        WeeklyButton = New RadioButton()
        DailyButton = New RadioButton()
        SpecificPanel = New Panel()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ListCancelButton = New Button()
        ListType.SuspendLayout()
        RoutinePanel.SuspendLayout()
        GroupBox1.SuspendLayout()
        SpecificPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' CreateButton
        ' 
        CreateButton.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        CreateButton.Location = New Point(179, 682)
        CreateButton.Name = "CreateButton"
        CreateButton.Size = New Size(166, 85)
        CreateButton.TabIndex = 0
        CreateButton.Text = "Create"
        CreateButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(88, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 32)
        Label1.TabIndex = 2
        Label1.Text = "Select list base"
        ' 
        ' ListTypeComboBox
        ' 
        ListTypeComboBox.FormattingEnabled = True
        ListTypeComboBox.Items.AddRange(New Object() {"Blank", "From Routine list", "From Recipe"})
        ListTypeComboBox.Location = New Point(108, 44)
        ListTypeComboBox.Name = "ListTypeComboBox"
        ListTypeComboBox.Size = New Size(121, 23)
        ListTypeComboBox.TabIndex = 1
        ListTypeComboBox.Text = "Type of list"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 654)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 25)
        Label2.TabIndex = 3
        Label2.Text = "List Name:"
        ' 
        ' ListNameBox
        ' 
        ListNameBox.Location = New Point(108, 659)
        ListNameBox.Name = "ListNameBox"
        ListNameBox.Size = New Size(230, 23)
        ListNameBox.TabIndex = 4
        ' 
        ' ListSelectComboBox
        ' 
        ListSelectComboBox.Enabled = False
        ListSelectComboBox.FormattingEnabled = True
        ListSelectComboBox.Location = New Point(102, 73)
        ListSelectComboBox.Name = "ListSelectComboBox"
        ListSelectComboBox.Size = New Size(243, 23)
        ListSelectComboBox.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 25)
        Label3.TabIndex = 6
        Label3.Text = "Base List:"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.Enabled = False
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(12, 141)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(326, 166)
        CheckedListBox1.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(102, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 25)
        Label4.TabIndex = 8
        Label4.Text = "Include Items"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 555)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(326, 96)
        RichTextBox1.TabIndex = 9
        RichTextBox1.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(135, 527)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 25)
        Label5.TabIndex = 10
        Label5.Text = "Purpose"
        ' 
        ' RoutineButton
        ' 
        RoutineButton.AutoSize = True
        RoutineButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        RoutineButton.Location = New Point(0, 28)
        RoutineButton.Name = "RoutineButton"
        RoutineButton.Size = New Size(137, 19)
        RoutineButton.TabIndex = 11
        RoutineButton.TabStop = True
        RoutineButton.Text = "Regular Shopping list"
        RoutineButton.UseVisualStyleBackColor = True
        ' 
        ' SpecificButton
        ' 
        SpecificButton.AutoSize = True
        SpecificButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        SpecificButton.Location = New Point(144, 28)
        SpecificButton.Name = "SpecificButton"
        SpecificButton.Size = New Size(137, 19)
        SpecificButton.TabIndex = 12
        SpecificButton.TabStop = True
        SpecificButton.Text = "Specific shopping list"
        SpecificButton.UseVisualStyleBackColor = True
        ' 
        ' ListType
        ' 
        ListType.Controls.Add(RoutineButton)
        ListType.Controls.Add(SpecificButton)
        ListType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListType.Location = New Point(12, 331)
        ListType.Name = "ListType"
        ListType.Size = New Size(326, 62)
        ListType.TabIndex = 13
        ListType.TabStop = False
        ListType.Text = "List Type"
        ' 
        ' RoutinePanel
        ' 
        RoutinePanel.Controls.Add(StoreTextBox)
        RoutinePanel.Controls.Add(Store)
        RoutinePanel.Controls.Add(GroupBox1)
        RoutinePanel.Location = New Point(272, 527)
        RoutinePanel.Name = "RoutinePanel"
        RoutinePanel.Size = New Size(326, 105)
        RoutinePanel.TabIndex = 14
        ' 
        ' StoreTextBox
        ' 
        StoreTextBox.Location = New Point(68, 69)
        StoreTextBox.Name = "StoreTextBox"
        StoreTextBox.Size = New Size(255, 23)
        StoreTextBox.TabIndex = 2
        StoreTextBox.Visible = False
        ' 
        ' Store
        ' 
        Store.AutoSize = True
        Store.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Store.Location = New Point(3, 66)
        Store.Name = "Store"
        Store.Size = New Size(59, 25)
        Store.TabIndex = 1
        Store.Text = "Store:"
        Store.Visible = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(MonthlyButton)
        GroupBox1.Controls.Add(WeeklyButton)
        GroupBox1.Controls.Add(DailyButton)
        GroupBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(320, 60)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Frequency"
        ' 
        ' MonthlyButton
        ' 
        MonthlyButton.AutoSize = True
        MonthlyButton.Location = New Point(189, 22)
        MonthlyButton.Name = "MonthlyButton"
        MonthlyButton.Size = New Size(100, 29)
        MonthlyButton.TabIndex = 2
        MonthlyButton.TabStop = True
        MonthlyButton.Text = "Monthly"
        MonthlyButton.UseVisualStyleBackColor = True
        ' 
        ' WeeklyButton
        ' 
        WeeklyButton.AutoSize = True
        WeeklyButton.Location = New Point(93, 22)
        WeeklyButton.Name = "WeeklyButton"
        WeeklyButton.Size = New Size(90, 29)
        WeeklyButton.TabIndex = 1
        WeeklyButton.TabStop = True
        WeeklyButton.Text = "Weekly"
        WeeklyButton.UseVisualStyleBackColor = True
        ' 
        ' DailyButton
        ' 
        DailyButton.AutoSize = True
        DailyButton.Location = New Point(12, 22)
        DailyButton.Name = "DailyButton"
        DailyButton.Size = New Size(72, 29)
        DailyButton.TabIndex = 0
        DailyButton.TabStop = True
        DailyButton.Text = "Daily"
        DailyButton.UseVisualStyleBackColor = True
        ' 
        ' SpecificPanel
        ' 
        SpecificPanel.Controls.Add(Label6)
        SpecificPanel.Controls.Add(DateTimePicker1)
        SpecificPanel.Location = New Point(12, 399)
        SpecificPanel.Name = "SpecificPanel"
        SpecificPanel.Size = New Size(326, 100)
        SpecificPanel.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(105, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 25)
        Label6.TabIndex = 1
        Label6.Text = "Shop Date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(63, 28)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 0
        ' 
        ' ListCancelButton
        ' 
        ListCancelButton.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        ListCancelButton.Location = New Point(12, 682)
        ListCancelButton.Name = "ListCancelButton"
        ListCancelButton.Size = New Size(161, 85)
        ListCancelButton.TabIndex = 16
        ListCancelButton.Text = "Cancel"
        ListCancelButton.UseVisualStyleBackColor = True
        ' 
        ' ListCreate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 774)
        Controls.Add(ListCancelButton)
        Controls.Add(SpecificPanel)
        Controls.Add(RoutinePanel)
        Controls.Add(ListType)
        Controls.Add(Label5)
        Controls.Add(RichTextBox1)
        Controls.Add(Label4)
        Controls.Add(CheckedListBox1)
        Controls.Add(Label3)
        Controls.Add(ListSelectComboBox)
        Controls.Add(ListNameBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListTypeComboBox)
        Controls.Add(CreateButton)
        Name = "ListCreate"
        Text = "ListCreate"
        ListType.ResumeLayout(False)
        ListType.PerformLayout()
        RoutinePanel.ResumeLayout(False)
        RoutinePanel.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        SpecificPanel.ResumeLayout(False)
        SpecificPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CreateButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListTypeComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListNameBox As TextBox
    Friend WithEvents ListSelectComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RoutineButton As RadioButton
    Friend WithEvents SpecificButton As RadioButton
    Friend WithEvents ListType As GroupBox
    Friend WithEvents RoutinePanel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MonthlyButton As RadioButton
    Friend WithEvents WeeklyButton As RadioButton
    Friend WithEvents DailyButton As RadioButton
    Friend WithEvents Store As Label
    Friend WithEvents StoreTextBox As TextBox
    Friend WithEvents SpecificPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListCancelButton As Button
End Class
