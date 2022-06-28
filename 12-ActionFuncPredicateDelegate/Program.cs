using System;

namespace _12_ActionFuncPredicateDelegate
{
    class Program
    {
        /*
         Action ve Action<T> delege türleri .Net framework 3.5 ile gelen önceden tanımlanmış 
        bir delege türüdür. Action<T> delege türleri Func<T> delegelerinin aksine hiçbir 
        değer döndürmeyen metodları temsil etmektedir. Action delege türü hiçbir parametre 
        almayan ve değer döndürmeyen metodları temsil eder. Adından da anlaşılacağı üzere 
        bir fonksiyonu değil bir eylemi(action) temsil etmektedirler.
         Action<T> delegeleri birden fazla parametre alabilecek metodları da temsil edebilecek şekilde tasarlanmıştır.
            Action
            Action <T>
            Action <T1,T2 >
            Action <T1,T2,T3>
            Action <T1,T2,…,TN>
        Her bir T, metodların alacağı parametrelerin tiplerini belirtmektedir. 
        Func<T> gibi Action<T> kullandığımızda delege tanımlamamıza gerek kalmamaktadır.
         */

        static void Main(string[] args)
        {
            // Action<string> errorLog=LogMessage;
            // errorLog("Deneme 1234");
            Action logMessage = () => Console.WriteLine("test 123");
            
            Action<string> logMessage2 = (message) => Console.WriteLine(message);

            //logMessage2("deneme ");
            //Console.WriteLine("Hello World!");
            FuncSample();
        }

        //public static void LogMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}


        /*Func(Önceden Tanımlanmış Delege Türü)
        Func<T> önceden tanımlanmış olan ve T tipinde değerler döndüren metodları temsil eden 
        bir delegedir.Func<T> tipi birden fazla parametre ile beslenebilecek şekilde 
        hazırlanmış bir tiptir. Yani bir veya birden fazla parametre alabilecek metodları 
        temsil eden önceden tanımlanmış bir delege türüdür.
        
        Func<T> kullandığımızda delege tanımlamamıza gerek kalmamaktadır.
            Func<T>
            Func<T, Tresult>
            Func<T1, T2, Tresult>
            Func<T1, T2,…T3, Tresult>
        Her bir T metodun alacağı parametre tipini ve TResult ise temsil edilen 
        metodun dönüş tipipni temsil etmektedir.
        Func tipi, bir veya birden fazla(16 haneye kadar) parametre alabilen ve geriye T
        tipinde değer döndüren bir delege yapısıdır.Bu delege sayesinde, alacağı parametreler
        ve geriye döndüreceği değeri simgeleyen delegemizi tanımlayabilir ve o
        tanımladığımız yapıdaki herhangi bir metodu bu delegeye işaretletebiliriz.
        Eğer bir işlemde delegeye ihtiyacınız varsa, Func ile hızlı ve pratik bir
        şekilde ihtiyacınızı giderebilir ve delegeyle uğraşmanıza gerek kalmayabilir.*/

        public static void FuncSample()
        {
           
            Func<int, int> toplam = GuausToplam;

            Func<int, int> toplam2 = (sayi) => 
            {
                int toplam = 0;
                for (int i = 0; i <= sayi; i++)
                {
                    toplam += i;
                }
                return toplam;

            };
            Func<int, int> toplam3 = sayi =>
            {
                int toplam = 0;
                for (int i = 0; i <= sayi; i++)
                {
                    toplam += i;
                }
                return toplam;

            };
            //Console.WriteLine(toplam(5));
            Console.WriteLine(toplam2(5));

        }
        public static int GuausToplam(int sayi)
        {
            int toplam = 0;
            for (int i = 0; i <= sayi; i++)
            {
                toplam += i;
            }
            return toplam;
        }

        public static void PredicateSample()
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Predicate<int> tekSayilar = (sayi) =>
            {
                return sayi % 2 == 0;

            };

        }
    }
}
