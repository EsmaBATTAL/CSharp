using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ali";
            ogrenci.Soyisim = "Demir";
            ogrenci.OgrenciNo = 352;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();


            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Derya", 332, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

        }
    }
    
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get {return isim;}
            set {isim = value;}
        }

        public string Soyisim{get=>soyisim; set=>soyisim=value;}
        public int OgrenciNo{get=>ogrenciNo; set=>ogrenciNo=value;}
        public int Sinif
        {
            get=>sinif; 
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif=1;
                }
                else
                {
                    sinif=value;
                }
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim=isim;
            Soyisim=soyisim;
            OgrenciNo=ogrenciNo;
            Sinif=sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******** Öğrenci Bilgileri ********");
            Console.WriteLine("Öğrenci Adı         :{0}", Isim);
            Console.WriteLine("Öğrenci Soyadı      :{0}", Soyisim);
            Console.WriteLine("Öğrenci No          :{0}", OgrenciNo);
            Console.WriteLine("Öğrenci Sınfı       :{0}", Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif =this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif =this.Sinif - 1;
        }
    }
}