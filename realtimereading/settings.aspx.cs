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
    public partial class settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string interval = txtInterval.Text;
            SqlOperation op = new SqlOperation();
            try
            {
                op.saveInterval(interval, int.Parse(Session["userid"].ToString()));
                ClientScript.RegisterStartupScript(typeof(Page), "MessagePopUp", "<script language='JavaScript'>alert('Update successful.');</script>");
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                ClientScript.RegisterStartupScript(typeof(Page), "MessagePopUp", "<script language='JavaScript'>alert('Update failed.');</script>");
            }
        }
    }
}