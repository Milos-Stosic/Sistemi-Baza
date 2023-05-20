using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Policijska_stanica
    {
        public virtual int ID { get; protected set; }
        public virtual string Naziv{ get; set; }
        public virtual string Adresa { get; set; }
        public virtual int Broj_sluzbenih_vozila { get; set; }
        public virtual string Opstina { get; set; }
        public virtual DateTime Datum_osnivanja { get; set; }
        public virtual Policajac SefStanice { get; set; }
        public virtual IList<Objekat> Objekti { get; set; }
        public virtual IList<Policajac> Policajci { get; set; }

        public Policijska_stanica()
        {
            Objekti = new List<Objekat>();
            Policajci = new List<Policajac>();
        }
    }
}
