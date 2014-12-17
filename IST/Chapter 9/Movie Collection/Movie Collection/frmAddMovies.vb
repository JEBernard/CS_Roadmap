Imports System.IO
Public Class frmAddMovies

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Add movies to file MovieCollection.txt located in the \bin\debug dir

        Dim addMovie As New System.IO.StreamWriter("MovieCollection.txt", True)

        'get Title / Year / Running Time 

        addMovie.WriteLine(Me.TextBox1.Text)
        addMovie.WriteLine(Me.TextBox2.Text)
        addMovie.WriteLine(Me.TextBox3.Text)
        If rbRateOne.Checked Then
            addMovie.WriteLine(Me.rbRateOne.Text)
        ElseIf rbRateTwo.Checked Then
            addMovie.WriteLine(Me.rbRateTwo.Text)
        ElseIf rbRateThree.Checked Then
            addMovie.WriteLine(Me.rbRateThree.Text)
        ElseIf rbRateFour.Checked Then
            addMovie.WriteLine(Me.rbRateFour.Text)
        End If

        'Get Genre

        If chkAction.Checked Then
            addMovie.WriteLine(Me.chkAction.Text)
        ElseIf chkComedy.Checked Then
            addMovie.WriteLine(Me.chkComedy.Text)
        ElseIf chkDrama.Checked Then
            addMovie.WriteLine(Me.chkDrama.Text)
        ElseIf chkKids.Checked Then
            addMovie.WriteLine(Me.chkKids.Text)
        ElseIf chkSciFi.Checked Then
            addMovie.WriteLine(Me.chkSciFi.Text)
        ElseIf chkTV.Checked Then
            addMovie.WriteLine(Me.chkTV.Text)
        End If

        'Get Format

        If cboFormat.Items.Equals("DVD") Then
            addMovie.WriteLine(Me.cboFormat.SelectedItem.ToString)
        ElseIf cboFormat.SelectedItem.Equals("VHS") Then
            addMovie.WriteLine(Me.cboFormat.SelectedItem.ToString)
        ElseIf cboFormat.SelectedItem.Equals("Laser Disk") Then
            addMovie.WriteLine(Me.cboFormat.SelectedItem.ToString)
        ElseIf cboFormat.SelectedItem.Equals("Blu-Ray") Then
            addMovie.WriteLine(Me.cboFormat.SelectedItem.ToString)
        ElseIf cboFormat.SelectedItem.Equals("Video File") Then
            addMovie.WriteLine(Me.cboFormat.SelectedItem.ToString)
        End If
        addMovie.Close()
        MsgBox("Movie Successfully Added To Collection", vbOKOnly)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clear the Form of input
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        rbRateOne.Checked = False
        rbRateTwo.Checked = False
        rbRateThree.Checked = False
        rbRateFour.Checked = False
        chkAction.Checked = False
        chkComedy.Checked = False
        chkDrama.Checked = False
        chkKids.Checked = False
        chkSciFi.Checked = False
        chkTV.Checked = False
        cboFormat.Refresh()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class