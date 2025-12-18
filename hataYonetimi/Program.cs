using System;
using System.Data;
using System.Diagnostics;

namespace hataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString() );
            }
        }
    }
}