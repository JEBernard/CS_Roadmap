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
        Me.gbPlayerChoice = New System.Windows.Forms.GroupBox()
        Me.rbRandomChoice = New System.Windows.Forms.RadioButton()
        Me.rbPrevCpuChoice = New System.Windows.Forms.RadioButton()
        Me.rbAlwaysScissors = New System.Windows.Forms.RadioButton()
        Me.rbAlwaysPaper = New System.Windows.Forms.RadioButton()
        Me.rbAlwaysRock = New System.Windows.Forms.RadioButton()
        Me.txtSim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlayerWins = New System.Windows.Forms.TextBox()
        Me.txtCpuWins = New System.Windows.Forms.TextBox()
        Me.txtTies = New System.Windows.Forms.TextBox()
        Me.txtPlayerPercent = New System.Windows.Forms.TextBox()
        Me.txtCpuPercent = New System.Windows.Forms.TextBox()
        Me.txtTiePercent = New System.Windows.Forms.TextBox()
        Me.txtCpuRock = New System.Windows.Forms.TextBox()
        Me.txtCpuPaper = New System.Windows.Forms.TextBox()
        Me.txtCpuScissors = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbPlayerChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPlayerChoice
        '
        Me.gbPlayerChoice.Controls.Add(Me.rbRandomChoice)
        Me.gbPlayerChoice.Controls.Add(Me.rbPrevCpuChoice)
        Me.gbPlayerChoice.Controls.Add(Me.rbAlwaysScissors)
        Me.gbPlayerChoice.Controls.Add(Me.rbAlwaysPaper)
        Me.gbPlayerChoice.Controls.Add(Me.rbAlwaysRock)
        Me.gbPlayerChoice.Location = New System.Drawing.Point(22, 33)
        Me.gbPlayerChoice.Name = "gbPlayerChoice"
        Me.gbPlayerChoice.Size = New System.Drawing.Size(182, 163)
        Me.gbPlayerChoice.TabIndex = 0
        Me.gbPlayerChoice.TabStop = False
        Me.gbPlayerChoice.Text = "Make a Selection"
        '
        'rbRandomChoice
        '
        Me.rbRandomChoice.AutoSize = True
        Me.rbRandomChoice.Location = New System.Drawing.Point(16, 123)
        Me.rbRandomChoice.Name = "rbRandomChoice"
        Me.rbRandomChoice.Size = New System.Drawing.Size(65, 17)
        Me.rbRandomChoice.TabIndex = 4
        Me.rbRandomChoice.TabStop = True
        Me.rbRandomChoice.Text = "Random"
        Me.rbRandomChoice.UseVisualStyleBackColor = True
        '
        'rbPrevCpuChoice
        '
        Me.rbPrevCpuChoice.AutoSize = True
        Me.rbPrevCpuChoice.Location = New System.Drawing.Point(16, 100)
        Me.rbPrevCpuChoice.Name = "rbPrevCpuChoice"
        Me.rbPrevCpuChoice.Size = New System.Drawing.Size(150, 17)
        Me.rbPrevCpuChoice.TabIndex = 3
        Me.rbPrevCpuChoice.TabStop = True
        Me.rbPrevCpuChoice.Text = "Previous Computer Choice"
        Me.rbPrevCpuChoice.UseVisualStyleBackColor = True
        '
        'rbAlwaysScissors
        '
        Me.rbAlwaysScissors.AutoSize = True
        Me.rbAlwaysScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbAlwaysScissors.Location = New System.Drawing.Point(16, 77)
        Me.rbAlwaysScissors.Name = "rbAlwaysScissors"
        Me.rbAlwaysScissors.Size = New System.Drawing.Size(99, 17)
        Me.rbAlwaysScissors.TabIndex = 2
        Me.rbAlwaysScissors.TabStop = True
        Me.rbAlwaysScissors.Text = "Always Scissors"
        Me.rbAlwaysScissors.UseVisualStyleBackColor = True
        '
        'rbAlwaysPaper
        '
        Me.rbAlwaysPaper.AutoSize = True
        Me.rbAlwaysPaper.Location = New System.Drawing.Point(16, 54)
        Me.rbAlwaysPaper.Name = "rbAlwaysPaper"
        Me.rbAlwaysPaper.Size = New System.Drawing.Size(89, 17)
        Me.rbAlwaysPaper.TabIndex = 1
        Me.rbAlwaysPaper.TabStop = True
        Me.rbAlwaysPaper.Text = "Always Paper"
        Me.rbAlwaysPaper.UseVisualStyleBackColor = True
        '
        'rbAlwaysRock
        '
        Me.rbAlwaysRock.AutoSize = True
        Me.rbAlwaysRock.Location = New System.Drawing.Point(16, 27)
        Me.rbAlwaysRock.Name = "rbAlwaysRock"
        Me.rbAlwaysRock.Size = New System.Drawing.Size(87, 17)
        Me.rbAlwaysRock.TabIndex = 0
        Me.rbAlwaysRock.TabStop = True
        Me.rbAlwaysRock.Text = "Always Rock"
        Me.rbAlwaysRock.UseVisualStyleBackColor = True
        '
        'txtSim
        '
        Me.txtSim.Location = New System.Drawing.Point(318, 33)
        Me.txtSim.Name = "txtSim"
        Me.txtSim.Size = New System.Drawing.Size(140, 20)
        Me.txtSim.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter # of Simulations"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(349, 79)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(90, 25)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 129)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(221, 210)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(84, 25)
        Me.lblResults.TabIndex = 5
        Me.lblResults.Text = "Results"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Player WIns"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Computer Wins"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(413, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ties"
        '
        'txtPlayerWins
        '
        Me.txtPlayerWins.Enabled = False
        Me.txtPlayerWins.Location = New System.Drawing.Point(43, 277)
        Me.txtPlayerWins.Name = "txtPlayerWins"
        Me.txtPlayerWins.Size = New System.Drawing.Size(81, 20)
        Me.txtPlayerWins.TabIndex = 9
        '
        'txtCpuWins
        '
        Me.txtCpuWins.Enabled = False
        Me.txtCpuWins.Location = New System.Drawing.Point(229, 277)
        Me.txtCpuWins.Name = "txtCpuWins"
        Me.txtCpuWins.Size = New System.Drawing.Size(81, 20)
        Me.txtCpuWins.TabIndex = 10
        '
        'txtTies
        '
        Me.txtTies.Enabled = False
        Me.txtTies.Location = New System.Drawing.Point(391, 277)
        Me.txtTies.Name = "txtTies"
        Me.txtTies.Size = New System.Drawing.Size(81, 20)
        Me.txtTies.TabIndex = 11
        '
        'txtPlayerPercent
        '
        Me.txtPlayerPercent.Enabled = False
        Me.txtPlayerPercent.Location = New System.Drawing.Point(46, 345)
        Me.txtPlayerPercent.Name = "txtPlayerPercent"
        Me.txtPlayerPercent.Size = New System.Drawing.Size(81, 20)
        Me.txtPlayerPercent.TabIndex = 12
        '
        'txtCpuPercent
        '
        Me.txtCpuPercent.Enabled = False
        Me.txtCpuPercent.Location = New System.Drawing.Point(229, 345)
        Me.txtCpuPercent.Name = "txtCpuPercent"
        Me.txtCpuPercent.Size = New System.Drawing.Size(81, 20)
        Me.txtCpuPercent.TabIndex = 13
        '
        'txtTiePercent
        '
        Me.txtTiePercent.Enabled = False
        Me.txtTiePercent.Location = New System.Drawing.Point(391, 345)
        Me.txtTiePercent.Name = "txtTiePercent"
        Me.txtTiePercent.Size = New System.Drawing.Size(81, 20)
        Me.txtTiePercent.TabIndex = 14
        '
        'txtCpuRock
        '
        Me.txtCpuRock.Enabled = False
        Me.txtCpuRock.Location = New System.Drawing.Point(46, 461)
        Me.txtCpuRock.Name = "txtCpuRock"
        Me.txtCpuRock.Size = New System.Drawing.Size(81, 20)
        Me.txtCpuRock.TabIndex = 15
        '
        'txtCpuPaper
        '
        Me.txtCpuPaper.Enabled = False
        Me.txtCpuPaper.Location = New System.Drawing.Point(226, 461)
        Me.txtCpuPaper.Name = "txtCpuPaper"
        Me.txtCpuPaper.Size = New System.Drawing.Size(81, 20)
        Me.txtCpuPaper.TabIndex = 16
        '
        'txtCpuScissors
        '
        Me.txtCpuScissors.Enabled = False
        Me.txtCpuScissors.Location = New System.Drawing.Point(377, 461)
        Me.txtCpuScissors.Name = "txtCpuScissors"
        Me.txtCpuScissors.Size = New System.Drawing.Size(81, 20)
        Me.txtCpuScissors.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Rock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Player WIn %"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(228, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Computer WIn %"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(245, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Paper"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(413, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Tie %"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(400, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Scissors"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(162, 393)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Computer Selection Summary"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 516)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCpuScissors)
        Me.Controls.Add(Me.txtCpuPaper)
        Me.Controls.Add(Me.txtCpuRock)
        Me.Controls.Add(Me.txtTiePercent)
        Me.Controls.Add(Me.txtCpuPercent)
        Me.Controls.Add(Me.txtPlayerPercent)
        Me.Controls.Add(Me.txtTies)
        Me.Controls.Add(Me.txtCpuWins)
        Me.Controls.Add(Me.txtPlayerWins)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSim)
        Me.Controls.Add(Me.gbPlayerChoice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbPlayerChoice.ResumeLayout(False)
        Me.gbPlayerChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbPlayerChoice As System.Windows.Forms.GroupBox
    Friend WithEvents rbRandomChoice As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrevCpuChoice As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlwaysScissors As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlwaysPaper As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlwaysRock As System.Windows.Forms.RadioButton
    Friend WithEvents txtSim As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerWins As System.Windows.Forms.TextBox
    Friend WithEvents txtCpuWins As System.Windows.Forms.TextBox
    Friend WithEvents txtTies As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayerPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtCpuPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtTiePercent As System.Windows.Forms.TextBox
    Friend WithEvents txtCpuRock As System.Windows.Forms.TextBox
    Friend WithEvents txtCpuPaper As System.Windows.Forms.TextBox
    Friend WithEvents txtCpuScissors As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
