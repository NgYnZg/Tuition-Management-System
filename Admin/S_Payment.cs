using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student
{
    

    public partial class S_Payment : Form
    {
        private string username;
        private int userid;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public S_Payment()
        {
            InitializeComponent();
        }

        public S_Payment(string un, int uid)
        {
            InitializeComponent();
            username = un;
            userid = uid;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(username, userid);
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Class WHERE ClassID = @ClassID"; // Use parameterized query
            cmd.Parameters.AddWithValue("@ClassID", textBox1.Text); // Add parameter value

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Class SET Fee = 0 WHERE ClassID = @ClassID";
            cmd.Parameters.AddWithValue("@ClassID", textBox1.Text);

            int rowsAffected = cmd.ExecuteNonQuery();

            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Thank You for Your Payment");
            }
            else
            {
                MessageBox.Show("Payment has not been updated");
            }
            this.Hide();
            Form1 form1 = new Form1(username, userid);
            form1.ShowDialog();
        }

    }
}
