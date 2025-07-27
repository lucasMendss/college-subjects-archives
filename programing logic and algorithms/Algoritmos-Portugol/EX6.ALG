Algoritmo "Ex6"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 23/05/2025
Var
// Seção de Declarações das variáveis 
num1, num2: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   escreval("Digite o 1º valor:")
   leia(num1)
   
   escreval("Digite o 2º valor:")
   leia(num2)
   
   se (num1 = num2) então
      escreval("Números iguais")
   senao
        se (num1 > num2) então
           escreval("O primeiro número digitado é o maior")
        senao
             escreval ("O segundo número digitado é o maior")
        fimse
   fimse
Fimalgoritmo