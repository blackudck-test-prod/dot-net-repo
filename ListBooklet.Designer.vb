<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBooklet
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
        Lists = New Label()
        CreateButton = New Button()
        SuspendLayout()
        ' 
        ' Lists
        ' 
        Lists.AutoSize = True
        Lists.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Lists.Location = New Point(45, 20)
        Lists.Name = "Lists"
        Lists.Size = New Size(59, 32)
        Lists.TabIndex = 0
        Lists.Text = "Lists"
        ' 
        ' CreateButton
        ' 
        CreateButton.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        CreateButton.Location = New Point(35, 73)
        CreateButton.Name = "CreateButton"
        CreateButton.Size = New Size(82, 43)
        CreateButton.TabIndex = 2
        CreateButton.Text = "Create"
        CreateButton.UseVisualStyleBackColor = True
        ' 
        ' ListBooklet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        BackgroundImage = My.Resources.Resources.booklet
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(CreateButton)
        Controls.Add(Lists)
        fixedPosition = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "ListBooklet"
        Size = New Size(147, 157)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lists As Label
    Friend WithEvents CreateButton As Button

End Class

