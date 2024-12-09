<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendToShopperPrompt
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
        Label1 = New Label()
        YesButton = New Button()
        NoButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 31)
        Label1.TabIndex = 0
        Label1.Text = "Send to Shopper?"
        ' 
        ' YesButton
        ' 
        YesButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        YesButton.Location = New Point(12, 66)
        YesButton.Name = "YesButton"
        YesButton.Size = New Size(88, 33)
        YesButton.TabIndex = 1
        YesButton.Text = "Yes"
        YesButton.UseVisualStyleBackColor = True
        ' 
        ' NoButton
        ' 
        NoButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NoButton.Location = New Point(106, 66)
        NoButton.Name = "NoButton"
        NoButton.Size = New Size(88, 33)
        NoButton.TabIndex = 2
        NoButton.Text = "No"
        NoButton.UseVisualStyleBackColor = True
        ' 
        ' SendToShopperPrompt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(352, 120)
        Controls.Add(NoButton)
        Controls.Add(YesButton)
        Controls.Add(Label1)
        Name = "SendToShopperPrompt"
        Text = "SendToShopperPrompt"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents YesButton As Button
    Friend WithEvents NoButton As Button
End Class
