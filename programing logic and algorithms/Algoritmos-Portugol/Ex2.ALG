Algoritmo "Ex2"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/05/2025
Var
// Se��o de Declara��es das vari�veis 
nConta: caracter
saldoAtual, saldo, credito, debito: real

Inicio
   // Se��o de Comandos, procedimento, fun��es, operadores, etc...
   escreval("Digite o n�mero da conta:")
   leia(nConta)

   escreval("Digite seu saldo:")
   leia(saldo)

   escreval("Digite sua quantia de cr�dito:")
   leia(credito)

   escreval("Digite sua quantia de d�bito:")
   leia(debito)

   saldoAtual <- saldo - debito + credito

   escreval("Saldo atual da conta ", nConta, ": ", saldoAtual)

   se (saldoAtual > 0) ent�o
      escreval("- Saldo positivo.")
   senao
        se (saldoAtual < 0) ent�o
           escreval("- Saldo negativo.")
        senao
             escreval("- Saldo nulo.")
        fimse
   fimse
Fimalgoritmo