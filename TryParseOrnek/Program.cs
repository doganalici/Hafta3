using System;

namespace TryParseOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int sayi;

            Console.Write("Bir sayı giriniz : ");
            str = Console.ReadLine();
            bool result = Int32.TryParse(str, out sayi);
            if (result == true)
            {
                Console.WriteLine("Dönüştürme işlemi başarılı : "+sayi);
            }
            else
            {
                Console.WriteLine("Dönüştürme işlemi başarısız");
            }


            Console.ReadKey();
        }
    }
}
