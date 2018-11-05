using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            string sql = "select * from tblLogin where username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //Response.Redirect("Contact.aspx");
                Session["username"] = dt.Rows[0].ItemArray[0].ToString();
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Error.aspx");
            }

        }
    }
}