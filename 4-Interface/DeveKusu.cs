using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface
{
    /*
     
     Devekusu ,Kus'tan miras aldigi icin baska bir siniftan miras alamaz.
    Ancak Interface sayesinde sinirsiz yetenek kazanabilirler
     
     */
    public class DeveKusu : Kus, IKosabilir,IYuruyebilir
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }
    }
}
