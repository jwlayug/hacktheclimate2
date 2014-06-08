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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlOperation op = new SqlOperation();

            try
            {
                op.register(firstname, lastname, email, username, password);
                ClientScript.RegisterStartupScript(typeof(Page), "MessagePopUp", "<script language='JavaScript'>alert('Registration successful. You may now log in.');window.location.href ='login.aspx';</script>");
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                ClientScript.RegisterStartupScript(typeof(Page), "MessagePopUp", "<script language='JavaScript'>alert('Registration failed.');</script>");
            }
        }
    }
}