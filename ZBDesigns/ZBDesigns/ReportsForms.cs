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
    public partial class ReportsForms : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        Class1 c = new Class1();
        public ReportsForms()
        {
            InitializeComponent();
        }

        public void showdata(string query)
        {
            dt = new DataTable();
            da = new SqlDataAdapter(query,c.con);
            da.Fill(dt);
            Grid.DataSource = dt;
        }

        public void showdataReady(string query)
        {
            dt = new DataTable();
            da = new SqlDataAdapter(query, c.con);
            da.Fill(dt);
            GridReady.DataSource = dt;
        }

        private void ReportsForms_Load(object sender, EventArgs e)
        {
            label2.UseMnemonic = false;
            label2.Text = "Z&B Designs";
            showdata("spOrderSelect");
            showdataReady("spOrderSelect");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            showdataReady("select * from tblOrder where DueDate between'" + DateTime.Parse(RStartDate.Value.ToString()) + "' and '" + DateTime.Parse(REndDate.Value.ToString()) + "' and IsReady='" + cmbReady.Text + "' and Delievered='" + comboBox1.Text + "' order by DueDate asc ");
        }

        private void btnSubmitDel_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showdata("select * from tblOrder where DueDate between '" + DateTime.Parse(txtFrom.Value.ToString()) + "' and '" + DateTime.Parse(txtTo.Value.ToString()) + "' order by DueDate asc");
        }
    }
}
