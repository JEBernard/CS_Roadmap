<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizza
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
        Me.chkHamburger = New System.Windows.Forms.CheckBox()
        Me.chPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkTaco = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.btnAddPizza = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkHamburger
        '
        Me.chkHamburger.AutoSize = True
        Me.chkHamburger.Location = New System.Drawing.Point(3, 162)
        Me.chkHamburger.Name = "chkHamburger"
        Me.chkHamburger.Size = New System.Drawing.Size(15, 14)
        Me.chkHamburger.TabIndex = 17
        Me.chkHamburger.UseVisualStyleBackColor = True
        '
        'chPepperoni
        '
        Me.chPepperoni.AutoSize = True
        Me.chPepperoni.Location = New System.Drawing.Point(149, 45)
        Me.chPepperoni.Name = "chPepperoni"
        Me.chPepperoni.Size = New System.Drawing.Size(15, 14)
        Me.chPepperoni.TabIndex = 16
        Me.chPepperoni.UseVisualStyleBackColor = True
        '
        'chkTaco
        '
        Me.chkTaco.AutoSize = True
        Me.chkTaco.Location = New System.Drawing.Point(149, 162)
        Me.chkTaco.Name = "chkTaco"
        Me.chkTaco.Size = New System.Drawing.Size(15, 14)
        Me.chkTaco.TabIndex = 15
        Me.chkTaco.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(3, 45)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(15, 14)
        Me.chkCheese.TabIndex = 14
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'btnAddPizza
        '
        Me.btnAddPizza.Location = New System.Drawing.Point(40, 226)
        Me.btnAddPizza.Name = "btnAddPizza"
        Me.btnAddPizza.Size = New System.Drawing.Size(185, 23)
        Me.btnAddPizza.TabIndex = 9
        Me.btnAddPizza.Text = "Add Selected Items"
        Me.btnAddPizza.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Stormazon.My.Resources.Resources.download
        Me.PictureBox4.Location = New System.Drawing.Point(170, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Stormazon.My.Resources.Resources.cheesy_hamburger_pizza
        Me.PictureBox3.Location = New System.Drawing.Point(24, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Stormazon.My.Resources.Resources.Taco_Pizza_close
        Me.PictureBox2.Location = New System.Drawing.Point(170, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Stormazon.My.Resources.Resources.Cheese_Pizza
        Me.PictureBox1.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.chkHamburger)
        Me.Controls.Add(Me.chPepperoni)
        Me.Controls.Add(Me.chkTaco)
        Me.Controls.Add(Me.chkCheese)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAddPizza)
        Me.Name = "frmPizza"
        Me.Text = "Pizza"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkHamburger As System.Windows.Forms.CheckBox
    Friend WithEvents chPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkTaco As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddPizza As System.Windows.Forms.Button
End Class
