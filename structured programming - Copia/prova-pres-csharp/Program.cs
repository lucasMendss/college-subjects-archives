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
            void Ex1()
            {
                double precoProduto; 
                int codigoProduto;

                Console.WriteLine("Digite o preço (em R$) do produto:");
                precoProduto = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o código de origem do produto:");
                codigoProduto = int.Parse(Console.ReadLine());

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Preço do produto: R${0}", precoProduto);

                if (codigoProduto <= 0 || codigoProduto >= 27)
                    Console.WriteLine("Procedência desconhecida.");
                else if (precoProduto <= 7)
                    Console.WriteLine("Procedência: Região Norte.");
                else if (precoProduto <= 16 )
                    Console.WriteLine("Procedência: Região Nordeste.");
                else if (precoProduto <= 19)
                    Console.WriteLine("Procedência: Região Centro-Oeste.");
                else if (precoProduto <= 23)
                    Console.WriteLine("Procedência: Região Sudeste.");
                else 
                    Console.WriteLine("Procedência: Região Sul.");
            }

            void Ex2()
            {
                double salario = 0, aliq = 0, impostoBrt = 0, deducao = 0, impostoR = 0;
                
                while(salario <= 0)
                {
                    Console.WriteLine("Digite seu salário em R$:");
                    salario = double.Parse(Console.ReadLine());
                }

                if (salario <= 2428.80)
                {
                    aliq = 0;
                    deducao = 0;
                }
                else if (salario <= 2826.65)
                {
                    aliq = 7.5;
                    deducao = 182.16;
                }
                else if (salario <= 3751.05)
                {
                    aliq = 15;
                    deducao = 394.16;
                }
                else if (salario <= 4664.68)
                {
                    aliq = 22.5;
                    deducao = 675.49;
                }
                else
                {
                    aliq = 27.5;
                    deducao = 908.73;
                }

                impostoBrt = salario * (aliq / 100);
                impostoR = impostoBrt - deducao;

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Salário Informado: R${0}", salario);
                Console.WriteLine("Alíquota.........: {0}%", aliq);
                Console.WriteLine("Imposto Bruto....: R${0}", impostoBrt);
                Console.WriteLine("Dedução..........: R${0}", deducao);
                Console.WriteLine("Imposto a Pagar..: R${0}", impostoR);

            }

            void Ex3() {
                double mediaP = 0, frequencia = 0;
                string conceito;

                string[] titulosDados = new string[4] {"Nota do 1º Bimestre", "Nota do 2º Bimestre", "Total de aulas dadas", "Total de faltas"};
                double[] dados = new double[4];

                for (int ii = 0;  ii < titulosDados.Length; ii++)
                {
                    Console.WriteLine("Digite: {0}", titulosDados[ii]);
                    dados[ii] = double.Parse(Console.ReadLine());   
                }

                mediaP = (dados[0] + dados[1]*2) / 3;
                frequencia = ((dados[2] - dados[3]) * 100) / dados[2];

                if (frequencia < 75)
                    conceito = "REPROVADO";
                else if (mediaP < 4)
                    conceito = "REPROVADO";
                else if (frequencia < 6)
                    conceito = "IFA";
                else
                    conceito = "APROVADO";

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Situação do aluno.....:");
                Console.WriteLine("- Nota do 1º Bimestre.: {0}", dados[0]);
                Console.WriteLine("- Nota do 2º Bimestre.: {0}", dados[1]);
                Console.WriteLine("- Total de aulas dadas: {0}", dados[2]);
                Console.WriteLine("- Total de faltas.....: {0}", dados[3]);
                Console.WriteLine("- Média Ponderada.....: {0}", mediaP.ToString("N2"));
                Console.WriteLine("- Frequência..........: {0}%", frequencia);
                Console.WriteLine("- Conceito............: {0}", conceito);

            }
            //Ex1();
            Ex2();
            //Ex3();
        }
    }
}
