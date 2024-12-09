Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.Design.AxImporter

Public Class ShoppingListEdit

    Dim items As List(Of Produce) = New List(Of Produce)
    Dim Inven As List(Of String) = New List(Of String) From {"milk", "bowtie", "linguine",
        "vegOil", "bread", "seaSalt", "tomato", "water", "cheese", "instantNoodle", "carrots"}
    Dim baseNote As StickyNote
    Public Sub New(ByRef Sticky As StickyNote)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each i In Sticky.items
            items.Add(i)
        Next
        baseNote = Sticky
        LabelProd.Text = $"Items in {baseNote.ShoppingListName}:"
        refreshList()

    End Sub


    Private Sub refreshList()
        'Redisplays the shopping list with edited items
        FlowLayoutPanel1.Controls.Clear()
        items.Sort(Function(x, y) String.Compare(x.prod, y.prod))

        For Each item As Produce In items
            FlowLayoutPanel1.Controls.Add(item)
            item.Show()

            If Form1.isInInven(item.prod) Then
                item.inInven = True
            End If
        Next

        If baseNote.SendLabel.Visible Then
            Form1.shopperPhone.refreshItems()
        End If

    End Sub


    Private Sub AddBut_Click(sender As Object, e As EventArgs) Handles AddBut.Click
        'Prompts user to select source
        CancelAdd.Visible = True
        SourcePanel.Visible = True
        OkButAdd.Visible = True

        AddBut.Enabled = False
        RemoveBut.Enabled = False
        ModBut.Enabled = False
        refreshList()
    End Sub

    Private Sub RemoveBut_Click(sender As Object, e As EventArgs) Handles RemoveBut.Click
        'Prompts user to remove item
        ComboRem.Items.Clear()
        For Each item As Produce In items
            ComboRem.Items.Add(item.prod)
        Next


        CancelRem.Visible = True
        RemovePanel.Visible = True
        OkButRem.Visible = True

        AddBut.Enabled = False
        RemoveBut.Enabled = False
        ModBut.Enabled = False
    End Sub

    Private Sub ModBut_Click(sender As Object, e As EventArgs) Handles ModBut.Click
        'Prompts user to modify item
        ComboMod.Items.Clear()
        For Each item As Produce In items
            ComboMod.Items.Add(item.prod)
        Next
        CancelMod.Visible = True
        ModPanel.Visible = True
        OkButMod.Visible = True

        AddBut.Enabled = False
        RemoveBut.Enabled = False
        ModBut.Enabled = False
    End Sub

    Private Sub CancelAdd_Click() Handles CancelAdd.Click, CancelRem.Click, CancelMod.Click
        'Hides all prompts
        AddBut.Enabled = True
        RemoveBut.Enabled = True
        ModBut.Enabled = True

        CancelAdd.Visible = False
        CancelRem.Visible = False
        CancelMod.Visible = False
        OkButAdd.Visible = False
        OkButRem.Visible = False
        OkButMod.Visible = False

        SourcePanel.Visible = False
        AddPanel.Visible = False
        RemovePanel.Visible = False
        ModPanel.Visible = False
    End Sub


    Private Sub AddItem(sender As Object, e As EventArgs) Handles OkButAdd.Click
        'adds produce to shopping list

        Dim newItem = New Produce()
        Dim source As List(Of Produce) = New List(Of Produce)
        'get refence list of produce
        Select Case SourceComboBox.SelectedItem
            Case "Any"
                source = Form1.FULLPRODUCELIST
            Case "Inventory"
                source = Form1.inventoryProduce
            Case "Recipe"
                source = Form1.ListBooklet1.recipes(SourceNameComboBox.SelectedIndex).items
            Case "Routine Shopping List"
                source = Form1.ListBooklet1.routineShoppingLists(SourceNameComboBox.SelectedIndex).items
            Case "Specific Shopping List"
                source = Form1.ListBooklet1.specificShoppingLists(SourceNameComboBox.SelectedIndex).items
        End Select
        'assign new item to corresponding index
        newItem = source(ComboAdd.SelectedIndex)
        'set amount and refresh lists

        'multiple item amount for servings
        If SourceComboBox.SelectedItem Is "Recipe" Then
            newItem.amo *= InputAmountAdd.Text
        Else
            newItem.amo = InputAmountAdd.Text
        End If
        items.Add(newItem)

        If Form1.isInInven(items.Last.prod) Then
            items.Last.inInven = True
        End If

        refreshList()
        CancelAdd_Click()


    End Sub

    Private Sub RemoveItem(sender As Object, e As EventArgs) Handles OkButRem.Click
        'remove selected item from list
        items.RemoveAt(ComboRem.SelectedIndex)
        refreshList()
        CancelAdd_Click()
    End Sub

    Private Sub ModifyItem(sender As Object, e As EventArgs) Handles OkButMod.Click
        'modify item amount from list
        items(ComboMod.SelectedIndex).amo = InputAmountMod.Text
        refreshList()
        CancelAdd_Click()
    End Sub




    Private Sub ChangeSource(sender As Object, e As EventArgs) Handles SourceComboBox.SelectedIndexChanged
        'updates the list source box based on category selected
        SourceNameComboBox.Items.Clear()

        'make combo add visible if any or inventory
        If SourceComboBox.SelectedItem Is "Any" Then
            ComboAdd.Items.Clear()
            For Each i As Produce In Form1.FULLPRODUCELIST
                ComboAdd.Items.Add(i.prod)
            Next
            SourceNameComboBox.Enabled = False
            AddPanel.Visible = True
            Return
        End If

        If SourceComboBox.SelectedItem Is "Inventory" Then
            ComboAdd.Items.Clear()
            For Each i As Produce In Form1.inventoryProduce
                ComboAdd.Items.Add(i.prod)
            Next
            SourceNameComboBox.Enabled = False
            AddPanel.Visible = True
            Return
        End If

        'prompt user for specefic recepie or list
        AmountName.Text = "Amount"
        Select Case SourceComboBox.SelectedItem
            Case "Recipe"
                AmountName.Text = "Servings"
                For Each Recipe As StickyNote In Form1.ListBooklet1.recipes
                    SourceNameComboBox.Items.Add(Recipe.ShoppingListName)
                Next
            Case "Routine Shopping List"
                For Each Routinelist As StickyNote In Form1.ListBooklet1.routineShoppingLists
                    SourceNameComboBox.Items.Add(Routinelist.ShoppingListName)
                Next
            Case "Specific Shopping List"
                For Each Specificlist As StickyNote In Form1.ListBooklet1.specificShoppingLists
                    SourceNameComboBox.Items.Add(Specificlist.ShoppingListName)
                Next
        End Select
        AddPanel.Visible = False
        SourceNameComboBox.Enabled = True
    End Sub

    Private Sub ChangeSourceName(sender As Object, e As EventArgs) Handles SourceNameComboBox.SelectedIndexChanged
        'update comboadd based on specific list selected
        ComboAdd.Items.Clear()
        Dim options As List(Of Produce) = New List(Of Produce)
        Select Case SourceComboBox.SelectedItem
            Case "Recipe"
                options = Form1.ListBooklet1.recipes(SourceNameComboBox.SelectedIndex).items
            Case "Routine Shopping List"
                options = Form1.ListBooklet1.routineShoppingLists(SourceNameComboBox.SelectedIndex).items
            Case "Specific Shopping List"
                options = Form1.ListBooklet1.specificShoppingLists(SourceNameComboBox.SelectedIndex).items
        End Select
        For Each item As Produce In options
            ComboAdd.Items.Add(item.prod)
        Next
        AddPanel.Visible = True
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'save edited changes to sticky note
        baseNote.items.Clear()
        For Each i In items
            baseNote.items.Add(i)
        Next
        Form1.shopperPhone.currentPurchaseList.refreshItems()
        Me.Hide()
        Form1.Show()
    End Sub

    'update amo based on shopping list amount
    Private Sub ComboAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboAdd.SelectedIndexChanged
        Dim options As List(Of Produce) = New List(Of Produce)

        Select Case ComboAdd.SelectedItem.ToString()
            Case "Milk"
                UnitAdd.Text = "Unit: 2 Litre Carton"
            Case "Bowtie"
                UnitAdd.Text = "Unit: Box"
            Case "Bread"
                UnitAdd.Text = "Unit: Loaf"
            Case "Carrots"
                UnitAdd.Text = "Unit: Carrot"
            Case "Cheese"
                UnitAdd.Text = "Unit: 300g bag"
            Case "Instant Noodles"
                UnitAdd.Text = "Unit: Packet"
            Case "Linguine"
                UnitAdd.Text = "Unit: Box"
            Case "Sea Salt"
                UnitAdd.Text = "Unit: Box"
            Case "Tomato"
                UnitAdd.Text = "Unit: Tomato"
            Case "Vegetable Oil"
                UnitAdd.Text = "Unit: 1 Litre Bottle"
            Case "Water"
                UnitAdd.Text = "Unit: Bottle"
        End Select

        If SourceComboBox.SelectedItem Is "Routine Shopping List" Then
            options = Form1.ListBooklet1.routineShoppingLists(SourceNameComboBox.SelectedIndex).items
        End If

        If SourceComboBox.SelectedItem Is "Specific Shopping List" Then
            options = Form1.ListBooklet1.specificShoppingLists(SourceNameComboBox.SelectedIndex).items
        End If

        If options.Count = 0 Then Return

        InputAmountAdd.Text = options(ComboAdd.SelectedIndex).amo

    End Sub

    Private Sub ComboMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMod.SelectedIndexChanged
        Select Case ComboMod.SelectedItem.ToString()
            Case "Milk"
                UnitMod.Text = "Unit: 2 Litre Carton"
            Case "Bowtie"
                UnitMod.Text = "Unit: Box"
            Case "Bread"
                UnitMod.Text = "Unit: Loaf"
            Case "Carrots"
                UnitMod.Text = "Unit: Carrot"
            Case "Cheese"
                UnitMod.Text = "Unit: 300g bag"
            Case "Instant Noodles"
                UnitMod.Text = "Unit: Packet"
            Case "Linguine"
                UnitMod.Text = "Unit: Box"
            Case "Sea Salt"
                UnitMod.Text = "Unit: Box"
            Case "Tomato"
                UnitMod.Text = "Unit: Tomato"
            Case "Vegetable Oil"
                UnitMod.Text = "Unit: 1 Litre Bottle"
            Case "Water"
                UnitMod.Text = "Unit: Bottle"
        End Select
    End Sub
End Class