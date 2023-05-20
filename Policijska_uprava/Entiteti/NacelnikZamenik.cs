using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policijska_uprava.Entiteti
{
   
        public class NacelnikZamenik
        {
            public virtual int Id { get; set; }
            public virtual Nacelnik Nacelnik { get; set; }
            public virtual ZamenikZaVanredneSituacije ZamenikZaVanredneSituacije { get; set; }
            public virtual ZamenikZaKrvneDelikte ZamenikZaKrvneDelikte { get; set; }
            public virtual ZamenikZaSaobracaj ZamenikZaSaobracaj { get; set; }
        }
    
}
