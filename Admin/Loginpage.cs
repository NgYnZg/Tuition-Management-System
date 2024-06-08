using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stat;
            user obj1 = new user(txtUsername.Text, txtPassword.Text); 
            stat=obj1.login(txtUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txtUsername.Text = String.Empty;
            
            txtPassword.Text = String.Empty;

            }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

    }
}
