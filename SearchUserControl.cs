using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kadoma_City_Council
{
    public partial class SearchUserControl : UserControl
    {
        public SearchUserControl()
        {
            InitializeComponent();
        }

        private void LollipopButton1_Click(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            String sqlSelectQuery = "SELECT nID FROM Members WHERE Name=" + textBox1.Text;
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = (dr["nID"].ToString());
                con.Close();
            }
        }
    }
}
