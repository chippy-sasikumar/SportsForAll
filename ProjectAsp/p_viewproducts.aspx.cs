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
    public partial class p_viewproducts : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string sel = "select * from tbProduct where CateId=" + Session["cateid"] + "";
                DataSet ds = ob.fnAdapter(sel);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }           
        }      
        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            Session["proid"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("productdetails.aspx");
        }
    }
}