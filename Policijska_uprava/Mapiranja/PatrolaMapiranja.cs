using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Policijska_uprava.Mapiranja
{
    public class PatrolaMapiranja : ClassMap<Policijska_uprava.Entiteti.Patrola>
    {
        public PatrolaMapiranja()
        {
            Table("PATROLA");


            Id(x => x.Redni_Broj, "REDNI_BROJ").GeneratedBy.Assigned();

            References(x => x.Vodja_JMBG)
            .Column("VODJA_JMBG")
            .LazyLoad();
         
            References(x => x.Clan_JMBG)
            .Column("CLAN_JMBG")
            .LazyLoad();

            References(x => x.Vozilo)
            .Column("REGISTRACIJA_VOZILA")
            .LazyLoad();

            HasMany(x => x.Intervencije).KeyColumn("REDNI_BROJ_INTERVENCIJE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
