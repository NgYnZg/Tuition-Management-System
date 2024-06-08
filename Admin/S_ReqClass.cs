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
    public partial class Edit_Request : Form
    {

        private string username;
        private int userid;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public Edit_Request()
        {
            InitializeComponent();
        }
        public Edit_Request(string un, int uid)
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
        

        private void Edit_Request_Load(object sender, EventArgs e)
        {
            disp_data();
            lblStudentID.Text = userid.ToString();
            lblStudentName.Text = username;
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Request";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                // Insert the record
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Request (StudentID, LecturerID, ClassRequest) VALUES (@StudentID, @LecturerID, @ClassRequest)";
                cmd.Parameters.AddWithValue("@StudentID", userid);
                cmd.Parameters.AddWithValue("@LecturerID", textBox4.Text);
                cmd.Parameters.AddWithValue("@StudentName", username);
                cmd.Parameters.AddWithValue("@ClassRequest", textBox2.Text);
                cmd.ExecuteNonQuery();


                con.Close();
                disp_data();
                MessageBox.Show("Record inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Request WHERE StudentName = '" + username + "'";
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                disp_data();
                MessageBox.Show("Record deleted successfully.");
            }
            else
            {
                MessageBox.Show("No records found with the given StudentName. Deletion canceled.");
            }
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
