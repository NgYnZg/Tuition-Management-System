using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin
{
    internal class Trainer
    {
        private string moduleName;
        private string level;
        private string ClassFee;
        private string intakeMonth;
        private string trainerEmail;
        private string trainerPhoneNumber;
        private string trainerName;
        private string userName;
        private string userPassword;
        private int moduleID;
        private int userID;
        private string startTime;
        private string endTime;
        private string Venue;


        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public string TrainerEmail { get => trainerEmail; set => trainerEmail = value; }
        public string TrainerPhoneNumber { get => trainerPhoneNumber; set => trainerPhoneNumber = value; }

        public Trainer(string name, string email, string phoneNumber)
        {
            this.trainerName = name;
            trainerEmail = email;
            trainerPhoneNumber = phoneNumber;
        }

        public Trainer(string name)
        {
            this.trainerName = name;
        }

        public Trainer(string level, string moduleName, string intakeMonth, string trainerName, string Venue)
        {
            this.level = level;
            this.moduleName = moduleName;
            this.intakeMonth = intakeMonth;
            this.trainerName = trainerName;
            this.Venue = Venue;
        }


        public Trainer(int usID)
        {
            userID = usID;
        }

        public Trainer(int mId, string mN1, string mLV1, string mC1, string mSM1, string mST, string mET, string mVN)//its for update course in-use
        {
            moduleID = mId;
            moduleName = mN1;
            level = mLV1;
            ClassFee = mC1;
            intakeMonth = mSM1;
            startTime = mST;
            endTime = mET;
            Venue = mVN;
        }

        public Trainer(string mN1, string mLV1, string mC1, string mSM1, string mST, string mET, string mVN, int uid)//its for add course in-use
        {
            moduleName = mN1;
            level = mLV1;
            ClassFee = mC1;
            intakeMonth = mSM1;
            startTime = mST;
            endTime = mET;
            Venue = mVN;
            userID = uid;
        }

        public string RegisterTrainer()
        {
            string status;

            con.Open();

            SqlCommand cmd2 = new SqlCommand("insert into users (userName, password, role) values (@a, 'trainer', 'trainer')", con);
            SqlCommand cmdID = new SqlCommand("select userid from users where username = @b", con);
            SqlCommand cmd = new SqlCommand("insert into trainer (UserID, Name, email, phoneNumber) values (@uid, @name, @em, @num)", con);

            cmdID.Parameters.AddWithValue("@b", trainerName);
            cmd2.Parameters.AddWithValue("@a", trainerName);

            int firstCMD = cmd2.ExecuteNonQuery();


            int uid = Convert.ToInt32(cmdID.ExecuteScalar().ToString());

            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@name", trainerName);
            cmd.Parameters.AddWithValue("@em", trainerEmail);
            cmd.Parameters.AddWithValue("@num", trainerPhoneNumber);

            int secondCMD = cmd.ExecuteNonQuery();
            if (firstCMD != 0)
            {
                if (secondCMD != 0)
                {
                    status = "Registration Successful";
                }
                else
                    status = "Trainer table error, please contact tech assistant";
                
            }
            else
            {
                status = "Invalid information, unable to register";
            }
            con.Close();
            return status;
        }

        public string DeleteTrainer()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from trainer where name = @a", con);
            SqlCommand cmd2 = new SqlCommand("delete from users where username = @a", con);
            cmd.Parameters.AddWithValue("@a", trainerName);
            cmd2.Parameters.AddWithValue("@a", trainerName);
            cmd.ExecuteNonQuery();
            int i = cmd2.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Deletion Successful";
            }
            else
            {
                status = "Unable to delete trainer";
            }
            con.Close();
            return status;

        }

        public string assignTrainer()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand
                (
                "update class " +
                "set trainerid = (select userid from trainer where name = @name ) where " +
                "classid in (select classid from level_module " +
                "where level = @level and module = @module and intakeMonth = @intakeMonth and venue = @venue)"
                , con);
            cmd.Parameters.AddWithValue("@name", trainerName);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@module", moduleName);
            cmd.Parameters.AddWithValue("@intakeMonth", intakeMonth);
            cmd.Parameters.AddWithValue("@venue", Venue);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update successful";
            }
            else
                status = "Unable to update";
            con.Close();
            return status;
        }

        public string removeTrainerfromClass()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand
                (
                "update class " +
                "set trainerid = NULL where " +
                "trainerid = (select userid from trainer where name = @name) and " +
                "classid = (select classid from level_module " +
                "where level = @level and module = @module and intakeMonth = @intakeMonth and venue = @venue)"
                , con);
            cmd.Parameters.Add("@name", trainerName);
            cmd.Parameters.Add("@level", level);
            cmd.Parameters.Add("@module", moduleName);
            cmd.Parameters.Add("@intakeMonth", intakeMonth);
            cmd.Parameters.Add("@venue", Venue);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Update successful";
            }
            else
                status = "Unable to update";
            con.Close ();
            return status;
        }


        


        //Reno trainer


        public string addcourse()
        {
            string status;
            con.Open();

            


            SqlCommand ins = new SqlCommand("insert into level_module (module, level, intakeMonth, Venue) values (@mN, @mL, @mSM, @vn)", con);

            ins.Parameters.AddWithValue("@mN", moduleName);
            ins.Parameters.AddWithValue("@mL", level);
            ins.Parameters.AddWithValue("@mSM", intakeMonth);
            ins.Parameters.AddWithValue("@vn", Venue);
            int cmd1 = ins.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("select max(classid) from level_module", con);
            int classid = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            

            SqlCommand ins2 = new SqlCommand("insert into class (Classid, trainerid, fee, starttime, endtime) values (@cid, @uid,@mC, @st, @et)", con);
            ins2.Parameters.AddWithValue("@cid", classid);
            ins2.Parameters.AddWithValue("@mC", ClassFee);
            ins2.Parameters.AddWithValue("@st", startTime);
            ins2.Parameters.AddWithValue("@et", endTime);
            ins2.Parameters.AddWithValue("@uid", userID);
            int cmd2 = ins2.ExecuteNonQuery();


            if (cmd1 == 0)
            {
                status = "Update unsuccessful";
            }
            else if (cmd2 != 0)
                status = "Course added succesfully.";
            else
                status = "Unable to add course.";
            con.Close();
            return status;
        }




        public string updatecourse()//newest version can update with moduleID in-use
        {
            string status;
            con.Open();

            SqlCommand cmd3 = new SqlCommand
                ("update level_module set intakeMonth='" + intakeMonth + "', " +
                " level='" + level + "', module ='" + moduleName + "', " +
                " Venue='" + Venue + "'" + 
                " where classid='" + moduleID + "'", con);

            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand
                ("update class set starttime = @st, endtime = @et, fee = @f where classid = @module", con);
            cmd4.Parameters.AddWithValue("@st", startTime);
            cmd4.Parameters.AddWithValue("@et", endTime);
            cmd4.Parameters.AddWithValue("@f", ClassFee);
            cmd4.Parameters.AddWithValue("@module", moduleID);
            int i = cmd4.ExecuteNonQuery();



            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public string deletecourse()//delete course only one version
        {
            string status;
            con.Open();
            SqlCommand deleteClass = new SqlCommand("delete from class where classid='" + moduleID + "'", con);
            SqlCommand deleteClassStudent = new SqlCommand("delete from class_student where classid='" + moduleID + "'", con);
            SqlCommand deleteLevelMod = new SqlCommand("delete from level_module where classid='" + moduleID + "'", con);
            deleteClassStudent.ExecuteNonQuery();
            deleteClass.ExecuteNonQuery();
            int i = deleteLevelMod.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Class deleted successfully";
            }
            else
            {
                status = "Unable to delete or record does not exist.";
            }

            con.Close();
            return status;
        }

        public static ArrayList viewAll(int id)//view student with paid status, working on view course only for specific trainerID
        {
            ArrayList stu = new ArrayList();
            con.Open();
            SqlCommand name2 = new SqlCommand
                ("SELECT s.name FROM " +
                "class_student cs inner join student s " +
                "ON s.userid = cs.studentid " +
                "inner join class c " +
                "on c.classid = cs.classid " +
                "WHERE c.trainerId = @ID and " +
                "cs.paymentstatus = 'paid'", con);
            name2.Parameters.AddWithValue("@ID", id);
            SqlDataReader show = name2.ExecuteReader();
            while (show.Read())
            {
                stu.Add(show.GetString(0));
            }
            con.Close();
            return stu;
        }


        public static void viewProfile(Trainer o1)//for update profile
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select email ,phoneNumber from trainer where userid ='" + o1.userID + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                o1.trainerEmail = read.GetString(0);
                o1.trainerPhoneNumber = read.GetString(1);
            }
            con.Close();
        }


        public string updateProfile(string em, string num, int id)//old version but still in use version for update profile
        {
            string status;
            con.Open();

            trainerEmail = em;
            trainerPhoneNumber = num;
            userID = id;
            SqlCommand up = new SqlCommand
                ("update trainer set email='" + trainerEmail + "',phoneNumber='" + trainerPhoneNumber + "' where userid= '" + userID + "'", con);

            int i = up.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "unable to update";
            con.Close();

            return status;
        }

        public Trainer(string uValidate, string PWvalidate)//constructor for profile update validation
        {
            userName = uValidate;
            userPassword = PWvalidate;
        }


        public void validateprofile(int IDD)//enter userNameame and password to be able to update profile
        {
            string status;
            con.Open();


            string query = "SELECT COUNT(*) FROM users WHERE userName = @userName AND password = @Password";
            SqlCommand validationCommand = new SqlCommand(query, con);
            validationCommand.Parameters.AddWithValue("@userName", userName);
            validationCommand.Parameters.AddWithValue("@Password", userPassword);

            int count = (int)validationCommand.ExecuteScalar();

            if (count > 0)
            {
                con.Close();
                T_Updateprofile f1 = new T_Updateprofile(IDD);
                f1.ShowDialog();;
            }
            else
            {
                con.Close();
                MessageBox.Show("invalid userName or password");

            }
        }
        public string sendFeedback(string fb)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Feedback (trainerid, feedbacks) values (@a, @fb)", con);
            cmd.Parameters.AddWithValue("@a", userID);
            cmd.Parameters.AddWithValue("@fb", fb);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Feedback sent successfully.";
            else
                status = "Unable to send feedback.";
            con.Close();
            return status;
        }

    }
}
