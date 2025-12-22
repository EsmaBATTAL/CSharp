using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace koleksiyonlarSoru2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ///Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            ///her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama 
            ///toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            
            Console.WriteLine("Lütfen 20 adet sayı giriniz: ");
            ArrayList dList = new ArrayList();
            
           
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. sayı : ", i+ 1);
                dList.Add(int.Parse(Console.ReadLine()));
            }
            dList.Sort();
            int bOrt = 0;
            int kOrt = 0;
            for(int i = 0; i < 3; i++)
            {
                kOrt+=Convert.ToInt32(dList[i]);
            }
            kOrt /= 3;
            Console.WriteLine("Listedeki en küçük 3 elemanın ortalaması " + kOrt);
            dList.Reverse();
            for(int i = 0; i < 3; i++)
            {
                bOrt+=Convert.ToInt32(dList[i]);
            }
            bOrt /= 3;
            int tOrt = kOrt+bOrt;
            Console.WriteLine("Listedeki en büyük 3 elemanın ortalaması " + bOrt);
            Console.WriteLine("En küçük 3 elemanın ortalaması ve en büyük 3 elemanın ortalaması toplamı " + tOrt);
        }
    }
}