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
    public partial class LoginForm : Form
    {
        Class1 c = new Class1();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbllogin where UserName=@u and Password=@p",c.con);
            cmd.Parameters.AddWithValue("@u",txtuser.Text);
            cmd.Parameters.AddWithValue("@p",txtpass.Text);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                this.Hide();
                Class1.mainform();
            }
            else
            {
                MessageBox.Show("User Name or Password is Incorrect");
                txtpass.Clear();
                txtuser.Clear();
                txtuser.Focus();
            }
            c.con.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.UseMnemonic = false;
            label1.Text = "Welcome To Z&B Designs";
        }
        
    }
}
