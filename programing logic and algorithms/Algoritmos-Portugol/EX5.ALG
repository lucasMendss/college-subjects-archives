Algoritmo "Ex5"
// Disciplina   : [Linguagem e L�gica de Programa��o]
// Professor   : Antonio Carlos Nicolodi 
// Descri��o   : Aqui voc� descreve o que o programa faz! (fun��o)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 23/05/2025
Var
// Se��o de Declara��es das vari�veis 
idAluno, conceito, situacao: caracter
nota1, nota2, nota3, mediaNormal, mediaAproveitamento: real

Inicio
// Se��o de Comandos, procedimento, fun��es, operadores, etc...
   escreval("Digite o n�mero de identifica��o do aluno:")
   leia(idAluno)

   escreval("Digite a 1� nota  do aluno:")
   leia(nota1)

   escreval("Digite a 2� nota do aluno:")
   leia(nota2)

   escreval("Digite a 3� nota do aluno:")
   leia(nota3)

   mediaNormal <- (nota1 + nota2 + nota3) / 3
   mediaAproveitamento <- (nota1 + nota2 * 2 + nota3 * 3 + mediaNormal)/7

   se (mediaAproveitamento < 40) ent�o
      conceito <- "E"
      situacao <- "Reprovado"
   senao
        se (mediaAproveitamento < 60) ent�o
           conceito <- "D"
           situacao <- "Reprovado"
        senao
             se (mediaAproveitamento < 75) ent�o
                conceito <- "C"
                situacao <- "Aprovado"
             senao
                  se (mediaAproveitamento < 90) ent�o
                     conceito <- "B"
                     situacao <- "Aprovado"
                  senao
                       conceito <- "A"
                       situacao <- "Aprovado"
                  fimse
             fimse
        fimse
   fimse

   escreval("---------------------------")
   escreval("Aluno ", idAluno)
   escreval("- Avalia��o 1: ", nota1, " | Avalia��o 2: ", nota2, " | Avalia��o 3: ", nota3)
   escreval("- M�dia aritm�tica: ", mediaNormal)
   escreval("- M�dia de aproveitamento: ", mediaAproveitamento)
   escreval("- Conceito: ", conceito)
   escreval("- Situa��o: ", situacao)
Fimalgoritmo