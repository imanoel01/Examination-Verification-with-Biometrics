using DarrenLee.Media;
using Enrollment;
using ExamVerification.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment
{
    public partial class EnrollmentForm3 : CaptureForm
    {
        ClsModule clsmodule = new ClsModule();
        ClsBiometric clsBiometric = new ClsBiometric();
        private void cmbfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsmodule.getDepartmentByFaculty(cmbDept, int.Parse(cmbfaculty.SelectedValue.ToString()));
        }
        public string id { get; set; }
        public string name { get; set; }
        public string User { get; set; }
      
        public EnrollmentForm3()
        {
            InitializeComponent();
            clsmodule.getAllFaculty(cmbfaculty);
           getInfo();
            User = ClsUserSetting.Usersetting;

        }
        void getnonenrolled()
        {
            clsBiometric.facultyId = int.Parse(cmbfaculty.SelectedValue.ToString());

            clsBiometric.departmentId = int.Parse(cmbDept.SelectedValue.ToString());
            clsBiometric.getNonEnrolledStudent(cmbMatric);
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            getnonenrolled();
        }

        private void cmbMatric_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = cmbMatric.SelectedValue.ToString();
            name = cmbMatric.SelectedText.ToString();
            //if (cmbDept.SelectedIndex==0)
            //{
            //    IsStudentAvailable = false;
            //    //MakeReport("No Student Available For Capture");
            //    Stop();
            //}
            //else
            //{
            //    IsStudentAvailable = true ;
            //    Start();
            //}
        }



        #region addded from enrollmentform
        public string message { get; set; }

        public delegate void OnTemplateEventHandler(DPFP.Template template);

        public event OnTemplateEventHandler OnTemplate;

        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Enrollment";
            Enroller = new DPFP.Processing.Enrollment();            // Create an enrollment.
            UpdateStatus();
        }

        public byte[] FingerTemplate { get; set; }
        public byte[] Image { get; set; }

        bool isfingertemplate = false;
        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null) try
                {
                    //MakeReport("The fingerprint feature set was created.");`
                    MakeReport("The fingerprint has  been captured.");
                    Enroller.AddFeatures(features);// Add feature set to template.

                }
                finally
                {
                    UpdateStatus();


                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing

                            byte[] fingerData = Enroller.Template.Bytes;

                            FingerTemplate = fingerData;

                            isfingertemplate = true;
                         


                            MakeReport(message);
                            SetPrompt("Click Close to and reopend to enroll new Student");
                            MakeReport(id + " has been enrolled. Click Close this window to capture another Student");

                            Stop();

                            break;


                        //OnTemplate(Enroller.Template);


                        case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            break;
                    }

                  
                }
          
        }

        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }

        private DPFP.Processing.Enrollment Enroller;

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // EnrollmentForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.ClientSize = new System.Drawing.Size(1032, 409);
        //    this.Name = "EnrollmentForm";
        //    this.Load += new System.EventHandler(this.EnrollmentForm_Load);
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}

        #endregion


        #region CameraCode

        int count = 0;
        Camera myCamera = new Camera();
      
        private void getInfo()
        {
            var cameraDevice = myCamera.GetCameraSources();
            var cameraResolution = myCamera.GetSupportedResolutions();
            foreach (var d in cameraDevice)
                cmbDevice.Items.Add(d);
            foreach (var r in cameraResolution)
                cmbResolution.Items.Add(r);

            cmbDevice.SelectedIndex = 0;
            cmbDevice.SelectedIndex = 0;
        }

        private void mycamer_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {

            try
            {
 Image img = e.GetFrame();
            picBox.Image = img;
            }
            catch (Exception)
            {

               
            }
           
        }

     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
        }



        public bool IsStudentAvailable { get; set; }

        byte[] ConvertImageBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            //getInfo();
          
        }

        private void cmbDevice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            myCamera.ChangeCamera(cmbDevice.SelectedIndex);

        }

        private void cmbResolution_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            myCamera.Start(cmbResolution.SelectedIndex);

        }
        bool isimage = false;
        private void btnCapture_Click_1(object sender, EventArgs e)
        {
           
        }



        #endregion
       
        private void metroButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void EnrollmentForm3_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
            Stop();
        }

        private void btnnStart_Click(object sender, EventArgs e)
        {
            myCamera.OnFrameArrived += mycamer_OnFrameArrived;
            myCamera.Start();
        }

        private void btnnCapture_Click(object sender, EventArgs e)
        {
            myCamera.Stop();
            var nm = ConvertImageBinary(picBox.Image);
            Image = nm;
            isimage = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbMatric.SelectedIndex < 1)
            {
                MessageBox.Show("No student available for capture", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            matric = cmbMatric.SelectedValue.ToString();
            int message;
            if (isimage && isfingertemplate)
            {
                clsBiometric.SaveFingerData(matric, FingerTemplate, Image,User);
                message = clsBiometric.RetMessage;

                if (message==1)
                {
                    MessageBox.Show(matric + " has successfully been enrolled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ooops! something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //MessageBox.Show(message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.Close();

            }
            else
            {
                MessageBox.Show("No image or FingerPrint Captured","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;

            }
        }
    }
}
