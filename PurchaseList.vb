Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PurchaseList
    Dim baseNote As StickyNote
    Dim listedProduce As List(Of ProdPurchase) = New List(Of ProdPurchase)

    Dim AddedItems As List(Of Produce) = New List(Of Produce)

    Public purchasedProduce As List(Of Produce) = New List(Of Produce)

    Public Sub New(ByRef base As StickyNote)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.baseNote = base

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = baseNote.ShoppingListName
        If baseNote.Frequency < 0 Then
            Label2.Text = "Shop by: "
            Label6.Text = baseNote.ShoppingDate
        ElseIf baseNote.Frequency > 0 Then
            Label2.Text = "Shop: "
            Label6.Text = baseNote.FrequencyWord(baseNote.Frequency)
        End If
        For Each i As Produce In baseNote.items
            Dim basic As New ProdPurchase(i)
            FlowLayoutPanel1.Controls.Add(basic)
            listedProduce.Add(basic)
        Next
    End Sub

    Public Sub refreshItems()
        'refresh shopping lists when changed
        FlowLayoutPanel1.Controls.Clear()

        If baseNote IsNot Nothing Then
            Dim newItems As List(Of Produce) = New List(Of Produce)
            Dim modItems As List(Of Produce) = New List(Of Produce)
            Dim remItems As List(Of Produce) = New List(Of Produce)
            Dim restItems As List(Of Produce) = New List(Of Produce)
            ' add rest/mod/rem
            For Each item As ProdPurchase In listedProduce
                Dim match = False
                For Each i As Produce In baseNote.items
                    If i.prod = item.Produce1.prod Then
                        match = True
                        If i.amo = item.Produce1.amo Then
                            restItems.Add(i)
                        Else
                            modItems.Add(i)
                        End If
                    End If

                Next
                If Not match Then remItems.Add(item.Produce1)
            Next
            ' add new items
            For Each i As Produce In baseNote.items
                Dim match = False
                For Each item As ProdPurchase In listedProduce
                    If i.prod = item.Produce1.prod Then
                        match = True
                    End If
                Next
                If Not match Then newItems.Add(i)
            Next

            'refreshList
            listedProduce.Clear()
            For Each i As Produce In newItems
                Dim basic As New ProdPurchase(i)
                basic.Produce1.BackColor = Color.Green
                FlowLayoutPanel1.Controls.Add(basic)
                listedProduce.Add(basic)
            Next

            For Each i As Produce In remItems
                Dim basic As New ProdPurchase(i)
                Dim skip = False
                For Each item As Produce In AddedItems
                    If item.prod = i.prod Then skip = True
                Next
                If Not skip Then
                    basic.Produce1.BackColor = Color.Red
                    basic.Produce1.amo = 0
                    FlowLayoutPanel1.Controls.Add(basic)
                    listedProduce.Add(basic)
                End If
            Next

                For Each i As Produce In modItems
                Dim basic As New ProdPurchase(i)
                basic.Produce1.BackColor = Color.Yellow
                FlowLayoutPanel1.Controls.Add(basic)
                listedProduce.Add(basic)
            Next

            For Each i As Produce In restItems
                Dim basic As New ProdPurchase(i)
                FlowLayoutPanel1.Controls.Add(basic)
                listedProduce.Add(basic)
            Next

        End If

        If AddedItems IsNot Nothing Then
            For Each item As Produce In AddedItems
                Dim basic As New ProdPurchase(item)

                FlowLayoutPanel1.Controls.Add(basic)
            Next
        End If


    End Sub



    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Shopper.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddPanel.Visible = True
        OkayButton.Visible = True
        CancelButton.Visible = True
        PurchaseButton.Enabled = False
        BackButton.Enabled = False
        Button1.Enabled = False
        ComboBox1.Enabled = False
    End Sub

    Private Sub CancelButton_Click() Handles CancelButton.Click
        AddPanel.Visible = False
        OkayButton.Visible = False
        CancelButton.Visible = False

        PurchaseButton.Enabled = True
        BackButton.Enabled = True
        Button1.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub OkayButton_Click(sender As Object, e As EventArgs) Handles OkayButton.Click
        Dim newItem = New Produce()
        newItem = Form1.FULLPRODUCELIST(ComboAdd.SelectedIndex)
        newItem.amo = InputAmountAdd.Text
        AddedItems.Add(newItem)
        refreshItems()
        CancelButton_Click()
    End Sub

    Private Sub ComboAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboAdd.SelectedIndexChanged
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
    End Sub

    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click
        For Each item In listedProduce
            If item.bought Then
                purchasedProduce.Add(item.baseProduce)
            End If
        Next

        For Each item As Produce In purchasedProduce
            Dim num = Form1.GetItemNum(item.prod)
            Form1.ModifyItem(num, item.amo)
            Form1.AddItem(num, item.amo)
        Next

        MessageBox.Show("Items have been purchased")

    End Sub
End Class