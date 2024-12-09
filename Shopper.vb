Imports System.Reflection.Emit

Public Class Shopper
    Dim baseNote As StickyNote
    Public currentPurchaseList As PurchaseList
    Public sentLists As List(Of StickyNote) = New List(Of StickyNote)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshItems()
    End Sub

    Public Sub refreshItems()
        'refresh shopping lists when changed
        FlowLayoutPanel1.Controls.Clear()

        For Each item As StickyNote In sentLists
            Dim basic As New BasicShoppingList(item)

            FlowLayoutPanel1.Controls.Add(basic)
        Next

    End Sub

    Private Sub OkayButton_Click(sender As Object, e As EventArgs) Handles OkayButton.Click

        If ComboBox1.SelectedIndex < Form1.ListBooklet1.specificShoppingLists.Count Then

            Me.sentLists.Add(Form1.ListBooklet1.specificShoppingLists.ElementAt(ComboBox1.SelectedIndex))
        Else
            Me.sentLists.Add(Form1.ListBooklet1.routineShoppingLists.ElementAt(ComboBox1.SelectedIndex - Form1.ListBooklet1.specificShoppingLists.Count))
        End If


        Me.refreshItems()
        CancelButton_Click()
    End Sub

    Private Sub CancelButton_Click() Handles CancelButton.Click
        ComboBox1.Text = "List..."
        Panel3.Visible = False

        ComboBox1.DataSource = Nothing
        ComboBox1.Items.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = True

        For Each item In Form1.ListBooklet1.specificShoppingLists
            If (Not sentLists.Contains(item)) Then ComboBox1.Items.Add(item.ShoppingListName)

        Next

        For Each item In Form1.ListBooklet1.routineShoppingLists
            If (Not sentLists.Contains(item)) Then ComboBox1.Items.Add(item.ShoppingListName)
        Next

    End Sub

End Class