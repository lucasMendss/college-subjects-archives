Algoritmo "EX7"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 23/05/2025
Var
// Se��o de Declara��es das vari�veis 
nomeProduto: caracter
qtdeProduto: inteiro
precoProduto, total, totalDescontado, desconto: real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   escreval("Digite o nome do produto:")
   leia(nomeProduto)
   
   escreval("Digite o pre�o do produto:")
   leia(precoProduto)
   
   escreval("Digite a quantidade adquirida:")
   leia(qtdeProduto)
   
   total <- qtdeProduto * precoProduto
   
   se (qtdeProduto <= 5) ent�o
      desconto <- 2/100
   senao
        se (qtdeProduto <= 10) ent�o
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