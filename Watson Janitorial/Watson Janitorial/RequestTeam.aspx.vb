Imports System.IO
Partial Class RequestTeam
    Inherits System.Web.UI.Page
    Dim intcounter As Integer
    Public dates() As Date
    Dim dcost() As Double = {0.08, 0.06, 0.04, 0.02, 0.01, 0.08}
    Dim vwdmcost() As Double = {0.09, 0.07, 0.05, 0.03, 0.01, 0.09}
    Dim wccost() As Double = {0.45, 0.3, 0.15, 0.1, 0.01, 0.45}
    Dim psscost() As Double = {0.14, 0.11, 0.09, 0.07, 0.04, 0.14}
    Dim lrcost() As Double = {0.08, 0.06, 0.04, 0.02, 0.01, 0.08}
    Dim lmcost() As Double = {0.08, 0.06, 0.04, 0.02, 0.01, 0.08}
    Dim lbrcost() As Double = {0.12, 0.09, 0.07, 0.05, 0.02, 0.12}
    Dim htcost() As Double = {5.0, 3.5, 2.0, 1.5, 0.25, 5.0}
    Dim srcost As Double = 50.0
    Dim strlabel() As String = {"", " Every Week", " Every Two Weeks", " Every Month", " Every Year", ""}
    Dim intcounter1 As Integer
    Dim intwritecounter As Integer

    Dim dblinside As Double
    Dim intwindows As Integer
    Dim dbllawn As Double
    Dim dblconcrete As Double
    Dim inthedges As Integer
    Dim intrepair As Integer
    Dim dectotalcost As Decimal
    Dim blnverify As Boolean
    Dim drequest As Boolean
    Dim vwdmrequest As Boolean
    Dim wcrequest As Boolean
    Dim pssrequest As Boolean
    Dim lrrequest As Boolean
    Dim lmrequest As Boolean
    Dim lbrrequest As Boolean
    Dim htrequest As Boolean
    Dim srrequest As Boolean
    Protected Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        If RadioButtonList1.SelectedValue = Nothing Then
            lblerror1.Visible = True
        Else
            lblerror1.Visible = False
            RadioButtonList1.Visible = False
            If RadioButtonList1.SelectedIndex = 5 Then
                lblselectdates.Visible = True
                btnadd.Visible = True
                lstdates.Visible = True
            End If
            btncontinue.Visible = True
            calavailabledates.Visible = True
            lblselectservices.Visible = True
            chkdisinfect.Visible = True
            chkfvwdm.Visible = True
            chkwindows.Visible = True
            chkpss.Visible = True
            chklr.Visible = True
            chklbr.Visible = True
            chklm.Visible = True
            chkht.Visible = True
            chkrepair.Visible = True
        End If
    End Sub
    Public Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim sdate As Date
        If calavailabledates.SelectedDate <= calavailabledates.TodaysDate Then
            lblerror.Visible = True
        Else
            sdate = calavailabledates.SelectedDate
            lblerror.Visible = False
            If RadioButtonList1.SelectedIndex = 5 Then
                lstdates.Items.Add(sdate.ToShortDateString)
                ReDim Preserve dates(intcounter)
                dates(intcounter) = sdate
                intcounter += 1
            End If
        End If
    End Sub
    Protected Sub btncontinue_Click(sender As Object, e As EventArgs) Handles btncontinue.Click
        If calavailabledates.SelectedDate <= calavailabledates.TodaysDate Then
            lblerror.Visible = True
        Else

            If chkdisinfect.Checked = False And chkfvwdm.Checked = False And chkwindows.Checked = False And chkpss.Checked = False And chklr.Checked = False And
                chklm.Checked = False And chklbr.Checked = False And chkht.Checked = False And chkrepair.Checked = False Then
                lblerror2.Visible = True
            Else
                If chkdisinfect.Checked Or chkfvwdm.Checked Then
                    lblinside.Visible = True
                    txtinside.Visible = True
                End If
                If chkwindows.Checked Then
                    lblwindows.Visible = True
                    txtwindows.Visible = True
                End If
                If chklr.Checked Or chklm.Checked Or chklbr.Checked Then
                    lbllawn.Visible = True
                    txtlawn.Visible = True
                End If
                If chklr.Checked Or chkpss.Checked Or chklbr.Checked Then
                    lblconcrete.Visible = True
                    txtconcrete.Visible = True
                End If
                If chkht.Checked Then
                    lblhedges.Visible = True
                    txthedges.Visible = True
                End If
                If chkrepair.Checked Then
                    lblrepair.Visible = True
                    txtrepair.Visible = True
                End If
                lblerror2.Visible = False
                lblerror.Visible = False
                btncalculate.Visible = True
            End If
        End If
    End Sub
    Protected Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        intcounter1 = RadioButtonList1.SelectedIndex

        If txtinside.Visible = True Then
            If IsNumeric(txtinside.Text) Then
                lblierror.Visible = False
                dblinside = Convert.ToInt32(txtinside.Text)
                If dblinside < 0 Then
                    lblierror.Visible = True
                    blnverify = False
                Else
                    lblierror.Visible = False
                    If chkdisinfect.Checked Then
                        dectotalcost += Convert.ToDecimal(dblinside * dcost(intcounter1))
                    End If

                    If chkfvwdm.Checked Then
                        dectotalcost += Convert.ToDecimal(dblinside * vwdmcost(intcounter1))
                    End If
                    blnverify = True
                End If
            Else
                lblierror.Visible = True
                blnverify = False
            End If
        End If

        If txtwindows.Visible = True Then
            If IsNumeric(txtwindows.Text) Then
                lblwerror.Visible = False
                intwindows = txtwindows.Text
                If intwindows < 0 Then
                    lblwerror.Visible = True
                    blnverify = False
                Else
                    lblwerror.Visible = False
                    If chkwindows.Checked Then
                        dectotalcost += Convert.ToDecimal(intwindows * wccost(intcounter1))
                    End If
                    blnverify = True
                End If
            Else
                lblwerror.Visible = True
                blnverify = False
            End If
        End If

        If txtlawn.Visible = True Then
            If IsNumeric(txtlawn.Text) Then
                lbllerror.Visible = False
                dbllawn = txtlawn.Text
                If dbllawn < 0 Then
                    lbllerror.Visible = True
                    blnverify = False
                Else
                    lbllerror.Visible = False
                    If chklm.Checked Then
                        dectotalcost += Convert.ToDecimal(dbllawn * lmcost(intcounter1))
                    End If

                    If chklr.Checked Then
                        dectotalcost += Convert.ToDecimal(dbllawn * lrcost(intcounter1))
                    End If

                    If chklbr.Checked Then
                        dectotalcost += Convert.ToDecimal(dbllawn * lbrcost(intcounter1))
                    End If
                    blnverify = True
                End If
            Else
                lbllerror.Visible = True
                blnverify = False
            End If
        End If

        If txtconcrete.Visible = True Then
            If IsNumeric(txtconcrete.Text) Then
                lblcerror.Visible = False
                dblconcrete = txtconcrete.Text
                If dblconcrete < 0 Then
                    lblcerror.Visible = True
                    blnverify = False
                Else
                    lblcerror.Visible = False
                    If chkpss.Checked Then
                        dectotalcost += Convert.ToDecimal(dblconcrete * psscost(intcounter1))
                    End If

                    If chklbr.Checked Then
                        dectotalcost += Convert.ToDecimal(dblconcrete * lbrcost(intcounter1))
                    End If
                    blnverify = True
                End If
            Else
                lblcerror.Visible = True
                blnverify = False
            End If
        End If

        If txthedges.Visible = True Then
            If IsNumeric(txthedges.Text) Then
                lblherror.Visible = False
                inthedges = txthedges.Text
                If inthedges < 0 Then
                    lblherror.Visible = True
                    blnverify = False
                Else
                    lblherror.Visible = False
                    If chkht.Checked Then
                        dectotalcost += Convert.ToDecimal(inthedges * htcost(intcounter1))
                    End If
                    blnverify = True
                End If
            Else
                lblherror.Visible = True
                blnverify = False
            End If
        End If

        If txtrepair.Visible = True Then
            If IsNumeric(txtrepair.Text) Then
                lblrerror.Visible = False
                intrepair = txtrepair.Text
                If intrepair < 0 Then
                    lblrerror.Visible = True
                    blnverify = False
                Else
                    lblrerror.Visible = False
                    If chkrepair.Checked Then
                        dectotalcost += Convert.ToDecimal(intrepair * srcost)
                    End If
                    blnverify = True
                End If
            Else
                lblrerror.Visible = True
                blnverify = False
            End If
        End If
        If blnverify = True Then
            If RadioButtonList1.SelectedIndex = 5 Then
                dectotalcost *= Convert.ToDecimal(lstdates.Items.Count)
            End If
            dectotalcost += Convert.ToDecimal(dectotalcost * 0.06)
            lbltotalcost.Text = "Total Cost (Taxes Included): "
            lbltotalcost1.Text = dectotalcost.ToString("C2")
            lbllabel.Text = strlabel(intcounter1)
            lbltotalcost.Visible = True
            lbltotalcost1.Visible = True
            lbllabel.Visible = True
            btnsend.Visible = True
        End If
    End Sub

    Public Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        Dim LastName As String
        Dim FirstName As String
        Dim StreetAddress As String
        Dim Borough As String
        Dim ZipCode As String
        Dim PhoneNumber As String
        Dim Email As String
        ' Enders are for data validation
        Dim intender As Integer
        Dim intender1 As Integer
        Dim strCancelClicked As String = ""
        Dim SWriter As IO.StreamWriter
        Dim strdates(lstdates.Items.Count - 1) As Date
        Do Until intender = 1 Or intender1 = 1
            LastName = InputBox("Please insert your last name", "Last Name")
            If LastName = strCancelClicked Then
                Dim strMsgResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel")
                If strMsgResult = MsgBoxResult.Yes Then
                    intender1 = 1
                Else
                    intender1 = 0
                End If
            Else
                If IsNumeric(LastName) Then
                    MsgBox("Last Name cannot be a number", , "Error")
                    intender = 0
                Else
                    intender = 1
                End If
            End If
        Loop

        If intender = 1 And intender1 = 0 Then
            intender = 0
            Do Until intender = 1 Or intender1 = 1
                FirstName = InputBox("Please insert your first name", "First Name")
                If FirstName = strCancelClicked Then
                    Dim strMsgResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel")
                    If strMsgResult = MsgBoxResult.Yes Then
                        intender1 = 1
                    Else
                        intender1 = 0
                    End If
                Else
                    If IsNumeric(FirstName) Then
                        MsgBox("First Name cannot be a number", , "Error")
                        intender = 0
                    Else
                        intender = 1
                    End If
                End If
            Loop
        End If

        If intender = 1 And intender1 = 0 Then
            intender = 0
            Do Until intender = 1 Or intender1 = 1
                StreetAddress = InputBox("Please enter your Street Address", "Street Address", "123 Main Street")
                If StreetAddress = strCancelClicked Then
                    Dim strMsgResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel")
                    If strMsgResult = MsgBoxResult.Yes Then
                        intender1 = 1
                    Else
                        intender1 = 0
                    End If
                Else
                    If IsNumeric(StreetAddress) Then
                        MsgBox("Street Address cannot be all numbers", , "Error")
                        intender = 0
                    Else
                        intender = 1
                    End If
                End If
            Loop
        End If

        If intender = 1 And intender1 = 0 Then
            intender = 0
            Do Until intender = 1 Or intender1 = 1
                Borough = InputBox("Please enter the borough of New York City your property is in", "Borough", "Manhattan")
                If Borough = strCancelClicked Then
                    Dim strMsgResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel")
                    If strMsgResult = MsgBoxResult.Yes Then
                        intender1 = 1
                    Else
                        intender1 = 0
                    End If
                Else
                    If IsNumeric(Borough) Then
                        MsgBox("Borough cannot be a number", , "Error")
                        intender = 0
                    Else
                        intender = 1
                    End If
                End If
            Loop
        End If

        If intender = 1 And intender1 = 0 Then
            intender = 0
            Do Until intender = 1 Or intender1 = 1
                ZipCode = InputBox("Please enter the zip code of your property", "Zip Code", "10001")
                If ZipCode = strCancelClicked Then
                    Dim strMsgResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel")
                    If strMsgResult = MsgBoxResult.Yes Then
                        intender1 = 1
                    Else
                        intender1 = 0
                    End If
                Else
                    If IsNumeric(ZipCode) = False Then
                        MsgBox("Zip Code must be a number", , "Error")
                        intender = 0
                    Else
                        intender = 1
                    End If
                End If
            Loop
        End If

        If intender = 1 And intender1 = 0 Then
            intender = 0
            Do Until intender = 1 Or intender1 = 1
                PhoneNumber = InputBox("Please enter a phone number where we can reach you. Type in 'N/A' if you have no phone number.", "Phone Number", "555-555-5555")
                If PhoneNumber = strCancelClicked Then
                    Dim strMsgResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel")
                    If strMsgResult = MsgBoxResult.Yes Then
                        intender1 = 1
                    Else
                        intender1 = 0
                    End If
                Else
                    If IsNumeric(PhoneNumber) Then
                        MsgBox("Phone Number must contain dashes", , "Error")
                        intender = 0
                    Else
                        intender = 1
                    End If
                End If
            Loop
        End If

        If intender = 1 And intender1 = 0 Then
            intender = 0
            Do Until intender = 1 Or intender1 = 1
                Email = InputBox("Please enter an email where we can reach you. Type in 'N/A' if you have no email.", "Email", "myname@gmail.com")
                If Email = strCancelClicked Then
                    Dim strMsgResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Cancel")
                    If strMsgResult = MsgBoxResult.Yes Then
                        intender1 = 1
                    Else
                        intender1 = 0
                    End If
                Else
                    If IsNumeric(Email) Then
                        MsgBox("Email cannot be all numbers", , "Error")
                        intender = 0
                    Else
                        intender = 1
                    End If
                End If
            Loop
        End If

        If intender = 1 And intender1 = 0 Then
            If chkdisinfect.Checked Then
                drequest = True
                dblinside = txtinside.Text
            Else
                drequest = False
            End If
            If chkfvwdm.Checked Then
                vwdmrequest = True
                dblinside = txtinside.Text
            Else
                vwdmrequest = False
            End If
            If chkwindows.Checked Then
                wcrequest = True
                intwindows = txtwindows.Text
            Else
                wcrequest = False
            End If
            If chkpss.Checked Then
                pssrequest = True
                dblconcrete = txtconcrete.Text
            Else
                pssrequest = False
            End If
            If chklr.Checked Then
                lrrequest = True
                dbllawn = txtlawn.Text
            Else
                lrrequest = False
            End If
            If chklm.Checked Then
                lmrequest = True
                dbllawn = txtlawn.Text
            Else
                lmrequest = False
            End If
            If chklbr.Checked Then
                lbrrequest = True
                dbllawn = txtlawn.Text
            Else
                lbrrequest = False
            End If
            If chkht.Checked Then
                htrequest = True
                inthedges = txthedges.Text
            Else
                htrequest = False
            End If
            If chkrepair.Checked Then
                srrequest = True
                intrepair = txtrepair.Text
            Else
                srrequest = False
            End If
            dectotalcost = lbltotalcost1.Text
            SWriter = New IO.StreamWriter("D:\Level 3 (Senior) Year\Senior Project\Requests.txt", False)
            If lstdates.Visible = False Then
                ' Writes the data entered by the user to a text file
                SWriter.WriteLine("" & "," & LastName & "," & FirstName & "," & StreetAddress & "," & Borough & "," & ZipCode & "," & PhoneNumber & "," &
                                  Email & "," & calavailabledates.SelectedDate.ToShortDateString & "," & drequest & "," & vwdmrequest & "," & wcrequest & "," &
                                                  pssrequest & "," & lrrequest & "," & lmrequest & "," & lbrrequest & "," & htrequest & "," & srrequest & "," & dblinside.ToString & "," &
                                                  (dbllawn + dblconcrete) & "," & intwindows & "," & inthedges & "," & intrepair & "," & dectotalcost.ToString("C2"))
                SWriter.Close()
            Else
                intwritecounter = 0
                Do
                    SWriter.WriteLine("" & "," & LastName & "," & FirstName & "," & StreetAddress & "," & Borough & "," & ZipCode & "," & PhoneNumber & "," &
                                      Email & "," & (lstdates.Items.Item(intwritecounter)).ToString & "," & drequest & "," & vwdmrequest & "," & wcrequest & "," &
                                                  pssrequest & "," & lrrequest & "," & lmrequest & "," & lbrrequest & "," & htrequest & "," & srrequest & "," & dblinside.ToString & "," &
                                                  (dbllawn + dblconcrete) & "," & intwindows & "," & inthedges & "," & intrepair & "," & dectotalcost.ToString("C2"))
                    intwritecounter += 1
                Loop Until intwritecounter > lstdates.Items.Count - 1
                SWriter.Close()
            End If
        End If
    End Sub
End Class