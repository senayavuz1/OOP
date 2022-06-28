using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EventHandlerOrnekleri.Bombaci
{
    public class Telefon
    {
        public event EventHandler KelimeKullanildi;

        public void Gorusme()
        {
            Console.WriteLine("Aloo Anlamadim...");
            string input = Console.ReadLine();
            if (input == "AliVeli")
            {
                KelimeKullanildi();
            }
            if (input == "Kapat")
            {
                return;
            }
            Gorusme();
        }
    }
}
