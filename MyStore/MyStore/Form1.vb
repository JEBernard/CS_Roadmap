Public Class Form1
    Dim Cheese As String                'Declare Class Variables 
    Dim Pepperoni As String
    Dim Veggie As String
    Dim tip As Decimal
    Dim subTotal As Decimal
    Dim Total As Decimal
    Const PRICE_CHEESE As Decimal = 2.73          'Price of pizzas
    Const PRICE_PEPPERONI As Decimal = 3.21
    Const PRICE_VEGGIE As Decimal = 5.21
    Const tax As Decimal = 0.07                 'Tax rate

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        If Not IsNumeric(txtTip.Text) Then     'Check if Tip Amount entered was a number 
            txtTip.Text = ""
            MsgBox("Not a number", MsgBoxStyle.Critical)
            Return
        End If

        If (txtTip.Text) > 0 Then 'Check if tip amount entered is greater than 0 
            tip = CStr(txtTip.Text)
            Cheese = CStr(txtCheese.Text)
            Pepperoni = CStr(txtPepp.Text)
            Veggie = CStr(txtVeg.Text)
            subTotal = Cheese * PRICE_CHEESE + Pepperoni * PRICE_PEPPERONI + Veggie * PRICE_VEGGIE 'Calculate the Sub Total
            Dim price = subTotal.ToString("C") 'Currency format
            lblSubTotal.Text = price
            Dim calcTax As Decimal = subTotal * tax 'Multiply the Sub Total by the tax rate
            Dim priceTax = calcTax.ToString("C")
            lblTax.Text = priceTax
            Dim Total As Decimal = subTotal + calcTax + tip 'Add the tip
            Dim totalPrice = Total.ToString("C")
            lblTotal.Text = totalPrice
            btnTotal.Enabled = False
            lblTipInclude.Show()  ' Displays the message "Total includes a tip"
        Else                    ' No tip was added
            Cheese = CStr(txtCheese.Text)
            Pepperoni = CStr(txtPepp.Text)
            Veggie = CStr(txtVeg.Text)
            Dim subTotal As Decimal = Cheese * PRICE_CHEESE + Pepperoni * PRICE_PEPPERONI + Veggie * PRICE_VEGGIE
            lblSubTotal.Text = "$ " + subTotal.ToString
            Dim calcTax As Decimal = subTotal * tax
            lblTax.Text = "$ " + calcTax
            Dim Total As Decimal = subTotal + calcTax 'No tip was added
            lblTotal.Text = "$ " + Total
            btnTotal.Enabled = False


        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()  'Exit the program
    End Sub

   
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCheese.Text = ""                     'Clearing all of the controls and setting focus back to Clear button
        txtPepp.Text = ""
        txtVeg.Text = ""
        txtTip.Text = ""
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblTipInclude.Hide()
        lblTotal.Text = ""
        btnTotal.Enabled = True
        Me.btnClear.Focus()


    End Sub
End Class
