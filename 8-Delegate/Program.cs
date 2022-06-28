using System;

namespace _8_Delegate
{
    class Program
    {

        /* Delegate : Bir olay gerceklestiginde birden fazla metod cagirmak istedigimizi dusunünelim.Burada amaç bir olay oldugunda birden fazla yere bu olayi duyurmaktir. Boyle bir durumda bu olayla ilgilenenler delegate ile olaydan haberdar olur.
         * 
         * Delegate olusturulurken izlenecek adimlar
         * 1-Tanimalama 
         * 2-Örnekleme
         * 3-Cagirma
        */
        // Metod tipi deklerasyon saglar


        public delegate int MetodTemsilci(int sayi1, int sayi2);

        public static MetodTemsilci Islem;

        public delegate void Logger(string message);
        static void Main(string[] args)
        {

            // Islem += Topla;

            // //int sonuc = Islem(3, 5);


            // Islem += Cikart;
            ////sonuc = Islem(3, 5); 
            // Islem += Carp;
            // Islem += Bol;


            Logger log = new Logger(FileLogger);
            log += SmsLogger;
            log += DbLogger;

            log.Invoke("Yetisin sistem çöktü");
            Console.WriteLine("");
        }


        public static void FileLogger(string mesaj)
        {
            Console.WriteLine("file Logger");
        }
        public static void DbLogger(string mesaj)
        {
            Console.WriteLine("Db Logger");

        }
        public static void SmsLogger(string mesaj)
        {
            Console.WriteLine("Sms Logger");

        }
        public static int Topla(int a, int b)
        {
            return a + b;
        }
        public static int Cikart(int a, int b)
        {
            return a - b;
        }
        public static int Carp(int a, int b)
        {
            return a * b;
        }

        public static int Bol(int a, int b)
        {
            return a / b;
        }
    }
}
