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
    public partial class AddNewCustomer : Form
    {
        Class1 c = new Class1();
        ToolTip t = new ToolTip();
        SqlCommand cmd;
        
        public AddNewCustomer()
        {
            InitializeComponent();
        }

        public void autoid()
        {
            c.con.Open();
            cmd = new SqlCommand("Select max(Cid)+1 from Cust_info", c.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string id;
                id = dr[0].ToString();
                if (id.Equals(""))
                {
                    lblCustId.Text = "1";
                }
                else
                {
                    lblCustId.Text = id;
                }
            }
            c.con.Close();
        }

        private void SetButton()
        {
            btnCustAdd.Enabled = (txtCustName.Text != "" || txtCustName.Visible == false) && (txtCustPhone.Text != "" || txtCustPhone.Visible == false) && (txtEdge.Text != "" || txtEdge.Visible == false) && (txtShoulder.Text != "" || txtShoulder.Visible == false);
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


        private void AddNewCustomer_Load(object sender, EventArgs e)
        {
            btnCustAdd.Enabled = false;
            btnClear.Enabled = false;
            autoid();
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class1.mainform();
        }

        private void btnCustAdd_Click(object sender, EventArgs e)
        {
            c.con.Open();
            try
            {
                cmd = new SqlCommand("spCustInsert", c.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cid", lblCustId.Text.ToString());
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            autoid();
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
