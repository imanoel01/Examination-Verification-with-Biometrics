using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamVerification.AppCode
{
   public  class ClsUserSetting
    {
        public static  string Usersetting { get; set; }

        public ClsUserSetting(string username)
        {
            Usersetting = username;
        }    

    }
}
