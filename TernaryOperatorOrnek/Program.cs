using System;

namespace TernaryOperatorOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //ternary operator : üçlü operatör
            //üç tane operand alır
            //operand1 ? operand2 : operand3;
            //şart ? ifade1 : ifade2;

            int sayi;
            Console.Write("Bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi<0)
            //{
            //    Console.WriteLine("Sayı negatif");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı pozitif");
            //}
            //ternary ile yapılabilir
            string sonuc;
            sonuc=(sayi<0)? "Sayı negatif": "Sayı pozitif";
            Console.WriteLine(sonuc);
            string sonuc2;
            sonuc2 = (sayi % 2 == 0) ? "Çift" : "Tek";
            Console.WriteLine(sonuc2);

            Console.ReadKey();
        }
    }
}
