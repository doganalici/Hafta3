using System;

namespace MantiksalOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // mantıksal öperatörler : && and(ve), || or(veya), ! not(değil)
            // && sonucun true olması için tüm şartlar true olması gerekir
            // || sonucun false olması için tüm şartlar false olması gerekir

            Console.WriteLine(false && true && true);
            Console.WriteLine(true && true && true);
            Console.WriteLine();
            Console.WriteLine(false || false || true);
            Console.WriteLine(!false);
            Console.WriteLine(!true);
            Console.WriteLine();
            int a = 12;
            int b = 11;
            Console.WriteLine((a==b) || (a!=b));
           Console.WriteLine((a==b) && (a!=b) || (a<b));
           
            Console.ReadKey();
        }
    }
}
