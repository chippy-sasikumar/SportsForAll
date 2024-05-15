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
    public partial class p_addproduct : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string ddl = "Select CateId,CateName from tbCategory";
                DataSet ds = ob.fnAdapter(ddl);
                ddlcateid.DataSource = ds;
                ddlcateid.DataTextField = "CateName";
                ddlcateid.DataValueField = "CateId";
                ddlcateid.DataBind();
                ddlcateid.Items.Insert(0, "-Select-");
            }
           
        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            string path = "~/P_Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string ins = "insert into tbProduct values(" + ddlcateid.SelectedItem.Value + ",'" + txtproname.Text + "','" + path + "','" + txtdescription.Text + "'," + txtprice.Text + "," + txtstock.Text + ",'" + DropDownList1.SelectedItem.Text + "')";
            int i = ob.fnNonQuery(ins);
            if (i == 1)
            {
                lblupload.Text = "Product Added Successfully";
            }
        }
    }
}