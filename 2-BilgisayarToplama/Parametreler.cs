using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BilgisayarToplama
{

    /// <summary>
    /// Bütün program boyunca kullanacagimiz genel tanimlamalari tutar
    /// </summary>
    public static  class Parametreler
    {
        // directory de üç level yukari cikip forms icerisinde Dosyalar klasorunde markalar.txt'yi arar.
        public const string MarkalarDosyasi = @"..\..\..\Forms\Dosyalar/Markalar.txt";
        public const string PowerSupplierDosyasi = @"..\..\..\Forms\Dosyalar/PowerSupplier.txt";
        public const string KasalarDosyasi = @"..\..\..\Forms\Dosyalar/Kasalar.txt";
        public const string IslemciDosyasi = @"..\..\..\Forms\Dosyalar/Islemciler.txt";
    }
}
