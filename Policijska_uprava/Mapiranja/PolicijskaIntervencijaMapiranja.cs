using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace Policijska_uprava.Mapiranja
{
    public class PolicijskaIntervencijaMapiranja : ClassMap<Policijska_uprava.Entiteti.Policijska_intervencija>
    {
        public PolicijskaIntervencijaMapiranja()
        {
            Table("POLICIJSKA_INTERVENCIJA");


            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();


            Map(x => x.Opis_Intervencije, "OPIS_INTERVENCIJE");
            Map(x => x.Datum_Intervencije, "DATUM_INTERVENCIJE");
            Map(x => x.Vreme_Intervencije, "VREME_INTERVENCIJE");
            
            References(x => x.Objekat)
            .Column("ID_OBJEKTA")
            .LazyLoad();

            References(x => x.PatrolaIntervenise)
            .Column("REDNI_BROJ_PATROLE")
            .LazyLoad();
        }
    }
}
