using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractClasslar
{
    //Abstract class'lardan instance alinamaz. Ancak kalitim verir.
    public abstract class MuzikAleti
    {
        public string Marka { get; set; }
        public string Model { get; set; }


        // Abstract metodlar kalitim alan siniflarda tanimlanmak zorundadir
        // Abstract metodlar private olamazlar
        // Abstrat metodlar sadece abstract class icerisinde tanimlanirlar.
        // Abstract metodlar virtual olarak tanimlamazlar
        // Abstract metodlar  static olarak tanimlanamazlar
        // Abstract metodlarlarin govdesi olmaz. Sadece metod imzasi olur.
       // public abstract string Cal();


        // Virtual metodlar ise kalitim alan siniflarda ovveride edilebilir.
        // Yani yeniden tanimlanabilir
        public virtual string  AkortEt()
        {
            return "Akor edildi";
        }
    }
}
