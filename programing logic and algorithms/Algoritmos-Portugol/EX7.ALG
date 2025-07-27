Algoritmo "EX7"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 23/05/2025
Var
// Seção de Declarações das variáveis 
nomeProduto: caracter
qtdeProduto: inteiro
precoProduto, total, totalDescontado, desconto: real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   escreval("Digite o nome do produto:")
   leia(nomeProduto)
   
   escreval("Digite o preço do produto:")
   leia(precoProduto)
   
   escreval("Digite a quantidade adquirida:")
   leia(qtdeProduto)
   
   total <- qtdeProduto * precoProduto
   
   se (qtdeProduto <= 5) então
      desconto <- 2/100
   senao
        se (qtdeProduto <= 10) então
           desconto <- 3/100
        senao
             desconto <- 5/100
        fimse
   fimse
   
   totalDescontado <- total - (total * desconto)
   
   escreval("------------------------------------")
   escreval("- Total (sem desconto): ", total)
   escreval("- Desconto: ", desconto * 100, "%")
   escreval("- Total (com desconto): ", totalDescontado)
Fimalgoritmo