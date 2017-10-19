using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZBDesigns
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddNewCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.addnewcust();
        }

        private void btnCustomerForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.customerform();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.orderform();
        }

        private void btnOrderView_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.orderview();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.PaymentForm();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Class1.SaleSumForm();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Class1.EmailForm();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportsForms rf = new ReportsForms();
            rf.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label3.UseMnemonic = false;
            label3.Text = "Z&B Designs";
        }
    }
}
