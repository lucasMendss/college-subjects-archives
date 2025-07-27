using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_Coletto_31_03_2025_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1
            void IndicaOMaiorEntreTresNumeros()
            {
                double num1 = 0, num2 = 0, num3 = 0;
                bool converteu = false;

                while (!converteu)
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    converteu = double.TryParse(Console.ReadLine(), out num1);

                    if (!converteu)
                    {
                        Console.WriteLine("Você precisa digitar um número.");
                    }
                }

                converteu = false;

                while (!converteu)
                {
                    Console.WriteLine("Digite o segundo número: ");
                    converteu = double.TryParse(Console.ReadLine(), out num2);

                    if (!converteu)
                    {
                        Console.WriteLine("Você precisa digitar um número.");
                    }
                }

                converteu = false;

                while (!converteu)
                {
                    Console.WriteLine("Digite o terceiro número: ");
                    converteu = double.TryParse(Console.ReadLine(), out num3);

                    if (!converteu)
                    {
                        Console.WriteLine("Você precisa digitar um número.");
                    }
                }

                if (num1 > num2 && num1 > num3)
                    Console.WriteLine("O maior número é " + num1);
                else if (num2 > num1 && num2 > num3)
                    Console.WriteLine("O maior número é " + num2);
                else if (num3 > num1 && num3 > num2)
                    Console.WriteLine("O maior número é " + num3);
                else if (num1 == num2 && num1 > num3)
                    Console.WriteLine("O maior número é " + num1 + ", que foi digitado duas vezes");
                else if (num1 == num3 && num1 > num2)
                    Console.WriteLine("O maior número é " + num1 + ", que foi digitado duas vezes");
                else if (num2 == num3 && num2 > num1)
                    Console.WriteLine("O maior número é " + num1 + ", que foi digitado duas vezes");
                else if (num1 == num2 && num1 == num3)
                    Console.WriteLine("O mesmo número foi digitado três vezes!!");
            }

            void ResolveEquacaoSegGrau()
            {
                double aa = 0, bb = 0, cc = 0, delta = 0, raiz1 = 0, raiz2 = 0;
                bool converteu = false;

                while (!converteu)
                {
                    Console.WriteLine("Digite o valor de a: ");
                    converteu = double.TryParse(Console.ReadLine(), out aa);

                    if (!converteu)
                    {
                        Console.WriteLine("Você precisa digitar um número.");
                    }
                }

                converteu = false;

                while (!converteu)
                {
                    Console.WriteLine("Digite o valor de b: ");
                    converteu = double.TryParse(Console.ReadLine(), out bb);

                    if (!converteu)
                    {
                        Console.WriteLine("Você precisa digitar um número.");
                    }
                }

                converteu = false;

                while (!converteu)
                {
                    Console.WriteLine("Digite o valor de c: ");
                    converteu = double.TryParse(Console.ReadLine(), out cc);

                    if (!converteu)
                    {
                        Console.WriteLine("Você precisa digitar um número.");
                    }
                }

                if (aa == 0)
                {
                    Console.WriteLine("Não existe equação do segundo grau se a valer 0.");
                }
                else
                {
                    delta = (bb * bb) - (4 * aa * cc);
                    if (delta < 0)
                    {
                        Console.WriteLine("Não há raízes reais quando delta é negativo.");
                    }
                    else
                    {
                        raiz1 = (-bb + Math.Sqrt(delta)) / 2 * aa;
                        raiz2 = (-bb - Math.Sqrt(delta)) / 2 * aa;
                        Console.WriteLine("Raíz 1: " + raiz1);
                        Console.WriteLine("Raíz 2: " + raiz2);
                    }
                }

                converteu = false;
            }

            void IndicaDiaDaSemana()
            {
                int num = 0;
                bool converteu = false;

                while (!converteu)
                {
                    Console.WriteLine("Digite um número entre 1 e 7: ");
                    converteu = int.TryParse(Console.ReadLine(), out num);

                    if (!converteu || num <= 0)
                    {
                        Console.WriteLine("Você precisa digitar um número entre 1 e 7!!!!");
                        converteu = false;
                    }
                }

                switch (num) 
                {
                    case 1:
                        {
                            Console.WriteLine("O número digitado é equivalente ao Domingo!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("O número digitado é equivalente à Segunda-feira!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("O número digitado é equivalente à Terça-feira!");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("O número digitado é equivalente à Quarta-feira!");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("O número digitado é equivalente à Quinta-feira!");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("O número digitado é equivalente à Sexta-feira!");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("O número digitado é equivalente ao Sábado!");
                            break;
                        }
                }
            }

            //IndicaOMaiorEntreTresNumeros();
            //ResolveEquacaoSegGrau();
            IndicaDiaDaSemana();

            Console.ReadKey();  
        }
    }
}
