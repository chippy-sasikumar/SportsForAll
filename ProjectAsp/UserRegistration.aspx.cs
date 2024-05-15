using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ProjectAsp
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string s = "select StateId,State from tbState";
                DataSet ds = ob.fnAdapter(s);
                ddlstate.DataSource = ds;
                ddlstate.DataTextField = "State";
                ddlstate.DataValueField = "StateId";
                ddlstate.DataBind();
                ddlstate.Items.Insert(0, "-Select-");             
            }          
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
            Session["regid"] = regid;
            string ins = "insert into tbUserReg values(" + regid + ",'" + txtname.Text + "'," + txtage.Text + ",'" + txtemail.Text + "'," + txtphone.Text + ",'" + txtpadr.Text + "','" + txtdadr.Text + "','" + ddldistrict.SelectedItem.Value + "','" + ddlstate.SelectedItem.Value + "'," + txtpin.Text + ",'Active')";
            int i = ob.fnNonQuery(ins);
            if (i == 1)
            {
                string inslog = "insert into tbLogin values(" + regid + ",'" + txtuname.Text + "','" + txtpwd.Text + "','User','Active')";
                int j = ob.fnNonQuery(inslog);
                if (j == 1)
                {                    
                    Response.Redirect("accountdetails.aspx");
                }
            }
        }
        protected void ddldistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }                              
        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string d = "select DistrId,District from tbDistrict where StateId='"+ddlstate.SelectedItem.Value +"'";
            DataSet dsd = ob.fnAdapter(d);
            ddldistrict.DataSource = dsd;
            ddldistrict.DataTextField = "District";
            ddldistrict.DataValueField = "DistrId";
            ddldistrict.DataBind();
            ddldistrict.Items.Insert(0, "-Select-");
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