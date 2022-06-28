using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_InterfaceOrnek2.Personeller
{
    public class Personel : PersonelBase, IPersonel
    {
        public string MesaiyeKal()
        {
            return "";
        }

        public string SabahIseGel()
        {
            return "";
        }

        public string SaygiliOl()
        {
            return "";
        }


        public Personel(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;

        }
    }
}
