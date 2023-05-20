using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace Policijska_uprava.Mapiranja
{
    public class BrojTelefonaObjektaMapiranje : ClassMap<Policijska_uprava.Entiteti.Objekat_Broj_Telefona>
    {
        public BrojTelefonaObjektaMapiranje()
        {
            Table("OBJEKAT_BROJ_TELEFONA");


            Id(x => x.Broj, "Broj").GeneratedBy.Assigned();

            References(x => x.Objekat)
                .Column("ID_OBJEKTA")
                .LazyLoad();
        }
    }
}
