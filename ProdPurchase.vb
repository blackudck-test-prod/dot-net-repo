
Public Class ProdPurchase
    Public baseProduce As Produce
    Public bought As Boolean
    Public Sub New(ByRef produce As Produce)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call
        Me.baseProduce = produce
        Label4.Text = baseProduce.price
        Label2.Text = baseProduce.store
        Produce1.amo = baseProduce.amo
        Produce1.prod = baseProduce.prod
        Produce1.unit = baseProduce.unit
        imageFix(baseProduce.prod)

    End Sub

    Private Sub CheckBox1_CheckedChanged() Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            bought = True
        Else
            bought = False
        End If
    End Sub

    Private Sub imageFix(name As String)
        Select Case name
            Case "Bowtie"
                Produce1.img = My.Resources.Resources.bowtie
            Case "Bread"
                Produce1.img = My.Resources.Resources.bread
            Case "Carrots"
                Produce1.img = My.Resources.Resources.Carrots
            Case "Cheese"
                Produce1.img = My.Resources.Resources.cheese
            Case "Instant Noodles"
                Produce1.img = My.Resources.Resources.noods
            Case "Linguine"
                Produce1.img = My.Resources.Resources.linguine
            Case "Milk"
                Produce1.img = My.Resources.Resources.milk
            Case "Sea Salt"
                Produce1.img = My.Resources.Resources.seaSalt
            Case "Tomato"
                Produce1.img = My.Resources.Resources.tomato
            Case "Vegetable Oil"
                Produce1.img = My.Resources.Resources.vegOil
            Case "Water"
                Produce1.img = My.Resources.Resources.water
        End Select
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub

End Class
