Public Class Produce
    Public store As String
    Public price As Double

    Dim isInven As Boolean
    Public Property prod As String
        Get
            Return ProdName.Text
        End Get
        Set
            ProdName.Text = Value
        End Set
    End Property

    Public Property amo As String
        Get
            Return Amount.Text
        End Get
        Set
            Amount.Text = Value
        End Set
    End Property

    Public Property unit As String
        Get
            Return ItemUnit.Text
        End Get
        Set
            ItemUnit.Text = Value
        End Set
    End Property

    Public Property img As Bitmap
        Get
            Return ProdPic.Image
        End Get
        Set

            ProdPic.BackgroundImage = Value
        End Set
    End Property

    Public Property inInven As Boolean
        Get
            Return isInven
        End Get
        Set
            isInven = Value

            If Value = True Then
                LabelInven.Visible = True
            Else
                LabelInven.Visible = False
            End If

        End Set
    End Property

    Public Sub New(Optional name As String = "ProduceName", ByVal Optional amount As String = "0", ByVal Optional image As Bitmap = Nothing,
                   ByVal Optional store As String = "Sobeys", ByVal Optional price As Double = 0, ByVal Optional unit As String = "unit")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        prod = name
        amo = amount
        img = image
        Me.unit = unit
        Me.store = store
        Me.price = price

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class
