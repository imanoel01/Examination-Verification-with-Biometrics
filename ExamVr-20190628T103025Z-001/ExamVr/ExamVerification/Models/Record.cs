using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamVerification.Models
{
    public class Record
    {
        private string m_id;
        private DPFP.Template m_template;
        public Record(string id, DPFP.Template template)
        {
            if (id != null && template != null)
            {
                m_id = id;
                m_template = template;
            }
            else
            {
                throw new ArgumentException("Valid Record");
            }

        }
        public string ID { get { return m_id; } }
        public DPFP.Template Template { get { return m_template; } }
    }
}