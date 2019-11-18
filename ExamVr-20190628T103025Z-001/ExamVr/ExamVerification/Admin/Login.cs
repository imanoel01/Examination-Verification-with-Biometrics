using ExamVerification.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamVerification.AppCode.Admin
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            clearfields();
        }
        void clearfields()
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }
        bool validateentry()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username or Password empty");
                return false;
            }
            return true;
        }
        ClsUserSetting usersetings;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateentry())
                {
                    Adminn admin = new Adminn(); 
                    admin.Username = txtUsername.Text;
                    admin.Password = txtPassword.Text;
                     admin.VerifyLogin();
                    
                    if (admin.Status==1)
                    {
                        usersetings = new ClsUserSetting(txtUsername.Text);
                        string successMessage = string.Format("Welcome" + " " + txtUsername.Text+ " "+ admin.facdeptid);
                        MessageBox.Show((successMessage));
                        Form home = new Home(txtUsername.Text,admin.Usertype,admin.facdeptid);
                        this.Hide();
                        home.Show();
                       
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            
                        return;
                    }
             
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
