namespace ZBDesigns
{
    partial class RptInvoice
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
            this.OrderViewRepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetInvoices = new ZBDesigns.DataSetInvoices();
            this.InvoiceView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrderViewRepTableAdapter = new ZBDesigns.DataSetInvoicesTableAdapters.OrderViewRepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrderViewRepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderViewRepBindingSource
            // 
            this.OrderViewRepBindingSource.DataMember = "OrderViewRep";
            this.OrderViewRepBindingSource.DataSource = this.DataSetInvoices;
            // 
            // DataSetInvoices
            // 
            this.DataSetInvoices.DataSetName = "DataSetInvoices";
            this.DataSetInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InvoiceView
            // 
            this.InvoiceView.AutoSize = true;
            this.InvoiceView.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.OrderViewRepBindingSource;
            this.InvoiceView.LocalReport.DataSources.Add(reportDataSource1);
            this.InvoiceView.LocalReport.ReportEmbeddedResource = "ZBDesigns.ReportInvoice.rdlc";
            this.InvoiceView.Location = new System.Drawing.Point(0, 0);
            this.InvoiceView.Name = "InvoiceView";
            this.InvoiceView.Size = new System.Drawing.Size(1133, 660);
            this.InvoiceView.TabIndex = 0;
            this.InvoiceView.Load += new System.EventHandler(this.InvoiceView_Load);
            // 
            // OrderViewRepTableAdapter
            // 
            this.OrderViewRepTableAdapter.ClearBeforeFill = true;
            // 
            // RptInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1133, 660);
            this.Controls.Add(this.InvoiceView);
            this.Name = "RptInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RptInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderViewRepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer InvoiceView;
        private System.Windows.Forms.BindingSource OrderViewRepBindingSource;
        private DataSetInvoices DataSetInvoices;
        private DataSetInvoicesTableAdapters.OrderViewRepTableAdapter OrderViewRepTableAdapter;
    }
}