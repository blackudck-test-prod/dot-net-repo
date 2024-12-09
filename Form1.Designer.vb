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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        FridgeTitle = New Label()
        Panel1 = New Panel()
        TabPage1 = New TabPage()
        Label2 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        ProdSaleCar = New ProdSale()
        ProdSaleNoods = New ProdSale()
        ProdSaleCheese = New ProdSale()
        ProdSaleWater = New ProdSale()
        ProdSaleTom = New ProdSale()
        ProdSaleSalt = New ProdSale()
        ProdSaleBread = New ProdSale()
        ProdSaleOil = New ProdSale()
        ProdSaleLing = New ProdSale()
        ProdSaleBow = New ProdSale()
        ProdSaleMilk = New ProdSale()
        Produce1 = New Produce()
        ButtAll = New Button()
        ButNotHave = New Button()
        ButAll = New Button()
        ButtNotHave = New Button()
        Inventory = New TabPage()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        ProdWater = New Produce()
        ProdOil = New Produce()
        ProdTomato = New Produce()
        ProdSalt = New Produce()
        ProdLing = New Produce()
        ProdInstNoods = New Produce()
        ProdCheese = New Produce()
        ProdCarrots = New Produce()
        ProdBread = New Produce()
        ProdBowtie = New Produce()
        ProdMilk = New Produce()
        AddBut = New Button()
        LabelProd = New Label()
        AddPanel = New Panel()
        Label1 = New Label()
        InputAmountAdd = New TextBox()
        ComboAdd = New ComboBox()
        UnitAdd = New Label()
        RemoveBut = New Button()
        RemovePanel = New Panel()
        ComboRem = New ComboBox()
        ModBut = New Button()
        ModPanel = New Panel()
        Label3 = New Label()
        InputAmountMod = New TextBox()
        ComboMod = New ComboBox()
        UnitMod = New Label()
        CancelAdd = New Button()
        OkButAdd = New Button()
        CancelRem = New Button()
        OkButMod = New Button()
        CancelMod = New Button()
        OkButRem = New Button()
        Home = New TabPage()
        ListBooklet1 = New ListBooklet()
        TrashCan1 = New TrashCan()
        RecipeBooklet1 = New RecipeBooklet()
        StickyNote1 = New StickyNote()
        Cart1 = New Cart()
        TabControl1 = New TabControl()
        Panel1.SuspendLayout()
        TabPage1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        Inventory.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        AddPanel.SuspendLayout()
        RemovePanel.SuspendLayout()
        ModPanel.SuspendLayout()
        Home.SuspendLayout()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' FridgeTitle
        ' 
        FridgeTitle.AutoSize = True
        FridgeTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        FridgeTitle.ForeColor = Color.Blue
        FridgeTitle.Location = New Point(269, 1)
        FridgeTitle.Name = "FridgeTitle"
        FridgeTitle.Size = New Size(302, 32)
        FridgeTitle.TabIndex = 15
        FridgeTitle.Text = "OurMeal Fridge Interface"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(FridgeTitle)
        Panel1.Location = New Point(160, 542)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(846, 39)
        Panel1.TabIndex = 16
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(ButtNotHave)
        TabPage1.Controls.Add(ButAll)
        TabPage1.Controls.Add(ButNotHave)
        TabPage1.Controls.Add(ButtAll)
        TabPage1.Controls.Add(FlowLayoutPanel2)
        TabPage1.Controls.Add(Label2)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Margin = New Padding(1)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(1)
        TabPage1.Size = New Size(838, 504)
        TabPage1.TabIndex = 2
        TabPage1.Text = "Sales"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(7, 7)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(219, 37)
        Label2.TabIndex = 6
        Label2.Text = "Sales of the Day: "
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D
        FlowLayoutPanel2.Controls.Add(Produce1)
        FlowLayoutPanel2.Controls.Add(ProdSaleMilk)
        FlowLayoutPanel2.Controls.Add(ProdSaleBow)
        FlowLayoutPanel2.Controls.Add(ProdSaleLing)
        FlowLayoutPanel2.Controls.Add(ProdSaleOil)
        FlowLayoutPanel2.Controls.Add(ProdSaleBread)
        FlowLayoutPanel2.Controls.Add(ProdSaleSalt)
        FlowLayoutPanel2.Controls.Add(ProdSaleTom)
        FlowLayoutPanel2.Controls.Add(ProdSaleWater)
        FlowLayoutPanel2.Controls.Add(ProdSaleCheese)
        FlowLayoutPanel2.Controls.Add(ProdSaleNoods)
        FlowLayoutPanel2.Controls.Add(ProdSaleCar)
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(7, 46)
        FlowLayoutPanel2.Margin = New Padding(1)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(409, 403)
        FlowLayoutPanel2.TabIndex = 7
        FlowLayoutPanel2.WrapContents = False
        ' 
        ' ProdSaleCar
        ' 
        ProdSaleCar.amo = "3"
        ProdSaleCar.BorderStyle = BorderStyle.Fixed3D
        ProdSaleCar.img = Nothing
        ProdSaleCar.isOnSale = False
        ProdSaleCar.Location = New Point(0, 1165)
        ProdSaleCar.Margin = New Padding(0)
        ProdSaleCar.Name = "ProdSaleCar"
        ProdSaleCar.PriceOG = "3.49"
        ProdSaleCar.PriceSale = "No Sale Price"
        ProdSaleCar.prod = "Carrots"
        ProdSaleCar.SaleNum = "12.97"
        ProdSaleCar.Size = New Size(388, 116)
        ProdSaleCar.TabIndex = 11
        ProdSaleCar.unit = "Carrot"
        ' 
        ' ProdSaleNoods
        ' 
        ProdSaleNoods.amo = "0"
        ProdSaleNoods.BorderStyle = BorderStyle.Fixed3D
        ProdSaleNoods.img = Nothing
        ProdSaleNoods.isOnSale = False
        ProdSaleNoods.Location = New Point(0, 1049)
        ProdSaleNoods.Margin = New Padding(0)
        ProdSaleNoods.Name = "ProdSaleNoods"
        ProdSaleNoods.PriceOG = "12.67"
        ProdSaleNoods.PriceSale = "No Sale Price"
        ProdSaleNoods.prod = "Instant Noodle"
        ProdSaleNoods.SaleNum = "12.97"
        ProdSaleNoods.Size = New Size(388, 116)
        ProdSaleNoods.TabIndex = 10
        ProdSaleNoods.unit = "Packet"
        ' 
        ' ProdSaleCheese
        ' 
        ProdSaleCheese.amo = "2"
        ProdSaleCheese.BorderStyle = BorderStyle.Fixed3D
        ProdSaleCheese.img = Nothing
        ProdSaleCheese.isOnSale = False
        ProdSaleCheese.Location = New Point(0, 933)
        ProdSaleCheese.Margin = New Padding(0)
        ProdSaleCheese.Name = "ProdSaleCheese"
        ProdSaleCheese.PriceOG = "5.98"
        ProdSaleCheese.PriceSale = "No Sale Price"
        ProdSaleCheese.prod = "Cheese"
        ProdSaleCheese.SaleNum = "15"
        ProdSaleCheese.Size = New Size(388, 116)
        ProdSaleCheese.TabIndex = 9
        ProdSaleCheese.unit = "300g Bag"
        ' 
        ' ProdSaleWater
        ' 
        ProdSaleWater.amo = "3"
        ProdSaleWater.BorderStyle = BorderStyle.Fixed3D
        ProdSaleWater.img = Nothing
        ProdSaleWater.isOnSale = False
        ProdSaleWater.Location = New Point(0, 817)
        ProdSaleWater.Margin = New Padding(0)
        ProdSaleWater.Name = "ProdSaleWater"
        ProdSaleWater.PriceOG = "2.88"
        ProdSaleWater.PriceSale = "No Sale Price"
        ProdSaleWater.prod = "Water"
        ProdSaleWater.SaleNum = "15"
        ProdSaleWater.Size = New Size(388, 116)
        ProdSaleWater.TabIndex = 8
        ProdSaleWater.unit = "Bottle"
        ' 
        ' ProdSaleTom
        ' 
        ProdSaleTom.amo = "6"
        ProdSaleTom.BorderStyle = BorderStyle.Fixed3D
        ProdSaleTom.img = Nothing
        ProdSaleTom.isOnSale = False
        ProdSaleTom.Location = New Point(0, 701)
        ProdSaleTom.Margin = New Padding(0)
        ProdSaleTom.Name = "ProdSaleTom"
        ProdSaleTom.PriceOG = "5.99"
        ProdSaleTom.PriceSale = "No Sale Price"
        ProdSaleTom.prod = "Tomato"
        ProdSaleTom.SaleNum = "15"
        ProdSaleTom.Size = New Size(388, 116)
        ProdSaleTom.TabIndex = 7
        ProdSaleTom.unit = "Tomato"
        ' 
        ' ProdSaleSalt
        ' 
        ProdSaleSalt.amo = "0"
        ProdSaleSalt.BorderStyle = BorderStyle.Fixed3D
        ProdSaleSalt.img = Nothing
        ProdSaleSalt.isOnSale = False
        ProdSaleSalt.Location = New Point(0, 585)
        ProdSaleSalt.Margin = New Padding(0)
        ProdSaleSalt.Name = "ProdSaleSalt"
        ProdSaleSalt.PriceOG = "1.47"
        ProdSaleSalt.PriceSale = "No Sale Price"
        ProdSaleSalt.prod = "Sea Salt"
        ProdSaleSalt.SaleNum = "15"
        ProdSaleSalt.Size = New Size(388, 116)
        ProdSaleSalt.TabIndex = 6
        ProdSaleSalt.unit = "Box"
        ' 
        ' ProdSaleBread
        ' 
        ProdSaleBread.amo = "0"
        ProdSaleBread.BorderStyle = BorderStyle.Fixed3D
        ProdSaleBread.img = Nothing
        ProdSaleBread.isOnSale = False
        ProdSaleBread.Location = New Point(0, 469)
        ProdSaleBread.Margin = New Padding(0)
        ProdSaleBread.Name = "ProdSaleBread"
        ProdSaleBread.PriceOG = "5.00"
        ProdSaleBread.PriceSale = "No Sale Price"
        ProdSaleBread.prod = "Bread"
        ProdSaleBread.SaleNum = "15"
        ProdSaleBread.Size = New Size(388, 116)
        ProdSaleBread.TabIndex = 5
        ProdSaleBread.unit = "Loaf"
        ' 
        ' ProdSaleOil
        ' 
        ProdSaleOil.amo = "0"
        ProdSaleOil.BorderStyle = BorderStyle.Fixed3D
        ProdSaleOil.img = Nothing
        ProdSaleOil.isOnSale = False
        ProdSaleOil.Location = New Point(0, 353)
        ProdSaleOil.Margin = New Padding(0)
        ProdSaleOil.Name = "ProdSaleOil"
        ProdSaleOil.PriceOG = "13.97"
        ProdSaleOil.PriceSale = "No Sale Price"
        ProdSaleOil.prod = "Vegetable Oil"
        ProdSaleOil.SaleNum = "15"
        ProdSaleOil.Size = New Size(388, 116)
        ProdSaleOil.TabIndex = 4
        ProdSaleOil.unit = "1 Litre Bottle"
        ' 
        ' ProdSaleLing
        ' 
        ProdSaleLing.amo = "0"
        ProdSaleLing.BorderStyle = BorderStyle.Fixed3D
        ProdSaleLing.img = Nothing
        ProdSaleLing.isOnSale = True
        ProdSaleLing.Location = New Point(0, 237)
        ProdSaleLing.Margin = New Padding(0)
        ProdSaleLing.Name = "ProdSaleLing"
        ProdSaleLing.PriceOG = "3.49"
        ProdSaleLing.PriceSale = "2.97"
        ProdSaleLing.prod = "Linguine"
        ProdSaleLing.SaleNum = "15"
        ProdSaleLing.Size = New Size(388, 116)
        ProdSaleLing.TabIndex = 3
        ProdSaleLing.unit = "Box"
        ' 
        ' ProdSaleBow
        ' 
        ProdSaleBow.amo = "2"
        ProdSaleBow.BorderStyle = BorderStyle.Fixed3D
        ProdSaleBow.img = Nothing
        ProdSaleBow.isOnSale = True
        ProdSaleBow.Location = New Point(0, 121)
        ProdSaleBow.Margin = New Padding(0)
        ProdSaleBow.Name = "ProdSaleBow"
        ProdSaleBow.PriceOG = "3.49"
        ProdSaleBow.PriceSale = "3.14"
        ProdSaleBow.prod = "Bowtie"
        ProdSaleBow.SaleNum = "10"
        ProdSaleBow.Size = New Size(388, 116)
        ProdSaleBow.TabIndex = 2
        ProdSaleBow.unit = "Box"
        ' 
        ' ProdSaleMilk
        ' 
        ProdSaleMilk.amo = "0"
        ProdSaleMilk.BorderStyle = BorderStyle.Fixed3D
        ProdSaleMilk.img = Nothing
        ProdSaleMilk.isOnSale = True
        ProdSaleMilk.Location = New Point(0, 5)
        ProdSaleMilk.Margin = New Padding(0)
        ProdSaleMilk.Name = "ProdSaleMilk"
        ProdSaleMilk.PriceOG = "3.99"
        ProdSaleMilk.PriceSale = "3.79"
        ProdSaleMilk.prod = "Milk"
        ProdSaleMilk.SaleNum = "5"
        ProdSaleMilk.Size = New Size(388, 116)
        ProdSaleMilk.TabIndex = 1
        ProdSaleMilk.unit = "2 Litre Carton"
        ' 
        ' Produce1
        ' 
        Produce1.amo = "Amount: "
        Produce1.BorderStyle = BorderStyle.Fixed3D
        Produce1.img = Nothing
        Produce1.inInven = False
        Produce1.Location = New Point(0, 0)
        Produce1.Margin = New Padding(0)
        Produce1.Name = "Produce1"
        Produce1.prod = "ProduceName"
        Produce1.Size = New Size(5, 5)
        Produce1.TabIndex = 0
        Produce1.unit = "Unit:"
        ' 
        ' ButtAll
        ' 
        ButtAll.Location = New Point(1238, 219)
        ButtAll.Name = "ButtAll"
        ButtAll.Size = New Size(410, 134)
        ButtAll.TabIndex = 8
        ButtAll.Text = "All Supplies"
        ButtAll.UseVisualStyleBackColor = True
        ' 
        ' ButNotHave
        ' 
        ButNotHave.Location = New Point(1238, 463)
        ButNotHave.Name = "ButNotHave"
        ButNotHave.Size = New Size(410, 134)
        ButNotHave.TabIndex = 9
        ButNotHave.Text = "Missing Supplies"
        ButNotHave.UseVisualStyleBackColor = True
        ' 
        ' ButAll
        ' 
        ButAll.Location = New Point(453, 46)
        ButAll.Margin = New Padding(1)
        ButAll.Name = "ButAll"
        ButAll.Size = New Size(194, 48)
        ButAll.TabIndex = 10
        ButAll.Text = "All Supplies"
        ButAll.UseVisualStyleBackColor = True
        ' 
        ' ButtNotHave
        ' 
        ButtNotHave.Location = New Point(453, 139)
        ButtNotHave.Margin = New Padding(1)
        ButtNotHave.Name = "ButtNotHave"
        ButtNotHave.Size = New Size(194, 48)
        ButtNotHave.TabIndex = 11
        ButtNotHave.Text = "Missing Supplies"
        ButtNotHave.UseVisualStyleBackColor = True
        ' 
        ' Inventory
        ' 
        Inventory.Controls.Add(OkButRem)
        Inventory.Controls.Add(CancelMod)
        Inventory.Controls.Add(OkButMod)
        Inventory.Controls.Add(CancelRem)
        Inventory.Controls.Add(OkButAdd)
        Inventory.Controls.Add(CancelAdd)
        Inventory.Controls.Add(ModPanel)
        Inventory.Controls.Add(ModBut)
        Inventory.Controls.Add(RemovePanel)
        Inventory.Controls.Add(RemoveBut)
        Inventory.Controls.Add(AddPanel)
        Inventory.Controls.Add(LabelProd)
        Inventory.Controls.Add(AddBut)
        Inventory.Controls.Add(FlowLayoutPanel1)
        Inventory.Location = New Point(4, 24)
        Inventory.Margin = New Padding(1)
        Inventory.Name = "Inventory"
        Inventory.Padding = New Padding(1)
        Inventory.Size = New Size(838, 504)
        Inventory.TabIndex = 1
        Inventory.Text = "Inventory"
        Inventory.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.Controls.Add(ProdMilk)
        FlowLayoutPanel1.Controls.Add(ProdBowtie)
        FlowLayoutPanel1.Controls.Add(ProdBread)
        FlowLayoutPanel1.Controls.Add(ProdCarrots)
        FlowLayoutPanel1.Controls.Add(ProdCheese)
        FlowLayoutPanel1.Controls.Add(ProdInstNoods)
        FlowLayoutPanel1.Controls.Add(ProdLing)
        FlowLayoutPanel1.Controls.Add(ProdSalt)
        FlowLayoutPanel1.Controls.Add(ProdTomato)
        FlowLayoutPanel1.Controls.Add(ProdOil)
        FlowLayoutPanel1.Controls.Add(ProdWater)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(7, 46)
        FlowLayoutPanel1.Margin = New Padding(1)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(341, 428)
        FlowLayoutPanel1.TabIndex = 1
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' ProdWater
        ' 
        ProdWater.amo = "3"
        ProdWater.BorderStyle = BorderStyle.Fixed3D
        ProdWater.img = Nothing
        ProdWater.inInven = False
        ProdWater.Location = New Point(0, 1030)
        ProdWater.Margin = New Padding(0)
        ProdWater.Name = "ProdWater"
        ProdWater.prod = "Water"
        ProdWater.Size = New Size(334, 103)
        ProdWater.TabIndex = 8
        ProdWater.unit = "Bottle"
        ' 
        ' ProdOil
        ' 
        ProdOil.amo = "1"
        ProdOil.BorderStyle = BorderStyle.Fixed3D
        ProdOil.img = Nothing
        ProdOil.inInven = False
        ProdOil.Location = New Point(0, 927)
        ProdOil.Margin = New Padding(0)
        ProdOil.Name = "ProdOil"
        ProdOil.prod = "Vegetable Oil"
        ProdOil.Size = New Size(334, 103)
        ProdOil.TabIndex = 4
        ProdOil.unit = "1 Litre Bottle"
        ProdOil.Visible = False
        ' 
        ' ProdTomato
        ' 
        ProdTomato.amo = "6"
        ProdTomato.BorderStyle = BorderStyle.Fixed3D
        ProdTomato.img = Nothing
        ProdTomato.inInven = False
        ProdTomato.Location = New Point(0, 824)
        ProdTomato.Margin = New Padding(0)
        ProdTomato.Name = "ProdTomato"
        ProdTomato.prod = "Tomato"
        ProdTomato.Size = New Size(334, 103)
        ProdTomato.TabIndex = 7
        ProdTomato.unit = "Tomato"
        ' 
        ' ProdSalt
        ' 
        ProdSalt.amo = "1"
        ProdSalt.BorderStyle = BorderStyle.Fixed3D
        ProdSalt.img = Nothing
        ProdSalt.inInven = False
        ProdSalt.Location = New Point(0, 721)
        ProdSalt.Margin = New Padding(0)
        ProdSalt.Name = "ProdSalt"
        ProdSalt.prod = "Sea Salt"
        ProdSalt.Size = New Size(334, 103)
        ProdSalt.TabIndex = 6
        ProdSalt.unit = "Box"
        ProdSalt.Visible = False
        ' 
        ' ProdLing
        ' 
        ProdLing.amo = "5"
        ProdLing.BorderStyle = BorderStyle.Fixed3D
        ProdLing.img = Nothing
        ProdLing.inInven = False
        ProdLing.Location = New Point(0, 618)
        ProdLing.Margin = New Padding(0)
        ProdLing.Name = "ProdLing"
        ProdLing.prod = "Linguine"
        ProdLing.Size = New Size(334, 103)
        ProdLing.TabIndex = 3
        ProdLing.unit = "Box"
        ProdLing.Visible = False
        ' 
        ' ProdInstNoods
        ' 
        ProdInstNoods.amo = "8"
        ProdInstNoods.BorderStyle = BorderStyle.Fixed3D
        ProdInstNoods.img = Nothing
        ProdInstNoods.inInven = False
        ProdInstNoods.Location = New Point(0, 515)
        ProdInstNoods.Margin = New Padding(0)
        ProdInstNoods.Name = "ProdInstNoods"
        ProdInstNoods.prod = "Instant Noodles"
        ProdInstNoods.Size = New Size(334, 103)
        ProdInstNoods.TabIndex = 10
        ProdInstNoods.unit = "Packet"
        ProdInstNoods.Visible = False
        ' 
        ' ProdCheese
        ' 
        ProdCheese.amo = "2"
        ProdCheese.BorderStyle = BorderStyle.Fixed3D
        ProdCheese.img = Nothing
        ProdCheese.inInven = False
        ProdCheese.Location = New Point(0, 412)
        ProdCheese.Margin = New Padding(0)
        ProdCheese.Name = "ProdCheese"
        ProdCheese.prod = "Cheese"
        ProdCheese.Size = New Size(334, 103)
        ProdCheese.TabIndex = 9
        ProdCheese.unit = "300g Bag"
        ' 
        ' ProdCarrots
        ' 
        ProdCarrots.amo = "3"
        ProdCarrots.BorderStyle = BorderStyle.Fixed3D
        ProdCarrots.img = Nothing
        ProdCarrots.inInven = False
        ProdCarrots.Location = New Point(0, 309)
        ProdCarrots.Margin = New Padding(0)
        ProdCarrots.Name = "ProdCarrots"
        ProdCarrots.prod = "Carrots"
        ProdCarrots.Size = New Size(334, 103)
        ProdCarrots.TabIndex = 11
        ProdCarrots.unit = "Carrot"
        ' 
        ' ProdBread
        ' 
        ProdBread.amo = "6"
        ProdBread.BorderStyle = BorderStyle.Fixed3D
        ProdBread.img = Nothing
        ProdBread.inInven = False
        ProdBread.Location = New Point(0, 206)
        ProdBread.Margin = New Padding(0)
        ProdBread.Name = "ProdBread"
        ProdBread.prod = "Bread"
        ProdBread.Size = New Size(334, 103)
        ProdBread.TabIndex = 5
        ProdBread.unit = "Loaf"
        ProdBread.Visible = False
        ' 
        ' ProdBowtie
        ' 
        ProdBowtie.amo = "2"
        ProdBowtie.BorderStyle = BorderStyle.Fixed3D
        ProdBowtie.img = Nothing
        ProdBowtie.inInven = False
        ProdBowtie.Location = New Point(0, 103)
        ProdBowtie.Margin = New Padding(0)
        ProdBowtie.Name = "ProdBowtie"
        ProdBowtie.prod = "Bowtie"
        ProdBowtie.Size = New Size(334, 103)
        ProdBowtie.TabIndex = 2
        ProdBowtie.unit = "Box"
        ' 
        ' ProdMilk
        ' 
        ProdMilk.amo = "1"
        ProdMilk.BorderStyle = BorderStyle.Fixed3D
        ProdMilk.img = Nothing
        ProdMilk.inInven = False
        ProdMilk.Location = New Point(0, 0)
        ProdMilk.Margin = New Padding(0)
        ProdMilk.Name = "ProdMilk"
        ProdMilk.prod = "Milk"
        ProdMilk.Size = New Size(334, 103)
        ProdMilk.TabIndex = 12
        ProdMilk.unit = "2 Litre Carton"
        ProdMilk.Visible = False
        ' 
        ' AddBut
        ' 
        AddBut.Location = New Point(366, 47)
        AddBut.Margin = New Padding(1)
        AddBut.Name = "AddBut"
        AddBut.Size = New Size(126, 32)
        AddBut.TabIndex = 2
        AddBut.Text = "Add Produce"
        AddBut.UseVisualStyleBackColor = True
        ' 
        ' LabelProd
        ' 
        LabelProd.AutoSize = True
        LabelProd.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        LabelProd.Location = New Point(7, 7)
        LabelProd.Margin = New Padding(1, 0, 1, 0)
        LabelProd.Name = "LabelProd"
        LabelProd.Size = New Size(120, 37)
        LabelProd.TabIndex = 5
        LabelProd.Text = "Produce:"
        ' 
        ' AddPanel
        ' 
        AddPanel.BorderStyle = BorderStyle.Fixed3D
        AddPanel.Controls.Add(UnitAdd)
        AddPanel.Controls.Add(ComboAdd)
        AddPanel.Controls.Add(InputAmountAdd)
        AddPanel.Controls.Add(Label1)
        AddPanel.Location = New Point(365, 88)
        AddPanel.Margin = New Padding(1)
        AddPanel.Name = "AddPanel"
        AddPanel.Size = New Size(437, 52)
        AddPanel.TabIndex = 6
        AddPanel.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(228, 16)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 1
        Label1.Text = "Amount:"
        ' 
        ' InputAmountAdd
        ' 
        InputAmountAdd.Location = New Point(284, 15)
        InputAmountAdd.Margin = New Padding(1)
        InputAmountAdd.Name = "InputAmountAdd"
        InputAmountAdd.Size = New Size(43, 23)
        InputAmountAdd.TabIndex = 2
        ' 
        ' ComboAdd
        ' 
        ComboAdd.FormattingEnabled = True
        ComboAdd.Items.AddRange(New Object() {"Milk", "Linguine", "Vegetable Oil", "Bread", "Sea Salt", "Instant Noodles"})
        ComboAdd.Location = New Point(6, 15)
        ComboAdd.Margin = New Padding(1)
        ComboAdd.Name = "ComboAdd"
        ComboAdd.Size = New Size(213, 23)
        ComboAdd.TabIndex = 3
        ComboAdd.Text = "Pick Product..."
        ' 
        ' UnitAdd
        ' 
        UnitAdd.AutoSize = True
        UnitAdd.Location = New Point(331, 15)
        UnitAdd.Name = "UnitAdd"
        UnitAdd.Size = New Size(32, 15)
        UnitAdd.TabIndex = 4
        UnitAdd.Text = "Unit:"
        ' 
        ' RemoveBut
        ' 
        RemoveBut.Location = New Point(365, 150)
        RemoveBut.Margin = New Padding(1)
        RemoveBut.Name = "RemoveBut"
        RemoveBut.Size = New Size(126, 32)
        RemoveBut.TabIndex = 7
        RemoveBut.Text = "Remove Produce"
        RemoveBut.UseVisualStyleBackColor = True
        ' 
        ' RemovePanel
        ' 
        RemovePanel.BorderStyle = BorderStyle.Fixed3D
        RemovePanel.Controls.Add(ComboRem)
        RemovePanel.Location = New Point(364, 191)
        RemovePanel.Margin = New Padding(1)
        RemovePanel.Name = "RemovePanel"
        RemovePanel.Size = New Size(438, 52)
        RemovePanel.TabIndex = 8
        RemovePanel.Visible = False
        ' 
        ' ComboRem
        ' 
        ComboRem.FormattingEnabled = True
        ComboRem.Items.AddRange(New Object() {"Bowtie", "Tomato", "Water", "Cheese", "Carrots"})
        ComboRem.Location = New Point(7, 16)
        ComboRem.Margin = New Padding(1)
        ComboRem.Name = "ComboRem"
        ComboRem.Size = New Size(317, 23)
        ComboRem.TabIndex = 4
        ComboRem.Text = "Pick Product..."
        ' 
        ' ModBut
        ' 
        ModBut.Location = New Point(366, 257)
        ModBut.Margin = New Padding(1)
        ModBut.Name = "ModBut"
        ModBut.Size = New Size(126, 32)
        ModBut.TabIndex = 9
        ModBut.Text = "Modify Produce"
        ModBut.UseVisualStyleBackColor = True
        ' 
        ' ModPanel
        ' 
        ModPanel.BorderStyle = BorderStyle.Fixed3D
        ModPanel.Controls.Add(UnitMod)
        ModPanel.Controls.Add(ComboMod)
        ModPanel.Controls.Add(InputAmountMod)
        ModPanel.Controls.Add(Label3)
        ModPanel.Location = New Point(366, 300)
        ModPanel.Margin = New Padding(1)
        ModPanel.Name = "ModPanel"
        ModPanel.Size = New Size(436, 52)
        ModPanel.TabIndex = 7
        ModPanel.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(230, 16)
        Label3.Margin = New Padding(1, 0, 1, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 1
        Label3.Text = "Amount:"
        ' 
        ' InputAmountMod
        ' 
        InputAmountMod.Location = New Point(284, 15)
        InputAmountMod.Margin = New Padding(1)
        InputAmountMod.Name = "InputAmountMod"
        InputAmountMod.Size = New Size(43, 23)
        InputAmountMod.TabIndex = 2
        ' 
        ' ComboMod
        ' 
        ComboMod.FormattingEnabled = True
        ComboMod.Items.AddRange(New Object() {"Bowtie", "Tomato", "Water", "Cheese", "Carrots"})
        ComboMod.Location = New Point(6, 15)
        ComboMod.Margin = New Padding(1)
        ComboMod.Name = "ComboMod"
        ComboMod.Size = New Size(213, 23)
        ComboMod.TabIndex = 3
        ComboMod.Text = "Pick Product..."
        ' 
        ' UnitMod
        ' 
        UnitMod.AutoSize = True
        UnitMod.Location = New Point(330, 16)
        UnitMod.Name = "UnitMod"
        UnitMod.Size = New Size(32, 15)
        UnitMod.TabIndex = 5
        UnitMod.Text = "Unit:"
        ' 
        ' CancelAdd
        ' 
        CancelAdd.Location = New Point(698, 47)
        CancelAdd.Margin = New Padding(1)
        CancelAdd.Name = "CancelAdd"
        CancelAdd.Size = New Size(100, 32)
        CancelAdd.TabIndex = 10
        CancelAdd.Text = "Cancel"
        CancelAdd.UseVisualStyleBackColor = True
        CancelAdd.Visible = False
        ' 
        ' OkButAdd
        ' 
        OkButAdd.Location = New Point(597, 47)
        OkButAdd.Margin = New Padding(1)
        OkButAdd.Name = "OkButAdd"
        OkButAdd.Size = New Size(98, 31)
        OkButAdd.TabIndex = 0
        OkButAdd.Text = "Okay"
        OkButAdd.UseVisualStyleBackColor = True
        OkButAdd.Visible = False
        ' 
        ' CancelRem
        ' 
        CancelRem.Location = New Point(698, 150)
        CancelRem.Margin = New Padding(1)
        CancelRem.Name = "CancelRem"
        CancelRem.Size = New Size(100, 32)
        CancelRem.TabIndex = 11
        CancelRem.Text = "Cancel"
        CancelRem.UseVisualStyleBackColor = True
        CancelRem.Visible = False
        ' 
        ' OkButMod
        ' 
        OkButMod.Location = New Point(598, 257)
        OkButMod.Margin = New Padding(1)
        OkButMod.Name = "OkButMod"
        OkButMod.Size = New Size(98, 32)
        OkButMod.TabIndex = 0
        OkButMod.Text = "Okay"
        OkButMod.UseVisualStyleBackColor = True
        OkButMod.Visible = False
        ' 
        ' CancelMod
        ' 
        CancelMod.Location = New Point(698, 257)
        CancelMod.Margin = New Padding(1)
        CancelMod.Name = "CancelMod"
        CancelMod.Size = New Size(100, 32)
        CancelMod.TabIndex = 12
        CancelMod.Text = "Cancel"
        CancelMod.UseVisualStyleBackColor = True
        CancelMod.Visible = False
        ' 
        ' OkButRem
        ' 
        OkButRem.Location = New Point(598, 151)
        OkButRem.Margin = New Padding(1)
        OkButRem.Name = "OkButRem"
        OkButRem.Size = New Size(98, 32)
        OkButRem.TabIndex = 4
        OkButRem.Text = "Okay"
        OkButRem.UseVisualStyleBackColor = True
        OkButRem.Visible = False
        ' 
        ' Home
        ' 
        Home.Controls.Add(Cart1)
        Home.Controls.Add(StickyNote1)
        Home.Controls.Add(RecipeBooklet1)
        Home.Controls.Add(TrashCan1)
        Home.Controls.Add(ListBooklet1)
        Home.Location = New Point(4, 24)
        Home.Margin = New Padding(1)
        Home.Name = "Home"
        Home.Padding = New Padding(1)
        Home.Size = New Size(838, 504)
        Home.TabIndex = 0
        Home.Text = "Home"
        Home.UseVisualStyleBackColor = True
        ' 
        ' ListBooklet1
        ' 
        ListBooklet1.BackgroundImage = CType(resources.GetObject("ListBooklet1.BackgroundImage"), Image)
        ListBooklet1.BackgroundImageLayout = ImageLayout.Stretch
        ListBooklet1.fixedPosition = True
        ListBooklet1.Location = New Point(505, 6)
        ListBooklet1.Margin = New Padding(3, 2, 3, 2)
        ListBooklet1.Name = "ListBooklet1"
        ListBooklet1.Size = New Size(151, 151)
        ListBooklet1.TabIndex = 5
        ' 
        ' TrashCan1
        ' 
        TrashCan1.BackgroundImage = CType(resources.GetObject("TrashCan1.BackgroundImage"), Image)
        TrashCan1.BackgroundImageLayout = ImageLayout.Stretch
        TrashCan1.fixedPosition = True
        TrashCan1.Location = New Point(653, 344)
        TrashCan1.Margin = New Padding(9, 10, 9, 10)
        TrashCan1.Name = "TrashCan1"
        TrashCan1.Size = New Size(150, 150)
        TrashCan1.TabIndex = 9
        ' 
        ' RecipeBooklet1
        ' 
        RecipeBooklet1.BackgroundImage = CType(resources.GetObject("RecipeBooklet1.BackgroundImage"), Image)
        RecipeBooklet1.BackgroundImageLayout = ImageLayout.Stretch
        RecipeBooklet1.Location = New Point(653, 6)
        RecipeBooklet1.Margin = New Padding(0)
        RecipeBooklet1.Name = "RecipeBooklet1"
        RecipeBooklet1.Size = New Size(150, 158)
        RecipeBooklet1.TabIndex = 11
        ' 
        ' StickyNote1
        ' 
        StickyNote1.AssignedShopper = "Housemate 1"
        StickyNote1.BackColor = Color.White
        StickyNote1.BackgroundImage = CType(resources.GetObject("StickyNote1.BackgroundImage"), Image)
        StickyNote1.BackgroundImageLayout = ImageLayout.Stretch
        StickyNote1.fixedPosition = False
        StickyNote1.Frequency = 7
        StickyNote1.Location = New Point(33, 28)
        StickyNote1.Margin = New Padding(13, 17, 13, 17)
        StickyNote1.Name = "StickyNote1"
        StickyNote1.Purpose = "Basic stuff"
        StickyNote1.ShoppingDate = New Date(2024, 11, 24, 14, 4, 41, 596)
        StickyNote1.ShoppingListName = "Basics"
        StickyNote1.Size = New Size(124, 234)
        StickyNote1.TabIndex = 13
        ' 
        ' Cart1
        ' 
        Cart1.BackgroundImage = CType(resources.GetObject("Cart1.BackgroundImage"), Image)
        Cart1.BackgroundImageLayout = ImageLayout.Zoom
        Cart1.fixedPosition = True
        Cart1.Location = New Point(22, 344)
        Cart1.Name = "Cart1"
        Cart1.Size = New Size(150, 150)
        Cart1.TabIndex = 14
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Home)
        TabControl1.Controls.Add(Inventory)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Location = New Point(160, 10)
        TabControl1.Margin = New Padding(1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(846, 532)
        TabControl1.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fridge_door
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1090, 653)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        Inventory.ResumeLayout(False)
        Inventory.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        AddPanel.ResumeLayout(False)
        AddPanel.PerformLayout()
        RemovePanel.ResumeLayout(False)
        ModPanel.ResumeLayout(False)
        ModPanel.PerformLayout()
        Home.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents StickyNote5 As StickyNote
    Friend WithEvents StickyNote4 As StickyNote
    Friend WithEvents StickyNote3 As StickyNote
    Friend WithEvents StickyNote8 As StickyNote
    Friend WithEvents StickyNote7 As StickyNote
    Friend WithEvents StickyNote6 As StickyNote
    Friend WithEvents FridgeTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ButtNotHave As Button
    Friend WithEvents ButAll As Button
    Friend WithEvents ButNotHave As Button
    Friend WithEvents ButtAll As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Produce1 As Produce
    Friend WithEvents ProdSaleMilk As ProdSale
    Friend WithEvents ProdSaleBow As ProdSale
    Friend WithEvents ProdSaleLing As ProdSale
    Friend WithEvents ProdSaleOil As ProdSale
    Friend WithEvents ProdSaleBread As ProdSale
    Friend WithEvents ProdSaleSalt As ProdSale
    Friend WithEvents ProdSaleTom As ProdSale
    Friend WithEvents ProdSaleWater As ProdSale
    Friend WithEvents ProdSaleCheese As ProdSale
    Friend WithEvents ProdSaleNoods As ProdSale
    Friend WithEvents ProdSaleCar As ProdSale
    Friend WithEvents Label2 As Label
    Friend WithEvents Inventory As TabPage
    Friend WithEvents OkButRem As Button
    Friend WithEvents CancelMod As Button
    Friend WithEvents OkButMod As Button
    Friend WithEvents CancelRem As Button
    Friend WithEvents OkButAdd As Button
    Friend WithEvents CancelAdd As Button
    Friend WithEvents ModPanel As Panel
    Friend WithEvents UnitMod As Label
    Friend WithEvents ComboMod As ComboBox
    Friend WithEvents InputAmountMod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ModBut As Button
    Friend WithEvents RemovePanel As Panel
    Friend WithEvents ComboRem As ComboBox
    Friend WithEvents RemoveBut As Button
    Friend WithEvents AddPanel As Panel
    Friend WithEvents UnitAdd As Label
    Friend WithEvents ComboAdd As ComboBox
    Friend WithEvents InputAmountAdd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelProd As Label
    Friend WithEvents AddBut As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ProdMilk As Produce
    Friend WithEvents ProdBowtie As Produce
    Friend WithEvents ProdBread As Produce
    Friend WithEvents ProdCarrots As Produce
    Friend WithEvents ProdCheese As Produce
    Friend WithEvents ProdInstNoods As Produce
    Friend WithEvents ProdLing As Produce
    Friend WithEvents ProdSalt As Produce
    Friend WithEvents ProdTomato As Produce
    Friend WithEvents ProdOil As Produce
    Friend WithEvents ProdWater As Produce
    Friend WithEvents Home As TabPage
    Friend WithEvents Cart1 As Cart
    Friend WithEvents StickyNote1 As StickyNote
    Friend WithEvents RecipeBooklet1 As RecipeBooklet
    Friend WithEvents TrashCan1 As TrashCan
    Friend WithEvents ListBooklet1 As ListBooklet
    Friend WithEvents TabControl1 As TabControl
End Class
