Algoritmo "Ex5"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 23/05/2025
Var
// Seção de Declarações das variáveis 
idAluno, conceito, situacao: caracter
nota1, nota2, nota3, mediaNormal, mediaAproveitamento: real

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
   escreval("Digite o número de identificação do aluno:")
   leia(idAluno)

   escreval("Digite a 1ª nota  do aluno:")
   leia(nota1)

   escreval("Digite a 2ª nota do aluno:")
   leia(nota2)

   escreval("Digite a 3ª nota do aluno:")
   leia(nota3)

   mediaNormal <- (nota1 + nota2 + nota3) / 3
   mediaAproveitamento <- (nota1 + nota2 * 2 + nota3 * 3 + mediaNormal)/7

   se (mediaAproveitamento < 40) então
      conceito <- "E"
      situacao <- "Reprovado"
   senao
        se (mediaAproveitamento < 60) então
           conceito <- "D"
           situacao <- "Reprovado"
        senao
             se (mediaAproveitamento < 75) então
                conceito <- "C"
                situacao <- "Aprovado"
             senao
                  se (mediaAproveitamento < 90) então
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
   escreval("- Avaliação 1: ", nota1, " | Avaliação 2: ", nota2, " | Avaliação 3: ", nota3)
   escreval("- Média aritmética: ", mediaNormal)
   escreval("- Média de aproveitamento: ", mediaAproveitamento)
   escreval("- Conceito: ", conceito)
   escreval("- Situação: ", situacao)
Fimalgoritmo