namespace ExamVerification.UserControls
{
    partial class StudentSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSerach = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.searchresult = new System.Windows.Forms.DataGridView();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchresult)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Student Details";
            // 
            // txtSerach
            // 
            // 
            // 
            // 
            this.txtSerach.CustomButton.Image = null;
            this.txtSerach.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtSerach.CustomButton.Name = "";
            this.txtSerach.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSerach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSerach.CustomButton.TabIndex = 1;
            this.txtSerach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSerach.CustomButton.UseSelectable = true;
            this.txtSerach.CustomButton.Visible = false;
            this.txtSerach.Lines = new string[0];
            this.txtSerach.Location = new System.Drawing.Point(126, 46);
            this.txtSerach.MaxLength = 32767;
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.PasswordChar = '\0';
            this.txtSerach.PromptText = "Enter Name or Matric no.";
            this.txtSerach.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSerach.SelectedText = "";
            this.txtSerach.SelectionLength = 0;
            this.txtSerach.SelectionStart = 0;
            this.txtSerach.ShortcutsEnabled = true;
            this.txtSerach.Size = new System.Drawing.Size(162, 23);
            this.txtSerach.TabIndex = 1;
            this.txtSerach.UseSelectable = true;
            this.txtSerach.WaterMark = "Enter Name or Matric no.";
            this.txtSerach.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSerach.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(312, 45);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Search";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.searchresult);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(22, 108);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(871, 329);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // searchresult
            // 
            this.searchresult.AllowUserToAddRows = false;
            this.searchresult.AllowUserToDeleteRows = false;
            this.searchresult.AllowUserToOrderColumns = true;
            this.searchresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchresult.Location = new System.Drawing.Point(0, 0);
            this.searchresult.Name = "searchresult";
            this.searchresult.ReadOnly = true;
            this.searchresult.Size = new System.Drawing.Size(871, 329);
            this.searchresult.TabIndex = 2;
            // 
            // StudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtSerach);
            this.Controls.Add(this.metroLabel1);
            this.Name = "StudentSearch";
            this.Size = new System.Drawing.Size(910, 459);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSerach;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView searchresult;
    }
}
