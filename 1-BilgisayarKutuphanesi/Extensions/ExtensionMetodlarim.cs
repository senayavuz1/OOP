using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BilgisayarKutuphanesi.Extensions
{
    public static  class ExtensionMetodlarim
    {
        public static string[] KelimelereAyir(this string param)
        {
            return param.Split(" ");
        }
    }
}
