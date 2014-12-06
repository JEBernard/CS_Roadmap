Public Class Form1

    Dim park As String
    Dim ride As String


    Public Sub getRecs()
        If txtAge.Text < 7 And txtTemp.Text >= 75 And txtTemp.Text > 50 Then
            pbRide.Image = My.Resources.waterpark
            park = "Water Park"
            ride = "Rain Storm"
        ElseIf txtAge.Text >= 7 And txtAge.Text < 14 And txtTemp.Text >= 75 And txtTemp.Text > 50 Then
            pbRide.Image = My.Resources.waterpark
            park = "Water Park"
            ride = "Summer Storm"
        ElseIf txtAge.Text >= 14 And txtTemp.Text >= 75 And txtTemp.Text > 50 Then
            pbRide.Image = My.Resources.waterpark
            park = "Water Park"
            ride = "ThunderStorm"
        ElseIf txtAge.Text < 7 And txtTemp.Text <= 74 And txtTemp.Text > 50 Then
            pbRide.Image = My.Resources.amusement
            park = "Amusement Park"
            ride = "Lil' Tornado"
        ElseIf txtAge.Text >= 7 And txtAge.Text < 14 And txtTemp.Text >= 74 And txtTemp.Text > 50 Then
            pbRide.Image = My.Resources.amusement
            park = "Amusement Park"
            ride = "Storm Chaser"
        ElseIf txtAge.Text >= 14 And txtTemp.Text >= 74 And txtTemp.Text > 50 Then
            pbRide.Image = My.Resources.amusement
            park = "Amusement Park"
            ride = "Storm Buster"
        ElseIf txtAge.Text < 7 And txtTemp.Text <= 50 Then
            pbRide.Image = My.Resources.Skiing2
            park = "Ski Park"
            ride = "Snow Drift Slope"
        ElseIf txtAge.Text >= 7 And txtAge.Text < 14 And txtTemp.Text <= 50 Then
            pbRide.Image = My.Resources.Skiing2
            park = "Ski Park"
            ride = "Blizzard Slope"
        ElseIf txtAge.Text >= 14 And txtTemp.Text <= 50 Then
            pbRide.Image = My.Resources.Skiing2
            park = "Ski Park"
            ride = "Avalanche Slope"
        ElseIf txtSeason.Text = "Winter" And txtTemp.Text < 50 Then
            pbRide.Image = My.Resources.stormland_closed
            park = "Park is Closed!"
        End If
        lblPark.Text = park
        lblRide.Text = ride

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtAge.Text = ""
        txtSeason.Text = ""
        txtTemp.Text = ""
        pbRide.Image = My.Resources.stormland
        lblPark.Text = ""
        lblRide.Text = ""
    End Sub

    Private Sub btnRecommend_Click(sender As Object, e As EventArgs) Handles btnRecommend.Click
        getRecs()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRide.Text = ""
        lblPark.Text = ""
    End Sub
End Class
