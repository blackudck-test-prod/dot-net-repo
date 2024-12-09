<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseList
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        PurchaseButton = New Button()
        BackButton = New Button()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        AddPanel = New Panel()
        UnitAdd = New Label()
        ComboAdd = New ComboBox()
        InputAmountAdd = New TextBox()
        Label4 = New Label()
        CancelButton = New Button()
        OkayButton = New Button()
        Label5 = New Label()
        Label6 = New Label()
        AddPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.Location = New Point(42, 97)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(396, 341)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(37, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 28)
        Label1.TabIndex = 1
        Label1.Text = "List Title:"
        ' 
        ' PurchaseButton
        ' 
        PurchaseButton.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        PurchaseButton.Location = New Point(37, 538)
        PurchaseButton.Name = "PurchaseButton"
        PurchaseButton.Size = New Size(193, 48)
        PurchaseButton.TabIndex = 2
        PurchaseButton.Text = "Purchase Items"
        PurchaseButton.UseVisualStyleBackColor = True
        ' 
        ' BackButton
        ' 
        BackButton.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        BackButton.Location = New Point(245, 538)
        BackButton.Name = "BackButton"
        BackButton.Size = New Size(193, 48)
        BackButton.TabIndex = 3
        BackButton.Text = "Go Back"
        BackButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(37, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 28)
        Label2.TabIndex = 4
        Label2.Text = "Shop By:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(221, 15)
        Label3.TabIndex = 5
        Label3.Text = "Here are the items on your shopping list:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Any", "FreshCO", "Sobeys"})
        ComboBox1.Location = New Point(317, 68)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "Sort By..."
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(42, 444)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 29)
        Button1.TabIndex = 7
        Button1.Text = "Add Additional Items"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AddPanel
        ' 
        AddPanel.BorderStyle = BorderStyle.Fixed3D
        AddPanel.Controls.Add(UnitAdd)
        AddPanel.Controls.Add(ComboAdd)
        AddPanel.Controls.Add(InputAmountAdd)
        AddPanel.Controls.Add(Label4)
        AddPanel.Location = New Point(37, 477)
        AddPanel.Margin = New Padding(1)
        AddPanel.Name = "AddPanel"
        AddPanel.Size = New Size(401, 52)
        AddPanel.TabIndex = 8
        AddPanel.Visible = False
        ' 
        ' UnitAdd
        ' 
        UnitAdd.AutoSize = True
        UnitAdd.Location = New Point(322, 15)
        UnitAdd.Name = "UnitAdd"
        UnitAdd.Size = New Size(32, 15)
        UnitAdd.TabIndex = 4
        UnitAdd.Text = "Unit:"
        ' 
        ' ComboAdd
        ' 
        ComboAdd.FormattingEnabled = True
        ComboAdd.Items.AddRange(New Object() {"Bowtie", "Bread", "Carrots", "Cheese", "Instant Noodles", "Linguine", "Milk", "Sea Salt", "Tomato", "Vegetable Oil", "Water"})
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
        InputAmountAdd.Size = New Size(34, 23)
        InputAmountAdd.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(228, 16)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 1
        Label4.Text = "Amount:"
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(361, 444)
        CancelButton.Margin = New Padding(1)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(69, 29)
        CancelButton.TabIndex = 14
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        CancelButton.Visible = False
        ' 
        ' OkayButton
        ' 
        OkayButton.Location = New Point(292, 444)
        OkayButton.Margin = New Padding(1)
        OkayButton.Name = "OkayButton"
        OkayButton.Size = New Size(67, 29)
        OkayButton.TabIndex = 13
        OkayButton.Text = "Okay"
        OkayButton.UseVisualStyleBackColor = True
        OkayButton.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(125, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 25)
        Label5.TabIndex = 15
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(125, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 25)
        Label6.TabIndex = 16
        Label6.Text = "Label6"
        ' 
        ' PurchaseList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(481, 602)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(CancelButton)
        Controls.Add(AddPanel)
        Controls.Add(OkayButton)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BackButton)
        Controls.Add(PurchaseButton)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        Name = "PurchaseList"
        Text = "PurchaseList"
        AddPanel.ResumeLayout(False)
        AddPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents AddPanel As Panel
    Friend WithEvents UnitAdd As Label
    Friend WithEvents ComboAdd As ComboBox
    Friend WithEvents InputAmountAdd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents OkayButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
