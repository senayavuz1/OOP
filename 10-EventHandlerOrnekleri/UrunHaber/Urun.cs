using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_EventHandlerOrnekleri.UrunHaber
{
    public class Urun
    {
        private int _fiyat;
        public event EventHandler FiyatDustu;
        public string UrunAdi { get; set; }
        public int Fiyat {
            get { return _fiyat; }
            set 
            { 
                if (value == 50)
                {
                    FiyatDustu();
                }
            } 
        }
    }

}
