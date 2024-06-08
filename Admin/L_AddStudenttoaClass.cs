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
    public partial class L_AddStudenttoaClass : Form
    {
        public L_AddStudenttoaClass()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select Count(UserID) from Student;", con);
            string maxx = cmd2.ExecuteScalar().ToString();
            int max = int.Parse(maxx);
            string[] Names = new string[max];



            Lecturer StudentUpdate = new Lecturer();
            StudentUpdate.StudentName(Names, max);


            for (int i = 0; i < max; i++)
                cb_name.Items.Add(Names[i]);
        }

        private void lbl_lvl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Lecturer Assign = new Lecturer();
            Assign.AssignStudent(cb_name.Text, cb_level.Text, cb_module.Text, cb_IM.Text);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
