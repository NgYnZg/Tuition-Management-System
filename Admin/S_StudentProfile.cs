using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Student
{

    public partial class Update_Profile : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        private string username;
        private int userID;
        public Update_Profile()
        {
            InitializeComponent();
        }

        public Update_Profile(string un, int uid)
        {
            InitializeComponent();
            username = un;
            userID = uid;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(username, userID);
            form1.ShowDialog();
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {
            lblName.Text = username;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Student set Email='"+textBox2.Text+"' where userid='"+userID+"'";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update Student set PhoneNumber='" + textBox3.Text + "' where userid='" + userID+ "'";
            cmd2.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("record update successfuly");

            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
