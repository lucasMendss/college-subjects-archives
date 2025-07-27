Algoritmo "Ex2"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/05/2025
Var
// Seção de Declarações das variáveis 
nConta: caracter
saldoAtual, saldo, credito, debito: real

Inicio
   // Seção de Comandos, procedimento, funções, operadores, etc...
   escreval("Digite o número da conta:")
   leia(nConta)

   escreval("Digite seu saldo:")
   leia(saldo)

   escreval("Digite sua quantia de crédito:")
   leia(credito)

   escreval("Digite sua quantia de débito:")
   leia(debito)

   saldoAtual <- saldo - debito + credito

   escreval("Saldo atual da conta ", nConta, ": ", saldoAtual)

   se (saldoAtual > 0) então
      escreval("- Saldo positivo.")
   senao
        se (saldoAtual < 0) então
           escreval("- Saldo negativo.")
        senao
             escreval("- Saldo nulo.")
        fimse
   fimse
Fimalgoritmo