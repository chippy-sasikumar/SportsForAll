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
    public partial class p_editcategory : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            fnGridbind();
        }
        public void fnGridbind()
        {
            string s = "select * from tbCategory";
            DataSet ds = ob.fnAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            int id = Convert.ToInt32(e.CommandArgument);
            string s = "select * from tbCategory where CateId=" + id + "";
            SqlDataReader dr = ob.fnReader(s);
            while (dr.Read())
            {
                lblid.Text = dr["CateId"].ToString();
                txtname.Text = dr["CateName"].ToString();
                txtdescription.Text = dr["CateDescription"].ToString();               
            }
            Session["cid"] = id;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {           
            string update = "update tbCategory set CateDescription='" + txtdescription.Text + "'where CateId=" + Session["cid"] + "";
            int i = ob.fnNonQuery(update);
            if (i == 1)
            {
                Panel1.Visible = false;
                lblupdate.Visible = true;
                lblupdate.Text = "Category Updated Successfully";
            }
        }
        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {            
            int id = Convert.ToInt32(e.CommandArgument);
            String s = "select CateStatus from tbCategory where CateId=" + id + "";
            string status = ob.fnScalar(s);
            if (status == "Available")
            {
                string update = "update tbCategory set CateStatus='Unavailable' where CateId=" + id + "";
                int i = ob.fnNonQuery(update);
                fnGridbind();
            }
            else if (status == "Unavailable")
            {
                string update = "update tbCategory set CateStatus='Available' where CateId=" + id + "";
                int i = ob.fnNonQuery(update);
                fnGridbind();
            }            
        }        
    }
}