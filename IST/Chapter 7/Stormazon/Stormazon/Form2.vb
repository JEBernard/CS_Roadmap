Public Class frmSoftDrinks
    Public dblClassic As Double = 10.99
    Public dblVanilla As Double = 12.99
    Public dblDiet As Double = 14.99
    Public dblCherry As Double = 19.99
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddDrinks.Click
        addSoftDrinks()
    End Sub
End Class