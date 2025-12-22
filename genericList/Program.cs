using System;
using System.Collections.Generic;

namespace genericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir
            List<int> sayiList = new List<int>();
            sayiList.Add(5);
            sayiList.Add(15);
            sayiList.Add(87);
            sayiList.Add(1);
            sayiList.Add(35);
            sayiList.Add(64);


            List<string> renkList= new List<string>();
            renkList.Add("Mavi");
            renkList.Add("Kırmızı");
            renkList.Add("Sarı");
            renkList.Add("Yeşil");


            Console.WriteLine(renkList.Count);
            Console.WriteLine(sayiList.Count);
            Console.WriteLine();


            /*foreach (var sayi in sayiList)
            {
                Console.WriteLine(sayi);
            }
            */
            /*
            foreach (var renk in renkList)
            {
                Console.WriteLine(renk);
            }
            */

            sayiList.ForEach(x=>Console.WriteLine(x));
            renkList.ForEach(renk=>Console.WriteLine(renk));


            sayiList.Remove(5);
            renkList.Remove("Sarı");

            sayiList.ForEach(x=>Console.WriteLine(x));
            renkList.ForEach(renk=>Console.WriteLine(renk));

            sayiList.RemoveAt(0);
            renkList.RemoveAt(1);

            sayiList.ForEach(x=>Console.WriteLine(x));
            renkList.ForEach(renk=>Console.WriteLine(renk));

            //Liste içerinde arama
            if (sayiList.Contains(35))
                Console.WriteLine("35 liste içinde bulundu.");


            //Eleman ile indexe erişme
            Console.WriteLine(renkList.BinarySearch("Yeşil"));


            //Diziyi Liste çevirme
            string[] hayvanlar = {"Maymun", "At", "Su Samuru", "Zürafa"};
            List<string> hayvanList = new List<string>(hayvanlar);


            //Listeyi temizleme
            hayvanList.Clear();


            //List içerisinde nesne tutma

            List<Kullanicilar> kullaniciList = new List<Kullanicilar>();
            
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Name = "Esma";
            kullanici1.Surname = "BATTAL";
            kullanici1.Old = 24;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Name = "Gamze";
            kullanici2.Surname = "KILIÇ";
            kullanici2.Old = 32;

            kullaniciList.Add(kullanici1);
            kullaniciList.Add(kullanici2);

            List<Kullanicilar> newList = new List<Kullanicilar>();
            newList.Add(new Kullanicilar()
            {
               Name="Derya",
               Surname="DENİZ",
               Old=34
            });

            foreach (var kullanici in kullaniciList)
            {
                Console.WriteLine("Kullanıcı Adı = "+ kullanici.Name);
                Console.WriteLine("Kullanıcı Soyadı = {0} ",kullanici.Surname);
                Console.WriteLine("Kullanıcı Yaşı = {0} ",kullanici.Old);
            }
            newList.Clear();
        }
    }
    public class Kullanicilar
    {
        private string name;
        private string surname;
        private int old;

        public string Name{get=> name; set=>name=value;}
        public string Surname{get=> surname; set=>surname = value;}
        public int Old{get=>old; set=>old = value;}
    }
}