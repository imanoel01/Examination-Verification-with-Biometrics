using ExamVerification.AppCode;
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
    public partial class NewFaculty : MetroFramework.Forms.MetroForm
    {
        public string userId { get; set; }
        public NewFaculty(string UserID)
        {
            InitializeComponent();
            userId = UserID;

        }
        public string message { get; set; }
        bool validateEntry()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtShortname.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("All entries are required", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }
        void ClearEntries()
        {
            txtName.Clear();
            txtShortname.Clear();
            txtDescription.Clear();
            txtName.Focus();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    ClsModule faculty = new ClsModule();
                    faculty.Name = txtName.Text.ToUpper();
                    faculty.ShortName = txtShortname.Text.ToUpper();
                    faculty.Description = txtDescription.Text;
                    faculty.Created_By = userId;
                    faculty.newFaculty();
                    message = faculty.ErrorMessage+ "Would you like to add a new faculty again";
                    DialogResult dialogResult=
                    MessageBox.Show(message,"Message",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    ClearEntries();
                    if (dialogResult==DialogResult.Yes)
                    {
                        ClearEntries();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    return;
                }


            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }

        }
    }
}
