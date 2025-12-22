using System;
using System.Collections;

namespace koleksiyonlarSoru1
{
    class Program
    {
        static public bool primeNumber(int n)
        {
            if (n == 1)
                return false;
            for (int i = 2 ; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static public bool isNumeric(string s)
        {
            foreach (var item in s)
            {
                if (item == '-')
                {
                    Console.WriteLine("Negatif sayı girmeyiniz.");
                    return false;
                }
                if (!Char.IsNumber(item))
                {
                    Console.WriteLine("Lütfen sayı giriniz");
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            ///Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            ///(ArrayList sınıfını kullanara yazınız.)
            /// Negatif ve numeric olmayan girişleri engelleyin.
            /// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            /// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            ArrayList dList = new ArrayList();
            Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz: ");
            string sayi;
            for (int i = 0; i < 20; i++)
            {
                sayi = Console.ReadLine();
                if(isNumeric(sayi))
                    dList.Add(Convert.ToInt32(sayi));
                else
                    i--;
                    
            }
            ArrayList aList = new ArrayList();
            ArrayList aoList = new ArrayList();

            foreach (var item in dList)
            {
                if(primeNumber(Convert.ToInt32(item)))
                    aList.Add(item);
                else
                    aoList.Add(item);
            }
            aList.Sort();
            aList.Reverse();
            aoList.Sort();
            aoList.Reverse();
            Console.WriteLine("Asal Liste");
            float aT = 0;
            float oT = 0;
            float aoT = 0;
            float oaoT = 0;
            foreach (var item in aList)
            {
                aT += Convert.ToInt32(item);
                Console.WriteLine(item);
            }
            oT = aT / aList.Count;
            Console.WriteLine("Asal Olmayan Liste");
             foreach (var item in aoList)
            {
                aoT += Convert.ToInt32(item);
                Console.WriteLine(item);
            }
            oaoT =aoT/ aoList.Count;
            Console.WriteLine("Asal sayılar listesinin eleman sayısı {0} 'dır. Ortalaması {1}'dır.",aList.Count,oT);
            Console.WriteLine("Asal olmayan sayılar listenin eleman sayısı {0} 'dır. Ortalaması {1}'dır.",aoList.Count,oaoT);
        }
    }
}
