using _10_EventHandlerOrnekleri.Bombaci;
using _10_EventHandlerOrnekleri.UrunHaber;
using System;

namespace _10_EventHandlerOrnekleri
{
    public delegate void EventHandler();
    public delegate void EventHandler2(string kod);

    class Program
    {
        static void Main(string[] args)
        {
            #region Kumanda
            //Araba araba = new Araba("AliVeli");

            //Kumanda k1 = new Kumanda("k1");
            //Kumanda k2 = new Kumanda("k2");
            //Kumanda k3 = new Kumanda("k3");
            //Kumanda k4 = new Kumanda("AliVeli");

            //k1.AcmaTusunaBas += araba.SinyalAl;

            //k2.AcmaTusunaBas += araba.SinyalAl;
            //k3.AcmaTusunaBas += araba.SinyalAl;
            //k4.AcmaTusunaBas += araba.SinyalAl;

            //k1.TusaBas();
            //k2.TusaBas();
            //k3.TusaBas();
            //k4.TusaBas(); 
            #endregion


            #region Bombaci
            //Bomba bomba1 = new Bomba();
            //Bomba bomba2 = new Bomba();

            //Telefon tel = new Telefon();
            //tel.KelimeKullanildi += Test;
            //tel.KelimeKullanildi += Test2;
            //tel.KelimeKullanildi += bomba1.Patla;

            //tel.KelimeKullanildi += bomba2.Patla;
            //tel.Gorusme(); 
            #endregion

            Urun IPhone = new Urun();
            IPhone.UrunAdi = "IPhone";
            

            Kisi ali = new Kisi("Ali");
            Kisi veli = new Kisi("veli");
            Kisi ayse = new Kisi("ayse");
            IPhone.FiyatDustu += ali.HaberAl;
            IPhone.FiyatDustu += veli.HaberAl;
            IPhone.FiyatDustu += ayse.HaberAl;

            IPhone.Fiyat = 50;


        }
        public static void Test()
        {
            Console.WriteLine("Test");
        }

        public static void Test2()
        {
            Console.WriteLine("Test2");
        }
    }
}
