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
    public partial class cartitems : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FnGridBnd();
            }            
        }
        public void FnGridBnd()
        {
            string sel = "select tbCart.CartId,tbProduct.ProName,tbProduct.ProImage,tbCart.Quantity,tbCart.TotalPrice from tbProduct join tbCart on tbProduct.ProId=tbCart.ProId where UserId="+Session["uid"]+"";
            DataSet ds = ob.fnAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }       
        protected void btnremove_Command(object sender, CommandEventArgs e)
        {
            int cartid = Convert.ToInt32(e.CommandArgument);
            string del = "delete from tbcart where CartId=" + cartid + "";
            int j = ob.fnNonQuery(del);
            if (j == 1)
            {
                Label1.Text = "Product Removed";
            }
            FnGridBnd(); 
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {           
            GridView1.EditIndex = e.NewEditIndex;
            FnGridBnd();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FnGridBnd();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtquantity = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];            
            string s = "select tbProduct.ProPrice from tbProduct join tbCart on tbProduct.ProId=tbCart.ProId where CartId=" + getid + "";
            string p = ob.fnScalar(s);
            
            int tp = Convert.ToInt32(txtquantity.Text) * Convert.ToInt32(p);
            string str = "update tbCart set Quantity=" + txtquantity.Text + ",TotalPrice=" + tp + " where CartId=" + getid + "";
            int u = ob.fnNonQuery(str);
            GridView1.EditIndex = -1;
            if (u == 1)
            {                
                FnGridBnd();
                Label2.Text = "Quantity Updated";                               
            }                  
        }
        protected void btnconfirm_Click(object sender, EventArgs e)
        {
            string mx = "select max(CartId) from tbCart";
            string cid = ob.fnScalar(mx);
            int cartid1 = Convert.ToInt32(cid);

            for (int i = 1; i <= cartid1; i++)
            {
                int rcartid = 0, ruserid = 0, rproid = 0, rquantity = 0, rtotalprice = 0;
                string scid = "select * from tbCart where CartId="+i+"";
                SqlDataReader dr = ob.fnReader(scid);
                while (dr.Read())
                {
                    rcartid = Convert.ToInt32(dr["CartId"].ToString());
                    ruserid = Convert.ToInt32(dr["UserId"].ToString());
                    rproid = Convert.ToInt32(dr["ProId"].ToString());
                    rquantity = Convert.ToInt32(dr["Quantity"].ToString());
                    rtotalprice = Convert.ToInt32(dr["TotalPrice"].ToString());
                }              

                string ins = "insert into tbOrder values(" + rcartid + "," + ruserid + "," + rproid + "," + rquantity + "," + rtotalprice + ",'Ordered')";
                int k= ob.fnNonQuery(ins);
                if (k == 1)
                {
                    string d = "delete from tbCart where CartId="+i+"";
                    int l = ob.fnNonQuery(d);                    
                }
            }
            string gt = "select sum(TotalPrice) from tbOrder where UserId=" + Session["uid"] + " and OrderStatus='Ordered'";
            int grandtotal = Convert.ToInt32(ob.fnScalar(gt));

            DateTime bdate = DateTime.Now;
            string date = bdate.ToString("yyyy/MM/dd");
            string inso = "insert into tbBill values('" + date + "'," + Session["uid"] + "," + grandtotal + ",'Waiting Payment')";
            int h = ob.fnNonQuery(inso);
            if (h == 1)
            {
                Response.Redirect("viewbill.aspx");
            }
        }       
    }
}