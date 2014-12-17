Public Class frmViewMovies

    Private Sub frmViewMovies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("MovieCollection.txt") Then
            Dim readMovies As New System.IO.StreamReader("MovieCollection.txt")

            txtTitle.Text = readMovies.ReadLine
            txtYear.Text = readMovies.ReadLine
            txtTime.Text = readMovies.ReadLine
            txtRating.Text = readMovies.ReadLine
            txtGenre.Text = readMovies.ReadLine
            txtFormat.Text = readMovies.ReadLine

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class