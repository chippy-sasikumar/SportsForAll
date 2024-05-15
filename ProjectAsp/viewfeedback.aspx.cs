using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace ProjectAsp
{
    public partial class viewfeedback : System.Web.UI.Page
    {
        connectionclass ob = new connectionclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fnGridBind();
            }
        }
        public void fnGridBind()
        {
            string sel = "select tbFeedback.*,tbUserReg.UserName,tbUserReg.UserEmail from tbFeedback join tbUserReg on tbFeedback.UserId=tbUserReg.UserId where tbFeedback.Status='Pending'";
            DataSet ds = ob.fnAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }        
        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Panel1.Visible = true;
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
            lblname.Text = rw.Cells[2].Text;
            lblemail.Text = rw.Cells[3].Text;
            lblfeedback.Text = rw.Cells[4].Text;
            Session["fid"] = Convert.ToInt32( rw.Cells[0].Text);

        }

        protected void btnmail_Click(object sender, EventArgs e)
        {
            SendEmail2("Rithu", "rithuproject1@gmail.com", "awho abaj wkiq xelb", "'" + lblname.Text + "'", "" + lblemail.Text + "", "Sports For All", "'" + txtreply.Text + "'");         
            
            string str = "update tbFeedback set Reply='" + txtreply.Text + "',Status='Sent' where FId=" + Session["fid"] + "";
            int u = ob.fnNonQuery(str);
            if (u == 1)
            {
                fnGridBind();
                Panel1.Visible = false;
                lblsent.Text = "Message Sent";              
            }
        }
        
        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)
        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}