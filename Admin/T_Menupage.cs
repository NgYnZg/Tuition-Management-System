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
    public partial class T_Menupage : Form
    {
        public static string name;
        public int userId;

        public T_Menupage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_Addinformation f1 = new T_Addinformation(userId);
            f1.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            T_Updateinformation f1 = new T_Updateinformation(userId);
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            T_Viewlist f1 = new T_Viewlist(userId);
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            T_Feedback f1 = new T_Feedback(userId);
            f1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            T_Profile f1 = new T_Profile(userId);
            f1.ShowDialog();
        }

        private void Menupage_Load(object sender, EventArgs e)
        {
            label2.Text = "Hello," + name;
        }

        public T_Menupage(string un, int uid)
        {
            InitializeComponent();
            name = un;
            userId = uid;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
