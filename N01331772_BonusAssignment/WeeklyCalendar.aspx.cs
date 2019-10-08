using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01331772_BonusAssignment
{
    public partial class WeeklyCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                Page.Validate();


                if (Page.IsValid)
                {
                    string Name_of_day = aspx_Name_of_day.Text.ToString();
                    //Oct 1 is a Tuesday!Time to work...
                    //Oct 2 is a Wednesday!Time to have fun!
                    //Oct 3 is a Thursday!Time to work…
                    //Oct 4 is a Friday!Time to work…
                    //Oct 5 is a Saturday!Time to have fun!
                    //Oct 6 is a Sunday!Time to have fun!
                    //Oct 7 is a Monday!Time to have fun!
                    //Oct 8 is a Tuesday!Time to work…
                    //…
                    //Oct 30 is a Monday!Time to work!

                    // confirmbox.InnerHtml += " Your monthly schedule Summary is as follows: <br>";
                    List<string> NameOfTheDay = new List<string>(7);

                    foreach (ListItem entereday in aspx_Name_of_day.Items)
                    {
                        if (entereday.Selected)
                        {
                            NameOfTheDay.Add(entereday.Value.ToString());
                        }
                    }

                    int[] daysOfMonths = new int[31];
                    for (int i = 0; i < 31; i++)
                    {
                        daysOfMonths[i] = 0;
                    }

                    for (int i = 0; i < 31; i++)
                    {
                        foreach (String day in NameOfTheDay)
                        {
                            if (day == "Sunday")
                            {
                                if ((i + 1) % 7 == 6)
                                {
                                    daysOfMonths[i] = 1;
                                }
                            }
                            if (day == "Monday")
                            {
                                if ((i + 1) % 7 == 0)
                                {
                                    daysOfMonths[i] = 1;
                                }
                            }
                            if (day == "Tuesday")
                            {
                                if ((i + 1) % 7 == 1)
                                {
                                    daysOfMonths[i] = 1;
                                }
                            }

                            if (day == "Wednesday")
                            {
                                if ((i + 1) % 7 == 2)
                                {
                                    daysOfMonths[i] = 1;
                                }
                            }
                            if (day == "Thursday")
                            {
                                if ((i + 1) % 7 == 3)
                                {
                                    daysOfMonths[i] = 1;
                                }
                            }
                            if (day == "Friday")
                            {
                                if ((i + 1) % 7 == 4)
                                {
                                    daysOfMonths[i] = 1;
                                }
                            }
                            if (day == "Saturday")
                            {
                                if ((i + 1) % 7 == 5)
                                {
                                    daysOfMonths[i] = 1;
                                }
                            }

                        }
                    }

                    for (int i = 0; i < 31; i++)
                    {
                        confirmbox.InnerHtml += "<br>" + "Oct " + (i + 1) + " is a ";

                        if((i+1)%7==1)
                        {
                            confirmbox.InnerHtml += "Tuesday";

                        }

                        if ((i+1)%7==2)
                        {
                            confirmbox.InnerHtml += "Wednesday";

                        }

                        if ((i+1)%7==3)
                        {
                            confirmbox.InnerHtml += "Thursday";

                        }

                        if ((i+1)%7==4)
                        {
                            confirmbox.InnerHtml += "Friday";

                        }

                        if ((i+1)%7==5)
                        {
                            confirmbox.InnerHtml += "Saturday";

                        }

                        if ((i+1)%7==6)
                        {
                            confirmbox.InnerHtml += "Sunday";

                        }
                        if ((i+1)%7==0)
                        {
                            confirmbox.InnerHtml += "Monday";

                        }


                        if (daysOfMonths[i] == 1)
                        {
                            confirmbox.InnerHtml += " Time to work";
                        }
                        else
                        {
                            confirmbox.InnerHtml += " Time to have fun";
                        }
                    }

                }

            }
        }
    }
}