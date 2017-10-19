namespace ZBDesigns
{
    partial class PaymentForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCBal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRecNow = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPIdSearch = new System.Windows.Forms.Button();
            this.txtSearchCid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchPid = new System.Windows.Forms.TextBox();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtTotalAmt = new System.Windows.Forms.TextBox();
            this.txtRemBal = new System.Windows.Forms.TextBox();
            this.txtRecAmt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.PayGrid = new System.Windows.Forms.DataGridView();
            this.paymentDataSet = new ZBDesigns.PaymentDataSet();
            this.panel2.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(27, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 22);
            this.label13.TabIndex = 79;
            this.label13.Text = "Current Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(27, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 78;
            this.label10.Text = "Payment Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(27, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 77;
            this.label9.Text = "Payment Id";
            // 
            // txtPId
            // 
            this.txtPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.Location = new System.Drawing.Point(211, 219);
            this.txtPId.Name = "txtPId";
            this.txtPId.ReadOnly = true;
            this.txtPId.Size = new System.Drawing.Size(171, 22);
            this.txtPId.TabIndex = 2;
            this.txtPId.TextChanged += new System.EventHandler(this.txtPId_TextChanged);
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(211, 181);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(171, 22);
            this.txtdate.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Location = new System.Drawing.Point(336, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 77);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(16, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add or Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(177, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(16, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(177, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCBal
            // 
            this.txtCBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCBal.Location = new System.Drawing.Point(210, 424);
            this.txtCBal.Name = "txtCBal";
            this.txtCBal.ReadOnly = true;
            this.txtCBal.Size = new System.Drawing.Size(171, 22);
            this.txtCBal.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(31, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 100);
            this.panel2.TabIndex = 11;
            // 
            // txtRecNow
            // 
            this.txtRecNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecNow.Location = new System.Drawing.Point(210, 461);
            this.txtRecNow.Name = "txtRecNow";
            this.txtRecNow.Size = new System.Drawing.Size(171, 22);
            this.txtRecNow.TabIndex = 9;
            this.txtRecNow.TextChanged += new System.EventHandler(this.txtRecNow_TextChanged);
            this.txtRecNow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecNow_KeyPress);
            this.txtRecNow.Leave += new System.EventHandler(this.txtRecNow_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(27, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 22);
            this.label8.TabIndex = 75;
            this.label8.Text = "Recieved Now";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(27, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 74;
            this.label4.Text = "Total Amount";
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.HeadPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeadPanel.Controls.Add(this.label1);
            this.HeadPanel.Controls.Add(this.btnMainForm);
            this.HeadPanel.Location = new System.Drawing.Point(0, -2);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(1039, 68);
            this.HeadPanel.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Payment Form";
            // 
            // btnMainForm
            // 
            this.btnMainForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMainForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMainForm.Location = new System.Drawing.Point(22, 15);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(145, 36);
            this.btnMainForm.TabIndex = 0;
            this.btnMainForm.Text = "Back to Main Form";
            this.btnMainForm.UseVisualStyleBackColor = false;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.btnPIdSearch);
            this.panel3.Controls.Add(this.txtSearchCid);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtSearchName);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtSearchPid);
            this.panel3.Controls.Add(this.btnCustSearch);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(31, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 97);
            this.panel3.TabIndex = 0;
            // 
            // btnPIdSearch
            // 
            this.btnPIdSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPIdSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPIdSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPIdSearch.Location = new System.Drawing.Point(552, 4);
            this.btnPIdSearch.Name = "btnPIdSearch";
            this.btnPIdSearch.Size = new System.Drawing.Size(111, 27);
            this.btnPIdSearch.TabIndex = 1;
            this.btnPIdSearch.Text = "PIDSearch";
            this.btnPIdSearch.UseVisualStyleBackColor = false;
            this.btnPIdSearch.Click += new System.EventHandler(this.btnPIdSearch_Click);
            // 
            // txtSearchCid
            // 
            this.txtSearchCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCid.Location = new System.Drawing.Point(299, 42);
            this.txtSearchCid.Name = "txtSearchCid";
            this.txtSearchCid.Size = new System.Drawing.Size(247, 22);
            this.txtSearchCid.TabIndex = 2;
            this.txtSearchCid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCid_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 21);
            this.label11.TabIndex = 33;
            this.label11.Text = "Find By Customer ID";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(299, 72);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(247, 22);
            this.txtSearchName.TabIndex = 4;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            this.txtSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchName_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(273, 21);
            this.label16.TabIndex = 31;
            this.label16.Text = "Search or Find By Customer Name";
            // 
            // txtSearchPid
            // 
            this.txtSearchPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPid.Location = new System.Drawing.Point(299, 8);
            this.txtSearchPid.Name = "txtSearchPid";
            this.txtSearchPid.Size = new System.Drawing.Size(247, 22);
            this.txtSearchPid.TabIndex = 0;
            this.txtSearchPid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchPid_KeyPress);
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCustSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustSearch.Location = new System.Drawing.Point(552, 40);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(111, 52);
            this.btnCustSearch.TabIndex = 5;
            this.btnCustSearch.Text = "Search";
            this.btnCustSearch.UseVisualStyleBackColor = false;
            this.btnCustSearch.Click += new System.EventHandler(this.btnCustSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Find By Payment ID";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustPhone.Location = new System.Drawing.Point(210, 323);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.ReadOnly = true;
            this.txtCustPhone.Size = new System.Drawing.Size(171, 22);
            this.txtCustPhone.TabIndex = 5;
            this.txtCustPhone.TextChanged += new System.EventHandler(this.txtCustPhone_TextChanged);
            // 
            // txtTotalAmt
            // 
            this.txtTotalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmt.Location = new System.Drawing.Point(210, 358);
            this.txtTotalAmt.Name = "txtTotalAmt";
            this.txtTotalAmt.ReadOnly = true;
            this.txtTotalAmt.Size = new System.Drawing.Size(171, 22);
            this.txtTotalAmt.TabIndex = 6;
            // 
            // txtRemBal
            // 
            this.txtRemBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemBal.Location = new System.Drawing.Point(210, 494);
            this.txtRemBal.Name = "txtRemBal";
            this.txtRemBal.ReadOnly = true;
            this.txtRemBal.Size = new System.Drawing.Size(171, 22);
            this.txtRemBal.TabIndex = 10;
            // 
            // txtRecAmt
            // 
            this.txtRecAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecAmt.Location = new System.Drawing.Point(210, 390);
            this.txtRecAmt.Name = "txtRecAmt";
            this.txtRecAmt.ReadOnly = true;
            this.txtRecAmt.Size = new System.Drawing.Size(172, 22);
            this.txtRecAmt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(27, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 73;
            this.label6.Text = "Remaining Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(27, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 22);
            this.label7.TabIndex = 72;
            this.label7.Text = "Recieved Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(27, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 22);
            this.label15.TabIndex = 71;
            this.label15.Text = "Customer Id";
            // 
            // txtCustId
            // 
            this.txtCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(211, 254);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.ReadOnly = true;
            this.txtCustId.Size = new System.Drawing.Size(171, 22);
            this.txtCustId.TabIndex = 3;
            this.txtCustId.TextChanged += new System.EventHandler(this.txtCustId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(27, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 70;
            this.label5.Text = "Customer Phone No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 69;
            this.label3.Text = "Customer Name";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(211, 289);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(171, 22);
            this.txtCustName.TabIndex = 4;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // PayGrid
            // 
            this.PayGrid.AllowUserToAddRows = false;
            this.PayGrid.AllowUserToDeleteRows = false;
            this.PayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayGrid.Location = new System.Drawing.Point(397, 175);
            this.PayGrid.Name = "PayGrid";
            this.PayGrid.ReadOnly = true;
            this.PayGrid.Size = new System.Drawing.Size(623, 339);
            this.PayGrid.TabIndex = 80;
            this.PayGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PayGrid_CellClick);
            this.PayGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PayGrid_CellContentClick);
            // 
            // paymentDataSet
            // 
            this.paymentDataSet.DataSetName = "PaymentDataSet";
            this.paymentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1037, 638);
            this.Controls.Add(this.PayGrid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPId);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtCBal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRecNow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeadPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtTotalAmt);
            this.Controls.Add(this.txtRemBal);
            this.Controls.Add(this.txtRecAmt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustName);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel2.ResumeLayout(false);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCBal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRecNow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPIdSearch;
        private System.Windows.Forms.TextBox txtSearchCid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearchPid;
        private System.Windows.Forms.Button btnCustSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtTotalAmt;
        private System.Windows.Forms.TextBox txtRemBal;
        private System.Windows.Forms.TextBox txtRecAmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.DataGridView PayGrid;
        private PaymentDataSet paymentDataSet;
    }
}