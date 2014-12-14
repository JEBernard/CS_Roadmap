<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSides
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
        Me.chkWings = New System.Windows.Forms.CheckBox()
        Me.chkPasta = New System.Windows.Forms.CheckBox()
        Me.chkMozz = New System.Windows.Forms.CheckBox()
        Me.chkBreadsticks = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        'chkWings
        '
        Me.chkWings.AutoSize = True
        Me.chkWings.Location = New System.Drawing.Point(8, 162)
        Me.chkWings.Name = "chkWings"
        Me.chkWings.Size = New System.Drawing.Size(15, 14)
        Me.chkWings.TabIndex = 26
        Me.chkWings.UseVisualStyleBackColor = True
        '
        'chkPasta
        '
        Me.chkPasta.AutoSize = True
        Me.chkPasta.Location = New System.Drawing.Point(154, 45)
        Me.chkPasta.Name = "chkPasta"
        Me.chkPasta.Size = New System.Drawing.Size(15, 14)
        Me.chkPasta.TabIndex = 25
        Me.chkPasta.UseVisualStyleBackColor = True
        '
        'chkMozz
        '
        Me.chkMozz.AutoSize = True
        Me.chkMozz.Location = New System.Drawing.Point(154, 162)
        Me.chkMozz.Name = "chkMozz"
        Me.chkMozz.Size = New System.Drawing.Size(15, 14)
        Me.chkMozz.TabIndex = 24
        Me.chkMozz.UseVisualStyleBackColor = True
        '
        'chkBreadsticks
        '
        Me.chkBreadsticks.AutoSize = True
        Me.chkBreadsticks.Location = New System.Drawing.Point(8, 45)
        Me.chkBreadsticks.Name = "chkBreadsticks"
        Me.chkBreadsticks.Size = New System.Drawing.Size(15, 14)
        Me.chkBreadsticks.TabIndex = 23
        Me.chkBreadsticks.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Add Selected Items"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Stormazon.My.Resources.Resources.getty_rf_photo_of_penne_pasta
        Me.PictureBox4.Location = New System.Drawing.Point(175, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Stormazon.My.Resources.Resources._06
        Me.PictureBox3.Location = New System.Drawing.Point(29, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Stormazon.My.Resources.Resources.mozzarella_sticks
        Me.PictureBox2.Location = New System.Drawing.Point(175, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Stormazon.My.Resources.Resources.New_Breadsticks_sm
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmSides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.chkWings)
        Me.Controls.Add(Me.chkPasta)
        Me.Controls.Add(Me.chkMozz)
        Me.Controls.Add(Me.chkBreadsticks)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSides"
        Me.Text = "Sides"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkWings As System.Windows.Forms.CheckBox
    Friend WithEvents chkPasta As System.Windows.Forms.CheckBox
    Friend WithEvents chkMozz As System.Windows.Forms.CheckBox
    Friend WithEvents chkBreadsticks As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
