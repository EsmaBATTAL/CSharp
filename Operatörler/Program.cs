using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);




            bool isSuccess = true;
            bool isCompleted = false;
            if ( isSuccess && isCompleted){
                Console.WriteLine("Perfect");
            }
            if (isCompleted || isSuccess){
                Console.WriteLine("Great");
            }
            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine");
            }
        }
    }
}
