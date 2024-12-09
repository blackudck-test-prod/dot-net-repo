<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BasicShoppingList
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
        NotificationLabel = New Label()
        PictureBox1 = New PictureBox()
        ListTitle = New Label()
        ShopByLabel = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NotificationLabel
        ' 
        NotificationLabel.AutoSize = True
        NotificationLabel.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        NotificationLabel.ForeColor = Color.Red
        NotificationLabel.Location = New Point(242, 13)
        NotificationLabel.Margin = New Padding(1, 0, 1, 0)
        NotificationLabel.Name = "NotificationLabel"
        NotificationLabel.Size = New Size(85, 15)
        NotificationLabel.TabIndex = 5
        NotificationLabel.Text = "LIST MODIFIED"
        NotificationLabel.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.rb_42430
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(14, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(78, 66)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' ListTitle
        ' 
        ListTitle.AutoSize = True
        ListTitle.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        ListTitle.Location = New Point(98, 13)
        ListTitle.Name = "ListTitle"
        ListTitle.Size = New Size(83, 28)
        ListTitle.TabIndex = 7
        ListTitle.Text = "List Title"
        ' 
        ' ShopByLabel
        ' 
        ShopByLabel.AutoSize = True
        ShopByLabel.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        ShopByLabel.Location = New Point(98, 41)
        ShopByLabel.Name = "ShopByLabel"
        ShopByLabel.Size = New Size(79, 28)
        ShopByLabel.TabIndex = 8
        ShopByLabel.Text = "ShopBy"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(232, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 42)
        Button1.TabIndex = 9
        Button1.Text = "View List"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BasicShoppingList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.Fixed3D
        Controls.Add(Button1)
        Controls.Add(ShopByLabel)
        Controls.Add(ListTitle)
        Controls.Add(PictureBox1)
        Controls.Add(NotificationLabel)
        Name = "BasicShoppingList"
        Size = New Size(336, 91)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NotificationLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListTitle As Label
    Friend WithEvents ShopByLabel As Label
    Friend WithEvents Button1 As Button

End Class
