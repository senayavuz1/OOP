using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EventHandlerOrnekleri
{
    public class Kumanda
    {
        private string _kod;
        public Kumanda(string kod)
        {
            _kod = kod;
        }
        public event EventHandler2 AcmaTusunaBas;
        public void TusaBas()
        {
            Console.WriteLine("Kumandanin tusuna basildi.");
            AcmaTusunaBas(_kod);

        }
    }
}
