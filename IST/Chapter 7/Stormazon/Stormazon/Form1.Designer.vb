﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftDrinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PizzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SidesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGrand = New System.Windows.Forms.Label()
        Me.lblTaxs = New System.Windows.Forms.Label()
        Me.lbldeliver = New System.Windows.Forms.Label()
        Me.lbllNumberOfItems = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblShipping2 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(380, 57)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(53, 13)
        Me.lblSub.TabIndex = 0
        Me.lblSub.Text = "Sub Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Remove Selected"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.Location = New System.Drawing.Point(59, 57)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(256, 160)
        Me.lstCart.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(547, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoftDrinksToolStripMenuItem, Me.PizzaToolStripMenuItem, Me.SidesToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'SoftDrinksToolStripMenuItem
        '
        Me.SoftDrinksToolStripMenuItem.Name = "SoftDrinksToolStripMenuItem"
        Me.SoftDrinksToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SoftDrinksToolStripMenuItem.Text = "Soft Drinks"
        '
        'PizzaToolStripMenuItem
        '
        Me.PizzaToolStripMenuItem.Name = "PizzaToolStripMenuItem"
        Me.PizzaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.PizzaToolStripMenuItem.Text = "Pizza"
        '
        'SidesToolStripMenuItem
        '
        Me.SidesToolStripMenuItem.Name = "SidesToolStripMenuItem"
        Me.SidesToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SidesToolStripMenuItem.Text = "Sides"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lblGrand
        '
        Me.lblGrand.AutoSize = True
        Me.lblGrand.Location = New System.Drawing.Point(380, 204)
        Me.lblGrand.Name = "lblGrand"
        Me.lblGrand.Size = New System.Drawing.Size(63, 13)
        Me.lblGrand.TabIndex = 4
        Me.lblGrand.Text = "Grand Total"
        '
        'lblTaxs
        '
        Me.lblTaxs.AutoSize = True
        Me.lblTaxs.Location = New System.Drawing.Point(380, 103)
        Me.lblTaxs.Name = "lblTaxs"
        Me.lblTaxs.Size = New System.Drawing.Size(25, 13)
        Me.lblTaxs.TabIndex = 5
        Me.lblTaxs.Text = "Tax"
        '
        'lbldeliver
        '
        Me.lbldeliver.AutoSize = True
        Me.lbldeliver.Location = New System.Drawing.Point(385, 157)
        Me.lbldeliver.Name = "lbldeliver"
        Me.lbldeliver.Size = New System.Drawing.Size(66, 13)
        Me.lbldeliver.TabIndex = 6
        Me.lbldeliver.Text = "Delivery Fee"
        '
        'lbllNumberOfItems
        '
        Me.lbllNumberOfItems.AutoSize = True
        Me.lbllNumberOfItems.Location = New System.Drawing.Point(56, 220)
        Me.lbllNumberOfItems.Name = "lbllNumberOfItems"
        Me.lbllNumberOfItems.Size = New System.Drawing.Size(87, 13)
        Me.lbllNumberOfItems.TabIndex = 7
        Me.lbllNumberOfItems.Text = "Number of Items:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(149, 220)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(54, 13)
        Me.lblNumber.TabIndex = 8
        Me.lblNumber.Text = "lblNumber"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(452, 57)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblSubTotal.TabIndex = 9
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(452, 103)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(0, 13)
        Me.lblTax.TabIndex = 10
        '
        'lblShipping2
        '
        Me.lblShipping2.AutoSize = True
        Me.lblShipping2.Location = New System.Drawing.Point(452, 157)
        Me.lblShipping2.Name = "lblShipping2"
        Me.lblShipping2.Size = New System.Drawing.Size(0, 13)
        Me.lblShipping2.TabIndex = 11
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Location = New System.Drawing.Point(452, 204)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblGrandTotal.TabIndex = 12
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(59, 272)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(137, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "This order is for delivery"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmStartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 311)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblShipping2)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lbllNumberOfItems)
        Me.Controls.Add(Me.lbldeliver)
        Me.Controls.Add(Me.lblTaxs)
        Me.Controls.Add(Me.lblGrand)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStartUp"
        Me.Text = "Startup"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstCart As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblGrand As System.Windows.Forms.Label
    Friend WithEvents lblTaxs As System.Windows.Forms.Label
    Friend WithEvents lbldeliver As System.Windows.Forms.Label
    Friend WithEvents lbllNumberOfItems As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblShipping2 As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents SoftDrinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PizzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SidesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
