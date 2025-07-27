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
            //Exercicios 29, 43, 44, 50

            void Exercicio29()
            {
                double acel = 0, velocIn = 0, velocFi = 0, velocFiConvertida = 0, tempo = 0;
                bool validouInput = false;

                while (!validouInput)
                {
                    Console.WriteLine("Digite o valor da ACELERAÇÃO em m/s²:");
                    validouInput = double.TryParse(Console.ReadLine(), out acel);

                    if (!validouInput )
                    {
                        Console.WriteLine("Valor inválido. Digite novamente.");
                    }
                }

                validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Digite o valor da VELOCIDADE INICIAL em m/s:");
                    validouInput = double.TryParse(Console.ReadLine(), out velocIn);

                    if (!validouInput || velocIn < 0)
                    {
                        Console.WriteLine("Valor inválido. Digite novamente.");
                        validouInput = false;
                    }
                }

                validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Digite o valor do TEMPO DE PERCURSO em s:");
                    validouInput = double.TryParse(Console.ReadLine(), out tempo);

                    if (!validouInput || tempo < 0)
                    {
                        Console.WriteLine("Valor inválido. Digite novamente.");
                        validouInput = false;
                    }
                }

                velocFi = velocIn + (acel * tempo);
                velocFiConvertida = velocFi * 3.6;

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("A velocidade do veículo no final do percurso foi:");
                Console.WriteLine("- Em m/s: {0}m/s", velocFi.ToString("N2"));
                Console.WriteLine("- Em km/h: {0}km/h", (velocFi * 3.6).ToString("N2"));

                if ( velocFiConvertida < 0 )
                    Console.WriteLine("Descrição: Veículo dando ré");
                else if (velocFiConvertida <= 40)
                    Console.WriteLine("Descrição: Veículo muito lento");
                else if (velocFiConvertida <= 60)
                    Console.WriteLine("Descrição: Veículo em velocidade permitida");
                else if (velocFiConvertida <= 80)
                    Console.WriteLine("Descrição: Veículo em velocidade de cruzeiro");
                else if (velocFiConvertida <= 120)
                    Console.WriteLine("Descrição: Veículo em velocidade rápida");
                else
                    Console.WriteLine("Descrição: Veículo muito rápido");
            }

            void Exercicio43()
            {
                int qtdeValores = 0;

                bool validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Digite a quantidade de valores que terá a sequência: ");
                    validouInput = int.TryParse(Console.ReadLine(), out qtdeValores); 
                    
                    if (!validouInput || qtdeValores < 0 || qtdeValores >= 50)
                    {
                        Console.WriteLine("A quantidade deve estar entre 0 e 49.");
                        validouInput = false;
                    }
                }

                Console.WriteLine("--------------------------------");
                for (int ii = 1; ii <= qtdeValores; ii++)
                {
                    Console.WriteLine("{0}/{1}", ii, ii + 1);
                }
            }

            void Exercicio44()
            {
                int qtdeValores = 0;

                bool validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Digite a quantidade de valores que terá a sequência: ");
                    validouInput = int.TryParse(Console.ReadLine(), out qtdeValores);

                    if (!validouInput || qtdeValores < 0 || qtdeValores >= 50)
                    {
                        Console.WriteLine("A quantidade deve estar entre 0 e 49.");
                        validouInput = false;
                    }
                }

                Console.WriteLine("--------------------------------");
                for (int ii = 1; ii <= qtdeValores; ii++)
                {
                    if (ii == 1)
                    {
                        Console.WriteLine(Math.Pow(ii, 2) + 1);
                    }
                    else
                    {
                       Console.WriteLine("{0}/{1}", Math.Pow(ii, 2) + 1, Math.Pow(ii, 3));
                    }
                    
                }
            }

            void Exercicio50()
            {
                double[] numeros;
                numeros = new double[3];

                for (int ii = 0; ii < 3; ii++)
                {
                    if (ii != 2)
                    {
                        bool converteuInput = false;
                        while (!converteuInput)
                        {
                            Console.WriteLine("Digite o {0}º valor:", ii + 1);
                            converteuInput = double.TryParse(Console.ReadLine(), out numeros[ii]);

                            if (!converteuInput)
                            {
                                Console.WriteLine("Valor inválido. Digite novamente");
                            }
                        }
                    }
                    else
                    {
                        bool converteuInput = false;
                        while (!converteuInput)
                        {
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("Escolha uma opção:");
                            Console.WriteLine("- Digite 1 para MULTIPLICAÇÃO");
                            Console.WriteLine("- Digite 2 para ADIÇÃO");
                            Console.WriteLine("- Digite 3 para DIVISÃO");
                            Console.WriteLine("- Digite 4 para SUBTRAÇÃO");
                            Console.WriteLine("- Digite 5 para FINALIZAR");
                            Console.WriteLine("-----------------------------");
                            converteuInput = double.TryParse(Console.ReadLine(), out numeros[ii]);

                            if (!converteuInput || numeros[ii] <= 0 || numeros[ii] > 5)
                            {
                                Console.WriteLine("Valor inválido. Digite novamente");
                                converteuInput = false;
                            }
                        }

                        switch (numeros[ii])
                        {
                            case 1:
                                Console.WriteLine("{0} X {1} = {2} ", numeros[0], numeros[1], numeros[0] * numeros[1]);
                                break;
                            case 2:
                                Console.WriteLine("{0} + {1} = {2} ", numeros[0], numeros[1], numeros[0] + numeros[1]);
                                break;
                            case 3:
                                if (numeros[1] == 0)
                                {
                                    Console.WriteLine("Impossível dividir por 0");
                                }
                                else
                                {
                                    Console.WriteLine("{0} / {1} = {2} ", numeros[0], numeros[1], numeros[0] / numeros[1]);
                                }
                                break;
                            case 4:
                                Console.WriteLine("{0} - {1} = {2} ", numeros[0], numeros[1], numeros[0] - numeros[1]);
                                break;
                            case 5:
                                Console.WriteLine("Programa finalizado.");
                                break;
                        }
                    }
                }
            }
            //Exercicio29(); 
            //Exercicio43();
            //Exercicio44();
            Exercicio50();
        }
    }
}
