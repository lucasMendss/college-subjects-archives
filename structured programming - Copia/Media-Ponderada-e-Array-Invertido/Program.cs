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
            void MediaPonderada()
            {
                double[] notas = new double[3];
                string[] atividades = new string[3] { "atividade de laboratório", "avaliação semestral", "prova final" };
                double mediaP = 0;
                string conceito = "", continuar = "S", nomeAluno;

                do
                {
                    Console.WriteLine("Digite o nome do(a) aluno(a):");
                    nomeAluno = Console.ReadLine();

                    for (int ii = 0; ii < 3; ii++)
                    {
                        bool validouInput = false;
                        while (!validouInput)
                        {
                            Console.WriteLine("Informe a nota da {0} do aluno:", atividades[ii]);
                            validouInput = double.TryParse(Console.ReadLine(), out notas[ii]);

                            if (!validouInput || notas[ii] < 0 || notas[ii] > 10)
                            {
                                Console.WriteLine("A nota deve estar entre 0 e 10. Digite novamente.");
                                validouInput = false;
                            }
                        }
                    }

                    mediaP = (notas[0] * 2 + notas[1] * 3 + notas[2] * 5) / 10;
                    if (mediaP >= 8)
                        conceito = "A";
                    else if (mediaP >= 7)
                        conceito = "B";
                    else if (mediaP >= 6)
                        conceito = "C";
                    else if (mediaP >= 5)
                        conceito = "D";
                    else
                        conceito = "E";

                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Aluno: {0}", nomeAluno);
                    Console.WriteLine("- Nota da {0}: {1}", atividades[0], notas[0]);
                    Console.WriteLine("- Nota da {0}: {1}", atividades[1], notas[1]);
                    Console.WriteLine("- Nota da {0}: {1}", atividades[2], notas[2]);
                    Console.WriteLine("- Média ponderada das atividades: {0}", mediaP);
                    Console.WriteLine("- Conceito: {0}", conceito);
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Deseja calcular média de outro(a) aluno(a)? (S/N):");
                    continuar = Console.ReadLine();
                }
                while (continuar.ToUpper() == "S");
            }

            void PrintInvertedArray()
            {
                int[] nums = new int[10] {1,2,3,4,5,6,7,8,9,10};

                for (int ii = nums.Length; ii > 0; ii--)
                {
                    Console.WriteLine(nums[ii-1]);
                }
            }

            PrintInvertedArray();
        }
    }
}