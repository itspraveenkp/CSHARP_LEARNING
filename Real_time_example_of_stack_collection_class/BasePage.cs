using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Real_time_example_of_stack_collection_class
{
    public class BasePage: System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            if(Session["URLStack"] == null)
            {
                Stack<string> urlstack = new Stack<string>();
                Session["URLStack"] = urlstack;
            }

            if (Request.UrlReferrer != null && !this.Page.IsPostBack && Session["BackButtonClicked"] == null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                urlStack.Push(Request.UrlReferrer.AbsoluteUri);
            }

            if (Session["BackButtonClicked"] != null)
            {
                Session["BackButtonClicked"] = null;
            }
        }
    }
}