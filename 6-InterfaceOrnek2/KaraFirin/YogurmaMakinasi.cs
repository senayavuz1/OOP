using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_InterfaceOrnek2.KaraFirin
{
    public class YogurmaMakinasi:IHamurYogurabilir
    {
        public string MakinaAdi { get; set; }
        public int Guc { get; set; }

        public string HamurYogur()
        {
            return $"{MakinaAdi} hamur yogurdu";
        }
    }
}
