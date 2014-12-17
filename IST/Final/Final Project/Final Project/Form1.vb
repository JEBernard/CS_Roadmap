Public Class frmLogin
    'Log in Information 
    Dim strUsernames() As String = {"Bernard", "Administrator"}
    Dim strPasswords() As String = {"IST", "admin"}
    'Arrays are used to hold the approved usernames and their assigned passwords

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUserName.Text = strUsernames(0) And TextBox2.Text = strPasswords(0) Then
            frmMain.Show()
        ElseIf txtUserName.Text = strUsernames(1) And TextBox2.Text = strPasswords(1) Then
            frmMain.Show()
        Else : MsgBox("Username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

  
End Class
