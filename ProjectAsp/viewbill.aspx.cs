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
    public partial class viewbill : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        string grandtotal = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select tbOrder.Quantity ,tbOrder.TotalPrice,tbProduct.ProName,tbProduct.ProPrice from tbOrder join tbProduct  on tbProduct.ProId=tbOrder.ProId where OrderStatus='Ordered' and UserId="+Session["uid"]+"";
            DataSet ds = ob.fnAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();


            string b = "select * from tbBill where UserId=" + Session["uid"] + " and BillStatus='Waiting Payment'";
            SqlDataReader dr = ob.fnReader(b);           
            while (dr.Read())
            {
                lblbillno.Text = dr["BillId"].ToString();
                grandtotal = dr["GrandTotal"].ToString();                 
            }
            lblgtotal.Text = grandtotal;
            lbldate.Text = Convert.ToString(DateTime.Now);

            string sa = "select * from tbuserReg where UserId=" + Session["uid"] + "";
            SqlDataReader drs = ob.fnReader(sa);            
            while (drs.Read())
            {
                lblshipadr.Text = drs["UserName"].ToString();
                lbladr.Text  = drs["UserDeliveryAddress"].ToString();
                lblpin.Text = drs["UserPincode"].ToString();
            }
        }

        protected void btnpay_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();
            int suid = Convert.ToInt32(Session["uid"]);
            int balance = obj.BalanceCheck(Convert.ToInt32(txtaccno.Text), suid);
            int gt = Convert.ToInt32(grandtotal);            

            // prostock         

            string ocm = "select max(OrderId) from tbOrder";
            int oridm = Convert.ToInt32(ob.fnScalar(ocm));
            string ocs = "select count(OrderId) from tbOrder where OrderStatus='Ordered' and UserId=" + Session["uid"] + "";
            int oids = Convert.ToInt32(ob.fnScalar(ocs));
            int oid = (oridm - oids) + 1;

            for(int i = oid; i <= oridm; i++)
            {
                int pid = 0, pq = 0, pst = 0;
                string proname = "", prostatus = "";
                string st = "select tbOrder.OrderId,tbOrder.ProId,tbOrder.Quantity,tbProduct.ProName,tbProduct.ProStock,tbProduct.ProStatus from tbOrder join tbProduct on tbOrder.ProId=tbProduct.ProId where UserId = " + Session["uid"] + "  and OrderId=" + i + "";
                SqlDataReader dr = ob.fnReader(st);
                while (dr.Read())
                {
                    pid = Convert.ToInt32(dr["ProId"].ToString());
                    proname = dr["ProName"].ToString();
                    pq = Convert.ToInt32(dr["quantity"].ToString());
                    pst = Convert.ToInt32(dr["ProStock"].ToString());
                    prostatus = dr["ProStatus"].ToString();
                }
                if (balance > gt)
                {
                    int newprostock = pst - pq;
                    string prostock = "update tbProduct set ProStock=" + newprostock + " where ProId=" + pid + "";
                    ob.fnNonQuery(prostock);
                    if (newprostock == 0)
                    {
                        string status = "update tbProduct set ProStatus='Unavailable' where ProId=" + pid + "";
                        ob.fnNonQuery(status);
                        
                    }

                    int newbal = balance - gt;
                    string upbal = "update tbAccount set AccBalance=" + newbal + " where AccNumber=" + (Convert.ToInt32(txtaccno.Text)) + " and UserId=" + Session["uid"] + "";
                    ob.fnNonQuery(upbal);

                    string upstatus = "update tbOrder set OrderStatus='Paid' where UserId=" + Session["uid"] + " and OrderId=" + i + "";
                    ob.fnNonQuery(upstatus);

                    string billstatus = "update tbBill set BillStatus='Paid' where UserId=" + Session["uid"] + "";
                    ob.fnNonQuery(billstatus);

                    Label6.Text = "Payment Successfull";
                }
                else
                {
                    Label6.Text = "Insufficient Balance";
                }

            }      
        }
    }
}