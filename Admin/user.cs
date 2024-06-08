using Admin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trainer
{
    internal class user
    {
        private string username;
        private string password;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public user(string us, string pass)
        {
            username=us;
            password = pass;
        }

        public string login(string un)
        {
            string status = null;
            
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from users where username='" + username +
                " 'and password = '" + password + "'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmdRole = new SqlCommand("select role from users where username='" 
                    + username + " 'and password= '" + password + "'", con);
                SqlCommand cmdID = new SqlCommand("select userid from users where username='"
                    + username + " 'and password= '" + password + "'", con);

                string userRole = cmdRole.ExecuteScalar().ToString();
                int UserId = Convert.ToInt32(cmdID.ExecuteScalar().ToString());
                if (userRole == "trainer   ")
                {
                    Trainer.T_Menupage a = new Trainer.T_Menupage(un, UserId); // Pass the username and userId to Menupage
                    a.ShowDialog();
                }

                else if (userRole == "admin     ")
                {
                    Admin.A_AdminHome b = new Admin.A_AdminHome(un, UserId);
                    b.ShowDialog();
                }
                
                else if (userRole == "lecturer  ")
                {
                    Lecturer.LecMainMenu a = new Lecturer.LecMainMenu(un, UserId);
                    a.ShowDialog();
                }

                else if (userRole == "student   ")
                {
                    Student.Form1 a = new Student.Form1(un, UserId);
                    a.ShowDialog();
                }

                
            }

            else
                status = "Incorrect username/password";
            
            
            con.Close();
            return status;
        }
    }
}
