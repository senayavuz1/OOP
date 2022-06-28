using _6_InterfaceOrnek2.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_InterfaceOrnek2.KaraFirin
{
    public class HamurUstasi : PersonelBase, IHamurYogurabilir
    {
        public string HamurYogur()
        {
            return $"{Ad} {Soyad} hamur yogurdu";
        }
    }
}
