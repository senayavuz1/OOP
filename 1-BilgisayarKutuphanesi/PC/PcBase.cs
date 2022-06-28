using _1_BilgisayarKutuphanesi.Bilesenler;
using _1_BilgisayarKutuphanesi.CevreBirimler;
using _1_BilgisayarKutuphanesi.IsletimSistemi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BilgisayarKutuphanesi.PC
{
    public class PcBase:BilesenBase
    {
        public AnaKart AnaKart   { get; set; }
        public Islemci Islemci { get; set; }
        public Ram Ram { get; set; }
        public EkranKarti EkranKarti { get; set; }
        public Kasa Kasa { get; set; }
        public Isletimsistemi IsletimSistemi{ get; set; }

        public Monitor Monitor  { get; set; }

        public Klavye Klavye { get; set; }
        public Mouse Mouse { get; set; }

    }
}
