using System;

namespace BinaryOperatorOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //binary operator : iki adet operand alır
            // + , - , * , / , %
            int x, y;
            Console.Write("1. sayıyı giriniz : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            y = Convert.ToInt32(Console.ReadLine());
            int toplam, fark, carpma, mod;
            double bolme;
            toplam = x + y;
            fark = x - y;
            carpma = x * y;
            bolme = (double)x / y;
            mod = x % y;

            Console.WriteLine("\n***** 1.YOL *****");
            Console.WriteLine($"\nToplama sonucu = {toplam}");
            Console.WriteLine($"Çıkarma sonucu = {fark}");
            Console.WriteLine($"Çarpma sonucu = {carpma}");
            Console.WriteLine($"Bölme sonucu = {bolme}");
            Console.WriteLine($"Mod alma sonucu = {mod}");
            Console.WriteLine("\n------------------------");

            Console.WriteLine("***** 2.YOL *****");
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {(double)x / y}");
            Console.WriteLine($"{x} % {y} = {x % y}");
            Console.WriteLine("\n------------------------");

            Console.WriteLine("***** 3.YOL *****");
            Console.WriteLine("{0} + {1} = {2}",x,y,x+y);
            Console.WriteLine("{0} - {1} = {2}",x,y,x-y);
            Console.WriteLine("{0} * {1} = {2}",x,y,x*y);
            Console.WriteLine("{0} / {1} = {2}",x,y,(double)x/y);
            Console.WriteLine("{0} % {1} = {2}",x,y,x%y);

            Console.ReadKey();
        }
    }
}
