Algoritmo "Ex6"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 23/05/2025
Var
// Se��o de Declara��es das vari�veis 
num1, num2: inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   escreval("Digite o 1� valor:")
   leia(num1)
   
   escreval("Digite o 2� valor:")
   leia(num2)
   
   se (num1 = num2) ent�o
      escreval("N�meros iguais")
   senao
        se (num1 > num2) ent�o
           escreval("O primeiro n�mero digitado � o maior")
        senao
             escreval ("O segundo n�mero digitado � o maior")
        fimse
   fimse
Fimalgoritmo