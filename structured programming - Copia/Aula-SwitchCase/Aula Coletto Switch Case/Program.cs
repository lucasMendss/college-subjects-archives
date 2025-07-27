using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Coletto_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void IndicaMes()
            {
                string month;

                Console.WriteLine("Digite um mês do ano de forma abreviada (exemplo: jan, abr, dez...):");
                month = Console.ReadLine();

                switch (month.ToLower())
                {
                    case "jan":
                    case "mar":
                    case "mai":
                    case "jul":
                    case "ago":
                    case "out":
                    case "dez":
                        Console.WriteLine("O mês de {0} tem 31 dias ", month.ToLower());
                        break;
                    case "abr":
                    case "jun":
                    case "set":
                    case "nov":
                        Console.WriteLine("O mês de {0} tem 30 dias ", month.ToLower());
                        break;
                    case "fev":
                        Console.WriteLine("O mês de {0} tem 28 dias ", month.ToLower());
                        break;
                }
            }

            void IndicaSeImparOuPar()
            {
                int num = 0;
                bool converted = false;

                while (!converted)
                {
                    Console.WriteLine("Digite um número entre 1 e 10 para eu dizer se ele é par ou ímpar!");
                    converted = int.TryParse(Console.ReadLine(), out num);

                    if (!converted || num < 1 || num > 10)
                    {
                        Console.WriteLine("O número precisa estar entre 1 e 10!");
                        converted = false;
                    }
                }

                if ((num % 2) == 0)
                {
                    Console.WriteLine("{0} é par.", num);
                }
                else
                {
                    Console.WriteLine("{0} é ímpar.", num);
                }
            }

            void IndicaDisciplinasDoProf ()
            {
                Console.WriteLine("Digite o nome de um dos seguintes professores:");
                Console.WriteLine("---------------------");
                Console.WriteLine("- Coletto;");
                Console.WriteLine("- Marco;");
                Console.WriteLine("- Alberto;");
                Console.WriteLine("- Tuler;");
                Console.WriteLine("- Nelson Paz;");
                Console.WriteLine("---------------------");

                string profName = Console.ReadLine();

                switch (profName.ToUpper())
                {
                    case "COLETTO":
                        Console.WriteLine("O prof. {0} ministra Programação Estruturada e Banco de Dados.", profName);
                        break;
                    case "MARCO":
                        Console.WriteLine("O prof. {0} ministra EDD1.", profName);
                        break;
                    case "ALBERTO":
                        Console.WriteLine("O prof. {0} ministra Redes e Lógica de Programação.", profName);
                        break;
                    case "TULER":
                        Console.WriteLine("O prof. {0} ministra AUDS, SWE, LPR1 e ENGS.", profName);
                        break;
                    case "NELSON PAZ":
                    case "NELSON":
                        Console.WriteLine("O prof. {0} ministra Programação Estruturada, IHC e Lógica de Programação.", profName);
                        break;
                }
            }

            // IndicaMes();
            // IndicaSeImparOuPar();

            string continua = "S";
            while (continua.ToLower() == "s")
            {
                IndicaDisciplinasDoProf();

                Console.WriteLine("Repetir? [S/N]?");
                continua = Console.ReadLine();
            }
        }
    }
}
