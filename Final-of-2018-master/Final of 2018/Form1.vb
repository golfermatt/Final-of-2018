Public Class Form1

    Dim LightPaperCost As Decimal = 0
    Dim HeavyPaperCost As Decimal = 0
    Dim TransparentPaperCost As Decimal = 0
    Dim FinalCostBeforeTax As Decimal = 0
    Dim TaxCalc As Decimal = 0
    Dim TaxCalcString As String
    Dim FinalCost As Decimal = 0
    Dim QuantitiyOfItemsOrdered As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LightPaperCost = (NumericUpDown1.Value * 12)
        HeavyPaperCost = (NumericUpDown2.Value * 5)
        TransparentPaperCost = (NumericUpDown3.Value * 200)

        FinalCostBeforeTax = (LightPaperCost + HeavyPaperCost + TransparentPaperCost)

        TaxCalc = (FinalCostBeforeTax * 0.045)
        FinalCost = (TaxCalc + FinalCostBeforeTax)

        QuantitiyOfItemsOrdered = (NumericUpDown1.Value + NumericUpDown2.Value + NumericUpDown3.Value)
        If QuantitiyOfItemsOrdered > 25 Then
            FinalCost = (TaxCalc + FinalCostBeforeTax + 10)
        End If

        'Cost calculations broken

        Receipt.ListBox1.Items.Add("Light Paper - " & (NumericUpDown1.Value))
        Receipt.ListBox1.Items.Add("Heavy Paper - " & (NumericUpDown2.Value))
        Receipt.ListBox1.Items.Add("Transparent Paper - " & (NumericUpDown3.Value))
        Receipt.ListBox1.Items.Add("Tax (4.5%) ")


        Receipt.ListBox2.Items.Add(LightPaperCost)
        Receipt.ListBox2.Items.Add(HeavyPaperCost)
        Receipt.ListBox2.Items.Add(TransparentPaperCost)
        Receipt.ListBox2.Items.Add(TaxCalc)


        If QuantitiyOfItemsOrdered > 25 Then
            Receipt.ListBox1.Items.Add("Shipping & Handling")
            Receipt.ListBox2.Items.Add("10")
        End If

        Receipt.ListBox1.Items.Add("")
        Receipt.ListBox2.Items.Add("")

        Receipt.ListBox1.Items.Add("Total ")
        Receipt.ListBox2.Items.Add("$ " & FinalCost)


        Receipt.Show()

    End Sub
End Class
