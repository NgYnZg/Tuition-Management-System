using Admin;
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

namespace Trainer
{
    public partial class T_Updateprofile : Form
    {
        public static string name;
        private int ID;
        private string email;
        private string phonenumber;

        public T_Updateprofile()
        {
            InitializeComponent();
        }

        public T_Updateprofile(string n)
        {
            InitializeComponent();
            name = n;
        }

        public T_Updateprofile(int n)
        {
            InitializeComponent();
            ID = n;
        }


        public T_Updateprofile(string em, string pw)
        {
            InitializeComponent();
            email = em;
            phonenumber = pw;
        }

        private void Updateprofile_Load(object sender, EventArgs e)
        {
            Admin.Trainer obj1 = new Admin.Trainer(ID);

            Admin.Trainer.viewProfile(obj1);

            showE.Text = obj1.TrainerEmail;
            showPN.Text = obj1.TrainerPhoneNumber;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtTrainemail.Text;
            string phone = txtTrainPN.Text;

            if (ValidateEmail(email) && ValidatePhoneNumber(phone))
            {
                Admin.Trainer obj1 = new Admin.Trainer(ID);
                MessageBox.Show(obj1.updateProfile(email, phone, ID));

                Admin.Trainer.viewProfile(obj1);

                showE.Text = obj1.TrainerEmail;
                showPN.Text = obj1.TrainerPhoneNumber;
                txtTrainemail.Clear();
                txtTrainPN.Clear();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
