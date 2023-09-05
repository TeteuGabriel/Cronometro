using System;
using System.Threading;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
               Menu();
        }

        static void Menu ()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m - 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int tempo = int.Parse(data.Substring(0, data.Length - 1 ));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (tempo == 0)
                System.Environment.Exit(0); 

            PreInicio (tempo *  multiplier);   
            
        }

        static void PreInicio(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Vai...");
            Thread.Sleep(2500);

            Inicio(tempo);

        }

        static void Inicio(int tempo)
        {
           
            int tempoatual = 0;

            while (tempoatual != tempo)
            {
                Console.Clear();    
                tempoatual++;
                Console.WriteLine(tempoatual); 
                Thread.Sleep(1000); 
            }
                
            Console.Clear() ;
            Console.WriteLine("Contagem Finalizada");
            Thread.Sleep(2500);
            Menu();
        }
    }
}