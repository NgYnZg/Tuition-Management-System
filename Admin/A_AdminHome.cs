using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class A_AdminHome : Form
    {
        public static string username;
        public static int userid;
        public A_AdminHome()
        {
            InitializeComponent();
        }

        public A_AdminHome(string un, int uid)
        {
            InitializeComponent();
            username = un;
            userid = uid;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelc.Text = "Welcome " + username;
        }
        private void btnRegDel_Click(object sender, EventArgs e)
        {
            A_Register_Delete_Trainer rgt = new A_Register_Delete_Trainer();
            rgt.ShowDialog();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            A_View_Income vi = new A_View_Income();
            vi.ShowDialog();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            A_View_Feedback vf = new A_View_Feedback();
            vf.ShowDialog();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            A_Assign_Trainer at = new A_Assign_Trainer();
            at.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            A_Update_Profile up = new A_Update_Profile(username);
            up.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
