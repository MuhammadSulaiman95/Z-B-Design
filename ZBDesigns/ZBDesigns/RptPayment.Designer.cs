namespace ZBDesigns
{
    partial class RptPayment
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
            this.PaymentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentDataSet = new ZBDesigns.PaymentDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaymentViewTableAdapter = new ZBDesigns.PaymentDataSetTableAdapters.PaymentViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentViewBindingSource
            // 
            this.PaymentViewBindingSource.DataMember = "PaymentView";
            this.PaymentViewBindingSource.DataSource = this.PaymentDataSet;
            // 
            // PaymentDataSet
            // 
            this.PaymentDataSet.DataSetName = "PaymentDataSet";
            this.PaymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PaymentViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ZBDesigns.ReportPayment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1120, 640);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PaymentViewTableAdapter
            // 
            this.PaymentViewTableAdapter.ClearBeforeFill = true;
            // 
            // RptPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1120, 640);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RptPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PaymentViewBindingSource;
        private PaymentDataSet PaymentDataSet;
        private PaymentDataSetTableAdapters.PaymentViewTableAdapter PaymentViewTableAdapter;
    }
}