using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(21);
            //liste.Add(true);
            //liste.Add('A');
            //Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** AddRange *****");
            //string[] renkler = {"kırmızı", "sarı", "yeşil", "mavi"};
            List<int> sayilar = new List<int>(){1,5,7,9,3,2};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("***** Sort *****");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***** Binary Search *****");
            Console.WriteLine(liste.BinarySearch(9));

            Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

             Console.WriteLine("***** Clear *****");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}