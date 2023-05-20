using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Patrola
    {
        public virtual int Redni_Broj { get; protected set; }
        public virtual PolicajacPatrole Vodja_JMBG { get; set; }
        public virtual PolicajacPatrole Clan_JMBG { get; set; }
        public virtual Sluzbeno_vozilo Vozilo { get; set; }
        public virtual IList<Policijska_intervencija> Intervencije { get; set; }

        public Patrola()
        {
            Intervencije = new List<Policijska_intervencija>();
        }
    }
}
