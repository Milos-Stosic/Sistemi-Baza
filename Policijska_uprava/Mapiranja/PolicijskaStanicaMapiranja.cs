using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Policijska_uprava.Mapiranja
{
    public class PolicijskaStanicaMapiranja : ClassMap<Policijska_uprava.Entiteti.Policijska_stanica>
    {
        public PolicijskaStanicaMapiranja()
        {
            Table("POLICIJSKA_STANICA");


            Id(x => x.ID, "ID").GeneratedBy.SequenceIdentity("SK_POLICIJSKA_STANICA");


            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Broj_sluzbenih_vozila, "BROJ_SLUZBENIH_VOZILA");
            Map(x => x.Opstina, "OPSTINA");
            Map(x => x.Datum_osnivanja, "DATUM_OSNIVANJA");

            HasMany(x => x.Objekti).KeyColumn("POLICIJSKA_STANICA_ID")
            .LazyLoad()
            .Cascade.All()
            .Inverse();

            HasMany(x => x.Policajci).KeyColumn("POLICIJSKA_STANICA_ID")
            .LazyLoad()
            .Cascade.All()
            .Inverse();
        }
    }
}
