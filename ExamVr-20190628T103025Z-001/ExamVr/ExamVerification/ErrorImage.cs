using ExamVerification.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamVerification
{
    public partial class ErrorImage : Form
    {
        public ErrorImage()
        {
            InitializeComponent();
        }

        private void ErrorImage_Load(object sender, EventArgs e)
        {

        }
        byte[] ConvertImageBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public byte[] Image { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var nm = ConvertImageBinary(picBox.Image);
            Image = nm;

            SaveErrotImage();
        }

        Connection con = new Connection();
        void SaveErrotImage()
        {

            SqlCommand cmd = new SqlCommand("InsertErrorImage", con.ActiveCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@basestring", Image);

            cmd.ExecuteNonQuery();

        }
    }
}
