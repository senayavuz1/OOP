using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BilgisayarKutuphanesi.Bilesenler
{
    public class EkranKarti
    {
        public KartTipi KartTipi { get; set; }
        public string Hafiza { get; set; }

    }

    public enum KartTipi 
    { 
        AMD,
        NVIDIA
    }
}
