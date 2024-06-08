using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lecturer
{
    internal class Lecturer
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        
        public string[] NameArray { get; private set; }
        
        public Lecturer()
        {

        }

        

        public void AddStudent(string Nm, int CN, string Em, string Add, string M, string lvl, string DE)
        {
            
                con.Open();

                // Insert the student as a user
                SqlCommand cmd = new SqlCommand("INSERT INTO users (Username, Password, Role) VALUES (@Username, 'student', 'student');", con);
                cmd.Parameters.AddWithValue("@Username", Nm);
                cmd.ExecuteNonQuery();

                // Get the UserID of the inserted student
                SqlCommand cmd2 = new SqlCommand("SELECT UserID FROM users WHERE Username = @Username AND Role = 'student';", con);
                cmd2.Parameters.AddWithValue("@Username", Nm);
                int UserID = (int)cmd2.ExecuteScalar();

                // Insert the student details into the Student table
                SqlCommand cmd3 = new SqlCommand("INSERT INTO Student VALUES (@UserID, @Username, @Em, @CN, @Add);", con);
                cmd3.Parameters.AddWithValue("@UserID", UserID);
                cmd3.Parameters.AddWithValue("@Username", Nm);
                cmd3.Parameters.AddWithValue("@Em", Em);
                cmd3.Parameters.AddWithValue("@CN", CN);
                cmd3.Parameters.AddWithValue("@Add", Add);
                cmd3.ExecuteNonQuery();

                // Get the ClassID based on the provided module, level, and intake month
                SqlCommand cmd4 = new SqlCommand("SELECT ClassID FROM Level_Module WHERE Module = @M AND Level = @lvl AND IntakeMonth = @DE;", con);
                cmd4.Parameters.AddWithValue("@M", M);
                cmd4.Parameters.AddWithValue("@lvl", lvl);
                cmd4.Parameters.AddWithValue("@DE", DE);
                int Class_ID = (int)cmd4.ExecuteScalar();

                // Insert the student into the ClassStudent table
                SqlCommand cmd5 = new SqlCommand("INSERT INTO Class_Student (ClassID, StudentID, CompletionStatus, PaymentStatus) VALUES (@ClassID, @UserID, 'Not Complete', 'Not Paid');", con);
                cmd5.Parameters.AddWithValue("@ClassID", Class_ID);
                cmd5.Parameters.AddWithValue("@UserID", UserID);
                cmd5.ExecuteNonQuery();

                MessageBox.Show("Student Added Successfully");
            
        }


        public Array StudentName(string[] p, int q)
        {
            int count = 0;

            con.Open();
            // Create a SqlCommand object to retrieve the student IDs
            SqlCommand cmd2 = new SqlCommand("SELECT TOP " + q + " UserID FROM Student", con);

            // Execute the command and retrieve the data using a SqlDataReader
            SqlDataReader reader = cmd2.ExecuteReader();

            // Create a List to store the retrieved student IDs
            List<int> studentIds = new List<int>();

            // Read the student IDs from the SqlDataReader and add them to the List
            while (reader.Read())
            {
                studentIds.Add(Convert.ToInt32(reader["UserID"]));
            }

            // Close the SqlDataReader
            reader.Close();

            // Iterate through the student IDs and retrieve the corresponding names
            foreach (int studentId in studentIds)
            {
                // Create a new SqlCommand object with a parameterized query to retrieve the student name
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Student WHERE UserID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", studentId);

                // Execute the command and retrieve the name using ExecuteScalar
                string name = cmd.ExecuteScalar().ToString();

                // Check if a name is retrieved and store it in the array
                if (name != null)
                {
                    p[count] = name;
                    count++;
                }
            }
            con.Close() ;
            return p;
            
        }


        public void UpdateModule(string y, string x, string z, string a)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select UserID from Student where Name = '" + z + "';", con);
            int UserID = (int)cmd1.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand("Select ClassID from Class_Student where StudentID = " + UserID + ";", con);
            int ClassID = (int)cmd2.ExecuteScalar();
            SqlCommand cmd = new SqlCommand("Select IntakeMonth from Level_Module where ClassID = " + ClassID + ";", con);
            string Intake_month = cmd.ExecuteScalar().ToString();

            string query = "Select ClassID from Level_Module where Level = @Level and Module = @Module and IntakeMonth = @IM;";
            SqlCommand cmd3 = new SqlCommand(query, con);

            cmd3.Parameters.AddWithValue("@Level", y);
            cmd3.Parameters.AddWithValue("@Module", x);
            cmd3.Parameters.AddWithValue("@IM", Intake_month);
            int New_ClassID = (int)cmd3.ExecuteScalar();
            int ClassStudentID = int.Parse(a);
            SqlCommand cmd4 = new SqlCommand("Update Class_Student Set ClassID = " +  New_ClassID + " where StudentID = '" + UserID + "' and ClassStudentID = "+ ClassStudentID +";", con);
            _= cmd4.ExecuteScalar();
            con.Close();

        }


        public void DeleteStudent(string Name)
        {
            con.Open();
            SqlCommand ID = new SqlCommand("select UserID from Student where Name = '" + Name + "';", con);
            int StudentID = (int)ID.ExecuteScalar();
            string query = "Delete from Class_Student where StudentID = " + StudentID + " AND CompletionStatus = 'Complete' AND PaymentStatus = 'Paid';";
            SqlCommand cmd = new SqlCommand(query, con);
            _ = cmd.ExecuteScalar();
            MessageBox.Show("Student Successfully deleted");
            con.Close();
        }

        public void StudentwithReq()
        {
            int count = 0;
            int countt = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT StudentID FROM Request", con);
            SqlCommand cmd2 = new SqlCommand("SELECT count(StudentID) from Request", con);
            string num = cmd2.ExecuteScalar().ToString();
            int numm = int.Parse(num); 
            NameArray = new string[numm];
            int[] StudentIDs = new int[numm];
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                StudentIDs[count++] = reader.GetInt32(0);
            }
          
            reader.Close();

            foreach (int StudentID in StudentIDs)
            {
                SqlCommand cmd3 = new SqlCommand("SELECT Name from Student where UserID = " + StudentID + ";", con);
                SqlDataReader reader2 = cmd3.ExecuteReader();
                while (reader2.Read())
                {
                    NameArray[countt++] = reader2.GetValue(0).ToString();
                }
                reader2.Close();
            }
            con.Close();
        }
        public string RequestDetail(string Name)
        {
            string x;
            con.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT UserID from Student where Name = '" + Name + "';", con);
            int UserID = (int)cmd.ExecuteScalar();
            SqlCommand cmd2 = new SqlCommand("Select ClassRequest from Request where StudentID = " + UserID + ";", con);
            x = cmd2.ExecuteScalar().ToString();
            con.Close() ;
            return x;
            
        }
        public void Approvereq(string name, string module)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ClassRequest FROM Request WHERE StudentID = (Select UserID from Student where Name = '" + name + "');", con);
            module = cmd.ExecuteScalar().ToString();

            SqlCommand StudentID = new SqlCommand("Select UserID from Student where Name = '" + name + "';", con) ;
            int UserID = (int)StudentID.ExecuteScalar();
            SqlCommand classID = new SqlCommand ( "Select ClassID from Class_Student WHERE StudentID = (Select UserID from Student where Name = '" + name + "')", con );
            int ClassID = (int)classID.ExecuteScalar();

            SqlCommand Level = new SqlCommand("Select Level from Level_Module where ClassID = " + ClassID + ";", con);
            string LevelID = Level.ExecuteScalar().ToString();
            SqlCommand IM = new SqlCommand("Select IntakeMonth from Level_Module where ClassID = " + ClassID + ";", con);
            string IntakeMonth = IM.ExecuteScalar().ToString();

            SqlCommand NewClassID = new SqlCommand("Select ClassID from Level_Module where Level = '" + LevelID + "' and Module = '" + module + "' and IntakeMonth = '" + IntakeMonth + "';", con);
            int New_ClassID = (int)NewClassID.ExecuteScalar();
            
            SqlCommand Update = new SqlCommand("Update Class_Student set ClassID = " + New_ClassID + " where StudentID = '" + UserID + "' AND ClassID = "+ ClassID + ";", con);
           
            _ = Update.ExecuteScalar();
            MessageBox.Show("Student Successfully updated");
            con.Close() ;

        }

        public void UpdateProfile(string name, int userid, string email, int phonenumber)
        {
            con.Open();
            
            SqlCommand cmd2 = new SqlCommand("Update Lecturer set Email = '" + email + "' , PhoneNumber = " + phonenumber + " where UserID = " + userid + " and Name = '" + name + "';", con);
            _ = cmd2.ExecuteScalar();
            con.Close();
        }

        public string LecturerEmail( string name, int userid)
        {   
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Email from Lecturer where Name = '" + name + "' and UserID = " + userid + " ;", con);
            string email = cmd.ExecuteScalar().ToString();
            

            con.Close ();
            
          
            return email;
            
        }
        public string LecturerPN(string name, int userid)
        {
            con.Open();
            
            SqlCommand cmd2 = new SqlCommand("Select PhoneNumber from Lecturer where Name = '" + name + "' and UserID = " + userid + " ;", con);
            string PN = (string)cmd2.ExecuteScalar();

            con.Close();

            return PN;
           

        }
        public void AssignStudent(string name, string level, string module, string IM)
        {
            con.Open();
            int ClassID;
            SqlCommand cmd = new SqlCommand("Select ClassID from Level_Module where Level = '" + level + "' and Module = '" + module + "' and IntakeMonth = '" + IM + "';", con);
            ClassID = (int)cmd.ExecuteScalar();
            SqlCommand cmd3 = new SqlCommand("Select UserID from Student where Name = '" + name + "';",con);
            int StudentID = (int)cmd3.ExecuteScalar();

            SqlCommand cmd2 = new SqlCommand("INSERT INTO Class_Student (ClassID, StudentID, CompletionStatus, PaymentStatus) VALUES (" + ClassID + "," + StudentID + ", 'Not Complete', 'Not Paid');", con);

            cmd2.ExecuteScalar();
            con.Close();
            MessageBox.Show("Student successfully Added to a class");
        }
        
    }   

}
