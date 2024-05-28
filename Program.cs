using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação:[ +, -, *, / ]");
            string operacao = Console.ReadLine().ToLower();
            Console.WriteLine("Primero numero: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());
            Operacao(operacao, n1, n2);
            Console.ReadKey();

        }
        static void Operacao (string operacao, double v1, double v2)
        {
            switch (operacao)
            {
                case "+":
                    double soma = v1 + v2;
                    Console.WriteLine(soma);
                    break;
                case "-":
                    double menos = v1 + v2;
                    Console.WriteLine(menos);
                    break;

                case "/":
                    double div = v1 + v2;
                    Console.WriteLine(div);
                    break;

                case "*":
                    double multi = v1 + v2;
                    Console.WriteLine(multi);
                    break;

            }

        }
        
    }
}
