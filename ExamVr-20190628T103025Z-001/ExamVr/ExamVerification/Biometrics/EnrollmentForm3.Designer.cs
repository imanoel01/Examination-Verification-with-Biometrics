namespace Enrollment
{
    partial class EnrollmentForm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMatric = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbDept = new MetroFramework.Controls.MetroComboBox();
            this.cmbfaculty = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnnCapture = new MetroFramework.Controls.MetroButton();
            this.btnnStart = new MetroFramework.Controls.MetroButton();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbMatric);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cmbDept);
            this.groupBox1.Controls.Add(this.cmbfaculty);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(493, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // cmbMatric
            // 
            this.cmbMatric.FormattingEnabled = true;
            this.cmbMatric.ItemHeight = 23;
            this.cmbMatric.Location = new System.Drawing.Point(16, 194);
            this.cmbMatric.Name = "cmbMatric";
            this.cmbMatric.Size = new System.Drawing.Size(214, 29);
            this.cmbMatric.TabIndex = 2;
            this.cmbMatric.UseSelectable = true;
            this.cmbMatric.SelectedIndexChanged += new System.EventHandler(this.cmbMatric_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 167);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(166, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Students Yet to be Enrolled";
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.ItemHeight = 23;
            this.cmbDept.Location = new System.Drawing.Point(16, 130);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(176, 29);
            this.cmbDept.TabIndex = 1;
            this.cmbDept.UseSelectable = true;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // cmbfaculty
            // 
            this.cmbfaculty.FormattingEnabled = true;
            this.cmbfaculty.ItemHeight = 23;
            this.cmbfaculty.Location = new System.Drawing.Point(16, 66);
            this.cmbfaculty.Name = "cmbfaculty";
            this.cmbfaculty.Size = new System.Drawing.Size(176, 29);
            this.cmbfaculty.TabIndex = 0;
            this.cmbfaculty.UseSelectable = true;
            this.cmbfaculty.SelectedIndexChanged += new System.EventHandler(this.cmbfaculty_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Department";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Faculty";
            // 
            // metroButton1
            // 
            this.metroButton1.ForeColor = System.Drawing.Color.Blue;
            this.metroButton1.Location = new System.Drawing.Point(16, 288);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(194, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "SAVE BIOMETRIC AND IMAGE";
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnnCapture);
            this.groupBox2.Controls.Add(this.btnnStart);
            this.groupBox2.Controls.Add(this.picBox);
            this.groupBox2.Controls.Add(this.cmbResolution);
            this.groupBox2.Controls.Add(this.cmbDevice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Capture";
            // 
            // btnnCapture
            // 
            this.btnnCapture.ForeColor = System.Drawing.Color.Red;
            this.btnnCapture.Location = new System.Drawing.Point(132, 198);
            this.btnnCapture.Name = "btnnCapture";
            this.btnnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnnCapture.TabIndex = 13;
            this.btnnCapture.Text = "Capture";
            this.btnnCapture.UseCustomForeColor = true;
            this.btnnCapture.UseSelectable = true;
            this.btnnCapture.Click += new System.EventHandler(this.btnnCapture_Click);
            // 
            // btnnStart
            // 
            this.btnnStart.ForeColor = System.Drawing.Color.Green;
            this.btnnStart.Location = new System.Drawing.Point(43, 198);
            this.btnnStart.Name = "btnnStart";
            this.btnnStart.Size = new System.Drawing.Size(75, 23);
            this.btnnStart.TabIndex = 12;
            this.btnnStart.Text = "Start";
            this.btnnStart.UseCustomForeColor = true;
            this.btnnStart.UseSelectable = true;
            this.btnnStart.Click += new System.EventHandler(this.btnnStart_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(43, 19);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(192, 173);
            this.picBox.TabIndex = 11;
            this.picBox.TabStop = false;
            // 
            // cmbResolution
            // 
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(333, 66);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(121, 21);
            this.cmbResolution.TabIndex = 1;
            this.cmbResolution.SelectedIndexChanged += new System.EventHandler(this.cmbResolution_SelectedIndexChanged_1);
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(333, 20);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(121, 21);
            this.cmbDevice.TabIndex = 0;
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resolution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Camera Device";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(16, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE STUDENT DATA";
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EnrollmentForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EnrollmentForm3";
            this.Text = "EnrollmentForm3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnrollmentForm3_FormClosing);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cmbMatric;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbDept;
        private MetroFramework.Controls.MetroComboBox cmbfaculty;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnnCapture;
        private MetroFramework.Controls.MetroButton btnnStart;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}