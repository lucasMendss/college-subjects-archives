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
            /* Procedures
                - não retornam valor -> void */

            /* Funções
                - retornam algum valor -> têm um tipo (int, double, tring, etc.) */

            //Console.BackgroundColor = ConsoleColor.DarkBlue;

            int num = 2;
            int ano = 2028;
            Console.WriteLine(ano);
            Console.WriteLine("----------------------------");
            Console.WriteLine("É bissexto? " + VerifSeBissexto(ano));
            Console.WriteLine("----------------------------");
            Console.WriteLine(num);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Numero³: " + CalculaCubo(num));
            Console.WriteLine("É par?(T/f) " + VerifSePar(num));
            Console.WriteLine("É par? " + ClassificaNum(num));
            //Console.WriteLine("É primo? " + VerifSePrimo(num));
        }

        public static double CalculaCubo(int num)
        {
            return Math.Pow(num, 3);
        }

        static bool VerifSePar(int num)
        {
            if (num % 2 == 0) 
                return true; 
            else
                return false;
        }

        static string ClassificaNum(int num)
        {
            if (VerifSePar(num))
                return "O número é par";
            else
                return "O número é ímpar";
        }

        /*static string VerifSePrimo(int num)
        {

            if (num < 2)
                return "O número não é primo";
            else if (num == 2)
            {
                return "O número é primo";
            }
            else if (VerifSePar(num))
                return "O número não é primo";
            else
            {
                for (int i = 3; i < num/2; i++)
                {
                    if (i % 2 == 0)
                        return "O número não é primo";
                    else
                        return "O número é primo";
                }
            }
                
        }*/

        static bool VerifSeBissexto(int ano)
        {
            if (ano % 4 == 0)
            {
                if (ano % 100 == 0)
                {
                    if (ano % 400 == 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
