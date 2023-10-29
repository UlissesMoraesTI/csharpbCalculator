using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int opcao = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("#----------------------#");
                Console.WriteLine("#   Menu Calculadora   #");
                Console.WriteLine("#----------------------#");
                Console.WriteLine("[1] Soma               #");
                Console.WriteLine("[2] Subtração          #");
                Console.WriteLine("[3] Divisão            #");
                Console.WriteLine("[4] Multiplicação      #");
                Console.WriteLine("#----------------------#");
                Console.WriteLine("[9] Encerrar Aplicação #");
                Console.WriteLine("#----------------------#");

                Console.WriteLine("Informe a opção desejada:");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break;
                    case 9:
                        EncerrarAplicacao(); break;
                    default: OpcaoInvalida(); break;
                }

            } while (opcao != 9);
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Informe o 1º Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"Soma: {resultado}");
            Console.ReadKey();
            // Console.WriteLine("Soma: " + resultado + ".");
            // Console.WriteLine("Soma: " + (v1 + v2));
            // Console.WriteLine($"Soma:  {v1 + v2} Com Interpolação no Cálculo.");
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Informe o 1º Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"Subtração: {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Informe o 1º Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"Divisão: {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Informe o 1º Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"Multiplicação: {resultado}");
            Console.ReadKey();
        }

        static void EncerrarAplicacao()
        {
            Console.Clear();
            Console.WriteLine("Aplicação encerrada com sucesso!");
            Console.ReadKey();
            Console.Clear();
            System.Environment.Exit(0);
        }

        static void OpcaoInvalida()
        {
            Console.Clear();
            Console.WriteLine("Opção Inválida!");
            Console.WriteLine("Opção Digite Novamente!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}