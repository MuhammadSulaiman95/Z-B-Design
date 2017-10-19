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
    public partial class RptInvoice : Form
    {
        int inv;
        public RptInvoice(int txtinv)
        {
            InitializeComponent();
            inv = txtinv;
        }

        private void RptInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetInvoices.OrderViewRep' table. You can move, or remove it, as needed.
            this.OrderViewRepTableAdapter.Fill(this.DataSetInvoices.OrderViewRep,inv);

            this.InvoiceView.RefreshReport();
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {
            this.OrderViewRepTableAdapter.Fill(this.DataSetInvoices.OrderViewRep, inv);

            this.InvoiceView.RefreshReport();
        }
    }
}
