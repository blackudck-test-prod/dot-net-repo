<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipes
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
        PrevBut = New Button()
        NextBut = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        ProdCar = New Produce()
        ProdBow = New Produce()
        ProdSalt = New Produce()
        ProdChee = New Produce()
        ProdMilk = New Produce()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Produce1 = New Produce()
        Produce2 = New Produce()
        Produce3 = New Produce()
        Produce4 = New Produce()
        Produce5 = New Produce()
        Panel1 = New Panel()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PrevBut
        ' 
        PrevBut.Enabled = False
        PrevBut.Location = New Point(53, 352)
        PrevBut.Margin = New Padding(1)
        PrevBut.Name = "PrevBut"
        PrevBut.Size = New Size(107, 28)
        PrevBut.TabIndex = 2
        PrevBut.Text = "Previous"
        PrevBut.UseVisualStyleBackColor = True
        ' 
        ' NextBut
        ' 
        NextBut.Enabled = False
        NextBut.Location = New Point(183, 352)
        NextBut.Margin = New Padding(1)
        NextBut.Name = "NextBut"
        NextBut.Size = New Size(107, 28)
        NextBut.TabIndex = 3
        NextBut.Text = "Next"
        NextBut.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Add(ProdCar)
        FlowLayoutPanel1.Controls.Add(ProdBow)
        FlowLayoutPanel1.Controls.Add(ProdSalt)
        FlowLayoutPanel1.Controls.Add(ProdChee)
        FlowLayoutPanel1.Controls.Add(ProdMilk)
        FlowLayoutPanel1.Location = New Point(5, 49)
        FlowLayoutPanel1.Margin = New Padding(1)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(310, 266)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' ProdCar
        ' 
        ProdCar.amo = "2"
        ProdCar.BorderStyle = BorderStyle.Fixed3D
        ProdCar.img = Nothing
        ProdCar.inInven = False
        ProdCar.Location = New Point(0, 0)
        ProdCar.Margin = New Padding(0)
        ProdCar.Name = "ProdCar"
        ProdCar.prod = "Carrots"
        ProdCar.Size = New Size(294, 76)
        ProdCar.TabIndex = 1
        ProdCar.unit = " Carrot"
        ' 
        ' ProdBow
        ' 
        ProdBow.amo = "1"
        ProdBow.BorderStyle = BorderStyle.Fixed3D
        ProdBow.img = Nothing
        ProdBow.inInven = False
        ProdBow.Location = New Point(0, 76)
        ProdBow.Margin = New Padding(0)
        ProdBow.Name = "ProdBow"
        ProdBow.prod = "Bowtie"
        ProdBow.Size = New Size(294, 76)
        ProdBow.TabIndex = 2
        ProdBow.unit = "Box"
        ' 
        ' ProdSalt
        ' 
        ProdSalt.amo = "1"
        ProdSalt.BorderStyle = BorderStyle.Fixed3D
        ProdSalt.img = Nothing
        ProdSalt.inInven = False
        ProdSalt.Location = New Point(0, 152)
        ProdSalt.Margin = New Padding(0)
        ProdSalt.Name = "ProdSalt"
        ProdSalt.prod = "Sea Salt"
        ProdSalt.Size = New Size(294, 76)
        ProdSalt.TabIndex = 3
        ProdSalt.unit = "Box"
        ' 
        ' ProdChee
        ' 
        ProdChee.amo = "3"
        ProdChee.BorderStyle = BorderStyle.Fixed3D
        ProdChee.img = Nothing
        ProdChee.inInven = False
        ProdChee.Location = New Point(0, 228)
        ProdChee.Margin = New Padding(0)
        ProdChee.Name = "ProdChee"
        ProdChee.prod = "Cheese"
        ProdChee.Size = New Size(294, 76)
        ProdChee.TabIndex = 0
        ProdChee.unit = "300g Bag"
        ' 
        ' ProdMilk
        ' 
        ProdMilk.amo = "2"
        ProdMilk.BorderStyle = BorderStyle.Fixed3D
        ProdMilk.img = Nothing
        ProdMilk.inInven = False
        ProdMilk.Location = New Point(0, 304)
        ProdMilk.Margin = New Padding(0)
        ProdMilk.Name = "ProdMilk"
        ProdMilk.prod = "Milk"
        ProdMilk.Size = New Size(294, 76)
        ProdMilk.TabIndex = 4
        ProdMilk.unit = "2 Litre Carton"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(27, 9)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 28)
        Label1.TabIndex = 1
        Label1.Text = "Aunt May's Recipe"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(FlowLayoutPanel2)
        Panel2.Location = New Point(1, 378)
        Panel2.Margin = New Padding(1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(265, 323)
        Panel2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(27, 9)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 28)
        Label2.TabIndex = 1
        Label2.Text = "Aunt May's Recipe"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.Controls.Add(Produce1)
        FlowLayoutPanel2.Controls.Add(Produce2)
        FlowLayoutPanel2.Controls.Add(Produce3)
        FlowLayoutPanel2.Controls.Add(Produce4)
        FlowLayoutPanel2.Controls.Add(Produce5)
        FlowLayoutPanel2.Location = New Point(5, 49)
        FlowLayoutPanel2.Margin = New Padding(1)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(255, 266)
        FlowLayoutPanel2.TabIndex = 0
        ' 
        ' Produce1
        ' 
        Produce1.amo = "2"
        Produce1.BorderStyle = BorderStyle.Fixed3D
        Produce1.img = Nothing
        Produce1.inInven = False
        Produce1.Location = New Point(0, 0)
        Produce1.Margin = New Padding(0)
        Produce1.Name = "Produce1"
        Produce1.prod = "Carrots"
        Produce1.Size = New Size(236, 76)
        Produce1.TabIndex = 1
        Produce1.unit = "Unit:"
        ' 
        ' Produce2
        ' 
        Produce2.amo = "1"
        Produce2.BorderStyle = BorderStyle.Fixed3D
        Produce2.img = Nothing
        Produce2.inInven = False
        Produce2.Location = New Point(0, 76)
        Produce2.Margin = New Padding(0)
        Produce2.Name = "Produce2"
        Produce2.prod = "Bowtie"
        Produce2.Size = New Size(236, 76)
        Produce2.TabIndex = 2
        Produce2.unit = "Unit:"
        ' 
        ' Produce3
        ' 
        Produce3.amo = "1"
        Produce3.BorderStyle = BorderStyle.Fixed3D
        Produce3.img = Nothing
        Produce3.inInven = False
        Produce3.Location = New Point(0, 152)
        Produce3.Margin = New Padding(0)
        Produce3.Name = "Produce3"
        Produce3.prod = "Sea Salt"
        Produce3.Size = New Size(236, 76)
        Produce3.TabIndex = 3
        Produce3.unit = "Unit:"
        ' 
        ' Produce4
        ' 
        Produce4.amo = "3"
        Produce4.BorderStyle = BorderStyle.Fixed3D
        Produce4.img = Nothing
        Produce4.inInven = False
        Produce4.Location = New Point(0, 228)
        Produce4.Margin = New Padding(0)
        Produce4.Name = "Produce4"
        Produce4.prod = "Cheese"
        Produce4.Size = New Size(236, 76)
        Produce4.TabIndex = 0
        Produce4.unit = "Unit:"
        ' 
        ' Produce5
        ' 
        Produce5.amo = "2"
        Produce5.BorderStyle = BorderStyle.Fixed3D
        Produce5.img = Nothing
        Produce5.inInven = False
        Produce5.Location = New Point(0, 304)
        Produce5.Margin = New Padding(0)
        Produce5.Name = "Produce5"
        Produce5.prod = "Milk"
        Produce5.Size = New Size(236, 76)
        Produce5.TabIndex = 4
        Produce5.unit = "Unit:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Location = New Point(13, 8)
        Panel1.Margin = New Padding(1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(340, 323)
        Panel1.TabIndex = 4
        ' 
        ' Recipes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(366, 418)
        Controls.Add(Panel1)
        Controls.Add(NextBut)
        Controls.Add(PrevBut)
        Margin = New Padding(1)
        Name = "Recipes"
        Text = "Recipes"
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PrevBut As Button
    Friend WithEvents NextBut As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ProdCar As Produce
    Friend WithEvents ProdBow As Produce
    Friend WithEvents ProdSalt As Produce
    Friend WithEvents ProdChee As Produce
    Friend WithEvents ProdMilk As Produce
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Produce1 As Produce
    Friend WithEvents Produce2 As Produce
    Friend WithEvents Produce3 As Produce
    Friend WithEvents Produce4 As Produce
    Friend WithEvents Produce5 As Produce
    Friend WithEvents Panel1 As Panel
End Class
