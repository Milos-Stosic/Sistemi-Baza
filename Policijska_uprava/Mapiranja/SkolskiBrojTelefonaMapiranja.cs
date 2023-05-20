using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace Policijska_uprava.Mapiranja
{
    public class BrojTelefonaSkoleMapiranje : ClassMap<Policijska_uprava.Entiteti.Skolski_Broj_Telefona>
    {
        public BrojTelefonaSkoleMapiranje()
        {
            Table("SKOLSKI_BROJ_TELEFONA");


            Id(x => x.Broj, "BROJ").GeneratedBy.Assigned();

            References(x => x.SkolskiPolicajac)
              .Column("JMBG_SKOLSKOG_POLICAJCA")
              .LazyLoad();
        }
    }
}
