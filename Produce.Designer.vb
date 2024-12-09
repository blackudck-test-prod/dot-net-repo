<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produce
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        ImageList1 = New ImageList(components)
        ProdPic = New PictureBox()
        ProdName = New Label()
        Amount = New Label()
        Label1 = New Label()
        LabelInven = New Label()
        ItemUnit = New Label()
        Label2 = New Label()
        CType(ProdPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' ProdPic
        ' 
        ProdPic.BackgroundImage = My.Resources.Resources.banana
        ProdPic.BackgroundImageLayout = ImageLayout.Stretch
        ProdPic.BorderStyle = BorderStyle.Fixed3D
        ProdPic.Location = New Point(15, 8)
        ProdPic.Margin = New Padding(1)
        ProdPic.Name = "ProdPic"
        ProdPic.Size = New Size(58, 50)
        ProdPic.TabIndex = 0
        ProdPic.TabStop = False
        ' 
        ' ProdName
        ' 
        ProdName.AutoSize = True
        ProdName.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        ProdName.Location = New Point(77, 8)
        ProdName.Margin = New Padding(1, 0, 1, 0)
        ProdName.Name = "ProdName"
        ProdName.Size = New Size(136, 28)
        ProdName.TabIndex = 1
        ProdName.Text = "ProduceName"
        ' 
        ' Amount
        ' 
        Amount.AutoSize = True
        Amount.Location = New Point(138, 41)
        Amount.Margin = New Padding(1, 0, 1, 0)
        Amount.Name = "Amount"
        Amount.Size = New Size(57, 15)
        Amount.TabIndex = 2
        Amount.Text = "Amount: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 41)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 3
        Label1.Text = "Amount:"
        ' 
        ' LabelInven
        ' 
        LabelInven.AutoSize = True
        LabelInven.Font = New Font("Segoe UI", 6.0F, FontStyle.Regular, GraphicsUnit.Point)
        LabelInven.ForeColor = Color.Red
        LabelInven.Location = New Point(217, 4)
        LabelInven.Margin = New Padding(1, 0, 1, 0)
        LabelInven.Name = "LabelInven"
        LabelInven.Size = New Size(111, 11)
        LabelInven.TabIndex = 4
        LabelInven.Text = "ITEM ALREADY IN INVENTORY"
        LabelInven.Visible = False
        ' 
        ' ItemUnit
        ' 
        ItemUnit.AutoSize = True
        ItemUnit.Location = New Point(217, 41)
        ItemUnit.Name = "ItemUnit"
        ItemUnit.Size = New Size(32, 15)
        ItemUnit.TabIndex = 5
        ItemUnit.Text = "Unit:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(181, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 6
        Label2.Text = "Unit:"
        ' 
        ' Produce
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.Fixed3D
        Controls.Add(Label2)
        Controls.Add(ItemUnit)
        Controls.Add(LabelInven)
        Controls.Add(Label1)
        Controls.Add(Amount)
        Controls.Add(ProdName)
        Controls.Add(ProdPic)
        Margin = New Padding(1)
        Name = "Produce"
        Size = New Size(346, 65)
        CType(ProdPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ProdPic As PictureBox
    Friend WithEvents ProdName As Label
    Friend WithEvents Amount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelInven As Label
    Friend WithEvents ItemUnit As Label
    Friend WithEvents Label2 As Label
End Class
