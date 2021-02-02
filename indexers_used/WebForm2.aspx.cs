using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace indexers_used
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Employee Name of With id 2 : " + company[2]);
            Response.Write("<br />");
            Response.Write("Employee Name of With id 4 : " + company[4]);
            Response.Write("<br />");
            Response.Write("Employee Name of With id 6 : " + company[6]);
            Response.Write("<br />");
            Response.Write("Employee Name of With id 8 : " + company[8]);

            Response.Write("<br />");
            Response.Write("<br />");
            Response.Write("<br />");
            Response.Write("<br />");


            Response.Write("Changing  Name of Employee with id 6 & 8");
            Response.Write("<br />");
            Response.Write("<br />");
            Response.Write("<br />");

            company[6] = "Garima";
            company[8] = "Dolli";
            
            Response.Write("Employee Name of With id 6 : " + company[6]);
            Response.Write("<br />");
            Response.Write("Employee Name of With id 8 : " + company[8]);
            Response.Write("<br />");

        }
    }
}