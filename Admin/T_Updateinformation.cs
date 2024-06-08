using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainer
{
    public partial class T_Updateinformation : Form
    {
        public T_Updateinformation()
        {
            InitializeComponent();
        }

        private int userid;

        public T_Updateinformation(int i)
        {
            InitializeComponent();
            userid = i;
        }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private void button1_Click(object sender, EventArgs e)
        {
            string upN = txtnewN.Text;
            string upLV = txtnewLV.Text;
            string upC = txtnewC.Text;
            string upSM = txtnewSM.Text;
            int idd;
            string st = txtnewST.Text;
            string et = txtnewET.Text;
            string vn = txtnewV.Text;
            Admin.Trainer update = new Admin.Trainer(int.Parse(txtnewID.Text), 
                upN, upLV, upC, upSM, st, et, vn);
            MessageBox.Show(update.updatecourse());
            con.Open();
            SqlCommand command5 = new SqlCommand
                ("SELECT module, level, intakeMonth, lm.Venue, C.ClassID, fee, Starttime, Endtime FROM " +
                "class c, level_module lm where " +
                "c.classid = lm.classid and trainerId='" + userid + "'"
                , con);
            SqlDataReader reader5 = command5.ExecuteReader();
            VIEW.Rows.Clear();
            while (reader5.Read())
            {
                string moduleName = reader5.GetString(0);
                string moduleLV = reader5.GetString(1);
                string startingMonth = reader5.GetString(2);
                int id = reader5.GetInt32(4);
                int cg = reader5.GetInt32(5);
                string starttime = reader5.GetString(6);
                string endtime = reader5.GetString(7);
                string venue = reader5.GetString(3);
                VIEW.Rows.Add(new object[] { id, moduleName, moduleLV, startingMonth, cg, starttime, endtime, venue });
            }
            reader5.Close();
            con.Close();
        }

        private void Updateinformation_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command5 = new SqlCommand
                ("SELECT module, level, intakeMonth, C.ClassID, fee, Starttime, Endtime, lm.Venue FROM " +
                "class c, level_module lm where " +
                "c.classid = lm.classid and trainerId='" + userid + "'"
                , con);
            SqlDataReader reader5 = command5.ExecuteReader();
            VIEW.Rows.Clear();
            while (reader5.Read())
            {
                string moduleName = reader5.GetString(0);
                string moduleLV = reader5.GetString(1);
                string startingMonth = reader5.GetString(2);
                int id = reader5.GetInt32(3);
                int cg = reader5.GetInt32(4);
                string starttime= reader5.GetString(5);
                string endtime= reader5.GetString(6);
                string venue= reader5.GetString(7);
                VIEW.Rows.Add(new object[] { id, moduleName, moduleLV, startingMonth, cg, starttime, endtime, venue });
            }
            reader5.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n = txtnewN.Text;
            string lv = txtnewLV.Text;
            string c = txtnewC.Text;
            string sm=txtnewSM.Text;
            string st=txtnewST.Text;
            string nt = txtnewET.Text;
            string nv = txtnewV.Text;
            Admin.Trainer delete = new Admin.Trainer(int.Parse(txtnewID.Text), n, lv, 
                c, sm, st, nt, nv);
            MessageBox.Show(delete.deletecourse());


            con.Open();
            SqlCommand command5 = new SqlCommand
                ("SELECT module, level, intakeMonth, lm.Venue, C.ClassID, fee, Starttime, Endtime FROM " +
                "class c, level_module lm where " +
                "c.classid = lm.classid and trainerId='" + userid + "'"
                , con);
            SqlDataReader reader5 = command5.ExecuteReader();
            VIEW.Rows.Clear();
            while (reader5.Read())
            {
                string moduleName = reader5.GetString(0);
                string moduleLV = reader5.GetString(1);
                string startingMonth = reader5.GetString(2);
                int id = reader5.GetInt32(4);
                int cg = reader5.GetInt32(5);
                string starttime = reader5.GetString(6);
                string endtime = reader5.GetString(7);
                string venue = reader5.GetString(3);
                VIEW.Rows.Add(new object[] { id, moduleName, moduleLV, startingMonth, cg, starttime, endtime, venue });
            }
            reader5.Close();
            con.Close();

        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
