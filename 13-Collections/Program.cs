using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _13_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new DateTime());
            arrayList.Add(new Kisi { Id = 1, Ad = "Ali", Soyad = "Yilmaz" });
            arrayList.Add(45);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

            List<Kisi> kisiler = new List<Kisi>();
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //sayilar.Add(""); Burasi hata verecektir.
            #region Listeler
            //List<int> ciftSayilar = sayilar.Where(x => x % 2 == 0).ToList();
            //sayilar.ForEach(x => Console.WriteLine(x));

            //ciftSayilar.ForEach(x => Console.WriteLine(x));
            //Console.Clear();
            //kisiler.Add(new Kisi() { Id = 2, Ad = "Veli", Soyad = "Yilmaz" });
            //kisiler.Add(new Kisi() { Id = 3, Ad = "Ayse", Soyad = "Yilmaz" });
            //kisiler.Add(new Kisi() { Ad = "Veli", Soyad = "Yilmaz" });
            //kisiler.ForEach(x => Console.WriteLine(x.Id + " " + x.Ad + " " + x.Soyad));
            //List<Kisi> IdBuyuk1 = kisiler.Where(x => x.Id > 1).ToList();

            //IdBuyuk1.ForEach(x => Console.WriteLine(x.Id + " " + x.Ad + " " + x.Soyad)); 
            #endregion


            #region Dictionary

            //Dictionary<string, int> parametreler = new Dictionary<string, int>();
            //parametreler.Add("GirisSayisi", 0);
            //parametreler.Add("TiklanmaSayisi", 0);
            //parametreler.Add("TiklanmaSayisi", 0);
            //parametreler["GirisSayisi"] = 5;

            ////Console.WriteLine(parametreler["GirisSayisi"]);
            //// Sozluk icin Tanimlama 

            //Dictionary<string, string> sozluk = new Dictionary<string, string>();
            //sozluk.Add("Apple", "Elma");

            //Dictionary<string, List<Kisi>> test = new Dictionary<string, List<Kisi>>(); 
            #endregion
            // Yanlica bir adet ayni keyden bulunabilir.
            // Hashtable hashtable = new Hashtable();
            // hashtable.Add("KayitSayisi", 10);
            //// hashtable.Add("KayitSayisi", 10);
             Kisi veli = new Kisi() { Id = 2, Ad = "Veli", Soyad = "Yilmaz" };
             Kisi ali = new Kisi() { Id = 3, Ad = "Ali", Soyad = "Yilmaz" };
            // hashtable.Add(veli.Id, veli);
            // hashtable.Add(ali.Id, ali);

            Stack stack = new Stack();
            
            // Son giren ilk cikar mantigi ile calisir.
            stack.Push(ali);
            stack.Push(veli);
            stack.Pop(); // Listedeki elemani size verir ve listeden remove eder
            stack.Peek();// Listedeki elemani size verir ve listeden silmez
            Console.WriteLine("Hello World!");
        }
    }

    public class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
