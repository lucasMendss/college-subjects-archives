Algoritmo "Ex3"
// Disciplina  :  [Linguagem e Lógica de Programação] 
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 13/05/2025
Var
// Seção de Declarações das variáveis 
peso, altura, imc: real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
escreval("Digite sua altura (em m):")
leia(altura)

escreval("Digite seu peso (em kg):")
leia(peso)

imc <- peso / (altura * altura)

se (imc < 18.5) então
   escreval("Abaixo do peso")
senao
     se (imc < 25) então
        escreval("Peso normal")
     senao
          se (imc < 30) então
             escreval("Acima do peso")
          senao
               escreval("Gordolas")
          fimse
     fimse
fimse
Fimalgoritmo