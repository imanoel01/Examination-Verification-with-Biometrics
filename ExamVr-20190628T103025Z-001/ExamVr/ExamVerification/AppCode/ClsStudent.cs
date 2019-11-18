using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExamVerification.AppCode
{
  public  class ClsStudent
    {
        Connection con = new Connection();

        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int StateofOrigin { get; set; }
        public int LGA { get; set; }
        public int FacultyID { get; set; }
        public int DepartentID { get; set; }
        public string MatricNo { get; set; }
        public string CreatedBy { get; set; }

        public string  Session { get; set; }
        public int Semester { get; set; }
        public int CourseID { get; set; }
        public string ErrorMessage { get; set; }
        public string Search { get; set; }
        public int Status { get; set; }
        public int Gender { get; set; }
        public void AddStudent()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddStudent", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Firstname", Firstname);
                cmd.Parameters.AddWithValue("@Middlename", Middlename);
                cmd.Parameters.AddWithValue("@Lastname", Lastname);
                cmd.Parameters.AddWithValue("@StateofOrigin", StateofOrigin);
                cmd.Parameters.AddWithValue("@LGA", LGA);
                cmd.Parameters.AddWithValue("@Faculty", FacultyID);
                cmd.Parameters.AddWithValue("@Department", DepartentID);
                cmd.Parameters.AddWithValue("@MatricNo", MatricNo);
                cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                var a = (string)cmd.Parameters["@ret"].Value;
                Status = int.Parse(a);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
           

        }
        
        public void courseReg()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddStudentCourse", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MatricNo", MatricNo);
                cmd.Parameters.AddWithValue("@CourseId", CourseID);
                cmd.Parameters.AddWithValue("@Session", Session);
                cmd.Parameters.AddWithValue("@deptid", DepartentID);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                //cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                //cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                //ErrorMessage = (string)cmd.Parameters["@ret"].Value;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

       public DataTable SearchStudent()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("studentSearch", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Searchvalue", Search);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                
                dt.Load(reader);
             return dt;
                //comboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public string checkMatricNo()
        {
            string Isexits;
            try
            {
                SqlCommand cmd = new SqlCommand("checkMatricNo", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Matric", MatricNo);
                cmd.Parameters.Add("@ret", SqlDbType.Int);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                Isexits =cmd.Parameters["@ret"].Value.ToString();
                return Isexits;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }


    }
}

