using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_BilgisayarKutuphanesi.Extensions;
namespace _1_BilgisayarKutuphanesi.Bilesenler
{
    public class Ram:BilesenBase
    {
        public RamTipi RamTipi { get; set; }
        public string Kapasite { get; set; }
        int a = 0;
        public void test()
        {
            string str = "";
            str.KelimelereAyir();      
        }
    }

    public enum RamTipi
    { 
        DDR2,
        DDR3,
        DDR4,
        DDR5,
        DDR6
    }

   
    
}
