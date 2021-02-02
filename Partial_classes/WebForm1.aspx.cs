using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partial_classes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            c1.FirstName = "Praveen";
            c1.LastName = "Prajapati";

            string print = c1.GetFullName();
            Response.Write("FullName = " + print + "<br />");

            PartialCustomer partialCustomer = new PartialCustomer();
            partialCustomer.FirstName = "Praveen";
            partialCustomer.LastName = "Prajapati";
            string Printing = partialCustomer.GetFullName();
            Response.Write("FullName = " + Printing);

        }
    }
}