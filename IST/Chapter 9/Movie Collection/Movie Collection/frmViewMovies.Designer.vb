<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewMovies
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtRating = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 330)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(87, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(12, 87)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(188, 72)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(119, 13)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Running Time (Minutes)"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(12, 152)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(41, 13)
        Me.lblRating.TabIndex = 5
        Me.lblRating.Text = "Rating:"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(12, 215)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(39, 13)
        Me.lblGenre.TabIndex = 6
        Me.lblGenre.Text = "Genre:"
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(12, 268)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(42, 13)
        Me.lblFormat.TabIndex = 7
        Me.lblFormat.Text = "Format:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(59, 28)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(202, 20)
        Me.txtTitle.TabIndex = 8
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(59, 84)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(56, 20)
        Me.txtYear.TabIndex = 9
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(218, 88)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(51, 20)
        Me.txtTime.TabIndex = 10
        '
        'txtRating
        '
        Me.txtRating.Location = New System.Drawing.Point(59, 149)
        Me.txtRating.Name = "txtRating"
        Me.txtRating.Size = New System.Drawing.Size(17, 20)
        Me.txtRating.TabIndex = 11
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(59, 212)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(85, 20)
        Me.txtGenre.TabIndex = 12
        '
        'txtFormat
        '
        Me.txtFormat.Location = New System.Drawing.Point(60, 261)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(84, 20)
        Me.txtFormat.TabIndex = 13
        '
        'frmViewMovies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 374)
        Me.Controls.Add(Me.txtFormat)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.txtRating)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmViewMovies"
        Me.Text = "View Movies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents lblFormat As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtRating As System.Windows.Forms.TextBox
    Friend WithEvents txtGenre As System.Windows.Forms.TextBox
    Friend WithEvents txtFormat As System.Windows.Forms.TextBox
End Class
