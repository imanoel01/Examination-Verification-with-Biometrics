using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExamVerification.AppCode
{
  public  class Connection
    {


        public static SqlConnection con()
        {
            return new SqlConnection("Data Source=.;Initial Catalog=ExamVerificationDb;Integrated Security=True");
        }
        
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ExamVerificationDb;Integrated Security=True");
        public SqlConnection ActiveCon()
        {
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;

        }
        public void CloseCon()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            //return conn;

        }

    }
}
