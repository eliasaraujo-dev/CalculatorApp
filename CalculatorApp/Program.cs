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
            while (true) 
            {
                Console.Write("\nDigite o primeiro número (ou 'sair' para encerrar): ");
                string input1 = Console.ReadLine(); 

                if (input1.ToLower() == "sair")
                    break;

                if (!double.TryParse(input1, out double num1))
                {
                    Console.WriteLine("Entrada inválida! Digite um número válido.");
                    continue; 
                }

                Console.Write("Digite o operador (+, -, *, /, ^, %): ");
                char operador = Console.ReadKey().KeyChar; 
                Console.WriteLine(); 

                Console.Write("Digite o segundo número: ");
                string input2 = Console.ReadLine();

                if (!double.TryParse(input2, out double num2))
                {
                    Console.WriteLine("Entrada inválida! Digite um número válido.");
                    continue; 
                }

                double resultado = 0; 
                bool operacaoValida = true; 

                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2; 
                        break;
                    case '-':
                        resultado = num1 - num2; 
                        break;
                    case '*':
                        resultado = num1 * num2; 
                        break;
                    case '/':
                        if (num2 != 0) 
                            resultado = num1 / num2; 
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero!");
                            operacaoValida = false; 
                        }
                        break;
                    case '^':
                        resultado = Math.Pow(num1, num2); 
                        break;
                    case '%':
                        resultado = num1 % num2; 
                        break;
                    default:
                        Console.WriteLine("Operador inválido!"); 
                        operacaoValida = false;
                        break;
                }

                if (operacaoValida)
                    Console.WriteLine($"Resultado: {resultado}");
            }

            Console.WriteLine("Calculadora encerrada.");
        }
    }
}
