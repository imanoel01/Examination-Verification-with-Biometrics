using ExamVerification.AppCode;
using ExamVerification.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Enrollment
{
    public partial class VerificationForm2 : CaptureForm
    {
        ClsModule clsModule = new ClsModule();
        ClsExam clsExam = new ClsExam();
        ClsVerification clsVerification = new ClsVerification();
        ClsBiometric clsBiometric = new ClsBiometric();
        
        

        public int departmentId { get; set; }
        public int semesterId { get; set; }
        public string session { get; set; }

        public int courseid { get; set; }

        public VerificationForm2()
        {
            InitializeComponent();
            clsModule.getAllFaculty(cmbfaculty);
            clsModule.getSemester(cmbsemester);
            clsModule.getAcademicSession(cmbsessions);
        }
        private void cmbfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsModule.getDepartmentByFaculty(cmbdept,int.Parse(cmbfaculty.SelectedValue.ToString()));
        }

        private void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentId= int.Parse(cmbdept.SelectedValue.ToString());
            clsModule.FacultyID = int.Parse(cmbfaculty.SelectedValue.ToString());
            clsModule.DepartmentId = departmentId;
            clsModule.getCourseByDeptSem(cmbcourse);

        }
        public DateTime startTime { get; set; }
        public DateTime stopTime { get; set; }
        async void TimerUpdater()
        {
            while (true)
            {
                txtCurrentTime.Text = DateTime.Now.ToString();
                await Task.Delay(1000);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateentry())
                {
                    int isexists;
                    clsExam.session = cmbsessions.SelectedValue.ToString();
                    clsExam.courseid = int.Parse(cmbcourse.SelectedValue.ToString());
                    clsExam.checkexamreport();

                    isexists = clsExam.Isexists;
                    if (isexists == 1)
                    {
                        MessageBox.Show( cmbcourse.SelectedText.ToString() +"exam has already been conducted");
                    }
                    else
                    {


                        disableControls();

                        btnEnd.Visible = true;
                        btnStart.Enabled = false;
                        //clsModule.Session=


                        getExpectedStudent();
                        clsBiometric.Semester = semesterId;
                        clsBiometric.Session = session;
                        clsBiometric.Courseid = courseid;

                        //FeaturesData=   clsBiometric.getFingerPrintTemplate();

                        ValidateUser();
                        ErrorImage();
                      txtStudentVerified.Text=  clsBiometric.getVerifiedStudentCount(int.Parse(session), courseid).ToString();

                        startTime = DateTime.Now;
                        txtStartTime.Text = startTime.ToString();
                        TimerUpdater();

                    }
                    
	{

                    }

               

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }


        void getExpectedStudent()
        {
            session= cmbsessions.SelectedValue.ToString();

            clsVerification.Session = session;
            clsVerification.courseID = int.Parse(cmbcourse.SelectedValue.ToString());
            clsVerification.getallstudentbycourse(txtExpectedstudent);
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


        #region added from verificationform
        public void Verify(DPFP.Template template)
        {

            //List<Record> result = await VerifyFingerPrint();


            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }
      
        Label lbl = new Label();

        public void getdata()
        {

        }

        #region Oldverification
        /**
        public IEnumerable<Record> FeaturesData { get; set; }
        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);
            
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            ClsBiometric biom = new ClsBiometric();
            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            lbl = lblmatric;

            if (features != null)
            {
                // Compare the feature set with our template

                bool isverified = false;


                IEnumerable recordEnumerable = new List<Record>();
                //invokecontrols();

                recordEnumerable = FeaturesData;
                Stopwatch sw = new Stopwatch();

                sw.Start();
                foreach (Record rec in recordEnumerable)
                {
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    Verificator.Verify(features, rec.Template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        matric = rec.ID;
                        MakeReport("The fingerprint was VERIFIED.");

                        isverified = true;
                        if (this.lblmatric.InvokeRequired)
                        {
                            this.lblmatric.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.lblmatric.Text = this.matric; ;
                            });
                        }
                        else
                        {
                            this.lblmatric.Text = this.matric;
                        }

                        if (this.txtStudentverified.InvokeRequired)
                        {
                            this.txtStudentverified.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.txtStudentverified.Text = this.matric; ;
                            });
                        }
                        else
                        {
                            this.txtStudentverified.Text = this.matric;
                        }

                        clsBiometric.getVerifiedStudentCount(txtStudentverified, lblMessage, matric, session, courseid);

                        break;
                    }
                    else
                    {
                        isverified = false;
                    }
                }
                if (!isverified)
                {
                    MakeReport("NOT VERIFIED");
                }
                
               
               
                sw.Stop();
                    
     

                
            }

        
           
        }
    */
        #endregion


        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // VerificationForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.ClientSize = new System.Drawing.Size(678, 354);
        //    this.Name = "VerificationForm";
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
        #endregion

        private void cmbsemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            semesterId= int.Parse(cmbsemester.SelectedValue.ToString());
            clsModule.DepartmentId = departmentId;
            clsModule.Semester = semesterId;
            clsModule.getCourseByDeptSem(cmbcourse);
        }

        private void cmbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
        //session = cmbsessions.SelectedValue.ToString();
            courseid = int.Parse(cmbcourse.SelectedValue.ToString());
        }

        private void cmbsessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            session = cmbsessions.SelectedValue.ToString();
        }

        void invokecontrols()
        {
            if (this.txtStudentVerified.InvokeRequired)
            {
                this.txtStudentVerified.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.txtStudentVerified.Text = clsBiometric.getVerifiedStudentCount(int.Parse(session), courseid).ToString(); ;
                });
            }
            else
            {
                this.txtStudentVerified.Text = clsBiometric.getVerifiedStudentCount(int.Parse(session), courseid).ToString();
            }

            if (this.txtAttempts.InvokeRequired)
            {
                this.txtAttempts.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.txtAttempts.Text = AllAttempts.ToString();
                });
            }
            else
            {
                this.txtAttempts.Text = AllAttempts.ToString();
            }
        }

        #region TestVerifcation
        public Dictionary<string, DPFP.Template > Samples = new Dictionary<string,DPFP.Template >();


        public Dictionary<string, byte[]> verifiedImages = new Dictionary<string,byte[]>();
        public int AllAttempts { get; set; }
        protected override void Process(DPFP.Sample Sample)
        {
            picBox.Image = null;
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            AllAttempts++;


            if (features != null)
            {
                // Compare the feature set with our template
                int count=0;
                bool isverified = false;
                foreach (DPFP.Template template in this.Samples.Values)
                {
                    
                        
                    
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    Verificator.Verify(features, template, ref result);
                    //result = Verificator.Verify(features, rec.Template,  H7FFFFFFF / 100000);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                      matric=  Samples.Keys.ElementAt(count);
                        isverified = true;

                        break;
                    }
                    else
                    {
                        isverified = false;
                    }
                    count++;

                }
                count = 0;
                try
                {
  if (isverified)
                {
                    byte[] nm;
                        
                    MakeReport(matric);
                    verifiedImages.TryGetValue(matric,out nm);
                    picBox.Image = ConverBinaryToImage(nm);
                int newVerified=    clsBiometric.updateVerifiedStudent(matric, courseid, int.Parse(session),semesterId,ClsUserSetting.Usersetting );
                    Console.Beep(7000, 400);
                        if (newVerified==1)
                        {
                            MakeReport("The fingerprint was VERIFIED.");
                        }
                        else
                        {
                            MakeReport("Already VERIFIED.");
                        }
                    


                }
                else
                {
                
                  int  length = 2;
                    picBox.Image = ConverBinaryToImage(errimage);
                    for (int i = 0; i < length; i++)
                    {
                        Console.Beep(450,450);

                    }

                    MakeReport("The fingerprint was NOT VERIFIED.");
                }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {

                    invokecontrols();
                }




            }

        }
        Connection con = new Connection();
        void ValidateUser()
        {
            
            SqlCommand cmd = new SqlCommand("getFingerPrintCourse", con.ActiveCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@session", session);
            cmd.Parameters.AddWithValue("@semester", semesterId);
            cmd.Parameters.AddWithValue("@course", courseid);

            using (SqlDataReader data = cmd.ExecuteReader())
            {
                var id = "";

                while (data.Read())
                {
                    id = data["MatricNo"].ToString();
                    byte[] fingerPrint = (byte[])data["fingerprint"];

                   byte[] Image = (byte[])data["Image"];
                    verifiedImages.Add(id,Image);

                    Samples.Add(id,new DPFP.Template(new MemoryStream(fingerPrint)) );

                }
            }

         
           
        }

        byte[] errimage;
//ClsBiometric clsBiometric = new ClsBiometric();
         void ErrorImage()
        {
            try
            {
                
                errimage = clsBiometric.getErrorImage();
               
            }
            catch (Exception)
            {

                throw ;
            }
        }
        Image ConverBinaryToImage(byte[] data)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        bool validateentry()
        {
            if (string.IsNullOrWhiteSpace(txtlecturer.Text)  || cmbfaculty.SelectedIndex == 0
                || cmbdept.SelectedIndex == 0 || cmbsemester.SelectedIndex == 0 || cmbcourse.SelectedIndex == 0 )
            {
                MessageBox.Show("All fields are required for Examination Setup");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
