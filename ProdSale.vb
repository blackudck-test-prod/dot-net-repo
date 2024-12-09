Public Class ProdSale

    Dim isSal As Boolean
    Public Property prod As String
        Get
            Return Prode.ProdName.Text
        End Get
        Set
            Prode.ProdName.Text = Value
        End Set
    End Property

    Public Property unit As String
        Get
            Return Prode.unit
        End Get
        Set
            Prode.unit = Value
        End Set
    End Property

    Public Property amo As String
        Get
            Return Prode.Amount.Text
        End Get
        Set
            Prode.Amount.Text = Value
        End Set
    End Property

    Public Property img As Bitmap
        Get
            Return Prode.ProdPic.Image
        End Get
        Set
            Prode.ProdPic.BackgroundImage = Value
        End Set
    End Property

    Public Property SaleNum As String
        Get
            Return Sale.Text
        End Get
        Set
            Sale.Text = Value
        End Set
    End Property

    Public Property isOnSale As Boolean
        Get
            Return isSal
        End Get
        Set
            isSal = Value

            If Value = True Then
                LabelSale.Text = "SALE:"
                LabelSale.ForeColor = Color.Green
                Sale.Visible = True
                LabelPer.Visible = True
            Else
                LabelSale.Text = "NO SALE"
                LabelSale.ForeColor = Color.Red
                Sale.Visible = False
                LabelPer.Visible = False
            End If
        End Set
    End Property

    Public Property PriceOG As String
        Get
            Return OGPrice.Text
        End Get
        Set
            OGPrice.Text = Value
        End Set
    End Property

    Public Property PriceSale As String
        Get
            Return NewPrice.Text
        End Get
        Set
            NewPrice.Text = Value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Prode.BorderStyle = BorderStyle.None
    End Sub

End Class
