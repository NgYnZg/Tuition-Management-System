using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lecturer
{
    public partial class RegS : Form
    {
        
        public RegS()
        {
            InitializeComponent(); 
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            
            int ContactN = int.Parse(txt_CN.Text);
            string Email = txt_Email.Text;
            string Address = txt_Address.Text;
            string Module = cb_M.Text;
            string Level = cb_Lvl.Text;
            string Date = cb_DE.Text;
            if (ValidateEmail(Email) && ValidatePhoneNumber(ContactN.ToString()))
            {
                Lecturer Student1 = new Lecturer();
                Student1.AddStudent(Name, ContactN, Email, Address, Module, Level, Date);
            }
            else
            {
                MessageBox.Show("Invalid email address format or phone number format");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();    
        }



        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
