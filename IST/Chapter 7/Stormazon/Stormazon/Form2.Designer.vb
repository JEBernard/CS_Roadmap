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
        Me.chkClassic = New System.Windows.Forms.CheckBox()
        Me.chkVanilla = New System.Windows.Forms.CheckBox()
        Me.chkDiet = New System.Windows.Forms.CheckBox()
        Me.chkCherry = New System.Windows.Forms.CheckBox()
        Me.btnAddDrinks = New System.Windows.Forms.Button()
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
        'chkClassic
        '
        Me.chkClassic.AutoSize = True
        Me.chkClassic.Location = New System.Drawing.Point(12, 45)
        Me.chkClassic.Name = "chkClassic"
        Me.chkClassic.Size = New System.Drawing.Size(15, 14)
        Me.chkClassic.TabIndex = 5
        Me.chkClassic.UseVisualStyleBackColor = True
        '
        'chkVanilla
        '
        Me.chkVanilla.AutoSize = True
        Me.chkVanilla.Location = New System.Drawing.Point(158, 162)
        Me.chkVanilla.Name = "chkVanilla"
        Me.chkVanilla.Size = New System.Drawing.Size(15, 14)
        Me.chkVanilla.TabIndex = 6
        Me.chkVanilla.UseVisualStyleBackColor = True
        '
        'chkDiet
        '
        Me.chkDiet.AutoSize = True
        Me.chkDiet.Location = New System.Drawing.Point(158, 45)
        Me.chkDiet.Name = "chkDiet"
        Me.chkDiet.Size = New System.Drawing.Size(15, 14)
        Me.chkDiet.TabIndex = 7
        Me.chkDiet.UseVisualStyleBackColor = True
        '
        'chkCherry
        '
        Me.chkCherry.AutoSize = True
        Me.chkCherry.Location = New System.Drawing.Point(12, 162)
        Me.chkCherry.Name = "chkCherry"
        Me.chkCherry.Size = New System.Drawing.Size(15, 14)
        Me.chkCherry.TabIndex = 8
        Me.chkCherry.UseVisualStyleBackColor = True
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
        'frmSoftDrinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnAddDrinks)
        Me.Controls.Add(Me.chkCherry)
        Me.Controls.Add(Me.chkDiet)
        Me.Controls.Add(Me.chkVanilla)
        Me.Controls.Add(Me.chkClassic)
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
    Friend WithEvents chkClassic As System.Windows.Forms.CheckBox
    Friend WithEvents chkVanilla As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiet As System.Windows.Forms.CheckBox
    Friend WithEvents chkCherry As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddDrinks As System.Windows.Forms.Button
End Class
