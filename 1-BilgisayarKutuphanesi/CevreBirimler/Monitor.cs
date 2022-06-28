using _1_BilgisayarKutuphanesi.Bilesenler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BilgisayarKutuphanesi.CevreBirimler
{
    public class Monitor:BilesenBase
    {
        public MonitorTipi MonitorTipi { get; set; }
        public MonitorSekli MonitorSekli { get; set; }
        public MonitorBoyutu MonitorBoyutu { get; set; }

        public MonitorCozunurluk MonitorCozunurluk { get; set; }

    }

    public enum MonitorTipi
    {
        CRT,
        LCD
    }
    public enum MonitorSekli
    {
        Curved,
        Flat
    }
    public enum MonitorBoyutu
    {
        Inc13,
        Inc15,
        Inc17,
        Inc19,
        Inc21,
        Inc24,
        Inc25,
        Inc27,
        Inc28,
        Inc29,
        Inc30,
        Inc31,
        Inc32,
        Inc34,
        Inc40
    }
    public enum MonitorCozunurluk 
    { 
        HDReady,
        FullHd,
        UltraHd,
        UltraHDPlus
    }
}
