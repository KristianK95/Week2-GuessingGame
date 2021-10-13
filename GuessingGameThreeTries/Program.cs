using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbrit 1 kuni 10;
            //kasutaja peab selle numbri ara arvama;
            //kui kasutaja suutis numbri ara arvata, siis ta on mangu voitnud;
            //kasutajal on 3 katset, kui kasutaja ei suuda 3 katsega numbrit ara arvata, siis mangu voidab arvuti;
            //*programm genereerib juhuslikku numbrit 1 korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool cpu = false;

            while(cpuNumber < 3)
            {

                Console.WriteLine("Vali number ühest kümneni:");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i != cpuNumber)
                {
                    Console.WriteLine("Vale number. Arva uuesti:");
                    
                }
               

                else if (i == cpuNumber)
                {
                    Console.WriteLine("Võitsid- õige number!");
                }

            } while (cpu == false);
        }
    }
}
