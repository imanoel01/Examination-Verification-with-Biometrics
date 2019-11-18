using ExamVerification.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace ExamVerification.AppCode
{

    public class ClsBiometric
    {
        Connection con = new Connection();
        public int Id { get; set; }
        public string StudentMatric { get; set; }
        public byte[] FingerPrint { get; set; }
        public string Message { get; set; }

        public int facultyId { get; set; }
        public int departmentId { get; set; }
        public string Session { get; set; }
        public int Courseid { get; set; }
        public int Semester { get; set; }

        public string CreatedBy { get; set; }
        //@Matricno nvarchar(50),@FingerData
        //return variable for value from db
        public int RetMessage { get; set; }
        public void SaveFingerData(string matric, byte[] fingertemplate, byte[] imagetemplate, string user)
        {


            CreatedBy = user;
            try
            {
                SqlCommand cmd = new SqlCommand("NewFingerData", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Matricno", matric);
                cmd.Parameters.AddWithValue("@FingerData", fingertemplate);
                cmd.Parameters.AddWithValue("@ImageData", imagetemplate);
                cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd.Parameters.Add("@ret", SqlDbType.NVarChar, 50);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                //cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                RetMessage = int.Parse((string)cmd.Parameters["@ret"].Value);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        //@session char (9),@semesterid int,@courseid int
        public List<Record> VerifyFingerPrint()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("verifyfingerprint", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Searchvalue", Search);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(reader);
                var id = "";

                DPFP.Template template = new DPFP.Template();

                List<Record> record = new List<Record>();
                while (reader.Read())
                {
                    id = reader["MatricNo"].ToString();
                    //DPFP.Template template = new DPFP.Template();

                    MemoryStream memStreamTemplate = new MemoryStream((byte[])reader["FingerPrint"]);
                    //  Dim memStreamTemplate As New MemoryStream(CType(reader("Features"), Byte()))
                    template.DeSerialize(memStreamTemplate);

                    var rec = new Record(id, template);

                    record.Add(rec);


                }

                return record;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

        public IEnumerable<Record> getFingerPrintTemplate()
        {
            SqlConnection sqlcon = Connection.con();

            try
            {
                using (sqlcon)
                {
                    SqlCommand cmd = new SqlCommand("getFingerPrintCourse", sqlcon);
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@session", Session);
                    cmd.Parameters.AddWithValue("@semesterid", Semester);
                    cmd.Parameters.AddWithValue("@courseid", Courseid);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    //DataTable dt = new DataTable();
                    //dt.Load(reader);
                    var id = "";

                    DPFP.Template template = new DPFP.Template();

                    List<Record> record = new List<Record>();
                    while (reader.Read())
                    {
                        id = reader["MatricNo"].ToString();
                        //DPFP.Template template = new DPFP.Template();

                        MemoryStream memStreamTemplate = new MemoryStream((byte[])reader["FingerPrint"]);
                        //  Dim memStreamTemplate As New MemoryStream(CType(reader("Features"), Byte()))
                        template.DeSerialize(memStreamTemplate);

                        var rec = new Record(id, template);

                        record.Add(rec);


                    }
                    reader.Close();
                    return record;
                }




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
        public void getNonEnrolledStudent(ComboBox comboBox)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("CheckEnrollment", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@FacultyID", facultyId);
                cmd.Parameters.AddWithValue("@Departmentid", departmentId);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { "<--Select-->", "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "MatricNo";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }

        public int getVerifiedStudentCount(int session, int CourseId)
        {
            SqlConnection sqlcon = Connection.con();



            try
            {
                using (sqlcon)
                {
                    SqlCommand cmd = new SqlCommand("getverifiedStudent", sqlcon);
                    if (sqlcon.State == ConnectionState.Closed)
                        sqlcon.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
            
                    cmd.Parameters.AddWithValue("@session", session);
                    cmd.Parameters.AddWithValue("@Courseid", CourseId);


                    cmd.Parameters.Add("@ret", SqlDbType.NVarChar,50);
                    cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                   
                    cmd.ExecuteNonQuery();
                    RetMessage = int.Parse((string)cmd.Parameters["@ret"].Value);
                    return RetMessage;
                    //cmd.Dispose();

                }



                //label.Text = (string)cmd.Parameters["@Name"].Value;
                //label2.Text = (string)cmd.Parameters["@ret"].Value;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.CloseCon();
            }
        }


        public static byte[] NotVerifiedImage { get; set; }
        //get errorm image
        public byte[] getErrorImage()
        {

            SqlCommand cmd = new SqlCommand("getErrorImage", con.ActiveCon());
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataReader data = cmd.ExecuteReader())
            {
                var id = "";

                while (data.Read())
                {
                    id = data["Id"].ToString();


                    byte[] baseString = (byte[])data["BaseString"];

                    NotVerifiedImage = baseString;


                }
            }
            return NotVerifiedImage;
        }

        public int updateVerifiedStudent(string matricno, int courseid, int session, int semester, string signedby)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateStudentExamAttendance", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Semester", semester);
                cmd.Parameters.AddWithValue("@matricno", matricno);
                cmd.Parameters.AddWithValue("@Courseid", courseid);
                cmd.Parameters.AddWithValue("@session", session);
                cmd.Parameters.AddWithValue("@SigninBy", signedby);
                cmd.Parameters.Add("@ret", SqlDbType.NVarChar, 50);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                RetMessage = int.Parse((string)cmd.Parameters["@ret"].Value);
                return RetMessage;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }


        }
    }
}

