using _1_BilgisayarKutuphanesi.Bilesenler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BilgisayarKutuphanesi.IsletimSistemi
{
    public class Isletimsistemi:BilesenBase
    {

        public OSType OSTipi { get; set; }
    }

    public enum OSType 
    { 
        OtuzikiBit,
        AltmisdortBit
    }
}
