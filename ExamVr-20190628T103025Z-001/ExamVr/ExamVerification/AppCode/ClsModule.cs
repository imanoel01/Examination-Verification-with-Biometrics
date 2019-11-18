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
    public class ClsModule
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
        public int coursetype { get; set; }
        public string ErrorMessage { get; set; }
        public int   stateid { get; set; }
        public string lga { get; set; }

        public int Status { get; set; }
        //public int MyProperty { get; set; }
        //rsecode char (6),@CourseTitle nvarchar(50), @Semester int, @level int,@FacultyID int,@DepartmentID int,@Description nvarchar(100),@CreatedBy nvarchar(50)

        public void newFaculty()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddFaculty", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@ShortName", ShortName);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@CreatedBy", Created_By);
                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                ErrorMessage = (string)cmd.Parameters["@ret"].Value;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public void getAllFaculty(ComboBox comboBox)
        {
            try
            {
             
                SqlCommand cmd = new SqlCommand("GetAllFacultty", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
             
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "ID";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }

        public void newDepartment()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddDepartment", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Shortname", ShortName);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@FacultyID", FacultyID);
                cmd.Parameters.AddWithValue("@Createdby", Created_By);
                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                ErrorMessage = (string)cmd.Parameters["@ret"].Value;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public void getLevel(ComboBox comboBox)
        {
            try
            {
               
                SqlCommand cmd = new SqlCommand("getAllLevel", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0,0 };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
            
        }

        public void getStudentCourseRange(ComboBox comboBox)
        {
            try
            {
               
                SqlCommand cmd = new SqlCommand("getcouresrange", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
      
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, 0 };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "ID";
                comboBox.DisplayMember = "ID";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
            
        }
        public void getSemester(ComboBox comboBox)
        {
            try
            {
                //SqlCommand cmd = new SqlCommand("getAllSemester", con.ActiveCon());
                //cmd.CommandType = CommandType.StoredProcedure;
                //SqlDataReader reader;
                //reader = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Columns.Add("SemesterId", typeof(string));
                //dt.Columns.Add("SemesterName", typeof(string));
                //dt.Load(reader);
                //comboBox.ValueMember = "SemesterId";
                //comboBox.DisplayMember = "SemesterName";
                //comboBox.DataSource = dt;
                SqlCommand cmd = new SqlCommand("getAllSemester", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public void getDepartment(ComboBox comboBox)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getAllDepartment", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "DepartmentId";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }

        public void getDepartmentByFaculty(ComboBox comboBox,int FacultyID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getDepartmentbyFaculty", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FacultyID", FacultyID);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public void getCourseByFacSem(ComboBox comboBox)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("GetCoursebyFacSem", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Faculty", FacultyID);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "ID";
                comboBox.DisplayMember = "Coursetitle";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;


            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public void newCourse()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddCourse", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CourseTitle", CourseTitle);
                cmd.Parameters.AddWithValue("@Coursecode", Coursecode);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                cmd.Parameters.AddWithValue("@level", Level);
                cmd.Parameters.AddWithValue("@FacultyID", FacultyID);
                cmd.Parameters.AddWithValue("@DepartmentID", DepartmentId);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Unit", courseunit);
                cmd.Parameters.AddWithValue("@Coursetype", coursetype);
                cmd.Parameters.AddWithValue("@CreatedBy", Created_By);
                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                
                cmd.ExecuteNonQuery();
                var a = (string)cmd.Parameters["@ret"].Value;
                Status = int.Parse(a);
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }


        public void getCourseByDeptSem(ComboBox comboBox)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("getCoursebyDepartmentSemester", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Department", DepartmentId);
                cmd.Parameters.AddWithValue("@Semester", Semester);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "ID";
                comboBox.DisplayMember = "Coursetitle";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;



            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public void getAcademicSession(ComboBox comboBox)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getAllSession", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(string));
                dt.Columns.Add("Name", typeof(string));
                dt.Load(reader);
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;
                //comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public void getAllCourseType(ComboBox comboBox)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("getAllCourseType", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
         
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "ShortName";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }
        public void getAllCourseUnit(ComboBox comboBox)
        {
            try
            {
              
                SqlCommand cmd = new SqlCommand("getAllCourseUnit", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, 0 };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Unit";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }

        public void getAllState(ComboBox comboBox)
        {
            try
            {
               
                SqlCommand cmd = new SqlCommand("getAllState", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }
        public void newlga()
        {
            try
            {
                string message;
                SqlCommand cmd = new SqlCommand("newlga", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", lga);
                cmd.Parameters.AddWithValue("@stateid", stateid);
                cmd.Parameters.Add("@ret", SqlDbType.Char, 500);
                cmd.Parameters["@ret"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                ErrorMessage = (string)cmd.Parameters["@ret"].Value;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void getlgabystate(ComboBox comboBox)
        {
            try
            {
              
                SqlCommand cmd = new SqlCommand("getlgabystate", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stateid", stateid);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "id";
                comboBox.DisplayMember = "name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }
        }


        public void getNonRegStudent(ComboBox comboBox,int Departmentid, int session,int semester)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("getNonRegStudent", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Session", session);
                cmd.Parameters.AddWithValue("@Deptid", Departmentid);
                cmd.Parameters.AddWithValue("@semester", Semester);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
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


        public void GetGender(ComboBox comboBox)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("getGender", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }
    }
}



