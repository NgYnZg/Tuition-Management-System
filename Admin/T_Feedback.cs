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

    public partial class T_Feedback : Form
    {
        public static int trainerID;
        public T_Feedback()
        {
            InitializeComponent();
        }

        public T_Feedback(int uid)
        {
            InitializeComponent();
            trainerID = uid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin.Trainer newcourse = new Admin.Trainer(trainerID);
            MessageBox.Show(newcourse.sendFeedback(txtfb.Text));
            txtfb.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
