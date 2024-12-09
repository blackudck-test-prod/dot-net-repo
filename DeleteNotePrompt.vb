Public Class DeleteNotePrompt
    Dim baseNote As StickyNote
    Public Sub New(ByRef baseNote As StickyNote)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Label1.Text = $"Delete {baseNote.ShoppingListName}?"
        Me.baseNote = baseNote

    End Sub

    Private Sub yesbuttonclick() Handles Yes.Click
        baseNote.Dispose()
        Me.Close()
    End Sub

    Private Sub nobuttonclick() Handles No.Click
        Me.Hide()
    End Sub

End Class