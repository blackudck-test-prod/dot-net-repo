Public Class StickyNote
    Public items As List(Of Produce) = New List(Of Produce) 'items in the list as an array of produce
    'Dim shopper As Shopper uncomment when shopper class is made
    Dim listPurpose As String  'purpose of the list
    Dim listFrequency As Integer  'number of days before list repeats set to -1 to indicate non routine list
    Dim listDate As Date = Nothing 'date the list needs to be shopped for

    Dim listName As String ' name of the list
    Dim shopper As String  ' name of the assigned shopper

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)



        'Add your custom paint code here
    End Sub

    Public Sub New(Optional name1 As String = "List Title", Optional purpose1 As String = "Nothing", Optional items1 As List(Of Produce) = Nothing,
                   Optional shopper1 As String = "Not Assigned", Optional date1 As Date = Nothing, Optional frequency1 As Integer = 7)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.


        'pass mouse events to parent
        For Each control In Controls
            If TypeOf control Is Button Then Continue For
            Dim c As Control = control
            AddHandler c.MouseDown, AddressOf ItemMouseDown
            AddHandler c.MouseUp, AddressOf ItemMouseUp
            AddHandler c.MouseMove, AddressOf ItemMouseMove
        Next

        If items1 Is Nothing Then
            Me.items = New List(Of Produce)
        Else
            Me.items = items1
        End If

        Purpose = purpose1
        Frequency = frequency1
        ShoppingDate = date1
        ShoppingListName = name1
        AssignedShopper = shopper1


        DateInfoLabel.Text = FrequencyWord(listFrequency)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        'pass mouse events to parent
        For Each control In Controls
            If TypeOf control Is Button Then Continue For
            Dim c As Control = control
            AddHandler c.MouseDown, AddressOf ItemMouseDown
            AddHandler c.MouseUp, AddressOf ItemMouseUp
            AddHandler c.MouseMove, AddressOf ItemMouseMove
        Next

        Me.items = New List(Of Produce)

        Purpose = "Nothing"
        Frequency = 7
        ShoppingDate = Date.Now
        ShoppingListName = "List Title"
        AssignedShopper = "Shopper"

    End Sub

    Public Function FrequencyWord(num As Integer) As String
        Select Case num
            Case -1
                Return "One-Time"
            Case 1
                Return "Daily"
            Case 7
                Return "Weekly"
            Case 30
                Return "Monthly"
        End Select
        Return Nothing
    End Function

    Property Purpose As String
        Get
            Return listPurpose
        End Get
        Set(value As String)
            listPurpose = value
        End Set
    End Property

    Property ShoppingDate As Date
        Get
            Return listDate
        End Get
        Set(value As Date)
            listDate = value
        End Set
    End Property

    Property ShoppingListName As String
        Get
            Return ListTitle.Text
        End Get
        Set(value As String)
            listName = value
            ListTitle.Text = listName
        End Set
    End Property

    Property AssignedShopper As String
        Get
            Return shopper
        End Get
        Set(value As String)
            shopper = value
            ShopperNameLabel.Text = value
        End Set
    End Property

    Property Frequency
        Get
            Return listFrequency
        End Get
        Set(value)
            listFrequency = value
            If listFrequency < 0 Then
                hideRoutine()
            Else
                showRoutine()
            End If

        End Set
    End Property

    Public Shadows Sub DraggedUnder(ByRef sender As Draggable)
        MsgBox("draggable")
    End Sub

    Public Shadows Sub DraggedUnder(ByRef sender As StickyNote)
        'MsgBox(items.)
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

    Private Sub editList(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim a = New ShoppingListEdit(Me)
        a.Show()
        Form1.Hide()
    End Sub

    Private Sub ViewDetails(sender As Object, e As EventArgs) Handles ViewButton.Click
        Dim a = New ShoppingListView(Me)
        a.Show()
        Form1.Hide()
    End Sub

    Private Sub hideRoutine()
        TypeLabel.Text = "Shop Date:"
        DateInfoLabel.Text = Me.ShoppingDate.ToString("yy-MM-dd")

    End Sub

    Private Sub ShowRoutine()
        TypeLabel.Text = "Frequency:"
        DateInfoLabel.Text = FrequencyWord(Frequency)

    End Sub
End Class
