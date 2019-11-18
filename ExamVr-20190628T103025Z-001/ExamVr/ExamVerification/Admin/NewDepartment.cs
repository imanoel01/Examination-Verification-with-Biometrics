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
    public partial class NewDepartment : MetroFramework.Forms.MetroForm
    {
        ClsModule clsdept = new ClsModule();
        public NewDepartment(string User)
        {
            InitializeComponent();
            clsdept.getAllFaculty(cmbfaculty);
            user = User;
        }
        public string user { get; set; }
        public string message { get; set; }

        bool validateentries()
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtdescription.Text) || cmbfaculty.SelectedIndex == -1)
            {

                MessageBox.Show("You have missed a required field");
                return false;
            }
            else
            {

                return true;
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateentries())
                {
                    clsdept.Name = txtname.Text.ToUpper();
                    clsdept.ShortName = txtshortname.Text.ToUpper();
                    clsdept.Description = txtdescription.Text;
                    clsdept.FacultyID = int.Parse(cmbfaculty.SelectedValue.ToString());
                    clsdept.Created_By = user;
            
                    clsdept.newDepartment();
                    message = clsdept.ErrorMessage+". Would you like to add new department";
                  DialogResult dialogResult=  MessageBox.Show(message,"Success",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (dialogResult==DialogResult.Yes)
                    {
                       
                        
                        clearentry();
                    }
                    else
                    {
                        this.Close();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Oops! Spomething went wrong");
                    return;
                }

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.ToString());
            }


        }
        public void clearentry()
        {
            txtdescription.Clear();
            txtname.Clear();
            txtshortname.Clear();
            cmbfaculty.SelectedIndex = 0;
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            clearentry();
        }
    }
}
