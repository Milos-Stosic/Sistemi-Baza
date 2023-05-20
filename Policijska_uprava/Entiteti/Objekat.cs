using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Objekat
    {
        public virtual int Id { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Tip { get; set; }
        public virtual float Povrsina { get; set; }
        public virtual string KontaktIme { get; set; }
        public virtual string KontaktPrezime { get; set; }
        public virtual Policijska_stanica PolicijskaStanica { get; set; }
        public virtual IList<Alarmni_sistem> AlarmniSistemi { get; set; }
        public virtual IList<Objekat_Broj_Telefona> BrojeviTelefonaObjekta { get; set; }
        public virtual IList<Policijska_intervencija> PolicijskeIntervencije { get; set; }
        public Objekat()
        {
            AlarmniSistemi = new List<Alarmni_sistem>();
            BrojeviTelefonaObjekta = new List<Objekat_Broj_Telefona>();
            PolicijskeIntervencije = new List<Policijska_intervencija>();
        }
    }
}
