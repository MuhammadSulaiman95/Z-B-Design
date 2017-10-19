using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ZBDesigns
{
    class Class1
    {
        public string name = "Only Alphabets is Allowed";
        public string tid = "Only Number Is Allowed";
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ZBDesigns.Properties.Settings.cs"].ConnectionString);
        public static void mainform()
        {
            MainForm cf = new MainForm();
            cf.Show();
        }

        public static void customerform()
        {
            CustomerForm cf = new CustomerForm();
            cf.Show();
        }


        public static void addnewcust()
        {
            AddNewCustomer cf = new AddNewCustomer();
            cf.Show();
        }

        public static void orderform()
        {
            OrderForm cf = new OrderForm();
            cf.Show();
        }


        public static void orderview()
        {
            OrderView cf = new OrderView();
            cf.Show();
        }

        public static void PaymentForm()
        {
            PaymentForm cf = new PaymentForm();
            cf.Show();
        }

        public static void SaleSumForm()
        {
            SaleSummaryForm cf = new SaleSummaryForm();
            cf.Show();
        }

        public static void EmailForm()
        {
            EmailSending cf = new EmailSending();
            cf.Show();
        }

        public void txtIntVal(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        public void txtCharVal(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


    }
}
