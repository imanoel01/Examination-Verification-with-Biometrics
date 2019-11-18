using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamVerification.AppCode
{
    public class ClsVerification
    {
        Connection con = new Connection();
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string Created_By { get; set; }

        public int FacultyID { get; set; }
        public string Coursecode { get; set; }
        public string CourseTitle { get; set; }
        public int courseID { get; set; }
        public int Semester { get; set; }
        public int Level { get; set; }
        public int DepartmentId { get; set; }
        public string Session { get; set; }
        public int courseunit { get; set; }
        public string coursetype { get; set; }
        public string MatricNo { get; set; }
        public string ErrorMessage { get; set; }
        public void getallstudentbycourse(Label label)
        {
            try
            {
                string message;
                SqlCommand cmd = new SqlCommand("getStudentReg", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Session", Session);
                cmd.Parameters.AddWithValue("@Courseid", courseID);
                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                label.Text = (string)cmd.Parameters["@ret"].Value;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void verifiyStudent(Label label)
        {
            try
            {
                string message;
                SqlCommand cmd = new SqlCommand("newProcVerify", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@matric", MatricNo);
                cmd.Parameters.AddWithValue("@courseid", courseID);
                cmd.Parameters.AddWithValue("@Session", Session);
                
                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@verified", SqlDbType.Char, 500);
                cmd.Parameters["@verified"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                label.Text =  (string)cmd.Parameters["@verified"].Value;
                ErrorMessage = (string)cmd.Parameters["@ret"].Value;
            }
            catch (Exception)
            {

                throw;
            }


        }




    }
}
//@matric nchar(14),@courseid int, @Session char (9), @ret nvarchar(50) out,@verified nvarchar out