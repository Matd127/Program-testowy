using System;

namespace Aplikacja
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            while(a<5)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine(" ");

           for (int i = 0; i < 5; i++)
                Console.WriteLine("Tekst");
           
        }
    }
}
