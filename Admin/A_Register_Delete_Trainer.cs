using System;
using System.Collections;
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
    public partial class A_Register_Delete_Trainer : Form
    {
        public A_Register_Delete_Trainer()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNum.Text;
            if (ValidateEmail(email) && ValidatePhoneNumber(phoneNumber))
            {
                Trainer obj1 = new Trainer(txtName.Text, email, phoneNumber);
                MessageBox.Show(obj1.RegisterTrainer());
                txtName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPhoneNum.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid email address format or phone number format");
            }
        }

        private void Register_Delete_Trainer_Load(object sender, EventArgs e)
        {
            ArrayList nm = new ArrayList();
            nm = Admin.getTrainerName();
            foreach (string i in nm)
            {
                comboTrainerName.Items.Add(i);
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Trainer delete_obj = new Trainer(comboTrainerName.Text);
            MessageBox.Show(delete_obj.DeleteTrainer());
        }

        private void btnExit_Click(object sender, EventArgs e)
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
