using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Skolski_Broj_Telefona
    {
        public virtual string Broj { get; protected set; }
        public virtual SkolskiPolicajac SkolskiPolicajac { get; set; }

        public Skolski_Broj_Telefona()
        {

        }

    }
}
