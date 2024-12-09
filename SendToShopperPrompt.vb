
Public Class SendToShopperPrompt
    Dim baseNote As StickyNote
    Public Sub New(ByRef baseNote As StickyNote)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Label1.Text = $"Send {baseNote.ShoppingListName} to Shopper?"
        Me.baseNote = baseNote

    End Sub
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        Shopper.sentLists.Add(baseNote)
        Shopper.refreshItems()
        baseNote.SendLabel.Visible = True
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Hide()
    End Sub
End Class