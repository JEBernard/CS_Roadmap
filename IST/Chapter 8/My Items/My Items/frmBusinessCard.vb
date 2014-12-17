Public Class frmBusinessCard

    Public Sub frmBusinessCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmDirectory.lstDirectory.SelectedItem.Equals("Jason Bernard") Then
            lblName.Text = frmDirectory.strEmployees(0)
            lblTitle.Text = frmDirectory.strJobTitle(0)
            lblAddress.Text = frmDirectory.strAddress(0)
            lblPhone.Text = frmDirectory.intPhone(0).ToString("(000)-000-0000")
            lblEmail.Text = frmDirectory.strEmail(0)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class