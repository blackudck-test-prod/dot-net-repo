Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim Inven As List(Of String) = New List(Of String) From {"bowtie", "bread", "carrots", "cheese",
        "instantNoodle", "linguine", "milk", "seaSalt", "tomato", "vegOil", "water"}

    Public shopperPhone As Shopper = Nothing
    Public inventoryProduce As List(Of Produce) = New List(Of Produce)
    Public FULLPRODUCELIST As New List(Of Produce) From {
        New Produce(name:="Bowtie", image:=My.Resources.Resources.bowtie, price:=7, store:="Sobeys", unit:="Box"),
        New Produce(name:="Bread", image:=My.Resources.Resources.bread, price:=2, store:="FreshCO", unit:="Loaf"),
        New Produce(name:="Carrots", image:=My.Resources.Resources.Carrots, price:=1.5, store:="FreshCO", unit:="Carrot"),
        New Produce(name:="Cheese", image:=My.Resources.Resources.cheese, price:=6, store:="FreshCO", unit:="300g Bag"),
        New Produce(name:="Instant Noodles", image:=My.Resources.Resources.noods, price:=3.5, store:="Sobeys", unit:="Packet"),
        New Produce(name:="Linguine", image:=My.Resources.Resources.linguine, price:=3, store:="FreshCO", unit:="Box"),
        New Produce(name:="Milk", image:=My.Resources.Resources.milk, price:=5, store:="FreshCO", unit:="2 Litre Carton"),
        New Produce(name:="Sea Salt", image:=My.Resources.Resources.seaSalt, price:=9, store:="Sobeys", unit:="Box"),
        New Produce(name:="Tomato", image:=My.Resources.Resources.tomato, price:=3, store:="FreshCO", unit:="Tomato"),
        New Produce(name:="Vegetable Oil", image:=My.Resources.Resources.vegOil, price:=15, store:="Sobeys", unit:="1 Litre Bottle"),
        New Produce(name:="Water", image:=My.Resources.Resources.water, price:=1, store:="Sobeys", unit:="Bottle")
        }

    Private Const MILK = 0
    Private Const BOWTIE = 1
    Private Const LINGUINE = 2
    Private Const VEG_OIL = 3
    Private Const BREAD = 4
    Private Const SEA_SALT = 5
    Private Const TOMATO = 6
    Private Const WATER = 7
    Private Const CHEESE = 8
    Private Const INST_NOODS = 9
    Private Const CARROTS = 10


    Public Sub refreshItems()
        'refresh inventoryProduce when changed
        inventoryProduce.Clear()
        For Each i In FlowLayoutPanel1.Controls
            If TypeOf i Is Produce Then
                If i.Visible Then
                    inventoryProduce.Add(i)
                End If

            End If
        Next
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        refreshItems()

        'No clue how else to add these imgs cause its not letting me any else'
        'imgs for inventory produce'
        ProdMilk.img = My.Resources.Resources.milk
        ProdBowtie.img = My.Resources.Resources.bowtie
        ProdLing.img = My.Resources.Resources.linguine
        ProdOil.img = My.Resources.Resources.vegOil
        ProdBread.img = My.Resources.Resources.bread
        ProdSalt.img = My.Resources.Resources.seaSalt
        ProdTomato.img = My.Resources.Resources.tomato
        ProdWater.img = My.Resources.Resources.water
        ProdCheese.img = My.Resources.Resources.cheese
        ProdInstNoods.img = My.Resources.Resources.noods
        ProdCarrots.img = My.Resources.Resources.Carrots

        ProdSaleMilk.img = My.Resources.Resources.milk
        ProdSaleBow.img = My.Resources.Resources.bowtie
        ProdSaleLing.img = My.Resources.Resources.linguine
        ProdSaleOil.img = My.Resources.Resources.vegOil
        ProdSaleBread.img = My.Resources.Resources.bread
        ProdSaleSalt.img = My.Resources.Resources.seaSalt
        ProdSaleTom.img = My.Resources.Resources.tomato
        ProdSaleWater.img = My.Resources.Resources.water
        ProdSaleCheese.img = My.Resources.Resources.cheese
        ProdSaleNoods.img = My.Resources.Resources.noods
        ProdSaleCar.img = My.Resources.Resources.Carrots

        StickyNote1.items.Add(New Produce(name:="Cheese", amount:="1", image:=My.Resources.Resources.cheese, price:=6, store:="FreshCO", unit:="300g Bag"))
        If isInInven(StickyNote1.items.Last.prod) Then
            StickyNote1.items.Last.inInven = True
        End If

        StickyNote1.items.Add(New Produce(name:="Instant Noodles", amount:="1", image:=My.Resources.Resources.noods, price:=3.5, store:="Sobeys", unit:="Packet"))
        If isInInven(StickyNote1.items.Last.prod) Then
            StickyNote1.items.Last.inInven = True
        End If

        StickyNote1.items.Add(New Produce(name:="Tomato", amount:="1", image:=My.Resources.Resources.tomato, price:=3, store:="FreshCO", unit:="Tomato"))
        If isInInven(StickyNote1.items.Last.prod) Then
            StickyNote1.items.Last.inInven = True
        End If

        StickyNote1.items.Add(New Produce(name:="Water", amount:="1", image:=My.Resources.Resources.water, price:=1, store:="Sobeys", unit:="Bottle"))
        If isInInven(StickyNote1.items.Last.prod) Then
            StickyNote1.items.Last.inInven = True
        End If

        ListBooklet1.routineShoppingLists.Add(StickyNote1)

        Recipes.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newShopper = New Shopper()
        shopperPhone = newShopper
        Shopper.Show()
    End Sub



    'ALL CODE FOR INVENTORY TABB'
    Private Sub AddBut_Click(sender As Object, e As EventArgs) Handles AddBut.Click
        CancelAdd.Visible = True
        OkButAdd.Visible = True
        AddPanel.Visible = True

        AddBut.Enabled = False
        RemoveBut.Enabled = False
        ModBut.Enabled = False
    End Sub

    Private Sub RemoveBut_Click(sender As Object, e As EventArgs) Handles RemoveBut.Click
        CancelRem.Visible = True
        OkButRem.Visible = True
        RemovePanel.Visible = True

        AddBut.Enabled = False
        RemoveBut.Enabled = False
        ModBut.Enabled = False
    End Sub

    Private Sub ModBut_Click(sender As Object, e As EventArgs) Handles ModBut.Click
        CancelMod.Visible = True
        OkButMod.Visible = True
        ModPanel.Visible = True

        AddBut.Enabled = False
        RemoveBut.Enabled = False
        ModBut.Enabled = False
    End Sub

    Private Sub CancelAdd_Click(sender As Object, e As EventArgs) Handles CancelAdd.Click, CancelRem.Click, CancelMod.Click
        AddBut.Enabled = True
        RemoveBut.Enabled = True
        ModBut.Enabled = True

        CancelAdd.Visible = False
        CancelRem.Visible = False
        CancelMod.Visible = False
        OkButAdd.Visible = False
        OkButMod.Visible = False
        OkButRem.Visible = False

        AddPanel.Visible = False
        RemovePanel.Visible = False
        ModPanel.Visible = False
    End Sub


    Private Sub OkButAdd_Click(sender As Object, e As EventArgs) Handles OkButAdd.Click
        AddItem(GetItemNum(ComboAdd.SelectedItem.ToString), InputAmountAdd.Text)

        ComboMod.Items.Add(ComboAdd.SelectedItem.ToString)
        ComboRem.Items.Add(ComboAdd.SelectedItem.ToString)

        ComboAdd.Items.Remove(ComboAdd.SelectedItem.ToString)
        refreshItems()
    End Sub

    Private Sub OkButRem_Click(sender As Object, e As EventArgs) Handles OkButRem.Click
        RemoveItem(GetItemNum(ComboRem.SelectedItem.ToString))


        ComboAdd.Items.Add(ComboRem.SelectedItem.ToString)
        ComboMod.Items.Remove(ComboRem.SelectedItem.ToString)
        ComboRem.Items.Remove(ComboRem.SelectedItem.ToString)
        refreshItems()
    End Sub

    Private Sub OkButMod_Click(sender As Object, e As EventArgs) Handles OkButMod.Click
        ModifyItem(GetItemNum(ComboMod.SelectedItem.ToString), InputAmountMod.Text)
        refreshItems()
    End Sub


    'ADD item to inventory'
    'But actually just reveal it again in inventory'
    Public Sub AddItem(item As Integer, amount As String)

        Select Case item
            Case BOWTIE
                ProdBowtie.Visible = True
                ProdBowtie.amo = amount
                ProdSaleBow.amo = amount
            Case BREAD
                ProdBread.Visible = True
                ProdBread.amo = amount
                ProdSaleBread.amo = amount
            Case CARROTS
                ProdCarrots.Visible = True
                ProdCarrots.amo = amount
                ProdSaleCar.amo = amount
            Case CHEESE
                ProdCheese.Visible = True
                ProdCheese.amo = amount
                ProdSaleCheese.amo = amount
            Case INST_NOODS
                ProdInstNoods.Visible = True
                ProdInstNoods.amo = amount
                ProdSaleNoods.amo = amount
            Case LINGUINE
                ProdLing.Visible = True
                ProdLing.amo = amount
                ProdSaleLing.amo = amount
            Case MILK
                ProdMilk.Visible = True
                ProdMilk.amo = amount
                ProdSaleMilk.amo = amount
            Case SEA_SALT
                ProdSalt.Visible = True
                ProdSalt.amo = amount
                ProdSaleSalt.amo = amount
            Case TOMATO
                ProdTomato.Visible = True
                ProdTomato.amo = amount
                ProdSaleTom.amo = amount
            Case VEG_OIL
                ProdOil.Visible = True
                ProdOil.amo = amount
                ProdSaleOil.amo = amount
            Case WATER
                ProdWater.Visible = True
                ProdWater.amo = amount
                ProdSaleWater.amo = amount
        End Select


    End Sub

    'REMOVE item from inventory'
    'But actually just hide it in inventory'
    Public Sub RemoveItem(item As Integer)
        Select Case item
            Case MILK
                ProdMilk.Visible = False
            Case BOWTIE
                ProdBowtie.Visible = False
            Case LINGUINE
                ProdLing.Visible = False
            Case VEG_OIL
                ProdOil.Visible = False
            Case BREAD
                ProdBread.Visible = False
            Case SEA_SALT
                ProdSalt.Visible = False
            Case TOMATO
                ProdTomato.Visible = False
            Case WATER
                ProdWater.Visible = False
            Case CHEESE
                ProdCheese.Visible = False
            Case INST_NOODS
                ProdInstNoods.Visible = False
            Case CARROTS
                ProdCarrots.Visible = False
        End Select
    End Sub

    'MODIFY item from inventory'
    'But change amount'
    Public Sub ModifyItem(item As Integer, amount As String)
        Select Case item
            Case MILK
                ProdMilk.amo = amount
                ProdSaleMilk.amo = amount
            Case BOWTIE
                ProdBowtie.amo = amount
                ProdSaleBow.amo = amount
            Case LINGUINE
                ProdLing.amo = amount
                ProdSaleLing.amo = amount
            Case VEG_OIL
                ProdOil.amo = amount
                ProdSaleOil.amo = amount
            Case BREAD
                ProdBread.amo = amount
                ProdSaleBread.amo = amount
            Case SEA_SALT
                ProdSalt.amo = amount
                ProdSaleSalt.amo = amount
            Case TOMATO
                ProdTomato.amo = amount
                ProdSaleTom.amo = amount
            Case WATER
                ProdWater.amo = amount
                ProdSaleWater.amo = amount
            Case CHEESE
                ProdCheese.amo = amount
                ProdSaleCheese.amo = amount
            Case INST_NOODS
                ProdInstNoods.amo = amount
                ProdSaleNoods.amo = amount
            Case CARROTS
                ProdCarrots.amo = amount
                ProdSaleCar.amo = amount
        End Select
    End Sub

    Public Function GetItemNum(itemName As String)
        Select Case itemName
            Case "Milk"
                Return MILK
            Case "Bowtie"
                Return BOWTIE
            Case "Linguine"
                Return LINGUINE
            Case "Vegetable Oil"
                Return VEG_OIL
            Case "Bread"
                Return BREAD
            Case "Sea Salt"
                Return SEA_SALT
            Case "Tomato"
                Return TOMATO
            Case "Water"
                Return WATER
            Case "Cheese"
                Return CHEESE
            Case "Instant Noodles"
                Return INST_NOODS
            Case "Carrots"
                Return CARROTS
        End Select
    End Function

    Private Sub ButAll_Click(sender As Object, e As EventArgs) Handles ButAll.Click
        ProdSaleBow.Visible = True
        ProdSaleBread.Visible = True
        ProdSaleCar.Visible = True
        ProdSaleCheese.Visible = True
        ProdSaleLing.Visible = True
        ProdSaleMilk.Visible = True
        ProdSaleNoods.Visible = True
        ProdSaleOil.Visible = True
        ProdSaleSalt.Visible = True
        ProdSaleTom.Visible = True
        ProdSaleWater.Visible = True
    End Sub

    Private Sub ButtNotHave_Click_1(sender As Object, e As EventArgs) Handles ButtNotHave.Click
        ProdSaleBow.Visible = False
        ProdSaleBread.Visible = False
        ProdSaleCar.Visible = False
        ProdSaleCheese.Visible = False
        ProdSaleLing.Visible = False
        ProdSaleMilk.Visible = False
        ProdSaleNoods.Visible = False
        ProdSaleOil.Visible = False
        ProdSaleSalt.Visible = False
        ProdSaleTom.Visible = False
        ProdSaleWater.Visible = False

        For Each comboItem In ComboAdd.Items
            Select Case GetItemNum(comboItem)
                Case BOWTIE
                    ProdSaleBow.Visible = True
                Case BREAD
                    ProdSaleBread.Visible = True
                Case CARROTS
                    ProdSaleCar.Visible = True
                Case CHEESE
                    ProdSaleCheese.Visible = True
                Case INST_NOODS
                    ProdSaleNoods.Visible = True
                Case VEG_OIL
                    ProdSaleOil.Visible = True
                Case LINGUINE
                    ProdSaleLing.Visible = True
                Case MILK
                    ProdSaleMilk.Visible = True
                Case SEA_SALT
                    ProdSaleSalt.Visible = True
                Case TOMATO
                    ProdSaleTom.Visible = True
                Case WATER
                    ProdSaleWater.Visible = True
            End Select
        Next

    End Sub

    Public Function MissingItems()
        Return ComboAdd.Items
    End Function

    Public Function isInInven(itemName As String)
        'MsgBox(itemName)

        For Each comboItem In ComboRem.Items
            If comboItem = itemName Then
                Return True
                'MsgBox("TRUE")
            End If
        Next

        'MsgBox("FLASE")

        Return False

    End Function

    Private Sub ComboAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboAdd.SelectedIndexChanged
        Select Case ComboAdd.SelectedItem.ToString()
            Case "Milk"
                UnitAdd.Text = "Unit: " + ProdMilk.unit
            Case "Bowtie"
                UnitAdd.Text = "Unit: " + ProdBowtie.unit
            Case "Bread"
                UnitAdd.Text = "Unit: " + ProdBread.unit
            Case "Carrots"
                UnitAdd.Text = "Unit: " + ProdCarrots.unit
            Case "Cheese"
                UnitAdd.Text = "Unit: " + ProdCheese.unit
            Case "Instant Noodles"
                UnitAdd.Text = "Unit: " + ProdInstNoods.unit
            Case "Linguine"
                UnitAdd.Text = "Unit: " + ProdLing.unit
            Case "Sea Salt"
                UnitAdd.Text = "Unit: " + ProdSalt.unit
            Case "Tomato"
                UnitAdd.Text = "Unit: " + ProdTomato.unit
            Case "Vegetable Oil"
                UnitAdd.Text = "Unit: " + ProdOil.unit
            Case "Water"
                UnitAdd.Text = "Unit: " + ProdWater.unit
        End Select
    End Sub

    Private Sub ComboMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMod.SelectedIndexChanged
        Select Case ComboMod.SelectedItem.ToString()
            Case "Milk"
                UnitMod.Text = "Unit: " + ProdMilk.unit
            Case "Bowtie"
                UnitMod.Text = "Unit: " + ProdBowtie.unit
            Case "Bread"
                UnitMod.Text = "Unit: " + ProdBread.unit
            Case "Carrots"
                UnitMod.Text = "Unit: " + ProdCarrots.unit
            Case "Cheese"
                UnitMod.Text = "Unit: " + ProdCheese.unit
            Case "Instant Noodles"
                UnitMod.Text = "Unit: " + ProdInstNoods.unit
            Case "Linguine"
                UnitMod.Text = "Unit: " + ProdLing.unit
            Case "Sea Salt"
                UnitMod.Text = "Unit: " + ProdSalt.unit
            Case "Tomato"
                UnitMod.Text = "Unit: " + ProdTomato.unit
            Case "Vegetable Oil"
                UnitMod.Text = "Unit: " + ProdOil.unit
            Case "Water"
                UnitMod.Text = "Unit: " + ProdWater.unit
        End Select
    End Sub


End Class
