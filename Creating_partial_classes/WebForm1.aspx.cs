using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creating_partial_classes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //PartialClasses partialClasses = new PartialClasses(); Considered All is abstract class

        }
    }

    //public class sample : PartialClasses
    //{

    //}  Can not drived sealed class
    public class sample
    {

    }

    public interface IEmployee
    {
        void EmployeeMethod();
        
    }

    public interface ICustomer
    {
        void CustomerMethod();
    }
        
    
}