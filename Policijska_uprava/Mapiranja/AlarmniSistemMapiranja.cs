using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Policijska_uprava.Entiteti;

namespace Policijska_uprava.Mapiranja
{
    public class AlarmniSistemMapiranja : ClassMap<Policijska_uprava.Entiteti.Alarmni_sistem>
    {
        public AlarmniSistemMapiranja()
        {
            Table("ALARMNI_SISTEM");


            Id(x => x.Serijski_Broj, "SERIJSKI_BROJ").GeneratedBy.Assigned(); ;


            Map(x => x.Model, "MODEL");
            Map(x => x.Datum_Instalacije, "DATUM_INSTALACIJE");
            Map(x => x.Datum_Poslednjeg_Atesta, "DATUM_POSLEDNJEG_ATESTA");
            Map(x => x.Datum_Poslednjeg_Servisa, "DATUM_POSLEDNJEG_SERVISA");
            Map(x => x.Godina_Proizvodnje, "GODINA_PROIZVODNJE");
            Map(x => x.Opis_Poslednjeg_Kvara, "OPIS_POSLEDNJEG_KVARA");
            Map(x => x.Tehnicko_Lice, "TEHNICKO_LICE");
            References(x => x.Objekat)
                          .Column("ID_OBJEKTA")
                          .LazyLoad();
            Map(x => x.Pocetni_Datum, "POCETNI_DATUM");
            Map(x => x.Poslednji_Datum, "POSLEDNJI_DATUM");

        }


    }

    public class PokretMapiranje : SubclassMap<Pokret>
    {
        public PokretMapiranje()
        {
            Table("POKRET");
            KeyColumn("SERIJSKI_BROJ");

            Map(x => x.Osetljivost, "OSETLJIVOST");
        }
    }

    public class Toplotni_OdrazMapiranje : SubclassMap<Toplotni_Odraz>
    {
        public Toplotni_OdrazMapiranje()
        {
            Table("TOPLOTNI_ODRAZ");
            KeyColumn("SERIJSKI_BROJ");

            Map(x => x.Horizontalna_Rezolucija, "HORIZONTALNA_REZOLUCIJA");
            Map(x => x.Vertikalna_Rezolucija, "VERTIKALNA_REZOLUCIJA");
        }
    }

    public class UltraZvukMapiranje : SubclassMap<Ultrazvuk>
    {
        UltraZvukMapiranje()
        {
            Table("ULTRAZVUK");
            KeyColumn("SERIJSKI_BROJ");

            Map(x => x.Donja_Frekvencija, "DONJA_FREKVENCIJA");
            Map(x => x.Gornja_Frekvencija, "GORNJA_FREKVENCIJA");

        }
    }

}
