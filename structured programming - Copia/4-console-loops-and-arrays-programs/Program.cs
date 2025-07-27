internal class Program
{
    private static void Main(string[] args)
    {
        void Ex1()
        {
            int idade = 0, qtdePessoas = 0, qtdeFx1 = 0, qtdeFx2 = 0, qtdeFx3 = 0, qtdeFx4 = 0, qtdeFx5 = 0;
            bool validouInput = false;

            while (!validouInput)
            {
                Console.WriteLine("Você quer digitar a iadade de quantas pessoas?(Máx: 20)");
                validouInput = int.TryParse(Console.ReadLine(), out qtdePessoas);

                if (!validouInput || qtdePessoas < 0 || qtdePessoas > 20)
                {
                    Console.WriteLine("Opção inválida. Digite novamente!");
                    validouInput = false;
                }
            }

            for (int ii = 1; ii <= qtdePessoas; ii++)
            {
                validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Digite a idade da {0}ª pessoa:", ii);
                    validouInput = int.TryParse(Console.ReadLine(), out idade);

                    if (!validouInput || idade < 0)
                    {
                        Console.WriteLine("Idade inválida. Digite novamente!");
                        validouInput = false;
                    }
                }

                if (idade <= 15)
                    qtdeFx1++;
                else if (idade <= 30)
                    qtdeFx2++;
                else if (idade <= 45)
                    qtdeFx3++;
                else if (idade <= 60)
                    qtdeFx4++;
                else
                    qtdeFx5++;
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Dados:");
            Console.WriteLine("- 0 a 15 anos: {0} pessoas ({1}%)", qtdeFx1, (qtdeFx1 * 100) / qtdePessoas);
            Console.WriteLine("- 16 a 30 anos: {0} pessoas ({1}%)", qtdeFx2, (qtdeFx2 * 100) / qtdePessoas);
            Console.WriteLine("- 31 a 45 anos: {0} pessoas ({1}%)", qtdeFx3, (qtdeFx3 * 100) / qtdePessoas);
            Console.WriteLine("- 46 a 60 anos: {0} pessoas ({1}%)", qtdeFx4, (qtdeFx4 * 100) / qtdePessoas);
            Console.WriteLine("- 61 ou mais anos: {0} pessoas ({1}%)", qtdeFx5, (qtdeFx5 * 100) / qtdePessoas);

        }

        void Ex2()
        {
            char codigoTransacao = '-';
            double valor = 0, valorAVista = 0, valorParcel = 0, valorTotal = 0;

            do
            {
                bool validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Informe o tipo de transação: \n ('v': à vista | 'p': a prazo | 'f': finalizar processo)");
                    validouInput = char.TryParse(Console.ReadLine(), out codigoTransacao);

                    if (!validouInput || (codigoTransacao != 'v' && codigoTransacao != 'p' && codigoTransacao != 'f'))
                    {
                        Console.WriteLine("Opção inválida. Digite novamente.");
                        validouInput = false;
                    }
                }

                if (codigoTransacao != 'f')
                {
                    validouInput = false;
                    while (!validouInput)
                    {
                        Console.WriteLine("Informe o valor em R$ da venda:");
                        validouInput = double.TryParse(Console.ReadLine(), out valor);

                        if (!validouInput || valor < 0)
                        {
                            Console.WriteLine("Valor inválido. Digite novamente.");
                            validouInput = false;
                        }
                    }

                    if (codigoTransacao == 'v')
                        valorAVista += valor;
                    else
                        valorParcel += valor;
                }

            } while (codigoTransacao != 'f');

            valorTotal = valorAVista + valorParcel;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Valor total de compras à vista.....................: R${0}", valorAVista.ToString("N2"));
            Console.WriteLine("Valor total de compras à prazo.....................: R${0}", valorParcel.ToString("N2"));
            Console.WriteLine("  |_ Valor total de cada parcela...................: R${0}", (valorParcel / 3).ToString("N2"));
            Console.WriteLine("Valor total de compras (vista + prazo).............: R${0}", valorTotal.ToString("N2"));
        }

        void Ex3()
        {
            int[] nums = new int[15];

            for (int ii = 0; ii < nums.Length; ii++)
            {
                bool validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Digite o {0}º número:", ii + 1);
                    validouInput = int.TryParse(Console.ReadLine(), out nums[ii]);

                    if (!validouInput)
                    {
                        Console.WriteLine("Digite apenas números!");
                    }
                }
            }

            Console.Write("\nNúmeros pares: ");
            for (int ii = 0; ii < nums.Length; ii++)
            {
                if (nums[ii] % 2 == 0)
                {
                    Console.Write(nums[ii] + "; ");
                }
            }

            Console.Write("\nNúmeros ímpares: ");
            for (int ii = 0; ii < nums.Length; ii++)
            {
                if (nums[ii] % 2 != 0)
                {
                    Console.Write(nums[ii] + "; ");
                }
            }
        }

        void Ex4()
        {
            double[] p1 = new double[10];
            double[] p2 = new double[10];
            double mediasSomadas = 0;
            int qtdeAprovados = 0, qtdeReprovados = 0;

            for (int ii = 0; ii < p1.Length; ii++)
            {
                bool validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Digite a nota P1 do {0}º aluno:", ii + 1);
                    validouInput = double.TryParse(Console.ReadLine(), out p1[ii]);

                    if (!validouInput || p1[ii] < 0 || p1[ii] > 10)
                    {
                        Console.WriteLine("Nota inválida. Digite novamente!");
                        validouInput = false;
                    }
                }
            }

            for (int ii = 0; ii < p2.Length; ii++)
            {
                bool validouInput = false;
                while (!validouInput)
                {
                    Console.WriteLine("Digite a nota P2 do {0}º aluno:", ii + 1);
                    validouInput = double.TryParse(Console.ReadLine(), out p2[ii]);

                    if (!validouInput || p2[ii] < 0 || p2[ii] > 10)
                    {
                        Console.WriteLine("Nota inválida. Digite novamente!");
                        validouInput = false;
                    }
                }
            }

            Console.WriteLine("------------------------------------------");
            for (int ii = 0; ii < p1.Length; ii++)
            {
                double media = ((p1[ii] + p2[ii]) / 2);
                Console.WriteLine("- Aluno {0}: P1: {1} | P2: {2} | Média: {3}", ii + 1, p1[ii], p2[ii], media);
                mediasSomadas = mediasSomadas + media;

                if (media < 6)
                    qtdeReprovados++;
                else
                    qtdeAprovados++;
            }
            Console.WriteLine("- Média da classe: {0}", mediasSomadas / p1.Length);
            Console.WriteLine("- Quant. de alunos APROVADOS: {0}", qtdeAprovados);
            Console.WriteLine("- Quant. de alunos REPROVADOS: {0}", qtdeReprovados);
        }

        int escolha;
        Console.WriteLine("-------------------------------------------------");
        do
        {
            Console.WriteLine("Escolha o exercício a ser executado (1 ao 4):");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("-----------------------\n");
                    Ex1();
                    break;
                case 2:
                    Console.WriteLine("-----------------------\n");
                    Ex2();
                    break;
                case 3:
                    Console.WriteLine("-----------------------\n");
                    Ex3();
                    break;
                case 4:
                    Console.WriteLine("-----------------------\n");
                    Ex4();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite de novo!");
                    break;
            }
        } while (escolha < 1 || escolha > 4);
    }
}
