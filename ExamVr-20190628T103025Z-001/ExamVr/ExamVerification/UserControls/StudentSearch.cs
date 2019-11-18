using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamVerification.AppCode;

namespace ExamVerification.UserControls
{
    public partial class StudentSearch : UserControl
    {
        ClsStudent clsStudent = new ClsStudent();
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSerach.Text))
            {
                DataTable ds;
                clsStudent.Search = txtSerach.Text;
              ds=  clsStudent.SearchStudent();
                searchresult.DataSource = ds;
               
            }
        }
    }
}
