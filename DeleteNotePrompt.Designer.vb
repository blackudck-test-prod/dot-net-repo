<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteNotePrompt
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
        Yes = New Button()
        No = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Yes
        ' 
        Yes.Location = New Point(5, 57)
        Yes.Name = "Yes"
        Yes.Size = New Size(75, 23)
        Yes.TabIndex = 0
        Yes.TabStop = False
        Yes.Text = "Yes"
        Yes.UseVisualStyleBackColor = True
        ' 
        ' No
        ' 
        No.Location = New Point(89, 57)
        No.Name = "No"
        No.Size = New Size(75, 23)
        No.TabIndex = 1
        No.Text = "No"
        No.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(5, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 30)
        Label1.TabIndex = 2
        Label1.Text = "Delete?"
        ' 
        ' DeleteNotePrompt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(176, 90)
        Controls.Add(Label1)
        Controls.Add(No)
        Controls.Add(Yes)
        Name = "DeleteNotePrompt"
        Text = "Delete Note"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Yes As Button
    Friend WithEvents No As Button
    Friend WithEvents Label1 As Label
End Class
