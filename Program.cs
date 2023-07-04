using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo(a) ao Stopwatch!");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();

            if (data == "0")
                System.Environment.Exit(0);

            char type = data[data.Length - 1];
            int time = 0;

            try
            {
                time = int.Parse(data.Substring(0, data.Length - 1));
            }
            catch
            {
                Console.WriteLine("Formato de entrada inválido! Tente novamente.");
                Thread.Sleep(2000);
                Menu();
            }

            int multiplier = type == 'm' ? 60 : 1;

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
