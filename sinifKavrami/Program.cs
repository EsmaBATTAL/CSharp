using System;

namespace sinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "Ayşe";
            calisan1.soyad = "Kırılmaz";
            calisan1.no = 123354687;
            calisan1.departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Console.WriteLine("---------------------------------------------------------------");

            Calisan calisan2 = new Calisan();
            calisan2.ad = "Derya";
            calisan2.soyad = "Deniz";
            calisan2.no = 987643131;
            calisan2.departman = "Satın Alma";
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string ad;
        public string soyad;
        public int no;
        public string departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı:{0}",ad);
            Console.WriteLine("Çalışan soyadı:{0}",soyad);
            Console.WriteLine("Çalışan no:{0}",no);
            Console.WriteLine("Çalışan departmanı:{0}",departman);
        }
    }
}