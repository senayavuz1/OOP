using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enum
{
    public class Personel
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
