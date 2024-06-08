using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Admin
{
    public partial class A_Update_Profile : Form
    {
        private string username;
        public A_Update_Profile()
        {
            InitializeComponent();
        }

        public A_Update_Profile(string name)
        {
            InitializeComponent();
            username = name;
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {
            lblName.Text = username;
            lblName2.Text = username;
            Admin admin = new Admin(username);
            lblEmail.Text = admin.getEmail();
            lblPhoneNumber.Text = admin.getPhoneNumber();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newemail = txtEmail.Text;
            string newPhoneNumber = txtPhoneNumber.Text;

            if (ValidateEmail(newemail) && ValidatePhoneNumber(newPhoneNumber))
            {
                Admin admin = new Admin(username);
                MessageBox.Show(admin.updateProfile(txtEmail.Text, txtPhoneNumber.Text));
                lblEmail.Text = admin.getEmail();
                lblPhoneNumber.Text = admin.getPhoneNumber();
                txtEmail.Clear();
                txtPhoneNumber.Clear();
            }
            else 
            {
                MessageBox.Show("Invalid email address format or phone number format");
            }
        }

        private bool ValidateEmail(string email)
        {
            string format = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            bool correct = Regex.IsMatch(email, format);

            return correct;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            string format = @"^\d{10}$";

            bool correct = Regex.IsMatch(phoneNumber, format);

            return correct;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
