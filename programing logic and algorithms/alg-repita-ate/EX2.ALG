Algoritmo "Ex2"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/06/2025
Var
// Se��o de Declara��es das vari�veis 
   num, maior, soma, total: inteiro
   media: real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   total <- 0
   repita
         repita
               escreval("Digite um n�mero (0 para finalizar)")
               leia (num)
               se num < 0 ent�o
                  escreval ("S�o permitidos apenas n�meros maiores ou iguais a 0")
               fimse
         ate num >= 0
         se num <> 0 ent�o
            se total = 0 ent�o
               maior <- num
            senao
                 se num > maior ent�o
                    maior <- num
                 fimse
            fimse
            total <- total + 1
            soma <- soma + num
         fimse

   ate num = 0
   
   escreval("-----------------------------------")
   escreval("Maior n�mero...............:", maior)
   escreval("Total de n�meros digitados.:",total)
   media <- soma / total
   escreval("M�dia dos n�meros..........:",media)

Fimalgoritmo