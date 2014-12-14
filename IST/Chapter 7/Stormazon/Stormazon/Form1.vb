Public Class frmStartUp
    Public dblTotal As Double = 0
    Public dblSubTotal As Double = 0
    Public dblDelivery As Double = 0
    Public dblTax As Double = 0.07
    Public intNumberOfItems As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRemoveItems.Click
        'Remove Selected Item from listbox and update the total
        Try
            removeItems()
        Catch ex As Exception
            MsgBox("No Item Selected")
        End Try

    End Sub

    Private Sub SoftDrinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftDrinksToolStripMenuItem.Click
        'Display the Drinks menu
        frmSoftDrinks.Show()
    End Sub

    Private Sub PizzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PizzaToolStripMenuItem.Click
        'Display the Pizza Menu
        frmPizza.Show()
    End Sub

    Private Sub SidesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SidesToolStripMenuItem.Click
        'Display the Sides Menu
        frmSides.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Display the About form
        frmAbout.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Check if order is for delivery 
        ' if there are 3 items or less shipping is $9
        'if there are more than 3 and less than 6 items shipping is $6
        'if there are more than 6 items shipping is free
            If lstCart.Items.Count > 1 And lstCart.Items.Count <= 3 Then
                dblDelivery = 9
                lblShipping2.Text = dblDelivery.ToString("C")
                dblTotal += dblDelivery
                lblGrandTotal.Text = dblTotal.ToString("C")
            ElseIf lstCart.Items.Count > 3 And lstCart.Items.Count <= 6 Then
                dblDelivery = 6
                lblShipping2.Text = dblDelivery.ToString("C")
                dblTotal += dblDelivery
            ElseIf lstCart.Items.Count > 6 Then
                lblShipping2.Text = "Free"
            Else
                dblDelivery = 0
                lblShipping2.Text = dblDelivery.ToString("C")
                dblTotal -= dblDelivery
                lblGrandTotal.Text = dblTotal.ToString("C")
            End If

    End Sub

    Private Sub frmStartUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set these variables on form load
        lblSubTotal.Text = dblSubTotal.ToString("C")
        lblGrandTotal.Text = dblTotal.ToString("C")
        lblNumber.Text = intNumberOfItems
        lblTax.Text = "0.07%"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit the program
        Me.Close()
    End Sub

   
    Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
        'Select an item in the listbox and right click and remove item
        Try
            removeItems()
        Catch ex As Exception
            MsgBox("No Item Selected")
        End Try
    End Sub

    Private Sub PizzaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PizzaToolStripMenuItem1.Click
        'Show Pizza form from right click menu
        frmPizza.Show()
    End Sub

    Private Sub SoftDrinksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SoftDrinksToolStripMenuItem1.Click
        'Show Soft Drinks form from right click menu
        frmSoftDrinks.Show()
    End Sub

    Private Sub SidesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SidesToolStripMenuItem1.Click
        'Show Sides form from right click menu
        frmSides.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        'Exit the form from right click menu    
        Me.Close()
    End Sub
End Class
