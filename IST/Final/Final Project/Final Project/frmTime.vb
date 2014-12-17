Public Class frmTime
    
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim dblMondayHours As Double = txtMonday.Text
        Dim dblTuesdayHours As Double = txtTuesday.Text
        Dim dblWednesdayHours As Double = txtWednesday.Text
        Dim dblThursdayHours As Double = txtThursday.Text
        Dim dblFridayHours As Double = txtFriday.Text
        Dim dblSaturdayHours As Double = txtSaturday.Text
        Dim dblSundayHours As Double = txtSunday.Text
        Dim dblTotalHours As Double = dblMondayHours + dblTuesdayHours + dblWednesdayHours + dblThursdayHours + dblFridayHours + dblSaturdayHours + dblSundayHours
        Try
            txtTotalHours.Text = dblTotalHours
        Catch ex As Exception
            MsgBox("Please enter number of hours for each day")
        End Try
        getPay(dblTotalHours)
        
        MsgBox("Time successfully submitted. Check Reporting for payment information")
    End Sub

    Public Sub frmTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMonday.Text = 0
        txtTuesday.Text = 0
        txtWednesday.Text = 0
        txtThursday.Text = 0
        txtFriday.Text = 0
        txtSaturday.Text = 0
        txtSunday.Text = 0


    End Sub
End Class