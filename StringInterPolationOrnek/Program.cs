using System;

namespace StringInterPolationOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Format 
            string ad, soyad;
            Console.Write("Adınızı Giriniz : ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz : ");
            soyad = Console.ReadLine();


            string mesaj = string.Format("Sayın {0} {1}. Hoş geldiniz", ad, soyad);
            Console.WriteLine(mesaj);

            // string interpolation : C# 6.0 ile beraber gelmiştir.
            // string ifalerin başında $ işareti konur.

            //string mesaj2 = $"C# dünyasına " +
            //    $"hoş"+
            //    $"geldiniz.";
            //Console.WriteLine(mesaj2);

            string mesaj2 = $"Sayın {ad} {soyad}. Hoş geldiniz";
            Console.WriteLine(mesaj2);

            Console.WriteLine("\n----- BEŞ İŞLEM -----");
            int x = 33, y = 19;
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"{x} % {y} = {x % y}");

            Console.ReadKey();
        }
    }
}
