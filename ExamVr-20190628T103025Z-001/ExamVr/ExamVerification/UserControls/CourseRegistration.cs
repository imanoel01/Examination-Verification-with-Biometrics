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
using ExamVerification.Models;
using System.Collections.ObjectModel;

namespace ExamVerification.UserControls
{
    public partial class CourseRegistration : UserControl
    {
        ClsModule clsmodule = new ClsModule();
        ClsStudent clsStudent = new ClsStudent();
        public CourseRegistration(string User)
        {
            InitializeComponent();
            init();
            user = User;
        }
        public int faculty { get; set; }
        public int semester { get; set; }
        public int session { get; set; }
        public int deptid { get; set; }

        public int no_course { get; set; }
        public string user { get; set; }
        public string message { get; set; }

        private ObservableCollection<StudentCourseReg> _course;
        //IEnumerable<StudentCourseReg> Addcourse()
        //  {
        //      _course = new ObservableCollection<StudentCourseReg>
        //      {
        //          new StudentCourseReg{courseid=}
        //      };
        //      return _course;
        //  }
        void init()
        {
            clsmodule.getAllFaculty(cmbfaculty);
            clsmodule.getSemester(cmbSemester);
            //clsmodule.getCourseByFacSem(cmbcourse1);
            clsmodule.getAcademicSession(cmbsession);
            //initializing the faculty and semester
            //cmbfaculty.SelectedIndex = 1;get
            //cmbSemester.SelectedIndex = 1;
        }

        private void cmbfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfaculty.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                faculty = int.Parse(cmbfaculty.SelectedValue.ToString());
                if (cmbSemester.SelectedIndex > 0)
                {
                    semester = int.Parse(cmbSemester.SelectedValue.ToString());
                    clsmodule.FacultyID = faculty;
                    clsmodule.Semester = semester;
                    getDataforCourses();

                }
                else
                {
                    return;
                }
            }
        }


        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemester.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                semester = int.Parse(cmbSemester.SelectedValue.ToString());
                if (cmbfaculty.SelectedIndex > -1)
                {
                    faculty = int.Parse(cmbfaculty.SelectedValue.ToString());
                    clsmodule.FacultyID = faculty;
                    clsmodule.Semester = semester;
                    getDataforCourses();

                }
                else
                {
                    return;
                }
            }
        }

        private void cmbfaculty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbfaculty.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                faculty = int.Parse(cmbfaculty.SelectedValue.ToString());
                if (cmbSemester.SelectedIndex > -1)
                {
                    semester = int.Parse(cmbSemester.SelectedValue.ToString());
                    clsmodule.FacultyID = faculty;
                    clsmodule.Semester = semester;
                    getDataforCourses();
                    clsmodule.getDepartmentByFaculty(cmbDept, faculty);
                    

                }
                else
                {
                    return;
                }
            }
        }

        #region logic Show controls based on the number of course


        void nocourse(int courses)
        {
            switch (courses)
            {
                case 4:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    break;

                case 5:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    break;

                case 6:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    break;

                case 7:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    cmbcourse7.Visible = true;
                    break;
                case 8:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    cmbcourse7.Visible = true;
                    cmbcourse8.Visible = true;

                    break;

                case 9:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    cmbcourse7.Visible = true;
                    cmbcourse8.Visible = true;
                    cmbcourse9.Visible = true;

                    break;

                case 10:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    cmbcourse7.Visible = true;
                    cmbcourse8.Visible = true;
                    cmbcourse9.Visible = true;
                    cmbcourse10.Visible = true;

                    break;
                case 11:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    cmbcourse7.Visible = true;
                    cmbcourse8.Visible = true;
                    cmbcourse9.Visible = true;
                    cmbcourse10.Visible = true;
                    cmbcourse11.Visible = true;

                    break;

                case 12:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    cmbcourse7.Visible = true;
                    cmbcourse8.Visible = true;
                    cmbcourse9.Visible = true;
                    cmbcourse10.Visible = true;
                    cmbcourse11.Visible = true;
                    cmbcourse12.Visible = true;
                    break;
                case 13:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    cmbcourse7.Visible = true;
                    cmbcourse8.Visible = true;
                    cmbcourse9.Visible = true;
                    cmbcourse10.Visible = true;
                    cmbcourse11.Visible = true;
                    cmbcourse12.Visible = true;
                    cmbcourse13.Visible = true;
                    break;
                case 14:
                    cmbcourse1.Visible = true;
                    cmbcourse2.Visible = true;
                    cmbcourse3.Visible = true;
                    cmbcourse4.Visible = true;
                    cmbcourse5.Visible = true;
                    cmbcourse6.Visible = true;
                    cmbcourse7.Visible = true;
                    cmbcourse8.Visible = true;
                    cmbcourse9.Visible = true;
                    cmbcourse10.Visible = true;
                    cmbcourse11.Visible = true;
                    cmbcourse12.Visible = true;
                    cmbcourse13.Visible = true;
                    cmbcourse14.Visible = true;
                    break;




                default:
                    break;
            }
        }
        #endregion
        private void cmbnocourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbMatric.SelectedIndex==0))
            {
                coursesvisibility();
                no_course = int.Parse(cmbnocourse.SelectedValue.ToString());
                nocourse(no_course);
                clsmodule.FacultyID = faculty;
                clsmodule.Semester = semester;
            }
            else
            {
                MessageBox.Show("No Student Availabe for Course Registration", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbnocourse.SelectedIndex = 0;            }

        }

        void coursesvisibility()
        {
            cmbcourse1.Visible = false;
            cmbcourse2.Visible = false;
            cmbcourse3.Visible = false;
            cmbcourse4.Visible = false;
            cmbcourse5.Visible = false;
            cmbcourse6.Visible = false;
            cmbcourse7.Visible = false;
            cmbcourse8.Visible = false;
            cmbcourse9.Visible = false;
            cmbcourse10.Visible = false;
            cmbcourse11.Visible = false;
            cmbcourse12.Visible = false;
            cmbcourse13.Visible = false;
            cmbcourse14.Visible = false;
        }

        private void CourseRegistration_Load(object sender, EventArgs e)
        {
            clsmodule.getStudentCourseRange(cmbnocourse);
          

        }

        #region Load data into coontrols 
        void getDataforCourses()
        {
            clsmodule.getCourseByFacSem(cmbcourse1);
            clsmodule.getCourseByFacSem(cmbcourse2);
            clsmodule.getCourseByFacSem(cmbcourse3);
            clsmodule.getCourseByFacSem(cmbcourse4);
            clsmodule.getCourseByFacSem(cmbcourse5);
            clsmodule.getCourseByFacSem(cmbcourse6);
            clsmodule.getCourseByFacSem(cmbcourse7);
            clsmodule.getCourseByFacSem(cmbcourse8);
            clsmodule.getCourseByFacSem(cmbcourse9);
            clsmodule.getCourseByFacSem(cmbcourse10);
            clsmodule.getCourseByFacSem(cmbcourse11);
            clsmodule.getCourseByFacSem(cmbcourse12);
            clsmodule.getCourseByFacSem(cmbcourse13);
            clsmodule.getCourseByFacSem(cmbcourse14);


        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
        

            if (cmbfaculty.SelectedIndex<1||cmbDept.SelectedIndex<1||cmbSemester.SelectedIndex<1||cmbMatric.SelectedIndex<1
                ||cmbnocourse.SelectedIndex<1)
            {
                MessageBox.Show("All fields are required");
                return;

            }
            else {
              
                
                #region working Course Registration


                int[] CourseChose = new int[14];
                CourseChose[0] = int.Parse(cmbcourse1.SelectedValue.ToString());
                CourseChose[1] = int.Parse(cmbcourse2.SelectedValue.ToString());
                CourseChose[2] = int.Parse(cmbcourse3.SelectedValue.ToString());
                CourseChose[3] = int.Parse(cmbcourse4.SelectedValue.ToString());
                CourseChose[4] = int.Parse(cmbcourse5.SelectedValue.ToString());
                CourseChose[5] = int.Parse(cmbcourse6.SelectedValue.ToString());
                CourseChose[6] = int.Parse(cmbcourse7.SelectedValue.ToString());
                CourseChose[7] = int.Parse(cmbcourse8.SelectedValue.ToString());
                CourseChose[8] = int.Parse(cmbcourse9.SelectedValue.ToString());
                CourseChose[9] = int.Parse(cmbcourse10.SelectedValue.ToString());
                CourseChose[10] = int.Parse(cmbcourse11.SelectedValue.ToString());
                CourseChose[11] = int.Parse(cmbcourse12.SelectedValue.ToString());
                CourseChose[12] = int.Parse(cmbcourse13.SelectedValue.ToString());
                CourseChose[13] = int.Parse(cmbcourse14.SelectedValue.ToString());
                int i = 0;
                for (; ; )
                {
                    if (i < no_course)
                    {
                        try
                        {
                            clsStudent.MatricNo = cmbMatric.SelectedValue.ToString();
                            clsStudent.CourseID = CourseChose[i];
                            clsStudent.Session = cmbsession.SelectedValue.ToString();
                            clsStudent.Semester = semester;
                            clsStudent.CreatedBy = user;
                            clsStudent.DepartentID = int.Parse(cmbDept.SelectedValue.ToString());

                            clsStudent.courseReg();
                            //message = clsStudent.ErrorMessage;
                            i++;
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                        break;
                }
                MessageBox.Show(cmbMatric.SelectedValue.ToString() + " has successfuly registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();

                #endregion
            }
        }

    

    //#endregion






IEnumerable<StudentCourseReg> Addcourse(ComboBox course = null)
{

    bool isexists = _course.Contains(course.SelectedValue);
    if (isexists)
    {
        MessageBox.Show("Course already Selected");
        return _course;
    }
    else
    {
        _course = new ObservableCollection<StudentCourseReg>
            {
                new StudentCourseReg{courseid=int.Parse(course.SelectedValue.ToString())} };
        return _course;
    };
}

public Dictionary<string, string> CourseReg = new Dictionary<string, string>();



        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
           deptid = int.Parse(cmbDept.SelectedValue.ToString());
              session  =int.Parse( cmbsession.SelectedValue.ToString());
            clsmodule.getNonRegStudent(cmbMatric, deptid,session,semester);
        }

        void ClearControls()
        {
            cmbDept.SelectedIndex = 0;
            cmbfaculty.SelectedIndex = 0;
            cmbMatric.SelectedIndex = 0;
            cmbnocourse.SelectedIndex = 0;
            cmbnocourse.SelectedIndex = 0;
            cmbSemester.SelectedIndex = 0;
            cmbsession.SelectedIndex = 0;
            cmbcourse1.SelectedIndex = 0;
            cmbcourse2.SelectedIndex = 0;
            cmbcourse3.SelectedIndex = 0;
            cmbcourse4.SelectedIndex = 0;
            cmbcourse5.SelectedIndex = 0;
            cmbcourse6.SelectedIndex = 0;
            cmbcourse7.SelectedIndex = 0;
            cmbcourse8.SelectedIndex = 0;
            cmbcourse9.SelectedIndex = 0;
            cmbcourse10.SelectedIndex = 0;
            cmbcourse11.SelectedIndex = 0;
            cmbcourse12.SelectedIndex = 0;
            cmbcourse13.SelectedIndex = 0;
            cmbcourse14.SelectedIndex = 0;
            
        }

        private void cmbsession_SelectedIndexChanged(object sender, EventArgs e)
        {
           session= int.Parse(cmbsession.SelectedValue.ToString());
        }
    }
}
