using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    
    internal class Admin
    {
        private string adminName;
        private string email;
        private string phoneNumber;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Admin(string name)
        {
            this.adminName = name;
        }



        public string updateProfile(string email, string phoneNumber) 
        {
            string status;
            con.Open();
            this.email = email;
            this.phoneNumber = phoneNumber;
            SqlCommand cmd = new SqlCommand("update admin set email = @a, phoneNumber = @b where name = @c", con);
            cmd.Parameters.AddWithValue("@a", email);
            cmd.Parameters.AddWithValue("@b", phoneNumber);
            cmd.Parameters.AddWithValue("@c", adminName);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update Successfully";
            }
            else
            {
                status = "Unable to update";
            }
            con.Close();
            return status;
        }

        public string getEmail()
        {
            string email;
            con.Open();
            SqlCommand cmd = new SqlCommand("select email from admin where name = @a", con);
            cmd.Parameters.AddWithValue("@a", adminName);
            email = cmd.ExecuteScalar().ToString();
            con.Close();
            return email;
        }

        public string getPhoneNumber()
        {
            string phoneNumber;
            con.Open();
            SqlCommand cmd = new SqlCommand("select phoneNumber from admin where name = @a", con);
            cmd.Parameters.AddWithValue("@a", adminName);
            phoneNumber = cmd.ExecuteScalar().ToString();
            con.Close();
            return phoneNumber;
        }

        public static ArrayList getTrainerFeedback(string trainername)
        {
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("select feedbacks from feedback " +
                "where trainerid = (select userid from trainer where name = @a)"
                , con);
            cmd.Parameters.AddWithValue("@a", trainername);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }
            con.Close();
            return nm;
        }


        public static ArrayList getTrainerNameFeedback() 
        { 
            ArrayList name = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand
                ("select name from trainer " +
                "where userid in (select trainerid from feedback)"
                , con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                name.Add(r.GetString(0));
            }
            con.Close();
            return name;
        }

        public static ArrayList getTrainerName()
        {
            ArrayList name = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("(select name from Trainer)", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                name.Add(r.GetString(0));
            }
            con.Close();
            return name;
        }
        public static ArrayList getIncomeName(string type) 
        {
            ArrayList nameIncome = new ArrayList();
            con.Open();
            if (type == "Name")
            {
                SqlCommand cmd = new SqlCommand
                    (
                    "select t.name from " +
                    "class_student cs, " +
                    "trainer t, " +
                    "class c where " +
                    "t.userid = c.trainerid and " +
                    "cs.classid = c.classid and " +
                    "cs.paymentstatus = 'paid' " +
                    "group by t.name"
                    , con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    nameIncome.Add(rd.GetString(0));
                }

            }
            else if (type == "Module")
            {
                SqlCommand cmd = new SqlCommand
                    (
                    "select distinct lm.module from class c " +
                    "inner join level_module lm " +
                    "on c.classid = lm.classid " +
                    "inner join class_student cs " +
                    "on c.classid = cs.classid " +
                    "where cs.paymentstatus = 'paid'"
                    , con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    nameIncome.Add(rd.GetString(0));
                }
            }
            else if (type == "Level")
            {
                SqlCommand cmd = new SqlCommand
                    (
                    "select distinct lm.level from class c " +
                    "inner join level_module lm " +
                    "on c.classid = lm.classid " +
                    "inner join class_student cs " +
                    "on c.classid = cs.classid " +
                    "where cs.paymentstatus = 'paid'"
                    , con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    nameIncome.Add(rd.GetString(0));
                }
            }
            else
                MessageBox.Show("Option not exist");
            con.Close();
            return nameIncome;

        }

        public static string getIncomeNumber(string type, string name) 
        {
            con.Open();
            string total = "";
            if (type == "Name")
            {
                SqlCommand cmd = new SqlCommand
                    (
                    "select sum(fee) from " +
                    "class_student cs, trainer t, class c where " +
                    "t.userid = c.trainerid and " +
                    "cs.classid = c.classid and " +
                    "cs.paymentstatus = 'paid' and " +
                    "t.name = @a"
                    , con);
                cmd.Parameters.AddWithValue("@a", name);
                total = cmd.ExecuteScalar().ToString();
            }
            else if (type == "Module")
            {
                SqlCommand cmd = new SqlCommand
                    (
                    "select sum(fee) from " +
                    "class_student cs, Level_module lm, class c where " +
                    "lm.classid = c.classid and " +
                    "cs.classid = c.classid and " +
                    "cs.paymentstatus = 'paid' and " +
                    "lm.module = @a"
                    , con);
                cmd.Parameters.AddWithValue("@a", name);
                total = cmd.ExecuteScalar().ToString();
            }

            else if (type == "Level")
            {
                SqlCommand cmd = new SqlCommand
                    (
                    "select sum(fee) from " +
                    "class_student cs, Level_module lm, class c where " +
                    "lm.classid = c.classid and " +
                    "cs.classid = c.classid and " +
                    "cs.paymentstatus = 'paid' and " +
                    "lm.level = @a"
                    , con);
                cmd.Parameters.AddWithValue("@a", name);
                total = cmd.ExecuteScalar().ToString();
            }
            con.Close();
            return total;
        }



    }
}
