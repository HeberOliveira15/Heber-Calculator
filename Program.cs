using System;

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

            Console.WriteLine("O que deseja fazer nesse momento?");
            Console.WriteLine("Opção 1 = Soma.");
            Console.WriteLine("Opção 2 = Subtração.");
            Console.WriteLine("Opção 3 = Divisão.");
            Console.WriteLine("Opção 4 = Multiplicação.");
            Console.WriteLine("Sair = 0");

            Console.WriteLine("-------------");
            Console.WriteLine("Selecione uma opção");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {

                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: divisao(); break;
                case 4: Multiplicacao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }





        }
        static void Soma()
        {

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 + v2;
            Console.WriteLine("");


            Console.WriteLine("O resultado da soma é:" + resultado);

            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            float subtracao = v1 - v2;
            Console.WriteLine($"O resultado é {subtracao}");
            Console.ReadKey();
            Menu();
        }
        static void divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            Console.WriteLine("");


            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado é:{resultado}");
            Console.ReadKey();
            Menu();


        }
    }
}
