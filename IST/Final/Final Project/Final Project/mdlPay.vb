Module mdlPay
    'Payment information module

    Const payRate As Double = 22.75
    Public dbltax As Double = 0.07
    Public dblNetPay As Double = 0
    Public strGrossPay As String
    'Function to determine the Gross, Net and Tax information
    Function getPay(ByVal myPay As Double)
        myPay *= payRate
        frmPayReport.txtGrossPay.Text = myPay.ToString("C")
        dbltax = dbltax * myPay
        frmPayReport.txtTax.Text = dbltax.ToString("C")
        dblNetPay = myPay - dbltax
        frmPayReport.txtNetPay.Text = dblNetPay.ToString("C")
        Try
            Dim filePath As String
            filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Time Sheet Log.txt")
            My.Computer.FileSystem.WriteAllText(filePath, "Your time has been logged", False)
        Catch ex As Exception
            MsgBox("File Could not be saved")
        End Try

        Return myPay
    End Function
End Module
