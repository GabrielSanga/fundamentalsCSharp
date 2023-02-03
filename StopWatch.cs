using System;
using System.Threading;

namespace Projeto
{
    class StopWatch
    {

        public static void Aplication()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Informe o tempo (1s) ou (1m): ");
            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            Start(time * multiplier);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();

                Console.WriteLine(currentTime);
                currentTime++;

                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado!");
            Thread.Sleep(2500);

            Menu();
        }

    }

}
