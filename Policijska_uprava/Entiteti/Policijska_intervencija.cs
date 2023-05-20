using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Policijska_intervencija
    {
        public virtual int ID { get; protected set; }
        public virtual string Opis_Intervencije { get; set; }
        public virtual DateTime Datum_Intervencije { get; set; }
        public virtual string Vreme_Intervencije { get; set; }
        public virtual Objekat Objekat { get; set; }
        public virtual Patrola PatrolaIntervenise { get; set; }
        public Policijska_intervencija()
        {

        }
    }
}
