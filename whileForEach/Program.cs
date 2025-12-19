using System;
using System.Security.Principal;

namespace whileForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1den başlayarak consoldan girilen sayıya kadar olan sayıların(girilen sayı dahil) ortalamasını olan algoritma
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // a'dan z'ye kadar olan tüm harfleri ekrana yazdıran algoritma
            char character = 'a';
            while (character <= 'z')
            {
                Console.WriteLine(character);
                character++;
            }


            Console.WriteLine("***** Foreach *****");
            string[] arabalar ={"BMW", "Toyota", "Nissan","Chery"};

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}