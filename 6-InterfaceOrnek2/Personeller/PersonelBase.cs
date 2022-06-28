using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_InterfaceOrnek2.Personeller
{
    public class PersonelBase
    {

        public Departmanlar Departmanlar { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public decimal Maas { get; set; }
        public string  DogumYeri { get; set; }

        public string Email { get; set; }
        public string Gsm { get; set; }
    }
}
