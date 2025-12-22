using System;

namespace kurucuMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Calisan calisan1 = new Calisan("Ayşe","Kırılmaz",123354687,"İnsan Kaynakları");
                calisan1.CalisanBilgileri();

                Console.WriteLine("---------------------------------------------------------------");

                Calisan calisan2 = new Calisan();
                calisan2.ad = "Derya";
                calisan2.soyad = "Deniz";
                calisan2.no = 987643131;
                calisan2.departman = "Satın Alma";
                calisan2.CalisanBilgileri();
                 Console.WriteLine("---------------------------------------------------------------");

                Calisan calisan3 = new Calisan("Korkmaz", "Yılmaz");
                calisan3.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
            this.departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı:{0}",ad);
            Console.WriteLine("Çalışan soyadı:{0}",soyad);
            Console.WriteLine("Çalışan no:{0}",no);
            Console.WriteLine("Çalışan departmanı:{0}",departman);
        }
    }
}
