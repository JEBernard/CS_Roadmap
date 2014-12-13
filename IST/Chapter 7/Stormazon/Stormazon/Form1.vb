Public Class frmStartUp
    Public dblTotal As Double = 0




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstCart.SelectedItems.Clear()
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
End Class
