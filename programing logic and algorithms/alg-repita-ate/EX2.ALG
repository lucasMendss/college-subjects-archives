Algoritmo "Ex2"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/06/2025
Var
// Seção de Declarações das variáveis 
   num, maior, soma, total: inteiro
   media: real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   total <- 0
   repita
         repita
               escreval("Digite um número (0 para finalizar)")
               leia (num)
               se num < 0 então
                  escreval ("São permitidos apenas números maiores ou iguais a 0")
               fimse
         ate num >= 0
         se num <> 0 então
            se total = 0 então
               maior <- num
            senao
                 se num > maior então
                    maior <- num
                 fimse
            fimse
            total <- total + 1
            soma <- soma + num
         fimse

   ate num = 0
   
   escreval("-----------------------------------")
   escreval("Maior número...............:", maior)
   escreval("Total de números digitados.:",total)
   media <- soma / total
   escreval("Média dos números..........:",media)

Fimalgoritmo