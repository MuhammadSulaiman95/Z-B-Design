using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZBDesigns
{
    public partial class SaleSummaryForm : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        ToolTip t = new ToolTip();
        Class1 c = new Class1();
        public SaleSummaryForm()
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

        public void autoComplete()
        {
            txtCustId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCustId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl1 = new AutoCompleteStringCollection();
            cmd = new SqlCommand("SpCust", c.con);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cl.Add(dr[0].ToString());
                cl1.Add(dr[1].ToString());
            }
            txtCustId.AutoCompleteCustomSource = cl;
            txtSearchName.AutoCompleteCustomSource = cl1;
            c.con.Close();
        }

        private void SaleSummaryForm_Load(object sender, EventArgs e)
        {
            autoComplete();
            showdata();
            txtCustId.ReadOnly = true;
            btnSubmit.Hide();
            label5.UseMnemonic = false;
            label5.Text = "Z&B Designs";
        }

        private void btnSaleDate_Click(object sender, EventArgs e)
        {
            RptSaleByDate rpt = new RptSaleByDate(DateTime.Parse(txtStartdate.Text),DateTime.Parse(txtEndDate.Text));
            rpt.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RptSaleByCid rp = new RptSaleByCid(int.Parse(txtCustId.Text), DateTime.Parse(txtStartdate.Text), DateTime.Parse(txtEndDate.Text));
            rp.Show();
        }

        private void btnRadioByDate_CheckedChanged(object sender, EventArgs e)
        {
            txtCustId.ReadOnly = true;
            btnSubmit.Hide();
            btnSaleDate.Show();
            txtCustId.Text = "";
        }

        private void btnRadioByCid_CheckedChanged(object sender, EventArgs e)
        {
            txtCustId.ReadOnly = false;
            btnSubmit.Show();
            btnSaleDate.Hide();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Cname like '%" + txtSearchName.Text + "%' ");
            CustomerView.DataSource = dv.ToTable();
        }
    }
}
