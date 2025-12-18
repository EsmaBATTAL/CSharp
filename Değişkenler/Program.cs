using System;

namespace DegiskenlerOdev
{
    class Program
    {
        static void Main(string[] args)
        {
             int deger = 2;
            string degisken = null;
            string Degisken = null;

            byte b = 5;
            sbyte c = 5;

            short s = 5;
            ushort s2 = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 4;
            long l = 4;
            ulong ul = 4;

            float f = 4.2f;
            double d = 4.8;
            decimal de = 4.8M;


            char ch = 'c';
            string str = "deneme";

            bool b1 = true;
            bool b2 = false;

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);

            object o1 = "x";
            object o2 = 'c';
            object o3 = 2;
            object o4 = 4.3;

            string name=string.Empty;
            name = "Esma";
            string isim = "Esma";
            string soyisim = "Battal";
            string tamisim = isim + " " +soyisim;

            Console.WriteLine(tamisim);


            int integer1 = 4;
            int integer2 = 5;
            int integer3 = integer1 + integer2;



            bool bool1 = 10<2;




            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);


            int int22 = int20 +int.Parse(str20);


            string date = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(date);
            string date2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(date2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}