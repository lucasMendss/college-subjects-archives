Algoritmo "Ex1"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 06/06/2025
Var
// Se��o de Declara��es das vari�veis 
  opcao: caractere
  num: inteiro

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
   repita
         escreval("Digite um n�mero")
         leia(num)
         escreval("O dobro de", num, " � ", num*2)
         repita
               escreval("Deseja digitar outro n�mero (s/n)?")
               leia (opcao)
               se (opcao <> "S") e (opcao <> "s") e (opcao <> "N") e (opcao <> "n") ent�o
               
                  escreval("N�o entendi")
               fimse
         ate (opcao = "S") ou (opcao = "s") ou (opcao = "N") ou (opcao = "n")
   at� (opcao <> "s") e (opcao <> "S")
   escreval ("Obrigado")


Fimalgoritmo