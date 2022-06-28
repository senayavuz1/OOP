using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BilgisayarKutuphanesi.Bilesenler
{
    public class Kasa:BilesenBase
    {
      
        public string KasaTipi { get; set; }
        public PowerSupplier PowerSupplier { get; set; }

    }


    public enum KasaTipi
    {
        FullTower ,
        MidiTower ,
        MiniTower,
        ATX,
        MicroATX,
        MiniITX,
        Cube,
        Slim
    
    }

}
