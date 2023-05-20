using Policijska_uprava.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava
{
    //Klase:
    public class PolicajacBasic
    {
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Ime_Roditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual char Pol { get; set; }
        public virtual DateTime Datum_Prijema { get; set; }
        public virtual DateTime Datum_Rodjenja { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Naziv_Skole_Kursa { get; set; }
        public virtual DateTime Datum_Sticanja_Diplome { get; set; }
        public virtual string Cin { get; set; }
        public virtual DateTime Datum_Sticanja_Cina { get; set; }

        public PolicajacBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema,
            DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina)
        {
            this.Jmbg = jmbg;
            this.Ime = licno_Ime;
            this.Ime_Roditelja = ime_Roditelja;
            this.Prezime = prezime;
            this.Pol = pol;
            this.Datum_Prijema = datum_Prijema;
            this.Datum_Rodjenja = datum_Rodjenja;
            this.Adresa = adresa;
            this.Naziv_Skole_Kursa = naziv_Skole;
            this.Datum_Sticanja_Diplome = datum_Sticanja_Diplome;
            this.Cin = cin;
            this.Datum_Sticanja_Cina = datum_Sticanja_Cina;
        }

        public PolicajacBasic()
        {
        }
    }
    public class PolicajacVanredneSituacijeBasic : PolicajacBasic
    {
        public virtual string Naziv_Vestine { get; set; }
        public virtual string Poseduje_Sertifikat { get; set; }
        public virtual string Pohadjao_Kurs { get; set; }
        public virtual DateTime Datum_Zavrsetka_Kursa { get; set; }
        public virtual DateTime Datum_Sticanja_Sertifikata { get; set; }
        public PolicajacVanredneSituacijeBasic()
        {

        }
        public PolicajacVanredneSituacijeBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema,
            DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina,
            string naziv_Vestine, string poseduje_Sertifikat, string pohadjao_Kurs,
            DateTime datum_Zavrsetka_Kursa, DateTime datum_Sticanja_Sertifikata)
            : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
            Naziv_Vestine = naziv_Vestine;
            Poseduje_Sertifikat = poseduje_Sertifikat;
            Pohadjao_Kurs = pohadjao_Kurs;
            Datum_Zavrsetka_Kursa = datum_Zavrsetka_Kursa;
            Datum_Sticanja_Sertifikata = datum_Sticanja_Sertifikata;
        }
    }
    public class SkolskiPolicajacBasic : PolicajacBasic
    {
        public SkolskiPolicajacBasic()
        {
        }

        public SkolskiPolicajacBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema,
            DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina,
            string naziv_skole, string skola_Adresa, string tip_Skole, string osoba_Za_Kontakt)
            : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
            Naziv_Skole = naziv_skole;
            Skola_adresa = skola_Adresa;
            Tip_Skole = tip_Skole;
            Osoba_Za_Kontakt = osoba_Za_Kontakt;
        }

        public virtual string Naziv_Skole { get; set; }
        public virtual string Skola_adresa { get; set; }
        public virtual string Tip_Skole { get; set; }
        public virtual string Osoba_Za_Kontakt { get; set; }

    }
    public class ZamenikZaKrvneDelikteBasic : PolicajacBasic
    {
        public ZamenikZaKrvneDelikteBasic()
        {
        }

        public ZamenikZaKrvneDelikteBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema, DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina) : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
        }
    }
    public class ZamenikZaSaobracajBasic : PolicajacBasic
    {
        public ZamenikZaSaobracajBasic()
        {
        }

        public ZamenikZaSaobracajBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema, DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina) : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
        }
    }
    public class ZamenikZaVanredneSituacijeBasic : PolicajacBasic
    {
        public ZamenikZaVanredneSituacijeBasic()
        {
        }

        public ZamenikZaVanredneSituacijeBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema, DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina) : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
        }
    }
    public class NacelnikBasic : PolicajacBasic
    {
        public NacelnikBasic()
        {
        }

        public NacelnikBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema, DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina) : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
        }
    }
    public class PozornikBasic : PolicajacBasic
    {
        public PozornikBasic()
        {
        }

        public PozornikBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema, DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina, string naziv_Ulice) : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
        }

        public virtual string Naziv_Ulice { get; set; }
    }
    public class SefBasic : PolicajacBasic
    {
        public SefBasic()
        {
        }

        public SefBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema, DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina) : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
        }
    }
    public class ZamenikSefaBasic : PolicajacBasic
    {
        public ZamenikSefaBasic()
        {
        }

        public ZamenikSefaBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema, DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina) : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
        }
    }
    public class PolicajacPatroleBasic : PolicajacBasic
    {
        public PolicajacPatroleBasic()
        {
        }

        public PolicajacPatroleBasic(string jmbg, string licno_Ime, string ime_Roditelja, string prezime, char pol, DateTime datum_Prijema, DateTime datum_Rodjenja, string adresa, string naziv_Skole, DateTime datum_Sticanja_Diplome, string cin, DateTime datum_Sticanja_Cina) : base(jmbg, licno_Ime, ime_Roditelja, prezime, pol, datum_Prijema, datum_Rodjenja, adresa, naziv_Skole, datum_Sticanja_Diplome, cin, datum_Sticanja_Cina)
        {
        }

        public virtual Patrola Patrola { get; set; }
    }

    public class AlarmniSistemBasic
    {
        public virtual int Id { get; set; }
        public virtual string Model { get; set; }
        public virtual DateTime Datum_Instalacije { get; set; }
        public virtual DateTime Datum_Poslednjeg_Atesta { get; set; }
        public virtual DateTime Datum_Poslednjeg_Servisa { get; set; }
        public virtual int Godina_Proizvodnje { get; set; }
        public virtual string Tehnicko_Lice { get; set; }

        public virtual DateTime Pocetak_Odrzavanja { get; set; }
        public virtual DateTime Zavrsetak_Odrzavanja { get; set; }


        public AlarmniSistemBasic()
        {

        }

        public AlarmniSistemBasic(int id, string model, DateTime datum_Instalacije, DateTime datum_Poslednjeg_Atesta, DateTime datum_Poslednjeg_Servisa, int godina_Proizvodnje, string tehnicko_Lice, DateTime pocetak_Odrzavanja, DateTime zavrsetak_Odrzavanja)
        {
            Id = id;
            Model = model;
            Datum_Instalacije = datum_Instalacije;
            Datum_Poslednjeg_Atesta = datum_Poslednjeg_Atesta;
            Datum_Poslednjeg_Servisa = datum_Poslednjeg_Servisa;
            Godina_Proizvodnje = godina_Proizvodnje;
            Tehnicko_Lice = tehnicko_Lice;
            Pocetak_Odrzavanja = pocetak_Odrzavanja;
            Zavrsetak_Odrzavanja = zavrsetak_Odrzavanja;
        }
    }
    public class IntervencijaBasic
    {
        public virtual int ID { get; set; }
        public virtual string Opis_Intervencije { get; set; }
        public virtual DateTime Datum_Intervencije { get; set; }
        public virtual string Vreme_Intervencije { get; set; }

        public IntervencijaBasic()
        {

        }

        public IntervencijaBasic(int iD, string opis_Intervencije, DateTime datum_Intervencije, string vreme_Intervencije)
        {
            this.ID = iD;
            this.Opis_Intervencije = opis_Intervencije;
            this.Datum_Intervencije = datum_Intervencije;
            this.Vreme_Intervencije = vreme_Intervencije;
        }
    }
    public class StanicaBasic
    {
        public StanicaBasic()
        {
        }

        public StanicaBasic(int iD, string naziv, string adresa, int brojVozila, string opstina, DateTime datum_Osnivanja)
        {
            ID = iD;
            Naziv = naziv;
            Adresa = adresa;
            BrojVozila = brojVozila;
            Opstina = opstina;
            Datum_Osnivanja = datum_Osnivanja;
        }

        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Adresa { get; set; }
        public virtual int BrojVozila { get; set; }
        public virtual string Opstina { get; set; }
        public virtual DateTime Datum_Osnivanja { get; set; }

    }
    public class ObjekatBasic
    {
        public ObjekatBasic()
        {
        }

        public ObjekatBasic(int iD, string adresa, string tip, float povrsina, string ime, string prezime, Policijska_stanica policijskaStanica)
        {
            ID = iD;
            Adresa = adresa;
            Tip = tip;
            Povrsina = povrsina;
            KontaktIme = ime;
            KontaktPrezime = prezime;
            PolicijskaStanica = policijskaStanica;
        }

        public virtual int ID { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Tip { get; set; }
        public virtual float Povrsina { get; set; }
        public virtual string KontaktIme { get; set; }
        public virtual string KontaktPrezime { get; set; }
        public virtual Policijska_stanica PolicijskaStanica { get; set; }
    }
}