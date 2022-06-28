using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractClasslar
{
    public class Gitar : MuzikAleti,IMuzikAleti
    {
        //public override string Cal()
        //{
        //    return "Gitar Caldi";
        //}
        public override string AkortEt()
        {
            return "Gitar Akort edildi";
        }

        public string Cal()
        {
            throw new NotImplementedException();
        }

        public virtual void test()
        {

        }
        
    }
}
