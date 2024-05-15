using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ProjectAsp
{
    public partial class AdminRegistration : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnregister_Click(object sender, EventArgs e)
        {
            string s = "select max(LogId) from tbLogin";
            string id = ob.fnScalar(s);
            int regid = 0;
            if (id == "")
            {
                regid = 1;
            }
            else
            {
                int newid = Convert.ToInt32(id);
                regid = newid + 1;
            }
            string ins = "insert into tbAdminReg values("+regid +",'" + txtname.Text + "','" + txtemail.Text + "'," + txtphone.Text + ")";
            int i = ob.fnNonQuery(ins);
            if (i == 1)
            {
                string inslog = "insert into tbLogin values(" + regid + ",'" + txtuname.Text + "','" + txtpwd.Text + "','Admin','Active')";
                int j = ob.fnNonQuery(inslog);
                if (j == 1)
                {
                    lblreg.Text = "Registered Successfully";
                }
                
            }
        }

        protected void txtuname_TextChanged(object sender, EventArgs e)
        {
            string unacheck = "select count(LogId) from tbLogin where UserName='" + txtuname.Text + "'";
            string cid = ob.fnScalar(unacheck);
            if (cid == "1")
            {
                lbluname.Text = "Please choose another Username";
            }
            else
            {
                lbluname.Visible = false;
            }
        }
    }
}