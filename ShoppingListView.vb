
Public Class ShoppingListView
    Dim baseNote As StickyNote
    Dim items As List(Of Produce) = New List(Of Produce)
    Dim Inven As List(Of String) = New List(Of String) From {"milk", "bowtie", "linguine",
        "vegOil", "bread", "seaSalt", "tomato", "water", "cheese", "instantNoodle", "carrots"}

    Public Sub New(ByRef Sticky As StickyNote)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each i In Sticky.items
            items.Add(i)
        Next
        baseNote = Sticky
        refreshList()

        ' adding to the assign shopper combo box
        ComboBox1.Items.Add("Housemate 1")
        ComboBox1.Items.Add("Housemate 2")
        ComboBox1.Items.Add("Shopper 1")

        ' adding to the list frequency combo box
        ComboBox2.Items.Add("Daily")
        ComboBox2.Items.Add("Weekly")
        ComboBox2.Items.Add("Monthly")

        ' load details
        Label1.Text = "List Name: " + baseNote.ShoppingListName
        Label2.Text = "Assigned Shopper: " + baseNote.AssignedShopper
        Select Case baseNote.Frequency
            Case 1
                CurrentFrequencyLabel.Text = "Current Frequency: Daily"
            Case 7
                CurrentFrequencyLabel.Text = "Current Frequency: Weekly"
            Case 30
                CurrentFrequencyLabel.Text = "Current Frequency: Monthly"
        End Select

        Label4.Text = "List Purpose: " + baseNote.Purpose
        DateLabel.Text = "Shop By: " + baseNote.ShoppingDate.ToString("yy-MM-dd")

        LabelProd.Text = $"Items in {baseNote.ShoppingListName}:"

        'overlap and hide panels
        Panel2.Location = Panel1.Location
        Panel4.Location = Panel1.Location

        SpecificPanel.Location = RoutinePanel.Location
        SpecificPanel.Visible = False
        RoutinePanel.Visible = False
        ChangeLabelAndButton()

    End Sub

    Private Sub refreshList()
        'Redisplays the shopping list with edited items
        FlowLayoutPanel1.Controls.Clear()
        items.Sort(Function(x, y) String.Compare(x.prod, y.prod))

        For Each item As Produce In items
            FlowLayoutPanel1.Controls.Add(item)
            item.Show()
        Next

    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ListTitleEditButton_Click(sender As Object, e As EventArgs) Handles EditTitle.Click
        Panel1.Visible = True
        DisableButtons()
    End Sub

    Private Sub AssignedShopperButton_Click(sender As Object, e As EventArgs) Handles AssignShopper.Click
        Panel2.Visible = True
        DisableButtons()
    End Sub

    Private Sub EditPurpose_Click(sender As Object, e As EventArgs) Handles EditPurpose.Click
        Panel4.Visible = True
        DisableButtons()
    End Sub

    Private Sub ChangeFrequencyButton_Click() Handles ChangeFrequencyButton.Click
        Panel3.Visible = True
        DisableButtons()
    End Sub

    Private Sub ChangeDate_Click() Handles ChangeDate.Click
        Panel5.Visible = True
        DisableButtons()
    End Sub

    Private Sub DisableButtons()
        EditTitle.Enabled = False
        AssignShopper.Enabled = False
        ChangeFrequencyButton.Enabled = False
        EditPurpose.Enabled = False
        ChangeDate.Enabled = False
        ReturnButton.Enabled = False
        SwapTypeButton.Enabled = False

    End Sub

    Private Sub CancelButton_Click() Handles ListCancelButton.Click, ShopperCancelButton.Click, CancelPupose.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False

        EditTitle.Enabled = True
        AssignShopper.Enabled = True
        ChangeFrequencyButton.Enabled = True
        EditPurpose.Enabled = True
        ChangeDate.Enabled = True
        ReturnButton.Enabled = True
        SwapTypeButton.Enabled = True
    End Sub

    Private Sub DateCancelButtonClick()
        CancelButton_Click()
        RoutinePanel.Visible = False
        SpecificPanel.Visible = False
        If baseNote.Frequency < 0 Then
            SpecificPanel.Visible = True
        Else
            RoutinePanel.Visible = True

        End If

    End Sub

    Private Sub SaveTitle_Click(sender As Object, e As EventArgs) Handles OkayTitle.Click
        Dim userInput = TextBox1.Text

        baseNote.ShoppingListName = userInput
        Label1.Text = "List Title: " + userInput

        CancelButton_Click()
    End Sub

    Private Sub OkayPurpose_Click(sender As Object, e As EventArgs) Handles OkayPurpose.Click
        Dim userInput = TextBox2.Text

        baseNote.Purpose = userInput
        Label4.Text = "List Purpose: " + userInput

        CancelButton_Click()
    End Sub

    Private Sub SaveShopper_Click(sender As Object, e As EventArgs) Handles OkayShopper.Click
        Select Case ComboBox1.SelectedItem
            Case "Housemate 1"
                Label2.Text = "Assigned Shopper: Housemate 1"
                baseNote.AssignedShopper = "Housemate 1"
            Case "Housemate 2"
                Label2.Text = "Assigned Shopper: Housemate 2"
                baseNote.AssignedShopper = "Housemate 2"
            Case "Shopper 1"
                Label2.Text = "Assigned Shopper: Shopper 1"
                baseNote.AssignedShopper = "Shopper 1"
        End Select

        CancelButton_Click()
    End Sub

    Private Sub FrequencySave_Click(sender As Object, e As EventArgs) Handles FrequencySave.Click
        Select Case ComboBox2.SelectedItem
            Case "Daily"
                CurrentFrequencyLabel.Text = "Current Frequency: Daily"
                baseNote.Frequency = 1
            Case "Weekly"
                CurrentFrequencyLabel.Text = "Current Frequency: Weekly"
                baseNote.Frequency = 7
            Case "Monthly"
                CurrentFrequencyLabel.Text = "Current Frequency: Monthly"
                baseNote.Frequency = 30
            Case Else
                CurrentFrequencyLabel.Text = "Current Frequency: One-Time Use"
                baseNote.Frequency = -1
        End Select
        ListTypeLabel.Text = "List Type: Routine List"
        SwapTypeButton.Text = "Change to Specific List"
        RoutinePanel.Visible = True
        SpecificPanel.Visible = False

        CancelButton_Click()
    End Sub

    Private Sub DateSaveButton_Click(sender As Object, e As EventArgs) Handles DateSaveButton.Click


        baseNote.ShoppingDate = DateTimePicker1.Value
        baseNote.Frequency = -1
        DateLabel.Text = "Shop By: " + baseNote.ShoppingDate.ToString("yy-MM-dd")
        ListTypeLabel.Text = "List Type: Specific List"
        SwapTypeButton.Text = "Change to Routine List"

        RoutinePanel.Visible = False
        SpecificPanel.Visible = True

        CancelButton_Click()
    End Sub

    Private Sub SwapTypeButton_Click(sender As Object, e As EventArgs) Handles SwapTypeButton.Click
        'swap type of list
        If baseNote.Frequency < 0 Then
            RoutinePanel.Visible = True
            ChangeFrequencyButton_Click()
            SpecificPanel.Visible = False
            DisableButtons()
        ElseIf baseNote.Frequency > 0 Then
            SpecificPanel.Visible = True
            ChangeDate_Click()
            RoutinePanel.Visible = False
            DisableButtons()
        End If

    End Sub

    Private Sub DateFrequencyCancelButton_Click(sender As Object, e As EventArgs) Handles DateCancelButton.Click, FrequencyCancel.Click

        ChangeLabelAndButton()
        CancelButton_Click()
    End Sub

    Private Sub ChangeLabelAndButton()
        If baseNote.Frequency < 0 Then
            SpecificPanel.Visible = True
            RoutinePanel.Visible = False
            If (Not Form1.ListBooklet1.specificShoppingLists.Contains(baseNote)) Then
                Form1.ListBooklet1.routineShoppingLists.Remove(baseNote)
                Form1.ListBooklet1.specificShoppingLists.Add(baseNote)
            End If

            ListTypeLabel.Text = "List Type: Specific List"
            SwapTypeButton.Text = "Change to Routine List"
        ElseIf baseNote.Frequency > 0 Then
            RoutinePanel.Visible = True
            SpecificPanel.Visible = False

            If (Not Form1.ListBooklet1.routineShoppingLists.Contains(baseNote)) Then
                Form1.ListBooklet1.specificShoppingLists.Remove(baseNote)
                Form1.ListBooklet1.routineShoppingLists.Add(baseNote)
            End If

            ListTypeLabel.Text = "List Type: Routine List"
            SwapTypeButton.Text = "Change to Specific List"
        End If
    End Sub

End Class