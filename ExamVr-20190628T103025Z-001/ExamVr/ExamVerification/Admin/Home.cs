using Enrollment;
using ExamVerification.UserControls;
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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public string user { get; set; }
        public Home(string User,int AccountType, int FacDept)
        {
            InitializeComponent();
            user = User;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            paneldetails.Controls.Clear();
            NewStudent newStudent = new NewStudent(user);
            paneldetails.Controls.Add(newStudent);
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFaculty newFaculty = new NewFaculty(user);
            newFaculty.ShowDialog();
        }

        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewDepartment newDepartment = new NewDepartment(user);
            newDepartment.ShowDialog();
        }

        private void courseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NewCourse newDepartment = new NewCourse(user);
            newDepartment.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            paneldetails.Controls.Clear();
            CourseRegistration newreg = new CourseRegistration(user);
            paneldetails.Controls.Add(newreg);
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            paneldetails.Controls.Clear();
            StudentVerification newver = new StudentVerification(user);
            paneldetails.Controls.Add(newver);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneldetails.Controls.Clear();
            StudentSearch newver = new StudentSearch();
            paneldetails.Controls.Add(newver);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneldetails.Controls.Clear();
            ViewReport newver = new ViewReport();
            paneldetails.Controls.Add(newver);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();

            //DialogResult dialog = MessageBox.Show("Do you really want to close the application?",
            //   "Exit", MessageBoxButtons.YesNo);
            //if (dialog == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else if (dialog == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}

        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            EnrollmentForm3 Enroller = new EnrollmentForm3();
            //Enroller.OnTemplate += this.OnTemplate;
            Enroller.ShowDialog();
        }

        private void examVerificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            VerificationForm2 Verifier = new VerificationForm2();
            Verifier.Verify(Template);
        }

        private DPFP.Template Template;
    }
}
