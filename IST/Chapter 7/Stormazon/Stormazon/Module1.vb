Module Module1
    Sub removeItems()
        If frmStartUp.lstCart.SelectedItem.Equals("Cheese Pizza") Then
            frmStartUp.dblSubTotal -= frmPizza.dblCheese
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItems.Equals("Pepperoni Pizza") Then
            frmStartUp.dblSubTotal -= frmPizza.dblPepperoni
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Taco Pizza") Then
            frmStartUp.dblSubTotal -= frmPizza.dblTaco
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Cheese Burger Pizza") Then
            frmStartUp.dblSubTotal -= frmPizza.dblCheeseBurger
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Coca-Cola") Then
            frmStartUp.dblSubTotal -= frmSoftDrinks.dblClassic
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Vanilla Coke") Then
            frmStartUp.dblSubTotal -= frmSoftDrinks.dblVanilla
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Diet Coke") Then
            frmStartUp.dblSubTotal -= frmSoftDrinks.dblDiet
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Cherry Coke") Then
            frmStartUp.dblSubTotal -= frmSoftDrinks.dblCherry
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Bread Sticks") Then
            frmStartUp.dblSubTotal -= frmSides.dblBread
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Penne Pasta") Then
            frmStartUp.dblSubTotal -= frmSides.dblPasta
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Chicken Wings") Then
            frmStartUp.dblSubTotal -= frmSides.dblWings
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Mozzerala Sticks") Then
            frmStartUp.dblSubTotal -= frmSides.dblSticks
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
        End If



        
    End Sub

  

    Function addPizza()
        If frmPizza.chkCheese.Checked Then
            frmStartUp.lstCart.Items.Add("Cheese Pizza")
            frmStartUp.dblSubTotal += frmPizza.dblCheese
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmPizza.chPepperoni.Checked Then
            frmStartUp.lstCart.Items.Add("Pepperoni Pizza")
            frmStartUp.dblSubTotal += frmPizza.dblPepperoni
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmPizza.chkTaco.Checked Then
            frmStartUp.lstCart.Items.Add("Taco Pizza")
            frmStartUp.dblSubTotal += frmPizza.dblTaco
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmPizza.chkHamburger.Checked Then
            frmStartUp.lstCart.Items.Add("Cheese Burger Pizza")
            frmStartUp.dblSubTotal += frmPizza.dblCheeseBurger
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If

    End Function

    Function addSoftDrinks()
        If frmSoftDrinks.chkClassic.Checked Then
            frmStartUp.lstCart.Items.Add("Coca-Cola")
            frmStartUp.dblSubTotal += frmSoftDrinks.dblClassic
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmSoftDrinks.chkVanilla.Checked Then
            frmStartUp.lstCart.Items.Add("Vanilla Coke")
            frmStartUp.dblSubTotal += frmSoftDrinks.dblVanilla
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmSoftDrinks.chkDiet.Checked Then
            frmStartUp.lstCart.Items.Add("Diet Coke")
            frmStartUp.dblSubTotal += frmSoftDrinks.dblDiet
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmSoftDrinks.chkCherry.Checked Then
            frmStartUp.lstCart.Items.Add("Cherry Coke")
            frmStartUp.dblSubTotal += frmSoftDrinks.dblCherry
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If

    End Function

    Function addSides()
        If frmSides.CheckBox1.Checked Then
            frmStartUp.lstCart.Items.Add("Breadsticks")
            frmStartUp.dblSubTotal += frmSides.dblBread
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmSides.CheckBox2.Checked Then
            frmStartUp.lstCart.Items.Add("Penne Pasta")
            frmStartUp.dblSubTotal += frmSides.dblPasta
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmSides.CheckBox3.Checked Then
            frmStartUp.lstCart.Items.Add("Chicken Wings")
            frmStartUp.dblSubTotal += frmSides.dblWings
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
        If frmSides.CheckBox4.Checked Then
            frmStartUp.lstCart.Items.Add("Mozzerela Sticks")
            frmStartUp.dblSubTotal += frmSides.dblSticks
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
        End If
    End Function
End Module
