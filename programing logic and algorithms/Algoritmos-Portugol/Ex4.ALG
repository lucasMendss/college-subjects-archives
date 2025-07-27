Algoritmo "Ex4"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/05/2025
Var
// Seção de Declarações das variáveis 
preco, precoDescontado, desconto, juros: real
escolhaPagamento: caracter

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreval("Digite o preço em R$ do produto que irá comprar:")
leia(preco)

escreval("Escolha um método de pagamento:")
escreval("-------------------------------")
escreval(" - Digite 1 para pagar à vista ou em cheque (10% de desconto)")
escreval(" - Digite 2 para pagar à vista no cartão de crédito (15% de desconto)")
escreval(" - Digite 3 para pagar em 2 vezes (sem desconto)")
escreval(" - Digite 4 para pagar em 2 vezes (com 10% de juros")

leia(escolhaPagamento)

se (escolhaPagamento = "1") então
   desconto <- 10
   precoDescontado <- preco - (preco * (desconto/100))
   escreval("Total a pagar: R$", precoDescontado)
senao
     se (escolhaPagamento = "2") então
        desconto <- 15
        precoDescontado <- preco - (preco * (desconto/100))
        escreval("Total a pagar: R$", precoDescontado)
     senao
          se (escolhaPagamento = "3") então
             escreval("Total a pagar: R$", preco)
          senao
               se (escolhaPagamento = "4") então
                  juros <- 10
                  precoDescontado <- preco + (preco * (juros/100))
                  escreval("Total a pagar: R$", precoDescontado)
               fimse
          fimse
     fimse
fimse
Fimalgoritmo