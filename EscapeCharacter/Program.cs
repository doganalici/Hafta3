using System;

namespace EscapeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {

            string path;
            path = "Sasdd\\Sasdd\\Sasdaad\\Ssdada";
            Console.WriteLine(path);

            string alinti = "\'Kodlar makina için değil insan için anlamlıdır.\'\n Ucnle Bob";
            Console.WriteLine(alinti);

            //verbatim string : @ ile başlar. Yazıldığı gibi ekrana yazar
            string path2 = @"Sasdd\Sasdd\Sasdaad\Ssdada";
            Console.WriteLine(path2);

            string mesaj = @"Merhaba 
                            C# 
                        dünyasına 
                   hoşgeldiniz";
            Console.WriteLine(mesaj);

            string suslu = @"
                             ****************************************
                             *** Bu uygulama 17.06.2023 tarihinde ***
                             *** MCSD Kursunda yazılmıştır.       ***
                             ****************************************";
            Console.WriteLine(suslu);

            // \n bir alt satıra geç : new line
            Console.WriteLine("\n\nbu mesajın devamı \nbir alt satırda devam eder.\n\n\n");
            Console.WriteLine("Adınız : Doğan\nSoyadınız : ALICI\nMesleğiniz : Bilgisayar Mühendisi");

            // \a : alert : beep sesi çıkartır
            Console.WriteLine("Merhaba \a");

            // \t : bir tab boşluk bırakır
            Console.WriteLine("\nAd\t\tSoyad\t\tMeslek");
            Console.WriteLine("Doğan\t\tALICI\t\tBilgisayar Mühendisi");

            Console.WriteLine("\n----------");
            string str = @"MYO\nBIL";
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
