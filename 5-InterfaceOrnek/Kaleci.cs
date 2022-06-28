using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_InterfaceOrnek
{
    public class Kaleci : IFutbolcu, IKaleci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public byte SutGucu { get; set; }
        public byte Agresiflik { get; set; }
        public bool Millimi { get; set; }

        public byte Hiz { get; set; }
        public void SutCek() 
        { 
        
        }
        public void PasAt()
        {

        }

        public void CalimAt()
        {

        }
        public void ElleOyna()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }
    }
}
