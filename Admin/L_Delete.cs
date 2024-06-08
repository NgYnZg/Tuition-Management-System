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
    public partial class L_Delete : Form
    {
        public L_Delete()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select Count(UserId) from Student;", con);
            string maxx = cmd2.ExecuteScalar().ToString();
            int max = int.Parse(maxx);
            string[] Names = new string[max];
            


            Lecturer StudentUpdate = new Lecturer();
            StudentUpdate.StudentName(Names, max);


            for (int i = 0; i < max; i++)
                cb_Name.Items.Add(Names[i]);
        }

        private void cb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_del1_Click(object sender, EventArgs e)
        {
           
                DialogResult myResult = MessageBox.Show("Are you sure you want to delete this role?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                   string Name = cb_Name.Text;
                    Lecturer Delete = new Lecturer();
                    Delete.DeleteStudent(Name);
                }
                else
                {
                  
                }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gb_del_Enter(object sender, EventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
