using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Policijska_uprava.Mapiranja
{
    public class ObjekatMapiranja: ClassMap<Policijska_uprava.Entiteti.Objekat>
    {
        public ObjekatMapiranja()
        {
            Table("OBJEKAT");


            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("SK_OBJEKAT");


            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Tip, "TIP");
            Map(x => x.Povrsina, "POVRSINA");
            Map(x => x.KontaktIme, "IME");
            Map(x => x.KontaktPrezime, "PREZIME");
      
            References(x => x.PolicijskaStanica)
              .Column("POLICIJSKA_STANICA_ID")
              .LazyLoad();

            HasMany(x => x.AlarmniSistemi).KeyColumn("ID_OBJEKTA")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.PolicijskeIntervencije).KeyColumn("ID_OBJEKTA")
             .LazyLoad()
             .Cascade.All()
             .Inverse();

            HasMany(x => x.BrojeviTelefonaObjekta).KeyColumn("ID_OBJEKTA")
             .LazyLoad()
             .Cascade.All()
             .Inverse();
        }
    }
}
