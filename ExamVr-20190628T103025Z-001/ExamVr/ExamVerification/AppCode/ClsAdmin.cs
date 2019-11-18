using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExamVerification.AppCode
{
    public class Adminn
    {
        Connection con = new Connection();
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DOB { get; set; }
        public int ret { get; set; }
        public int Usertype { get; set; }
        public int facdeptid { get; set; }
        public int Status { get; set; }
        public void newAdmin()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddAdmin", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Firstname", Firstname);
                cmd.Parameters.AddWithValue("@Lastname", Lastname);
                cmd.Parameters.AddWithValue("@Middlename", Middlename);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@DOB", DOB); 
                cmd.Parameters.AddWithValue("@UserType", Usertype);
                cmd.Parameters.AddWithValue("@facdeptid", facdeptid);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }

        public void VerifyLogin()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Login", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(cmd);   
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Status = 1;
                    var a = dt.Rows[0]["AccountType"];
                    var b  = dt.Rows[0]["FacDept"];

                    Usertype = int.Parse(a.ToString());
                    facdeptid = int.Parse(b.ToString());

                }
                else
                {
                    Status = 0;
                }
               
               
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }

        public void getUserType(ComboBox comboBox)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("getUserType", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "id";
                comboBox.DisplayMember = "typename";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void getFacOrCOursebyAccountType(ComboBox comboBox, int accountytype)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("getFacorDeptbyAccountType", con.ActiveCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accountype", accountytype);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                DataRow drw;
                drw = dt.NewRow();
                drw.ItemArray = new object[] { 0, "<--Select-->" };
                dt.Rows.InsertAt(drw, 0);
                comboBox.ValueMember = "id";
                comboBox.DisplayMember = "Name";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
