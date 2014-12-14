<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftDrinks
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
        Me.btnAddDrinks = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rbClassic = New System.Windows.Forms.RadioButton()
        Me.rbDiet = New System.Windows.Forms.RadioButton()
        Me.rbCherry = New System.Windows.Forms.RadioButton()
        Me.rbVanilla = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddDrinks
        '
        Me.btnAddDrinks.Location = New System.Drawing.Point(47, 226)
        Me.btnAddDrinks.Name = "btnAddDrinks"
        Me.btnAddDrinks.Size = New System.Drawing.Size(185, 23)
        Me.btnAddDrinks.TabIndex = 10
        Me.btnAddDrinks.Text = "Add Selected Items"
        Me.btnAddDrinks.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Stormazon.My.Resources.Resources.Diet_Coke_330ml_500x500
        Me.PictureBox4.Location = New System.Drawing.Point(170, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Stormazon.My.Resources.Resources._0004900001477_A
        Me.PictureBox3.Location = New System.Drawing.Point(24, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Stormazon.My.Resources.Resources.vanilla_coke
        Me.PictureBox2.Location = New System.Drawing.Point(170, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Stormazon.My.Resources.Resources.article_2166193_13D6EDC3000005DC_154_306x545
        Me.PictureBox1.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'rbClassic
        '
        Me.rbClassic.AutoSize = True
        Me.rbClassic.Location = New System.Drawing.Point(12, 45)
        Me.rbClassic.Name = "rbClassic"
        Me.rbClassic.Size = New System.Drawing.Size(28, 17)
        Me.rbClassic.TabIndex = 11
        Me.rbClassic.TabStop = True
        Me.rbClassic.Text = " "
        Me.rbClassic.UseVisualStyleBackColor = True
        '
        'rbDiet
        '
        Me.rbDiet.AutoSize = True
        Me.rbDiet.Location = New System.Drawing.Point(155, 45)
        Me.rbDiet.Name = "rbDiet"
        Me.rbDiet.Size = New System.Drawing.Size(28, 17)
        Me.rbDiet.TabIndex = 12
        Me.rbDiet.TabStop = True
        Me.rbDiet.Text = " "
        Me.rbDiet.UseVisualStyleBackColor = True
        '
        'rbCherry
        '
        Me.rbCherry.AutoSize = True
        Me.rbCherry.Location = New System.Drawing.Point(12, 167)
        Me.rbCherry.Name = "rbCherry"
        Me.rbCherry.Size = New System.Drawing.Size(28, 17)
        Me.rbCherry.TabIndex = 13
        Me.rbCherry.TabStop = True
        Me.rbCherry.Text = " "
        Me.rbCherry.UseVisualStyleBackColor = True
        '
        'rbVanilla
        '
        Me.rbVanilla.AutoSize = True
        Me.rbVanilla.Location = New System.Drawing.Point(155, 167)
        Me.rbVanilla.Name = "rbVanilla"
        Me.rbVanilla.Size = New System.Drawing.Size(28, 17)
        Me.rbVanilla.TabIndex = 14
        Me.rbVanilla.TabStop = True
        Me.rbVanilla.Text = " "
        Me.rbVanilla.UseVisualStyleBackColor = True
        '
        'frmSoftDrinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.rbVanilla)
        Me.Controls.Add(Me.rbCherry)
        Me.Controls.Add(Me.rbDiet)
        Me.Controls.Add(Me.rbClassic)
        Me.Controls.Add(Me.btnAddDrinks)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSoftDrinks"
        Me.Text = "Soft Drinks"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddDrinks As System.Windows.Forms.Button
    Friend WithEvents rbClassic As System.Windows.Forms.RadioButton
    Friend WithEvents rbDiet As System.Windows.Forms.RadioButton
    Friend WithEvents rbCherry As System.Windows.Forms.RadioButton
    Friend WithEvents rbVanilla As System.Windows.Forms.RadioButton
End Class
