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
        Me.gbEventSeating = New System.Windows.Forms.GroupBox()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.cbNumberOfSeats = New System.Windows.Forms.ComboBox()
        Me.rbNoseBleedSeats = New System.Windows.Forms.RadioButton()
        Me.rbGeneralSeats = New System.Windows.Forms.RadioButton()
        Me.rbPremiumSeats = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.gbMerch = New System.Windows.Forms.GroupBox()
        Me.gbConcessions = New System.Windows.Forms.GroupBox()
        Me.gbAccomodations = New System.Windows.Forms.GroupBox()
        Me.rbThreeNights = New System.Windows.Forms.RadioButton()
        Me.rbTwoNight = New System.Windows.Forms.RadioButton()
        Me.rbOneNight = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkOvernight = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkHat = New System.Windows.Forms.CheckBox()
        Me.chkProgram = New System.Windows.Forms.CheckBox()
        Me.chkShirt = New System.Windows.Forms.CheckBox()
        Me.chkPizza = New System.Windows.Forms.CheckBox()
        Me.chkHotDog = New System.Windows.Forms.CheckBox()
        Me.chkChips = New System.Windows.Forms.CheckBox()
        Me.chkCoke = New System.Windows.Forms.CheckBox()
        Me.gbEventSeating.SuspendLayout()
        Me.gbMerch.SuspendLayout()
        Me.gbConcessions.SuspendLayout()
        Me.gbAccomodations.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEventSeating
        '
        Me.gbEventSeating.Controls.Add(Me.lblNumberOfTickets)
        Me.gbEventSeating.Controls.Add(Me.cbNumberOfSeats)
        Me.gbEventSeating.Controls.Add(Me.rbNoseBleedSeats)
        Me.gbEventSeating.Controls.Add(Me.rbGeneralSeats)
        Me.gbEventSeating.Controls.Add(Me.rbPremiumSeats)
        Me.gbEventSeating.Location = New System.Drawing.Point(28, 26)
        Me.gbEventSeating.Name = "gbEventSeating"
        Me.gbEventSeating.Size = New System.Drawing.Size(355, 95)
        Me.gbEventSeating.TabIndex = 0
        Me.gbEventSeating.TabStop = False
        Me.gbEventSeating.Text = "Event Seating"
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(71, 60)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(94, 13)
        Me.lblNumberOfTickets.TabIndex = 4
        Me.lblNumberOfTickets.Text = "Number of Tickets"
        '
        'cbNumberOfSeats
        '
        Me.cbNumberOfSeats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNumberOfSeats.FormattingEnabled = True
        Me.cbNumberOfSeats.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbNumberOfSeats.Location = New System.Drawing.Point(190, 54)
        Me.cbNumberOfSeats.Name = "cbNumberOfSeats"
        Me.cbNumberOfSeats.Size = New System.Drawing.Size(90, 21)
        Me.cbNumberOfSeats.Sorted = True
        Me.cbNumberOfSeats.TabIndex = 3
        '
        'rbNoseBleedSeats
        '
        Me.rbNoseBleedSeats.AutoSize = True
        Me.rbNoseBleedSeats.Location = New System.Drawing.Point(261, 28)
        Me.rbNoseBleedSeats.Name = "rbNoseBleedSeats"
        Me.rbNoseBleedSeats.Size = New System.Drawing.Size(80, 17)
        Me.rbNoseBleedSeats.TabIndex = 2
        Me.rbNoseBleedSeats.TabStop = True
        Me.rbNoseBleedSeats.Text = "Nose Bleed"
        Me.rbNoseBleedSeats.UseVisualStyleBackColor = True
        '
        'rbGeneralSeats
        '
        Me.rbGeneralSeats.AutoSize = True
        Me.rbGeneralSeats.Location = New System.Drawing.Point(130, 28)
        Me.rbGeneralSeats.Name = "rbGeneralSeats"
        Me.rbGeneralSeats.Size = New System.Drawing.Size(62, 17)
        Me.rbGeneralSeats.TabIndex = 1
        Me.rbGeneralSeats.TabStop = True
        Me.rbGeneralSeats.Text = "General"
        Me.rbGeneralSeats.UseVisualStyleBackColor = True
        '
        'rbPremiumSeats
        '
        Me.rbPremiumSeats.AutoSize = True
        Me.rbPremiumSeats.Location = New System.Drawing.Point(9, 28)
        Me.rbPremiumSeats.Name = "rbPremiumSeats"
        Me.rbPremiumSeats.Size = New System.Drawing.Size(65, 17)
        Me.rbPremiumSeats.TabIndex = 0
        Me.rbPremiumSeats.TabStop = True
        Me.rbPremiumSeats.Text = "Premium"
        Me.rbPremiumSeats.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Location = New System.Drawing.Point(434, 23)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 21)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(434, 67)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 21)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(434, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 21)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'gbMerch
        '
        Me.gbMerch.Controls.Add(Me.chkShirt)
        Me.gbMerch.Controls.Add(Me.chkProgram)
        Me.gbMerch.Controls.Add(Me.chkHat)
        Me.gbMerch.Location = New System.Drawing.Point(28, 163)
        Me.gbMerch.Name = "gbMerch"
        Me.gbMerch.Size = New System.Drawing.Size(355, 51)
        Me.gbMerch.TabIndex = 4
        Me.gbMerch.TabStop = False
        Me.gbMerch.Text = "Merchandise"
        '
        'gbConcessions
        '
        Me.gbConcessions.Controls.Add(Me.chkCoke)
        Me.gbConcessions.Controls.Add(Me.chkChips)
        Me.gbConcessions.Controls.Add(Me.chkHotDog)
        Me.gbConcessions.Controls.Add(Me.chkPizza)
        Me.gbConcessions.Location = New System.Drawing.Point(28, 258)
        Me.gbConcessions.Name = "gbConcessions"
        Me.gbConcessions.Size = New System.Drawing.Size(355, 51)
        Me.gbConcessions.TabIndex = 5
        Me.gbConcessions.TabStop = False
        Me.gbConcessions.Text = "Concessions"
        '
        'gbAccomodations
        '
        Me.gbAccomodations.Controls.Add(Me.rbThreeNights)
        Me.gbAccomodations.Controls.Add(Me.rbTwoNight)
        Me.gbAccomodations.Controls.Add(Me.rbOneNight)
        Me.gbAccomodations.Controls.Add(Me.Label1)
        Me.gbAccomodations.Controls.Add(Me.chkOvernight)
        Me.gbAccomodations.Location = New System.Drawing.Point(28, 354)
        Me.gbAccomodations.Name = "gbAccomodations"
        Me.gbAccomodations.Size = New System.Drawing.Size(355, 66)
        Me.gbAccomodations.TabIndex = 6
        Me.gbAccomodations.TabStop = False
        Me.gbAccomodations.Text = "Accomodations"
        '
        'rbThreeNights
        '
        Me.rbThreeNights.AutoSize = True
        Me.rbThreeNights.Enabled = False
        Me.rbThreeNights.Location = New System.Drawing.Point(250, 45)
        Me.rbThreeNights.Name = "rbThreeNights"
        Me.rbThreeNights.Size = New System.Drawing.Size(31, 17)
        Me.rbThreeNights.TabIndex = 4
        Me.rbThreeNights.TabStop = True
        Me.rbThreeNights.Text = "3"
        Me.rbThreeNights.UseVisualStyleBackColor = True
        '
        'rbTwoNight
        '
        Me.rbTwoNight.AutoSize = True
        Me.rbTwoNight.Enabled = False
        Me.rbTwoNight.Location = New System.Drawing.Point(213, 45)
        Me.rbTwoNight.Name = "rbTwoNight"
        Me.rbTwoNight.Size = New System.Drawing.Size(31, 17)
        Me.rbTwoNight.TabIndex = 3
        Me.rbTwoNight.TabStop = True
        Me.rbTwoNight.Text = "2"
        Me.rbTwoNight.UseVisualStyleBackColor = True
        '
        'rbOneNight
        '
        Me.rbOneNight.AutoSize = True
        Me.rbOneNight.Enabled = False
        Me.rbOneNight.Location = New System.Drawing.Point(175, 45)
        Me.rbOneNight.Name = "rbOneNight"
        Me.rbOneNight.Size = New System.Drawing.Size(31, 17)
        Me.rbOneNight.TabIndex = 2
        Me.rbOneNight.TabStop = True
        Me.rbOneNight.Text = "1"
        Me.rbOneNight.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of nights"
        '
        'chkOvernight
        '
        Me.chkOvernight.AutoSize = True
        Me.chkOvernight.Location = New System.Drawing.Point(9, 46)
        Me.chkOvernight.Name = "chkOvernight"
        Me.chkOvernight.Size = New System.Drawing.Size(96, 17)
        Me.chkOvernight.TabIndex = 0
        Me.chkOvernight.Text = "Overnight Stay"
        Me.chkOvernight.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Big_Event_Calculator.My.Resources.Resources.packers_logo_color_gradient_500x500
        Me.PictureBox1.Location = New System.Drawing.Point(402, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'chkHat
        '
        Me.chkHat.AutoSize = True
        Me.chkHat.Location = New System.Drawing.Point(122, 19)
        Me.chkHat.Name = "chkHat"
        Me.chkHat.Size = New System.Drawing.Size(43, 17)
        Me.chkHat.TabIndex = 1
        Me.chkHat.Text = "Hat"
        Me.chkHat.UseVisualStyleBackColor = True
        '
        'chkProgram
        '
        Me.chkProgram.AutoSize = True
        Me.chkProgram.Location = New System.Drawing.Point(250, 19)
        Me.chkProgram.Name = "chkProgram"
        Me.chkProgram.Size = New System.Drawing.Size(65, 17)
        Me.chkProgram.TabIndex = 2
        Me.chkProgram.Text = "Program"
        Me.chkProgram.UseVisualStyleBackColor = True
        '
        'chkShirt
        '
        Me.chkShirt.AllowDrop = True
        Me.chkShirt.AutoSize = True
        Me.chkShirt.Location = New System.Drawing.Point(9, 19)
        Me.chkShirt.Name = "chkShirt"
        Me.chkShirt.Size = New System.Drawing.Size(57, 17)
        Me.chkShirt.TabIndex = 3
        Me.chkShirt.Text = "T-Shirt"
        Me.chkShirt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkShirt.UseVisualStyleBackColor = True
        '
        'chkPizza
        '
        Me.chkPizza.AutoSize = True
        Me.chkPizza.Location = New System.Drawing.Point(9, 17)
        Me.chkPizza.Name = "chkPizza"
        Me.chkPizza.Size = New System.Drawing.Size(51, 17)
        Me.chkPizza.TabIndex = 1
        Me.chkPizza.Text = "Pizza"
        Me.chkPizza.UseVisualStyleBackColor = True
        '
        'chkHotDog
        '
        Me.chkHotDog.AutoSize = True
        Me.chkHotDog.Location = New System.Drawing.Point(99, 17)
        Me.chkHotDog.Name = "chkHotDog"
        Me.chkHotDog.Size = New System.Drawing.Size(66, 17)
        Me.chkHotDog.TabIndex = 2
        Me.chkHotDog.Text = "Hot Dog"
        Me.chkHotDog.UseVisualStyleBackColor = True
        '
        'chkChips
        '
        Me.chkChips.AutoSize = True
        Me.chkChips.Location = New System.Drawing.Point(190, 17)
        Me.chkChips.Name = "chkChips"
        Me.chkChips.Size = New System.Drawing.Size(52, 17)
        Me.chkChips.TabIndex = 3
        Me.chkChips.Text = "Chips"
        Me.chkChips.UseVisualStyleBackColor = True
        '
        'chkCoke
        '
        Me.chkCoke.AutoSize = True
        Me.chkCoke.Location = New System.Drawing.Point(264, 17)
        Me.chkCoke.Name = "chkCoke"
        Me.chkCoke.Size = New System.Drawing.Size(51, 17)
        Me.chkCoke.TabIndex = 4
        Me.chkCoke.Text = "Coke"
        Me.chkCoke.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 446)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbAccomodations)
        Me.Controls.Add(Me.gbConcessions)
        Me.Controls.Add(Me.gbMerch)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gbEventSeating)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbEventSeating.ResumeLayout(False)
        Me.gbEventSeating.PerformLayout()
        Me.gbMerch.ResumeLayout(False)
        Me.gbMerch.PerformLayout()
        Me.gbConcessions.ResumeLayout(False)
        Me.gbConcessions.PerformLayout()
        Me.gbAccomodations.ResumeLayout(False)
        Me.gbAccomodations.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbEventSeating As System.Windows.Forms.GroupBox
    Friend WithEvents rbNoseBleedSeats As System.Windows.Forms.RadioButton
    Friend WithEvents rbGeneralSeats As System.Windows.Forms.RadioButton
    Friend WithEvents rbPremiumSeats As System.Windows.Forms.RadioButton
    Friend WithEvents lblNumberOfTickets As System.Windows.Forms.Label
    Friend WithEvents cbNumberOfSeats As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents gbMerch As System.Windows.Forms.GroupBox
    Friend WithEvents gbConcessions As System.Windows.Forms.GroupBox
    Friend WithEvents gbAccomodations As System.Windows.Forms.GroupBox
    Friend WithEvents rbThreeNights As System.Windows.Forms.RadioButton
    Friend WithEvents rbTwoNight As System.Windows.Forms.RadioButton
    Friend WithEvents rbOneNight As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkOvernight As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkShirt As System.Windows.Forms.CheckBox
    Friend WithEvents chkProgram As System.Windows.Forms.CheckBox
    Friend WithEvents chkHat As System.Windows.Forms.CheckBox
    Friend WithEvents chkCoke As System.Windows.Forms.CheckBox
    Friend WithEvents chkChips As System.Windows.Forms.CheckBox
    Friend WithEvents chkHotDog As System.Windows.Forms.CheckBox
    Friend WithEvents chkPizza As System.Windows.Forms.CheckBox

End Class
