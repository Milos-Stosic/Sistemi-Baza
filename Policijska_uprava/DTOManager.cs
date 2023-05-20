using NHibernate;
using Policijska_uprava.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava
{

    public class DTOManager
    {
        //staticke Metode
        #region Policajac
        public static List<PolicajacBasic> GetPolicajceBasic()
        {
            List<PolicajacBasic> pb = new List<PolicajacBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                
                IQueryable<Policajac> policajci = s.Query<Policajac>();

                foreach (Policajac p in policajci)
                { 
                    pb.Add(new PolicajacBasic(p.Jmbg, p.Ime, p.Ime_Roditelja, p.Prezime, p.Pol, p.Datum_Prijema,
                        p.Datum_Rodjenja, p.Adresa, p.Naziv_Skole_Kursa, p.Datum_Sticanja_Diplome,
                        p.Cin,p.Datum_Sticanja_Cina));
                }

                s.Close();

            }
            catch (Exception er)
            {
                throw er;
                //handle
            }
            return pb;
        }

        

        public static PolicajacBasic vratiPolicajca(string jmbg)
        {
            PolicajacBasic pb = new PolicajacBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Policajac p = s.Load<Policajac>(jmbg);
                pb = new PolicajacBasic(p.Jmbg, p.Ime, p.Ime_Roditelja, p.Prezime, p.Pol, p.Datum_Prijema,
                    p.Datum_Rodjenja, p.Adresa, p.Naziv_Skole_Kursa, p.Datum_Sticanja_Diplome, p.Cin,
                        p.Datum_Sticanja_Cina);

                s.Close();
            }
            catch (Exception ec)
            {
                throw ec;
            }

            return pb;
        }
        public static void azurirajPolicajca(PolicajacBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Policajac o = s.Load<Policajac>(p.Jmbg);

                o.Ime = p.Ime;
                o.Ime_Roditelja = p.Ime_Roditelja;
                o.Prezime = p.Prezime;
                o.Pol = p.Pol;
                o.Datum_Prijema = p.Datum_Prijema;
                o.Datum_Rodjenja = p.Datum_Rodjenja;
                o.Adresa = p.Adresa;
                o.Naziv_Skole_Kursa = p.Naziv_Skole_Kursa;
                o.Datum_Sticanja_Diplome = p.Datum_Sticanja_Diplome;
                o.Cin = p.Cin;
                o.Datum_Sticanja_Cina = p.Datum_Sticanja_Cina;

                s.Update(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                throw ec;
            }

        }

        #endregion
        public static void dodajAlarmniSistem(AlarmniSistemBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Alarmni_sistem o = new Alarmni_sistem
                {
                    Serijski_Broj = p.Id,
                    Model = p.Model,
                    Datum_Instalacije = p.Datum_Instalacije,
                    Godina_Proizvodnje = p.Godina_Proizvodnje,
                    Tehnicko_Lice = p.Tehnicko_Lice,
                    Pocetni_Datum = p.Pocetak_Odrzavanja,
                    Poslednji_Datum = p.Zavrsetak_Odrzavanja,
                };

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }
        public static void dodajIntervenciju(IntervencijaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Policijska_intervencija i = new Policijska_intervencija();
                {
                   
                };

                s.SaveOrUpdate(i);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }


        public static void dodajPolicajca(PolicajacBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Policijska_stanica stanica = s.Load<Policijska_stanica>(1);
                Policajac o= new Policajac()
                {
                    Jmbg = p.Jmbg,
                    Ime = p.Ime,
                    Ime_Roditelja = p.Ime_Roditelja,
                    Prezime = p.Prezime,
                    Pol = p.Pol,
                    Datum_Prijema = p.Datum_Prijema,
                    Datum_Rodjenja = p.Datum_Rodjenja,
                    Adresa = p.Adresa,
                    Naziv_Skole_Kursa = p.Naziv_Skole_Kursa,
                    Datum_Sticanja_Diplome = p.Datum_Sticanja_Diplome,
                    Cin = p.Cin,
                    Datum_Sticanja_Cina = p.Datum_Sticanja_Cina,
                    Policijska_stanica = stanica,

                };

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }

        public static void dodajPozornika(PozornikBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Policijska_stanica stanica = s.Load<Policijska_stanica>(1);
                Pozornik o = new Pozornik()
                {
                    Jmbg = p.Jmbg,
                    Ime = p.Ime,
                    Ime_Roditelja = p.Ime_Roditelja,
                    Prezime = p.Prezime,
                    Pol = p.Pol,
                    Datum_Prijema = p.Datum_Prijema,
                    Datum_Rodjenja = p.Datum_Rodjenja,
                    Adresa = p.Adresa,
                    Naziv_Skole_Kursa = p.Naziv_Skole_Kursa,
                    Datum_Sticanja_Diplome = p.Datum_Sticanja_Diplome,
                    Cin = p.Cin,
                    Datum_Sticanja_Cina = p.Datum_Sticanja_Cina,
                    Policijska_stanica = stanica,
                    Naziv_Ulice = p.Naziv_Ulice
                };

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }

        public static List<PozornikBasic> GetPozornikBasic()
        {
            List<PozornikBasic> pb = new List<PozornikBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQueryable<Pozornik> pozornici = s.Query<Pozornik>();

                foreach (Pozornik p in pozornici)
                {
                    pb.Add(new PozornikBasic(p.Jmbg, p.Ime, p.Ime_Roditelja, p.Prezime, p.Pol, p.Datum_Prijema, p.Datum_Rodjenja,p.Adresa, p.Naziv_Skole_Kursa, p.Datum_Sticanja_Diplome, p.Cin, p.Datum_Sticanja_Cina,p.Naziv_Ulice));
                }

                s.Close();
                return pb;
            }
            catch (Exception er)
            {
                throw er;
                //handle
            }
        }
        public static void obrisiPozornika(string jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Pozornik o = s.Load<Pozornik>(jmbg);



                s.Delete(o);
                s.Flush();



                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }

        public static void dodajSkolskog(SkolskiPolicajacBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Policijska_stanica stanica = s.Load<Policijska_stanica>(1);
                SkolskiPolicajac o = new SkolskiPolicajac()
                {
                    Jmbg = p.Jmbg,
                    Ime = p.Ime,
                    Ime_Roditelja = p.Ime_Roditelja,
                    Prezime = p.Prezime,
                    Pol = p.Pol,
                    Datum_Prijema = p.Datum_Prijema,
                    Datum_Rodjenja = p.Datum_Rodjenja,
                    Adresa = p.Adresa,
                    Naziv_Skole_Kursa = p.Naziv_Skole_Kursa,
                    Datum_Sticanja_Diplome = p.Datum_Sticanja_Diplome,
                    Cin = p.Cin,
                    Datum_Sticanja_Cina = p.Datum_Sticanja_Cina,
                    Policijska_stanica = stanica,
                    Naziv_Skole = p.Naziv_Skole,
                    Skola_adresa = p.Skola_adresa,
                    Tip_Skole = p.Tip_Skole,
                    Osoba_Za_Kontakt = p.Osoba_Za_Kontakt,
            
                };

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void obrisiSkolskog(string jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                SkolskiPolicajac o = s.Load<SkolskiPolicajac>(jmbg);



                s.Delete(o);
                s.Flush();



                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }
        public static List<SkolskiPolicajacBasic> GetSkolskiPolicajacBasic()
        {
            List<SkolskiPolicajacBasic> pb = new List<SkolskiPolicajacBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQueryable<SkolskiPolicajac> skolskiPolicajac = s.Query<SkolskiPolicajac>();

                foreach (SkolskiPolicajac p in skolskiPolicajac)
                {
                    pb.Add(new SkolskiPolicajacBasic(p.Jmbg, p.Ime, p.Ime_Roditelja, p.Prezime, p.Pol, p.Datum_Prijema, p.Datum_Rodjenja, p.Adresa, p.Naziv_Skole_Kursa, p.Datum_Sticanja_Diplome, p.Cin, p.Datum_Sticanja_Cina,  p.Naziv_Skole, p.Skola_adresa, p.Tip_Skole, p.Osoba_Za_Kontakt));
                }

                s.Close();
                return pb;
            }
            catch (Exception er)
            {
                throw er;
                //handle
            }
        }
        public static void dodajPolicajcaZaVanredne(PolicajacVanredneSituacijeBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Policijska_stanica stanica = s.Load<Policijska_stanica>(1);
                PolicajacVanredneSituacije o = new PolicajacVanredneSituacije()
                {   
                    Jmbg = p.Jmbg,
                    Ime = p.Ime,
                    Ime_Roditelja = p.Ime_Roditelja,
                    Prezime = p.Prezime,
                    Pol = p.Pol,
                    Datum_Prijema = p.Datum_Prijema,
                    Datum_Rodjenja = p.Datum_Rodjenja,
                    Adresa = p.Adresa,
                    Naziv_Skole_Kursa = p.Naziv_Skole_Kursa,
                    Datum_Sticanja_Diplome = p.Datum_Sticanja_Diplome,
                    Cin = p.Cin,
                    Datum_Sticanja_Cina = p.Datum_Sticanja_Cina,
                    Policijska_stanica = stanica,
                    Naziv_Vestine = p.Naziv_Vestine,
                    Poseduje_Sertifikat = p.Poseduje_Sertifikat,
                    Pohadjao_Kurs = p.Pohadjao_Kurs,
                    Datum_Zavrsetka_Kursa = p.Datum_Zavrsetka_Kursa,
                    Datum_Sticanja_Sertifikata = p.Datum_Sticanja_Sertifikata,

            };

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }

        public static void obrisiVanrednog(string jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                PolicajacVanredneSituacije o = s.Load<PolicajacVanredneSituacije>(jmbg);



                s.Delete(o);
                s.Flush();



                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }
            public static List<PolicajacVanredneSituacijeBasic> GetPolicajacVanredneSituacijeBasic()
        {
            List<PolicajacVanredneSituacijeBasic> pb = new List<PolicajacVanredneSituacijeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQueryable<PolicajacVanredneSituacije> policajacVanredneSituacije = s.Query<PolicajacVanredneSituacije>();

                foreach (PolicajacVanredneSituacije p in policajacVanredneSituacije)
                {
                    pb.Add(new PolicajacVanredneSituacijeBasic(p.Jmbg, p.Ime, p.Ime_Roditelja, p.Prezime, p.Pol, p.Datum_Prijema, p.Datum_Rodjenja, p.Adresa, p.Naziv_Skole_Kursa,
                        p.Datum_Sticanja_Diplome, p.Cin, p.Datum_Sticanja_Cina, p.Naziv_Vestine, p.Poseduje_Sertifikat,p.Pohadjao_Kurs,p.Datum_Zavrsetka_Kursa,p.Datum_Sticanja_Sertifikata));
                }

                s.Close();
                return pb;
            }
            catch (Exception er)
            {
                throw er;
                //handle
            }
        }

        public static List<IntervencijaBasic> GetIntervencijaBasic()
        {
            List<IntervencijaBasic> pb = new List<IntervencijaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQueryable<Policijska_intervencija> intervencija = s.Query<Policijska_intervencija>();

                foreach (Policijska_intervencija p in intervencija)
                {
                    pb.Add(new IntervencijaBasic(p.ID, p.Opis_Intervencije, p.Datum_Intervencije, p.Vreme_Intervencije));
                }

                s.Close();
                return pb;
            }
            catch (Exception er)
            {
                throw er;
                //handle
            }
        }
        public static List<AlarmniSistemBasic> GetAlarmniSistemBasic()
        {
            List<AlarmniSistemBasic> pb = new List<AlarmniSistemBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQueryable<Alarmni_sistem> alarmniSistem = s.Query<Alarmni_sistem>();

                foreach (Alarmni_sistem p in alarmniSistem)
                {
                    pb.Add(new AlarmniSistemBasic(p.Serijski_Broj, p.Model, p.Datum_Instalacije, p.Datum_Poslednjeg_Atesta, p.Datum_Poslednjeg_Servisa, p.Godina_Proizvodnje, p.Tehnicko_Lice, p.Pocetni_Datum, p.Poslednji_Datum));
                }

                s.Close();
                return pb;
            }
            catch (Exception er)
            {
                throw er;
                //handle
            }
        }

        public static void obrisiAlarmniSistem(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Alarmni_sistem o = s.Load<Alarmni_sistem>(id);



                s.Delete(o);
                s.Flush();



                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }

        public static void obrisiPolicajca(string jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Policajac o = s.Load<Policajac>(jmbg);



                s.Delete(o);
                s.Flush();



                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }

        public static void azurirajAlarmniSistem(AlarmniSistemBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                Alarmni_sistem o = s.Load<Alarmni_sistem>(p.Id);

                o.Model = p.Model;
                o.Datum_Instalacije = p.Datum_Instalacije;
                o.Godina_Proizvodnje = p.Godina_Proizvodnje;
                o.Datum_Poslednjeg_Servisa = p.Datum_Poslednjeg_Servisa;
                o.Datum_Poslednjeg_Atesta = p.Datum_Poslednjeg_Atesta;
                o.Tehnicko_Lice = p.Tehnicko_Lice;
                o.Pocetni_Datum = p.Pocetak_Odrzavanja;
                o.Poslednji_Datum = p.Zavrsetak_Odrzavanja;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }

        }

        public static AlarmniSistemBasic vratiAlarmniSistem(int id)
        {
            AlarmniSistemBasic pb = new AlarmniSistemBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Alarmni_sistem p = s.Load<Alarmni_sistem>(id);
                pb = new AlarmniSistemBasic(p.Serijski_Broj, p.Model, p.Datum_Instalacije,p.Datum_Poslednjeg_Atesta,p.Datum_Poslednjeg_Servisa, p.Godina_Proizvodnje, p.Tehnicko_Lice, p.Pocetni_Datum, p.Poslednji_Datum);

                s.Close();
            }
            catch (Exception ec)
            {
                throw ec;
            }

            return pb;
        }
        #region PolicijskaStanica
        public static List<StanicaBasic> GetStaniceBasic()
        {
            List<StanicaBasic> pb = new List<StanicaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQueryable<Policijska_stanica> Stanice = s.Query<Policijska_stanica>();

                foreach (Policijska_stanica p in Stanice)
                {
                    pb.Add(new StanicaBasic(p.ID, p.Naziv, p.Adresa, p.Broj_sluzbenih_vozila, p.Opstina, p.Datum_osnivanja));
                }

                s.Close();
                return pb;
            }
            catch (Exception er)
            {
                throw er;
                //handle
            }
        }
        public static void dodajStanicu(StanicaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Policijska_stanica o = new Policijska_stanica()
                {
                    Naziv = p.Naziv,
                    Adresa = p.Adresa,
                    Broj_sluzbenih_vozila = p.BrojVozila,
                    Opstina = p.Opstina,
                    Datum_osnivanja = p.Datum_Osnivanja
                };

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }
        public static void azurirajStanicu(StanicaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Policijska_stanica o = s.Load<Policijska_stanica>(p.ID);

                o.Naziv = p.Naziv;
                o.Adresa = p.Adresa;
                o.Broj_sluzbenih_vozila = p.BrojVozila;
                o.Datum_osnivanja = p.Datum_Osnivanja;
                o.Opstina = p.Opstina;
                s.Update(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                throw ec;
            }

        }
        public static StanicaBasic vratiStanicu(int ID)
        {
            StanicaBasic pb = new StanicaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Policijska_stanica p = s.Load<Policijska_stanica>(ID);
                pb = new StanicaBasic(ID, p.Naziv, p.Adresa, p.Broj_sluzbenih_vozila, p.Opstina, p.Datum_osnivanja);

                s.Close();
            }
            catch (Exception ec)
            {
                throw ec;
            }

            return pb;
        }
        public static void obrisiStanicu(int ID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Policijska_stanica o = s.Load<Policijska_stanica>(ID);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }
        #endregion
        #region Objekat
        public static List<ObjekatBasic> GetObjekteBasic(int IDStanice)
        {
            List<ObjekatBasic> pb = new List<ObjekatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQueryable<Objekat> Objekti = from o in s.Query<Objekat>()
                                              where o.PolicijskaStanica.ID == IDStanice
                                              select o;
                Policijska_stanica PolicijskaStanica = s.Load<Policijska_stanica>(IDStanice);
                foreach (Objekat p in Objekti)
                {
                    pb.Add(new ObjekatBasic(p.Id, p.Adresa,p.Tip,p.Povrsina,p.KontaktIme,p.KontaktPrezime, PolicijskaStanica));
                }

                s.Close();
                return pb;
            }
            catch (Exception er)
            {
                throw er;
                //handle
            }
        }
        public static void dodajObjekat(ObjekatBasic p, int i)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Policijska_stanica PolicijskaStanica = s.Load<Policijska_stanica>(i);
                Objekat o = new Objekat()
                {
                    Adresa = p.Adresa,
                    Tip = p.Tip,
                    Povrsina = p.Povrsina,
                    KontaktIme = p.KontaktIme,
                    KontaktPrezime = p.KontaktPrezime,
                    PolicijskaStanica = PolicijskaStanica
                };

                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                //handle exceptions
            }
        }
        public static void azurirajObjekat(ObjekatBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(p.ID);

                o.Adresa = p.Adresa;
                o.Tip = p.Tip;
                o.Povrsina = p.Povrsina;
                o.KontaktIme = p.KontaktIme;
                o.KontaktPrezime = p.KontaktPrezime;
                s.Update(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                throw ec;
            }

        }
        public static ObjekatBasic vratiObjekat(int ID)
        {
            ObjekatBasic pb = new ObjekatBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat p = s.Load<Objekat>(ID);
                pb = new ObjekatBasic(ID, p.Adresa, p.Tip, p.Povrsina, p.KontaktIme, p.KontaktPrezime, p.PolicijskaStanica);

                s.Close();
            }
            catch (Exception ec)
            {
                throw ec;
            }

            return pb;
        }
        public static void obrisiObjekat(int ID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(ID);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }
        #endregion
    }

}


