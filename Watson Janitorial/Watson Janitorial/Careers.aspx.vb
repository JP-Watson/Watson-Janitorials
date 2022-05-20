Partial Class Careers
    Inherits System.Web.UI.Page

    Protected Sub btnd_Click(sender As Object, e As EventArgs) Handles btnd.Click
        lstd.Items.Clear()
        lstd.Items.Add("Job Title: Disinfector")
        lstd.Items.Add("Salary: $10.00 per Hour")
        lstd.Items.Add("Job Requirements:")
        lstd.Items.Add("    1. Must be at least 16 years old")
        lstd.Items.Add("    2. Must have a valid form of ID")
        lstd.Items.Add("    3. Must be able to stand for long periods")
        lstd.Items.Add("       of time")
        lstd.Items.Add("    4. Must have no criminal record")
        lstd.Items.Add("")
        lstd.Items.Add("Description: Disinfectors will sanitize all")
        lstd.Items.Add("surfaces in the area with an electrostatic")
        lstd.Items.Add("sprayer and, additionally, use clorox")
        lstd.Items.Add("wipes to sanitize all high touch points")
        lstd.Items.Add("including light switches, doorknobs,")
        lstd.Items.Add("handles, and rails")
        lstd.Items.Add("")
        lstd.Items.Add("This job entails the use of the following")
        lstd.Items.Add("types of equipment: ")
        lstd.Items.Add("    1. Electrostacic Sprayer")
        lstd.Items.Add("    2. Clorox Wipes")
        lstd.Visible = True
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlmht.Visible = False
        lstmt.Visible = False
        lsttd.Visible = False
    End Sub
    Protected Sub btnjanitor_Click(sender As Object, e As EventArgs) Handles btnjanitor.Click
        lstj.Items.Clear()
        lstj.Items.Add("Job Title: Janitor")
        lstj.Items.Add("Salary: $15.00 per Hour")
        lstj.Items.Add("Job Requirements:")
        lstj.Items.Add("    1. Must be at least 18 years old")
        lstj.Items.Add("    2. Must have a valid form of ID")
        lstj.Items.Add("    3. Must be able to stand for long periods")
        lstj.Items.Add("       of time")
        lstj.Items.Add("    4. Must have no criminal record")
        lstj.Items.Add("")
        lstj.Items.Add("Description: Janitors will clean the")
        lstj.Items.Add("floors and tables in the public areas")
        lstj.Items.Add("along with any restrooms in the area.")
        lstj.Items.Add("The equipment used varies depending on")
        lstj.Items.Add("if the floors are carpeted.")
        lstj.Items.Add("")
        lstj.Items.Add("This job entails the use of the following")
        lstj.Items.Add("types of equipment: ")
        lstj.Items.Add("    1. Mop")
        lstj.Items.Add("    2. Vacuum")
        lstj.Items.Add("    3. Toilet Brush")
        lstd.Visible = False
        lstj.Visible = True
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlmht.Visible = False
        lstmt.Visible = False
        lsttd.Visible = False
    End Sub
    Protected Sub btnww_Click(sender As Object, e As EventArgs) Handles btnww.Click
        lstww.Items.Clear()
        lstww.Items.Add("Job Title: Window Washer")
        lstww.Items.Add("Salary: $17.50 per Hour")
        lstww.Items.Add("Job Requirements:")
        lstww.Items.Add("    1. Must be at least 21 years old")
        lstww.Items.Add("    2. Must have a valid form of ID")
        lstww.Items.Add("    3. Must be able to stand for long periods")
        lstww.Items.Add("       of time")
        lstww.Items.Add("    4. Must have no criminal record")
        lstww.Items.Add("    5. Must have a high tolerance for extreme")
        lstww.Items.Add("       heights")
        lstww.Items.Add("")
        lstww.Items.Add("Description: Window washers clean the")
        lstww.Items.Add("windows outside the structure with a")
        lstww.Items.Add("Docapole window washing kit and a")
        lstww.Items.Add("ladder or high-rise window cleaning")
        lstww.Items.Add("platform depending on how high up")
        lstww.Items.Add("the window is. Additionally, window")
        lstww.Items.Add("washers will use windex to clean the")
        lstww.Items.Add("windows and other glass surfaces")
        lstww.Items.Add("inside the structure.")
        lstww.Items.Add("")
        lstww.Items.Add("This job entails the use of the following")
        lstww.Items.Add("types of equipment: ")
        lstww.Items.Add("    1. High-rise window cleaning platform")
        lstww.Items.Add("    2. Ladder")
        lstww.Items.Add("    3. Docapole window washing kit")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = True
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlmht.Visible = False
        lstmt.Visible = False
        lsttd.Visible = False
    End Sub
    Protected Sub btnss_Click(sender As Object, e As EventArgs) Handles btnss.Click
        lstss.Items.Clear()
        lstss.Items.Add("Job Title: Sweeper / Shoveler")
        lstss.Items.Add("Salary: $13.50 per Hour")
        lstss.Items.Add("Job Requirements:")
        lstss.Items.Add("    1. Must be at least 16 years old")
        lstss.Items.Add("    2. Must have a valid form of ID")
        lstss.Items.Add("    3. Must be able to stand for long periods")
        lstss.Items.Add("       of time")
        lstss.Items.Add("    4. Must have no criminal record")
        lstss.Items.Add("")
        lstss.Items.Add("Description: Sweepers / Shovelers sweep")
        lstss.Items.Add("the dirt and leaves or shovel the snow")
        lstss.Items.Add("off of the walkways outside the")
        lstss.Items.Add("structure being cleaned. If the client")
        lstss.Items.Add("wishes, salt can be put on the walkways")
        lstss.Items.Add("to melt any ice.")
        lstss.Items.Add("")
        lstss.Items.Add("This job entails the use of the following")
        lstss.Items.Add("types of equipment")
        lstss.Items.Add("    1. Snow Shovel")
        lstss.Items.Add("    2. Broom")
        lstss.Items.Add("    3. Salt")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = True
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlmht.Visible = False
        lstmt.Visible = False
        lsttd.Visible = False
    End Sub
    Protected Sub btnlr_Click(sender As Object, e As EventArgs) Handles btnlr.Click
        lstlr.Items.Clear()
        lstlr.Items.Add("Job Title: Litter Remover")
        lstlr.Items.Add("Salary: $13.50 per Hour")
        lstlr.Items.Add("Job Requirements:")
        lstlr.Items.Add("    1. Must be at least 16 years old")
        lstlr.Items.Add("    2. Must have a valid form of ID")
        lstlr.Items.Add("    3. Must be able to stand for long periods")
        lstlr.Items.Add("       of time")
        lstlr.Items.Add("    4. Must have no criminal record")
        lstlr.Items.Add("")
        lstlr.Items.Add("Description: Litter Removers will use")
        lstlr.Items.Add("a trash pickup stick to pick up any")
        lstlr.Items.Add("litter left on the ground outside the")
        lstlr.Items.Add("structure being cleaned and then put")
        lstlr.Items.Add("the litter in a trash bag.")
        lstlr.Items.Add("")
        lstlr.Items.Add("This job entails the use of the following")
        lstlr.Items.Add("types of equipment: ")
        lstlr.Items.Add("    1. Trash Pickup Stick")
        lstlr.Items.Add("    2. Trash Bags")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = True
        lstlbr.Visible = False
        lstlmht.Visible = False
        lstmt.Visible = False
        lsttd.Visible = False
    End Sub
    Protected Sub btnlbr_Click(sender As Object, e As EventArgs) Handles btnlbr.Click
        lstlbr.Items.Clear()
        lstlbr.Items.Add("Job Title: Leaf Blower / Raker")
        lstlbr.Items.Add("Salary: $15.00 per Hour")
        lstlbr.Items.Add("Job Requirements:")
        lstlbr.Items.Add("    1. Must be at least 18 years old")
        lstlbr.Items.Add("    2. Must have a valid form of ID")
        lstlbr.Items.Add("    3. Must be able to stand for long periods")
        lstlbr.Items.Add("       of time")
        lstlbr.Items.Add("    4. Must have no criminal record")
        lstlbr.Items.Add("")
        lstlbr.Items.Add("Description: Leaf Blowers / Rakers use")
        lstlbr.Items.Add("a leaf blower and rake to clear all")
        lstlbr.Items.Add("the leaves off of the lawn of the")
        lstlbr.Items.Add("structure being cleaned and, if the")
        lstlbr.Items.Add("client wishes, either raked into a")
        lstlbr.Items.Add("pile or put in trash bags and removed.")
        lstlbr.Items.Add("")
        lstlbr.Items.Add("This job entails the use of the following")
        lstlbr.Items.Add("types of equipment: ")
        lstlbr.Items.Add("    1. Leaf Blower")
        lstlbr.Items.Add("    2. Rake")
        lstlbr.Items.Add("    3. Trash Bags")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = True
        lstlmht.Visible = False
        lstmt.Visible = False
        lsttd.Visible = False
    End Sub
    Protected Sub btnlmht_Click(sender As Object, e As EventArgs) Handles btnlmht.Click
        lstlmht.Items.Clear()
        lstlmht.Items.Add("Job Title: Lawn Mower / Hedge Trimmer")
        lstlmht.Items.Add("Salary: $16.00 per Hour")
        lstlmht.Items.Add("Job Requirements:")
        lstlmht.Items.Add("    1. Must be at least 18 years old")
        lstlmht.Items.Add("    2. Must have a valid form of ID")
        lstlmht.Items.Add("    3. Must be able to stand for long periods")
        lstlmht.Items.Add("       of time")
        lstlmht.Items.Add("    4. Must have no criminal record")
        lstlmht.Items.Add("")
        lstlmht.Items.Add("Description: Lawn Mowers / Hedge")
        lstlmht.Items.Add("Trimmers use a lawn mower or lawn")
        lstlmht.Items.Add("tractor, depending on the size of")
        lstlmht.Items.Add("the client's lawn, to mow the lawn")
        lstlmht.Items.Add("of the structure being cleaned. Hedge")
        lstlmht.Items.Add("trimmers are also used to cut the dead")
        lstlmht.Items.Add("parts off of any hedges the client owns.")
        lstlmht.Items.Add("")
        lstlmht.Items.Add("This job entails the use of the following")
        lstlmht.Items.Add("types of equipment: ")
        lstlmht.Items.Add("    1. Lawn Mower")
        lstlmht.Items.Add("    2. Lawn Tractor")
        lstlmht.Items.Add("    3. Hedge Trimmers")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlmht.Visible = True
        lstmt.Visible = False
        lsttd.Visible = False
    End Sub
    Protected Sub btnmt_Click(sender As Object, e As EventArgs) Handles btnmt.Click
        lstmt.Items.Clear()
        lstmt.Items.Add("Job Title: Maintenance Technician")
        lstmt.Items.Add("Salary: $30.00 per Hour")
        lstmt.Items.Add("Job Requirements:")
        lstmt.Items.Add("    1. Must be at least 21 years old")
        lstmt.Items.Add("    2. Must have a valid form of ID")
        lstmt.Items.Add("    3. Must be able to stand for long periods")
        lstmt.Items.Add("       of time")
        lstmt.Items.Add("    4. Must have no criminal record")
        lstmt.Items.Add("    5. Must have a bachelor's degree or")
        lstmt.Items.Add("       higher degree of education")
        lstmt.Items.Add("    6. Must have an industrial")
        lstmt.Items.Add("       maintenance degree.")
        lstmt.Items.Add("")
        lstmt.Items.Add("Description: Maintenance Technicians")
        lstmt.Items.Add("use a variety of different types of")
        lstmt.Items.Add("equipment to repair any broken or faulty")
        lstmt.Items.Add("items or machines owned by the client.")
        lstmt.Items.Add("")
        lstmt.Items.Add("The equipment used in this job varies")
        lstmt.Items.Add("depending on the item in need of repair")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlmht.Visible = False
        lstmt.Visible = True
        lsttd.Visible = False
    End Sub
    Protected Sub btntd_Click(sender As Object, e As EventArgs) Handles btntd.Click
        lsttd.Items.Clear()
        lsttd.Items.Add("Job Title: Truck Driver")
        lsttd.Items.Add("Salary: $40.00 per Day")
        lsttd.Items.Add("Job Requirements:")
        lsttd.Items.Add("    1. Must be at least 21 years old")
        lsttd.Items.Add("    2. Must have a valid form of ID")
        lsttd.Items.Add("    3. Must have a Class A Commercial")
        lsttd.Items.Add("       Driver's License (CDL)")
        lsttd.Items.Add("    4. Must have no criminal record")
        lsttd.Items.Add("    5. Must have a high school diploma or")
        lsttd.Items.Add("       higher degree of education")
        lsttd.Items.Add("")
        lsttd.Items.Add("Description: Truck Drivers are responsible")
        lsttd.Items.Add("for driving a Cutaway van to transport a")
        lsttd.Items.Add("team of workers and their equipment to")
        lsttd.Items.Add("and from the area they've been asked to")
        lsttd.Items.Add("clean.")
        lstd.Visible = False
        lstj.Visible = False
        lstww.Visible = False
        lstss.Visible = False
        lstlr.Visible = False
        lstlbr.Visible = False
        lstlmht.Visible = False
        lstmt.Visible = False
        lsttd.Visible = True
    End Sub
End Class
