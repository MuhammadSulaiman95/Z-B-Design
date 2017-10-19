using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZBDesigns
{
    public partial class OrderForm : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        ToolTip t = new ToolTip();
        Class1 c = new Class1();
        public OrderForm()
        {
            InitializeComponent();
        }

        public void autoid()
        {
            c.con.Open();
            cmd = new SqlCommand("Select max(InvNo)+1 from tblOrder", c.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string id;
                id = dr[0].ToString();
                if (id.Equals(""))
                {
                    lblInv.Text = "INV1";
                }
                else
                {
                    lblInv.Text = id;
                }
            }
            c.con.Close();

        }

        public void showdata()
        {
            cmd = new SqlCommand("spCustSelect", c.con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            CustomerView.DataSource = dt;
        }

        public void autoComplete()
        {
            txtCustId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCustId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl1 = new AutoCompleteStringCollection();
            txtCustName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCustName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl2 = new AutoCompleteStringCollection();
            cmd = new SqlCommand("SpCust", c.con);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cl.Add(dr[0].ToString());
                cl1.Add(dr[1].ToString());
                cl2.Add(dr[1].ToString());
            }
            txtCustId.AutoCompleteCustomSource = cl;
            txtSearchName.AutoCompleteCustomSource = cl1;
            txtCustName.AutoCompleteCustomSource = cl2;
            c.con.Close();
        }

        private void SetButton()
        {
            btnCustAdd.Enabled = (txtCustId.Text != "" || txtCustId.Visible == false) && (txtCustName.Text != "" || txtCustName.Visible == false) && (txtOrderQty.Text != "" || txtOrderQty.Visible == false) && (txtTotalAmt.Text != "" || txtTotalAmt.Visible == false) && (txtAdvAmt.Text != "" || txtAdvAmt.Visible == false);
            btnClear.Enabled = (txtCustId.Text != "" || txtCustId.Visible == false) && (txtOrderQty.Text != "" || txtOrderQty.Visible == false) && (txtTotalAmt.Text != "" || txtTotalAmt.Visible == false) && (txtAdvAmt.Text != "" || txtAdvAmt.Visible == false);
        }

        public void clear()
        {
            txtCustId.Clear();
            txtCustName.Clear();
            txtOrderQty.Clear();
            cmbCategory.ResetText();
            orderDate.ResetText();
            OrderDDate.ResetText();
            txtTotalAmt.Clear();
            txtAdvAmt.Clear();
            txtRemainBal.Clear();
            txtRemarks.Clear();
            txtCBal.Clear();
        }


        private void OrderForm_Load(object sender, EventArgs e)
        {
            btnCustAdd.Enabled = false;
            btnClear.Enabled = false;
            btnPrint.Enabled = false;
            autoid();
            autoComplete();
            showdata();
            lblInv.ForeColor = System.Drawing.Color.White;
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.mainform();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            autoid();
            btnPrint.Enabled = false;
        }

        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            orderDate.Format = DateTimePickerFormat.Custom;
            orderDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            c.con.Open();
            try
            {
                cmd = new SqlCommand("spOrderInsert", c.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@inv", lblInv.Text.ToString());
                cmd.Parameters.AddWithValue("@cid", txtCustId.Text.ToString());
                cmd.Parameters.AddWithValue("@cname", txtCustName.Text);
                cmd.Parameters.AddWithValue("@oqty", txtOrderQty.Text);
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@dat", orderDate.Value.ToString());
                cmd.Parameters.AddWithValue("@dudat", OrderDDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@tamt", txtTotalAmt.Text.ToString());
                cmd.Parameters.AddWithValue("@aamt", txtAdvAmt.Text.ToString());
                cmd.Parameters.AddWithValue("@rbal", txtRemainBal.Text.ToString());
                cmd.Parameters.AddWithValue("@rem", txtRemarks.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("The data is inserted or saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Failed");
            }
            finally
            {
                c.con.Close();
            }
            btnPrint.Enabled = true;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Cname like '%" + txtSearchName.Text + "%' ");
            CustomerView.DataSource = dv.ToTable();
        }

        private void txtCustName_Leave(object sender, EventArgs e)
        {
            c.con.Open();
            cmd = new SqlCommand("select sum(TotalAmt)-sum(RecAmt) from tblSale where Cname='" + txtCustName.Text + "'", c.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (txtCustName.Text!="")
            {
                while (dr.Read())
                {
                    txtCBal.Text = (dr[0].ToString());
                }
            if(txtCBal.Text=="")
            {
                txtCBal.Text = "0";
            }
            }
            else
            {
                txtCBal.Text = "0";
            }
            c.con.Close();
        }

        private void txtAdvAmt_Leave(object sender, EventArgs e)
        {
            decimal c;
            if (decimal.TryParse(txtTotalAmt.Text, out c) && decimal.TryParse(txtAdvAmt.Text, out c))
            {
                txtRemainBal.Text = (decimal.Parse(txtTotalAmt.Text) - decimal.Parse(txtAdvAmt.Text)).ToString();
                lblCurBal.Text = (decimal.Parse(txtCBal.Text) + decimal.Parse(txtRemainBal.Text)).ToString();
            }
            else if(txtCustName.Text=="")
            {
                MessageBox.Show("Insert Customer Name Please");
                txtTotalAmt.Clear();
                txtAdvAmt.Clear();
            }
            else
            {
                MessageBox.Show("wrong value");
                txtTotalAmt.Clear();
                txtAdvAmt.Clear();
            }
        }

        private void OrderDDate_Leave(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(orderDate.Value.ToString());
            DateTime ddt = DateTime.Parse(OrderDDate.Value.ToString());

            if (ddt < dt)
            {
                MessageBox.Show("Due Date is less than Order Date");
                OrderDDate.ResetText();
            }
        }

        private void txtCustId_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtOrderQty_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtTotalAmt_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtAdvAmt_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtCustId_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtCustId);
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtCharVal(e);
            t.Show(c.name, txtCustName);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RptInvoice rp = new RptInvoice(int.Parse(lblInv.Text.ToString()));
            rp.Show();
        }


    }
}
