using System;
using System.Collections.Generic;

namespace YapilacaklarTahtasiApp
{
    // Enum: Kart büyüklükleri
    public enum Buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }

    // Takım üyesi
    public class TakimUyesi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }

    // Kart
    public class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public TakimUyesi AtananKisi { get; set; }
        public Buyukluk KartBuyuklugu { get; set; }
    }

    // Kolon (TODO, IN PROGRESS, DONE)
    public class Kolon
    {
        public string Ad { get; set; }
        public List<Kart> Kartlar { get; set; } = new List<Kart>();
    }

    // Tahta
    public class Tahta
    {
        public Kolon Yapilacak { get; set; } = new Kolon { Ad = "TODO" };
        public Kolon DevamEden { get; set; } = new Kolon { Ad = "IN PROGRESS" };
        public Kolon Tamamlanan { get; set; } = new Kolon { Ad = "DONE" };

        public List<TakimUyesi> TakimUyeleri { get; set; } = new List<TakimUyesi>();

        public Tahta()
        {
            // Varsayılan takım üyeleri
            TakimUyeleri.Add(new TakimUyesi { Id = 1, Ad = "Ahmet" });
            TakimUyeleri.Add(new TakimUyesi { Id = 2, Ad = "Ayşe" });
            TakimUyeleri.Add(new TakimUyesi { Id = 3, Ad = "Mehmet" });

            // Varsayılan kartlar
            Yapilacak.Kartlar.Add(new Kart { Baslik = "Alışveriş", Icerik = "Market alışverişi yapılacak", AtananKisi = TakimUyeleri[0], KartBuyuklugu = Buyukluk.M });
            DevamEden.Kartlar.Add(new Kart { Baslik = "Proje", Icerik = "C# Console App yazılacak", AtananKisi = TakimUyeleri[1], KartBuyuklugu = Buyukluk.L });
            Tamamlanan.Kartlar.Add(new Kart { Baslik = "Kitap", Icerik = "Roman okundu", AtananKisi = TakimUyeleri[2], KartBuyuklugu = Buyukluk.S });
        }

        // (1) Tahtayı Listele
        public void TahtayiListele()
        {
            KolonYazdir(Yapilacak);
            KolonYazdir(DevamEden);
            KolonYazdir(Tamamlanan);
        }

        private void KolonYazdir(Kolon kolon)
        {
            Console.WriteLine($"{kolon.Ad} Line");
            Console.WriteLine("************************");
            if (kolon.Kartlar.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var kart in kolon.Kartlar)
                {
                    Console.WriteLine($"Başlık      : {kart.Baslik}");
                    Console.WriteLine($"İçerik      : {kart.Icerik}");
                    Console.WriteLine($"Atanan Kişi : {kart.AtananKisi.Ad}");
                    Console.WriteLine($"Büyüklük    : {kart.KartBuyuklugu}");
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine();
        }

        // (2) Kart Ekle
        public void KartEkle()
        {
            Console.Write("Başlık Giriniz: ");
            string baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz: ");
            string icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
            int buyuklukSecim = int.Parse(Console.ReadLine());

            if (!Enum.IsDefined(typeof(Buyukluk), buyuklukSecim))
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                return;
            }
            Buyukluk buyukluk = (Buyukluk)buyuklukSecim;

            Console.WriteLine("Kişi Seçiniz (ID giriniz):");
            foreach (var u in TakimUyeleri)
            {
                Console.WriteLine($"{u.Id} - {u.Ad}");
            }
            int uyeId = int.Parse(Console.ReadLine());
            TakimUyesi uye = TakimUyeleri.Find(u => u.Id == uyeId);

            if (uye == null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                return;
            }

            Yapilacak.Kartlar.Add(new Kart { Baslik = baslik, Icerik = icerik, AtananKisi = uye, KartBuyuklugu = buyukluk });
            Console.WriteLine("Kart başarıyla eklendi!");
        }

        // (3) Kart Sil
        public void KartSil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();

            bool bulundu = false;
            foreach (var kolon in new[] { Yapilacak, DevamEden, Tamamlanan })
            {
                var silinecekler = kolon.Kartlar.FindAll(k => k.Baslik.ToLower() == baslik.ToLower());
                if (silinecekler.Count > 0)
                {
                    foreach (var kart in silinecekler)
                    {
                        kolon.Kartlar.Remove(kart);
                        bulundu = true;
                    }
                }
            }

            if (!bulundu)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string secim = Console.ReadLine();
                if (secim == "2") KartSil();
            }
            else
            {
                Console.WriteLine("Kart(lar) başarıyla silindi!");
            }
        }

        // (4) Kart Taşı
        public void KartTasi()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();

            Kart bulunanKart = null;
            Kolon mevcutKolon = null;

            foreach (var kolon in new[] { Yapilacak, DevamEden, Tamamlanan })
            {
                foreach (var kart in kolon.Kartlar)
                {
                    if (kart.Baslik.ToLower() == baslik.ToLower())
                    {
                        bulunanKart = kart;
                        mevcutKolon = kolon;
                        break;
                    }
                }
                if (bulunanKart != null) break;
            }

            if (bulunanKart == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için     : (2)");
                string secim = Console.ReadLine();
                if (secim == "2") KartTasi();
                return;
            }

            Console.WriteLine("Bulunan Kart Bilgileri:");
            Console.WriteLine("**************************************");
            Console.Write($"Başlık : {bulunanKart.Baslik}");
            Console.Write($"İçerik : {bulunanKart.Icerik}");
            Console.Write($"Atanan Kişi : {bulunanKart.AtananKisi.Ad}");
            Console.Write($"Büyüklük : {bulunanKart.KartBuyuklugu}");
            Console.Write($"Kolon : {mevcutKolon.Ad}");

            Console.WriteLine("Lütfen taşımak istediğiniz Kolon'u seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");
            string secimKolon = Console.ReadLine();

            Kolon hedefKolon = null;
            if (secimKolon == "1") hedefKolon = Yapilacak;
            else if (secimKolon == "2") hedefKolon = DevamEden;
            else if (secimKolon == "3") hedefKolon = Tamamlanan;
            else
            {
                Console.WriteLine("Hatalı bir seçim yaptınız!");
                return;
            }

            mevcutKolon.Kartlar.Remove(bulunanKart);
            hedefKolon.Kartlar.Add(bulunanKart);

            Console.WriteLine("Kart başarıyla taşındı!");
            TahtayiListele();
        }
    }

    class Program
{
    static void Main(string[] args)
    {
        Tahta tahta = new Tahta();

        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.Write("(1) Board Listelemek");
            Console.Write("(2) Board'a Kart Eklemek");
            Console.Write("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    tahta.TahtayiListele();
                    break;
                case "2":
                    tahta.KartEkle();
                    break;
                case "3":
                    tahta.KartSil();
                    break;
                case "4":
                    tahta.KartTasi();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
}
