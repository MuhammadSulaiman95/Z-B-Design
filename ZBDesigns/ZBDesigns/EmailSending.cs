using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace ZBDesigns
{
    public partial class EmailSending : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        Class1 c = new Class1();
        public EmailSending()
        {
            InitializeComponent();
        }

        public void showdata()
        {
            cmd = new SqlCommand("spCustSelect", c.con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            CustomerView.DataSource = dt;
        }

        private void SetButton()
        {
            btnSend.Enabled = (txtTo.Text != "" || txtTo.Visible == false) && (txtSub.Text != "" || txtSub.Visible == false) && (txtMsg.Text != "" || txtMsg.Visible == false) && (txtUser.Text != "" || txtUser.Visible == false) && (txtPass.Text != "" || txtPass.Visible == false);
        }

        public void autoComplete()
        {
            txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl1 = new AutoCompleteStringCollection();
            cmd = new SqlCommand("select Cname from Cust_info", c.con);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cl1.Add(dr[0].ToString());
            }
            txtSearchName.AutoCompleteCustomSource = cl1;
            c.con.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient(txtSmtp.Text, int.Parse(txtPort.Text));
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(txtUser.Text, txtPass.Text);
                MailMessage msg = new MailMessage();
                msg.To.Add(txtTo.Text);
                msg.From = new MailAddress(txtUser.Text + txtSmtp.Text.Replace("smtp.", "@"), "Z&B Designs", Encoding.UTF8);
                msg.Subject = txtSub.Text;
                msg.Body = txtMsg.Text;
                client.Send(msg);
                MessageBox.Show("Email Sent Successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmailSending_Load(object sender, EventArgs e)
        {
            label2.UseMnemonic = false;
            label2.Text = "Z&B Designs";
            showdata();
            autoComplete();
            btnSend.Enabled = false;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Cname like '%" + txtSearchName.Text + "%' ");
            CustomerView.DataSource = dv.ToTable();
        }

        private void CustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTo.Text = CustomerView.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtSub_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTo.Text = "";
            txtSub.Text = "";
            txtMsg.Text = "";
        }
    }
}
