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

namespace Lecturer
{
    public partial class L_LecUpdateProfile : Form
    {
        string username;
        int UserID;
        string PN;
        string Email;
        public L_LecUpdateProfile()
        {
            InitializeComponent();
            

        }
        public L_LecUpdateProfile( string username, int id)
        {
            InitializeComponent();
            this.username = username;
            this.UserID = id;

            

        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string phone = txt_PN.Text;

            if (ValidateEmail(email) && ValidatePhoneNumber(phone))
            {
                Lecturer Profile = new Lecturer();
            
                int NewPN = int.Parse(txt_PN.Text);
            
                Profile.UpdateProfile(username, UserID, txt_email.Text, NewPN );
                MessageBox.Show("Profile Updated");
                this.Close();
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

        private void L_LecUpdateProfile_Load(object sender, EventArgs e)
        {
            Lecturer Profile = new Lecturer();
            this.Email =Profile.LecturerEmail(username, UserID);
            this.PN =Profile.LecturerPN(username, UserID);
            
            lbl_userid .Text = Convert.ToString(UserID);
            lbl_name.Text = username;
            lbl_email.Text = Email;
            lbl_PN.Text = PN;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }

}
