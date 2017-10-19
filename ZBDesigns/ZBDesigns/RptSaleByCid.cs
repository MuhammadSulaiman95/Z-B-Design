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
    public partial class RptSaleByCid : Form
    {
        int cid;
        DateTime from;
        DateTime to;
        public RptSaleByCid(int txtcid,DateTime txtFrom, DateTime txtTo)
        {
            InitializeComponent();
            cid = txtcid;
            from = txtFrom;
            to = txtTo;
        }

        private void RptSaleByCid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetSaleByCid.ViewSaleSummary' table. You can move, or remove it, as needed.
            this.ViewSaleSummaryTableAdapter.Fill(this.DataSetSaleByCid.ViewSaleSummary, cid.ToString(), from, to);

            this.SaleViewer.RefreshReport();
        }

        private void SaleViewer_Load(object sender, EventArgs e)
        {
            this.ViewSaleSummaryTableAdapter.Fill(this.DataSetSaleByCid.ViewSaleSummary, cid.ToString(), from, to);

            this.SaleViewer.RefreshReport();
        }
    }
}
