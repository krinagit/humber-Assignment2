using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01331772_BonusAssignment
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    int Num_of_tickets = Convert.ToInt32(num_of_tickets.Text);
                    //-Ticket purchases under 50 (including 50) are bundled individually - 
                    //-Ticket purchases between 51 (including 51)  and 150 (including 150) are bundled in sets of 2 
                    //- Ticket amounts between 151 (including 151) and 300 (including 300) are bundled in sets of 3 
                    //- Ticket amounts over 301 (including 301) are bundled in sets of 5 

                    confirmbox.InnerHtml = "";
                    if (Num_of_tickets <= 50)
                    {
                        double sum = 0;

                        for (int i = 0; i < Num_of_tickets; i++)
                        {
                            confirmbox.InnerHtml += "You've received a bundle of 1! That's " + (i + 1) + "ticket(s)! <br>";
                            sum = sum + 0.25;
                        }

                        confirmbox.InnerHtml += "Your total ticket(s) is " + Num_of_tickets + " and your cost is " +sum +" cad.<br>";
                    }
                    else if (Num_of_tickets > 50 && Num_of_tickets <= 150)
                    {

                        for (int i = 0; i < Num_of_tickets; i=i+2)
                        {
                            confirmbox.InnerHtml += "You've received a bundle of 2! That's " + (i + 1) + "ticket(s)! <br>";
                        }
                    }
                    else if (Num_of_tickets > 150 && Num_of_tickets <= 300)
                    {

                        for (int i = 0; i < Num_of_tickets; i=i+3)
                        {
                            confirmbox.InnerHtml += "You've received a bundle of 3! That's " + (i + 1) + "ticket(s)! <br>";
                        }
                    }
                    else if ( Num_of_tickets >= 301)
                    {

                        for (int i = 0; i < Num_of_tickets; i=i+5)
                        {
                            confirmbox.InnerHtml += "You've received a bundle of 5! That's " + (i + 1) + "ticket(s)! <br>";
                        }
                    }
                }
            }
        }
    }
}