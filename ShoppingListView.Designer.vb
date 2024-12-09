<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShoppingListView
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
        LabelProd = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        CurrentFrequencyLabel = New Label()
        EditTitle = New Button()
        AssignShopper = New Button()
        ChangeFrequencyButton = New Button()
        ReturnButton = New Button()
        ListCancelButton = New Button()
        TextBox1 = New TextBox()
        OkayTitle = New Button()
        Panel1 = New Panel()
        EditLabel = New Label()
        ShopperCancelButton = New Button()
        OkayShopper = New Button()
        ComboBox1 = New ComboBox()
        Panel2 = New Panel()
        AssignLabel = New Label()
        FrequencyCancel = New Button()
        FrequencySave = New Button()
        ComboBox2 = New ComboBox()
        Panel3 = New Panel()
        FrequencyLabel = New Label()
        DetailLabel = New Label()
        DateLabel = New Label()
        Label4 = New Label()
        SwapTypeButton = New Button()
        ListTypeLabel = New Label()
        SpecificPanel = New Panel()
        Panel5 = New Panel()
        DateSaveButton = New Button()
        DateCancelButton = New Button()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ChangeDate = New Button()
        RoutinePanel = New Panel()
        EditPurpose = New Button()
        Panel4 = New Panel()
        Label3 = New Label()
        OkayPurpose = New Button()
        TextBox2 = New TextBox()
        CancelPupose = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SpecificPanel.SuspendLayout()
        Panel5.SuspendLayout()
        RoutinePanel.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelProd
        ' 
        LabelProd.AutoSize = True
        LabelProd.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        LabelProd.Location = New Point(21, 9)
        LabelProd.Margin = New Padding(1, 0, 1, 0)
        LabelProd.Name = "LabelProd"
        LabelProd.Size = New Size(178, 37)
        LabelProd.TabIndex = 17
        LabelProd.Text = "ShoppingList:"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(21, 48)
        FlowLayoutPanel1.Margin = New Padding(1)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(312, 609)
        FlowLayoutPanel1.TabIndex = 16
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(350, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 25)
        Label1.TabIndex = 18
        Label1.Text = "List Title: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(351, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 25)
        Label2.TabIndex = 19
        Label2.Text = "Assigned Shopper: "
        ' 
        ' CurrentFrequencyLabel
        ' 
        CurrentFrequencyLabel.AutoSize = True
        CurrentFrequencyLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        CurrentFrequencyLabel.Location = New Point(-5, 0)
        CurrentFrequencyLabel.Name = "CurrentFrequencyLabel"
        CurrentFrequencyLabel.Size = New Size(160, 25)
        CurrentFrequencyLabel.TabIndex = 20
        CurrentFrequencyLabel.Text = "Current Frequency:"
        ' 
        ' EditTitle
        ' 
        EditTitle.Location = New Point(354, 111)
        EditTitle.Name = "EditTitle"
        EditTitle.Size = New Size(65, 23)
        EditTitle.TabIndex = 21
        EditTitle.Text = "Edit"
        EditTitle.UseVisualStyleBackColor = True
        ' 
        ' AssignShopper
        ' 
        AssignShopper.Location = New Point(355, 175)
        AssignShopper.Name = "AssignShopper"
        AssignShopper.Size = New Size(65, 23)
        AssignShopper.TabIndex = 22
        AssignShopper.Text = "Assign"
        AssignShopper.UseVisualStyleBackColor = True
        ' 
        ' ChangeFrequencyButton
        ' 
        ChangeFrequencyButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChangeFrequencyButton.Location = New Point(0, 28)
        ChangeFrequencyButton.Name = "ChangeFrequencyButton"
        ChangeFrequencyButton.Size = New Size(155, 29)
        ChangeFrequencyButton.TabIndex = 23
        ChangeFrequencyButton.Text = "Change Frequency"
        ChangeFrequencyButton.UseVisualStyleBackColor = True
        ' 
        ' ReturnButton
        ' 
        ReturnButton.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        ReturnButton.Location = New Point(440, 564)
        ReturnButton.Margin = New Padding(3, 2, 3, 2)
        ReturnButton.Name = "ReturnButton"
        ReturnButton.Size = New Size(380, 74)
        ReturnButton.TabIndex = 29
        ReturnButton.Text = "Return to Fridge"
        ReturnButton.UseVisualStyleBackColor = True
        ' 
        ' ListCancelButton
        ' 
        ListCancelButton.Location = New Point(90, 64)
        ListCancelButton.Name = "ListCancelButton"
        ListCancelButton.Size = New Size(75, 23)
        ListCancelButton.TabIndex = 24
        ListCancelButton.Text = "Cancel"
        ListCancelButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(9, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(229, 23)
        TextBox1.TabIndex = 30
        ' 
        ' OkayTitle
        ' 
        OkayTitle.AutoEllipsis = True
        OkayTitle.Location = New Point(9, 64)
        OkayTitle.Name = "OkayTitle"
        OkayTitle.Size = New Size(75, 23)
        OkayTitle.TabIndex = 31
        OkayTitle.Text = "Save"
        OkayTitle.TextAlign = ContentAlignment.BottomCenter
        OkayTitle.UseMnemonic = False
        OkayTitle.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(EditLabel)
        Panel1.Controls.Add(OkayTitle)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(ListCancelButton)
        Panel1.Location = New Point(695, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(260, 103)
        Panel1.TabIndex = 34
        Panel1.Visible = False
        ' 
        ' EditLabel
        ' 
        EditLabel.AutoSize = True
        EditLabel.Location = New Point(11, 15)
        EditLabel.Name = "EditLabel"
        EditLabel.Size = New Size(227, 15)
        EditLabel.TabIndex = 32
        EditLabel.Text = "What's the new title for this shopping list?"
        ' 
        ' ShopperCancelButton
        ' 
        ShopperCancelButton.Location = New Point(92, 62)
        ShopperCancelButton.Name = "ShopperCancelButton"
        ShopperCancelButton.Size = New Size(75, 23)
        ShopperCancelButton.TabIndex = 27
        ShopperCancelButton.Text = "Cancel"
        ShopperCancelButton.UseVisualStyleBackColor = True
        ' 
        ' OkayShopper
        ' 
        OkayShopper.AutoEllipsis = True
        OkayShopper.Location = New Point(11, 62)
        OkayShopper.Name = "OkayShopper"
        OkayShopper.Size = New Size(75, 23)
        OkayShopper.TabIndex = 33
        OkayShopper.Text = "Save"
        OkayShopper.TextAlign = ContentAlignment.BottomCenter
        OkayShopper.UseMnemonic = False
        OkayShopper.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(11, 33)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(232, 23)
        ComboBox1.TabIndex = 35
        ComboBox1.Text = "Housemates..."
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(AssignLabel)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(OkayShopper)
        Panel2.Controls.Add(ShopperCancelButton)
        Panel2.Location = New Point(695, 157)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(260, 102)
        Panel2.TabIndex = 36
        Panel2.Visible = False
        ' 
        ' AssignLabel
        ' 
        AssignLabel.AutoSize = True
        AssignLabel.Location = New Point(12, 15)
        AssignLabel.Name = "AssignLabel"
        AssignLabel.Size = New Size(192, 15)
        AssignLabel.TabIndex = 36
        AssignLabel.Text = "Who do you want to assign this to?"
        ' 
        ' FrequencyCancel
        ' 
        FrequencyCancel.Location = New Point(93, 60)
        FrequencyCancel.Name = "FrequencyCancel"
        FrequencyCancel.Size = New Size(75, 23)
        FrequencyCancel.TabIndex = 27
        FrequencyCancel.Text = "Cancel"
        FrequencyCancel.UseVisualStyleBackColor = True
        ' 
        ' FrequencySave
        ' 
        FrequencySave.AutoEllipsis = True
        FrequencySave.Location = New Point(12, 60)
        FrequencySave.Name = "FrequencySave"
        FrequencySave.Size = New Size(75, 23)
        FrequencySave.TabIndex = 33
        FrequencySave.Text = "Save"
        FrequencySave.TextAlign = ContentAlignment.BottomCenter
        FrequencySave.UseMnemonic = False
        FrequencySave.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 31)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(232, 23)
        ComboBox2.TabIndex = 35
        ComboBox2.Text = "Frequency..."
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(FrequencyLabel)
        Panel3.Controls.Add(ComboBox2)
        Panel3.Controls.Add(FrequencySave)
        Panel3.Controls.Add(FrequencyCancel)
        Panel3.Location = New Point(3, 59)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(260, 95)
        Panel3.TabIndex = 37
        Panel3.Visible = False
        ' 
        ' FrequencyLabel
        ' 
        FrequencyLabel.AutoSize = True
        FrequencyLabel.Location = New Point(12, 13)
        FrequencyLabel.Name = "FrequencyLabel"
        FrequencyLabel.Size = New Size(244, 15)
        FrequencyLabel.TabIndex = 36
        FrequencyLabel.Text = "How frequent do you want to repeat this list?"
        ' 
        ' DetailLabel
        ' 
        DetailLabel.AutoSize = True
        DetailLabel.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        DetailLabel.Location = New Point(355, 50)
        DetailLabel.Name = "DetailLabel"
        DetailLabel.Size = New Size(83, 28)
        DetailLabel.TabIndex = 38
        DetailLabel.Text = "Details:"
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        DateLabel.Location = New Point(0, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(146, 25)
        DateLabel.TabIndex = 39
        DateLabel.Text = "Date to Shop By:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(351, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 25)
        Label4.TabIndex = 40
        Label4.Text = "List Purpose:"
        ' 
        ' SwapTypeButton
        ' 
        SwapTypeButton.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        SwapTypeButton.Location = New Point(355, 327)
        SwapTypeButton.Name = "SwapTypeButton"
        SwapTypeButton.Size = New Size(164, 29)
        SwapTypeButton.TabIndex = 41
        SwapTypeButton.Text = "Change to Specific List"
        SwapTypeButton.UseVisualStyleBackColor = True
        ' 
        ' ListTypeLabel
        ' 
        ListTypeLabel.AutoSize = True
        ListTypeLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ListTypeLabel.Location = New Point(351, 299)
        ListTypeLabel.Name = "ListTypeLabel"
        ListTypeLabel.Size = New Size(180, 25)
        ListTypeLabel.TabIndex = 42
        ListTypeLabel.Text = "List Type: Routine List"
        ' 
        ' SpecificPanel
        ' 
        SpecificPanel.Controls.Add(Panel5)
        SpecificPanel.Controls.Add(ChangeDate)
        SpecificPanel.Controls.Add(DateLabel)
        SpecificPanel.Location = New Point(662, 373)
        SpecificPanel.Name = "SpecificPanel"
        SpecificPanel.Size = New Size(298, 169)
        SpecificPanel.TabIndex = 43
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(DateSaveButton)
        Panel5.Controls.Add(DateCancelButton)
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(DateTimePicker1)
        Panel5.Location = New Point(3, 59)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(261, 100)
        Panel5.TabIndex = 42
        Panel5.Visible = False
        ' 
        ' DateSaveButton
        ' 
        DateSaveButton.AutoEllipsis = True
        DateSaveButton.Location = New Point(3, 60)
        DateSaveButton.Name = "DateSaveButton"
        DateSaveButton.Size = New Size(75, 23)
        DateSaveButton.TabIndex = 43
        DateSaveButton.Text = "Save"
        DateSaveButton.TextAlign = ContentAlignment.BottomCenter
        DateSaveButton.UseMnemonic = False
        DateSaveButton.UseVisualStyleBackColor = True
        ' 
        ' DateCancelButton
        ' 
        DateCancelButton.Location = New Point(84, 60)
        DateCancelButton.Name = "DateCancelButton"
        DateCancelButton.Size = New Size(75, 23)
        DateCancelButton.TabIndex = 42
        DateCancelButton.Text = "Cancel"
        DateCancelButton.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 15)
        Label6.TabIndex = 41
        Label6.Text = "Enter new shop by date:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(3, 31)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 40
        ' 
        ' ChangeDate
        ' 
        ChangeDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChangeDate.Location = New Point(3, 28)
        ChangeDate.Name = "ChangeDate"
        ChangeDate.Size = New Size(155, 29)
        ChangeDate.TabIndex = 41
        ChangeDate.Text = "Change Date"
        ChangeDate.UseVisualStyleBackColor = True
        ' 
        ' RoutinePanel
        ' 
        RoutinePanel.Controls.Add(ChangeFrequencyButton)
        RoutinePanel.Controls.Add(CurrentFrequencyLabel)
        RoutinePanel.Controls.Add(Panel3)
        RoutinePanel.Location = New Point(355, 373)
        RoutinePanel.Name = "RoutinePanel"
        RoutinePanel.Size = New Size(275, 169)
        RoutinePanel.TabIndex = 44
        ' 
        ' EditPurpose
        ' 
        EditPurpose.Location = New Point(355, 245)
        EditPurpose.Name = "EditPurpose"
        EditPurpose.Size = New Size(75, 23)
        EditPurpose.TabIndex = 45
        EditPurpose.Text = "Edit"
        EditPurpose.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(OkayPurpose)
        Panel4.Controls.Add(TextBox2)
        Panel4.Controls.Add(CancelPupose)
        Panel4.Location = New Point(695, 267)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(260, 103)
        Panel4.TabIndex = 46
        Panel4.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 15)
        Label3.TabIndex = 32
        Label3.Text = "What's the purpose for this shopping list?"
        ' 
        ' OkayPurpose
        ' 
        OkayPurpose.AutoEllipsis = True
        OkayPurpose.Location = New Point(9, 64)
        OkayPurpose.Name = "OkayPurpose"
        OkayPurpose.Size = New Size(75, 23)
        OkayPurpose.TabIndex = 31
        OkayPurpose.Text = "Save"
        OkayPurpose.TextAlign = ContentAlignment.BottomCenter
        OkayPurpose.UseMnemonic = False
        OkayPurpose.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(9, 35)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(229, 23)
        TextBox2.TabIndex = 30
        ' 
        ' CancelPupose
        ' 
        CancelPupose.Location = New Point(90, 64)
        CancelPupose.Name = "CancelPupose"
        CancelPupose.Size = New Size(75, 23)
        CancelPupose.TabIndex = 24
        CancelPupose.Text = "Cancel"
        CancelPupose.UseVisualStyleBackColor = True
        ' 
        ' ShoppingListView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(955, 662)
        Controls.Add(Panel4)
        Controls.Add(EditPurpose)
        Controls.Add(RoutinePanel)
        Controls.Add(SpecificPanel)
        Controls.Add(ListTypeLabel)
        Controls.Add(SwapTypeButton)
        Controls.Add(Label4)
        Controls.Add(DetailLabel)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(ReturnButton)
        Controls.Add(AssignShopper)
        Controls.Add(EditTitle)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LabelProd)
        Controls.Add(FlowLayoutPanel1)
        Name = "ShoppingListView"
        Text = "ShoppingListView"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        SpecificPanel.ResumeLayout(False)
        SpecificPanel.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        RoutinePanel.ResumeLayout(False)
        RoutinePanel.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelProd As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CurrentFrequencyLabel As Label
    Friend WithEvents EditTitle As Button
    Friend WithEvents AssignShopper As Button
    Friend WithEvents ChangeFrequencyButton As Button
    Friend WithEvents CancelFrequency As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents ListCancelButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OkayTitle As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShopperCancelButton As Button
    Friend WithEvents OkayShopper As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FrequencyCancel As Button
    Friend WithEvents FrequencySave As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DetailLabel As Label
    Friend WithEvents EditLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AssignLabel As Label
    Friend WithEvents FrequencyLabel As Label
    Friend WithEvents SwapTypeButton As Button
    Friend WithEvents ListTypeLabel As Label
    Friend WithEvents SpecificPanel As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RoutinePanel As Panel
    Friend WithEvents ChangeDate As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DateSaveButton As Button
    Friend WithEvents DateCancelButton As Button
    Friend WithEvents EditPurpose As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents OkayPurpose As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CancelPupose As Button
End Class
