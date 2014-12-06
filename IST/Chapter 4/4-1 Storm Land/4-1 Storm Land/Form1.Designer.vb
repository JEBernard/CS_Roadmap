<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblSeason = New System.Windows.Forms.Label()
        Me.txtSeason = New System.Windows.Forms.TextBox()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.pbRide = New System.Windows.Forms.PictureBox()
        Me.btnRecommend = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPark = New System.Windows.Forms.Label()
        Me.lblRide = New System.Windows.Forms.Label()
        CType(Me.pbRide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(22, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(223, 20)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(19, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(19, 89)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(22, 105)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(121, 20)
        Me.txtAge.TabIndex = 2
        '
        'lblSeason
        '
        Me.lblSeason.AutoSize = True
        Me.lblSeason.Location = New System.Drawing.Point(19, 147)
        Me.lblSeason.Name = "lblSeason"
        Me.lblSeason.Size = New System.Drawing.Size(194, 13)
        Me.lblSeason.TabIndex = 5
        Me.lblSeason.Text = "Season (Spring, Summer, Fall or Winter)"
        '
        'txtSeason
        '
        Me.txtSeason.Location = New System.Drawing.Point(22, 163)
        Me.txtSeason.Name = "txtSeason"
        Me.txtSeason.Size = New System.Drawing.Size(121, 20)
        Me.txtSeason.TabIndex = 4
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(19, 205)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(67, 13)
        Me.lblTemp.TabIndex = 7
        Me.lblTemp.Text = "Temperature"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(22, 221)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(121, 20)
        Me.txtTemp.TabIndex = 6
        '
        'pbRide
        '
        Me.pbRide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbRide.Image = Global._4_1_Storm_Land.My.Resources.Resources.stormland
        Me.pbRide.Location = New System.Drawing.Point(294, 23)
        Me.pbRide.Name = "pbRide"
        Me.pbRide.Size = New System.Drawing.Size(288, 182)
        Me.pbRide.TabIndex = 8
        Me.pbRide.TabStop = False
        '
        'btnRecommend
        '
        Me.btnRecommend.Location = New System.Drawing.Point(22, 266)
        Me.btnRecommend.Name = "btnRecommend"
        Me.btnRecommend.Size = New System.Drawing.Size(121, 24)
        Me.btnRecommend.TabIndex = 9
        Me.btnRecommend.Text = "Recommend"
        Me.btnRecommend.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(229, 266)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 24)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(461, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 24)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPark
        '
        Me.lblPark.AutoSize = True
        Me.lblPark.Location = New System.Drawing.Point(413, 208)
        Me.lblPark.Name = "lblPark"
        Me.lblPark.Size = New System.Drawing.Size(39, 13)
        Me.lblPark.TabIndex = 12
        Me.lblPark.Text = "Label1"
        '
        'lblRide
        '
        Me.lblRide.AutoSize = True
        Me.lblRide.Location = New System.Drawing.Point(413, 228)
        Me.lblRide.Name = "lblRide"
        Me.lblRide.Size = New System.Drawing.Size(39, 13)
        Me.lblRide.TabIndex = 13
        Me.lblRide.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 302)
        Me.Controls.Add(Me.lblRide)
        Me.Controls.Add(Me.lblPark)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRecommend)
        Me.Controls.Add(Me.pbRide)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.lblSeason)
        Me.Controls.Add(Me.txtSeason)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbRide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblSeason As System.Windows.Forms.Label
    Friend WithEvents txtSeason As System.Windows.Forms.TextBox
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents pbRide As System.Windows.Forms.PictureBox
    Friend WithEvents btnRecommend As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPark As System.Windows.Forms.Label
    Friend WithEvents lblRide As System.Windows.Forms.Label

End Class
