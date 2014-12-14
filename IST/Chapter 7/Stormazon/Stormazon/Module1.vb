Module Module1
    Sub removeItems()
        'Remove items from Listbox on Start up form
        ' This is called from the remove selected items button on the start up form
        If frmStartUp.lstCart.SelectedItem.Equals("Cheese Pizza") Then
            'Remove Cheese Pizza if selected
            frmStartUp.dblSubTotal -= frmPizza.dblCheese
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmPizza.dblCheese + frmPizza.dblCheese * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Pepperoni Pizza") Then
            'Remove Pepperoni Pizza if selected
            frmStartUp.dblSubTotal -= frmPizza.dblPepperoni
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
            frmStartUp.dblTotal -= frmPizza.dblPepperoni + frmPizza.dblPepperoni * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")


        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Taco Pizza") Then
            'Remove Taco Pizza if selected
            frmStartUp.dblSubTotal -= frmPizza.dblTaco
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
            frmStartUp.dblTotal -= frmPizza.dblTaco + frmPizza.dblTaco * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Cheese Burger Pizza") Then
            'Remove Cheese Burger Pizza if selected
            frmStartUp.dblSubTotal -= frmPizza.dblCheeseBurger
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
            frmStartUp.dblTotal -= frmPizza.dblCheeseBurger + frmPizza.dblCheese * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Coca-Cola") Then
            'Remove Coca=Cola if selected
            frmStartUp.dblSubTotal -= frmSoftDrinks.dblClassic
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmSoftDrinks.dblClassic + frmSoftDrinks.dblClassic * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Vanilla Coke") Then
            'Remove Vanilla Coke if selected
            frmStartUp.dblSubTotal -= frmSoftDrinks.dblVanilla
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmSoftDrinks.dblVanilla + frmSoftDrinks.dblVanilla * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Diet Coke") Then
            'Remove Diet Coke if selected
            frmStartUp.dblSubTotal -= frmSoftDrinks.dblDiet
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmSoftDrinks.dblDiet + frmSoftDrinks.dblDiet * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Cherry Coke") Then
            'Remove Cherry Coke if selected
            frmStartUp.dblSubTotal -= frmSoftDrinks.dblCherry
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmSoftDrinks.dblCherry + frmSoftDrinks.dblCherry * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Breadsticks") Then
            'Remove Breadsticks if selected 
            frmStartUp.dblSubTotal -= frmSides.dblBread
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmSides.dblBread + frmSides.dblBread * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Penne Pasta") Then
            'Remove Penne Pasta if selected
            frmStartUp.dblSubTotal -= frmSides.dblPasta
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmSides.dblPasta + frmSides.dblPasta * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Chicken Wings") Then
            'Remove Chicken Wings if selected
            frmStartUp.dblSubTotal -= frmSides.dblWings
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmSides.dblWings + frmSides.dblWings * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        ElseIf frmStartUp.lstCart.SelectedItem.Equals("Mozzerala Sticks") Then
            'Remove Mozzerela sticks if selected
            frmStartUp.dblSubTotal -= frmSides.dblSticks
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.lstCart.Items.Remove(frmStartUp.lstCart.SelectedItem)
            frmStartUp.intNumberOfItems -= 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal -= frmSides.dblSticks + frmSides.dblSticks * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        End If




    End Sub



    Sub addPizza()
        'Add Pizza items to lisbox on the start up form 
        If frmPizza.chkCheese.Checked Then
            'Add Cheese Pizza if selected
            frmStartUp.lstCart.Items.Add("Cheese Pizza")
            frmStartUp.dblSubTotal += frmPizza.dblCheese
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmPizza.dblCheese + frmPizza.dblCheese * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        End If
        If frmPizza.chPepperoni.Checked Then
            'Add Pepperoni Pizza if selected
            frmStartUp.lstCart.Items.Add("Pepperoni Pizza")
            frmStartUp.dblSubTotal += frmPizza.dblPepperoni
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmPizza.dblPepperoni + frmPizza.dblPepperoni * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")

        End If
        If frmPizza.chkTaco.Checked Then
            'Add Taco Pizza if selected 
            frmStartUp.lstCart.Items.Add("Taco Pizza")
            frmStartUp.dblSubTotal += frmPizza.dblTaco
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmPizza.dblTaco + frmPizza.dblTaco * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If
        If frmPizza.chkHamburger.Checked Then
            'Add Cheese Burger Pizza if selected
            frmStartUp.lstCart.Items.Add("Cheese Burger Pizza")
            frmStartUp.dblSubTotal += frmPizza.dblCheeseBurger
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmPizza.dblCheeseBurger + frmPizza.dblCheeseBurger * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If

    End Sub

    Sub addSoftDrinks()
        'Add drink items to listbox on start up form 
        If frmSoftDrinks.rbClassic.Checked Then
            'Add Coca-Cola if selected
            frmStartUp.lstCart.Items.Add("Coca-Cola")
            frmStartUp.dblSubTotal += frmSoftDrinks.dblClassic
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmSoftDrinks.dblClassic + frmSoftDrinks.dblClassic * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If
        If frmSoftDrinks.rbVanilla.Checked Then
            'Add Vanilla Coke if selected
            frmStartUp.lstCart.Items.Add("Vanilla Coke")
            frmStartUp.dblSubTotal += frmSoftDrinks.dblVanilla
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmSoftDrinks.dblVanilla + frmSoftDrinks.dblVanilla * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If
        If frmSoftDrinks.rbDiet.Checked Then
            'Add Diet Coke if selected
            frmStartUp.lstCart.Items.Add("Diet Coke")
            frmStartUp.dblSubTotal += frmSoftDrinks.dblDiet
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmSoftDrinks.dblDiet + frmSoftDrinks.dblDiet * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If
        If frmSoftDrinks.rbCherry.Checked Then
            'Add Cherry Coke if selected    
            frmStartUp.lstCart.Items.Add("Cherry Coke")
            frmStartUp.dblSubTotal += frmSoftDrinks.dblCherry
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmSoftDrinks.dblCherry + frmSoftDrinks.dblCherry * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If

    End Sub

    Sub addSides()
        'Add sides to listbox on start up form
        If frmSides.chkBreadsticks.Checked Then
            'Add Breadsticks if selected
            frmStartUp.lstCart.Items.Add("Breadsticks")
            frmStartUp.dblSubTotal += frmSides.dblBread
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmSides.dblBread + frmSides.dblBread * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If
        If frmSides.chkMozz.Checked Then
            'Add Mozzerela Sticks if selected
            frmStartUp.lstCart.Items.Add("Mozzerela Sticks")
            frmStartUp.dblSubTotal += frmSides.dblSticks
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmSides.dblSticks + frmSides.dblSticks * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If
        If frmSides.chkPasta.Checked Then
            'Add Penne Pasta if selected
            frmStartUp.lstCart.Items.Add("Penne Pasta")
            frmStartUp.dblSubTotal += frmSides.dblPasta
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmSides.dblPasta + frmSides.dblPasta * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If
        If frmSides.chkWings.Checked Then
            'Add Chicken Wings if selected
            frmStartUp.lstCart.Items.Add("Chicken Wings")
            frmStartUp.dblSubTotal += frmSides.dblWings
            frmStartUp.lblSubTotal.Text = frmStartUp.dblSubTotal.ToString("C")
            frmStartUp.intNumberOfItems += 1
            frmStartUp.lblNumber.Text = frmStartUp.intNumberOfItems
            frmStartUp.dblTotal += frmSides.dblWings + frmSides.dblWings * frmStartUp.dblTax
            frmStartUp.lblGrandTotal.Text = frmStartUp.dblTotal.ToString("C")
        End If
    End Sub
End Module
