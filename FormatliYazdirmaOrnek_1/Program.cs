using System;

namespace FormatliYazdirmaOrnek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sonuc = {0}", 5);
            //Console.WriteLine("{0} {1} {2}",a,b,c);

            Console.WriteLine("a = {0} b = {1} c={2}", 10, 20, 30);

            Console.WriteLine("x : {0} y : {1} z : {2}", 22, 33, (22 + 33));

            int x, y, z;
            x = 22;
            y = 33;
            z = x + y;

            Console.WriteLine("\n{0} + {1} = {2}", x, y, z);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);

            Console.WriteLine("\n-------------SAĞA HİZALAMA-------------");

            Console.WriteLine("\n{0,10} + {1,10} = {2,10}", 100, 200, 300);
            Console.WriteLine("{0,10} - {1,10} = {2,10}", 1000, 2000, -1000);
            Console.WriteLine("{0,10} * {1,10} = {2,10}", 10000, 20000, 2000000000);
            Console.WriteLine("{0,10} / {1,10} = {2,10}", 1000, 200000, 0);
            Console.WriteLine("{0,10} % {1,10} = {2,10}", 10015, 2000, 15);

            Console.WriteLine("\n-------------SOLA HİZALAMA-------------");

            Console.WriteLine("\n{0,-10} + {1,-10} = {2,-10}", 100, 200, 300);
            Console.WriteLine("{0,-10} - {1,-10} = {2,-10}", 1000, 2000, -1000);
            Console.WriteLine("{0,-10} * {1,-10} = {2,-10}", 10000, 20000, 2000000000);
            Console.WriteLine("{0,-10} / {1,-10} = {2,-10}", 1000, 200000, 0);
            Console.WriteLine("{0,-10} % {1,-10} = {2,-10}", 10015, 2000, 15);

            Console.WriteLine("\n-----DİĞER FORMATLAR-----");
            //Console.WriteLine("Para Formatı : {0:C}",100000);
            Console.WriteLine("Üslü ifade Formatı : {0:E}", 10000);
            Console.WriteLine("Üslü ifade Formatı : {0:E5}", 0.000000001);
            Console.WriteLine("Hexadecimal Formatı : {0:X}", 256);
            Console.WriteLine("255 Hexadecimal Formatı : {0:X}", 255);
            Console.WriteLine("65535 Hexadecimal Formatı : {0:X}", 65535);


            Console.ReadKey();
        }
    }
}
