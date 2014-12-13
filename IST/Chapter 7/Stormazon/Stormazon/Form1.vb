Public Class frmStartUp
    Public dblTotal As Double = 0
    Public dblSubTotal As Double = 0
    Public dblDelivery As Double = 0
    Public dblTax As Double = 0.07

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        removeItems()

    End Sub

    Private Sub SoftDrinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftDrinksToolStripMenuItem.Click
        frmSoftDrinks.Show()
    End Sub

    Private Sub PizzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PizzaToolStripMenuItem.Click
        frmPizza.Show()
    End Sub

    Private Sub SidesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SidesToolStripMenuItem.Click
        frmSides.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        
        If lstCart.Items.Count <= 3 Then
            dblDelivery = 9
            lblShipping2.Text = dblDelivery.ToString("C")
        ElseIf lstCart.Items.Count > 3 And lstCart.Items.Count <= 6 Then
            dblDelivery = 6
            lblShipping2.Text = dblDelivery.ToString("C")
        ElseIf lstCart.Items.Count > 6 Then
            lblShipping2.Text = "Free"
        End If
    End Sub
End Class
