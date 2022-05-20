
Partial Class Prices
    Inherits System.Web.UI.Page

    Protected Sub btnd_Click(sender As Object, e As EventArgs) Handles btnd.Click
        lstd.Items.Clear()
        lstd.Items.Add("Service: Disinfect")
        lstd.Items.Add("Price (per square foot): $0.08 one-time,")
        lstd.Items.Add("$0.06 weekly, $0.04 bi-weekly,")
        lstd.Items.Add("$0.02 monthly, $0.01 yearly")
        lstd.Items.Add("Included in cost:")
        lstd.Items.Add("    1. Disinfecting of all surfaces")
        lstd.Items.Add("    2. Wiping down, with clorox wipes, all")
        lstd.Items.Add("       high touch points including doorknobs,")
        lstd.Items.Add("       handles, and light switches.")
        lstd.Visible = True
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlm.Visible = False
        lstht.Visible = False
        lstm.Visible = False
    End Sub
    Protected Sub btnjanitor_Click(sender As Object, e As EventArgs) Handles btnjanitor.Click
        lstj.Items.Clear()
        lstj.Items.Add("Service: Janitorial")
        lstj.Items.Add("Price (per square foot): $0.09 one-time,")
        lstj.Items.Add("$0.07 weekly, $0.05 bi-weekly,")
        lstj.Items.Add("$0.03 monthly, $0.01 yearly")
        lstj.Items.Add("Included in cost:")
        lstj.Items.Add("    1. Vaccuuming of all carpeted floors")
        lstj.Items.Add("    2. Wet mop And dry mop of all hard")
        lstj.Items.Add("       surface floors")
        lstd.Visible = False
        lstj.Visible = True
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlm.Visible = False
        lstht.Visible = False
        lstm.Visible = False
    End Sub
    Protected Sub btnww_Click(sender As Object, e As EventArgs) Handles btnww.Click
        lstww.Items.Clear()
        lstww.Items.Add("Service: Window Washing")
        lstww.Items.Add("Price (per window): $0.45 one-time,")
        lstww.Items.Add("$0.3 weekly, $0.15 bi-weekly,")
        lstww.Items.Add("$0.1 monthly, $0.01 yearly")
        lstww.Items.Add("Included in cost:")
        lstww.Items.Add("    1. Cleaning, with windex, the inside of")
        lstww.Items.Add("       all windows")
        lstww.Items.Add("    2. Cleanings the outside of all windows")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = True
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlm.Visible = False
        lstht.Visible = False
        lstm.Visible = False
    End Sub
    Protected Sub btnss_Click(sender As Object, e As EventArgs) Handles btnss.Click
        lstss.Items.Clear()
        lstss.Items.Add("Service: Sweeping / Shoveling")
        lstss.Items.Add("Price (per square foot): $0.14 one-time,")
        lstss.Items.Add("$0.11 weekly, $0.09 bi-weekly,")
        lstss.Items.Add("$0.07 monthly, $0.04 yearly")
        lstss.Items.Add("Included in cost:")
        lstss.Items.Add("    1. Sweeing dirt and leaves or shoveling")
        lstss.Items.Add("       snow off of the area requested by the")
        lstss.Items.Add("       customer")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = True
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlm.Visible = False
        lstht.Visible = False
        lstm.Visible = False
    End Sub
    Protected Sub btnlr_Click(sender As Object, e As EventArgs) Handles btnlr.Click
        lstlr.Items.Clear()
        lstlr.Items.Add("Service: Removal of Litter")
        lstlr.Items.Add("Price (per square foot): $0.08 one-time,")
        lstlr.Items.Add("$0.06 weekly, $0.04 bi-weekly,")
        lstlr.Items.Add("$0.02 monthly, $0.01 yearly")
        lstlr.Items.Add("Included in cost:")
        lstlr.Items.Add("    1. Removal of all litter from the area")
        lstlr.Items.Add("       requested by the customer")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = True
        lstlbr.Visible = False
        lstlm.Visible = False
        lstht.Visible = False
        lstm.Visible = False
    End Sub
    Protected Sub btnlbr_Click(sender As Object, e As EventArgs) Handles btnlbr.Click
        lstlbr.Items.Clear()
        lstlbr.Items.Add("Service: Leaves Blown / Raked")
        lstlbr.Items.Add("Price (per square foot): $0.12 one-time,")
        lstlbr.Items.Add("$0.09 weekly, $0.07 bi-weekly,")
        lstlbr.Items.Add("$0.05 monthly, $0.02 yearly")
        lstlbr.Items.Add("Included in cost:")
        lstlbr.Items.Add("    1. Blowing and raking all leaves off of")
        lstlbr.Items.Add("       the area requested by the customer")
        lstlbr.Items.Add("    2. Putting all the leaves into trash bags")
        lstlbr.Items.Add("       and taking them away")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = True
        lstlm.Visible = False
        lstht.Visible = False
        lstm.Visible = False
    End Sub
    Protected Sub btnlm_Click(sender As Object, e As EventArgs) Handles btnlm.Click
        lstlm.Items.Clear()
        lstlm.Items.Add("Service: Lawn Mowed")
        lstlm.Items.Add("Price (per 50 square feet): $0.08 one-time,")
        lstlm.Items.Add("$0.06 weekly, $0.04 bi-weekly,")
        lstlm.Items.Add("$0.02 monthly, $0.01 yearly")
        lstlm.Items.Add("Included in cost:")
        lstlm.Items.Add("    1. Blowing and raking all leaves off of")
        lstlm.Items.Add("       the area requested by the customer")
        lstlm.Items.Add("    2. Putting all the leaves into trash bags")
        lstlm.Items.Add("       and taking them away")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlm.Visible = True
        lstht.Visible = False
        lstm.Visible = False
    End Sub
    Protected Sub btnht_Click(sender As Object, e As EventArgs) Handles btnht.Click
        lstht.Items.Clear()
        lstht.Items.Add("Service: Hedges Trimmed")
        lstht.Items.Add("Price (per hedge): $5.00 one-time,")
        lstht.Items.Add("$3.50 weekly, $2.00 bi-weekly,")
        lstht.Items.Add("$1.50 monthly, $0.25 yearly")
        lstht.Items.Add("Included in cost:")
        lstht.Items.Add("    1. Trimming all dead leaves and branches")
        lstht.Items.Add("       off of the hedges")
        lstht.Items.Add("    2. Removal of all dead leaves and")
        lstht.Items.Add("       branches from area")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlm.Visible = False
        lstht.Visible = True
        lstm.Visible = False
    End Sub
    Protected Sub btnm_Click(sender As Object, e As EventArgs) Handles btnm.Click
        lstm.Items.Clear()
        lstm.Items.Add("Service: Maintenance & Repairs")
        lstm.Items.Add("Price (per item in need of repair): $50.00")
        lstm.Items.Add("Included in cost:")
        lstm.Items.Add("    1. Maintenance and repairs to area or")
        lstm.Items.Add("       item requested by the customer")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlm.Visible = False
        lstht.Visible = False
        lstm.Visible = True
    End Sub
End Class
