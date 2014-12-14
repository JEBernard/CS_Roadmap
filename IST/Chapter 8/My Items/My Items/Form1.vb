Public Class frmDirectory
    Public strEmployees() As String = {"Jason E. Bernard", "Cinda G. Luebke", "Michael P. Hale", "Yvette S. Romero", "Ruby J. Brown", "Robert C. Neely", "Leonard T. Lee", "Jeffery E. Nava", "Ashley J. Buckley", "Todd S. Kale"}
    Public strJobTitle() As String = {"CEO", "CFO", "CHRO", "Account Associate", "Marketing Director", "Sales Director", "IT Supervisor", "Lead Programmer", "Graphic Designer", "Security Director"}
    Public strAddress() As String = {"4854 Goldcliff Circle, Washington, DC 20005", "1329 County Line Road, Washington, DC 20005", "2327 Park Street, Washington, DC 20005", "4653 Brookside Drive, Washington, DC 20005", "4441 Ash Avenue, Washington, DC 20005", "646 Rebecca Street, Washington, DC 20005", "4716 Barnes Street, Washington, DC 20005", "994 Peaceful Lane, Washington, DC 20005", "1364 Perry Street, Washington, DC 20005", "718 Calvin Street, Washington, DC 20005"}
    Public intPhone() As Long = {2025658486, 916329180, 9254809916, 2053732438, 3149273141, 8477677622, 4073369457, 2165093335, 8106436718, 4433722607}
    Public strEmail() As String = {"jbernard@ClearLime.com", "cluebke@ClearLime.com", "mhale@ClearLime.com", "yromero@ClearLime.com", "rbrown@ClearLime.com", "rneely@ClearLime.com", "llee@CLearLime.com", "jnava@ClearLime.com", "abuckley@ClearLime.com", "tkale@ClearLime.com"}
    Public strName As String
    Public strStreetAddress As String
    Public strTitle As String
    Public intPhoneNumber As Long
    Public strEmailAddress As String
    Public nameList As New List(Of String)(strEmployees)
    Public titleList As New List(Of String)(strJobTitle)
    Public addressList As New List(Of String)(strAddress)
    Public phoneList As New List(Of Long)(intPhone)
    Public emailList As New List(Of String)(strEmail)









    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'Load Business Card

        frmBusinessCard.Show()
        'get the selected employees information

        getEmployee(lstDirectory.SelectedIndex)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        'Add a new Employee 
        strName = InputBox("Enter the Employee Name")
        nameList.Add(strName)

        strTitle = InputBox("Enter the Employee's Job Title")
        titleList.Add(strTitle)

        strStreetAddress = InputBox("Enter the Employee's Address")
        addressList.Add(strStreetAddress)

        intPhoneNumber = InputBox("Enter the Employee's Phone Number")
        phoneList.Add(intPhoneNumber)

        strEmailAddress = InputBox("Enter the Employee's Email Address")

        emailList.Add(strEmailAddress)
        'Refresh listbox data source
        lstDirectory.DataSource = Nothing
        lstDirectory.DataSource = nameList
        MsgBox("Employee Added Successfully!")


    End Sub



    Private Sub frmDirectory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstDirectory.DataSource = nameList

    End Sub

    


    Private Sub ViewBusinessCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBusinessCardToolStripMenuItem.Click
        frmBusinessCard.Show()
        getEmployee(lstDirectory.SelectedIndex)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exit the program
        Me.Close()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub
End Class
