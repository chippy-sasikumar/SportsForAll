using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAsp
{
    public partial class feedback : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbFeedback values(" + Session["uid"] + ",'" + txtfeedback.Text + "','Waiting','Pending')";
            int i = ob.fnNonQuery(ins);
            if (i == 1)
            {
                lblfeedback.Text = "Feedback Sent";
            }
        }
    }
}