using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lecturer
{
    public partial class L_Requests : Form
    {
        string LN = "";
        string detail = "";
        Lecturer StudentDetail = new Lecturer();

        public L_Requests()
        {
            InitializeComponent(); 
        }

        private void cb_requests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            String Check = cb_requests.Text;
            

            detail = StudentDetail.RequestDetail(Check);
            lbl_detail2.Text = "Change module to " + detail;
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_appr_Click(object sender, EventArgs e)
        {
            String Check = cb_requests.Text;
            detail = StudentDetail.RequestDetail(Check);
            StudentDetail.Approvereq(cb_requests.Text, detail);

        }

        private void L_Requests_Load(object sender, EventArgs e)
        {
            Lecturer StudentDetail = new Lecturer();
            StudentDetail.StudentwithReq();
            string[] names = StudentDetail.NameArray;
            int max = names.Count();
            for (int i = 0; i < max; i++)
                cb_requests.Items.Add(names[i]);
            MessageBox.Show(max.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
