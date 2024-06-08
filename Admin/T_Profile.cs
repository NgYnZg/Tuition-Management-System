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
    public partial class T_Profile : Form
    {
        private int usID;
        public T_Profile()
        {
            InitializeComponent();
        }


        public T_Profile(int s)
        {
            InitializeComponent();
            usID = s;
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin.Trainer obj1 = new Admin.Trainer(txtuN.Text, txtuPW.Text);
            obj1.validateprofile(usID);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
