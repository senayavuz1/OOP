using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface
{
    public class KaraBatak : Kus, IYuzebilir, IUcabilir,IYuruyebilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
