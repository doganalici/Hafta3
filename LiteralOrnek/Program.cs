using System;

namespace LiteralOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal (10 şuk sayı sistemi) formatta
            int a = 145;
            //octal format
            int b = 0145;
            //hexadecimal
            int c = 0xFace;
            //binary
            int d = 0b1011;

            Console.WriteLine("a : "+a);
            Console.WriteLine("b : "+b);
            Console.WriteLine("c : "+c);
            Console.WriteLine("d : "+d);
            Console.Write("SONUÇ : {0}",5);
            Console.ReadKey();
        }
    }
}
