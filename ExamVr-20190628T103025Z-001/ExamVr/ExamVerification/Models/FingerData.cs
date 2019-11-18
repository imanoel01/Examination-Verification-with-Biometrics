using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamVerification.Models
{
    public class FingerData
    {
        public int Id { get; set; }
        public string MatricNo { get; set; }
        public byte [] Fingerprint { get; set; }
    }
}
