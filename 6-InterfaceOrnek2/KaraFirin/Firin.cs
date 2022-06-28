using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_InterfaceOrnek2.KaraFirin
{
    public class Firin
    {
        public string EkmekUret(IHamurYogurabilir hamurYogurabilir)
        {
            return hamurYogurabilir.HamurYogur();
        }
    }
}
