<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMovies
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblRunning = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.rbRateOne = New System.Windows.Forms.RadioButton()
        Me.rbRateTwo = New System.Windows.Forms.RadioButton()
        Me.rbRateThree = New System.Windows.Forms.RadioButton()
        Me.rbRateFour = New System.Windows.Forms.RadioButton()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.chkComedy = New System.Windows.Forms.CheckBox()
        Me.chkKids = New System.Windows.Forms.CheckBox()
        Me.chkDrama = New System.Windows.Forms.CheckBox()
        Me.chkAction = New System.Windows.Forms.CheckBox()
        Me.chkSciFi = New System.Windows.Forms.CheckBox()
        Me.chkTV = New System.Windows.Forms.CheckBox()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.cboFormat = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(26, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(29, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(250, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblRunning
        '
        Me.lblRunning.AutoSize = True
        Me.lblRunning.Location = New System.Drawing.Point(156, 77)
        Me.lblRunning.Name = "lblRunning"
        Me.lblRunning.Size = New System.Drawing.Size(119, 13)
        Me.lblRunning.TabIndex = 2
        Me.lblRunning.Text = "Running Time (Minutes)"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(26, 77)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(29, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(59, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(159, 93)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(57, 20)
        Me.TextBox3.TabIndex = 5
        '
        'rbRateOne
        '
        Me.rbRateOne.AutoSize = True
        Me.rbRateOne.Location = New System.Drawing.Point(38, 154)
        Me.rbRateOne.Name = "rbRateOne"
        Me.rbRateOne.Size = New System.Drawing.Size(31, 17)
        Me.rbRateOne.TabIndex = 6
        Me.rbRateOne.TabStop = True
        Me.rbRateOne.Text = "1"
        Me.rbRateOne.UseVisualStyleBackColor = True
        '
        'rbRateTwo
        '
        Me.rbRateTwo.AutoSize = True
        Me.rbRateTwo.Location = New System.Drawing.Point(100, 154)
        Me.rbRateTwo.Name = "rbRateTwo"
        Me.rbRateTwo.Size = New System.Drawing.Size(31, 17)
        Me.rbRateTwo.TabIndex = 7
        Me.rbRateTwo.TabStop = True
        Me.rbRateTwo.Text = "2"
        Me.rbRateTwo.UseVisualStyleBackColor = True
        '
        'rbRateThree
        '
        Me.rbRateThree.AutoSize = True
        Me.rbRateThree.Location = New System.Drawing.Point(174, 154)
        Me.rbRateThree.Name = "rbRateThree"
        Me.rbRateThree.Size = New System.Drawing.Size(31, 17)
        Me.rbRateThree.TabIndex = 8
        Me.rbRateThree.TabStop = True
        Me.rbRateThree.Text = "3"
        Me.rbRateThree.UseVisualStyleBackColor = True
        '
        'rbRateFour
        '
        Me.rbRateFour.AutoSize = True
        Me.rbRateFour.Location = New System.Drawing.Point(244, 154)
        Me.rbRateFour.Name = "rbRateFour"
        Me.rbRateFour.Size = New System.Drawing.Size(31, 17)
        Me.rbRateFour.TabIndex = 9
        Me.rbRateFour.TabStop = True
        Me.rbRateFour.Text = "4"
        Me.rbRateFour.UseVisualStyleBackColor = True
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(26, 138)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(38, 13)
        Me.lblRating.TabIndex = 10
        Me.lblRating.Text = "Rating"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(26, 202)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(36, 13)
        Me.lblGenre.TabIndex = 11
        Me.lblGenre.Text = "Genre"
        '
        'chkComedy
        '
        Me.chkComedy.AutoSize = True
        Me.chkComedy.Location = New System.Drawing.Point(33, 218)
        Me.chkComedy.Name = "chkComedy"
        Me.chkComedy.Size = New System.Drawing.Size(64, 17)
        Me.chkComedy.TabIndex = 12
        Me.chkComedy.Text = "Comedy"
        Me.chkComedy.UseVisualStyleBackColor = True
        '
        'chkKids
        '
        Me.chkKids.AutoSize = True
        Me.chkKids.Location = New System.Drawing.Point(120, 218)
        Me.chkKids.Name = "chkKids"
        Me.chkKids.Size = New System.Drawing.Size(46, 17)
        Me.chkKids.TabIndex = 13
        Me.chkKids.Text = "Kids"
        Me.chkKids.UseVisualStyleBackColor = True
        '
        'chkDrama
        '
        Me.chkDrama.AutoSize = True
        Me.chkDrama.Location = New System.Drawing.Point(222, 218)
        Me.chkDrama.Name = "chkDrama"
        Me.chkDrama.Size = New System.Drawing.Size(57, 17)
        Me.chkDrama.TabIndex = 14
        Me.chkDrama.Text = "Drama"
        Me.chkDrama.UseVisualStyleBackColor = True
        '
        'chkAction
        '
        Me.chkAction.AutoSize = True
        Me.chkAction.Location = New System.Drawing.Point(29, 255)
        Me.chkAction.Name = "chkAction"
        Me.chkAction.Size = New System.Drawing.Size(56, 17)
        Me.chkAction.TabIndex = 15
        Me.chkAction.Text = "Action"
        Me.chkAction.UseVisualStyleBackColor = True
        '
        'chkSciFi
        '
        Me.chkSciFi.AutoSize = True
        Me.chkSciFi.Location = New System.Drawing.Point(120, 255)
        Me.chkSciFi.Name = "chkSciFi"
        Me.chkSciFi.Size = New System.Drawing.Size(52, 17)
        Me.chkSciFi.TabIndex = 16
        Me.chkSciFi.Text = "Sci-Fi"
        Me.chkSciFi.UseVisualStyleBackColor = True
        '
        'chkTV
        '
        Me.chkTV.AutoSize = True
        Me.chkTV.Location = New System.Drawing.Point(222, 255)
        Me.chkTV.Name = "chkTV"
        Me.chkTV.Size = New System.Drawing.Size(40, 17)
        Me.chkTV.TabIndex = 17
        Me.chkTV.Text = "TV"
        Me.chkTV.UseVisualStyleBackColor = True
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(26, 285)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(39, 13)
        Me.lblFormat.TabIndex = 18
        Me.lblFormat.Text = "Format"
        '
        'cboFormat
        '
        Me.cboFormat.FormattingEnabled = True
        Me.cboFormat.Items.AddRange(New Object() {"Blu-Ray", "DVD", "Laser Disk", "VHS", "Video File"})
        Me.cboFormat.Location = New System.Drawing.Point(29, 301)
        Me.cboFormat.Name = "cboFormat"
        Me.cboFormat.Size = New System.Drawing.Size(121, 21)
        Me.cboFormat.TabIndex = 19
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(29, 338)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(246, 27)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 24)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "&Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(193, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 24)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAddMovies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 425)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboFormat)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.chkTV)
        Me.Controls.Add(Me.chkSciFi)
        Me.Controls.Add(Me.chkAction)
        Me.Controls.Add(Me.chkDrama)
        Me.Controls.Add(Me.chkKids)
        Me.Controls.Add(Me.chkComedy)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.rbRateFour)
        Me.Controls.Add(Me.rbRateThree)
        Me.Controls.Add(Me.rbRateTwo)
        Me.Controls.Add(Me.rbRateOne)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblRunning)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmAddMovies"
        Me.Text = "Enter Movie Data "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Protected Friend WithEvents lblRunning As System.Windows.Forms.Label
    Protected Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents rbRateOne As System.Windows.Forms.RadioButton
    Friend WithEvents rbRateTwo As System.Windows.Forms.RadioButton
    Friend WithEvents rbRateThree As System.Windows.Forms.RadioButton
    Friend WithEvents rbRateFour As System.Windows.Forms.RadioButton
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents chkComedy As System.Windows.Forms.CheckBox
    Friend WithEvents chkKids As System.Windows.Forms.CheckBox
    Friend WithEvents chkDrama As System.Windows.Forms.CheckBox
    Friend WithEvents chkAction As System.Windows.Forms.CheckBox
    Friend WithEvents chkSciFi As System.Windows.Forms.CheckBox
    Friend WithEvents chkTV As System.Windows.Forms.CheckBox
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents cboFormat As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
