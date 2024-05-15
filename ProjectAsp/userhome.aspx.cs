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
    public partial class userhome : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select * from tbCategory";
                DataSet ds = ob.fnAdapter(sel);
                DataList1.DataSource = ds;
                DataList1.DataBind(); 
            }            
        }
        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            Session["cateid"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("p_viewproducts.aspx");
        }        

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("feedback.aspx");
        }
    }
}