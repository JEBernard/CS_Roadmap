Public Class Form1
    Dim rand As New Random
    Dim lastCpuChoice As String
    Dim RPS(2) As String
    Dim playerChoice As String
    Dim computerChoice As String
    Dim RandomChoice As String
    Dim simNumber As Integer
    Dim playerWins As Double
    Dim computerWins As Double
    Dim ties As Double
    Dim playerWinPercent As Decimal
    Dim computerWinPercent As Decimal
    Dim tiePercent As Decimal
    Dim computerChoiceRock As Decimal
    Dim computerChoicePaper As Decimal
    Dim computerChoiceScissors As Decimal

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        RPS(0) = "Rock"
        RPS(1) = "Paper"
        RPS(2) = "Scissors"
        If IsNumeric(txtSim.Text) And txtSim.Text > 0 Then
            getPLayerChoice()
            getComputerChoice()
            simulate()
        End If
    End Sub
    Public Sub simulate()
        Dim ctrPlays As Integer
        Dim computerRockPercentage As Double
        Dim computerPaperPercentage As Double
        Dim computerScissorsPercentage As Double
        Dim playerPercentage = playerWins / computerWins * 100
        Dim ComputerPercentage = computerWins / playerWins * 100
        simNumber = txtSim.Text
        While simNumber > ctrPlays
            If playerChoice > computerChoice Then
                playerWins = playerWins + 1
                ctrPlays = ctrPlays + 1
            ElseIf computerChoice > playerChoice Then
                computerWins = computerWins + 1
                ctrPlays = ctrPlays + 1
            ElseIf computerChoice = playerChoice Then
                ties = ties + 1
                ctrPlays = ctrPlays + 1
            End If
            txtPlayerWins.Text = playerWins
            txtCpuWins.Text = computerWins
            txtTies.Text = ties
            txtPlayerPercent.Text = playerPercentage.ToString("##.00") & ("%")
            txtCpuPercent.Text = ComputerPercentage.ToString("##.00") & ("%")
            computerRockPercentage = computerChoiceRock / ctrPlays * 100
            txtCpuRock.Text = computerRockPercentage.ToString("##.00") & ("%")
            computerPaperPercentage = computerChoicePaper / ctrPlays * 100
            txtCpuPaper.Text = computerPaperPercentage.ToString("##.00")
            computerScissorsPercentage = computerChoiceScissors / ctrPlays * 100
            txtCpuScissors.Text = computerScissorsPercentage.ToString("##.00")

        End While
    End Sub
    Public Sub getComputerChoice()

        computerChoice = rand.Next(3)
        If computerChoice = 0 Then
            computerChoice = RPS(0)
            lastCpuChoice = RPS(0)
            computerChoiceRock = computerChoiceRock + 1
        ElseIf computerChoice = 1 Then
            computerChoice = RPS(1)
            lastCpuChoice = RPS(1)
            computerChoicePaper = computerChoicePaper + 1
        ElseIf computerChoice = 2 Then
            computerChoice = RPS(2)
            lastCpuChoice = RPS(2)
            computerChoiceScissors = computerChoiceScissors + 1
        End If

    End Sub
    Public Sub getPLayerChoice()
        If rbAlwaysRock.Checked Then
            playerChoice = RPS(0)
        ElseIf rbAlwaysPaper.Checked Then
            playerChoice = RPS(1)
        ElseIf rbAlwaysScissors.Checked Then
            playerChoice = RPS(2)
        ElseIf rbPrevCpuChoice.Checked Then
            playerChoice = lastCpuChoice
        ElseIf rbRandomChoice.Checked Then
            playerChoice = rand.Next(3)
            If playerChoice = 1 Then
                playerChoice = RPS(0)
            ElseIf playerChoice = 2 Then
                playerChoice = RPS(1)
            ElseIf playerChoice = 3 Then
                playerChoice = RPS(2)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class