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
    public partial class p_editproduct : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            fnGridbind();
        }
        public void fnGridbind()
        {
            string sel = "select * from tbProduct";
            DataSet ds = ob.fnAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            int id = Convert.ToInt32(e.CommandArgument);
            string s = "select * from tbProduct where ProId=" + id + "";
            SqlDataReader dr = ob.fnReader(s);
            while (dr.Read())
            {
                lblid.Text = dr["ProId"].ToString();
                lblname.Text = dr["ProName"].ToString();
                txtdescription.Text = dr["ProDescription"].ToString();
                txtprice.Text = dr["ProPrice"].ToString();
                txtstock.Text = dr["ProStock"].ToString();                
            }
            Session["pid"] = id;
        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {            
            string update = "update tbProduct set ProDescription='" + txtdescription.Text + "',ProPrice=" + txtprice.Text + ", proStock=" + txtstock.Text + " where ProId=" + Session["pid"] + "";
            int i = ob.fnNonQuery(update);
            if (i == 1)
            {
                Panel1.Visible = false;
                lblupdate.Visible = true;
                lblupdate.Text = "Product Updated Successfully";
                fnGridbind();
            }
        }
        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {            
            int id = Convert.ToInt32(e.CommandArgument);
            string s = "select ProStatus from tbProduct where ProId=" + id + "";
            string status = ob.fnScalar(s);
            if (status == "Available")
            {
                string update = "update tbProduct set ProStatus='Unavailable' where ProId=" + id + "";
                int i = ob.fnNonQuery(update);
                fnGridbind();
            }
            else if(status=="Unavailable")
            {
                string update = "update tbProduct set ProStatus='Available' where ProId=" + id + "";
                ;
                int i = ob.fnNonQuery(update);
                fnGridbind();
            }           
        }     
    }
}