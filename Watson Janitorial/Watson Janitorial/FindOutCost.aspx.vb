Option Strict On
Partial Class FindOutCost
    Inherits System.Web.UI.Page
    Protected Sub btncontinue_Click(sender As Object, e As EventArgs) Handles btncontinue.Click
        If chkd.Checked = False And chkvwdm.Checked = False And chkwc.Checked = False And chkpss.Checked = False And chklr.Checked = False And chklm.Checked = False _
            And chklbr.Checked = False And chkht.Checked = False And chksr.Checked = False Then
            MsgBox("You must select the services you wish to have done on your property", , "Error")
        Else
            chkd.Visible = False
            chkvwdm.Visible = False
            chkwc.Visible = False
            chkpss.Visible = False
            chklr.Visible = False
            chklm.Visible = False
            chklbr.Visible = False
            chkht.Visible = False
            chksr.Visible = False
            RadioButtonList1.Visible = True

            If chkd.Checked Or chkvwdm.Checked Then
                lblinside.Visible = True
                txtinside.Visible = True
                btncalculate.Visible = True
            End If

            If chkwc.Checked Then
                lblwindows.Visible = True
                txtwindows.Visible = True
                btncalculate.Visible = True
            End If

            If chklm.Checked Or chklr.Checked Or chklbr.Checked Then
                lbllawn.Visible = True
                txtlawn.Visible = True
                btncalculate.Visible = True
            End If

            If chkpss.Checked Or chklbr.Checked Then
                lblconcrete.Visible = True
                txtconcrete.Visible = True
                btncalculate.Visible = True
            End If

            If chkht.Checked Then
                lblhedges.Visible = True
                txthedges.Visible = True
                btncalculate.Visible = True
            End If

            If chksr.Checked Then
                lblrepair.Visible = True
                txtrepair.Visible = True
                btncalculate.Visible = True
            End If
        End If
    End Sub
    Protected Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        If RadioButtonList1.SelectedValue = Nothing Then
            MsgBox("Please select how often you want the selected services done on your property", , "Error")
        Else
            RadioButtonList1.Visible = False
            Dim dcost() As Double = {0.08, 0.06, 0.04, 0.02, 0.01}
            Dim vwdmcost() As Double = {0.09, 0.07, 0.05, 0.03, 0.01}
            Dim wccost() As Double = {0.45, 0.3, 0.15, 0.1, 0.01}
            Dim psscost() As Double = {0.14, 0.11, 0.09, 0.07, 0.04}
            Dim lrcost() As Double = {0.08, 0.06, 0.04, 0.02, 0.01}
            Dim lmcost() As Double = {0.08, 0.06, 0.04, 0.02, 0.01}
            Dim lbrcost() As Double = {0.12, 0.09, 0.07, 0.05, 0.02}
            Dim htcost() As Double = {5.0, 3.5, 2.0, 1.5, 0.25}
            Dim srcost As Double = 50.0
            Dim intcounter As Integer

            Dim dblinside As Double
            Dim intwindows As Integer
            Dim dbllawn As Double
            Dim dblconcrete As Double
            Dim inthedges As Integer
            Dim intrepair As Integer
            Dim dectotalcost As Decimal
            Dim blnverify As Boolean

            intcounter = RadioButtonList1.SelectedIndex

            If txtinside.Visible = True Then
                If IsNumeric(txtinside.Text) Then
                    lblierror.Visible = False
                    dblinside = Convert.ToDouble(txtinside.Text)
                    If dblinside < 0 Then
                        lblierror.Visible = True
                        blnverify = False
                    Else
                        lblierror.Visible = False
                        If chkd.Checked Then
                            dectotalcost += Convert.ToDecimal(dblinside * dcost(intcounter))
                        End If

                        If chkvwdm.Checked Then
                            dectotalcost += Convert.ToDecimal(dblinside * vwdmcost(intcounter))
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
                    intwindows = Convert.ToInt32(txtwindows.Text)
                    If intwindows < 0 Then
                        lblwerror.Visible = True
                        blnverify = False
                    Else
                        lblwerror.Visible = False
                        If chkwc.Checked Then
                            dectotalcost += Convert.ToDecimal(intwindows * wccost(intcounter))
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
                    dbllawn = Convert.ToDouble(txtlawn.Text)
                    If dbllawn < 0 Then
                        lbllerror.Visible = True
                        blnverify = False
                    Else
                        lbllerror.Visible = False
                        If chklm.Checked Then
                            dectotalcost += Convert.ToDecimal(dbllawn * lmcost(intcounter))
                        End If

                        If chklr.Checked Then
                            dectotalcost += Convert.ToDecimal(dbllawn * lrcost(intcounter))
                        End If

                        If chklbr.Checked Then
                            dectotalcost += Convert.ToDecimal(dbllawn * lbrcost(intcounter))
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
                    dblconcrete = Convert.ToDouble(txtconcrete.Text)
                    If dblconcrete < 0 Then
                        lblcerror.Visible = True
                        blnverify = False
                    Else
                        lblcerror.Visible = False
                        If chkpss.Checked Then
                            dectotalcost += Convert.ToDecimal(dblconcrete * psscost(intcounter))
                        End If

                        If chklbr.Checked Then
                            dectotalcost += Convert.ToDecimal(dblconcrete * lbrcost(intcounter))
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
                    inthedges = Convert.ToInt32(txthedges.Text)
                    If inthedges < 0 Then
                        lblherror.Visible = True
                        blnverify = False
                    Else
                        lblherror.Visible = False
                        If chkht.Checked Then
                            dectotalcost += Convert.ToDecimal(inthedges * htcost(intcounter))
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
                    intrepair = Convert.ToInt32(txtrepair.Text)
                    If intrepair < 0 Then
                        lblrerror.Visible = True
                        blnverify = False
                    Else
                        lblrerror.Visible = False
                        If chksr.Checked Then
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
                dectotalcost += Convert.ToDecimal(dectotalcost * 0.06)
                lbltotalcost.Text = "Total Cost (Taxes Included): " & dectotalcost.ToString("C2")
                lbltotalcost.Visible = True
            End If
        End If
    End Sub
End Class