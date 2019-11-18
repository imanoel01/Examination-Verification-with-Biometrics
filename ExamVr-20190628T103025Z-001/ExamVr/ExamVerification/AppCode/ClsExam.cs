using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamVerification.AppCode
{
   public class ClsExam
    {
        Connection con = new Connection();
        public int ID { get; set; }
        public int courseid { get; set; }
        public string totalregistered { get; set; }
        public string totalpresent { get; set; }
        public string session { get; set; }
        public int facultyid { get; set; }
        public int departmentid { get; set; }
        public int discipline { get; set; }
        public string Lecturer { get; set; }
        public string Createdby { get; set; }
        public string message { get; set; }
        public int Isexists { get; set; }

        public void SaveReport()
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("NewExamReport", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@courseid", courseid);
                cmd.Parameters.AddWithValue("@Session", session);
                cmd.Parameters.AddWithValue("@TotalRegistered", totalregistered);
                cmd.Parameters.AddWithValue("@Totalpresent", totalpresent);
                cmd.Parameters.AddWithValue("@faculty", facultyid);
                cmd.Parameters.AddWithValue("@department", departmentid);
                cmd.Parameters.AddWithValue("@disciplinarycase", discipline);
                cmd.Parameters.AddWithValue("@lecturer", Lecturer);
                cmd.Parameters.AddWithValue("@createdby", Createdby);


                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void checkexamreport()
        {
            //SqlConnection sqlcon = Connection.con();
            try
            {
                //using (sqlcon)
                //{
                    SqlCommand cmd = new SqlCommand("checkexamreport", con.ActiveCon());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@courseid", courseid);
                    cmd.Parameters.AddWithValue("@Session", session);
                    cmd.Parameters.Add("@ret", SqlDbType.Int);
                    cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    Isexists = int.Parse(cmd.Parameters["@ret"].Value.ToString());
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.CloseCon();
                    }

                    
              
        }

    }
}
//(@courseid, @Session, @TotalRegistered, @Totalpresent, @faculty, @department, @disciplinarycase, @lecturer, @createdby)