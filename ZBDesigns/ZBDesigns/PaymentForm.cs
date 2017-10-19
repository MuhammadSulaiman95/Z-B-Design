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
    public partial class PaymentForm : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        ToolTip t = new ToolTip();
        Class1 c = new Class1();
        public PaymentForm()
        {
            InitializeComponent();
        }

        public void autoid()
        {
            c.con.Open();
            cmd = new SqlCommand("select max(Pid)+1 from tblPayment", c.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string id;
                id = dr[0].ToString();
                if (id.Equals(""))
                {
                    txtPId.Text = "1";
                }
                else
                {
                    txtPId.Text = id;
                }
            }
            c.con.Close();
        }

        public void showdata()
        {
            cmd = new SqlCommand("spPaymentSelect", c.con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            PayGrid.DataSource = dt;
        }

        public void autoComplete()
        {
            txtSearchCid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchCid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl1 = new AutoCompleteStringCollection();
            txtSearchPid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchPid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl2 = new AutoCompleteStringCollection();
            cmd = new SqlCommand("spAutoPayment", c.con);
            cmd.CommandType = CommandType.StoredProcedure;
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cl.Add(dr[0].ToString());
                cl1.Add(dr[1].ToString());
                cl2.Add(dr[2].ToString());
            }
            txtSearchCid.AutoCompleteCustomSource = cl;
            txtSearchName.AutoCompleteCustomSource = cl1;
            txtSearchPid.AutoCompleteCustomSource = cl2;
            c.con.Close();
        }

        private void SetButton()
        {
            btnAdd.Enabled = (txtPId.Text != "" || txtPId.Visible == false) && (txtCustId.Text != "" || txtCustId.Visible == false) && (txtCustName.Text != "" || txtCustName.Visible == false) && (txtRecNow.Text != "" || txtRecNow.Visible == false);
        }

        public void clear()
        {
            txtCustId.Text = "";
            txtCustName.Text = "";
            txtCustPhone.Text = "";
            txtTotalAmt.Text = "";
            txtRecAmt.Text = "";
            txtRecNow.Text = "";
            txtRemBal.Text = "";
            txtdate.ResetText();
            txtCBal.Text = "";
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            autoid();
            showdata();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            autoComplete();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.con.Open();
            SqlTransaction tra = c.con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("spPaymentInsert", c.con, tra);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pid", txtPId.Text.ToString());
                cmd.Parameters.AddWithValue("@Cid", txtCustId.Text.ToString());
                cmd.Parameters.AddWithValue("@Cname", txtCustName.Text);
                cmd.Parameters.AddWithValue("@Cphone", txtCustPhone.Text);
                cmd.Parameters.AddWithValue("@TAmt", txtTotalAmt.Text.ToString());
                cmd.Parameters.AddWithValue("@RAmt", txtRecAmt.Text.ToString());
                cmd.Parameters.AddWithValue("@cbal", txtCBal.Text.ToString());
                cmd.Parameters.AddWithValue("@RNow", txtRecNow.Text.ToString());
                cmd.Parameters.AddWithValue("@RBal", txtRemBal.Text.ToString());
                cmd.Parameters.AddWithValue("@DateIn", txtdate.Value.ToString());
                cmd.ExecuteNonQuery();
                tra.Commit();
                MessageBox.Show("The data is inserted or saved");
                btnPrint.Enabled = true;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.con.Open();
            SqlTransaction tra = c.con.BeginTransaction();
            try
            {
                cmd = new SqlCommand("spPaymentUpdate", c.con, tra);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pid", txtPId.Text.ToString());
                cmd.Parameters.AddWithValue("@Cid", txtCustId.Text.ToString());
                cmd.Parameters.AddWithValue("@Cname", txtCustName.Text);
                cmd.Parameters.AddWithValue("@Cphone", txtCustPhone.Text);
                cmd.Parameters.AddWithValue("@TAmt", txtTotalAmt.Text.ToString());
                cmd.Parameters.AddWithValue("@RAmt", txtRecAmt.Text.ToString());
                cmd.Parameters.AddWithValue("@cbal", txtCBal.Text.ToString());
                cmd.Parameters.AddWithValue("@RNow", txtRecNow.Text.ToString());
                cmd.Parameters.AddWithValue("@RBal", txtRemBal.Text.ToString());
                cmd.Parameters.AddWithValue("@DateIn", txtdate.Value.ToString());
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
            cmd = new SqlCommand("spPaymentDelete", c.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Pid", txtPId.Text);
            c.con.Open();
            cmd.ExecuteNonQuery();
            c.con.Close();
            MessageBox.Show("The data is Deleted");
            showdata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            autoid();
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            autoid();
            cmd = new SqlCommand("FindPayment", c.con);
            cmd.Parameters.AddWithValue("@cid", txtSearchCid.Text);
            cmd.Parameters.AddWithValue("@cname", txtSearchName.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtCustId.Text = dr[0].ToString();
                txtCustName.Text = dr[1].ToString();
                txtTotalAmt.Text = dr[2].ToString();
                txtRecAmt.Text = dr[3].ToString();
            }
            c.con.Close();
            decimal d;
            d = decimal.Parse(txtTotalAmt.Text) - decimal.Parse(txtRecAmt.Text);
            txtCBal.Text = d.ToString();
            btnAdd.Visible = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnClear.Enabled = true;
            txtRecNow.Text = "";
            txtdate.ResetText();
            txtRemBal.Text = "";
            txtSearchPid.Text = "";
        }

        private void btnPIdSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("FindPaymentId", c.con);
            cmd.Parameters.AddWithValue("@pid", txtSearchPid.Text.ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtPId.Text = dr[0].ToString();
                txtCustId.Text = dr[1].ToString();
                txtCustName.Text = dr[2].ToString();
                txtCustPhone.Text = dr[3].ToString();
                txtTotalAmt.Text = dr[4].ToString();
                txtRecAmt.Text = dr[5].ToString();
                txtCBal.Text = dr[6].ToString();
                txtRecNow.Text = dr[7].ToString();
                txtRemBal.Text = dr[8].ToString();
                txtdate.Text = dr[9].ToString();
            }
            c.con.Close();
            btnAdd.Visible = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            txtSearchCid.Text = "";
            txtSearchName.Text = "";
            btnPrint.Enabled = true;
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.mainform();
        }

        private void txtPId_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtCustId_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtCustPhone_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtRecNow_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtRecNow_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtRecNow);
        }

        private void txtSearchPid_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtSearchPid);
        }

        private void txtSearchCid_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtSearchCid);
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtCharVal(e);
            t.Show(c.name, txtSearchName);
        }

        private void txtRecNow_Leave(object sender, EventArgs e)
        {
            decimal c;
            if (decimal.TryParse(txtTotalAmt.Text, out c) && decimal.TryParse(txtRecAmt.Text, out c) && decimal.TryParse(txtRecNow.Text, out c))
            {
                c = decimal.Parse(txtTotalAmt.Text) - decimal.Parse(txtRecAmt.Text) - decimal.Parse(txtRecNow.Text);
                txtRemBal.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("wrong value");
                txtRecNow.Text = "";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RptPayment rpt = new RptPayment(int.Parse(txtPId.Text));
            rpt.Show();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Cname like '%" + txtSearchName.Text + "%' ");
            PayGrid.DataSource = dv.ToTable();
        }

        private void PayGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PayGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPId.Text = PayGrid.CurrentRow.Cells["Pid"].Value.ToString();
            txtCustId.Text = PayGrid.CurrentRow.Cells["Cid"].Value.ToString();
            txtCustName.Text = PayGrid.CurrentRow.Cells["Cname"].Value.ToString();
            txtCustPhone.Text = PayGrid.CurrentRow.Cells["CPhone"].Value.ToString();
            txtTotalAmt.Text = PayGrid.CurrentRow.Cells["TAmt"].Value.ToString();
            txtRecAmt.Text = PayGrid.CurrentRow.Cells["RAmt"].Value.ToString();
            txtCBal.Text = PayGrid.CurrentRow.Cells["CurBal"].Value.ToString();
            txtRecNow.Text = PayGrid.CurrentRow.Cells["RNow"].Value.ToString();
            txtRemBal.Text = PayGrid.CurrentRow.Cells["RBal"].Value.ToString();
            txtdate.Text = PayGrid.CurrentRow.Cells["DateIn"].Value.ToString();
            btnPrint.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }



    }
}
