using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Soru1();
            Soru2();
            Soru3();
            Soru4();
            
        }
        ////Soru1
            /// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            /// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            /// Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            /// 
        static public void Soru1()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            Console.WriteLine("Lütfen {0} adet pozitif sayı giriniz: ",n);
            for (int i = 0; i < n; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Girmiş olduğunuz sayılardan çift olanlar : ");
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                    Console.WriteLine(item);
            }
        }
        //Soru2 
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        static public void Soru2()
        {
            Console.WriteLine("Lütfen pozitif 2 sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] dizi=new int[n];
            Console.WriteLine("Lütfen {0} adet pozitif sayı giriniz : ",n);
            for (int i = 0; i < n; i++)
            {
                dizi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Girmiş olduğunuz sayılardan {0} ile tam bölünenler : ", m);
            foreach (var item in dizi)
            {
                if (item % m == 0)
                    Console.WriteLine(item);
            }
        }
        /// Soru3
        /// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        /// Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        /// Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        /// 
        static public void Soru3()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            string[] dizi = new string[n];
            Console.WriteLine("Lütfen {0} adet kelime giriniz: ",n);
            for(int i = 0; i < n; i++)
            {
                dizi[i] = Console.ReadLine();
            }
            Console.WriteLine("Girmiş olduğunuz kelimeler sondan başa doğru şu sırada : ");
            for(int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(dizi[i]);
            }
        }
        //Soru4
        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        static public void Soru4()
        {
            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string ifade = Console.ReadLine();
            string[] dizi = ifade.Split(" ");
            string nIfade = string.Join("",dizi);
            int kelime = 0;
            foreach (var item in dizi)
            {
                kelime++;
            }
            int harf = 0;
            foreach (var item in nIfade)
            {
               harf++;
            }

            Console.WriteLine("Cümledeki kelime sayısı : {0}, harf sayısı : {1}", kelime, harf);
        }

    }
}