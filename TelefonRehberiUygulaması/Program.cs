using System;
using System.Collections.Generic;

namespace TelefonRehberiUygulamasi
{
    public class Kisi
    {
        private string isim;
        private string soyisim;
        private string telefon;
        public string Isim { get=>isim; set=>isim = value; }
        public string Soyisim { get=>soyisim; set=>soyisim =value; }
        public string Telefon { get=>telefon; set=>telefon = value; }
    }

    public class Rehber
    {
        private List<Kisi> kisiler = new List<Kisi>();

        public Rehber()
        {
            kisiler.Add(new Kisi { Isim = "Ahmet", Soyisim = "Yılmaz", Telefon = "05321234567" });
            kisiler.Add(new Kisi { Isim = "Ayşe", Soyisim = "Demir", Telefon = "05419876543" });
            kisiler.Add(new Kisi { Isim = "Mehmet", Soyisim = "Kaya", Telefon = "05551234567" });
            kisiler.Add(new Kisi { Isim = "Elif", Soyisim = "Çelik", Telefon = "05331239876" });
            kisiler.Add(new Kisi { Isim = "Can", Soyisim = "Arslan", Telefon = "05071234567" });
        }

        // (1) Yeni Numara Kaydet
        public void YeniNumaraKaydet()
        {
            Console.Write("Lütfen isim giriniz             : ");
            string isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          : ");
            string soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz : ");
            string telefon = Console.ReadLine();

            kisiler.Add(new Kisi { Isim = isim, Soyisim = soyisim, Telefon = telefon });
            Console.WriteLine("Numara başarıyla kaydedildi!");
        }

        // (2) Numara Sil
        public void NumaraSil()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine().ToLower();

            Kisi bulunan = null;
            foreach (var k in kisiler)
            {
                if (k.Isim.ToLower() == input || k.Soyisim.ToLower() == input)
                {
                    bulunan = k;
                    break;
                }
            }

            if (bulunan == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string secim = Console.ReadLine();
                if (secim == "2") NumaraSil();
                return;
            }

            Console.WriteLine($"{bulunan.Isim} {bulunan.Soyisim} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n)");
            string onay = Console.ReadLine();
            if (onay.ToLower() == "y")
            {
                kisiler.Remove(bulunan);
                Console.WriteLine("Kişi başarıyla silindi!");
            }
        }

        // (3) Numara Güncelle
        public void NumaraGuncelle()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string input = Console.ReadLine().ToLower();

            Kisi bulunan = null;
            foreach (var k in kisiler)
            {
                if (k.Isim.ToLower() == input || k.Soyisim.ToLower() == input)
                {
                    bulunan = k;
                    break;
                }
            }

            if (bulunan == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");
                string secim = Console.ReadLine();
                if (secim == "2") NumaraGuncelle();
                return;
            }

            Console.Write("Yeni telefon numarasını giriniz: ");
            string yeniTelefon = Console.ReadLine();
            bulunan.Telefon = yeniTelefon;
            Console.WriteLine("Numara başarıyla güncellendi!");
        }

        // (4) Rehberi Listele
        public void RehberiListele()
        {
            Console.WriteLine("Listeleme seçiniz: (1) A-Z (2) Z-A");
            string secim = Console.ReadLine();

            List<Kisi> liste = new List<Kisi>(kisiler);

            if (secim == "1")
                liste.Sort((x, y) => x.Isim.CompareTo(y.Isim));
            else if (secim == "2")
                liste.Sort((x, y) => y.Isim.CompareTo(x.Isim));

            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var k in liste)
            {
                Console.WriteLine($"isim: {k.Isim} Soyisim: {k.Soyisim} Telefon Numarası: {k.Telefon}");
            }
        }

        // (5) Rehberde Arama
        public void RehberdeArama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string secim = Console.ReadLine();

            List<Kisi> sonuc = new List<Kisi>();

            if (secim == "1")
            {
                Console.Write("Aramak istediğiniz isim/soyisim: ");
                string input = Console.ReadLine().ToLower();
                foreach (var k in kisiler)
                {
                    if (k.Isim.ToLower().Contains(input) || k.Soyisim.ToLower().Contains(input))
                        sonuc.Add(k);
                }
            }
            else if (secim == "2")
            {
                Console.Write("Aramak istediğiniz telefon numarası: ");
                string input = Console.ReadLine();
                foreach (var k in kisiler)
                {
                    if (k.Telefon.Contains(input))
                        sonuc.Add(k);
                }
            }

            YazdirSonuc(sonuc);
        }

        private void YazdirSonuc(List<Kisi> sonuc)
        {
            Console.WriteLine("Arama Sonuçlarınız:");
            Console.WriteLine("**********************************************");
            foreach (var k in sonuc)
            {
                Console.WriteLine($"isim: {k.Isim} Soyisim: {k.Soyisim} Telefon Numarası: {k.Telefon}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rehber rehber = new Rehber();

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.Write("*******************************************");
                Console.Write("(1) Yeni Numara Kaydetmek ");
                Console.Write("(2) Varolan Numarayı Silmek ");
                Console.Write("(3) Varolan Numarayı Güncelleme ");
                Console.Write("(4) Rehberi Listelemek ");
                Console.WriteLine("(5) Rehberde Arama Yapmak ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1": rehber.YeniNumaraKaydet(); break;
                    case "2": rehber.NumaraSil(); break;
                    case "3": rehber.NumaraGuncelle(); break;
                    case "4": rehber.RehberiListele(); break;
                    case "5": rehber.RehberdeArama(); break;
                    default: Console.WriteLine("Geçersiz seçim!"); break;
                }
            }
        }
    }


}