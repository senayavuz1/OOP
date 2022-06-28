using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_InterfaceOrnek2.Personeller
{
    public class Muhasebe : Personel, IMuhasebe
    {


        public Muhasebe(string ad,string soyad):base(ad,soyad)
        {
            
        }
        public void KdvVerisiniHesapla()
        {
            throw new NotImplementedException();
        }

        public decimal MaasOde()
        {
            throw new NotImplementedException();
        }
    }
}
