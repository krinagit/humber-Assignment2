using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01331772_BonusAssignment
{
    public partial class Coordinate : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                Page.Validate();


                if (Page.IsValid)
                {

                    int Value_of_x = Convert.ToInt32(aspx_Value_of_x.Text);
                    int Value_of_y = Convert.ToInt32(aspx_Value_of_y.Text);

                   // confirmbox.InnerHtml += "Value of x" + aspx_Value_of_x + "value of y" + aspx_Value_of_y + "<br>";


                    //Given input of two integers, create a server click function which prints a message to a blank div
                    //element of which quadrant the coordinate would fall.Validate your inputs to assume that x and y
                    //are non-zero (for the sake of simplicity)

                    //print falls in quadrant

                    if (Value_of_x > 0 && Value_of_y > 0)
                    {
                        confirmbox.InnerHtml += "("+Value_of_x +","+Value_of_y +")"+ "falls in quadrant 1";
                    }
                    else if (Value_of_x < 0 && Value_of_y > 0)
                    {
                        confirmbox.InnerHtml += "(" + Value_of_x + "," + Value_of_y + ")" + "falls in quadrant 2";
                    }
                    else if (Value_of_x < 0 && Value_of_y < 0)
                    {
                        confirmbox.InnerHtml += "(" + Value_of_x + "," + Value_of_y + ")" + "falls in quadrant 3";

                    }
                    else if (Value_of_x > 0 && Value_of_y < 0)
                    {
                        confirmbox.InnerHtml += "(" + Value_of_x + "," + Value_of_y + ")" + "falls in quadrant 4";

                    }

                    else
                    {
                        confirmbox.InnerHtml +=   "non of the quadrants";
                    }

                }
            }
        }
    }
}