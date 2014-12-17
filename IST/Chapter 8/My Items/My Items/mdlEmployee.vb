
Module mdlEmployee
    Function getEmployee(ByVal index) As Long
        frmBusinessCard.lblName.Text = frmDirectory.nameList(index)
        frmBusinessCard.lblTitle.Text = frmDirectory.titleList(index)
        frmBusinessCard.lblAddress.Text = frmDirectory.addressList(index)
        frmBusinessCard.lblPhone.Text = frmDirectory.phoneList(index).ToString("(000) 000-0000")
        frmBusinessCard.lblEmail.Text = frmDirectory.emailList(index)
        Return index
    End Function
End Module
