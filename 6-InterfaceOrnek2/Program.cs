using _6_InterfaceOrnek2.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_InterfaceOrnek2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PersonelBase personelBase = new();


            //Constructer base deger atamasi
            Personel ali = new("Ali","Yilmaz");

            //Object initialize
            //Personel veli = new Personel
            //{
            //    Ad="Ali",
            //    Soyad="Yilmaz"
                
            //};

            Personel ayse = new Personel("","");
            ayse.Ad = "Ayse";
            ayse.Soyad = "Yilmaz";

            Muhasebe fatma = new Muhasebe("fatma","ozturk");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
