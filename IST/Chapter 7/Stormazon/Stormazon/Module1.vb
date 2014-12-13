Module Module1
    Function addPizza()
        If frmPizza.chkCheese.Checked Then
            frmStartUp.lstCart.Items.Add("Cheese Pizza")
            frmStartUp.dblTotal += 20.99
        End If
        If frmPizza.chPepperoni.Checked Then
            frmStartUp.lstCart.Items.Add("Pepperoni Pizza")
            frmStartUp.dblTotal += 22.99
        End If
        If frmPizza.chkTaco.Checked Then
            frmStartUp.lstCart.Items.Add("Taco Pizza")
            frmStartUp.dblTotal += 24.99
        End If
        If frmPizza.chkHamburger.Checked Then
            frmStartUp.lstCart.Items.Add("Cheese Burger Pizza")
            frmStartUp.dblTotal += 29.99
        End If

    End Function

    Function addSoftDrinks()
        If frmSoftDrinks.chkClassic.Checked Then
            frmStartUp.lstCart.Items.Add("Coca-Cola")
            frmStartUp.dblTotal += 10.99
        End If
        If frmSoftDrinks.chkVanilla.Checked Then
            frmStartUp.lstCart.Items.Add("Vanilla Coke")
            frmStartUp.dblTotal += 12.99
        End If
        If frmSoftDrinks.chkDiet.Checked Then
            frmStartUp.lstCart.Items.Add("Diet Coke")
            frmStartUp.dblTotal += 14.99
        End If
        If frmSoftDrinks.chkCherry.Checked Then
            frmStartUp.lstCart.Items.Add("Cherry Coke")
            frmStartUp.dblTotal += 19.99
        End If

    End Function

    Function addSides()
        If frmSides.CheckBox1.Checked Then
            frmStartUp.lstCart.Items.Add("Breadsticks")
            frmStartUp.dblTotal += 4.99
        End If
        If frmSides.CheckBox2.Checked Then
            frmStartUp.lstCart.Items.Add("Penne Pasta")
            frmStartUp.dblTotal += 9.99
        End If
        If frmSides.CheckBox3.Checked Then
            frmStartUp.lstCart.Items.Add("Chicken Wings")
            frmStartUp.dblTotal += 2.99
        End If
        If frmSides.CheckBox4.Checked Then
            frmStartUp.lstCart.Items.Add("Mozzerela Sticks")
            frmStartUp.dblTotal += 0.99
        End If
    End Function
End Module
