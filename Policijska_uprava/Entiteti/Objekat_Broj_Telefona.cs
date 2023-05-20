using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Objekat_Broj_Telefona
    {
        public virtual string Broj { get; protected set; }
        public virtual Objekat Objekat { get; set; }

        public Objekat_Broj_Telefona()
        {

        }
    }
}
