using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Sluzbeno_vozilo
    {
        public virtual int Registarska_Oznaka { get; protected set; }
        public virtual string Boja{ get; set; }
        public virtual string Tip{ get; set; }
        public virtual string Model{ get; set; }
        public virtual string Proizvodjac{ get; set; }
        
        public Sluzbeno_vozilo()
        {

        }
    }
}
