<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShoppingListEdit
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
        CancelMod = New Button()
        CancelRem = New Button()
        CancelAdd = New Button()
        ModPanel = New Panel()
        UnitMod = New Label()
        ComboMod = New ComboBox()
        InputAmountMod = New TextBox()
        Label3 = New Label()
        OkButMod = New Button()
        ModBut = New Button()
        RemovePanel = New Panel()
        ComboRem = New ComboBox()
        OkButRem = New Button()
        RemoveBut = New Button()
        AddPanel = New Panel()
        UnitAdd = New Label()
        ComboAdd = New ComboBox()
        InputAmountAdd = New TextBox()
        AmountName = New Label()
        OkButAdd = New Button()
        LabelProd = New Label()
        AddBut = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        SourcePanel = New Panel()
        SourceNameComboBox = New ComboBox()
        SourceComboBox = New ComboBox()
        SaveButton = New Button()
        ModPanel.SuspendLayout()
        RemovePanel.SuspendLayout()
        AddPanel.SuspendLayout()
        SourcePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' CancelMod
        ' 
        CancelMod.Location = New Point(674, 326)
        CancelMod.Margin = New Padding(1)
        CancelMod.Name = "CancelMod"
        CancelMod.Size = New Size(99, 32)
        CancelMod.TabIndex = 23
        CancelMod.Text = "Cancel"
        CancelMod.UseVisualStyleBackColor = True
        CancelMod.Visible = False
        ' 
        ' CancelRem
        ' 
        CancelRem.Location = New Point(674, 219)
        CancelRem.Margin = New Padding(1)
        CancelRem.Name = "CancelRem"
        CancelRem.Size = New Size(100, 32)
        CancelRem.TabIndex = 22
        CancelRem.Text = "Cancel"
        CancelRem.UseVisualStyleBackColor = True
        CancelRem.Visible = False
        ' 
        ' CancelAdd
        ' 
        CancelAdd.Location = New Point(674, 46)
        CancelAdd.Margin = New Padding(1)
        CancelAdd.Name = "CancelAdd"
        CancelAdd.Size = New Size(100, 32)
        CancelAdd.TabIndex = 21
        CancelAdd.Text = "Cancel"
        CancelAdd.UseVisualStyleBackColor = True
        CancelAdd.Visible = False
        ' 
        ' ModPanel
        ' 
        ModPanel.BorderStyle = BorderStyle.Fixed3D
        ModPanel.Controls.Add(UnitMod)
        ModPanel.Controls.Add(ComboMod)
        ModPanel.Controls.Add(InputAmountMod)
        ModPanel.Controls.Add(Label3)
        ModPanel.Location = New Point(354, 369)
        ModPanel.Margin = New Padding(1)
        ModPanel.Name = "ModPanel"
        ModPanel.Size = New Size(420, 52)
        ModPanel.TabIndex = 17
        ModPanel.Visible = False
        ' 
        ' UnitMod
        ' 
        UnitMod.AutoSize = True
        UnitMod.Location = New Point(330, 18)
        UnitMod.Name = "UnitMod"
        UnitMod.Size = New Size(32, 15)
        UnitMod.TabIndex = 6
        UnitMod.Text = "Unit:"
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
        ' InputAmountMod
        ' 
        InputAmountMod.Location = New Point(284, 15)
        InputAmountMod.Margin = New Padding(1)
        InputAmountMod.Name = "InputAmountMod"
        InputAmountMod.Size = New Size(43, 23)
        InputAmountMod.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(228, 16)
        Label3.Margin = New Padding(1, 0, 1, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 1
        Label3.Text = "Amount:"
        ' 
        ' OkButMod
        ' 
        OkButMod.Location = New Point(572, 326)
        OkButMod.Margin = New Padding(1)
        OkButMod.Name = "OkButMod"
        OkButMod.Size = New Size(100, 32)
        OkButMod.TabIndex = 0
        OkButMod.Text = "Okay"
        OkButMod.UseVisualStyleBackColor = True
        OkButMod.Visible = False
        ' 
        ' ModBut
        ' 
        ModBut.Location = New Point(354, 326)
        ModBut.Margin = New Padding(1)
        ModBut.Name = "ModBut"
        ModBut.Size = New Size(126, 32)
        ModBut.TabIndex = 20
        ModBut.Text = "Modify Produce"
        ModBut.UseVisualStyleBackColor = True
        ' 
        ' RemovePanel
        ' 
        RemovePanel.BorderStyle = BorderStyle.Fixed3D
        RemovePanel.Controls.Add(ComboRem)
        RemovePanel.Location = New Point(352, 260)
        RemovePanel.Margin = New Padding(1)
        RemovePanel.Name = "RemovePanel"
        RemovePanel.Size = New Size(420, 52)
        RemovePanel.TabIndex = 19
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
        ComboRem.Text = "Pick Product"
        ' 
        ' OkButRem
        ' 
        OkButRem.Location = New Point(572, 219)
        OkButRem.Margin = New Padding(1)
        OkButRem.Name = "OkButRem"
        OkButRem.Size = New Size(100, 32)
        OkButRem.TabIndex = 4
        OkButRem.Text = "Okay"
        OkButRem.UseVisualStyleBackColor = True
        OkButRem.Visible = False
        ' 
        ' RemoveBut
        ' 
        RemoveBut.Location = New Point(353, 219)
        RemoveBut.Margin = New Padding(1)
        RemoveBut.Name = "RemoveBut"
        RemoveBut.Size = New Size(126, 32)
        RemoveBut.TabIndex = 18
        RemoveBut.Text = "Remove Produce"
        RemoveBut.UseVisualStyleBackColor = True
        ' 
        ' AddPanel
        ' 
        AddPanel.BorderStyle = BorderStyle.Fixed3D
        AddPanel.Controls.Add(UnitAdd)
        AddPanel.Controls.Add(ComboAdd)
        AddPanel.Controls.Add(InputAmountAdd)
        AddPanel.Controls.Add(AmountName)
        AddPanel.Location = New Point(353, 143)
        AddPanel.Margin = New Padding(1)
        AddPanel.Name = "AddPanel"
        AddPanel.Size = New Size(420, 52)
        AddPanel.TabIndex = 16
        AddPanel.Visible = False
        ' 
        ' UnitAdd
        ' 
        UnitAdd.AutoSize = True
        UnitAdd.Location = New Point(331, 15)
        UnitAdd.Name = "UnitAdd"
        UnitAdd.Size = New Size(32, 15)
        UnitAdd.TabIndex = 5
        UnitAdd.Text = "Unit:"
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
        ' InputAmountAdd
        ' 
        InputAmountAdd.Location = New Point(284, 15)
        InputAmountAdd.Margin = New Padding(1)
        InputAmountAdd.Name = "InputAmountAdd"
        InputAmountAdd.Size = New Size(43, 23)
        InputAmountAdd.TabIndex = 2
        ' 
        ' AmountName
        ' 
        AmountName.AutoSize = True
        AmountName.Location = New Point(228, 16)
        AmountName.Margin = New Padding(1, 0, 1, 0)
        AmountName.Name = "AmountName"
        AmountName.Size = New Size(54, 15)
        AmountName.TabIndex = 1
        AmountName.Text = "Amount:"
        ' 
        ' OkButAdd
        ' 
        OkButAdd.Location = New Point(572, 46)
        OkButAdd.Margin = New Padding(1)
        OkButAdd.Name = "OkButAdd"
        OkButAdd.Size = New Size(100, 32)
        OkButAdd.TabIndex = 0
        OkButAdd.Text = "Okay"
        OkButAdd.UseVisualStyleBackColor = True
        OkButAdd.Visible = False
        ' 
        ' LabelProd
        ' 
        LabelProd.AutoSize = True
        LabelProd.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        LabelProd.Location = New Point(9, 7)
        LabelProd.Margin = New Padding(1, 0, 1, 0)
        LabelProd.Name = "LabelProd"
        LabelProd.Size = New Size(178, 37)
        LabelProd.TabIndex = 15
        LabelProd.Text = "ShoppingList:"
        ' 
        ' AddBut
        ' 
        AddBut.Location = New Point(354, 46)
        AddBut.Margin = New Padding(1)
        AddBut.Name = "AddBut"
        AddBut.Size = New Size(126, 32)
        AddBut.TabIndex = 14
        AddBut.Text = "Add Produce"
        AddBut.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(9, 46)
        FlowLayoutPanel1.Margin = New Padding(1)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(312, 609)
        FlowLayoutPanel1.TabIndex = 13
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' SourcePanel
        ' 
        SourcePanel.Controls.Add(SourceNameComboBox)
        SourcePanel.Controls.Add(SourceComboBox)
        SourcePanel.Location = New Point(353, 81)
        SourcePanel.Margin = New Padding(3, 2, 3, 2)
        SourcePanel.Name = "SourcePanel"
        SourcePanel.Size = New Size(421, 44)
        SourcePanel.TabIndex = 24
        SourcePanel.Visible = False
        ' 
        ' SourceNameComboBox
        ' 
        SourceNameComboBox.Enabled = False
        SourceNameComboBox.FormattingEnabled = True
        SourceNameComboBox.Location = New Point(231, 11)
        SourceNameComboBox.Margin = New Padding(3, 2, 3, 2)
        SourceNameComboBox.Name = "SourceNameComboBox"
        SourceNameComboBox.Size = New Size(176, 23)
        SourceNameComboBox.TabIndex = 1
        ' 
        ' SourceComboBox
        ' 
        SourceComboBox.FormattingEnabled = True
        SourceComboBox.Items.AddRange(New Object() {"Any", "Inventory", "Recipe", "Routine Shopping List", "Specific Shopping List"})
        SourceComboBox.Location = New Point(9, 11)
        SourceComboBox.Margin = New Padding(3, 2, 3, 2)
        SourceComboBox.Name = "SourceComboBox"
        SourceComboBox.Size = New Size(119, 23)
        SourceComboBox.TabIndex = 0
        SourceComboBox.Text = "Add From..."
        ' 
        ' SaveButton
        ' 
        SaveButton.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point)
        SaveButton.Location = New Point(360, 529)
        SaveButton.Margin = New Padding(3, 2, 3, 2)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(400, 89)
        SaveButton.TabIndex = 25
        SaveButton.Text = "Return To Fridge"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' ShoppingListEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(807, 672)
        Controls.Add(OkButRem)
        Controls.Add(OkButAdd)
        Controls.Add(SaveButton)
        Controls.Add(OkButMod)
        Controls.Add(SourcePanel)
        Controls.Add(CancelMod)
        Controls.Add(CancelRem)
        Controls.Add(CancelAdd)
        Controls.Add(ModPanel)
        Controls.Add(ModBut)
        Controls.Add(RemovePanel)
        Controls.Add(RemoveBut)
        Controls.Add(AddPanel)
        Controls.Add(LabelProd)
        Controls.Add(AddBut)
        Controls.Add(FlowLayoutPanel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ShoppingListEdit"
        Text = "ShoppingList"
        ModPanel.ResumeLayout(False)
        ModPanel.PerformLayout()
        RemovePanel.ResumeLayout(False)
        AddPanel.ResumeLayout(False)
        AddPanel.PerformLayout()
        SourcePanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CancelMod As Button
    Friend WithEvents CancelRem As Button
    Friend WithEvents CancelAdd As Button
    Friend WithEvents ModPanel As Panel
    Friend WithEvents ComboMod As ComboBox
    Friend WithEvents InputAmountMod As TextBox
    Friend WithEvents OkButMod As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ModBut As Button
    Friend WithEvents RemovePanel As Panel
    Friend WithEvents OkButRem As Button
    Friend WithEvents ComboRem As ComboBox
    Friend WithEvents RemoveBut As Button
    Friend WithEvents AddPanel As Panel
    Friend WithEvents ComboAdd As ComboBox
    Friend WithEvents InputAmountAdd As TextBox
    Friend WithEvents OkButAdd As Button
    Friend WithEvents AmountName As Label
    Friend WithEvents LabelProd As Label
    Friend WithEvents AddBut As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ProdMilk As Produce
    Friend WithEvents ProdBowtie As Produce
    Friend WithEvents ProdLing As Produce
    Friend WithEvents ProdOil As Produce
    Friend WithEvents ProdBread As Produce
    Friend WithEvents ProdSalt As Produce
    Friend WithEvents ProdWater As Produce
    Friend WithEvents ProdCheese As Produce
    Friend WithEvents ProdInstNoods As Produce
    Friend WithEvents ProdCarrots As Produce
    Friend WithEvents SourcePanel As Panel
    Friend WithEvents SourceNameComboBox As ComboBox
    Friend WithEvents SourceComboBox As ComboBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents UnitMod As Label
    Friend WithEvents UnitAdd As Label
End Class
