using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Kadoma_City_Council
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conx = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Carlos\Documents\logindat.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("select  count(*) from users where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'and actype='USER'", conx);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main mm = new Main();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Login Credentials", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
