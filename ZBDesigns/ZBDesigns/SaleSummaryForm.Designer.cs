namespace ZBDesigns
{
    partial class SaleSummaryForm
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
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.CustomerView = new System.Windows.Forms.DataGridView();
            this.btnRadioByCid = new System.Windows.Forms.RadioButton();
            this.btnRadioByDate = new System.Windows.Forms.RadioButton();
            this.btnSaleDate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStartdate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerView)).BeginInit();
            this.panel1.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(300, 23);
            this.label16.TabIndex = 31;
            this.label16.Text = "Search or Find By Customer Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.txtSearchName);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(418, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 57);
            this.panel3.TabIndex = 1;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(309, 24);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(259, 22);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // CustomerView
            // 
            this.CustomerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerView.Location = new System.Drawing.Point(418, 191);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.Size = new System.Drawing.Size(630, 357);
            this.CustomerView.TabIndex = 60;
            // 
            // btnRadioByCid
            // 
            this.btnRadioByCid.AutoSize = true;
            this.btnRadioByCid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadioByCid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRadioByCid.Location = new System.Drawing.Point(184, 67);
            this.btnRadioByCid.Name = "btnRadioByCid";
            this.btnRadioByCid.Size = new System.Drawing.Size(164, 27);
            this.btnRadioByCid.TabIndex = 1;
            this.btnRadioByCid.TabStop = true;
            this.btnRadioByCid.Text = "By Customer ID";
            this.btnRadioByCid.UseVisualStyleBackColor = true;
            this.btnRadioByCid.CheckedChanged += new System.EventHandler(this.btnRadioByCid_CheckedChanged);
            // 
            // btnRadioByDate
            // 
            this.btnRadioByDate.AutoSize = true;
            this.btnRadioByDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadioByDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRadioByDate.Location = new System.Drawing.Point(31, 67);
            this.btnRadioByDate.Name = "btnRadioByDate";
            this.btnRadioByDate.Size = new System.Drawing.Size(140, 27);
            this.btnRadioByDate.TabIndex = 0;
            this.btnRadioByDate.TabStop = true;
            this.btnRadioByDate.Text = "By Only Date";
            this.btnRadioByDate.UseVisualStyleBackColor = true;
            this.btnRadioByDate.CheckedChanged += new System.EventHandler(this.btnRadioByDate_CheckedChanged);
            // 
            // btnSaleDate
            // 
            this.btnSaleDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaleDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaleDate.Location = new System.Drawing.Point(31, 269);
            this.btnSaleDate.Name = "btnSaleDate";
            this.btnSaleDate.Size = new System.Drawing.Size(309, 36);
            this.btnSaleDate.TabIndex = 5;
            this.btnSaleDate.Text = "Sale by Only Date";
            this.btnSaleDate.UseVisualStyleBackColor = false;
            this.btnSaleDate.Click += new System.EventHandler(this.btnSaleDate_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(27, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 25);
            this.label15.TabIndex = 59;
            this.label15.Text = "Customer Id";
            // 
            // txtCustId
            // 
            this.txtCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(158, 130);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(195, 22);
            this.txtCustId.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(31, 311);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(309, 36);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Sale by Customer Id";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "End Date";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(158, 214);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(195, 22);
            this.txtEndDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(33, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sale Summary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(27, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 54;
            this.label10.Text = "Start Date";
            // 
            // txtStartdate
            // 
            this.txtStartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartdate.Location = new System.Drawing.Point(158, 178);
            this.txtStartdate.Name = "txtStartdate";
            this.txtStartdate.Size = new System.Drawing.Size(195, 22);
            this.txtStartdate.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRadioByCid);
            this.panel1.Controls.Add(this.btnRadioByDate);
            this.panel1.Controls.Add(this.btnSaleDate);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtCustId);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEndDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtStartdate);
            this.panel1.Location = new System.Drawing.Point(34, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 357);
            this.panel1.TabIndex = 2;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.HeadPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeadPanel.Controls.Add(this.label4);
            this.HeadPanel.Controls.Add(this.label5);
            this.HeadPanel.Location = new System.Drawing.Point(-2, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(1092, 107);
            this.HeadPanel.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(447, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 41);
            this.label4.TabIndex = 61;
            this.label4.Text = "Sale Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(465, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 43);
            this.label5.TabIndex = 59;
            this.label5.Text = "ZB Designs";
            // 
            // SaleSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1091, 617);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CustomerView);
            this.Controls.Add(this.panel1);
            this.Name = "SaleSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleSummaryForm";
            this.Load += new System.EventHandler(this.SaleSummaryForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView CustomerView;
        private System.Windows.Forms.RadioButton btnRadioByCid;
        private System.Windows.Forms.RadioButton btnRadioByDate;
        private System.Windows.Forms.Button btnSaleDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtStartdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}