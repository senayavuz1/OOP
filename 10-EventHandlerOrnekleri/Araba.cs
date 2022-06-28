using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EventHandlerOrnekleri
{
    public class Araba
    {
        private string _kod;
        public Araba(string kod)
        {
            _kod = kod;
        }
        public void SinyalAl(string kod)
        {
            Console.WriteLine("Sinyal alindi:"+kod);
            if (kod == _kod)
            {
                KapilariAc();
            }
        }
        
        private void KapilariAc()
        {
            Console.WriteLine("Kapilar acildi:"+_kod);
        }
    }
}
