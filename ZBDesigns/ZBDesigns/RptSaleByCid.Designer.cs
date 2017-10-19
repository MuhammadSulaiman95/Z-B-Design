namespace ZBDesigns
{
    partial class RptSaleByCid
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
            this.ViewSaleSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetSaleByCid = new ZBDesigns.DataSetSaleByCid();
            this.SaleViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewSaleSummaryTableAdapter = new ZBDesigns.DataSetSaleByCidTableAdapters.ViewSaleSummaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSaleSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSaleByCid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewSaleSummaryBindingSource
            // 
            this.ViewSaleSummaryBindingSource.DataMember = "ViewSaleSummary";
            this.ViewSaleSummaryBindingSource.DataSource = this.DataSetSaleByCid;
            // 
            // DataSetSaleByCid
            // 
            this.DataSetSaleByCid.DataSetName = "DataSetSaleByCid";
            this.DataSetSaleByCid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaleViewer
            // 
            this.SaleViewer.AutoSize = true;
            this.SaleViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet4";
            reportDataSource1.Value = this.ViewSaleSummaryBindingSource;
            this.SaleViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.SaleViewer.LocalReport.ReportEmbeddedResource = "ZBDesigns.ReportSaleByCid.rdlc";
            this.SaleViewer.Location = new System.Drawing.Point(0, 0);
            this.SaleViewer.Name = "SaleViewer";
            this.SaleViewer.Size = new System.Drawing.Size(1069, 457);
            this.SaleViewer.TabIndex = 0;
            this.SaleViewer.Load += new System.EventHandler(this.SaleViewer_Load);
            // 
            // ViewSaleSummaryTableAdapter
            // 
            this.ViewSaleSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // RptSaleByCid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1069, 457);
            this.Controls.Add(this.SaleViewer);
            this.Name = "RptSaleByCid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RptSaleByCid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptSaleByCid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewSaleSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSaleByCid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer SaleViewer;
        private System.Windows.Forms.BindingSource ViewSaleSummaryBindingSource;
        private DataSetSaleByCid DataSetSaleByCid;
        private DataSetSaleByCidTableAdapters.ViewSaleSummaryTableAdapter ViewSaleSummaryTableAdapter;
    }
}