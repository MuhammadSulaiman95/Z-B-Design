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
    public partial class OrderView : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string chk;
        string chkr;
        ToolTip t = new ToolTip();
        Class1 c = new Class1();
        public OrderView()
        {
            InitializeComponent();
        }

        public void showdata()
        {
            cmd = new SqlCommand("spOrderSelect", c.con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            OrderData.DataSource = dt;
        }


        public void autoComplete()
        {
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl1 = new AutoCompleteStringCollection();
            cmd = new SqlCommand("Spinv", c.con);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cl.Add(dr[0].ToString());
                cl1.Add(dr[1].ToString());
            }
            txtSearch.AutoCompleteCustomSource = cl;
            txtSearchName.AutoCompleteCustomSource = cl1;
            c.con.Close();
        }

        private void SetButton()
        {
            btnUpdate.Enabled = (txtCustName.Text != "" || txtCustName.Visible == false) && (txtOrderQty.Text != "" || txtOrderQty.Visible == false) && (txtTotalAmt.Text != "" || txtTotalAmt.Visible == false) && (txtAdvAmt.Text != "" || txtAdvAmt.Visible == false);
            btnDelete.Enabled = (txtCustName.Text != "" || txtCustName.Visible == false) && (txtOrderQty.Text != "" || txtOrderQty.Visible == false) && (txtTotalAmt.Text != "" || txtTotalAmt.Visible == false) && (txtAdvAmt.Text != "" || txtAdvAmt.Visible == false);
            btnClear.Enabled = (txtCustName.Text != "" || txtCustName.Visible == false) && (txtOrderQty.Text != "" || txtOrderQty.Visible == false) && (txtTotalAmt.Text != "" || txtTotalAmt.Visible == false) && (txtAdvAmt.Text != "" || txtAdvAmt.Visible == false);
            btnPrint.Enabled = (txtCustName.Text != "" || txtCustName.Visible == false) && (txtOrderQty.Text != "" || txtOrderQty.Visible == false) && (txtTotalAmt.Text != "" || txtTotalAmt.Visible == false) && (txtAdvAmt.Text != "" || txtAdvAmt.Visible == false);
        }

        public void chkbx()
        {
            if (chk == "True" && chkr == "True")
            {
                chkDel.Checked = true;
                chkReady.Checked = true;
            }
            else if (chk == "False" && chkr == "False")
            {
                chkDel.Checked = false;
                chkReady.Checked = false;
            }
            else if (chkr == "False" || chk == "True")
            {
                chkDel.Checked = true;
                chkReady.Checked = false;
            }
            else if (chk == "False" && chkr == "True")
            {
                chkDel.Checked = false;
                chkReady.Checked = true;
            }
            else
            {
                chkDel.Checked = false;
                chkReady.Checked = false;
            }
        }

        public void clear()
        {
            lblCustId.Text = "";
            txtCustName.Clear();
            txtOrderQty.Clear();
            txtCategory.Clear();
            orderDate.ResetText();
            OrderDDate.ResetText();
            txtTotalAmt.Clear();
            txtAdvAmt.Clear();
            txtRemainBal.Clear();
            txtRemarks.Clear();
            chkDel.Checked = false;
            chkReady.Checked = false;
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            showdata();
            autoComplete();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnPrint.Enabled = false;
            lblInv.ForeColor = System.Drawing.Color.White;
            lblCustId.ForeColor = System.Drawing.Color.White;
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.mainform();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.orderform();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void OrderData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblInv.Text = OrderData.CurrentRow.Cells["InvNo"].Value.ToString();
            lblCustId.Text = OrderData.CurrentRow.Cells["Cid"].Value.ToString();
            txtCustName.Text = OrderData.CurrentRow.Cells["Cname"].Value.ToString();
            txtOrderQty.Text = OrderData.CurrentRow.Cells["OQty"].Value.ToString();
            txtCategory.Text = OrderData.CurrentRow.Cells["Category"].Value.ToString();
            orderDate.Text = OrderData.CurrentRow.Cells["ODate"].Value.ToString();
            OrderDDate.Text = OrderData.CurrentRow.Cells["DueDate"].Value.ToString();
            txtTotalAmt.Text = OrderData.CurrentRow.Cells["TAmt"].Value.ToString();
            txtAdvAmt.Text = OrderData.CurrentRow.Cells["AAmt"].Value.ToString();
            txtRemainBal.Text = OrderData.CurrentRow.Cells["RBal"].Value.ToString();
            txtRemarks.Text = OrderData.CurrentRow.Cells["Remarks"].Value.ToString();
            chk = OrderData.CurrentRow.Cells["Delievered"].Value.ToString();
            chkr = OrderData.CurrentRow.Cells["IsReady"].Value.ToString();
            chkbx();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Cname like '%" + txtSearchName.Text + "%' ");
            OrderData.DataSource = dv.ToTable();
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("FindOrder", c.con);
            cmd.Parameters.AddWithValue("@inv", txtSearch.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblInv.Text = dr[0].ToString();
                lblCustId.Text = dr[1].ToString();
                txtCustName.Text = dr[2].ToString();
                txtOrderQty.Text = dr[3].ToString();
                txtCategory.Text = dr[4].ToString();
                orderDate.Text = dr[5].ToString();
                OrderDDate.Text = dr[6].ToString();
                txtTotalAmt.Text = dr[7].ToString();
                txtAdvAmt.Text = dr[8].ToString();
                txtRemainBal.Text = dr[9].ToString();
                txtRemarks.Text = dr[10].ToString();
                chk = dr[11].ToString();
                chkr = dr[12].ToString();
                chkbx();
            }
            c.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            orderDate.Format = DateTimePickerFormat.Custom;
            orderDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            c.con.Open();
            SqlTransaction tra = c.con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("spOrderupdate", c.con, tra);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@inv", lblInv.Text.ToString());
                cmd.Parameters.AddWithValue("@cid", lblCustId.Text.ToString());
                cmd.Parameters.AddWithValue("@cname", txtCustName.Text);
                cmd.Parameters.AddWithValue("@oqty", txtOrderQty.Text);
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
                cmd.Parameters.AddWithValue("@dat", orderDate.Value.ToString());
                cmd.Parameters.AddWithValue("@dudat", OrderDDate.Value.ToString());
                cmd.Parameters.AddWithValue("@tamt", txtTotalAmt.Text.ToString());
                cmd.Parameters.AddWithValue("@aamt", txtAdvAmt.Text.ToString());
                cmd.Parameters.AddWithValue("@rbal", txtRemainBal.Text.ToString());
                cmd.Parameters.AddWithValue("@rem", txtRemarks.Text.ToString());
                if (chkDel.Checked == true && chkReady.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@del", chkDel.Checked);
                    cmd.Parameters.AddWithValue("@rd", chkReady.Checked);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@del", chkDel.CheckState);
                    cmd.Parameters.AddWithValue("@rd", chkReady.CheckState);
                }
                cmd.ExecuteNonQuery();
                tra.Commit();
                MessageBox.Show("The data is Updated or saved");
            }
            catch (Exception ex)
            {
                tra.Rollback();
                MessageBox.Show(ex.Message + "Failed");
            }
            finally
            {
                c.con.Close();
            }
            showdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("spOrderDelete", c.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inv", lblInv.Text);
            c.con.Open();
            cmd.ExecuteNonQuery();
            c.con.Close();
            MessageBox.Show("The data is Deleted");
            showdata();
            clear();
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

        private void txtAdvAmt_Leave(object sender, EventArgs e)
        {
            decimal c;
            if (decimal.TryParse(txtTotalAmt.Text, out c) && decimal.TryParse(txtAdvAmt.Text, out c))
            {
                txtRemainBal.Text = (decimal.Parse(txtTotalAmt.Text) - decimal.Parse(txtAdvAmt.Text)).ToString();
            }
            else
            {
                MessageBox.Show("wrong value");
                txtTotalAmt.Clear();
                txtAdvAmt.Clear();
            }
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            RptInvoice rp = new RptInvoice(int.Parse(lblInv.Text.ToString()));
            rp.Show();
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtCharVal(e);
            t.Show(c.name, txtCustName);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtSearch);
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtCharVal(e);
            t.Show(c.name, txtSearchName);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void chkReady_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkDel_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkDel_CheckStateChanged(object sender, EventArgs e)
        {
           
        }

        private void chkDel_Leave(object sender, EventArgs e)
        {
            if (chkReady.Checked == false && chkDel.Checked == true)
            {
                MessageBox.Show("Please Check The Ready CheckBox");
                chkDel.Checked = false;
            }
            else
            {
                MessageBox.Show("ok");
            }
        }




    }
}
