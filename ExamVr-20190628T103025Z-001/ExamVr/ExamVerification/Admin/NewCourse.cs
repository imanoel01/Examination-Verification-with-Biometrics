using ExamVerification.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamVerification.Admin
{

    public partial class NewCourse : MetroFramework.Forms.MetroForm
    {
        ClsModule clsmodule = new ClsModule();
        public NewCourse(string User)
        {
            InitializeComponent();
            init();
            user = User;
        }

        public string user { get; set; }
        public string message { get; set; }
        void init()
        {
            clsmodule.getAllFaculty(cmbFaculty);
            clsmodule.getSemester(cmbSemester);
            clsmodule.getLevel(cmbLevel);
            clsmodule.getAllCourseType(cmbcoursetype);
            clsmodule.getAllCourseUnit(cmbcourseunit);
            //clsmodule.getDepartment(cmbDepartment);
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int facultyid = int.Parse(cmbFaculty.SelectedValue.ToString());
            clsmodule.getDepartmentByFaculty(cmbDepartment, facultyid);

        }

        void clearentry()
        {
            txtCourseCode.Clear();
            txtTitle.Clear();
            cmbSemester.SelectedIndex = 0;
            cmbFaculty.SelectedIndex = 0;
            cmbLevel.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
            cmbcoursetype.SelectedIndex = 0;
            cmbcourseunit.SelectedIndex = 0;
            txtDescription.Clear();

            
        }

        bool validateentry()
        {
            if (string.IsNullOrWhiteSpace(txtCourseCode.Text) || string.IsNullOrWhiteSpace(txtTitle.Text) || cmbDepartment.SelectedIndex == 0
                || cmbLevel.SelectedIndex == 0 || cmbFaculty.SelectedIndex == 0 || cmbSemester.SelectedIndex == 0||cmbcourseunit.SelectedIndex==0
                ||cmbcoursetype.SelectedIndex==0)
            {
                MessageBox.Show("All fields are required");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateentry())
                {
                    clsmodule.Coursecode = txtCourseCode.Text.ToUpper();
                    clsmodule.CourseTitle = txtTitle.Text.ToUpper();
                    clsmodule.Semester = int.Parse(cmbSemester.SelectedValue.ToString());
                    clsmodule.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                    clsmodule.Level = int.Parse(cmbLevel.SelectedValue.ToString());
                    clsmodule.Description = txtDescription.Text;
                    clsmodule.Created_By = ClsUserSetting.Usersetting;
                    clsmodule.DepartmentId = int.Parse(cmbDepartment.SelectedValue.ToString());
                    clsmodule.courseunit = int.Parse(cmbcourseunit.SelectedValue.ToString());
                    clsmodule.coursetype = int.Parse(cmbcoursetype.SelectedValue.ToString());

                    clsmodule.newCourse();

                    message = txtCourseCode.Text + " Successfully saved";
                    //MessageBox.Show(message);
                    //clearentry();
                    if (clsmodule.Status==1)
                    {
                        MessageBox.Show( message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearentry();
                    }
                    else
                    {
                        MessageBox.Show( txtCourseCode.Text +" 0r" +txtTitle.Text+ "already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            clearentry();
        }


    }
}

