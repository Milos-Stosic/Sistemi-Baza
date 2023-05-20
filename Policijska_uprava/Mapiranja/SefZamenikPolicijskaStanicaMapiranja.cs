using FluentNHibernate.Mapping;
using Policijska_uprava.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Mapiranja
{
    public class SefZamenikPolicijskaStanicaMap : ClassMap<SefZamenikPolicijskaStanica>
    {
       
            public SefZamenikPolicijskaStanicaMap()
            {
                Table("SEF_ZAMENIK_POLICIJSKA_STANICA");

                Id(x => x.ID).Column("ID").GeneratedBy.Assigned();
                References(x => x.Policijska_stanica).Column("POLICIJSKA_STANICA_ID").LazyLoad();
                References(x => x.Sef).Column("SEF_JMBG").LazyLoad();
                References(x => x.Zamenik).Column("ZAMENIK_JMBG").LazyLoad();
            }
        
    }
}
