using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EventHandlerOrnekleri.Bombaci
{
    public class Bomba
    {
        public void Patla()
        {
            Console.WriteLine("Booooommmmmmm");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
