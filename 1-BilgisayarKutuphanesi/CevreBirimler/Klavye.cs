using _1_BilgisayarKutuphanesi.Bilesenler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1_BilgisayarKutuphanesi.CevreBirimler
{
    public class Klavye : BilesenBase
    {
        public BaglantiTipi KlavyeBaglanti { get; set; }

    }

    public enum BaglantiTipi 
    { 
        PS2,
        USB,
        Bluetooth,
        WIFI
    }
}
