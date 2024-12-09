<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdPurchase
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
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Produce1 = New Produce()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(280, 24)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(63, 32)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Buy"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(183, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 3
        Label1.Text = "Store:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(226, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 4
        Label2.Text = "Label2"
        ' 
        ' Produce1
        ' 
        Produce1.amo = "Amount: "
        Produce1.BorderStyle = BorderStyle.Fixed3D
        Produce1.img = Nothing
        Produce1.inInven = False
        Produce1.Location = New Point(1, 0)
        Produce1.Margin = New Padding(1)
        Produce1.Name = "Produce1"
        Produce1.prod = "ProduceName"
        Produce1.Size = New Size(348, 65)
        Produce1.TabIndex = 5
        Produce1.unit = "Unit:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(85, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 6
        Label3.Text = "Price:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(127, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 7
        Label4.Text = "Label4"
        ' 
        ' ProdPurchase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.Fixed3D
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Controls.Add(Produce1)
        Name = "ProdPurchase"
        Size = New Size(346, 79)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Produce1 As Produce
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
