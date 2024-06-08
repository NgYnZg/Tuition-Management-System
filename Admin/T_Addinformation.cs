using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Trainer
{
    public partial class T_Addinformation : Form
    {
        public T_Addinformation()
        {
            InitializeComponent();
        }

        private int userId;//this is for userID to be record


        public T_Addinformation(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string me = txtme.Text;
            string lv = txtModuleLV.Text;
            string cg = txtCharges.Text;
            string sm = txtStarting.Text;
            string st = txtStartT.Text;
            string et=txtEndT.Text;
            string vn = txtVN.Text;
            Admin.Trainer newcourse = new Admin.Trainer(me, lv, cg, sm, st, et, vn, userId);
            MessageBox.Show(newcourse.addcourse());
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
