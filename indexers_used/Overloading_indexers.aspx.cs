using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace indexers_used
{
    public partial class Overloading_indexers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Before Update");
            Response.Write("<br /><br />");
            
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br />");
            Response.Write("Total Female Employees = " + company["Female"]);
            Response.Write("<br />");


            
            Response.Write("<br /><br />");

            company["Male"] = "Female";
            Response.Write("After Update");
            Response.Write("<br />");
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br />");
            Response.Write("Total Female Employees = " + company["Female"]);
            Response.Write("<br />");
        }
    }
}