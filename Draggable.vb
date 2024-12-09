Imports System.CodeDom
Imports System.Windows.Forms.VisualStyles

Public Class Draggable
    Dim OldMouse As Point = New Point(0, 0)
    Dim fixed As Boolean = False

    Public Sub DraggedUnder(ByRef sender As Draggable)
        'gets called when another object is dragged over this one
    End Sub

    Public Sub DraggedOver(ByRef sender As Draggable)
        'gets called when this object gets dragged over another one
    End Sub

    Property fixedPosition As Boolean
        'defines wether object can be moved around
        'will respond to other objects dragged over it regardless
        Get
            Return fixed
        End Get
        Set(ByVal value As Boolean)
            fixed = value
        End Set
    End Property


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Draggable_MouseDown(sender As Object, e As EventArgs) Handles Me.MouseDown
        'set object to captured if its position is not fixed
        If fixed Then Return
        Capture = True
        OldMouse = Cursor.Position
        BringToFront()
    End Sub

    Private Sub Draggable_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        'uncapture object
        If fixed Then Return
        Capture = False
        'check for overlapping objects
        Dim boxRect As Rectangle = New Rectangle(Location, Size)
        For Each control In Parent.Controls
            If TypeOf control IsNot Draggable Then Continue For
            If Not control.Equals(Me) Then 'control cant intersect with itself
                If boxRect.IntersectsWith(New Rectangle(control.Location, control.Size)) Then
                    'call drag methods on intersection
                    control.DraggedUnder(Me)
                    DraggedOver(control)
                End If
            End If
        Next
    End Sub

    Private Sub Draggable_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'moves object based on mouse delta if captured
        If fixed Then Return
        If Not Capture Then Return
        Location += Cursor.Position - OldMouse
        OldMouse = Cursor.Position


    End Sub

End Class
