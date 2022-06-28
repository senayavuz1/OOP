using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EventHandlerOrnekleri.UrunHaber
{
    public class Kisi
    {
        public string Adi { get; set; }

        public Kisi(string Ad)
        {
            Adi = Ad;
        }

        public void HaberAl()
        {
            Console.WriteLine($"{Adi} haberi aldi");
        }
    }
}
