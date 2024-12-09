Public Class ListBooklet
    Public routineShoppingLists As List(Of StickyNote) = New List(Of StickyNote)
    Public specificShoppingLists As List(Of StickyNote) = New List(Of StickyNote)

    Public recipeIngredients As List(Of Produce) = New List(Of Produce) From {
    New Produce(name:="carrots", amount:="2", image:=My.Resources.Resources.Carrots, price:=1.5, store:="FreshCO"),
    New Produce(name:="bowtie", amount:="1", image:=My.Resources.Resources.bowtie, price:=7, store:="Sobeys"),
    New Produce(name:="seaSalt", amount:="1", image:=My.Resources.Resources.seaSalt, price:=9, store:="Sobeys"),
    New Produce(name:="cheese", amount:="3", image:=My.Resources.Resources.cheese, price:=6, store:="FreshCO"),
    New Produce(name:="milk", amount:="2", image:=My.Resources.Resources.milk, price:=5, store:="FreshCO")}

    Public recipes As List(Of StickyNote) = New List(Of StickyNote) From {New StickyNote("Aunt May's Recipe", "Chicken Noodle Soup for cold days",
recipeIngredients, "Shopper", Date.Now, 1)}


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

    Public Shadows Sub DraggedUnder(ByRef sender As Draggable)
        MsgBox("draggable")
    End Sub

    Public Shadows Sub DraggedUnder(ByRef sender As StickyNote)
        MsgBox("sticky")
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

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim listCreate As New ListCreate()
        listCreate.Show()
        Form1.Hide()
    End Sub
End Class
