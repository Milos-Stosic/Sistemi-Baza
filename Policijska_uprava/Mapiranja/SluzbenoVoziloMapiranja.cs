using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Policijska_uprava.Mapiranja
{
    public class SluzbenoVoziloMapiranja : ClassMap<Policijska_uprava.Entiteti.Sluzbeno_vozilo>
    {
        public SluzbenoVoziloMapiranja()
        {
            Table("SLUZBENO_VOZILO");


            Id(x => x.Registarska_Oznaka, "REGISTARSKA_OZNAKA").GeneratedBy.Assigned();


            Map(x => x.Boja, "BOJA");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.Model, "MODEL");
            Map(x => x.Tip, "TIP");
        }
    }
}
