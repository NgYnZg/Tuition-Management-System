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

namespace Student
{
    public partial class Form2 : Form
    {
        private string username;
        private int userid;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string un, int uid)
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



        private void displayButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT C.TrainerID, lm.IntakeMonth, c.StartTime, c.Endtime FROM Class C, level_module lm WHERE c.classid = lm.classid and lm.ClassID = @ClassID";
            cmd.Parameters.AddWithValue("@ClassID", textBox1.Text); // Assuming textBox1 contains the ClassID value

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            // Remove the "Fee" column from the DataTable
            //dt.Columns.Remove("Fee");

            dataGridView1.DataSource = dt;
            con.Close();

        }



    }
}
