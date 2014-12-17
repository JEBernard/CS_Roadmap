<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTime))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblSunday = New System.Windows.Forms.Label()
        Me.lblMonday = New System.Windows.Forms.Label()
        Me.lblTuesday = New System.Windows.Forms.Label()
        Me.lblWednesday = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFriday = New System.Windows.Forms.Label()
        Me.lblSaturday = New System.Windows.Forms.Label()
        Me.txtSunday = New System.Windows.Forms.TextBox()
        Me.txtMonday = New System.Windows.Forms.TextBox()
        Me.txtTuesday = New System.Windows.Forms.TextBox()
        Me.txtWednesday = New System.Windows.Forms.TextBox()
        Me.txtThursday = New System.Windows.Forms.TextBox()
        Me.txtFriday = New System.Windows.Forms.TextBox()
        Me.txtSaturday = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.txtTotalHours = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.BackgroundImage = Global.Final_Project.My.Resources.Resources.Clear_Lime
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 64)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(170, 71)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lblSunday
        '
        Me.lblSunday.AutoSize = True
        Me.lblSunday.Location = New System.Drawing.Point(71, 159)
        Me.lblSunday.Name = "lblSunday"
        Me.lblSunday.Size = New System.Drawing.Size(26, 13)
        Me.lblSunday.TabIndex = 2
        Me.lblSunday.Text = "Sun"
        '
        'lblMonday
        '
        Me.lblMonday.AutoSize = True
        Me.lblMonday.Location = New System.Drawing.Point(130, 159)
        Me.lblMonday.Name = "lblMonday"
        Me.lblMonday.Size = New System.Drawing.Size(28, 13)
        Me.lblMonday.TabIndex = 3
        Me.lblMonday.Text = "Mon"
        '
        'lblTuesday
        '
        Me.lblTuesday.AutoSize = True
        Me.lblTuesday.Location = New System.Drawing.Point(187, 159)
        Me.lblTuesday.Name = "lblTuesday"
        Me.lblTuesday.Size = New System.Drawing.Size(26, 13)
        Me.lblTuesday.TabIndex = 4
        Me.lblTuesday.Text = "Tue"
        '
        'lblWednesday
        '
        Me.lblWednesday.AutoSize = True
        Me.lblWednesday.Location = New System.Drawing.Point(245, 159)
        Me.lblWednesday.Name = "lblWednesday"
        Me.lblWednesday.Size = New System.Drawing.Size(30, 13)
        Me.lblWednesday.TabIndex = 5
        Me.lblWednesday.Text = "Wed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(298, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Thu"
        '
        'lblFriday
        '
        Me.lblFriday.AutoSize = True
        Me.lblFriday.Location = New System.Drawing.Point(354, 159)
        Me.lblFriday.Name = "lblFriday"
        Me.lblFriday.Size = New System.Drawing.Size(18, 13)
        Me.lblFriday.TabIndex = 7
        Me.lblFriday.Text = "Fri"
        '
        'lblSaturday
        '
        Me.lblSaturday.AutoSize = True
        Me.lblSaturday.Location = New System.Drawing.Point(402, 159)
        Me.lblSaturday.Name = "lblSaturday"
        Me.lblSaturday.Size = New System.Drawing.Size(23, 13)
        Me.lblSaturday.TabIndex = 8
        Me.lblSaturday.Text = "Sat"
        '
        'txtSunday
        '
        Me.txtSunday.Location = New System.Drawing.Point(77, 195)
        Me.txtSunday.Name = "txtSunday"
        Me.txtSunday.Size = New System.Drawing.Size(20, 20)
        Me.txtSunday.TabIndex = 9
        '
        'txtMonday
        '
        Me.txtMonday.Location = New System.Drawing.Point(133, 195)
        Me.txtMonday.Name = "txtMonday"
        Me.txtMonday.Size = New System.Drawing.Size(20, 20)
        Me.txtMonday.TabIndex = 10
        '
        'txtTuesday
        '
        Me.txtTuesday.Location = New System.Drawing.Point(190, 195)
        Me.txtTuesday.Name = "txtTuesday"
        Me.txtTuesday.Size = New System.Drawing.Size(20, 20)
        Me.txtTuesday.TabIndex = 11
        '
        'txtWednesday
        '
        Me.txtWednesday.Location = New System.Drawing.Point(248, 195)
        Me.txtWednesday.Name = "txtWednesday"
        Me.txtWednesday.Size = New System.Drawing.Size(20, 20)
        Me.txtWednesday.TabIndex = 12
        '
        'txtThursday
        '
        Me.txtThursday.Location = New System.Drawing.Point(304, 195)
        Me.txtThursday.Name = "txtThursday"
        Me.txtThursday.Size = New System.Drawing.Size(20, 20)
        Me.txtThursday.TabIndex = 13
        '
        'txtFriday
        '
        Me.txtFriday.Location = New System.Drawing.Point(357, 195)
        Me.txtFriday.Name = "txtFriday"
        Me.txtFriday.Size = New System.Drawing.Size(20, 20)
        Me.txtFriday.TabIndex = 14
        '
        'txtSaturday
        '
        Me.txtSaturday.Location = New System.Drawing.Point(405, 195)
        Me.txtSaturday.Name = "txtSaturday"
        Me.txtSaturday.Size = New System.Drawing.Size(20, 20)
        Me.txtSaturday.TabIndex = 15
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(372, 240)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(147, 25)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "&Submit Time"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblTotalHours
        '
        Me.lblTotalHours.AutoSize = True
        Me.lblTotalHours.Location = New System.Drawing.Point(85, 249)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(65, 13)
        Me.lblTotalHours.TabIndex = 17
        Me.lblTotalHours.Text = "Total Hours:"
        '
        'txtTotalHours
        '
        Me.txtTotalHours.Location = New System.Drawing.Point(154, 243)
        Me.txtTotalHours.Name = "txtTotalHours"
        Me.txtTotalHours.ReadOnly = True
        Me.txtTotalHours.Size = New System.Drawing.Size(59, 20)
        Me.txtTotalHours.TabIndex = 18
        '
        'frmTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.nwUWEJe
        Me.ClientSize = New System.Drawing.Size(571, 363)
        Me.Controls.Add(Me.txtTotalHours)
        Me.Controls.Add(Me.lblTotalHours)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtSaturday)
        Me.Controls.Add(Me.txtFriday)
        Me.Controls.Add(Me.txtThursday)
        Me.Controls.Add(Me.txtWednesday)
        Me.Controls.Add(Me.txtTuesday)
        Me.Controls.Add(Me.txtMonday)
        Me.Controls.Add(Me.txtSunday)
        Me.Controls.Add(Me.lblSaturday)
        Me.Controls.Add(Me.lblFriday)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblWednesday)
        Me.Controls.Add(Me.lblTuesday)
        Me.Controls.Add(Me.lblMonday)
        Me.Controls.Add(Me.lblSunday)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTime"
        Me.RightToLeftLayout = True
        Me.Text = "Time Card"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSunday As System.Windows.Forms.Label
    Friend WithEvents lblMonday As System.Windows.Forms.Label
    Friend WithEvents lblTuesday As System.Windows.Forms.Label
    Friend WithEvents lblWednesday As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFriday As System.Windows.Forms.Label
    Friend WithEvents lblSaturday As System.Windows.Forms.Label
    Friend WithEvents txtSunday As System.Windows.Forms.TextBox
    Friend WithEvents txtMonday As System.Windows.Forms.TextBox
    Friend WithEvents txtTuesday As System.Windows.Forms.TextBox
    Friend WithEvents txtWednesday As System.Windows.Forms.TextBox
    Friend WithEvents txtThursday As System.Windows.Forms.TextBox
    Friend WithEvents txtFriday As System.Windows.Forms.TextBox
    Friend WithEvents txtSaturday As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblTotalHours As System.Windows.Forms.Label
    Friend WithEvents txtTotalHours As System.Windows.Forms.TextBox
End Class
