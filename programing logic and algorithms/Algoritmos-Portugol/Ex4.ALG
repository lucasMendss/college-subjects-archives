Algoritmo "Ex4"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/05/2025
Var
// Se��o de Declara��es das vari�veis 
preco, precoDescontado, desconto, juros: real
escolhaPagamento: caracter

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
escreval("Digite o pre�o em R$ do produto que ir� comprar:")
leia(preco)

escreval("Escolha um m�todo de pagamento:")
escreval("-------------------------------")
escreval(" - Digite 1 para pagar � vista ou em cheque (10% de desconto)")
escreval(" - Digite 2 para pagar � vista no cart�o de cr�dito (15% de desconto)")
escreval(" - Digite 3 para pagar em 2 vezes (sem desconto)")
escreval(" - Digite 4 para pagar em 2 vezes (com 10% de juros")

leia(escolhaPagamento)

se (escolhaPagamento = "1") ent�o
   desconto <- 10
   precoDescontado <- preco - (preco * (desconto/100))
   escreval("Total a pagar: R$", precoDescontado)
senao
     se (escolhaPagamento = "2") ent�o
        desconto <- 15
        precoDescontado <- preco - (preco * (desconto/100))
        escreval("Total a pagar: R$", precoDescontado)
     senao
          se (escolhaPagamento = "3") ent�o
             escreval("Total a pagar: R$", preco)
          senao
               se (escolhaPagamento = "4") ent�o
                  juros <- 10
                  precoDescontado <- preco + (preco * (juros/100))
                  escreval("Total a pagar: R$", precoDescontado)
               fimse
          fimse
     fimse
fimse
Fimalgoritmo