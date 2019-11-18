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
    public partial class StudentVerification : UserControl
    {
        ClsModule clsModule = new ClsModule();
        ClsVerification clsVerification = new ClsVerification();
        ClsExam clsExam = new ClsExam();
        public StudentVerification(string User)
        {
            InitializeComponent();
            user = User;
            init();
        }
        public string  user { get; set; }
        void init()
        {
            clsModule.getAllFaculty(cmbfaculty);
            clsModule.getSemester(cmbsemester);
            clsModule.getAcademicSession(cmbsessions);
        }
        public int faculty { get; set; }
        public int department { get; set; }
        public int courseid { get; set; }
        public int semester { get; set; }

        public string Session { get; set; }


        private void cmbfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            faculty = int.Parse(cmbfaculty.SelectedValue.ToString());
            clsModule.getDepartmentByFaculty(cmbdept, faculty);
        }

        private void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            //semester = int.Parse(cmbsemester.SelectedValue.ToString());
            department = int.Parse(cmbdept.SelectedValue.ToString());
            clsModule.DepartmentId = department;
            clsModule.Semester = semester;
            clsModule.getCourseByDeptSem(cmbcourse);


        }

        private void cmbsemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            semester = int.Parse(cmbsemester.SelectedValue.ToString());
            //department = int.Parse(cmbdept.SelectedValue.ToString());
            clsModule.DepartmentId = department;
            clsModule.Semester = semester;
            clsModule.getCourseByDeptSem(cmbcourse);





        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //            try
            //            {
            //                int isexists;
            //                clsExam.session = cmbsessions.SelectedValue.ToString();
            //                clsExam.courseid = int.Parse(cmbcourse.SelectedValue.ToString());
            //                clsExam.checkexamreport();

            //                isexists = clsExam.Isexists;
            //                if (isexists==1)
            //                {
            //                    MessageBox.Show("this exams has already been conducted");
            //                }
            //                else { 


            //                disableControls();
            //                groupBox2.Visible = true;
            //                btnEnd.Visible = true;
            //                btnStart.Enabled = false;
            //                //clsModule.Session=


            //                getExpectedStudent();
            //}
            //            }
            //            catch (Exception ex)
            //            {

            //                MessageBox.Show(ex.ToString());
            //            }

            MainForm mainForm = new MainForm(2);
           //btnStart_Click.Click += mainForm.
           
            mainForm.ShowDialog();
        }


        void disableControls()
        {
            cmbfaculty.Enabled = false;
            cmbdept.Enabled = false;
            cmbcourse.Enabled = false;
            cmbsemester.Enabled = false;
            txtlecturer.Enabled = false;
            cmbsessions.Enabled = false;
        }

        void getExpectedStudent()
        {

            clsVerification.Session = cmbsessions.SelectedValue.ToString();
            clsVerification.courseID = int.Parse(cmbcourse.SelectedValue.ToString());
            clsVerification.getallstudentbycourse(txtExpectedstudent);
        }

        private void cmbsessions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            verifyStudent();
        }

        void verifyStudent()
        {
            try
            {
                string msg;
                clsVerification.MatricNo = txtmatric.Text;
                clsVerification.Session = cmbsessions.SelectedValue.ToString();
                clsVerification.courseID = int.Parse(cmbcourse.SelectedValue.ToString());
                clsVerification.verifiyStudent(txtStudentverified);
                msg = clsVerification.ErrorMessage;
                MessageBox.Show(msg);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbdiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdiscipline.SelectedIndex==0)
            {
                hidealldiscplinecase();
                cleardiscipline();
                cmbNodiscipline.Visible = true;
                lblNooffence.Visible = true;
                isdiscipline = 1;
                
            }
            else
            {
                hidealldiscplinecase();
                cleardiscipline();
                cmbNodiscipline.Visible = false;
                lblNooffence.Visible = false;
                cmbNodiscipline.SelectedIndex = -1;
                isdiscipline = 0;
            }
        }

        private void cmbNodiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
           int foo= int.Parse(cmbNodiscipline.SelectedIndex.ToString());

            nodisciplinecase(foo);

            
        }

        void nodisciplinecase(int no)
        {
            switch (no)
            {
                case 0:
                    hidealldiscplinecase();
                    cleardiscipline();
                    lblmat1.Visible = true; txtmat1.Visible = true; lbloff1.Visible = true; txtoff1.Visible = true;
                    break;
                case 1:
                    hidealldiscplinecase();
                    cleardiscipline();
                    lblmat1.Visible = true; txtmat1.Visible = true; lbloff1.Visible = true; txtoff1.Visible = true;
                    lblmat2.Visible = true; txtmat2.Visible = true; lbloff2.Visible = true; txtoff2.Visible = true;
                    break;
                case 2:
                    hidealldiscplinecase();
                    cleardiscipline();
                    lblmat1.Visible = true; txtmat1.Visible = true; lbloff1.Visible = true; txtoff1.Visible = true;
                    lblmat2.Visible = true; txtmat2.Visible = true; lbloff2.Visible = true; txtoff2.Visible = true;
                    lblmat3.Visible = true; txtmat3.Visible = true; lbloff3.Visible = true; txtoff3.Visible = true;
                    break;
                case 3:
                    hidealldiscplinecase();
                    cleardiscipline();
                    lblmat1.Visible = true; txtmat1.Visible = true; lbloff1.Visible = true; txtoff1.Visible = true;
                    lblmat2.Visible = true; txtmat2.Visible = true; lbloff2.Visible = true; txtoff2.Visible = true;
                    lblmat3.Visible = true; txtmat3.Visible = true; lbloff3.Visible = true; txtoff3.Visible = true;
                    lblmat4.Visible = true; txtmat4.Visible = true; lbloff4.Visible = true; txtoff4.Visible = true;
                    break;
                case 4:
                    hidealldiscplinecase();
                    cleardiscipline();
                    lblmat1.Visible = true; txtmat1.Visible = true; lbloff1.Visible = true; txtoff1.Visible = true;
                    lblmat2.Visible = true; txtmat2.Visible = true; lbloff2.Visible = true; txtoff2.Visible = true;
                    lblmat3.Visible = true; txtmat3.Visible = true; lbloff3.Visible = true; txtoff3.Visible = true;
                    lblmat4.Visible = true; txtmat4.Visible = true; lbloff4.Visible = true; txtoff4.Visible = true;
                    lblmat5.Visible = true; txtmat5.Visible = true; lbloff5.Visible = true; txtoff5.Visible = true;
                    break;

                default:

                    throw new ArgumentNullException();
            }
        }

        void hidealldiscplinecase()
        {
            lblmat1.Visible = false; txtmat1.Visible = false; lbloff1.Visible = false; txtoff1.Visible = false;
            lblmat2.Visible = false; txtmat2.Visible = false; lbloff2.Visible = false; txtoff2.Visible = false;
            lblmat3.Visible = false; txtmat3.Visible = false; lbloff3.Visible = false; txtoff3.Visible = false;
            lblmat4.Visible = false; txtmat4.Visible = false; lbloff4.Visible = false; txtoff4.Visible = false;
            lblmat5.Visible = false; txtmat5.Visible = false; lbloff5.Visible = false; txtoff5.Visible = false;
        }

        void cleardiscipline()
        {
             txtmat1.Clear();  txtoff1.Clear();
             txtmat2.Clear();  txtoff2.Clear();
             txtmat3.Clear();  txtoff3.Clear();
             txtmat4.Clear();  txtoff4.Clear();
             txtmat5.Clear();  txtoff5.Clear();
        }
        public int isdiscipline { get; set; }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtExpectedstudent.Text)>0)
            {
                try
                {
                    clsExam.courseid = int.Parse(cmbcourse.SelectedValue.ToString());
                    clsExam.session = cmbsessions.SelectedValue.ToString();
                    clsExam.totalregistered = txtExpectedstudent.Text;
                    clsExam.totalpresent = txtStudentverified.Text;
                    clsExam.facultyid = int.Parse(cmbfaculty.SelectedValue.ToString());
                    clsExam.departmentid = int.Parse(cmbdept.SelectedValue.ToString());
                    clsExam.discipline = isdiscipline;
                    clsExam.Lecturer = txtlecturer.Text;
                    clsExam.Createdby = user;
                    clsExam.SaveReport();

                    MessageBox.Show("Verification of student has ended");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("No student registered for this course");
                return;
            }


        }
    }
}
//(@coursecode, @Session, @TotalRegistered, @Totalpresent, @faculty, @department, @disciplinarycase, @lecturer, @createdby)