<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecipeBooklet
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
        Label1 = New Label()
        ButView = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(57, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 106)
        Label1.TabIndex = 0
        Label1.Text = "Recipes"
        ' 
        ' ButView
        ' 
        ButView.Location = New Point(78, 267)
        ButView.Name = "ButView"
        ButView.Size = New Size(272, 178)
        ButView.TabIndex = 1
        ButView.Text = "View"
        ButView.UseVisualStyleBackColor = True
        ' 
        ' RecipeBooklet
        ' 
        AutoScaleDimensions = New SizeF(20F, 48F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.recipe
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(ButView)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "RecipeBooklet"
        Size = New Size(420, 502)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButView As Button
End Class
