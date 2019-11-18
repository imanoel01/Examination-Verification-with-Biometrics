using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Enrollment
{
	delegate void Function();	// a simple delegate for marshalling calls from event handlers to the GUI thread

   
    public partial class MainForm : Form
	{
        public string matric { get; set; }
        public MainForm(int i) 
		{
            
			InitializeComponent();
            if (i == 1)
            {
                EnrollButton.Visible = true;
                VerifyButton.Visible = false;
            }
            else
            {
                EnrollButton.Visible = false;
                VerifyButton.Visible = true;
            }
           
        }

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void EnrollButton_Click(object sender, EventArgs e)
		{
			//EnrollmentForm3 Enroller = new EnrollmentForm3();
			//Enroller.OnTemplate += this.OnTemplate;
			//Enroller.ShowDialog();
		}

		private void VerifyButton_Click(object sender, EventArgs e)
		{
			VerificationForm2 Verifier = new VerificationForm2();
			Verifier.Verify(Template);
            
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Fingerprint Template File (*.fpt)|*.fpt";
			if (save.ShowDialog() == DialogResult.OK) {
				using (FileStream fs = File.Open(save.FileName, FileMode.Create, FileAccess.Write)) {
					Template.Serialize(fs);
				}
			}
		}

		private void LoadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Fingerprint Template File (*.fpt)|*.fpt";
			if (open.ShowDialog() == DialogResult.OK) {
				using (FileStream fs = File.OpenRead(open.FileName)) {
					DPFP.Template template = new DPFP.Template(fs);
					//OnTemplate(template);
				}
			}
		}

		//private void OnTemplate(DPFP.Template template)
		//{
		//	this.Invoke(new Function(delegate()
		//	{
		//		Template = template;
		//		VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
		//		if (Template != null)
		//			MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
		//		else
		//			MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
		//	}));
		//}

		private DPFP.Template Template;
	}
}