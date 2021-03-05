using System;

namespace Aplikacja
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int los = rnd.Next(1, 50);
            int proba;
            float ilerazy = 0;
            float trafnosc;

            Console.WriteLine("Zgadnij liczbe z zakresu 1-1");

            do
            {
                ilerazy++;
                
                proba = int.Parse(Console.ReadLine());

                    if(proba>los)
                        Console.WriteLine("Twoja liczba jest za duza!");
                    else if(los>proba)
                        Console.WriteLine("Liczba jest za mala!");
                    else
                {
                    trafnosc = (1 / ilerazy)*100;
                    Console.WriteLine("Gratulacje, trafiłeś za "+ilerazy+" razem. Twoja trafnosc wynosi "+trafnosc+"%");
                }
                         

            } while (los!=proba);
        }
    }
}
