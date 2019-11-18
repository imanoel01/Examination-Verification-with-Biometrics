namespace ExamVerification.Admin
{
    partial class AddLGA
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
            this.cmbstate = new MetroFramework.Controls.MetroComboBox();
            this.txtlga = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbstate
            // 
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.ItemHeight = 23;
            this.cmbstate.Location = new System.Drawing.Point(110, 98);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(121, 29);
            this.cmbstate.TabIndex = 0;
            this.cmbstate.UseSelectable = true;
            // 
            // txtlga
            // 
            // 
            // 
            // 
            this.txtlga.CustomButton.Image = null;
            this.txtlga.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtlga.CustomButton.Name = "";
            this.txtlga.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtlga.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtlga.CustomButton.TabIndex = 1;
            this.txtlga.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtlga.CustomButton.UseSelectable = true;
            this.txtlga.CustomButton.Visible = false;
            this.txtlga.Lines = new string[0];
            this.txtlga.Location = new System.Drawing.Point(110, 155);
            this.txtlga.MaxLength = 32767;
            this.txtlga.Name = "txtlga";
            this.txtlga.PasswordChar = '\0';
            this.txtlga.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlga.SelectedText = "";
            this.txtlga.SelectionLength = 0;
            this.txtlga.SelectionStart = 0;
            this.txtlga.ShortcutsEnabled = true;
            this.txtlga.Size = new System.Drawing.Size(121, 23);
            this.txtlga.TabIndex = 1;
            this.txtlga.UseSelectable = true;
            this.txtlga.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtlga.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "State";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 155);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(32, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "LGA";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(110, 218);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "SAVE";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddLGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 315);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtlga);
            this.Controls.Add(this.cmbstate);
            this.Name = "AddLGA";
            this.Text = "AddLGA";
            this.Load += new System.EventHandler(this.AddLGA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbstate;
        private MetroFramework.Controls.MetroTextBox txtlga;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}