Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Start the clock
        Label1.Text = DateAndTime.Now.ToShortTimeString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        'Display the payment report 
        frmPayReport.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTimeSheet.Click
        'Display the Time Card  
        frmTime.Show()
        btnReport.Enabled = True
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Display the About page
        frmAbout.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        'Display the payment report from menu
        frmPayReport.Show()
    End Sub

    Private Sub CalendarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalendarToolStripMenuItem.Click
        'Display the Time Card from the menu
        frmTime.Show()
    End Sub
End Class