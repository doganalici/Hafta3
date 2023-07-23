using System;

namespace IliskiselOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            //relational operators : ilişkisel operatörler
            //1. büyüklük, küçüklük, eşitlik açısından kontrol eder
            //2. sonuç her zaman boolean (true, false) değerdir.

            int s1, s2;
            Console.Write("1. sayıyı giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***** KARŞILAŞTIRMA SONUÇLARI *****");
            Console.WriteLine($"s1 > s1 = {s1 > s2}");
            Console.WriteLine($"s1 < s1 = {s1 < s2}");
            Console.WriteLine($"s1 >= s1 = {s1 >= s2}");
            Console.WriteLine($"s1 <= s1 = {s1 <= s2}");
            Console.WriteLine($"s1 == s1 = {s1 == s2}");
            Console.WriteLine($"s1 != s1 = {s1 != s2}");
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"100 < 101 = {100 < 101}");
            Console.WriteLine($"100 == 101 = {100 == 101}");
            Console.WriteLine($"100 != 101 = {100 != 101}");
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"23.4 < 23.5 = {23.4 < 23.5}");
            Console.WriteLine($"23.4 >= 23.5 = {23.4 >= 23.5}");
            Console.WriteLine($"23.4 == 23.5 = {23.4 == 23.5}");
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"a > A = {'a' > 'A'}");
            Console.WriteLine($"a < A = {'a' < 'A'}");
            Console.WriteLine($"a != A = {'a' != 'A'}");
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"adem == Adem = {"adem" == "Adem"}");
            Console.WriteLine($"adem != Adem = {"adem" != "Adem"}");


            Console.ReadKey();
        }
    }
}
