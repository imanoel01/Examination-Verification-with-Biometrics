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
    public partial class AddLGA : MetroFramework.Forms.MetroForm
    {
        public AddLGA()
        {
            InitializeComponent();
            init();
        }
        ClsModule clsModule = new ClsModule();
        void init()
        {
            clsModule.getAllState(cmbstate);
        }
        private void AddLGA_Load(object sender, EventArgs e)
        {

        }
        public string message { get; set; }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtlga.Text))
            {
                clsModule.stateid = int.Parse(cmbstate.SelectedValue.ToString());
                clsModule.lga = txtlga.Text;
                clsModule.newlga();
                message = clsModule.ErrorMessage;
                MessageBox.Show(message);
                txtlga.Clear();
            }
        }
    }
}
