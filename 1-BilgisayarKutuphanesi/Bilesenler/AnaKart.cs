using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BilgisayarKutuphanesi.Bilesenler
{
    public class AnaKart:BilesenBase
    {
        public SoketTipi SoketTipi { get; set; }
    }

    public enum SoketTipi { 
      AMD,
      INTEL
    } 
}
