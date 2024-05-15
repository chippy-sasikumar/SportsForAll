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
    public partial class p_addcategory : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            string path = "~/P_Photos" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string ins = "insert into tbCategory values('" + txtname.Text + "','" + path + "','" + txtdescription.Text + "','" + DropDownList1.SelectedItem.Text + "')";
            int i = ob.fnNonQuery(ins);
            if (i == 1)
            {
                Label4.Text = "New Category added successfully";
            }
        }
    }
}