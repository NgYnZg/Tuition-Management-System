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

namespace Admin
{
    public partial class A_View_Feedback : Form
    {
        
        public A_View_Feedback()
        {
            InitializeComponent();
        }

        private void View_Feedback_Load(object sender, EventArgs e)
        {
            ArrayList trainerName = new ArrayList();
            

            trainerName = Admin.getTrainerNameFeedback();
            foreach (string name in trainerName)
            {
                comboName.Items.Add(name);
            }


        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstFeedback.Items.Clear();
            ArrayList feedback = new ArrayList();

            string selectedItem = comboName.Text;
            feedback = Admin.getTrainerFeedback(selectedItem);
            foreach (string feedbacks in feedback)
            {
                lstFeedback.Items.Add(feedbacks);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
