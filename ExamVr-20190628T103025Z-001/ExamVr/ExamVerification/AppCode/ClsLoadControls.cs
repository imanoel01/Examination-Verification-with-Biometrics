using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamVerification.AppCode
{
  public  class ClsLoadControls
    {
        public void LoadFaculty(ComboBox cboFaculty,DataTable dt)
        {
            cboFaculty.Items.Clear();
           
        }
    }
}
