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
    public partial class A_View_Income : Form
    {
        private string IncomeSort;
        public A_View_Income()
        {
            InitializeComponent();
        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstName.Items.Clear();
            ArrayList IncomeName = new ArrayList();
            IncomeSort = comboSort.Text;
            IncomeName = Admin.getIncomeName(IncomeSort);

            foreach (string item in IncomeName)
            {
                lstName.Items.Add(item);
            }
            
        }


        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_Item = lstName.SelectedItem.ToString();
            lblName.Text = selected_Item;
            lblIncome.Text = Admin.getIncomeNumber(comboSort.Text, selected_Item);


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
