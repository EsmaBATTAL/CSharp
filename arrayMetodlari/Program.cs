using System;

namespace arrayMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi ={23,3,42,54,7,78,46,32};
            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Array.Sort(sayiDizisi);
            Console.WriteLine("***** Sıralı Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("***** Array Clear *****");
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
             Array.Reverse(sayiDizisi);
            Console.WriteLine("***** Array Reverse *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
             
            Console.WriteLine("***** Array Indexof *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,42));

            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=67;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}