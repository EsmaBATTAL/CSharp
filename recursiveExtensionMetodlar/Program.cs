using System;

namespace recursiveExtensionMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i =1; i<5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);


            Console.WriteLine("***** Recursive Metodlar *****");
            Islemler instance=new();
            Console.WriteLine(instance.Expo(3,4));

            Console.WriteLine("***** Extension Metodlar *****");
            string ifade = "Esma BATTAL";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(sonuc);
            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());


            int[] dizi={9,3,6,5,7,8,0};
            dizi.SortArray();
            dizi.EkranaYaz();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if(us < 2)
                return sayi;
            return Expo(sayi,us-1) *sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi= param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
         public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYaz(this int[] param)
        {
            foreach (var i in param)
            {
                Console.WriteLine(i);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2==0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }

    }
}