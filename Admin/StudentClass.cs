using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trainer
{
    internal class StudentClass
    {
        private string studName;
        private string email;
        private string phoneNum;
        private string module;
        private string moduleN;
        private string moLV;
        private string moCharges;
        private string moStart;



        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Module { get => module; set => module = value; }
        public string MoLV { get => moLV; set => moLV = value; }
        public string MoCharges { get => moCharges; set => moCharges = value; }
        public string ModuleN { get => moduleN; set => moduleN = value; }
        public string MoStart { get => moStart; set => moStart = value; }

        public StudentClass(string n, string em)
        {
            studName = n;
            email = em;
        }


        public StudentClass(string nn)
        {
            studName = nn;
        }

        public StudentClass(string mN1, string mLV1, string mC1, string mSM1)
        {
            moduleN = mN1;
            moLV = mLV1;
            moCharges = mC1;
            moStart = mSM1;
        }

        public string addcourse()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into course (moduleName, moduleLV, charges, Startingmonth) values (@mN, @mL, @mC, @mSM)", con);

            cmd.Parameters.AddWithValue("@mN", moduleN);
            cmd.Parameters.AddWithValue("@mL", moLV);
            cmd.Parameters.AddWithValue("@mC", moCharges);
            cmd.Parameters.AddWithValue("@mSM", moStart);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Course added succesfully.";
            else
                status = "Unable to add course.";
            con.Close();
            return status;
        }

        public StudentClass(string newN, string newLV, string newC)
        {
            moduleN = newN;
            moLV = newLV;
            moCharges = newC;
        }
        public string updatecourse()
        {
            string status;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select moduleLV,charges,Startingmonth from course where moduleName='" + moduleN + "'", con);
            string modulename = cmd2.ExecuteScalar().ToString();
            if (modulename == "aaa1")
            {
                SqlCommand cmd3 = new SqlCommand
                ("update course set Startingmonth='" + moduleN + "'and moduleLV='" 
                + moLV + " 'and charges='" + moCharges + "'", con);
                cmd2.ExecuteNonQuery();
                int i = cmd3.ExecuteNonQuery();
                if (i != 0)
                    status = "Registration Successful.";
                else
                    status = "Unable to register.";
                con.Close();
                return status;
            }
            else if (modulename == "bbb1")
            {
                SqlCommand cmd4 = new SqlCommand
                ("update course set Startingmonth='" + moduleN + "'and moduleLV='"
                + moLV + " 'and charges='" + moCharges + "'", con);
                cmd2.ExecuteNonQuery();
                int i = cmd4.ExecuteNonQuery();
                if (i != 0)
                    status = "Registration Successful.";
                else
                    status = "Unable to register.";
                con.Close();
                return status;
            }
            else
            {
                status = "Unable to update.";
                return status;
            }
        }

        public string addStudent()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into students (studentName, email, phoneNumber) values (@name, @em, @num)", con);

            SqlCommand cmd2 = new SqlCommand("insert into users (username, password, role) values (@name, '123', 'student')", con);
            cmd.Parameters.AddWithValue("@name", studName); 
            cmd2.Parameters.AddWithValue("@name", studName); 
            cmd.Parameters.AddWithValue("@em", email); 
            cmd.Parameters.AddWithValue("@num", phoneNum);

            cmd2.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to register.";
            con.Close();
            return status;
        }


        public static ArrayList viewAll()
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand name2 = new SqlCommand("select studentname from students where paymentstatus='paid'", con);
            SqlDataReader read = name2.ExecuteReader();
            while (read.Read())
            {
                nm.Add(read.GetString(0));
            }
            con.Close();
            return nm;
        }


        public static void viewProfile(StudentClass o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students where studentName ='" + o1.studName + "'", con); SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.phoneNum = rd.GetString(3);
            }
            con.Close();
        }


        public string updateProfile(string em, string num)
        {
            string status;
            con.Open();

            email = em;
            phoneNum = num;

            SqlCommand cmd = new SqlCommand
                ("update students set email=' " + email + "'phoneNumber='" + phoneNum + " ' where studentName= ' " + studName + " ' ", con);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "unable to update";
            con.Close();

            return status;
        }

        

        public string updateProfileAdmin(string em, string num, string mo)
        {
            string status;
            con.Open();

            email = em;
            phoneNum = num;
            module = mo;

            SqlCommand cmd = new SqlCommand
                ("update admin set email=' " + email + "'phoneNumber='" 
                + phoneNum + " 'module=' " + module + " ' where adminName= ' " + studName + " ' ", con);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "unable to update";
            con.Close();

            return status;
        }


        public string addCoach()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into coach (moduleName, moduleLV, charges) values (@mo, @lv, @charges)", con);

            cmd.Parameters.AddWithValue("@mo", moduleN);
            cmd.Parameters.AddWithValue("@lv", moLV);
            cmd.Parameters.AddWithValue("@charges", moCharges);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Insert Successful.";
            else
                status = "Unable to insert.";
            con.Close();
            return status;
        }

        public string sfeedback()
        {
            return module;
        }
    }
}
