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
    public partial class productdetails : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        int prostock = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select * from tbProduct where ProId=" + Session["proid"] + "";
            SqlDataReader dr = ob.fnReader(sel);
            while (dr.Read())
            {
                Image1.ImageUrl = dr["ProImage"].ToString();
                lblname.Text = dr["ProName"].ToString();
                lbldescription.Text = dr["ProDescription"].ToString();
                lblprice.Text = dr["ProPrice"].ToString();
                prostock = Convert.ToInt32(dr["ProStock"].ToString());

            }
        }
        protected void btncart_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(txtquantity.Text);
            if (prostock<0 || q > prostock) 
            {
                lblstock.Visible = true;
                lblstock.Text = "Item Out of Stock";
            }
            else
            {
                lblstock.Visible = false;
                int id;
                string se = "select max(CartId) from tbCart";
                string cartid = ob.fnScalar(se);
                if (cartid == "")
                {
                    id = 1;
                }
                else
                {
                    int newcartid = Convert.ToInt32(cartid);
                    id = newcartid + 1;
                }
                string s = "select ProPrice from tbProduct where ProId=" + Session["proid"] + "";
                int price = Convert.ToInt32(txtquantity.Text) * Convert.ToInt32(ob.fnScalar(s));
                string ins = "insert into tbCart values(" + id + "," + Session["proid"] + "," + Session["uid"] + "," + txtquantity.Text + "," + price + ",'Incart')";
                int i = ob.fnNonQuery(ins);
                if (i == 1)
                {
                    lblcart.Text = "Product Added to Cart";
                }
            }                 
        }
        protected void btncontinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("userhome.aspx");
        }

        protected void btnviewcart_Click(object sender, EventArgs e)
        {
            Response.Redirect("cartitems.aspx");
        }
    }
}