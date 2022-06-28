using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_InterfaceOrnek2.Personeller
{
    public interface IMuhasebe
    {
        public decimal MaasOde();
        public void KdvVerisiniHesapla();
    }
}
