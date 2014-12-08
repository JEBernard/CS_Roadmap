Public Class Form1
    Dim PremiumSeats As Integer = 220
    Dim GeneralSeats As Integer = 125
    Dim NoseBleedSeats As Integer = 55

    Dim TShirt As Integer = 25
    Dim Hat As Integer = 18
    Dim Program As Integer = 12

    Dim Pizza As Decimal = 5.5
    Dim HotDog As Decimal = 4.0
    Dim Chips As Decimal = 3.25
    Dim Coke As Decimal = 2.25

    Dim extras As String
    Dim ticketCost As String
    Dim totalCost As String

    Dim FirstNightStay As Integer = 185
    Dim EachAdditionalNight As Integer = 125
    Public Sub additionalNightStay()
        If chkOvernight.Checked Then
            rbOneNight.Enabled = True
            rbTwoNight.Enabled = True
            rbThreeNights.Enabled = True
        Else : rbOneNight.Enabled = False
            rbOneNight.Checked = False
            rbTwoNight.Enabled = False
            rbTwoNight.Checked = False
            rbThreeNights.Enabled = False
            rbThreeNights.Checked = False
        End If
    End Sub
   
    Function calculateTicketCost() As Integer
        If rbPremiumSeats.Checked Then
            ticketCost = PremiumSeats * cbNumberOfSeats.Text.ToString
        ElseIf rbGeneralSeats.Checked Then
            ticketCost = GeneralSeats * cbNumberOfSeats.Text.ToString
        ElseIf rbNoseBleedSeats.Checked Then
            ticketCost = NoseBleedSeats * cbNumberOfSeats.Text.ToString
        End If
        Return MsgBox("Total ticket cost is: " + ticketCost, MsgBoxStyle.OkCancel, "Ticket Cost")
    End Function
    Function calculateExtraCosts() As Integer
        If chkPizza.Checked Then
            extras = extras + Pizza
        End If
        If chkHotDog.Checked Then
            extras = extras + HotDog
        End If
        If chkCoke.Checked Then
            extras = extras + Coke
        End If
        If chkShirt.Checked Then
            extras = extras + TShirt
        End If
        If chkHat.Checked Then
            extras = extras + Hat
        End If
        If chkProgram.Checked Then
            extras = extras + Program
        End If
        If chkOvernight.Checked Then
            extras = extras + FirstNightStay
        End If
        If rbTwoNight.Checked Then
            extras = extras + FirstNightStay + EachAdditionalNight
        End If
        If rbThreeNights.Checked Then
            extras = extras + FirstNightStay + EachAdditionalNight * 2
        End If
        If rbThreeNights.Checked Then
            extras = extras + FirstNightStay + EachAdditionalNight * 3
        End If
        Return MsgBox("Extra costs are: " + extras, MsgBoxStyle.OkCancel, "Extra Cost")
    End Function
    Function calculateTotalCost() As Decimal
        totalCost = ticketCost + extras
        Return MsgBox("Total Cost is: " + totalCost.ToString, MsgBoxStyle.OkCancel, "Total Costs")
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        calculateTicketCost()
        calculateExtraCosts()
        calculateTotalCost()
    End Sub

    Private Sub chkOvernight_CheckedChanged(sender As Object, e As EventArgs) Handles chkOvernight.CheckedChanged
        additionalNightStay()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbNumberOfSeats.SelectedIndex = 0
    End Sub
End Class
