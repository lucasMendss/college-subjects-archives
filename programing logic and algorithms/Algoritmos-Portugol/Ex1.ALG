Algoritmo "semnome"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Alberto
// Descrição   : Lê três números inteioros distintos e indica
               // o maior, o do meioe o menor.
// Autor(a)    : Lucas Mendes
// Data atual  : 13/05/2025
Var
// Seção de Declarações das variáveis 
n1, n2, n3: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreval ("Digite o 1º número:")
leia (n1)

escreval ("Digite o 2º número:")
leia (n2)

escreval ("Digite o 3º número:")
leia (n3)

se (n1 > n2) e (n1 > n3) então
   escreval(n1, "(n1) é o maior")
   se (n2 > n3) então
      escreval(n2, "(n2) é o do meio")
      escreval(n3, "(n3) é o menor")
   senao
        escreval(n3, "(n3) é o do meio")
        escreval(n2, "(n2) é o menor")
   fimse
senao
     se (n2 > n1) e (n2 > n3) então
        escreval(n2, "(n2) é o maior")
        se (n1 > n3) então
           escreval(n1, "(n1) é o do meio")
           escreval(n3, "(n3) é o menor")
        senao
             escreval(n3, "(n3) é o do meio")
             escreval(n1, "(n1) é o menor")
        fimse
senao
     escreval(n3, "(n3) é o maior")
     se (n1 > n2) então
        escreval(n1, "(n1) é o do meio")
        escreval(n2, "(n2) é o menor")
     senao
          escreval(n2, "(n2) é o do meio")
          escreval(n1, "(n1) é o menor")
     fimse
     fimse
fimse
Fimalgoritmo