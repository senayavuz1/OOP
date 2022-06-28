using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EventHandler
{

    public delegate void HizAsimiEventHandler();
    public class Araba
    {
        public Araba(string marka,int hiz)
        {
            this.Marka = marka;
            this.Hiz = hiz;
        }


        public event HizAsimiEventHandler HizAsimi;
       



       
        public string Marka { get; set; }
        public string Model { get; set; }

        public string Plaka { get; set; }

        public string SoforAdi { get; set; }
        public bool  AracCalisiyormu  { get; set; }
        private int _Hiz;

       public void HareketEdiyor()
        {
            //Sofor sofor = (Sofor)sender;
            //AracCalisiyormu = true;
            //OlayArg yeniarg = new OlayArg();
            //yeniarg.Gerceklesen = this;
            //yeniarg.OlayAdi = $"Araba Hareket Halinde Anlik Hizi:{_Hiz}";
            //while (AracCalisiyormu)
            //{
            //    Olay(this, yeniarg);

            //}

        }

        public int Hiz
        {
            get { return _Hiz; }
            set 
            { 
                _Hiz = value;
                if (value >= 120)
                    HizAsimi();
            }
        }

    }
}
