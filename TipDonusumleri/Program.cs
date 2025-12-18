using System;
using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;

namespace tipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Implicit Conversion *****");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.Write("d : " + d);

            long h = d ;
            Console.Write("h : " + h);

            float i = h ;
            Console.Write("i : " + i);



            string e = "esma";
            char f = 'e';
            object g = e + f + d;
            Console.WriteLine("g : "+g);



        Console.WriteLine("***** Explicit Conversion *****");

        int x = 4;
        byte y = (byte)x;
        Console.WriteLine("y : "+y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t : "+t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v : "+v);

        Console.WriteLine("***** ToString Metodu *****");

        int xx = 6;
        string yy =xx.ToString();
        Console.WriteLine("yy : " +yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz : " +zz);

        Console.WriteLine("***** System.Convert Sınıfı *****");

        string s1 = "10" , s2 = "20";
        int sayi1, sayi2;
        int toplam;
        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);
        toplam = sayi1+sayi2;
        Console.WriteLine("toplam = " +toplam);

        Console.WriteLine("***** Parse Metodu *****");
        ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam;
            double double1;

            rakam = Int32.Parse(metin1);
            double1 =Double.Parse(metin2);

            Console.WriteLine("rakam  : " + rakam);
            Console.WriteLine("double : " + double1);


        }
    }
}