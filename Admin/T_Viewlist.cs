using System;
using System.Collections;
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
    public partial class T_Viewlist : Form
    {
        public T_Viewlist()
        {
            InitializeComponent();
        }

        private int UID;
        public T_Viewlist(int userId)
        {
            InitializeComponent();
            this.UID = userId;
        }

        private void Viewlist_Load(object sender, EventArgs e)
        {
            ArrayList name = new ArrayList();

            name = Admin.Trainer.viewAll(UID);
            foreach(var item in name)
            {
                lstStudent.Items.Add(item);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
