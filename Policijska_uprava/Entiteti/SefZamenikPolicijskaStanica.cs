using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class SefZamenikPolicijskaStanica
    {
        public virtual int ID { get; set; }
        public virtual Policijska_stanica Policijska_stanica { get; set; }

        public virtual Sef Sef { get; set; }
        public virtual ZamenikSefa Zamenik { get; set; }
    }
}
