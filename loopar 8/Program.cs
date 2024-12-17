using System;

namespace loopar_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int produkt = 1;
            for (int i = 1; i <=5; i++)
            {
                produkt *= i;
                {
                    Console.WriteLine("produkten av heltalen från 1 till 5 är;" + produkt);
                }

            }

        }
    }

}
