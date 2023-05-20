using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Alarmni_sistem
    {
        public virtual int Serijski_Broj { get; set; }
        public virtual int Godina_Proizvodnje { get; set; }
        public virtual string Model { get; set; }
        public virtual DateTime Datum_Instalacije { get; set; }
        public virtual DateTime Datum_Poslednjeg_Atesta { get; set; }
        public virtual DateTime Datum_Poslednjeg_Servisa { get; set; }
        public virtual string Opis_Poslednjeg_Kvara { get; set; }
        public virtual string Tehnicko_Lice { get; set; }
        public virtual DateTime Pocetni_Datum { get; set; }
        public virtual DateTime Poslednji_Datum { get; set; }//Krajnji
        public virtual Objekat Objekat { get; set; }

        public virtual float Opseg_frekvencije { get; set; }

        public Alarmni_sistem()
        {

        }
    }

    public class Pokret : Alarmni_sistem
    {
        public virtual int Osetljivost { get; set; }

    }

    public class Toplotni_Odraz : Alarmni_sistem
    {
        public virtual int Horizontalna_Rezolucija { get; set; }
        public virtual int Vertikalna_Rezolucija { get; set; }
    }

    public class Ultrazvuk : Alarmni_sistem
    {
        public virtual int Gornja_Frekvencija { get; set; }
        public virtual int Donja_Frekvencija { get; set; }

    }
}
