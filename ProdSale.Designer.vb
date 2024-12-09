<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdSale
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Prode = New Produce()
        Label1 = New Label()
        NewPrice = New Label()
        Label5 = New Label()
        OGPrice = New Label()
        LabelSale = New Label()
        Sale = New Label()
        LabelPer = New Label()
        SuspendLayout()
        ' 
        ' Prode
        ' 
        Prode.amo = "Amount: "
        Prode.BorderStyle = BorderStyle.Fixed3D
        Prode.img = Nothing
        Prode.inInven = False
        Prode.Location = New Point(0, 0)
        Prode.Margin = New Padding(0, 0, 0, 0)
        Prode.Name = "Prode"
        Prode.prod = "ProduceName"
        Prode.Size = New Size(269, 65)
        Prode.TabIndex = 0
        Prode.unit = "Unit:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 90)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 1
        Label1.Text = "Sale Price: "
        ' 
        ' NewPrice
        ' 
        NewPrice.AutoSize = True
        NewPrice.Location = New Point(79, 90)
        NewPrice.Margin = New Padding(1, 0, 1, 0)
        NewPrice.Name = "NewPrice"
        NewPrice.Size = New Size(41, 15)
        NewPrice.TabIndex = 2
        NewPrice.Text = "Label2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 73)
        Label5.Margin = New Padding(1, 0, 1, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 3
        Label5.Text = "Original Price:"
        ' 
        ' OGPrice
        ' 
        OGPrice.AutoSize = True
        OGPrice.Location = New Point(98, 73)
        OGPrice.Margin = New Padding(1, 0, 1, 0)
        OGPrice.Name = "OGPrice"
        OGPrice.Size = New Size(41, 15)
        OGPrice.TabIndex = 4
        OGPrice.Text = "Label4"
        ' 
        ' LabelSale
        ' 
        LabelSale.AutoSize = True
        LabelSale.ForeColor = Color.Green
        LabelSale.Location = New Point(283, 17)
        LabelSale.Margin = New Padding(1, 0, 1, 0)
        LabelSale.Name = "LabelSale"
        LabelSale.Size = New Size(36, 15)
        LabelSale.TabIndex = 5
        LabelSale.Text = "SALE:"
        ' 
        ' Sale
        ' 
        Sale.AutoSize = True
        Sale.Location = New Point(283, 32)
        Sale.Margin = New Padding(1, 0, 1, 0)
        Sale.Name = "Sale"
        Sale.Size = New Size(21, 15)
        Sale.TabIndex = 6
        Sale.Text = "##"
        ' 
        ' LabelPer
        ' 
        LabelPer.AutoSize = True
        LabelPer.Location = New Point(302, 32)
        LabelPer.Margin = New Padding(1, 0, 1, 0)
        LabelPer.Name = "LabelPer"
        LabelPer.Size = New Size(17, 15)
        LabelPer.TabIndex = 7
        LabelPer.Text = "%"
        ' 
        ' ProdSale
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.Fixed3D
        Controls.Add(LabelPer)
        Controls.Add(Sale)
        Controls.Add(LabelSale)
        Controls.Add(OGPrice)
        Controls.Add(Label5)
        Controls.Add(NewPrice)
        Controls.Add(Label1)
        Controls.Add(Prode)
        Margin = New Padding(1, 1, 1, 1)
        Name = "ProdSale"
        Size = New Size(345, 107)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Prode As Produce
    Friend WithEvents Label1 As Label
    Friend WithEvents NewPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OGPrice As Label
    Friend WithEvents LabelSale As Label
    Friend WithEvents Sale As Label
    Friend WithEvents LabelPer As Label
End Class
