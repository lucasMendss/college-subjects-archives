Algoritmo "Ex3"
// Disciplina  :  [Linguagem e L�gica de Programa��o] 
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/05/2025
Var
// Se��o de Declara��es das vari�veis 
peso, altura, imc: real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc... 
escreval("Digite sua altura (em m):")
leia(altura)

escreval("Digite seu peso (em kg):")
leia(peso)

imc <- peso / (altura * altura)

se (imc < 18.5) ent�o
   escreval("Abaixo do peso")
senao
     se (imc < 25) ent�o
        escreval("Peso normal")
     senao
          se (imc < 30) ent�o
             escreval("Acima do peso")
          senao
               escreval("Gordolas")
          fimse
     fimse
fimse
Fimalgoritmo