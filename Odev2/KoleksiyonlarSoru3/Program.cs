using System;
using System.Collections;

namespace koleksiyonlarSoru3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
            /// ve dizinin elemanlarını sıralayan programı yazınız.
            /// 
            Console.WriteLine("Bir cümle giriniz : ");
            string girilenCumle = Console.ReadLine();

            ArrayList sesliHarf = new ArrayList();
            if (girilenCumle != null)
            {
                foreach (var item in girilenCumle)
                {
                    if (item == 'a' || item == 'e' || item == 'u'|| item == 'ı'|| item == 'o'|| item == 'ü'|| item == 'i'|| item == 'ö')
                        sesliHarf.Add(item);
                }
                
            }
            sesliHarf.Sort();
            foreach(var item in sesliHarf)
            {
                Console.WriteLine(item);
            }
        }
    }
}