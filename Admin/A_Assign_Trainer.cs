using System;
using System.Collections;
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

namespace Admin
{
    public partial class A_Assign_Trainer : Form
    {
        private string nameOutput;
        private string level;
        private string module;
        private string intakeMonth;
        private string venue;
        public A_Assign_Trainer()
        {
            InitializeComponent();
        }

        private void Assign_Trainer_Load(object sender, EventArgs e)
        {
            ArrayList nm = new ArrayList();
            nm = Admin.getTrainerName();
            foreach (string i in nm)
            {
                comboName.Items.Add(i);
            }
            getAvailabeSlots();

            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            level = checkRadioButton(rdBeg, rdInter, rdAd);
            module = checkRadioButton(rdC, rdCSharp, rdP);
            intakeMonth = checkRadioButton(rdMarch, rdJune, rdSep);
            venue = checkRadioButton(rbHall1, rbHall2, rbHall3);
            Trainer obj1 = new Trainer(level, module, intakeMonth, comboName.Text, venue);
            MessageBox.Show(obj1.assignTrainer());
            getAvailabeSlots();

            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            level = checkRadioButton(rdBeg, rdInter, rdAd);
            module = checkRadioButton(rdC, rdCSharp, rdP);
            intakeMonth = checkRadioButton(rdMarch, rdJune, rdSep);
            venue = checkRadioButton(rbHall1, rbHall2, rbHall3);
            Trainer obj1 = new Trainer(level, module, intakeMonth, comboName.Text, venue);
            MessageBox.Show(obj1.removeTrainerfromClass());
            getAvailabeSlots();
        }
        
        
        private string checkRadioButton(RadioButton rd1, RadioButton rd2, RadioButton rd3)
        {
            if (rd1.Checked == true)
            {
                nameOutput = rd1.Text;
            }
            else if (rd2.Checked == true)
            {
                nameOutput = rd2.Text;
            }
            else if (rd3.Checked == true) 
            { 
                nameOutput = rd3.Text; 
            }
            return nameOutput;
        }

        private void getAvailabeSlots() 
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand info = new SqlCommand
                ("select level, module, intakemonth, venue from level_module " +
                "where classid in (select classid from class where trainerid is null or trainerid = 0)"
                , con);
            SqlDataReader rd = info.ExecuteReader();
            classViewer.Rows.Clear();
            while (rd.Read())
            {
                string level = rd.GetString(0);
                string module = rd.GetString(1);
                string intakeMonth = rd.GetString(2);
                string venue = rd.GetString(3);
                classViewer.Rows.Add(new object[] { module, level, intakeMonth, venue });
            }
            rd.Close();
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
