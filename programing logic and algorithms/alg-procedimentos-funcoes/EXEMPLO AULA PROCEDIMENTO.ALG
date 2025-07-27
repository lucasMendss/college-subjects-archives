Algoritmo "EXEMPLO AULA PROCEDIMENTO"
// Procedimento: não retorna valor; pode ter parâmetros
// Função: retorna algum valor; pode ter parâmetros

Var
   // Seção de Declarações das variáveis
   num1, num2, opcao: inteiro

função adiciona(x, y: inteiro): inteiro
Var
   soma: inteiro

Inicio
   soma <- x + y
   retorne soma
fimfunção

procedimento subtrai(x, y: inteiro)
Var
   subtracao: inteiro

Inicio
   subtracao <- x - y
   escreval(x, " - ", y, " = ", subtracao)
fimprocedimento

procedimento multiplica(x, y: inteiro)
Var
   mult: inteiro

Inicio
   mult <- x * y
   escreval(x, " x ", y, " = ", mult)
fimprocedimento

procedimento divide(x, y: inteiro)
Var
   divi: real

Inicio
   divi <- x / y
   escreval(x, " / ", y, " = ", divi)
fimprocedimento

Inicio
   // Seção de Comandos, procedimento, funções, operadores, etc...
   escreval("Digite o 1º número:")
   leia(num1)

   escreval("Digite o 2º número:")
   leia(num2)

   repita
      escreval("----------------------------------")
      escreval("Escolha a operação:")
      escreval("- 1: somar")
      escreval("- 2: subtrair")
      escreval("- 3: multiplicar")
      escreval("- 4: dividir")
      escreval("- 5: finalizar programa")
      leia(opcao)

      se opcao = 1 então
         //função:
         escreval(num1, " + ", num2, " = ", adiciona(num1, num2))
      senao
         se opcao = 2 então
            //procedimento:
            subtrai(num1, num2)
         senao
            se opcao = 3 então
               //procedimento:
               multiplica(num1, num2)
            senao
               se opcao = 4 então
                  //procedimento:
                  divide(num1, num2)
               fimse
            fimse
         fimse
      fimse
   ate opcao = 5
Fimalgoritmo
