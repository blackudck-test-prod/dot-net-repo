Public Class Cart
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.


        'pass mouse events to parent
        For Each control As Control In Controls
            AddHandler control.MouseDown, AddressOf ItemMouseDown
            AddHandler control.MouseUp, AddressOf ItemMouseUp
            AddHandler control.MouseMove, AddressOf ItemMouseMove
        Next

    End Sub
    Shadows Sub draggedUnder(ByRef sticky As StickyNote)
        Dim inp = New SendToShopperPrompt(sticky)
        inp.Show()
    End Sub

    'pass mouse events to parent
    Private Sub ItemMouseDown(sender As Object, e As MouseEventArgs)
        OnMouseDown(e)
    End Sub
    Private Sub ItemMouseUp(sender As Object, e As MouseEventArgs)
        OnMouseUp(e)
    End Sub
    Private Sub ItemMouseMove(sender As Object, e As MouseEventArgs)
        OnMouseMove(e)
    End Sub

End Class
