Algoritmo "Ex1"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/06/2025
Var
// Seção de Declarações das variáveis 
  opcao: caractere
  num: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   repita
         escreval("Digite um número")
         leia(num)
         escreval("O dobro de", num, " é ", num*2)
         repita
               escreval("Deseja digitar outro número (s/n)?")
               leia (opcao)
               se (opcao <> "S") e (opcao <> "s") e (opcao <> "N") e (opcao <> "n") então
               
                  escreval("Não entendi")
               fimse
         ate (opcao = "S") ou (opcao = "s") ou (opcao = "N") ou (opcao = "n")
   até (opcao <> "s") e (opcao <> "S")
   escreval ("Obrigado")


Fimalgoritmo