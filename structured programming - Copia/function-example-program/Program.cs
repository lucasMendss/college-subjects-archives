using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota da P1:");
            double p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da P1:");
            int peso1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da P2:");
            double p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da P2:");
            int peso2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Média ponderada das duas notas: {0}", MediaP(p1, p2, peso1, peso2).ToString("N2"));
        }

        private static double MediaP(double p1, double p2, int peso1, int peso2)
        {
            double media = (p1*peso1 + p2*peso2) / (peso1 + peso2);
            return media;
        }
    }
}
