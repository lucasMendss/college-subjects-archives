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
            void Exercicio1()
            {
                int maior = 0;
                int[] numeros;
                numeros = new int[10];

                for (int i = 0; i < numeros.Length; i++)
                {
                    bool aceitouValor = false;

                    while (!aceitouValor)
                    {
                        Console.WriteLine("Digite o {0}° número:", i + 1);
                        aceitouValor = int.TryParse(Console.ReadLine(), out numeros[i]);

                        if (!aceitouValor)
                        {
                            Console.WriteLine("Valor inválido");
                        }
                    }

                    if (i == 0)
                    {
                        maior = numeros[i];
                    }
                    else if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }
                }

                Console.WriteLine("O maior número digitado foi {0} ", maior);
            }

            void Exercicio2()
            {
                int qtdeAlunos = 2, notasSomadas = 0;
                string[] nomes;
                nomes = new string[qtdeAlunos];

                int[] p1;
                p1 = new int[qtdeAlunos];

                int[] p2;
                p2 = new int[qtdeAlunos];

                double[] medias;
                medias = new double[qtdeAlunos];

                for (int ii = 0; ii < qtdeAlunos; ii++)
                {
                    Console.WriteLine("Digite o nome do {0}° aluno: ", ii + 1);
                    nomes[ii] = Console.ReadLine();

                    bool aceitouValor = false;
                    while (!aceitouValor)
                    {
                        Console.WriteLine("Digite a nota p1 do {0}° aluno: ", ii + 1);
                        aceitouValor = int.TryParse(Console.ReadLine(), out p1[ii]);

                        if (!aceitouValor || p1[ii] < 0 || p1[ii] > 10)
                        {
                            Console.WriteLine("Valor inválido");
                            aceitouValor = false;
                        }
                    }

                    aceitouValor = false;
                    while (!aceitouValor)
                    {
                        Console.WriteLine("Digite a nota p2 do {0}° aluno: ", ii + 1);
                        aceitouValor = int.TryParse(Console.ReadLine(), out p2[ii]);

                        if (!aceitouValor || p2[ii] < 0 || p2[ii] > 10)
                        {
                            Console.WriteLine("Valor inválido");
                            aceitouValor = false;
                        }
                    }

                    notasSomadas = p1[ii] + p2[ii];
                    medias[ii] = notasSomadas / 2.0;  
                }

                for (int ii = 0; ii < qtdeAlunos; ii++)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Aluno: {0}; Nota P1: {1}; Nota P2 {2}; Média: {3} ", nomes[ii], p1[ii], p2[ii], medias[ii]);
                }
            }

            Exercicio2();
           
        }
    }
}
