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
    public partial class CustomerForm : Form
    {
        Class1 c = new Class1();
        ToolTip t = new ToolTip();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public CustomerForm()
        {
            InitializeComponent();
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
            txtSearchid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl = new AutoCompleteStringCollection();
            txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection cl1 = new AutoCompleteStringCollection();
            cmd = new SqlCommand("SpCust", c.con);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cl.Add(dr[0].ToString());
                cl1.Add(dr[1].ToString());
            }
            txtSearchid.AutoCompleteCustomSource = cl;
            txtSearchName.AutoCompleteCustomSource = cl1;
            c.con.Close();
        }

        private void SetButton()
        {
            btnUpdate.Enabled = (txtCustName.Text != "" || txtCustName.Visible == false) && (txtCustPhone.Text != "" || txtCustPhone.Visible == false) && (txtEdge.Text != "" || txtEdge.Visible == false) && (txtShoulder.Text != "" || txtShoulder.Visible == false);
            btnDelete.Enabled = (txtCustName.Text != "" || txtCustName.Visible == false) && (txtCustPhone.Text != "" || txtCustPhone.Visible == false) && (txtEdge.Text != "" || txtEdge.Visible == false) && (txtShoulder.Text != "" || txtShoulder.Visible == false);
            btnClear.Enabled = (txtCustName.Text != "" || txtCustName.Visible == false) && (txtCustPhone.Text != "" || txtCustPhone.Visible == false) && (txtEdge.Text != "" || txtEdge.Visible == false) && (txtShoulder.Text != "" || txtShoulder.Visible == false);
        }

        public void clear()
        {
           lblCustId.Text = "";
            txtCustName.Clear();
            txtCustAdress.Clear();
            txtCustPhone.Clear();
            txtLength.Clear();
            txtWidth.Clear();
            txtSleeve.Clear();
            txtCollar.Clear();
            txtPocket.Clear();
            txtCuff.Clear();
            txtBottom.Clear();
            txtEdge.Clear();
            txtChest.Clear();
            txtHip.Clear();
            txtNeck.Clear();
            txtShoulder.Clear();
            txtTrouser.Clear();
            txtEmail.Text = "";
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {
            showdata();
            autoComplete();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            lblCustId.ForeColor = System.Drawing.Color.White;
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.mainform();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.addnewcust();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.con.Open();
            try
            {
                cmd = new SqlCommand("spCustUpdate", c.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", lblCustId.Text.ToString());
                cmd.Parameters.AddWithValue("@cn", txtCustName.Text);
                cmd.Parameters.AddWithValue("@cad", txtCustAdress.Text);
                cmd.Parameters.AddWithValue("@cph", txtCustPhone.Text);
                cmd.Parameters.AddWithValue("@eml", txtEmail.Text);
                cmd.Parameters.AddWithValue("@l", txtLength.Text.ToString());
                cmd.Parameters.AddWithValue("@w", txtWidth.Text.ToString());
                cmd.Parameters.AddWithValue("@sl", txtSleeve.Text.ToString());
                cmd.Parameters.AddWithValue("@col", txtCollar.Text.ToString());
                cmd.Parameters.AddWithValue("@po", txtPocket.Text.ToString());
                cmd.Parameters.AddWithValue("@cuf", txtCuff.Text.ToString());
                cmd.Parameters.AddWithValue("@b", txtBottom.Text.ToString());
                cmd.Parameters.AddWithValue("@e", txtEdge.Text.ToString());
                cmd.Parameters.AddWithValue("@ch", txtChest.Text.ToString());
                cmd.Parameters.AddWithValue("@hip", txtHip.Text.ToString());
                cmd.Parameters.AddWithValue("@nec", txtNeck.Text.ToString());
                cmd.Parameters.AddWithValue("@sh", txtShoulder.Text.ToString());
                cmd.Parameters.AddWithValue("@tr", txtTrouser.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("The data is Updated or saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Failed");
            }
            finally
            {
                c.con.Close();
            }
            showdata();
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("FindCustomer", c.con);
            cmd.Parameters.AddWithValue("@Cid", txtSearchid.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblCustId.Text = dr[0].ToString();
                txtCustName.Text = dr[1].ToString();
                txtCustAdress.Text = dr[2].ToString();
                txtEmail.Text = dr[3].ToString();
                txtCustPhone.Text = dr[4].ToString();
                txtLength.Text = dr[5].ToString();
                txtWidth.Text = dr[6].ToString();
                txtSleeve.Text = dr[7].ToString();
                txtCollar.Text = dr[8].ToString();
                txtPocket.Text = dr[9].ToString();
                txtCuff.Text = dr[10].ToString();
                txtBottom.Text = dr[11].ToString();
                txtEdge.Text = dr[12].ToString();
                txtChest.Text = dr[13].ToString();
                txtHip.Text = dr[14].ToString();
                txtNeck.Text = dr[15].ToString();
                txtShoulder.Text = dr[16].ToString();
                txtTrouser.Text = dr[17].ToString();
            }
            c.con.Close();
        }

        private void CustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCustId.Text = CustomerView.CurrentRow.Cells["Cid"].Value.ToString();
            txtCustName.Text = CustomerView.CurrentRow.Cells["Cname"].Value.ToString();
            txtCustAdress.Text = CustomerView.CurrentRow.Cells["Adress"].Value.ToString();
            txtCustPhone.Text = CustomerView.CurrentRow.Cells["Phone"].Value.ToString();
            txtEmail.Text = CustomerView.CurrentRow.Cells["Email"].Value.ToString();
            txtLength.Text = CustomerView.CurrentRow.Cells["Length"].Value.ToString();
            txtWidth.Text = CustomerView.CurrentRow.Cells["Width"].Value.ToString();
            txtSleeve.Text = CustomerView.CurrentRow.Cells["Sleeve"].Value.ToString();
            txtCollar.Text = CustomerView.CurrentRow.Cells["Collar"].Value.ToString();
            txtPocket.Text = CustomerView.CurrentRow.Cells["Pocket"].Value.ToString();
            txtCuff.Text = CustomerView.CurrentRow.Cells["Cuff"].Value.ToString();
            txtBottom.Text = CustomerView.CurrentRow.Cells["Bottom"].Value.ToString();
            txtEdge.Text = CustomerView.CurrentRow.Cells["Edge"].Value.ToString();
            txtChest.Text = CustomerView.CurrentRow.Cells["Chest"].Value.ToString();
            txtHip.Text = CustomerView.CurrentRow.Cells["Hip"].Value.ToString();
            txtNeck.Text = CustomerView.CurrentRow.Cells["Neck"].Value.ToString();
            txtShoulder.Text = CustomerView.CurrentRow.Cells["Shoulder"].Value.ToString();
            txtTrouser.Text = CustomerView.CurrentRow.Cells["Trouser"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("spCustDelete", c.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", lblCustId.Text.ToString());
            c.con.Open();
            cmd.ExecuteNonQuery();
            c.con.Close();
            MessageBox.Show("The data is Deleted");
            showdata();
            clear();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Cname like '%" + txtSearchName.Text + "%' ");
            CustomerView.DataSource = dv.ToTable();
        }

        private void txtCustPhone_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtEdge_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtShoulder_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtCharVal(e);
            t.Show(c.name, txtCustName);
        }

        private void txtCustPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtCustPhone);
        }

        private void txtSearchid_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtSearchid);
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtCharVal(e);
            t.Show(c.name, txtSearchName);
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtLength);
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtWidth);
        }

        private void txtSleeve_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtSleeve);
        }

        private void txtCollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtCollar);
        }

        private void txtPocket_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtPocket);
        }

        private void txtCuff_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtCuff);
        }

        private void txtBottom_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtBottom);
        }

        private void txtEdge_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtEdge);
        }

        private void txtChest_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtChest);
        }

        private void txtHip_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtHip);
        }

        private void txtNeck_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtNeck);
        }

        private void txtShoulder_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtShoulder);
        }

        private void txtTrouser_KeyPress(object sender, KeyPressEventArgs e)
        {
            c.txtIntVal(e);
            t.Show(c.tid, txtTrouser);
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }
        



    }
}
