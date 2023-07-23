using System;

namespace UnaryOperatorOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //unary operator : birleşik/tekli operatör
            //tek operand alır
            //++ : değişkenin değerini bir artırır.
            int a = 10;
            int b = a++;  //önce a'nın değerini bir arttır sonra b ye ata
            // $ : string interpolation : c# 6.0
            Console.WriteLine($"a={a} , b={b}");

            Console.WriteLine("------------------");
            int x = 99;
            int y = x++; //önce x in değerini y ye ata sonra x in değerini bir arttır
            Console.WriteLine($"x={x} , y={y}");

            Console.WriteLine("------------------");
            int m = 19;
            int n = --m; //önce m nin değerinin bir azalt sonra n ye ata
            Console.WriteLine($"m={m} , n={n}");

            Console.WriteLine("------------------");
            int p = 11;
            int r = p--; //önce p nin değerini r ye ata sonra p yi bir azalt
            Console.WriteLine($"p={p} , r={r}");

            Console.WriteLine("------------------");
            int k = 5;
            Console.WriteLine($"++k * 8 = {++k * 8}");
            Console.WriteLine($"k++ * 8 = {k++ * 8}");
            Console.WriteLine($"k = {k}");

            Console.ReadKey();
        }
    }
}
