Public Class ListCreate

    Dim baseListPool As List(Of StickyNote) = New List(Of StickyNote)

    Private Sub ListCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoutinePanel.Location = SpecificPanel.Location
        RoutinePanel.Visible = False
        SpecificPanel.Visible = False

    End Sub
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim inp = ListNameBox.Text

        If inp = Nothing Then
            inp = "List Title"
        End If

        Dim s = New StickyNote(name1:=inp)

        'add items to list
        If CheckedListBox1.Enabled Then
            For i = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemCheckState(i) = CheckState.Checked Then
                    s.items.Add(baseListPool(ListSelectComboBox.SelectedIndex).items(i))
                End If
            Next
        End If

        'add routine info if routine list
        If RoutineButton.Checked Then
            If DailyButton.Checked Then s.Frequency = 1
            If WeeklyButton.Checked Then s.Frequency = 7
            If MonthlyButton.Checked Then s.Frequency = 30
            Form1.ListBooklet1.routineShoppingLists.Add(s)
        End If

        'add specific info if specific
        If SpecificButton.Checked Then
            s.ShoppingDate = DateTimePicker1.Value
            s.Frequency = -1
            Form1.ListBooklet1.specificShoppingLists.Add(s)

        End If
        'add purpose

        s.Purpose = RichTextBox1.Text

        'add list to home
        Form1.Home.Controls.Add(s)
        s.Show()
        s.Location = New Point(170, 30)
        s.BringToFront()

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ListTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTypeComboBox.SelectedIndexChanged
        ' set options of reference list based on list type
        ListSelectComboBox.Items.Clear()
        ListSelectComboBox.Text = ""
        ListSelectComboBox.Enabled = True
        CheckedListBox1.Enabled = True
        Select Case ListTypeComboBox.SelectedIndex
            Case 0
                baseListPool = New List(Of StickyNote)
                ListSelectComboBox.Enabled = False
                CheckedListBox1.Enabled = False

            Case 1
                baseListPool = Form1.ListBooklet1.routineShoppingLists
                ListSelectComboBox.Enabled = True
            Case 2
                baseListPool = Form1.ListBooklet1.recipes
                ListSelectComboBox.Enabled = True
        End Select
        For Each item As StickyNote In baseListPool
            ListSelectComboBox.Items.Add(item.ShoppingListName)
        Next

    End Sub

    Private Sub ListSelectComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSelectComboBox.SelectedIndexChanged
        'show items based on selected list
        CheckedListBox1.Items.Clear()
        For Each item As Produce In baseListPool(ListSelectComboBox.SelectedIndex).items
            CheckedListBox1.Items.Add($"{item.prod} x{item.amo}")
            CheckedListBox1.SetItemChecked(CheckedListBox1.Items.Count - 1, True)
        Next

    End Sub

    Private Sub ListType_Enter(sender As Object, e As EventArgs) Handles RoutineButton.Click, SpecificButton.Click
        'update selectors for routine/specific
        RoutinePanel.Visible = RoutineButton.Checked
        SpecificPanel.Visible = SpecificButton.Checked
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles ListCancelButton.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class