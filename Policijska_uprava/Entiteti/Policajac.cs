using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
    public class Policajac
    {
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Ime_Roditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime Datum_Rodjenja { get; set; }
        public virtual DateTime Datum_Prijema { get; set; }
        public virtual string Adresa { get; set; }
        public virtual char Pol { get; set; }
        public virtual string Naziv_Skole_Kursa { get; set; }
        public virtual DateTime Datum_Sticanja_Diplome { get; set; }
        public virtual string Cin { get; set; }
        public virtual DateTime Datum_Sticanja_Cina { get; set; }
        public virtual Policijska_stanica Policijska_stanica { get; set; }

        public Policajac()
        {
        }
    }

    public class PolicajacVanredneSituacije : Policajac
    {
        public virtual string Naziv_Vestine { get; set; }
        public virtual string Poseduje_Sertifikat { get; set; }
        public virtual string Pohadjao_Kurs { get; set; }
        public virtual DateTime Datum_Zavrsetka_Kursa { get; set; }
        public virtual DateTime Datum_Sticanja_Sertifikata { get; set; }
    }
    public class SkolskiPolicajac : Policajac
    {
        public virtual string Naziv_Skole { get; set; }
        public virtual string Skola_adresa { get; set; }
        public virtual string Tip_Skole { get; set; }
        public virtual string Osoba_Za_Kontakt { get; set; }

    }
    public class ZamenikZaKrvneDelikte : Policajac
    {

    }
    public class ZamenikZaSaobracaj: Policajac
    {

    }
    public class ZamenikZaVanredneSituacije : Policajac
    {

    }
    public class Nacelnik : Policajac
    {

    }
    public class Pozornik : Policajac
    {
        public virtual string Naziv_Ulice { get; set; }
    }
    public class Sef : Policajac
    {

    }
    public class ZamenikSefa : Policajac
    {

    }
    public class PolicajacPatrole : Policajac
    {
    }
}
