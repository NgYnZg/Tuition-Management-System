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

namespace Lecturer
{
    public partial class L_UpdateEn : Form
    {
        public L_UpdateEn()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select Count(UserID) from Student;", con);
            string maxx = cmd2.ExecuteScalar().ToString();
            int max = int.Parse(maxx);
            string[] Names = new string[max];
            
            
            
            Lecturer StudentUpdate = new Lecturer();
            StudentUpdate.StudentName(Names,max);
            

            for (int i = 0; i < max; i++)
                cb_Name.Items.Add(Names[i]);
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string Module = cb_module.Text;
            string Level = cb_level.Text;
            string Name = cb_Name.Text;
            Lecturer StudentUpdate = new Lecturer();
            StudentUpdate.UpdateModule( Level, Module, Name, cb_ID.Text);
            MessageBox.Show("Update succesfull");
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gb_Update_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateEn_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            cb_ID.Items.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            string Name = cb_Name.Text;
            SqlCommand cmd = new SqlCommand("Select UserID from Student where name = '" + Name + "';", con);
            int StudentID = (int)cmd.ExecuteScalar();
            SqlCommand cmd1 = new SqlCommand("Select ClassStudentID from Class_Student where StudentID = " + StudentID + ";",con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                cb_ID.Items.Add(dr.GetInt32(0));
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
