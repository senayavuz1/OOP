using _14_Generic.Repository;
using System;
using System.Reflection;

namespace _14_Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            //reflectionSample();

          // var assembly = Assembly.LoadFrom("1-BilgisayarKutuphanesi.dll");

            Console.WriteLine("Hello World!");
        }


        public static void reflectionSample()
        {
            ProductRepository productRepository = new ProductRepository();
            object o = new object();

            var liste = productRepository.GetType().GetMethods();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            var props = productRepository.GetType().GetProperties();
            foreach (var item in props)
            {
                Console.WriteLine(item);
            }
            
        }

    }
    
    public interface ITopla<T>
    {
        public T Topla(T sayi);
    }

    public class Toplama : ITopla<decimal>
    {
        decimal Topla(decimal sayi)
        {
            return sayi + 10;
        }

        decimal ITopla<decimal>.Topla(decimal sayi)
        {
            throw new NotImplementedException();
        }
    }

    interface IToplaInt 
    {
        int Topla(int sayi);
    }
    interface IToplaLong
    {
        long Topla(long sayi);
    }

    interface IToplaFloat
    {
        float Topla(float sayi);
    }
    interface IToplaDecimal
    {
        decimal Topla(decimal sayi);
    }
}
