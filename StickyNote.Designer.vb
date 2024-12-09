<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StickyNote
    Inherits Draggable

    'Control overrides dispose to clean up the component list.
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

    'Required by the Control Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  Do not modify it
    ' using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ListTitle = New Label()
        ShopperLabel = New Label()
        TypeLabel = New Label()
        ViewButton = New Button()
        EditButton = New Button()
        ShopperNameLabel = New Label()
        DateInfoLabel = New Label()
        GrabHand = New PictureBox()
        SendLabel = New Label()
        CType(GrabHand, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListTitle
        ' 
        ListTitle.AutoSize = True
        ListTitle.BackColor = Color.Transparent
        ListTitle.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        ListTitle.ForeColor = Color.Black
        ListTitle.Location = New Point(0, 14)
        ListTitle.Name = "ListTitle"
        ListTitle.Size = New Size(102, 32)
        ListTitle.TabIndex = 1
        ListTitle.Text = "List Title"
        ' 
        ' ShopperLabel
        ' 
        ShopperLabel.AutoSize = True
        ShopperLabel.BackColor = Color.Transparent
        ShopperLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ShopperLabel.ForeColor = Color.Black
        ShopperLabel.Location = New Point(3, 46)
        ShopperLabel.Name = "ShopperLabel"
        ShopperLabel.Size = New Size(84, 25)
        ShopperLabel.TabIndex = 6
        ShopperLabel.Text = "Shopper:"
        ' 
        ' TypeLabel
        ' 
        TypeLabel.AutoSize = True
        TypeLabel.BackColor = Color.Transparent
        TypeLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TypeLabel.ForeColor = Color.Black
        TypeLabel.Location = New Point(3, 96)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New Size(97, 25)
        TypeLabel.TabIndex = 7
        TypeLabel.Text = "Frequency:"
        ' 
        ' ViewButton
        ' 
        ViewButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ViewButton.Location = New Point(6, 152)
        ViewButton.Name = "ViewButton"
        ViewButton.Size = New Size(111, 36)
        ViewButton.TabIndex = 8
        ViewButton.Text = "Edit Details"
        ViewButton.UseVisualStyleBackColor = True
        ' 
        ' EditButton
        ' 
        EditButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EditButton.Location = New Point(6, 194)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(111, 37)
        EditButton.TabIndex = 9
        EditButton.Text = "Edit Items"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' ShopperNameLabel
        ' 
        ShopperNameLabel.AutoSize = True
        ShopperNameLabel.BackColor = Color.Transparent
        ShopperNameLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ShopperNameLabel.ForeColor = Color.Black
        ShopperNameLabel.Location = New Point(3, 71)
        ShopperNameLabel.Name = "ShopperNameLabel"
        ShopperNameLabel.Size = New Size(127, 25)
        ShopperNameLabel.TabIndex = 10
        ShopperNameLabel.Text = "ShopperName"
        ' 
        ' DateInfoLabel
        ' 
        DateInfoLabel.AutoSize = True
        DateInfoLabel.BackColor = Color.Transparent
        DateInfoLabel.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        DateInfoLabel.ForeColor = Color.Black
        DateInfoLabel.Location = New Point(3, 124)
        DateInfoLabel.Name = "DateInfoLabel"
        DateInfoLabel.Size = New Size(68, 25)
        DateInfoLabel.TabIndex = 11
        DateInfoLabel.Text = "Weekly"
        ' 
        ' GrabHand
        ' 
        GrabHand.BackColor = Color.Transparent
        GrabHand.BackgroundImage = My.Resources.Resources.GrabHand
        GrabHand.BackgroundImageLayout = ImageLayout.Stretch
        GrabHand.Location = New Point(96, 0)
        GrabHand.Name = "GrabHand"
        GrabHand.Size = New Size(28, 32)
        GrabHand.TabIndex = 12
        GrabHand.TabStop = False
        ' 
        ' SendLabel
        ' 
        SendLabel.AutoSize = True
        SendLabel.BackColor = Color.Transparent
        SendLabel.Font = New Font("Segoe UI Semibold", 7F, FontStyle.Bold, GraphicsUnit.Point)
        SendLabel.ForeColor = Color.Red
        SendLabel.Location = New Point(0, 2)
        SendLabel.Margin = New Padding(1, 0, 1, 0)
        SendLabel.Name = "SendLabel"
        SendLabel.Size = New Size(92, 12)
        SendLabel.TabIndex = 13
        SendLabel.Text = "SENT TO SHOPPER"
        SendLabel.Visible = False
        ' 
        ' StickyNote
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.stickynote4_0
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(SendLabel)
        Controls.Add(GrabHand)
        Controls.Add(DateInfoLabel)
        Controls.Add(ShopperNameLabel)
        Controls.Add(EditButton)
        Controls.Add(ViewButton)
        Controls.Add(TypeLabel)
        Controls.Add(ShopperLabel)
        Controls.Add(ListTitle)
        DoubleBuffered = True
        Name = "StickyNote"
        Size = New Size(124, 234)
        CType(GrabHand, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ListTitle As Label
    Friend WithEvents ShopperLabel As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents ViewButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents ShopperNameLabel As Label
    Friend WithEvents DateInfoLabel As Label
    Friend WithEvents GrabHand As PictureBox
    Friend WithEvents SendLabel As Label

End Class

