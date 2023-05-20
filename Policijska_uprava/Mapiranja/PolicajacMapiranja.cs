using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Policijska_uprava.Entiteti;

namespace Policijska_uprava.Mapiranja
{
    public class PolicajacMapiranja : ClassMap<Policajac>
    {
        public PolicajacMapiranja()
        {
            Table("POLICAJAC");

            Id(x => x.Jmbg, "JMBG").GeneratedBy.Assigned();
        

            Map(x => x.Ime, "IME");
            Map(x => x.Ime_Roditelja, "IME_RODITELJA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Datum_Rodjenja, "DATUM_RODJENJA");
            Map(x => x.Datum_Prijema, "DATUM_PRIJEMA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Pol, "POL");
            Map(x => x.Naziv_Skole_Kursa, "NAZIV_SKOLE_KURSA");
            Map(x => x.Datum_Sticanja_Diplome, "DATUM_STICANJA_DIPLOME");
            Map(x => x.Cin, "CIN"); 
            Map(x => x.Datum_Sticanja_Cina, "DATUM_STICANJA_CINA");

            References(x => x.Policijska_stanica)
            .Column("POLICIJSKA_STANICA_ID")
            .LazyLoad().Cascade.All();
        }
    }

    class PolicajacVanredneSituacijeMapiranja : SubclassMap<PolicajacVanredneSituacije>
    {
        public PolicajacVanredneSituacijeMapiranja()
        {
            Table("VANREDNA_SITUACIJA");
            KeyColumn("JMBG");

            Map(x => x.Naziv_Vestine, "NAZIV_VESTINE");
            Map(x => x.Pohadjao_Kurs, "POHADJAO_KURS");
            Map(x => x.Poseduje_Sertifikat, "POSEDUJE_SERTIFIKAT");
            Map(x => x.Datum_Zavrsetka_Kursa, "DATUM_ZAVRSETKA_KURSA");
            Map(x => x.Datum_Sticanja_Sertifikata, "DATUM_STICANJA_SERTIFIKATA");

        }
    }

    class PolicajacPatroleMapiranja : SubclassMap<PolicajacPatrole>
    {
        public PolicajacPatroleMapiranja()
        {
            Table("OSTALI");
            KeyColumn("JMBG");

        }
    }

    class PozornikMapiranja : SubclassMap<Pozornik>
    {
        public PozornikMapiranja()
        {
            Table("POZORNIK");
            KeyColumn("JMBG");
            Map(x => x.Naziv_Ulice, "NAZIV_ULICE");
        }
    }

    class ZamenikZaSaobracajMapiranja : SubclassMap<ZamenikZaSaobracaj>
    {
        public ZamenikZaSaobracajMapiranja()
        {
            
            Table("ZAMENIK_ZA_SAOBRACAJ");
            KeyColumn("JMBG");
        }
    }

    class SefMapiranja : SubclassMap<Sef>
    {
        public SefMapiranja()
        {
          
            Table("SEF");
            KeyColumn("JMBG");
        }
    }

    class ZamenikSefaMapiranja : SubclassMap<ZamenikSefa>
    {
        public ZamenikSefaMapiranja()
        {
            Table("ZAMENIK_SEFA");
            KeyColumn("JMBG");
        }
    }

    class SkolskiPolicajacMapiranja : SubclassMap<SkolskiPolicajac>
    {
        public SkolskiPolicajacMapiranja()
        {
           
            Table("SKOLSKI");
            KeyColumn("JMBG");


            Map(x => x.Naziv_Skole, "NAZIV_SKOLE");
            Map(x => x.Skola_adresa, "ADRESA_SKOLE");
            Map(x => x.Tip_Skole, "TIP_SKOLE");
            Map(x => x.Osoba_Za_Kontakt, "OSOBA_ZA_KONTAKT");
        }
    }
    
    class NacelnikMapiranja : SubclassMap<Nacelnik>
    {
        public NacelnikMapiranja()
        {
            Table("NACELNIK");
            KeyColumn("JMBG");
        }
    }

    class ZamenikZaKrvneDelikteMapiranja : SubclassMap<ZamenikZaKrvneDelikte>
    {
        public ZamenikZaKrvneDelikteMapiranja()
        {
            Table("ZAMENIK_ZA_KRVNE_DELIKTE");
            KeyColumn("JMBG");
        }
    }

    class ZamenikZaVanredneSituacijeMapiranja : SubclassMap<ZamenikZaVanredneSituacije>
    {
        public ZamenikZaVanredneSituacijeMapiranja()
        {
            Table("ZAMENIK_ZA_VANREDNE_SITUACIJE");
            KeyColumn("JMBG");
        }
    }
}