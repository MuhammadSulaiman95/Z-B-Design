namespace ZBDesigns
{
    partial class RptSaleByDate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewSaleSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetSaleByDate = new ZBDesigns.DataSetSaleByDate();
            this.ViewSaleSummaryTableAdapter = new ZBDesigns.DataSetSaleByDateTableAdapters.ViewSaleSummaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSaleSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSaleByDate)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.ViewSaleSummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ZBDesigns.ReportSaleByDate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1087, 613);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ViewSaleSummaryBindingSource
            // 
            this.ViewSaleSummaryBindingSource.DataMember = "ViewSaleSummary";
            this.ViewSaleSummaryBindingSource.DataSource = this.DataSetSaleByDate;
            // 
            // DataSetSaleByDate
            // 
            this.DataSetSaleByDate.DataSetName = "DataSetSaleByDate";
            this.DataSetSaleByDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewSaleSummaryTableAdapter
            // 
            this.ViewSaleSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // RptSaleByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 613);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptSaleByDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RptSaleByDate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptSaleByDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewSaleSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSaleByDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewSaleSummaryBindingSource;
        private DataSetSaleByDate DataSetSaleByDate;
        private DataSetSaleByDateTableAdapters.ViewSaleSummaryTableAdapter ViewSaleSummaryTableAdapter;
    }
}