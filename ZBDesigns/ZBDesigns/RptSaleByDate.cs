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
    public partial class RptSaleByDate : Form
    {
        DateTime from;
        DateTime to;
        public RptSaleByDate(DateTime txtFrom, DateTime txtTo)
        {
            InitializeComponent();
            from = txtFrom;
            to = txtTo;
        }

        private void RptSaleByDate_Load(object sender, EventArgs e)
        {
            this.ViewSaleSummaryTableAdapter.Fill(this.DataSetSaleByDate.ViewSaleSummary,from, to);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.ViewSaleSummaryTableAdapter.Fill(this.DataSetSaleByDate.ViewSaleSummary, from, to);

            this.reportViewer1.RefreshReport();
        }
    }
}
