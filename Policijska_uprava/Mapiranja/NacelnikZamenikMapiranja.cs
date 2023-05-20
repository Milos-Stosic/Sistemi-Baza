using FluentNHibernate.Mapping;
using Policijska_uprava.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Mapiranja
{
    public class NacelnikZamenikMap : ClassMap<NacelnikZamenik>
    {
        public NacelnikZamenikMap()
        {
            Table("NACELNIK_ZAMENIK");
            Id(x => x.Id, "ID").GeneratedBy.Identity();

            References(x => x.Nacelnik)
                .Column("JMBG_NACELNIKA")
                .ForeignKey("NACELNIK_FK");

            References(x => x.ZamenikZaVanredneSituacije)
                .Column("JMBG_ZVS")
                .ForeignKey("ZAMENIK_VS_FK");

            References(x => x.ZamenikZaKrvneDelikte)
                .Column("JMBG_ZKD")
                .ForeignKey("ZAMENIK_KD_FK");

            References(x => x.ZamenikZaSaobracaj)
                .Column("JMBG_ZS")
                .ForeignKey("ZAMENIK_S_FK");
        }
    }
}
