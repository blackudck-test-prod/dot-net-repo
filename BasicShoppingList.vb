Public Class BasicShoppingList
    Dim baseNote As StickyNote
    Public Property title As String
        Get
            Return ListTitle.Text
        End Get
        Set
            ListTitle.Text = Value
        End Set
    End Property

    Public Property ShopDate As String
        Get
            Return ShopByLabel.Text
        End Get
        Set
            ShopByLabel.Text = Value
        End Set
    End Property

    Public Sub New(ByRef baseNote As StickyNote)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.baseNote = baseNote
        title = baseNote.ShoppingListName

        If baseNote.Frequency < 0 Then
            ShopDate = "Shop by: " + baseNote.ShoppingDate
        ElseIf baseNote.Frequency > 0 Then
            ShopDate = "Shop: " + baseNote.FrequencyWord(baseNote.Frequency)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inp = New PurchaseList(baseNote)
        inp.Show()
        Form1.shopperPhone.currentPurchaseList = inp
        Shopper.Hide()
    End Sub
End Class
