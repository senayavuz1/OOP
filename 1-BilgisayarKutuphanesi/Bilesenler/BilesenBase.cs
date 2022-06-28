using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BilgisayarKutuphanesi.Bilesenler
{
    public class BilesenBase
    {

        private DateTime _garanti;

        public DateTime GarantiTarihi
        {
            get { return _garanti; }
            set
            {

                if (value <= DateTime.Now)
                    _garanti = value;
                else
                    throw new Exception("Girilen Tarih bugunden buyuk olamaz");

            }
        }
        // Bugunden buyuk olmaz . 
       

        private decimal _fiyat;

        public decimal Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value <= 0)
                    value = 0;

                _fiyat = value;
            }
        }


        public string Marka { get; set; }

        public string Model { get; set; }

        public string Kategori { get; set; }

        public override string ToString()
        {
            return $"{Kategori}-{Marka}-{Model}-{Fiyat}";
        }
    }
}
