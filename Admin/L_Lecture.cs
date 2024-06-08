using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecturer
{
    public partial class LecMainMenu : Form
    {
        private string username;
        private int id;
        public LecMainMenu()
        {
            InitializeComponent();
        }

        public LecMainMenu(string username, int id)
        {
            InitializeComponent();
            this.username = username;
            this.id = id;
            
        }

            private void LecMainMenu_Load(object sender, EventArgs e)
        {
            string capitalizedUsername = char.ToUpper(username[0]) + username.Substring(1);
            lblname.Text = capitalizedUsername;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            L_LecUpdateProfile frm = new L_LecUpdateProfile(username, id);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegS frm = new RegS();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            L_UpdateEn frm = new L_UpdateEn();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            L_Delete frm = new L_Delete();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            L_Requests frm = new L_Requests ();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            L_LecUpdateProfile frm = new L_LecUpdateProfile(username, id);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            L_LecUpdateProfile frm = new L_LecUpdateProfile( username, id);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            L_AddStudenttoaClass frm = new L_AddStudenttoaClass();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
