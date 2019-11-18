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
using Enrollment;

namespace ExamVerification.UserControls
{
    public partial class NewStudent : UserControl
    {
        ClsModule clsModule = new ClsModule();
        ClsStudent clsStudent = new ClsStudent();
        public NewStudent(string User)
        {
            InitializeComponent();
            user = User;
            init();
        }
        public string user { get; set; }
        public int facultyid { get; set; }
        public string message { get; set; }

        void init()
        {
            ClsModule clsModule = new ClsModule();
            clsModule.getAllFaculty(cmbFaculty);
            clsModule.getDepartmentByFaculty(cmbDepartment, facultyid);
            clsModule.getAllState(cmbState);
            clsModule.GetGender(cmbGender);

        }

        private void NewStudent_Load(object sender, EventArgs e)
        {

        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            facultyid = int.Parse( cmbFaculty.SelectedValue.ToString());
            clsModule.getDepartmentByFaculty(cmbDepartment, facultyid);
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsModule.stateid = int.Parse(cmbState.SelectedValue.ToString()) ;
            clsModule.getlgabystate(cmblga);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateentry())
                {
  clsStudent.Firstname = txtFirstname.Text.ToUpper();
                clsStudent.Middlename = txtMiddlename.Text.ToUpper();
                clsStudent.Lastname = txtLastname.Text.ToUpper();
                clsStudent.StateofOrigin = int.Parse(cmbState.SelectedValue.ToString());
                clsStudent.LGA = int.Parse(cmblga.SelectedValue.ToString());
                clsStudent.FacultyID = facultyid;
                clsStudent.DepartentID = int.Parse(cmbDepartment.SelectedValue.ToString());
                clsStudent.MatricNo = txtMatricno.Text.ToUpper();
                    clsStudent.Gender = int.Parse(cmbGender.SelectedValue.ToString());
                clsStudent.CreatedBy = user;
                clsStudent.AddStudent();

                    if (clsStudent.Status==1)
                    {
                        MessageBox.Show(txtMatricno.Text + " was successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearcontrols();
                    }
                    //            DialogResult dialogResult=    MessageBox.Show(message+"           Do you want to add a new student again??","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    //                    if (dialogResult==DialogResult.Yes)
                    //                    {
                    //clearcontrols();
                    //                    }
                    //                    else
                    //                    {
                    //                    }
                    else
                    {
                        MessageBox.Show(txtMatricno.Text + " already exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.Beep(1000, 300);
                    }

                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          

        }

        bool validateentry()
        {
            if (string.IsNullOrWhiteSpace(txtLastname.Text) || string.IsNullOrWhiteSpace(txtFirstname.Text) || cmbDepartment.SelectedIndex == 0
                || cmbState.SelectedIndex == 0 || cmbFaculty.SelectedIndex == 0 || cmblga.SelectedIndex == 0 || string.IsNullOrWhiteSpace(txtMiddlename.Text)
                || string.IsNullOrWhiteSpace(txtMatricno.Text))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (txtMatricno.Text.Length!=14)
                {
                    MessageBox.Show("Matric No not in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
        }

        void clearcontrols()
        {
            txtFirstname.Clear();
            txtMiddlename.Clear();
            txtLastname.Clear();
            cmbState.SelectedIndex = 0;
            cmblga.SelectedIndex = 0;
            cmbFaculty.SelectedIndex = 0;
            cmbDepartment.SelectedIndex = 0;
            txtMatricno.Clear();
            cmbGender.SelectedIndex = 0;
        }


  
    }
}

