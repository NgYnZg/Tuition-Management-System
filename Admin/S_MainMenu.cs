using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {

        private string username;
        private int userid;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string un, int uid)
        {
            InitializeComponent();
            username = un;
            userid = uid;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Request edit_Request = new Edit_Request(username, userid);
            edit_Request.ShowDialog();
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            S_Payment payment = new S_Payment(username, userid);    
            payment.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(username, userid);
            f2.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Profile update_Profile = new Update_Profile(username, userid);
            update_Profile.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
