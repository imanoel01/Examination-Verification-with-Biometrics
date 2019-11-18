namespace ExamVerification.Admin
{
    partial class NewDepartment
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.txtshortname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbfaculty = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtdescription = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(85, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name";
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(183, 95);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PromptText = "enter department name";
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(200, 23);
            this.txtname.TabIndex = 0;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMark = "enter department name";
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtshortname
            // 
            // 
            // 
            // 
            this.txtshortname.CustomButton.Image = null;
            this.txtshortname.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtshortname.CustomButton.Name = "";
            this.txtshortname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtshortname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtshortname.CustomButton.TabIndex = 1;
            this.txtshortname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtshortname.CustomButton.UseSelectable = true;
            this.txtshortname.CustomButton.Visible = false;
            this.txtshortname.Lines = new string[0];
            this.txtshortname.Location = new System.Drawing.Point(183, 150);
            this.txtshortname.MaxLength = 32767;
            this.txtshortname.Name = "txtshortname";
            this.txtshortname.PasswordChar = '\0';
            this.txtshortname.PromptText = "enter short name for department";
            this.txtshortname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtshortname.SelectedText = "";
            this.txtshortname.SelectionLength = 0;
            this.txtshortname.SelectionStart = 0;
            this.txtshortname.ShortcutsEnabled = true;
            this.txtshortname.Size = new System.Drawing.Size(129, 23);
            this.txtshortname.TabIndex = 1;
            this.txtshortname.UseSelectable = true;
            this.txtshortname.WaterMark = "enter short name for department";
            this.txtshortname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtshortname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(85, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Acronym";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(85, 237);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Faculty";
            // 
            // cmbfaculty
            // 
            this.cmbfaculty.FormattingEnabled = true;
            this.cmbfaculty.ItemHeight = 23;
            this.cmbfaculty.Items.AddRange(new object[] {
            "select***"});
            this.cmbfaculty.Location = new System.Drawing.Point(183, 234);
            this.cmbfaculty.Name = "cmbfaculty";
            this.cmbfaculty.Size = new System.Drawing.Size(129, 29);
            this.cmbfaculty.TabIndex = 3;
            this.cmbfaculty.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(85, 193);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Description";
            // 
            // txtdescription
            // 
            // 
            // 
            // 
            this.txtdescription.CustomButton.Image = null;
            this.txtdescription.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtdescription.CustomButton.Name = "";
            this.txtdescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdescription.CustomButton.TabIndex = 1;
            this.txtdescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdescription.CustomButton.UseSelectable = true;
            this.txtdescription.CustomButton.Visible = false;
            this.txtdescription.Lines = new string[0];
            this.txtdescription.Location = new System.Drawing.Point(183, 193);
            this.txtdescription.MaxLength = 32767;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.PasswordChar = '\0';
            this.txtdescription.PromptText = "enter description";
            this.txtdescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdescription.SelectedText = "";
            this.txtdescription.SelectionLength = 0;
            this.txtdescription.SelectionStart = 0;
            this.txtdescription.ShortcutsEnabled = true;
            this.txtdescription.Size = new System.Drawing.Size(129, 23);
            this.txtdescription.TabIndex = 2;
            this.txtdescription.UseSelectable = true;
            this.txtdescription.WaterMark = "enter description";
            this.txtdescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.ForeColor = System.Drawing.Color.Blue;
            this.metroButton1.Location = new System.Drawing.Point(91, 294);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "SAVE";
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.ForeColor = System.Drawing.Color.Red;
            this.metroButton2.Location = new System.Drawing.Point(183, 293);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "CANCEL";
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // NewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 386);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cmbfaculty);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtshortname);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.metroLabel1);
            this.Name = "NewDepartment";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "NewDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Controls.MetroTextBox txtshortname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbfaculty;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtdescription;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}