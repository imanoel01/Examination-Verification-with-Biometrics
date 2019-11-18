using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamVerification.AppCode;
using MetroFramework.Forms;

namespace ExamVerification
{
    public partial class Form1 : MetroForm
    {
        Adminn admin = new Adminn();
        public Form1()
        {
            InitializeComponent();
            admin.getUserType(cmbUserType);
        }
        public bool validate()
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) || string.IsNullOrWhiteSpace(txtAddress.Text)
                || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmP.Text)
                )

            {
                MessageBox.Show("You are missing a required field");
                return false;
            }
            else
            {
                if (txtPassword.Text != txtConfirmP.Text)
                {
                    MessageBox.Show("Passwords do not match");
                    return false;
                }
                
                return true;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validate())
                    return;
                admin.Firstname = txtFirstname.Text;
                admin.Lastname = txtLastname.Text;
                admin.Middlename = txtMiddlename.Text;
                admin.Address = txtAddress.Text;
                admin.Username = txtUsername.Text;
                admin.Password = txtPassword.Text;
                admin.DOB = dob.Text;
                
                admin.Usertype = int.Parse(cmbUserType.SelectedValue.ToString());
                admin.facdeptid = int.Parse(cmbCorDept.SelectedValue.ToString());
                
                admin.newAdmin();

                string SuccessMessage = string.Format(txtUsername.Text + " " + " has been successfully added");
                MessageBox.Show(SuccessMessage);
                ResetControls();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        void ResetControls()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtMiddlename.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmP.Clear();
            txtFirstname.Focus();
            cmbUserType.SelectedIndex = 0;
        }
       
        private void dob_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            admin.getFacOrCOursebyAccountType(cmbCorDept, int.Parse(cmbUserType.SelectedValue.ToString()));
        }
    }
}
