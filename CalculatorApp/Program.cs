using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop infinito para permitir múltiplos cálculos
            {
                // Solicita o primeiro número ao usuário
                Console.Write("\nDigite o primeiro número (ou 'sair' para encerrar): ");
                string input1 = Console.ReadLine(); // Lê a entrada do usuário

                // Se o usuário digitar "sair", o programa é encerrado
                if (input1.ToLower() == "sair")
                    break;

                // Tenta converter a entrada para um número. Se falhar, pede novamente
                if (!double.TryParse(input1, out double num1))
                {
                    Console.WriteLine("Entrada inválida! Digite um número válido.");
                    continue; // Volta ao início do loop para tentar novamente
                }

                // Solicita o operador matemático ao usuário
                Console.Write("Digite o operador (+, -, *, /, ^, %): ");
                char operador = Console.ReadKey().KeyChar; // Lê um único caractere sem precisar pressionar Enter
                Console.WriteLine(); // Pula linha para manter a formatação do console

                // Solicita o segundo número ao usuário
                Console.Write("Digite o segundo número: ");
                string input2 = Console.ReadLine();

                // Tenta converter a entrada para um número. Se falhar, pede novamente
                if (!double.TryParse(input2, out double num2))
                {
                    Console.WriteLine("Entrada inválida! Digite um número válido.");
                    continue; // Volta ao início do loop para tentar novamente
                }

                double resultado = 0; // Variável que armazenará o resultado do cálculo
                bool operacaoValida = true; // Variável para verificar se a operação foi válida

                // Estrutura de decisão para determinar a operação matemática
                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2; // Soma
                        break;
                    case '-':
                        resultado = num1 - num2; // Subtração
                        break;
                    case '*':
                        resultado = num1 * num2; // Multiplicação
                        break;
                    case '/':
                        if (num2 != 0) // Evita divisão por zero
                            resultado = num1 / num2; // Divisão
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero!");
                            operacaoValida = false; // Marca operação como valida
                        }
                        break;
                    case '^':
                        resultado = Math.Pow(num1, num2); // Potência (num1 elevado a num2)
                        break;
                    case '%':
                        resultado = num1 % num2; // Módulo (resto da divisão)
                        break;
                    default:
                        Console.WriteLine("Operador inválido!"); // Se o operador não for reconhecido
                        operacaoValida = false;
                        break;
                }

                // Se a operação foi válida, exibe o resultado
                if (operacaoValida)
                    Console.WriteLine($"Resultado: {resultado}");
            }

            // Mensagem de encerramento quando o usuário sai da calculadora
            Console.WriteLine("Calculadora encerrada.");
        }
    }
}
