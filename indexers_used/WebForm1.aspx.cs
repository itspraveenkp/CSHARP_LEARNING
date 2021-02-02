using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace indexers_used
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Session
            //Session["Session1"] = "Session 1 Data";
            //Session["Session2"] = "Session 2 Data";

            //Response.Write("Session 1 Data = "+ Session[0].ToString());
            //Response.Write("<br />");
            //Response.Write("Session 2 Data = " + Session["Session2"].ToString());
            #endregion

            string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from tblEmployees";
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Response.Write("ID" + reader[0].ToString());
                    Response.Write("Name " + reader["Name"].ToString());
                    Response.Write("<br />");
                }
            }
        }
    }
}