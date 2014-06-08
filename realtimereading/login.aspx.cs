using MySql.Data.MySqlClient;
using realtimereading.utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace realtimereading
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlOperation op = new SqlOperation();
            MySqlDataReader dr = op.login(username, password);

            if (dr.HasRows)
            {
                //Successful login
                dr.Read();
                Session.Add("userid", dr.GetValue(0));
                ClientScript.RegisterStartupScript(typeof(Page), "MessagePopUp", "<script language='JavaScript'>alert('Log in successful.');window.location.href ='index.aspx';</script>");
            }
            else
            {
                //Unsuccessful login
                ClientScript.RegisterStartupScript(typeof(Page), "MessagePopUp", "<script language='JavaScript'>alert('Log in failed. Please try again.');</script>");
            }
        }
    }
}