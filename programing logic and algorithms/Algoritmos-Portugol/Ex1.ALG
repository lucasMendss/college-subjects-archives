Algoritmo "semnome"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Alberto
// Descri��o   : L� tr�s n�meros inteioros distintos e indica
               // o maior, o do meioe o menor.
// Autor(a)    : Lucas Mendes
// Data atual  : 13/05/2025
Var
// Se��o de Declara��es das vari�veis 
n1, n2, n3: inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
escreval ("Digite o 1� n�mero:")
leia (n1)

escreval ("Digite o 2� n�mero:")
leia (n2)

escreval ("Digite o 3� n�mero:")
leia (n3)

se (n1 > n2) e (n1 > n3) ent�o
   escreval(n1, "(n1) � o maior")
   se (n2 > n3) ent�o
      escreval(n2, "(n2) � o do meio")
      escreval(n3, "(n3) � o menor")
   senao
        escreval(n3, "(n3) � o do meio")
        escreval(n2, "(n2) � o menor")
   fimse
senao
     se (n2 > n1) e (n2 > n3) ent�o
        escreval(n2, "(n2) � o maior")
        se (n1 > n3) ent�o
           escreval(n1, "(n1) � o do meio")
           escreval(n3, "(n3) � o menor")
        senao
             escreval(n3, "(n3) � o do meio")
             escreval(n1, "(n1) � o menor")
        fimse
senao
     escreval(n3, "(n3) � o maior")
     se (n1 > n2) ent�o
        escreval(n1, "(n1) � o do meio")
        escreval(n2, "(n2) � o menor")
     senao
          escreval(n2, "(n2) � o do meio")
          escreval(n1, "(n1) � o menor")
     fimse
     fimse
fimse
Fimalgoritmo