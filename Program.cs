using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
    
        static void Start(int time)
        {
            int currenTime = 0;

            while(time != currenTime)
            {
                Console.Clear();
                currenTime++;
                Console.WriteLine(currenTime);
                Thread.Sleep(500);
            }

            Console.Clear();
            Console.WriteLine("Cronometro foi finalizado");

            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo =  1s = 1 segundo");
            Console.WriteLine("M = Minuto = 1m = 1 minuto");
            Console.WriteLine("Quanto tempo deseja contar?");
            
            var data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1));
            int time = int.Parse(data.Substring(0,data.Length -1));
            var multiplicador = 1;

            if(type == 'm')
                multiplicador = 60;

            if(type == '0')
                System.Environment.Exit(0);

            Prestart(time * multiplicador);

        }
    
        static void Prestart(int time)
        {
            Console.Clear();
            Console.WriteLine("Aguarde");
            Thread.Sleep(1000);
            Console.WriteLine("Prepare-se");
            Thread.Sleep(1000);
            Console.WriteLine("Pronto!");
            Thread.Sleep(1000);

            Start(time);
        }
    }
}
