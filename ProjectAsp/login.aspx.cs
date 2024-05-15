using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAsp
{
    public partial class login : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string str = "select count(RegId) from tbLogin where UserName='" + txtuname.Text + "' and Password='" + txtpwd.Text + "'";
            string cid = ob.fnScalar(str);
            int id = Convert.ToInt32(cid);
            if (id == 1)
            {
                string str1 = "select RegId from tbLogin where UserName='" + txtuname.Text + "' and Password='" + txtpwd.Text + "'";
                string regid = ob.fnScalar(str1);
                Session["uid"] = regid;
                string str2 = "select LogType from tbLogin where UserName='" + txtuname.Text + "' and Password='" + txtpwd.Text + "'";
                string logtype = ob.fnScalar(str2);
                if (logtype == "Admin")
                {
                    Response.Redirect("adminhome.aspx");
                }
                else if (logtype == "User")
                {
                    Response.Redirect("userhome.aspx");
                }
            }
            else
            {
                Label4.Text = "Invalid Username And Password";
            }

        }
    }
}