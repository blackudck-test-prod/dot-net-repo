<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shopper
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
        Panel1 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Panel2 = New Panel()
        ShopperTitle = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Panel3 = New Panel()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        OkayButton = New Button()
        CancelButton = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(53, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(380, 565)
        Panel1.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(20, 126)
        FlowLayoutPanel1.Margin = New Padding(1)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(341, 333)
        FlowLayoutPanel1.TabIndex = 17
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(87, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 23)
        Label1.TabIndex = 16
        Label1.Text = "Welcome Back Shopper 1!"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(ShopperTitle)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(380, 55)
        Panel2.TabIndex = 15
        ' 
        ' ShopperTitle
        ' 
        ShopperTitle.AutoSize = True
        ShopperTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        ShopperTitle.ForeColor = Color.Blue
        ShopperTitle.Location = New Point(28, 9)
        ShopperTitle.Name = "ShopperTitle"
        ShopperTitle.Size = New Size(325, 32)
        ShopperTitle.TabIndex = 13
        ShopperTitle.Text = "OurMeal Shopper Interface"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(236, 15)
        Label4.TabIndex = 14
        Label4.Text = "Here are the shopping lists assigned to you:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(20, 463)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 23)
        Button1.TabIndex = 1
        Button1.Text = "Volunteer To Shop"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(CancelButton)
        Panel3.Controls.Add(OkayButton)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(20, 492)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(341, 52)
        Panel3.TabIndex = 0
        Panel3.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(218, 15)
        Label2.TabIndex = 18
        Label2.Text = "Which list do you volunteer to shop for?"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(8, 26)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(135, 23)
        ComboBox1.TabIndex = 19
        ComboBox1.Text = "List..."
        ' 
        ' OkayButton
        ' 
        OkayButton.Location = New Point(149, 26)
        OkayButton.Name = "OkayButton"
        OkayButton.Size = New Size(75, 23)
        OkayButton.TabIndex = 20
        OkayButton.Text = "Okay"
        OkayButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.Location = New Point(230, 26)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(75, 23)
        CancelButton.TabIndex = 21
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = True
        ' 
        ' Shopper
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.phone
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(479, 725)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "Shopper"
        Text = "Shopper"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ShopperTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CancelButton As Button
    Friend WithEvents OkayButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
