using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAsp
{
    public partial class accountdetails : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            string ins = "insert into tbAccount values('" + txtaccname.Text + "'," + txtaccno.Text + "," + Session["regid"] + ",'" + DropDownList1.SelectedItem.Text + "'," + txtaccbal.Text + ")";
            int i = ob.fnNonQuery(ins);
            if(i==1)
            {
                lblreg.Text = "Registered Successfully";
            }
        }
    }
}